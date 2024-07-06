using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.DirectoryServices.ActiveDirectory;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyClinicOdonto_BE;
using ProyClinicOdonto_BL;

namespace ProyClinicOdonto_GUI
{
    public partial class OdontologoMan2 : Form
    {
        // Instancias...
        OdontologoBL objOdontologoBL = new OdontologoBL();
        OdontologoBE objOdontologoBE = new OdontologoBE();
        DistritoBL objDistritoBL = new DistritoBL();
        public OdontologoMan2()
        {
            InitializeComponent();
        }





        private void btnGrabar_Click_1(object sender, EventArgs e)
        {
            try
            {


                String Genero = "";
                if (rbMascu.Checked == true)
                {
                    Genero = "Masculino";
                }
                else
                {
                    Genero = "Femenino";
                }
                Boolean activo;
                if (chkActivo.Checked == true)
                {
                    activo = true;
                }
                else
                {
                    activo = false;
                }


                DateTime fechaIng = dtpFecing.Value;
                //Codifique}
                //Validamos
                if (txtNomOdon.Text.Trim() == String.Empty)
                {
                    throw new Exception("Ingresa un Nombre porfavor");
                }
                if (txtApeOdon.Text.Trim() == String.Empty)
                {
                    throw new Exception("Ingresa un Apellido porfavor:");
                }
                if (Genero.Trim() == String.Empty)
                {
                    throw new Exception("Escoge un genero porfavor");
                }
                if (txtEmail.Text.Trim() == String.Empty)
                {
                    throw new Exception("Ingresa un Email porfavor:");
                }
                if (txtDirec.Text.Trim() == String.Empty)
                {
                    throw new Exception("Ingresa una Dirección porfavor:");
                }
                if (mskTelefono.Text.Trim() == String.Empty)
                {
                    throw new Exception("Ingresa un número de celular");
                }
                if (mskCOP.Text.Trim() == String.Empty)
                {
                    throw new Exception("Ingresa un número de COP");
                }
                //Cargamos la entidad de negocio
                objOdontologoBE.Nombres = txtNomOdon.Text;
                objOdontologoBE.Apellidos = txtApeOdon.Text;
                objOdontologoBE.Genero = Genero;
                objOdontologoBE.email = txtEmail.Text;
                objOdontologoBE.direccion = txtDirec.Text;
                objOdontologoBE.telefono = mskTelefono.Text;
                //objOdontologoBE.Idespecialidad = cboEspecia.SelectedValue.ToString();
                objOdontologoBE.COP = mskCOP.Text;
                objOdontologoBE.Estado = activo;
                objOdontologoBE.fechaCreacion = fechaIng;
                objOdontologoBE.IdDist = cboDistrito.SelectedValue.ToString();

                if (objOdontologoBL.InsertarOdontologos(objOdontologoBE) == true)
                {
                    this.Close();
                }
                else
                {

                    throw new Exception("Disculpa la molestia, trabajaremos para mejorar nuestro sistema.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void grpDatos_Enter(object sender, EventArgs e)
        {

        }

        private void OdontologoMan2_Load(object sender, EventArgs e)
        {

            //try
            //{
            // DataTable dt = objEspecialidadBL.ListarEspecialidad();
             //DataRow dr;
               // dr = dt.NewRow();
               // dr["Idespecialidad"] = 0;
               // dr["Nomespecialidad"] = "--Seleccione--";
               // dt.Rows.InsertAt(dr, 0);
                //cboEspecia.DataSource = dt;
                //cboEspecia.DisplayMember = "Nomespecialidad";
                //cboEspecia.ValueMember = "Idespecialidad";
            //}
           // catch (Exception)
            //{

               // throw;
            //}

            try
            {
                DataTable dt = objDistritoBL.ListarDistrito();
                DataRow dr;
                dr = dt.NewRow();
                dr["IdDist"] = 0;
                dr["Nombre"] = "--Seleccione--";
                dt.Rows.InsertAt(dr, 0);
                cboDistrito.DataSource = dt;
                cboDistrito.DisplayMember = "Nombre";
                cboDistrito.ValueMember = "IdDist";
            }
            catch (Exception)
            {

                throw;
            }
        }



        private void txtApeOdon_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtNomOdon_TextChanged(object sender, EventArgs e)
        {
        }
    }
}

