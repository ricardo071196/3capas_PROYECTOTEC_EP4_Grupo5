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
    public partial class OdontologoMan1 : Form
    {
        OdontologoBL objOdontologoBL = new OdontologoBL();
        DataView dtv;
        public OdontologoMan1()
        {
            InitializeComponent();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                // Codifique
                OdontologoMan3 objOdon3 = new OdontologoMan3();
                objOdon3.ShowDialog();
                //Refrescar datagrid
                CargarDatos(textBox1.Text.Trim());
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
                OdontologoMan2 objOdon2 = new OdontologoMan2();
                objOdon2.ShowDialog();
                //Refrescar datagrid
                CargarDatos(textBox1.Text.Trim());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }
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

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dtgOdontologo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }





        private void dtgOdontologo_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void OdontologoMan1_Load_1(object sender, EventArgs e)
        {
            CargarDatos("");
        }
        private void CargarDatos(String strFiltro)
        {

            // Construimos  el objeto Dataview dtv  en base al DataTable devuelto por el metodo ListarProducto
            // Y lo filtramos de acuerdo al parametro strFiltro
            dtv = new DataView(objOdontologoBL.ListarOdontologos());
            dtv.RowFilter = "Nombres like '%" + strFiltro + "%'";
            dtgOdontologo.DataSource = dtv;
            lblRegistros.Text = dtgOdontologo.Rows.Count.ToString();

        }


        private void textBox1_TextChanged_1(object sender, EventArgs e)
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

        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnInsertar_Click_2(object sender, EventArgs e)
        {

            try
            {
                // Codifique
                OdontologoMan2 objOdon2 = new OdontologoMan2();
                objOdon2.ShowDialog();
                //Refrescar datagrid
                CargarDatos(textBox1.Text.Trim());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }
        }

        private void btnActualizar_Click_2(object sender, EventArgs e)
        {
            try
            {
                OdontologoMan3 objOdon3 = new OdontologoMan3();
                objOdon3.Codigo = dtgOdontologo.CurrentRow.Cells[0].Value.ToString();
                // Codifique
                objOdon3.ShowDialog();
                //Refrescar datagrid
                CargarDatos(textBox1.Text.Trim());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }
    }
}
