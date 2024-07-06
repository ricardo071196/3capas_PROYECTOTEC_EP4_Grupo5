using ProyClinicOdonto_BE;
using ProyClinicOdonto_BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyClinicOdonto_GUI
{
    public partial class ReservaMan2 : Form
    {
        ReservaBL objReservaBL = new ReservaBL();
        ReservaBE objReservaBE = new ReservaBE();
        OdontologosListaBL objOdontologosListaBL = new OdontologosListaBL();
        ConsultorioListaBL objConsultorioListaBL = new ConsultorioListaBL();

        public ReservaMan2()
        {
            InitializeComponent();
        }
        private void btnGrabar_Click(object sender, EventArgs e)
        {
            try
            {
                bool activo = chkActivo.Checked;

                DateTime fechaIng = dtpFechaReser.Value;

                if (mskPACIENTE.Text.Trim() == String.Empty)
                {
                    throw new Exception("Ingresa un DNI por favor");
                }

                if (txtHORA.Text.Trim() == String.Empty)
                {
                    throw new Exception("Ingresa una hora por favor");
                }

                if (txtDetalle.Text.Trim() == String.Empty)
                {
                    throw new Exception("Ingresa un detalle por favor");
                }

                objReservaBE.idpaciente = mskPACIENTE.Text;
                objReservaBE.idodontologo = cboOdontologos.SelectedValue.ToString();
                objReservaBE.HoraCita = txtHORA.Text;
                objReservaBE.detalle = txtDetalle.Text;
                objReservaBE.id_consultorio = cboConsultorio.SelectedValue.ToString();
                objReservaBE.Estado = activo;
                objReservaBE.diaCita = fechaIng;

                if (objReservaBL.InsertarReserva(objReservaBE))
                {
                    MessageBox.Show("Reserva realizada exitosamente");
                    this.Close();
                }
                else
                {
                    throw new Exception("Disculpa la molestia, trabajaremos para mejorar nuestro sistema.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ReservaMan2_Load(object sender, EventArgs e)
        {
            try
            {
                dtpFechaReser.ValueChanged += dateTimePicker1_ValueChanged;
                txtHORA.TextChanged += txtHORA_TextChanged;

                DataTable dtConsultorios = objConsultorioListaBL.ConsultorioLista();
                DataRow drConsultorio = dtConsultorios.NewRow();
                drConsultorio["id_consultorio"] = 0;
                drConsultorio["nombre"] = "--Seleccione--";
                dtConsultorios.Rows.InsertAt(drConsultorio, 0);
                cboConsultorio.DataSource = dtConsultorios;
                cboConsultorio.DisplayMember = "nombre";
                cboConsultorio.ValueMember = "id_consultorio";

                // Cargar odontólogos disponibles inicialmente
                LoadOdontologosByDayAndHour(dtpFechaReser.Value.DayOfWeek, txtHORA.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            LoadOdontologosByDayAndHour(dtpFechaReser.Value.DayOfWeek, txtHORA.Text);
        }

        private void txtHORA_TextChanged(object sender, EventArgs e)
        {
            LoadOdontologosByDayAndHour(dtpFechaReser.Value.DayOfWeek, txtHORA.Text);
        }

        private void LoadOdontologosByDayAndHour(DayOfWeek dayOfWeek, string hora)
        {
            string column = dayOfWeek switch
            {
                DayOfWeek.Monday => "Lunes",
                DayOfWeek.Tuesday => "Martes",
                DayOfWeek.Wednesday => "Miércoles",
                DayOfWeek.Thursday => "Jueves",
                DayOfWeek.Friday => "Viernes",
                DayOfWeek.Saturday => "Sábado",
                _ => null
            };

            if (column == null || string.IsNullOrEmpty(hora))
            {
                // No se soportan domingos o hora no especificada, limpiar el ComboBox
                cboOdontologos.DataSource = null;
                return;
            }

            string query = $@"
        SELECT o.Idodontologo, CONCAT(o.Nombres, ' ', o.Apellidos) AS NombreCompleto, h.{column}
        FROM [dbo].[Odontologo] o
        INNER JOIN [dbo].[Horarios] h ON o.Idodontologo = h.Idodontologo
        WHERE h.{column} IS NOT NULL AND h.{column} <> '' AND h.{column} <> 'DESCANSO'";

            string connectionString = ConfigurationManager.ConnectionStrings["Clinica"].ConnectionString;

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    con.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(reader);
                    con.Close();

                    DataRow dr = dt.NewRow();
                    dr["Idodontologo"] = 0;
                    dr["NombreCompleto"] = "--Seleccione--";
                    dt.Rows.InsertAt(dr, 0);

                    DataTable filteredDt = dt.Clone();
                    foreach (DataRow row in dt.Rows)
                    {
                        if (IsOdontologoAvailable(row["Idodontologo"].ToString(), row[column].ToString(), dtpFechaReser.Value, hora))
                        {
                            filteredDt.ImportRow(row);
                        }
                    }

                    cboOdontologos.DataSource = filteredDt;
                    cboOdontologos.DisplayMember = "NombreCompleto";
                    cboOdontologos.ValueMember = "Idodontologo";
                }
            }
        }

        private bool IsOdontologoAvailable(string idOdontologo, string horario, DateTime fecha, string hora)
        {
            if (string.IsNullOrEmpty(horario) || string.IsNullOrEmpty(hora))
            {
                return false;
            }

            DateTime appointmentTime;
            if (!DateTime.TryParse(hora, out appointmentTime))
            {
                return false;
            }

            string query = @"
        SELECT COUNT(*)
        FROM [dbo].[Detalle_Reserva]
        WHERE Idodontologo = @idOdontologo AND diaCita = @fecha AND horaCita = @hora";

            string connectionString = ConfigurationManager.ConnectionStrings["Clinica"].ConnectionString;

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@idOdontologo", idOdontologo);
                    cmd.Parameters.AddWithValue("@fecha", fecha.Date); // Comparar solo la fecha sin la hora
                    cmd.Parameters.AddWithValue("@hora", hora);

                    con.Open();
                    int count = (int)cmd.ExecuteScalar();
                    con.Close();

                    if (count > 0)
                    {
                        return false; // El odontólogo ya tiene una cita en esa fecha y hora
                    }
                }
            }

            string[] intervals = horario.Split(';');
            foreach (string interval in intervals)
            {
                string[] times = interval.Split('-');
                if (times.Length == 2)
                {
                    DateTime start;
                    DateTime end;

                    if (DateTime.TryParse(times[0], out start) && DateTime.TryParse(times[1], out end))
                    {
                        if (appointmentTime >= start && appointmentTime <= end)
                        {
                            return true; // El odontólogo está disponible en este horario
                        }
                    }
                }
            }
            return false;
        }

        private void cboOdontologos_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Manejar el cambio de selección si es necesario
            if (cboOdontologos.SelectedValue != null)
            {
                string selectedId = cboOdontologos.SelectedValue.ToString();
                MessageBox.Show($"Odontólogo seleccionado ID: {selectedId}");
            }
        }
}
}
