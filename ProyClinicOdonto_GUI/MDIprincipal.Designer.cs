namespace ProyClinicOdonto_GUI
{
    partial class MDIprincipal
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
            menuStrip1 = new MenuStrip();
            accionesToolStripMenuItem = new ToolStripMenuItem();
            mantenimientoEquiposToolStripMenuItem = new ToolStripMenuItem();
            salirToolStripMenuItem = new ToolStripMenuItem();
            consultaToolStripMenuItem = new ToolStripMenuItem();
            timer1 = new System.Windows.Forms.Timer(components);
            statusStrip1 = new StatusStrip();
            lblEquipo = new ToolStripStatusLabel();
            lblTiempo = new ToolStripStatusLabel();
            lblUsuario = new ToolStripStatusLabel();
            guiaDeRemisionToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { accionesToolStripMenuItem, consultaToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(8, 4, 0, 4);
            menuStrip1.Size = new Size(1000, 37);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // accionesToolStripMenuItem
            // 
            accionesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { mantenimientoEquiposToolStripMenuItem, guiaDeRemisionToolStripMenuItem, salirToolStripMenuItem });
            accionesToolStripMenuItem.Name = "accionesToolStripMenuItem";
            accionesToolStripMenuItem.Size = new Size(98, 29);
            accionesToolStripMenuItem.Text = "Acciones";
            // 
            // mantenimientoEquiposToolStripMenuItem
            // 
            mantenimientoEquiposToolStripMenuItem.Name = "mantenimientoEquiposToolStripMenuItem";
            mantenimientoEquiposToolStripMenuItem.Size = new Size(303, 34);
            mantenimientoEquiposToolStripMenuItem.Text = "Mantenimiento Equipos";
            mantenimientoEquiposToolStripMenuItem.Click += mantenimientoEquiposToolStripMenuItem_Click;
            // 
            // salirToolStripMenuItem
            // 
            salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            salirToolStripMenuItem.Size = new Size(303, 34);
            salirToolStripMenuItem.Text = "Cerrar Sesion";
            salirToolStripMenuItem.Click += salirToolStripMenuItem_Click;
            // 
            // consultaToolStripMenuItem
            // 
            consultaToolStripMenuItem.Name = "consultaToolStripMenuItem";
            consultaToolStripMenuItem.Size = new Size(16, 29);
            consultaToolStripMenuItem.Click += consultaToolStripMenuItem_Click;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { lblEquipo, lblTiempo, lblUsuario });
            statusStrip1.Location = new Point(0, 532);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Padding = new Padding(1, 0, 18, 0);
            statusStrip1.Size = new Size(1000, 32);
            statusStrip1.TabIndex = 3;
            statusStrip1.Text = "statusStrip1";
            statusStrip1.ItemClicked += statusStrip1_ItemClicked;
            // 
            // lblEquipo
            // 
            lblEquipo.BackColor = SystemColors.ActiveCaptionText;
            lblEquipo.ForeColor = SystemColors.ButtonHighlight;
            lblEquipo.Name = "lblEquipo";
            lblEquipo.Size = new Size(72, 25);
            lblEquipo.Text = "Equipo:";
            // 
            // lblTiempo
            // 
            lblTiempo.BackColor = SystemColors.ControlDark;
            lblTiempo.ForeColor = SystemColors.ControlLightLight;
            lblTiempo.Name = "lblTiempo";
            lblTiempo.Size = new Size(76, 25);
            lblTiempo.Text = "Tiempo:";
            lblTiempo.Click += lblTiempo_Click;
            // 
            // lblUsuario
            // 
            lblUsuario.BackColor = SystemColors.ControlDarkDark;
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(24, 25);
            lblUsuario.Text = "...";
            // 
            // guiaDeRemisionToolStripMenuItem
            // 
            guiaDeRemisionToolStripMenuItem.Name = "guiaDeRemisionToolStripMenuItem";
            guiaDeRemisionToolStripMenuItem.Size = new Size(303, 34);
            guiaDeRemisionToolStripMenuItem.Text = "Guia de Remision";
            guiaDeRemisionToolStripMenuItem.Click += guiaDeRemisionToolStripMenuItem_Click;
            // 
            // MDIprincipal
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            BackgroundImage = Properties.Resources.consultorio_medico_vacio_equipos_e_instrumentos_482257_27314;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1000, 564);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Margin = new Padding(4, 4, 4, 4);
            Name = "MDIprincipal";
            WindowState = FormWindowState.Maximized;
            FormClosing += MDIprincipal_FormClosing;
            FormClosed += MDIprincipal_FormClosed;
            Load += MDIprincipal_Load;
            Resize += MDIprincipal_Resize;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private System.Windows.Forms.Timer timer1;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel lblEquipo;
        private ToolStripStatusLabel lblTiempo;
        private ToolStripStatusLabel lblUsuario;
        private ToolStripMenuItem consultaToolStripMenuItem;
        private ToolStripMenuItem accionesToolStripMenuItem;
        private ToolStripMenuItem mantenimientoEquiposToolStripMenuItem;
        private ToolStripMenuItem salirToolStripMenuItem;
        private ToolStripMenuItem guiaDeRemisionToolStripMenuItem;
    }
}