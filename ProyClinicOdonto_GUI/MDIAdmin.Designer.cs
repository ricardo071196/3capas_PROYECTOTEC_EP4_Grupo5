namespace ProyClinicOdonto_GUI
{
    partial class MDIAdmin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            statusStrip1 = new StatusStrip();
            lblEquipo = new ToolStripStatusLabel();
            lblTiempo = new ToolStripStatusLabel();
            lblUsuario = new ToolStripStatusLabel();
            menuStrip1 = new MenuStrip();
            accionesToolStripMenuItem = new ToolStripMenuItem();
            mantenimientoEquiposToolStripMenuItem = new ToolStripMenuItem();
            consultaToolStripMenuItem = new ToolStripMenuItem();
            timer1 = new System.Windows.Forms.Timer(components);
            saToolStripMenuItem = new ToolStripMenuItem();
            statusStrip1.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { lblEquipo, lblTiempo, lblUsuario });
            statusStrip1.Location = new Point(0, 425);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(800, 26);
            statusStrip1.TabIndex = 5;
            statusStrip1.Text = "statusStrip1";
            // 
            // lblEquipo
            // 
            lblEquipo.BackColor = SystemColors.ActiveCaptionText;
            lblEquipo.ForeColor = SystemColors.ButtonHighlight;
            lblEquipo.Name = "lblEquipo";
            lblEquipo.Size = new Size(59, 20);
            lblEquipo.Text = "Equipo:";
            // 
            // lblTiempo
            // 
            lblTiempo.BackColor = SystemColors.ControlDark;
            lblTiempo.ForeColor = SystemColors.ControlLightLight;
            lblTiempo.Name = "lblTiempo";
            lblTiempo.Size = new Size(63, 20);
            lblTiempo.Text = "Tiempo:";
            // 
            // lblUsuario
            // 
            lblUsuario.BackColor = SystemColors.ControlDarkDark;
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(18, 20);
            lblUsuario.Text = "...";
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { accionesToolStripMenuItem, consultaToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(6, 3, 0, 3);
            menuStrip1.Size = new Size(800, 30);
            menuStrip1.TabIndex = 4;
            menuStrip1.Text = "menuStrip1";
            // 
            // accionesToolStripMenuItem
            // 
            accionesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { mantenimientoEquiposToolStripMenuItem, saToolStripMenuItem });
            accionesToolStripMenuItem.Name = "accionesToolStripMenuItem";
            accionesToolStripMenuItem.Size = new Size(82, 24);
            accionesToolStripMenuItem.Text = "Acciones";
            // 
            // mantenimientoEquiposToolStripMenuItem
            // 
            mantenimientoEquiposToolStripMenuItem.Name = "mantenimientoEquiposToolStripMenuItem";
            mantenimientoEquiposToolStripMenuItem.Size = new Size(253, 26);
            mantenimientoEquiposToolStripMenuItem.Text = "Mantenimiento Usuarios";
            mantenimientoEquiposToolStripMenuItem.Click += mantenimientoEquiposToolStripMenuItem_Click;
            // 
            // consultaToolStripMenuItem
            // 
            consultaToolStripMenuItem.Name = "consultaToolStripMenuItem";
            consultaToolStripMenuItem.Size = new Size(14, 24);
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // saToolStripMenuItem
            // 
            saToolStripMenuItem.Name = "saToolStripMenuItem";
            saToolStripMenuItem.Size = new Size(253, 26);
            saToolStripMenuItem.Text = "Salir";
            saToolStripMenuItem.Click += saToolStripMenuItem_Click;
            // 
            // MDIAdmin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            BackgroundImage = Properties.Resources.consultorio_medico_vacio_equipos_e_instrumentos_482257_27314;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 451);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            Name = "MDIAdmin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MDIAdmin";
            WindowState = FormWindowState.Maximized;
            Load += MDIAdmin_Load;
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private StatusStrip statusStrip1;
        private ToolStripStatusLabel lblEquipo;
        private ToolStripStatusLabel lblTiempo;
        private ToolStripStatusLabel lblUsuario;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem consultaToolStripMenuItem;
        private ToolStripMenuItem accionesToolStripMenuItem;
        private ToolStripMenuItem mantenimientoEquiposToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
        private ToolStripMenuItem saToolStripMenuItem;
    }
}