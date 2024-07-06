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
    public partial class VistaEquipo : Form
    {
        EquipoBL objEquipoBL = new EquipoBL();
        DataView dtv;
        public VistaEquipo()
        {
            InitializeComponent();
        }



        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();

            PacienteMan1 objPaciente1 = new PacienteMan1();
            objPaciente1.Show();

        }

        private void VistaEquipo_Load(object sender, EventArgs e)
        {
            CargarDatos("");
        }
        private void CargarDatos(String strFiltro)
        {

            // Construimos  el objeto Dataview dtv  en base al DataTable devuelto por el metodo ListarProducto
            // Y lo filtramos de acuerdo al parametro strFiltro
            dtv = new DataView(objEquipoBL.ListarEquipo());
            dtv.RowFilter = "Nombre like '%" + strFiltro + "%'";
            dtgEquipo.DataSource = dtv;
            lblRegistros.Text = dtgEquipo.Rows.Count.ToString();

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
    }
}
