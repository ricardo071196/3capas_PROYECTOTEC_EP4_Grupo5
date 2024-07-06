namespace ProyClinicOdonto_GUI
{
    partial class ReservaMan2
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
            label2 = new Label();
            cboOdontologos = new ComboBox();
            txtHORA = new TextBox();
            label5 = new Label();
            label4 = new Label();
            txtDetalle = new TextBox();
            mskPACIENTE = new MaskedTextBox();
            chkActivo = new CheckBox();
            label3 = new Label();
            dtpFechaReser = new DateTimePicker();
            btnCancelar = new Button();
            btnGrabar = new Button();
            label9 = new Label();
            label1 = new Label();
            grpDatos.SuspendLayout();
            SuspendLayout();
            // 
            // grpDatos
            // 
            grpDatos.Controls.Add(cboConsultorio);
            grpDatos.Controls.Add(label2);
            grpDatos.Controls.Add(cboOdontologos);
            grpDatos.Controls.Add(txtHORA);
            grpDatos.Controls.Add(label5);
            grpDatos.Controls.Add(label4);
            grpDatos.Controls.Add(txtDetalle);
            grpDatos.Controls.Add(mskPACIENTE);
            grpDatos.Controls.Add(chkActivo);
            grpDatos.Controls.Add(label3);
            grpDatos.Controls.Add(dtpFechaReser);
            grpDatos.Controls.Add(btnCancelar);
            grpDatos.Controls.Add(btnGrabar);
            grpDatos.Controls.Add(label9);
            grpDatos.Controls.Add(label1);
            grpDatos.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            grpDatos.Location = new Point(49, 38);
            grpDatos.Margin = new Padding(4);
            grpDatos.Name = "grpDatos";
            grpDatos.Padding = new Padding(4);
            grpDatos.Size = new Size(806, 503);
            grpDatos.TabIndex = 1;
            grpDatos.TabStop = false;
            grpDatos.Text = "Datos:";
            // 
            // cboConsultorio
            // 
            cboConsultorio.BackColor = SystemColors.ScrollBar;
            cboConsultorio.DropDownStyle = ComboBoxStyle.DropDownList;
            cboConsultorio.FormattingEnabled = true;
            cboConsultorio.Location = new Point(206, 294);
            cboConsultorio.Name = "cboConsultorio";
            cboConsultorio.Size = new Size(253, 27);
            cboConsultorio.TabIndex = 45;
            cboConsultorio.UseWaitCursor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(52, 302);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(105, 19);
            label2.TabIndex = 44;
            label2.Text = "Consultorio:";
            // 
            // cboOdontologos
            // 
            cboOdontologos.BackColor = SystemColors.ScrollBar;
            cboOdontologos.DropDownStyle = ComboBoxStyle.DropDownList;
            cboOdontologos.FormattingEnabled = true;
            cboOdontologos.Location = new Point(206, 225);
            cboOdontologos.Name = "cboOdontologos";
            cboOdontologos.Size = new Size(310, 27);
            cboOdontologos.TabIndex = 43;
            cboOdontologos.UseWaitCursor = true;
            cboOdontologos.SelectedIndexChanged += cboOdontologos_SelectedIndexChanged;
            // 
            // txtHORA
            // 
            txtHORA.Cursor = Cursors.IBeam;
            txtHORA.Location = new Point(206, 158);
            txtHORA.Margin = new Padding(4);
            txtHORA.Name = "txtHORA";
            txtHORA.Size = new Size(106, 28);
            txtHORA.TabIndex = 42;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(52, 233);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(112, 19);
            label5.TabIndex = 39;
            label5.Text = "Odontologo:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(52, 360);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(71, 19);
            label4.TabIndex = 38;
            label4.Text = "Detalle:";
            // 
            // txtDetalle
            // 
            txtDetalle.Cursor = Cursors.IBeam;
            txtDetalle.Location = new Point(206, 351);
            txtDetalle.Margin = new Padding(4);
            txtDetalle.Name = "txtDetalle";
            txtDetalle.Size = new Size(421, 28);
            txtDetalle.TabIndex = 37;
            // 
            // mskPACIENTE
            // 
            mskPACIENTE.Location = new Point(206, 42);
            mskPACIENTE.Mask = "99999999";
            mskPACIENTE.Name = "mskPACIENTE";
            mskPACIENTE.Size = new Size(106, 28);
            mskPACIENTE.TabIndex = 36;
            // 
            // chkActivo
            // 
            chkActivo.AutoSize = true;
            chkActivo.Location = new Point(206, 400);
            chkActivo.Name = "chkActivo";
            chkActivo.Size = new Size(84, 23);
            chkActivo.TabIndex = 4;
            chkActivo.Text = "Activo";
            chkActivo.UseVisualStyleBackColor = true;
            chkActivo.UseWaitCursor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(52, 167);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(88, 19);
            label3.TabIndex = 22;
            label3.Text = "Hora cita:";
            // 
            // dtpFechaReser
            // 
            dtpFechaReser.Location = new Point(206, 94);
            dtpFechaReser.Name = "dtpFechaReser";
            dtpFechaReser.Size = new Size(370, 28);
            dtpFechaReser.TabIndex = 6;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.OrangeRed;
            btnCancelar.Location = new Point(562, 446);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(120, 50);
            btnCancelar.TabIndex = 8;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            // 
            // btnGrabar
            // 
            btnGrabar.BackColor = Color.RoyalBlue;
            btnGrabar.Location = new Point(421, 446);
            btnGrabar.Name = "btnGrabar";
            btnGrabar.Size = new Size(120, 50);
            btnGrabar.TabIndex = 7;
            btnGrabar.Text = "Grabar";
            btnGrabar.UseVisualStyleBackColor = false;
            btnGrabar.Click += btnGrabar_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(52, 101);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(100, 19);
            label9.TabIndex = 16;
            label9.Text = "Fecha cita:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(52, 42);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(44, 19);
            label1.TabIndex = 0;
            label1.Text = "DNI:";
            // 
            // ReservaMan2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(890, 544);
            Controls.Add(grpDatos);
            Name = "ReservaMan2";
            Text = "ReservaMan2";
            Load += ReservaMan2_Load;
            grpDatos.ResumeLayout(false);
            grpDatos.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpDatos;
        private CheckBox chkActivo;
        private Label label3;
        private DateTimePicker dtpFechaReser;
        private Button btnCancelar;
        private Button btnGrabar;
        private Label label9;
        private Label label1;
        private MaskedTextBox mskPACIENTE;
        private Label label5;
        private Label label4;
        private TextBox txtDetalle;
        private TextBox txtHORA;
        private ComboBox cboOdontologos;
        private ComboBox cboConsultorio;
        private Label label2;
    }
}