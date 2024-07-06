using ProyClinicOdonto_BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProyClinicOdonto_GUI
{
    public partial class ReservaMan1 : Form
    {
        ReservaBL objReservaBL = new ReservaBL();
        DataView dtv;
        public ReservaMan1()
        {
            InitializeComponent();
        }

        private void dtgEquipo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ReservaMan1_Load(object sender, EventArgs e)
        {
            CargarDatos("");
        }

        private void CargarDatos(String strFiltro)
        {

            // Construimos  el objeto Dataview dtv  en base al DataTable devuelto por el metodo ListarProducto
            // Y lo filtramos de acuerdo al parametro strFiltro
            dtv = new DataView(objReservaBL.ListarReserva());
            // Crea un nuevo filtro utilizando parámetros
            string filtro = $"Paciente LIKE '%{strFiltro}%' OR Convert(diaCita, 'System.String') LIKE '%{strFiltro}%'";
            dtv.RowFilter = filtro;
            dtgReserva.DataSource = dtv;
            lblRegistros.Text = dtgReserva.Rows.Count.ToString();
        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            try
            {
                // Pasaremos al metodo CargarDatos el texto que se va escribiendo
                // en la caja de texto 
                CargarDatos(txtFiltro.Text.Trim());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            try
            {
                // Codifique
                ReservaMan2 objReserva2 = new ReservaMan2();
                objReserva2.ShowDialog();
                //Refrescar datagrid
                CargarDatos(txtFiltro.Text.Trim());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();

            PacienteMan1 objPaciente1 = new PacienteMan1();
            objPaciente1.Show();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                ReservaMan3 objReserva3 = new ReservaMan3();
                objReserva3.Codigo = dtgReserva.CurrentRow.Cells[0].Value.ToString();
                // Codifique
                objReserva3.ShowDialog();
                //Refrescar datagrid
                CargarDatos(txtFiltro.Text.Trim());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }
        }
    }
}
