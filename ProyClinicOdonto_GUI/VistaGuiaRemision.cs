using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyClinicOdonto_BE;
using ProyClinicOdonto_BL;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace ProyClinicOdonto_GUI
{
    public partial class VistaGuiaRemision : Form
    {
        //Declaramos las instancias
        GuiaRemisionBL objGuiaRemisionBL = new GuiaRemisionBL();
        DataView dtv = new DataView();

        public VistaGuiaRemision()
        {
            InitializeComponent();
        }

        private void VistaGuiaRemision_Load(object sender, EventArgs e)
        {
            CargarDatos("");
        }

        private void CargarDatos(String strFiltro)
        {

            // Construimos  el objeto Dataview dtv  en base al DataTable devuelto por el metodo ListarProducto
            // Y lo filtramos de acuerdo al parametro strFiltro
            dtv = new DataView(objGuiaRemisionBL.ListarGuia());
            dtv.RowFilter = "descripcion like '%" + strFiltro + "%'";
            dtgGuia.DataSource = dtv;
            lblRegistros.Text = dtgGuia.Rows.Count.ToString();

        }

        private void btnInsertar_Click_1(object sender, EventArgs e)
        {
            try
            {
                // Codifique
                GuiaRemisionMan objGuiaRemisionMan = new GuiaRemisionMan();
                objGuiaRemisionMan.ShowDialog();
                //Refrescar datagrid
                CargarDatos(txtFiltro.Text.Trim());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }

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
