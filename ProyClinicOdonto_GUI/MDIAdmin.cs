using Microsoft.VisualBasic.Devices;
using ProyVentas_GUI;
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
    public partial class MDIAdmin : Form
    {

        TimeSpan horaInicio = new TimeSpan();
        Computer miComputadora = new Computer();
        String strMensajeRed;
        public MDIAdmin()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Text = "Aplicación Clinica - Hora Actual : " + DateTime.Now;
            lblTiempo.Text = "Tiempo: " + DateTime.Now.TimeOfDay.Subtract(horaInicio).ToString().Substring(0, 8);
        }

        private void MDIAdmin_Load(object sender, EventArgs e)
        {
            if (clsCredenciales.Login_Usuario != null)
            {
                lblUsuario.Text = "Usuario: " + clsCredenciales.Login_Usuario;
            }
            if (clsCredencialesAUX.Login_Usuario != null)
            {
                lblUsuario.Text = "Usuario: " + clsCredencialesAUX.Login_Usuario;
            }
            if (clsCredencialesRH.Login_Usuario != null)
            {
                lblUsuario.Text = "Usuario: " + clsCredencialesRH.Login_Usuario;
            }
            if (clsCredencialesADMIN.Login_Usuario != null)
            {
                lblUsuario.Text = "Usuario: " + clsCredencialesADMIN.Login_Usuario;
            }



            horaInicio = DateTime.Now.TimeOfDay;
            if (miComputadora.Network.IsAvailable == true)
            {
                strMensajeRed = "Equipo con conexion disponible";
            }
            else
            {
                strMensajeRed = "Equipo sin conexion disponible";
            }

            lblEquipo.Text = "Equipo : " + miComputadora.Name + "." + strMensajeRed;
        }

        private void mantenimientoEquiposToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdministradorMan1 objAdmin1 = new AdministradorMan1();
            objAdmin1.Show();
        }

        private void saToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            frmLogin objLogin = new frmLogin();
            objLogin.Show();
        }
    }
}
