namespace ProyClinicOdonto_GUI
{
    partial class AdministradorMan2
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
            cboEstado = new ComboBox();
            cboFuente = new ComboBox();
            label3 = new Label();
            txtPass_Usuario = new TextBox();
            txtLogin_Usuario = new TextBox();
            dtpFechaReg = new DateTimePicker();
            btnCancelar = new Button();
            btnGrabar = new Button();
            label9 = new Label();
            label6 = new Label();
            label2 = new Label();
            label1 = new Label();
            grpDatos.SuspendLayout();
            SuspendLayout();
            // 
            // grpDatos
            // 
            grpDatos.Controls.Add(cboEstado);
            grpDatos.Controls.Add(cboFuente);
            grpDatos.Controls.Add(label3);
            grpDatos.Controls.Add(txtPass_Usuario);
            grpDatos.Controls.Add(txtLogin_Usuario);
            grpDatos.Controls.Add(dtpFechaReg);
            grpDatos.Controls.Add(btnCancelar);
            grpDatos.Controls.Add(btnGrabar);
            grpDatos.Controls.Add(label9);
            grpDatos.Controls.Add(label6);
            grpDatos.Controls.Add(label2);
            grpDatos.Controls.Add(label1);
            grpDatos.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            grpDatos.Location = new Point(-9, -24);
            grpDatos.Margin = new Padding(4, 4, 4, 4);
            grpDatos.Name = "grpDatos";
            grpDatos.Padding = new Padding(4, 4, 4, 4);
            grpDatos.Size = new Size(764, 556);
            grpDatos.TabIndex = 1;
            grpDatos.TabStop = false;
            grpDatos.Text = "Datos:";
            grpDatos.Enter += grpDatos_Enter;
            // 
            // cboEstado
            // 
            cboEstado.FormattingEnabled = true;
            cboEstado.Location = new Point(247, 195);
            cboEstado.Name = "cboEstado";
            cboEstado.Size = new Size(151, 27);
            cboEstado.TabIndex = 39;
            // 
            // cboFuente
            // 
            cboFuente.FormattingEnabled = true;
            cboFuente.Location = new Point(246, 38);
            cboFuente.Name = "cboFuente";
            cboFuente.Size = new Size(151, 27);
            cboFuente.TabIndex = 38;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(40, 198);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(68, 19);
            label3.TabIndex = 30;
            label3.Text = "Estado:";
            // 
            // txtPass_Usuario
            // 
            txtPass_Usuario.Location = new Point(248, 131);
            txtPass_Usuario.Margin = new Padding(4, 4, 4, 4);
            txtPass_Usuario.Name = "txtPass_Usuario";
            txtPass_Usuario.Size = new Size(370, 28);
            txtPass_Usuario.TabIndex = 29;
            // 
            // txtLogin_Usuario
            // 
            txtLogin_Usuario.Location = new Point(247, 83);
            txtLogin_Usuario.Margin = new Padding(4, 4, 4, 4);
            txtLogin_Usuario.Name = "txtLogin_Usuario";
            txtLogin_Usuario.Size = new Size(370, 28);
            txtLogin_Usuario.TabIndex = 3;
            // 
            // dtpFechaReg
            // 
            dtpFechaReg.Location = new Point(246, 267);
            dtpFechaReg.Name = "dtpFechaReg";
            dtpFechaReg.Size = new Size(370, 28);
            dtpFechaReg.TabIndex = 6;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.OrangeRed;
            btnCancelar.Location = new Point(561, 486);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(120, 50);
            btnCancelar.TabIndex = 8;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            // 
            // btnGrabar
            // 
            btnGrabar.BackColor = Color.RoyalBlue;
            btnGrabar.Location = new Point(421, 486);
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
            label9.Location = new Point(40, 267);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(161, 19);
            label9.TabIndex = 16;
            label9.Text = "Fecha de Registro:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(40, 92);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(145, 19);
            label6.TabIndex = 10;
            label6.Text = "Nombre Usuario:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(40, 140);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(119, 19);
            label2.TabIndex = 2;
            label2.Text = "Pass_Usuario:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(40, 46);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(130, 19);
            label1.TabIndex = 0;
            label1.Text = "Rol de usuario:";
            // 
            // AdministradorMan2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(755, 521);
            Controls.Add(grpDatos);
            Name = "AdministradorMan2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Datos:";
            Load += AdministradorMan2_Load;
            grpDatos.ResumeLayout(false);
            grpDatos.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpDatos;
        private TextBox txtLogin_Usuario;
        private DateTimePicker dtpFechaReg;
        private Button btnCancelar;
        private Button btnGrabar;
        private Label label9;
        private Label label6;
        private Label label2;
        private Label label1;
        private Label label3;
        private TextBox txtPass_Usuario;
        private ComboBox cboFuente;
        private ComboBox cboEstado;
    }
}