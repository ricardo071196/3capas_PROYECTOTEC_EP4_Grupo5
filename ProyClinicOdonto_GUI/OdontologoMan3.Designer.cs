namespace ProyClinicOdonto_GUI
{
    partial class OdontologoMan3
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
            groupBox1 = new GroupBox();
            optInactivo = new RadioButton();
            optActivo = new RadioButton();
            mskTelefono = new MaskedTextBox();
            gbGenero = new GroupBox();
            rbFemen = new RadioButton();
            rbMascu = new RadioButton();
            txtDireccion = new TextBox();
            lbCodOdo = new Label();
            lblCodOdon = new Label();
            txtEmail = new TextBox();
            txtApeOdo = new TextBox();
            txtNomOdo = new TextBox();
            btnCancelar = new Button();
            btnGrabar = new Button();
            label10 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            cboDistrito = new ComboBox();
            label7 = new Label();
            grpDatos.SuspendLayout();
            groupBox1.SuspendLayout();
            gbGenero.SuspendLayout();
            SuspendLayout();
            // 
            // grpDatos
            // 
            grpDatos.Controls.Add(label7);
            grpDatos.Controls.Add(cboDistrito);
            grpDatos.Controls.Add(groupBox1);
            grpDatos.Controls.Add(mskTelefono);
            grpDatos.Controls.Add(gbGenero);
            grpDatos.Controls.Add(txtDireccion);
            grpDatos.Controls.Add(lbCodOdo);
            grpDatos.Controls.Add(lblCodOdon);
            grpDatos.Controls.Add(txtEmail);
            grpDatos.Controls.Add(txtApeOdo);
            grpDatos.Controls.Add(txtNomOdo);
            grpDatos.Controls.Add(btnCancelar);
            grpDatos.Controls.Add(btnGrabar);
            grpDatos.Controls.Add(label10);
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
            grpDatos.Size = new Size(700, 548);
            grpDatos.TabIndex = 0;
            grpDatos.TabStop = false;
            grpDatos.Text = "Datos:";
            grpDatos.Enter += grpDatos_Enter;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(optInactivo);
            groupBox1.Controls.Add(optActivo);
            groupBox1.Location = new Point(262, 407);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(244, 53);
            groupBox1.TabIndex = 31;
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
            optActivo.CheckedChanged += optActivo_CheckedChanged;
            // 
            // mskTelefono
            // 
            mskTelefono.Location = new Point(262, 365);
            mskTelefono.Mask = "999999999";
            mskTelefono.Name = "mskTelefono";
            mskTelefono.Size = new Size(172, 28);
            mskTelefono.TabIndex = 4;
            // 
            // gbGenero
            // 
            gbGenero.Controls.Add(rbFemen);
            gbGenero.Controls.Add(rbMascu);
            gbGenero.Location = new Point(262, 142);
            gbGenero.Name = "gbGenero";
            gbGenero.Size = new Size(253, 47);
            gbGenero.TabIndex = 27;
            gbGenero.TabStop = false;
            // 
            // rbFemen
            // 
            rbFemen.AutoSize = true;
            rbFemen.Location = new Point(133, 16);
            rbFemen.Name = "rbFemen";
            rbFemen.Size = new Size(111, 23);
            rbFemen.TabIndex = 1;
            rbFemen.TabStop = true;
            rbFemen.Text = "Femenino";
            rbFemen.UseVisualStyleBackColor = true;
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
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(262, 247);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(299, 28);
            txtDireccion.TabIndex = 3;
            // 
            // lbCodOdo
            // 
            lbCodOdo.BorderStyle = BorderStyle.FixedSingle;
            lbCodOdo.Location = new Point(262, 20);
            lbCodOdo.Margin = new Padding(4, 0, 4, 0);
            lbCodOdo.Name = "lbCodOdo";
            lbCodOdo.Size = new Size(72, 26);
            lbCodOdo.TabIndex = 0;
            lbCodOdo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblCodOdon
            // 
            lblCodOdon.AutoSize = true;
            lblCodOdon.Location = new Point(32, 27);
            lblCodOdon.Name = "lblCodOdon";
            lblCodOdon.Size = new Size(205, 19);
            lblCodOdon.TabIndex = 0;
            lblCodOdon.Text = "Codigo de Odontologo:";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(262, 201);
            txtEmail.Margin = new Padding(4);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(299, 28);
            txtEmail.TabIndex = 2;
            // 
            // txtApeOdo
            // 
            txtApeOdo.Location = new Point(262, 108);
            txtApeOdo.Name = "txtApeOdo";
            txtApeOdo.Size = new Size(299, 28);
            txtApeOdo.TabIndex = 1;
            // 
            // txtNomOdo
            // 
            txtNomOdo.Cursor = Cursors.IBeam;
            txtNomOdo.Location = new Point(262, 66);
            txtNomOdo.Margin = new Padding(4);
            txtNomOdo.Name = "txtNomOdo";
            txtNomOdo.Size = new Size(299, 28);
            txtNomOdo.TabIndex = 0;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.OrangeRed;
            btnCancelar.Location = new Point(559, 491);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(120, 50);
            btnCancelar.TabIndex = 6;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click_1;
            // 
            // btnGrabar
            // 
            btnGrabar.BackColor = Color.RoyalBlue;
            btnGrabar.Location = new Point(420, 491);
            btnGrabar.Name = "btnGrabar";
            btnGrabar.Size = new Size(120, 50);
            btnGrabar.TabIndex = 5;
            btnGrabar.Text = "Grabar";
            btnGrabar.UseVisualStyleBackColor = false;
            btnGrabar.Click += btnGrabar_Click_1;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(32, 420);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(198, 19);
            label10.TabIndex = 20;
            label10.Text = "Estado de Odontologo:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(32, 368);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(84, 19);
            label6.TabIndex = 12;
            label6.Text = "Telefono:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(32, 256);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(93, 19);
            label5.TabIndex = 10;
            label5.Text = "Direccion:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(32, 204);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(58, 19);
            label4.TabIndex = 8;
            label4.Text = "Email:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(32, 156);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(76, 19);
            label3.TabIndex = 6;
            label3.Text = "Genero:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(32, 113);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(213, 19);
            label2.TabIndex = 4;
            label2.Text = "Apellido de Odontologo:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 69);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(211, 19);
            label1.TabIndex = 2;
            label1.Text = "Nombre de Odontologo:";
            // 
            // cboDistrito
            // 
            cboDistrito.BackColor = SystemColors.ScrollBar;
            cboDistrito.DropDownStyle = ComboBoxStyle.DropDownList;
            cboDistrito.FormattingEnabled = true;
            cboDistrito.Location = new Point(262, 308);
            cboDistrito.Name = "cboDistrito";
            cboDistrito.Size = new Size(253, 27);
            cboDistrito.TabIndex = 40;
            cboDistrito.UseWaitCursor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(32, 308);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(66, 19);
            label7.TabIndex = 41;
            label7.Text = "Distrito:";
            // 
            // OdontologoMan3
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 192, 192);
            ClientSize = new Size(752, 570);
            Controls.Add(grpDatos);
            Font = new Font("Century Gothic", 8F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = SystemColors.ButtonHighlight;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "OdontologoMan3";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Actualizar Odontologo";
            Load += OdontologoMan3_Load_1;
            grpDatos.ResumeLayout(false);
            grpDatos.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            gbGenero.ResumeLayout(false);
            gbGenero.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpDatos;
        private TextBox txtDireccion;
        internal Label lbCodOdo;
        private Label lblCodOdon;
        private TextBox txtEmail;
        private TextBox txtApeOdo;
        private TextBox txtNomOdo;
        private Button btnCancelar;
        private Button btnGrabar;
        private Label label10;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private GroupBox gbGenero;
        private RadioButton rbFemen;
        private RadioButton rbMascu;
        private MaskedTextBox mskTelefono;
        private GroupBox groupBox1;
        private RadioButton optInactivo;
        private RadioButton optActivo;
        private Label label7;
        private ComboBox cboDistrito;
    }
}