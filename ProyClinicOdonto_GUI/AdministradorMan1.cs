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
    public partial class AdministradorMan1 : Form
    {
        ManAdminBL objUsuarioAdminBL = new ManAdminBL();
        DataView dtv;
        public AdministradorMan1()
        {
            InitializeComponent();
        }


        private void CargarDatos(String strFiltro)
        {

            // Construimos  el objeto Dataview dtv  en base al DataTable devuelto por el metodo ListarProducto
            // Y lo filtramos de acuerdo al parametro strFiltro
            dtv = new DataView(objUsuarioAdminBL.ListarUsuario());
            dtv.RowFilter = " Login_Usuario like '%" + strFiltro + "%'";
            dtgUsuarioAdmin.DataSource = dtv;
            lblRegistros2.Text = dtgUsuarioAdmin.Rows.Count.ToString();

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

        private void dtgUsuarioAdmin_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void AdministradorMan1_Load(object sender, EventArgs e)
        {
            CargarDatos("");
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            try
            {
                // Codifique
                AdministradorMan2 objAdministradorMan2 = new AdministradorMan2();
                objAdministradorMan2.ShowDialog();
                //Refrescar datagrid
                CargarDatos(txtFiltro.Text.Trim());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            //try
            // {
            // AdministradorMan3 objAdministradorMan3 = new AdministradorMan3();
            // objAdministradorMan3.Login_Usuario = dtgUsuarioAdmin.CurrentRow.Cells[0].Value.ToString();
            // Codifique
            // objAdministradorMan3.ShowDialog();
            //Refrescar datagrid
            //   CargarDatos(txtFiltro.Text.Trim());
            //   }
            // catch (Exception ex)
            // {
            // MessageBox.Show("Error:" + ex.Message);
            //}
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
