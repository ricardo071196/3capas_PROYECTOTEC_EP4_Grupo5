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
    public partial class AdministradorMan2 : Form
    {

        ManAdminBL objManAdminBL = new ManAdminBL();
        ManAdminBE objManAdminBE = new ManAdminBE();

        public AdministradorMan2()
        {
            InitializeComponent();
        }
        public String Login_Usuario { get; set; }

        private void btnGrabar_Click(object sender, EventArgs e)
        {

            try
            {


                DateTime Fec_Registro = dtpFechaReg.Value;
                //Codifique}
                //Validamos

                if (txtLogin_Usuario.Text.Trim() == String.Empty)
                {
                    throw new Exception("La cantidad es obligatoria");
                }


                if (txtPass_Usuario.Text.Trim() == String.Empty)
                {
                    throw new Exception("La descripcion es obligatoria");
                }





                //Cargamos la entidad de negocio
                objManAdminBE.Fuente = cboFuente.Text;
                objManAdminBE.Login_Usuario = txtLogin_Usuario.Text;
                objManAdminBE.Pass_Usuario = txtPass_Usuario.Text;
                objManAdminBE.Estado = cboEstado.Text;
                objManAdminBE.Fec_Registro = Fec_Registro;
                objManAdminBE.Usu_Registro = Login_Usuario;


                if (objManAdminBL.InsertarUsuario(objManAdminBE) == true)
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

        private void grpDatos_Enter(object sender, EventArgs e)
        {

        }

        private void AdministradorMan2_Load(object sender, EventArgs e)
        {
            // Agregar opciones al ComboBox para Fuente
            cboFuente.Items.Add("--Seleccionar--");
            cboFuente.Items.Add("Usuario");
            cboFuente.Items.Add("RH");
            cboFuente.Items.Add("Auxalmacen");

            // Opcional: Seleccionar un ítem por defecto en cboFuente
            cboFuente.SelectedIndex = 0;


            // Agregar opciones al ComboBox para Fuente
            cboEstado.Items.Add("--Seleccionar--");
            cboEstado.Items.Add("Activo");
            cboEstado.Items.Add("Inactivo");

            // Opcional: Seleccionar un ítem por defecto en cboFuente
            cboEstado.SelectedIndex = 0;
        }
    }
}
