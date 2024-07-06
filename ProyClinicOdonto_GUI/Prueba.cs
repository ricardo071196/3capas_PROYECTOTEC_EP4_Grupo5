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
    public partial class Prueba : Form
    {
        public Prueba()
        {
            InitializeComponent();
        }

        private void Prueba_Load(object sender, EventArgs e)
        {
            // Set DateTimePicker to allow only day selection
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "dddd"; // Display day name (e.g., Monday)
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            LoadOdontologosByDay(dateTimePicker1.Value.DayOfWeek);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Handle selected index change if necessary
            // For example, display additional information about the selected odontologist
            if (comboBox1.SelectedValue != null)
            {
                string selectedId = comboBox1.SelectedValue.ToString();
                MessageBox.Show($"Odontólogo seleccionado ID: {selectedId}");
            }
        }

        private void LoadOdontologosByDay(DayOfWeek dayOfWeek)
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

            if (column == null)
            {
                // No se soportan domingos, limpiar el ComboBox
                comboBox1.DataSource = null;
                return;
            }

            string query = $@"
                SELECT o.Idodontologo, CONCAT(o.Nombres, ' ', o.Apellidos) AS NombreCompleto
                FROM [dbo].[Odontologo] o
                INNER JOIN [dbo].[Horarios] h ON o.Idodontologo = h.Idodontologo
                WHERE h.{column} IS NOT NULL AND h.{column} <> '' AND h.{column} <> 'DESCANSO'";

            // Get the connection string from app.config
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

                    comboBox1.DataSource = dt;
                    comboBox1.DisplayMember = "NombreCompleto";
                    comboBox1.ValueMember = "Idodontologo";
                }
            }
        }
    }
}
