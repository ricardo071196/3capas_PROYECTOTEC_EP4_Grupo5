namespace ProyClinicOdonto_GUI
{
    partial class EquipoMan2
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
            chkActivo = new CheckBox();
            label4 = new Label();
            cboTipo = new ComboBox();
            txtDesc = new TextBox();
            txtNomEqui = new TextBox();
            btnCancelar = new Button();
            btnGrabar = new Button();
            label6 = new Label();
            label2 = new Label();
            label1 = new Label();
            grpDatos.SuspendLayout();
            SuspendLayout();
            // 
            // grpDatos
            // 
            grpDatos.Controls.Add(cboPiso);
            grpDatos.Controls.Add(label7);
            grpDatos.Controls.Add(chkActivo);
            grpDatos.Controls.Add(label4);
            grpDatos.Controls.Add(cboTipo);
            grpDatos.Controls.Add(txtDesc);
            grpDatos.Controls.Add(txtNomEqui);
            grpDatos.Controls.Add(btnCancelar);
            grpDatos.Controls.Add(btnGrabar);
            grpDatos.Controls.Add(label6);
            grpDatos.Controls.Add(label2);
            grpDatos.Controls.Add(label1);
            grpDatos.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            grpDatos.Location = new Point(29, 28);
            grpDatos.Margin = new Padding(4);
            grpDatos.Name = "grpDatos";
            grpDatos.Padding = new Padding(4);
            grpDatos.Size = new Size(802, 507);
            grpDatos.TabIndex = 0;
            grpDatos.TabStop = false;
            grpDatos.Text = "Datos:";
            // 
            // cboPiso
            // 
            cboPiso.DropDownStyle = ComboBoxStyle.DropDownList;
            cboPiso.FormattingEnabled = true;
            cboPiso.Items.AddRange(new object[] { "Quirurgico", "Asistencial", "Maquinaria", "Manual", "Rayos X", "Instrumento" });
            cboPiso.Location = new Point(254, 211);
            cboPiso.Name = "cboPiso";
            cboPiso.Size = new Size(192, 27);
            cboPiso.TabIndex = 27;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(45, 211);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(47, 19);
            label7.TabIndex = 26;
            label7.Text = "Piso:";
            // 
            // chkActivo
            // 
            chkActivo.AutoSize = true;
            chkActivo.Location = new Point(257, 284);
            chkActivo.Name = "chkActivo";
            chkActivo.Size = new Size(84, 23);
            chkActivo.TabIndex = 4;
            chkActivo.Text = "Activo";
            chkActivo.UseVisualStyleBackColor = true;
            chkActivo.UseWaitCursor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(45, 284);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(68, 19);
            label4.TabIndex = 24;
            label4.Text = "Estado:";
            label4.UseWaitCursor = true;
            // 
            // cboTipo
            // 
            cboTipo.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTipo.FormattingEnabled = true;
            cboTipo.Items.AddRange(new object[] { "Quirurgico", "Asistencial", "Maquinaria", "Manual", "Rayos X", "Instrumento" });
            cboTipo.Location = new Point(254, 150);
            cboTipo.Name = "cboTipo";
            cboTipo.Size = new Size(275, 27);
            cboTipo.TabIndex = 1;
            // 
            // txtDesc
            // 
            txtDesc.Location = new Point(257, 86);
            txtDesc.Margin = new Padding(4);
            txtDesc.Name = "txtDesc";
            txtDesc.Size = new Size(370, 28);
            txtDesc.TabIndex = 3;
            // 
            // txtNomEqui
            // 
            txtNomEqui.Cursor = Cursors.IBeam;
            txtNomEqui.Location = new Point(257, 37);
            txtNomEqui.Margin = new Padding(4);
            txtNomEqui.Name = "txtNomEqui";
            txtNomEqui.Size = new Size(278, 28);
            txtNomEqui.TabIndex = 0;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.OrangeRed;
            btnCancelar.Location = new Point(664, 423);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(120, 50);
            btnCancelar.TabIndex = 8;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click_1;
            // 
            // btnGrabar
            // 
            btnGrabar.BackColor = Color.RoyalBlue;
            btnGrabar.Location = new Point(507, 423);
            btnGrabar.Name = "btnGrabar";
            btnGrabar.Size = new Size(120, 50);
            btnGrabar.TabIndex = 7;
            btnGrabar.Text = "Grabar";
            btnGrabar.UseVisualStyleBackColor = false;
            btnGrabar.Click += btnGrabar_Click_1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(45, 95);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(112, 19);
            label6.TabIndex = 10;
            label6.Text = "Descripcion:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(45, 150);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(47, 19);
            label2.TabIndex = 2;
            label2.Text = "Tipo:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(39, 45);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(169, 19);
            label1.TabIndex = 0;
            label1.Text = "Nombre de Equipo:";
            // 
            // EquipoMan2
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 192, 192);
            ClientSize = new Size(847, 553);
            Controls.Add(grpDatos);
            Font = new Font("Century Gothic", 8F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.Snow;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "EquipoMan2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Insertar Equipo";
            Load += EquipoMan2_Load_1;
            grpDatos.ResumeLayout(false);
            grpDatos.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpDatos;
        private Label label6;
        private Label label2;
        private Label label1;
        private TextBox txtDesc;
        private TextBox txtNomEqui;
        private Button btnCancelar;
        private Button btnGrabar;
        private ComboBox cboTipo;
        private CheckBox chkActivo;
        private Label label4;
        private ComboBox cboPiso;
        private Label label7;
    }
}