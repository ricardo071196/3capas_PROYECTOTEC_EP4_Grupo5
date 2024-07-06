namespace ProyClinicOdonto_GUI
{
    partial class ReservaMan3
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
            grpDatos = new GroupBox();
            cboConsultorio = new ComboBox();
            label5 = new Label();
            lblDni = new Label();
            groupBox1 = new GroupBox();
            optInactivo = new RadioButton();
            optActivo = new RadioButton();
            label10 = new Label();
            cboOdontologosac = new ComboBox();
            txtHORA = new TextBox();
            label4 = new Label();
            txtDetalle = new TextBox();
            label3 = new Label();
            dtpFechaReserac = new DateTimePicker();
            label9 = new Label();
            lblIdreserva = new Label();
            lblNumSerie = new Label();
            btnCancelar = new Button();
            btnGrabar = new Button();
            label2 = new Label();
            label1 = new Label();
            grpDatos.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // grpDatos
            // 
            grpDatos.Controls.Add(cboConsultorio);
            grpDatos.Controls.Add(label5);
            grpDatos.Controls.Add(lblDni);
            grpDatos.Controls.Add(groupBox1);
            grpDatos.Controls.Add(label10);
            grpDatos.Controls.Add(cboOdontologosac);
            grpDatos.Controls.Add(txtHORA);
            grpDatos.Controls.Add(label4);
            grpDatos.Controls.Add(txtDetalle);
            grpDatos.Controls.Add(label3);
            grpDatos.Controls.Add(dtpFechaReserac);
            grpDatos.Controls.Add(label9);
            grpDatos.Controls.Add(lblIdreserva);
            grpDatos.Controls.Add(lblNumSerie);
            grpDatos.Controls.Add(btnCancelar);
            grpDatos.Controls.Add(btnGrabar);
            grpDatos.Controls.Add(label2);
            grpDatos.Controls.Add(label1);
            grpDatos.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            grpDatos.ForeColor = SystemColors.ButtonHighlight;
            grpDatos.Location = new Point(120, 27);
            grpDatos.Margin = new Padding(5, 4, 5, 4);
            grpDatos.Name = "grpDatos";
            grpDatos.Padding = new Padding(5, 4, 5, 4);
            grpDatos.Size = new Size(690, 729);
            grpDatos.TabIndex = 2;
            grpDatos.TabStop = false;
            grpDatos.Text = "Datos:";
            grpDatos.Enter += grpDatos_Enter;
            // 
            // cboConsultorio
            // 
            cboConsultorio.BackColor = SystemColors.ScrollBar;
            cboConsultorio.DropDownStyle = ComboBoxStyle.DropDownList;
            cboConsultorio.FormattingEnabled = true;
            cboConsultorio.Location = new Point(237, 370);
            cboConsultorio.Name = "cboConsultorio";
            cboConsultorio.Size = new Size(229, 27);
            cboConsultorio.TabIndex = 56;
            cboConsultorio.UseWaitCursor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(35, 378);
            label5.Margin = new Padding(5, 0, 5, 0);
            label5.Name = "label5";
            label5.Size = new Size(105, 19);
            label5.TabIndex = 55;
            label5.Text = "Consultorio:";
            // 
            // lblDni
            // 
            lblDni.BorderStyle = BorderStyle.FixedSingle;
            lblDni.Location = new Point(237, 88);
            lblDni.Margin = new Padding(5, 0, 5, 0);
            lblDni.Name = "lblDni";
            lblDni.Size = new Size(114, 26);
            lblDni.TabIndex = 54;
            lblDni.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(optInactivo);
            groupBox1.Controls.Add(optActivo);
            groupBox1.Location = new Point(237, 499);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(245, 53);
            groupBox1.TabIndex = 53;
            groupBox1.TabStop = false;
            // 
            // optInactivo
            // 
            optInactivo.AutoSize = true;
            optInactivo.Location = new Point(133, 24);
            optInactivo.Name = "optInactivo";
            optInactivo.Size = new Size(96, 23);
            optInactivo.TabIndex = 1;
            optInactivo.TabStop = true;
            optInactivo.Text = "Inactivo";
            optInactivo.UseVisualStyleBackColor = true;
            // 
            // optActivo
            // 
            optActivo.AutoSize = true;
            optActivo.Location = new Point(18, 24);
            optActivo.Name = "optActivo";
            optActivo.Size = new Size(83, 23);
            optActivo.TabIndex = 0;
            optActivo.TabStop = true;
            optActivo.Text = "Activo";
            optActivo.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(40, 523);
            label10.Margin = new Padding(5, 0, 5, 0);
            label10.Name = "label10";
            label10.Size = new Size(166, 19);
            label10.TabIndex = 52;
            label10.Text = "Estado de Reserva.";
            // 
            // cboOdontologosac
            // 
            cboOdontologosac.BackColor = SystemColors.ScrollBar;
            cboOdontologosac.DropDownStyle = ComboBoxStyle.DropDownList;
            cboOdontologosac.FormattingEnabled = true;
            cboOdontologosac.Location = new Point(237, 153);
            cboOdontologosac.Name = "cboOdontologosac";
            cboOdontologosac.Size = new Size(323, 27);
            cboOdontologosac.TabIndex = 50;
            cboOdontologosac.UseWaitCursor = true;
            cboOdontologosac.SelectedIndexChanged += cboOdontologosac_SelectedIndexChanged;
            // 
            // txtHORA
            // 
            txtHORA.Cursor = Cursors.IBeam;
            txtHORA.Location = new Point(237, 296);
            txtHORA.Margin = new Padding(5, 4, 5, 4);
            txtHORA.Name = "txtHORA";
            txtHORA.Size = new Size(106, 28);
            txtHORA.TabIndex = 48;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(35, 443);
            label4.Margin = new Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new Size(71, 19);
            label4.TabIndex = 47;
            label4.Text = "Detalle:";
            // 
            // txtDetalle
            // 
            txtDetalle.Cursor = Cursors.IBeam;
            txtDetalle.Location = new Point(237, 434);
            txtDetalle.Margin = new Padding(5, 4, 5, 4);
            txtDetalle.Name = "txtDetalle";
            txtDetalle.Size = new Size(412, 28);
            txtDetalle.TabIndex = 46;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(35, 305);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(88, 19);
            label3.TabIndex = 45;
            label3.Text = "Hora cita:";
            // 
            // dtpFechaReserac
            // 
            dtpFechaReserac.Location = new Point(237, 219);
            dtpFechaReserac.Name = "dtpFechaReserac";
            dtpFechaReserac.Size = new Size(370, 28);
            dtpFechaReserac.TabIndex = 43;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(40, 228);
            label9.Margin = new Padding(5, 0, 5, 0);
            label9.Name = "label9";
            label9.Size = new Size(100, 19);
            label9.TabIndex = 44;
            label9.Text = "Fecha cita:";
            // 
            // lblIdreserva
            // 
            lblIdreserva.BorderStyle = BorderStyle.FixedSingle;
            lblIdreserva.Location = new Point(237, 37);
            lblIdreserva.Margin = new Padding(5, 0, 5, 0);
            lblIdreserva.Name = "lblIdreserva";
            lblIdreserva.Size = new Size(114, 26);
            lblIdreserva.TabIndex = 0;
            lblIdreserva.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblNumSerie
            // 
            lblNumSerie.AutoSize = true;
            lblNumSerie.Location = new Point(41, 39);
            lblNumSerie.Name = "lblNumSerie";
            lblNumSerie.Size = new Size(96, 19);
            lblNumSerie.TabIndex = 0;
            lblNumSerie.Text = "IdReserva:";
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.OrangeRed;
            btnCancelar.Location = new Point(487, 584);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(120, 51);
            btnCancelar.TabIndex = 8;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            // 
            // btnGrabar
            // 
            btnGrabar.BackColor = Color.RoyalBlue;
            btnGrabar.Location = new Point(301, 584);
            btnGrabar.Name = "btnGrabar";
            btnGrabar.Size = new Size(120, 51);
            btnGrabar.TabIndex = 7;
            btnGrabar.Text = "Grabar";
            btnGrabar.UseVisualStyleBackColor = false;
            btnGrabar.Click += btnGrabar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(35, 156);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(112, 19);
            label2.TabIndex = 4;
            label2.Text = "Odontologo:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(41, 88);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(40, 19);
            label1.TabIndex = 2;
            label1.Text = "Dni:";
            // 
            // ReservaMan3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(936, 780);
            Controls.Add(grpDatos);
            Name = "ReservaMan3";
            Text = "ReservaMan3";
            Load += ReservaMan3_Load;
            grpDatos.ResumeLayout(false);
            grpDatos.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpDatos;
        internal Label lblIdreserva;
        private Label lblNumSerie;
        private Button btnCancelar;
        private Button btnGrabar;
        private Label label2;
        private Label label1;
        private TextBox txtHORA;
        private Label label4;
        private TextBox txtDetalle;
        private Label label3;
        private DateTimePicker dtpFechaReserac;
        private Label label9;
        private ComboBox cboOdontologosac;
        private GroupBox groupBox1;
        private RadioButton optInactivo;
        private RadioButton optActivo;
        private Label label10;
        internal Label lblDni;
        private ComboBox cboConsultorio;
        private Label label5;
    }
}