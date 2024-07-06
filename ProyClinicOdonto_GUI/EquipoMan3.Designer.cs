namespace ProyClinicOdonto_GUI
{
    partial class EquipoMan3
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
            cboPiso = new ComboBox();
            label7 = new Label();
            txtObservacion = new TextBox();
            label2 = new Label();
            mskStock = new MaskedTextBox();
            label5 = new Label();
            groupBox1 = new GroupBox();
            optInactivo = new RadioButton();
            optActivo = new RadioButton();
            label10 = new Label();
            lblNumSer = new Label();
            lbl = new Label();
            txtDesc = new TextBox();
            txtNomEqui = new TextBox();
            btnCancelar = new Button();
            btnGrabar = new Button();
            label6 = new Label();
            label1 = new Label();
            grpDatos.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // grpDatos
            // 
            grpDatos.Controls.Add(cboPiso);
            grpDatos.Controls.Add(label7);
            grpDatos.Controls.Add(txtObservacion);
            grpDatos.Controls.Add(label2);
            grpDatos.Controls.Add(mskStock);
            grpDatos.Controls.Add(label5);
            grpDatos.Controls.Add(groupBox1);
            grpDatos.Controls.Add(label10);
            grpDatos.Controls.Add(lblNumSer);
            grpDatos.Controls.Add(lbl);
            grpDatos.Controls.Add(txtDesc);
            grpDatos.Controls.Add(txtNomEqui);
            grpDatos.Controls.Add(btnCancelar);
            grpDatos.Controls.Add(btnGrabar);
            grpDatos.Controls.Add(label6);
            grpDatos.Controls.Add(label1);
            grpDatos.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            grpDatos.Location = new Point(35, 29);
            grpDatos.Margin = new Padding(5);
            grpDatos.Name = "grpDatos";
            grpDatos.Padding = new Padding(5);
            grpDatos.Size = new Size(668, 580);
            grpDatos.TabIndex = 0;
            grpDatos.TabStop = false;
            grpDatos.Text = "Datos:";
            grpDatos.Enter += grpDatos_Enter_1;
            // 
            // cboPiso
            // 
            cboPiso.DropDownStyle = ComboBoxStyle.DropDownList;
            cboPiso.FormattingEnabled = true;
            cboPiso.Items.AddRange(new object[] { "Quirurgico", "Asistencial", "Maquinaria", "Manual", "Rayos X", "Instrumento" });
            cboPiso.Location = new Point(199, 225);
            cboPiso.Name = "cboPiso";
            cboPiso.Size = new Size(89, 27);
            cboPiso.TabIndex = 46;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(24, 233);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(47, 19);
            label7.TabIndex = 45;
            label7.Text = "Piso:";
            // 
            // txtObservacion
            // 
            txtObservacion.Location = new Point(198, 375);
            txtObservacion.Margin = new Padding(5);
            txtObservacion.Name = "txtObservacion";
            txtObservacion.Size = new Size(358, 28);
            txtObservacion.TabIndex = 44;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(19, 382);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(120, 19);
            label2.TabIndex = 43;
            label2.Text = "Observacion:";
            label2.Click += label2_Click;
            // 
            // mskStock
            // 
            mskStock.Location = new Point(198, 297);
            mskStock.Mask = "9999";
            mskStock.Name = "mskStock";
            mskStock.Size = new Size(115, 28);
            mskStock.TabIndex = 42;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(24, 300);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(59, 19);
            label5.TabIndex = 41;
            label5.Text = "Stock:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(optInactivo);
            groupBox1.Controls.Add(optActivo);
            groupBox1.Location = new Point(203, 440);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(229, 46);
            groupBox1.TabIndex = 40;
            groupBox1.TabStop = false;
            // 
            // optInactivo
            // 
            optInactivo.AutoSize = true;
            optInactivo.Location = new Point(127, 17);
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
            optActivo.Location = new Point(7, 17);
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
            label10.Location = new Point(24, 459);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(156, 19);
            label10.TabIndex = 39;
            label10.Text = "Estado de Equipo:";
            // 
            // lblNumSer
            // 
            lblNumSer.BorderStyle = BorderStyle.FixedSingle;
            lblNumSer.ForeColor = SystemColors.ButtonHighlight;
            lblNumSer.Location = new Point(198, 26);
            lblNumSer.Margin = new Padding(5, 0, 5, 0);
            lblNumSer.Name = "lblNumSer";
            lblNumSer.Size = new Size(90, 32);
            lblNumSer.TabIndex = 1;
            lblNumSer.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl
            // 
            lbl.AutoSize = true;
            lbl.Location = new Point(24, 38);
            lbl.Margin = new Padding(4, 0, 4, 0);
            lbl.Name = "lbl";
            lbl.Size = new Size(152, 19);
            lbl.TabIndex = 0;
            lbl.Text = "Numero de Serie:";
            // 
            // txtDesc
            // 
            txtDesc.Location = new Point(203, 148);
            txtDesc.Margin = new Padding(5);
            txtDesc.Name = "txtDesc";
            txtDesc.Size = new Size(358, 28);
            txtDesc.TabIndex = 2;
            // 
            // txtNomEqui
            // 
            txtNomEqui.Cursor = Cursors.IBeam;
            txtNomEqui.Location = new Point(203, 96);
            txtNomEqui.Margin = new Padding(5);
            txtNomEqui.Name = "txtNomEqui";
            txtNomEqui.Size = new Size(306, 28);
            txtNomEqui.TabIndex = 0;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.Red;
            btnCancelar.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancelar.Location = new Point(495, 521);
            btnCancelar.Margin = new Padding(4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(120, 50);
            btnCancelar.TabIndex = 4;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click_1;
            // 
            // btnGrabar
            // 
            btnGrabar.BackColor = Color.RoyalBlue;
            btnGrabar.Location = new Point(330, 521);
            btnGrabar.Margin = new Padding(4);
            btnGrabar.Name = "btnGrabar";
            btnGrabar.Size = new Size(120, 50);
            btnGrabar.TabIndex = 3;
            btnGrabar.Text = "Grabar";
            btnGrabar.UseVisualStyleBackColor = false;
            btnGrabar.Click += btnGrabar_Click_1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(24, 155);
            label6.Margin = new Padding(5, 0, 5, 0);
            label6.Name = "label6";
            label6.Size = new Size(112, 19);
            label6.TabIndex = 12;
            label6.Text = "Descripcion:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 99);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(169, 19);
            label1.TabIndex = 2;
            label1.Text = "Nombre de Equipo:";
            // 
            // EquipoMan3
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 192, 192);
            ClientSize = new Size(717, 623);
            Controls.Add(grpDatos);
            Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = SystemColors.ButtonHighlight;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "EquipoMan3";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Actualizar Equipo";
            Load += EquipoMan3_Load_1;
            grpDatos.ResumeLayout(false);
            grpDatos.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpDatos;
        private Button btnCancelar;
        private Button btnGrabar;
        private Label label6;
        private Label label1;
        private Label lbl;
        internal Label lblNumSer;
        private TextBox txtDesc;
        private TextBox txtNomEqui;
        private GroupBox groupBox1;
        private RadioButton optInactivo;
        private RadioButton optActivo;
        private Label label10;
        private Label label5;
        private TextBox txtObservacion;
        private Label label2;
        private MaskedTextBox mskStock;
        private ComboBox cboPiso;
        private Label label7;
    }
}