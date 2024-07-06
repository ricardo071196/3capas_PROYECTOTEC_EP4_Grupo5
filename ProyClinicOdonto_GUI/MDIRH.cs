using Microsoft.VisualBasic.Devices;
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
    public partial class MDIRH : Form
    {
        TimeSpan horaInicio = new TimeSpan();
        Computer miComputadora = new Computer();
        String strMensajeRed;
        public MDIRH()
        {
            InitializeComponent();
        }

        private void mantenimientoEquiposToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OdontologoMan1 objOdontologo1 = new OdontologoMan1();
            objOdontologo1.Show();
        }

        private void MDIRH_Load(object sender, EventArgs e)
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Text = "Aplicación Clinica - Hora Actual : " + DateTime.Now;
            lblTiempo.Text = "Tiempo: " + DateTime.Now.TimeOfDay.Subtract(horaInicio).ToString().Substring(0, 8);
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Mostrar un cuadro de diálogo de confirmación
            DialogResult result = MessageBox.Show("¿Seguro que desea cerrar sesión?", "Confirmar Cierre de Sesión", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Comprobar la respuesta del usuario
            if (result == DialogResult.Yes)
            {
                // Si el usuario elige 'Sí', cerrar la sesión (cerrar la aplicación)
                this.Close();
            }
            // Si el usuario elige 'No', no hacer nada (quedarse en la aplicación)
        }

        private void turnosToolStripMenuItem_Click(object sender, EventArgs e)
        {
           VistaHorario objVistaHorario = new VistaHorario();
            objVistaHorario.Show();
        }
    }
}
