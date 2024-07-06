using ProyClinicOdonto_BE;
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
    public partial class PacienteMan2 : Form
    {
        PacienteBL objPacienteBL = new PacienteBL();
        PacienteBE objPacienteBE = new PacienteBE();
        DistritoBL objDistritoBL = new DistritoBL();
        public PacienteMan2()
        {
            InitializeComponent();
        }

        private void PacienteMan2_Load(object sender, EventArgs e)
        {

        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void txtNomOdon_TextChanged(object sender, EventArgs e)
        {
        }

        private void PacienteMan2_Load_1(object sender, EventArgs e)
        {

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



                DateTime fechaInsc = dtpReg.Value;
                //Codifique}
                //Validamos
                if (mskDNI.Text.Trim() == String.Empty)
                {
                    throw new Exception("Ingresa numero de DNI");
                }

                if (txtNomPaci.Text.Trim() == String.Empty)
                {
                    throw new Exception("El nombre es obligatorio");
                }



                if (txtApePaci.Text.Trim() == String.Empty)
                {
                    throw new Exception("El apellido es obligatorio");
                }



                if (Genero.Trim() == String.Empty)
                {
                    throw new Exception("Escoge un genero porfavor");
                }



                if (txtEmail.Text.Trim() == String.Empty)
                {
                    throw new Exception("Ingresa un email porfavor");
                }


                if (mskTelefono.Text.Trim() == String.Empty)
                {
                    throw new Exception("El telefono es obligatorio");
                }


                if (cboDistrito.Text.Trim() == String.Empty)
                {
                    throw new Exception("Escoge un distrito");
                }





                //Cargamos la entidad de negocio
                objPacienteBE.idpaciente = mskDNI.Text;
                objPacienteBE.Nombres = txtNomPaci.Text;
                objPacienteBE.Apellidos = txtApePaci.Text;
                objPacienteBE.Genero = Genero;
                objPacienteBE.email = txtEmail.Text;
                //objPacienteBE.direccion = txtDirec.Text;
                objPacienteBE.telefono = mskTelefono.Text;
                objPacienteBE.alergias = txtAlerg.Text;
                //objPacienteBE.Estado = activo;
                objPacienteBE.fechaInscripcion = fechaInsc;
                objPacienteBE.IdDist = cboDistrito.SelectedValue.ToString();

                if (objPacienteBL.InsertarPacientes(objPacienteBE) == true)
                {
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
    }
}
