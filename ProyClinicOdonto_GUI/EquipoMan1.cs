using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyClinicOdonto_BL;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProyClinicOdonto_GUI
{
    public partial class EquipoMan1 : Form
    {
        EquipoBL objEquipoBL = new EquipoBL();
        DataView dtv;
        public EquipoMan1()
        {
            InitializeComponent();

        }


        private void txtFiltro_TextChanged_1(object sender, EventArgs e)
        {


        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            try
            {
                // Codifique
                EquipoMan2 objMan2 = new EquipoMan2();
                objMan2.ShowDialog();
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

            try
            {
                EquipoMan3 objMan3 = new EquipoMan3();
                objMan3.Codigo = dtgEquipo.CurrentRow.Cells[0].Value.ToString();
                // Codifique
                objMan3.ShowDialog();
                //Refrescar datagrid
                CargarDatos(txtFiltro.Text.Trim());
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

        private void dtgEquipo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void EquipoMan1_Load_1(object sender, EventArgs e)
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
            lblRegistros2.Text = dtgEquipo.Rows.Count.ToString();

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

        private void dtgEquipo_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnActualizar_Click_1(object sender, EventArgs e)
        {
            try
            {
                EquipoMan3 objEqui3 = new EquipoMan3();
                objEqui3.Codigo = dtgEquipo.CurrentRow.Cells[0].Value.ToString();
                // Codifique
                objEqui3.ShowDialog();
                //Refrescar datagrid
                CargarDatos(txtFiltro.Text.Trim());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }
        }

        private void btnInsertar_Click_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnInsertar_Click_2(object sender, EventArgs e)
        {
            try
            {
                // Codifique
                EquipoMan2 objEqui2 = new EquipoMan2();
                objEqui2.ShowDialog();
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


