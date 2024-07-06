namespace ProyClinicOdonto_GUI
{
    partial class OdontologoMan2
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
            cboDistrito = new ComboBox();
            label12 = new Label();
            dtpFecing = new DateTimePicker();
            label11 = new Label();
            chkActivo = new CheckBox();
            mskTelefono = new MaskedTextBox();
            gbGenero = new GroupBox();
            rbFemen = new RadioButton();
            rbMascu = new RadioButton();
            txtDirec = new TextBox();
            txtEmail = new TextBox();
            txtApeOdon = new TextBox();
            txtNomOdon = new TextBox();
            btnCancelar = new Button();
            btnGrabar = new Button();
            label9 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            mskCOP = new MaskedTextBox();
            grpDatos.SuspendLayout();
            gbGenero.SuspendLayout();
            SuspendLayout();
            // 
            // grpDatos
            // 
            grpDatos.Controls.Add(mskCOP);
            grpDatos.Controls.Add(cboDistrito);
            grpDatos.Controls.Add(label12);
            grpDatos.Controls.Add(dtpFecing);
            grpDatos.Controls.Add(label11);
            grpDatos.Controls.Add(chkActivo);
            grpDatos.Controls.Add(mskTelefono);
            grpDatos.Controls.Add(gbGenero);
            grpDatos.Controls.Add(txtDirec);
            grpDatos.Controls.Add(txtEmail);
            grpDatos.Controls.Add(txtApeOdon);
            grpDatos.Controls.Add(txtNomOdon);
            grpDatos.Controls.Add(btnCancelar);
            grpDatos.Controls.Add(btnGrabar);
            grpDatos.Controls.Add(label9);
            grpDatos.Controls.Add(label7);
            grpDatos.Controls.Add(label6);
            grpDatos.Controls.Add(label5);
            grpDatos.Controls.Add(label4);
            grpDatos.Controls.Add(label3);
            grpDatos.Controls.Add(label2);
            grpDatos.Controls.Add(label1);
            grpDatos.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            grpDatos.Location = new Point(13, 14);
            grpDatos.Margin = new Padding(4);
            grpDatos.Name = "grpDatos";
            grpDatos.Padding = new Padding(4);
            grpDatos.Size = new Size(726, 523);
            grpDatos.TabIndex = 0;
            grpDatos.TabStop = false;
            grpDatos.Text = "Datos:";
            grpDatos.UseWaitCursor = true;
            grpDatos.Enter += grpDatos_Enter;
            // 
            // cboDistrito
            // 
            cboDistrito.BackColor = SystemColors.ScrollBar;
            cboDistrito.DropDownStyle = ComboBoxStyle.DropDownList;
            cboDistrito.FormattingEnabled = true;
            cboDistrito.Location = new Point(282, 313);
            cboDistrito.Name = "cboDistrito";
            cboDistrito.Size = new Size(253, 27);
            cboDistrito.TabIndex = 7;
            cboDistrito.UseWaitCursor = true;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(26, 321);
            label12.Name = "label12";
            label12.Size = new Size(66, 19);
            label12.TabIndex = 28;
            label12.Text = "Distrito:";
            label12.UseWaitCursor = true;
            // 
            // dtpFecing
            // 
            dtpFecing.Location = new Point(282, 361);
            dtpFecing.Name = "dtpFecing";
            dtpFecing.Size = new Size(367, 28);
            dtpFecing.TabIndex = 8;
            dtpFecing.UseWaitCursor = true;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(26, 365);
            label11.Name = "label11";
            label11.Size = new Size(161, 19);
            label11.TabIndex = 24;
            label11.Text = "Fecha de Registro:";
            label11.UseWaitCursor = true;
            // 
            // chkActivo
            // 
            chkActivo.AutoSize = true;
            chkActivo.Location = new Point(282, 280);
            chkActivo.Name = "chkActivo";
            chkActivo.Size = new Size(84, 23);
            chkActivo.TabIndex = 6;
            chkActivo.Text = "Activo";
            chkActivo.UseVisualStyleBackColor = true;
            chkActivo.UseWaitCursor = true;
            // 
            // mskTelefono
            // 
            mskTelefono.Location = new Point(282, 197);
            mskTelefono.Mask = "999999999";
            mskTelefono.Name = "mskTelefono";
            mskTelefono.Size = new Size(98, 28);
            mskTelefono.TabIndex = 4;
            mskTelefono.UseWaitCursor = true;
            // 
            // gbGenero
            // 
            gbGenero.Controls.Add(rbFemen);
            gbGenero.Controls.Add(rbMascu);
            gbGenero.Location = new Point(282, 395);
            gbGenero.Name = "gbGenero";
            gbGenero.Size = new Size(253, 47);
            gbGenero.TabIndex = 19;
            gbGenero.TabStop = false;
            gbGenero.UseWaitCursor = true;
            // 
            // rbFemen
            // 
            rbFemen.AutoSize = true;
            rbFemen.Location = new Point(136, 16);
            rbFemen.Name = "rbFemen";
            rbFemen.Size = new Size(111, 23);
            rbFemen.TabIndex = 1;
            rbFemen.TabStop = true;
            rbFemen.Text = "Femenino";
            rbFemen.UseVisualStyleBackColor = true;
            rbFemen.UseWaitCursor = true;
            // 
            // rbMascu
            // 
            rbMascu.AutoSize = true;
            rbMascu.Location = new Point(18, 16);
            rbMascu.Name = "rbMascu";
            rbMascu.Size = new Size(114, 23);
            rbMascu.TabIndex = 0;
            rbMascu.TabStop = true;
            rbMascu.Text = "Masculino";
            rbMascu.UseVisualStyleBackColor = true;
            rbMascu.UseWaitCursor = true;
            // 
            // txtDirec
            // 
            txtDirec.Location = new Point(282, 163);
            txtDirec.Name = "txtDirec";
            txtDirec.Size = new Size(253, 28);
            txtDirec.TabIndex = 3;
            txtDirec.UseWaitCursor = true;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(282, 127);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(253, 28);
            txtEmail.TabIndex = 2;
            txtEmail.UseWaitCursor = true;
            // 
            // txtApeOdon
            // 
            txtApeOdon.Location = new Point(282, 85);
            txtApeOdon.Name = "txtApeOdon";
            txtApeOdon.Size = new Size(253, 28);
            txtApeOdon.TabIndex = 1;
            txtApeOdon.UseWaitCursor = true;
            txtApeOdon.TextChanged += txtApeOdon_TextChanged;
            // 
            // txtNomOdon
            // 
            txtNomOdon.Cursor = Cursors.IBeam;
            txtNomOdon.Location = new Point(282, 38);
            txtNomOdon.Margin = new Padding(4);
            txtNomOdon.Name = "txtNomOdon";
            txtNomOdon.Size = new Size(253, 28);
            txtNomOdon.TabIndex = 0;
            txtNomOdon.UseWaitCursor = true;
            txtNomOdon.TextChanged += txtNomOdon_TextChanged;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.OrangeRed;
            btnCancelar.Location = new Point(599, 466);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(120, 50);
            btnCancelar.TabIndex = 10;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.UseWaitCursor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnGrabar
            // 
            btnGrabar.BackColor = Color.RoyalBlue;
            btnGrabar.Location = new Point(473, 466);
            btnGrabar.Name = "btnGrabar";
            btnGrabar.Size = new Size(120, 50);
            btnGrabar.TabIndex = 9;
            btnGrabar.Text = "Grabar";
            btnGrabar.UseVisualStyleBackColor = false;
            btnGrabar.UseWaitCursor = true;
            btnGrabar.Click += btnGrabar_Click_1;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(26, 281);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(198, 19);
            label9.TabIndex = 16;
            label9.Text = "Estado de Odontologo:";
            label9.UseWaitCursor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(30, 240);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(51, 19);
            label7.TabIndex = 12;
            label7.Text = "COP:";
            label7.UseWaitCursor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(28, 197);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(84, 19);
            label6.TabIndex = 10;
            label6.Text = "Telefono:";
            label6.UseWaitCursor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(28, 157);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(93, 19);
            label5.TabIndex = 8;
            label5.Text = "Direccion:";
            label5.UseWaitCursor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(28, 124);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(58, 19);
            label4.TabIndex = 6;
            label4.Text = "Email:";
            label4.UseWaitCursor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(26, 412);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(206, 19);
            label3.TabIndex = 4;
            label3.Text = "Genero de Odontologo:";
            label3.UseWaitCursor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 85);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(213, 19);
            label2.TabIndex = 2;
            label2.Text = "Apellido de Odontologo:";
            label2.UseWaitCursor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 41);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(211, 19);
            label1.TabIndex = 0;
            label1.Text = "Nombre de Odontologo:";
            label1.UseWaitCursor = true;
            label1.Click += label1_Click;
            // 
            // mskCOP
            // 
            mskCOP.Location = new Point(282, 246);
            mskCOP.Mask = "999999999";
            mskCOP.Name = "mskCOP";
            mskCOP.Size = new Size(98, 28);
            mskCOP.TabIndex = 29;
            mskCOP.UseWaitCursor = true;
            // 
            // OdontologoMan2
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 192, 192);
            ClientSize = new Size(752, 550);
            Controls.Add(grpDatos);
            Font = new Font("Century Gothic", 8F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = SystemColors.ButtonHighlight;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "OdontologoMan2";
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Registro de Odontologo";
            UseWaitCursor = true;
            Load += OdontologoMan2_Load;
            grpDatos.ResumeLayout(false);
            grpDatos.PerformLayout();
            gbGenero.ResumeLayout(false);
            gbGenero.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpDatos;
        private MaskedTextBox mskValor;
        private DateTimePicker dtpFechaReg;
        private DateTimePicker dtpFechaAdqui;
        private DateTimePicker dtpFechaMan;
        private TextBox txtApeOdon;
        private TextBox txtNomOdon;
        private Button btnCancelar;
        private Button btnGrabar;
        private Label label9;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtDirec;
        private TextBox txtEmail;
        private MaskedTextBox mskTelefono;
        private GroupBox gbGenero;
        private RadioButton rbFemen;
        private RadioButton rbMascu;
        private CheckBox chkActivo;
        private DateTimePicker dtpFecing;
        private Label label11;
        private Label label12;
        private ComboBox cboDistrito;
        private MaskedTextBox mskCOP;
    }
}