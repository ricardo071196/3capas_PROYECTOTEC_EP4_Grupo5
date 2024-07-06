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

namespace ProyClinicOdonto_GUI
{
    public partial class VistaHorario : Form
    {
        HorarioBL objHorarioBL = new HorarioBL();
        DataView dtv;
        public VistaHorario()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                // Pasaremos al metodo CargarDatos el texto que se va escribiendo
                // en la caja de texto 
                CargarDatos(textBox1.Text.Trim());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }
        }

        private void CargarDatos(String strFiltro)
        {

            // Construimos  el objeto Dataview dtv  en base al DataTable devuelto por el metodo ListarProducto
            // Y lo filtramos de acuerdo al parametro strFiltro
            dtv = new DataView(objHorarioBL.HorarioLista());
            dtv.RowFilter = "Odontologo like '%" + strFiltro + "%'";
            dtgOdontologo.DataSource = dtv;
            lblRegistros.Text = dtgOdontologo.Rows.Count.ToString();

        }

        private void VistaHorario_Load(object sender, EventArgs e)
        {
            CargarDatos("");
        }
    }
}
