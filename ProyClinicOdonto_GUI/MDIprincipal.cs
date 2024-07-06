using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.Devices;
using ProyVentas_GUI;

namespace ProyClinicOdonto_GUI
{
    public partial class MDIprincipal : Form
    {
        TimeSpan horaInicio = new TimeSpan();
        Computer miComputadora = new Computer();
        String strMensajeRed;

        public MDIprincipal()
        {
            InitializeComponent();
        }

        private void MDIprincipal_Resize(object sender, EventArgs e)
        {
            this.Refresh();
        }

        private void equipoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void odontologoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void pacienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void salirToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Text = "Aplicación Clinica - Hora Actual : " + DateTime.Now;
            lblTiempo.Text = "Tiempo: " + DateTime.Now.TimeOfDay.Subtract(horaInicio).ToString().Substring(0, 8);
        }

        private void MDIprincipal_Load(object sender, EventArgs e)
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

        private void MDIprincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void MDIprincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult vrpta;
            vrpta = MessageBox.Show("Seguro que desea salir de la aplicación?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (vrpta == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void consultaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void mantenimientoEquiposToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EquipoMan1 objEquipo1 = new EquipoMan1();
            objEquipo1.Show();
        }

        private void lblTiempo_Click(object sender, EventArgs e)
        {

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

        private void guiaDeRemisionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VistaGuiaRemision objVistaGuiaRemision1 = new VistaGuiaRemision();
            objVistaGuiaRemision1.Show();
        }
    }
}
