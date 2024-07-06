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

namespace ProyClinicOdonto_GUI
{
    public partial class EquipoMan2 : Form
    {
        // Instancias...
        EquipoBL objEquipoBL = new EquipoBL();
        EquipoBE objEquipoBE = new EquipoBE();
        TipoBL objTipoBL = new TipoBL();
        PisoBL objPisoBL = new PisoBL();
        public EquipoMan2()
        {
            InitializeComponent();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void EquipoMan2_Load(object sender, EventArgs e)
        {

        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {

        }

        private void grpDatos_Enter(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtEstaEqui_TextChanged(object sender, EventArgs e)
        {

        }

        private void EquipoMan2_Load_1(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = objTipoBL.ListarTipo();
                DataRow dr;
                dr = dt.NewRow();
                dr["IdTipo"] = 0;
                dr["NombreTipo"] = "--Seleccione--";
                dt.Rows.InsertAt(dr, 0);
                cboTipo.DataSource = dt;
                cboTipo.DisplayMember = "NombreTipo";
                cboTipo.ValueMember = "IdTipo";


            }
            catch (Exception)
            {

                throw;
            }

            try
            {
                DataTable dt = objPisoBL.ListarPiso();
                DataRow dr;
                dr = dt.NewRow();
                dr["id_piso"] = 0;
                dr["Nombre"] = "--Seleccione--";
                dt.Rows.InsertAt(dr, 0);
                cboPiso.DataSource = dt;
                cboPiso.DisplayMember = "Nombre";
                cboPiso.ValueMember = "id_piso";


            }
            catch (Exception)
            {

                throw;
            }





        }

        private void btnGrabar_Click_1(object sender, EventArgs e)
        {

            try
            {
                Boolean activo;
                if (chkActivo.Checked == true)
                {
                    activo = true;
                }
                else
                {
                    activo = false;
                }
                //Codifique}
                //Validamos
                if (txtNomEqui.Text.Trim() == String.Empty)
                {
                    throw new Exception("El nombre de equipo es obligatorio");
                }


                if (txtDesc.Text.Trim() == String.Empty)
                {
                    throw new Exception("La descripcion es obligatoria");
                }

                if (cboTipo.Text.Trim() == String.Empty)
                {
                    throw new Exception("Escoge un tipo por favor:");
                }

                //Cargamos la entidad de negocio
                objEquipoBE.Nombre = txtNomEqui.Text;
                objEquipoBE.Descripcion = txtDesc.Text;
                objEquipoBE.Estado = activo;
                objEquipoBE.IdTipo = cboTipo.SelectedValue.ToString();
                objEquipoBE.id_piso = cboPiso.SelectedValue.ToString();

                if (objEquipoBL.InsertarEquipo(objEquipoBE) == true)
                {
                    MessageBox.Show("Equipo insertado exitosamente, puedes buscarlo por su id");
                    this.Close();
                }
                else
                {

                    throw new Exception("Registro no se inserto, contacte con el area de TI");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
