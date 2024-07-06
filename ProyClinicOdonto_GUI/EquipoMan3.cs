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
    public partial class EquipoMan3 : Form
    {
        EquipoBL objEquipoBL = new EquipoBL();
        EquipoBE objEquipoBE = new EquipoBE();
        PisoBL objPisoBL = new PisoBL();
        public EquipoMan3()
        {
            InitializeComponent();
        }

        public String Codigo { get; set; }
        private void grpDatos_Enter(object sender, EventArgs e)
        {

        }



        private void EquipoMan3_Load(object sender, EventArgs e)
        {
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {

        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EquipoMan3_Load_1(object sender, EventArgs e)
        {

            try

            {
                // Primero, asigna los datos al ComboBox cboDistrito
                DataTable dt = objPisoBL.ListarPiso();
                DataRow dr = dt.NewRow();
                dr["id_piso"] = 0;
                dr["Nombre"] = "--Seleccionar--";
                dt.Rows.InsertAt(dr, 0);
                cboPiso.DataSource = dt;
                cboPiso.DisplayMember = "Nombre";
                cboPiso.ValueMember = "id_piso";

                objEquipoBE = objEquipoBL.ConsultarEquipo(this.Codigo);


                lblNumSer.Text = Codigo;
                txtNomEqui.Text = objEquipoBE.Nombre;
                txtDesc.Text = objEquipoBE.Descripcion;
                txtObservacion.Text = objEquipoBE.Observacion;
                mskStock.Text = objEquipoBE.Stock;
                cboPiso.SelectedValue = objEquipoBE.id_piso;

                if (objEquipoBE.Estado == true)
                {
                    optActivo.Checked = true;
                }
                else
                {
                    optInactivo.Checked = true;
                }


            }
            catch (Exception)
            {
                throw;
            }
        }

        private void grpDatos_Enter_1(object sender, EventArgs e)
        {

        }

        private void btnGrabar_Click_1(object sender, EventArgs e)
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

                objEquipoBE.Nombre = txtNomEqui.Text;
                objEquipoBE.Descripcion = txtDesc.Text;
                objEquipoBE.Estado = activo;
                objEquipoBE.id_piso = cboPiso.SelectedValue.ToString();
                objEquipoBE.Observacion = txtObservacion.Text;
                objEquipoBE.Stock = mskStock.Text;

                //objprofesorBE.FecIng = fechaIng;
                //objprofesorBE.Id_Ubi = cboDep.SelectedValue.ToString() + cboProvincia.SelectedValue.ToString() +
                //    cboDistrito.SelectedValue.ToString();
                if (objEquipoBL.ActualizarEquipo(objEquipoBE) == true)
                {
                    this.Close();
                }
                else
                {
                    throw new Exception("No se inserto ");
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

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}

