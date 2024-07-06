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
    public partial class AdministradorMan3 : Form
    {
        ManAdminBL objManAdminBL = new ManAdminBL();
        ManAdminBE objManAdminBE = new ManAdminBE();

        public AdministradorMan3()
        {
            InitializeComponent();
        }
        public String Login_Usuario { get; set; }

        private void grpDatos_Enter(object sender, EventArgs e)
        {

        }

        private void AdministradorMan3_Load(object sender, EventArgs e)
        {
            try
            {
                // Carga los datos del usuario a actualizar
                objManAdminBE = objManAdminBL.ConsultarUsuarioDatos(this.Login_Usuario);

                // Asigna los datos del usuario a los controles del formulario
                // (Asume que los controles tienen nombres correspondientes a las propiedades del objeto ManAdminBE)
                txtLogin_Usuario.Text = objManAdminBE.Login_Usuario;
                txtPass_Usuario.Text = objManAdminBE.Pass_Usuario;
                // Carga las opciones de estado al ComboBox
                cboEstado.Items.Add("Activo");
                cboEstado.Items.Add("Inactivo");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtiene los valores ingresados por el usuario
                string loginUsuario = txtLogin_Usuario.Text;
                string passUsuario = txtPass_Usuario.Text;
                string estado = cboEstado.SelectedItem.ToString();

                // Verifica que se hayan ingresado los datos obligatorios


                // Actualiza los datos del usuario
                objManAdminBE.Login_Usuario = loginUsuario;
                objManAdminBE.Pass_Usuario = passUsuario;
                objManAdminBE.Estado = estado;

                // Llama al método de la capa de negocio para actualizar el usuario en la base de datos
                if (objManAdminBL.ActualizarUsuarioDatos(objManAdminBE))
                {
                    MessageBox.Show("Usuario actualizado correctamente.");
                    this.Close();
                }
                else
                {
                    throw new Exception("No se pudo actualizar el usuario.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar el usuario: " + ex.Message);
            }
        }
    }
}
