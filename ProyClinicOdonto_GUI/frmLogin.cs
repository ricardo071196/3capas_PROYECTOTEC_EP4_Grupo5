using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Windows.Forms;
//Using...
using ProyClinicOdonto_BE;
using ProyClinicOdonto_BL;
using ProyClinicOdonto_GUI;

namespace ProyVentas_GUI
{
    public partial class frmLogin : Form
    {
        // Declaramos variableas de intentos y tiempo....
        Int16 intentos = 0;
        Int16 tiempo = 30;
        // Declaramos instancias para autenficacion de Usuarios....
        UsuarioBE objUsuarioBE = new UsuarioBE();
        UsuarioBL objUsuarioBL = new UsuarioBL();
        UsuarioAUXBE objUsuarioAUXBE = new UsuarioAUXBE();
        UsuarioAUXBL objUsuarioAUXBL = new UsuarioAUXBL();
        UsuarioRHBE objUsuarioRHBE = new UsuarioRHBE();
        UsuarioRHBL objUsuarioRHBL = new UsuarioRHBL();
        UsuarioAdminBE objUsuarioAdminBE = new UsuarioAdminBE();
        UsuarioAdminBL objUsuarioAdminBL = new UsuarioAdminBL();





        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {

            if (txtLogin.Text.Trim() != String.Empty && txtPassword.Text.Trim() != String.Empty)
            {
                // Intentar autenticar como Usuario del primer tipo
                objUsuarioBE = objUsuarioBL.ConsultarUsuario(txtLogin.Text.Trim());

                if (objUsuarioBE.Login_Usuario != null && txtLogin.Text.Trim() == objUsuarioBE.Login_Usuario && txtPassword.Text.Trim() == objUsuarioBE.Pass_Usuario)
                {
                    // Credenciales correctas para UsuarioBE
                    AutenticarUsuario(objUsuarioBE.Login_Usuario, objUsuarioBE.Pass_Usuario);
                    return;
                }

                // Intentar autenticar como Usuario del segundo tipo
                objUsuarioAUXBE = objUsuarioAUXBL.ConsultarUsuario2(txtLogin.Text.Trim());

                if (objUsuarioAUXBE.Login_Usuario != null && txtLogin.Text.Trim() == objUsuarioAUXBE.Login_Usuario && txtPassword.Text.Trim() == objUsuarioAUXBE.Pass_Usuario)
                {
                    // Credenciales correctas para Usuario2BE
                    AutenticarUsuario2(objUsuarioAUXBE.Login_Usuario, objUsuarioAUXBE.Pass_Usuario);
                    return;
                }
                objUsuarioRHBE = objUsuarioRHBL.ConsultarUsuario3(txtLogin.Text.Trim());
                if (objUsuarioRHBE.Login_Usuario != null && txtLogin.Text.Trim() == objUsuarioRHBE.Login_Usuario && txtPassword.Text.Trim() == objUsuarioRHBE.Pass_Usuario)
                {
                    // Credenciales correctas para Usuario2BE
                    AutenticarUsuario3(objUsuarioRHBE.Login_Usuario, objUsuarioRHBE.Pass_Usuario);
                    return;
                }
                objUsuarioAdminBE = objUsuarioAdminBL.ConsultarUsuario4(txtLogin.Text.Trim());
                if (objUsuarioAdminBE.Login_Usuario != null && txtLogin.Text.Trim() == objUsuarioAdminBE.Login_Usuario && txtPassword.Text.Trim() == objUsuarioAdminBE.Pass_Usuario)
                {
                    // Credenciales correctas para Usuario2BE
                    AutenticarUsuario4(objUsuarioAdminBE.Login_Usuario, objUsuarioAdminBE.Pass_Usuario);
                    return;
                }

                // Si ninguna autenticación tuvo éxito
                MessageBox.Show("Usuario no existe", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                intentos += 1;
                ValidaAccesos();
            }
            else
            {
                MessageBox.Show("Usuario o Password obligatorios", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                intentos += 1;
                ValidaAccesos();
            }

        }



        private void AutenticarUsuario(string login, string password)
        {
            // Credenciales correctas
            this.Hide();
            timer1.Enabled = false;

            // Registramos las credenciales
            clsCredenciales.Login_Usuario = login;
            clsCredenciales.Pass_Usuario = password;


            // Lanzamos el MDI
            MDIRECEP objRECEP = new MDIRECEP();
            objRECEP.ShowDialog();
            return; // Salir del método ya que el usuario normal fue encontrado
        }

        private void AutenticarUsuario2(string login, string password)
        {
            // Credenciales correctas
            this.Hide();
            timer1.Enabled = false;

            // Registramos las credenciales
            clsCredencialesAUX.Login_Usuario = login;
            clsCredencialesAUX.Pass_Usuario = password;


            // Lanzamos el MDI
            MDIprincipal objMDI = new MDIprincipal();
            objMDI.ShowDialog();
            return; // Salir del método ya que el usuario normal fue encontrado
        }

        private void AutenticarUsuario3(string login, string password)
        {
            // Credenciales correctas
            this.Hide();
            timer1.Enabled = false;

            // Registramos las credenciales
            clsCredencialesRH.Login_Usuario = login;
            clsCredencialesRH.Pass_Usuario = password;
            // Lanzamos el MDI


            MDIRH objRH = new MDIRH();
            objRH.ShowDialog();
            return; // Salir del método ya que el usuario normal fue encontrado
        }

        private void AutenticarUsuario4(string login, string password)
        {
            // Credenciales correctas
            this.Hide();
            timer1.Enabled = false;

            // Registramos las credenciales
            clsCredencialesADMIN.Login_Usuario = login;
            clsCredencialesADMIN.Pass_Usuario = password;
            // Lanzamos el MDI


            MDIAdmin objAdmin = new MDIAdmin();
            objAdmin.ShowDialog();
            return; // Salir del método ya que el usuario normal fue encontrado
        }




        private void ValidaAccesos()
        {
            if (intentos == 3)
            {
                MessageBox.Show("Lo sentimos,  sobrepaso el numero de intentos",
                    "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }

        }
        private void timer1_Tick(object sender, EventArgs e)
        {

            tiempo -= 1;
            this.Text = "Ingrese su login y contraseña. Le quedan...." + tiempo;
            if (tiempo == 0)
            {
                MessageBox.Show("Lo sentimos, sobrepaso el tiempo de espera",
                    "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Application.Exit();
            }
        }

        private void frmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            timer1.Enabled = false;
            Application.Exit();

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            Application.Exit();
        }

        private void frmLogin_KeyDown(object sender, KeyEventArgs e)
        {
            // Para al pulsar Enter acceder al MDI...
            if (e.KeyCode == Keys.Enter)
            {
                btnAceptar.PerformClick();

            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
