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
    public partial class ReservaMan3 : Form
    {
        OdontologoBL objOdontologoBL = new OdontologoBL();
        ConsultorioListaBL objconsultorioListaBL = new ConsultorioListaBL();
        ReservaBE objReservaBE = new ReservaBE();
        ReservaBL objReservaBL = new ReservaBL();

        public ReservaMan3()
        {
            InitializeComponent();
        }
        public String Codigo { get; set; }
        private void ReservaMan3_Load(object sender, EventArgs e)
        {
            try
            {
                // Cargar los consultorios en el ComboBox cboConsultorio
                DataTable dtConsultorios = objconsultorioListaBL.ConsultorioLista();
                DataRow drConsultorio = dtConsultorios.NewRow();
                drConsultorio["id_consultorio"] = 0;
                drConsultorio["nombre"] = "--Seleccione--";
                dtConsultorios.Rows.InsertAt(drConsultorio, 0);
                cboConsultorio.DataSource = dtConsultorios;
                cboConsultorio.DisplayMember = "nombre";
                cboConsultorio.ValueMember = "id_consultorio";

                // Cargar los odontólogos basados en el día y la hora seleccionados
                LoadOdontologosByDayAndHour(dtpFechaReserac.Value.DayOfWeek, txtHORA.Text);
                dtpFechaReserac.ValueChanged += dtpFechaReserac_ValueChanged;
                txtHORA.TextChanged += txtHORA_TextChanged;

                // Consultar la reserva según el código
                objReservaBE = objReservaBL.ConsultarReserva(this.Codigo);

                // Asignar los valores a los controles si objReservaBE no es nulo
                if (objReservaBE != null)
                {
                    lblIdreserva.Text = Codigo;
                    lblDni.Text = objReservaBE.idpaciente;
                    cboOdontologosac.SelectedValue = objReservaBE.idodontologo;

                    // Verificar si objReservaBE.id_consultorio no es null antes de asignarlo
                    if (objReservaBE.id_consultorio != null)
                    {
                        cboConsultorio.SelectedValue = objReservaBE.id_consultorio;
                    }
                    else
                    {
                        // Manejar el caso donde id_consultorio es null (opcional)
                        // cboConsultorio.SelectedValue = 0; // O cualquier valor predeterminado
                    }

                    dtpFechaReserac.Value = objReservaBE.diaCita;
                    txtHORA.Text = objReservaBE.HoraCita;
                    txtDetalle.Text = objReservaBE.detalle;

                    if (objReservaBE.Estado)
                    {
                        optActivo.Checked = true;
                    }
                    else
                    {
                        optInactivo.Checked = true;
                    }
                }
                else
                {
                    MessageBox.Show("No se encontró la reserva con el código especificado.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos: " + ex.Message);
            }

        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            try
            {
                Boolean activo;
                if (optActivo.Checked == true)
                {
                    activo = true;
                }
                else
                {
                    activo = false;
                }
                //Pasamos valores alas propiedades de la instancia...

                objReservaBE.idodontologo = cboOdontologosac.SelectedValue.ToString();
                objReservaBE.diaCita = Convert.ToDateTime(dtpFechaReserac.Text);
                objReservaBE.HoraCita = txtHORA.Text;
                objReservaBE.detalle = txtDetalle.Text;
                objReservaBE.id_consultorio = cboConsultorio.SelectedValue.ToString();
                objReservaBE.Estado = activo;

                if (objReservaBL.ActualizarReserva(objReservaBE) == true)
                {
                    this.Close();
                }
                else
                {
                    throw new Exception("No se insertaron los datos correctamente");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void grpDatos_Enter(object sender, EventArgs e)
        {
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            VistaEquipo objVistaEquipo1 = new VistaEquipo();
            objVistaEquipo1.Show();
        }

        private void dtpFechaReserac_ValueChanged(object sender, EventArgs e)
        {
            LoadOdontologosByDayAndHour(dtpFechaReserac.Value.DayOfWeek, txtHORA.Text);
        }

        private void txtHORA_TextChanged(object sender, EventArgs e)
        {
            LoadOdontologosByDayAndHour(dtpFechaReserac.Value.DayOfWeek, txtHORA.Text);
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
                cboOdontologosac.DataSource = null;
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
                        if (IsOdontologoAvailable(row["Idodontologo"].ToString(), row[column].ToString(), dtpFechaReserac.Value, hora))
                        {
                            filteredDt.ImportRow(row);
                        }
                    }

                    cboOdontologosac.DataSource = filteredDt;
                    cboOdontologosac.DisplayMember = "NombreCompleto";
                    cboOdontologosac.ValueMember = "Idodontologo";
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

        private void cboOdontologosac_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
    }
}
