namespace ProyClinicOdonto_GUI
{
    partial class AdministradorMan3
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
            label3 = new Label();
            txtPass_Usuario = new TextBox();
            label6 = new Label();
            label2 = new Label();
            btnCancelar = new Button();
            btnGrabar = new Button();
            txtLogin_Usuario = new TextBox();
            grpDatos.SuspendLayout();
            SuspendLayout();
            // 
            // grpDatos
            // 
            grpDatos.Controls.Add(txtLogin_Usuario);
            grpDatos.Controls.Add(cboEstado);
            grpDatos.Controls.Add(label3);
            grpDatos.Controls.Add(txtPass_Usuario);
            grpDatos.Controls.Add(label6);
            grpDatos.Controls.Add(label2);
            grpDatos.Controls.Add(btnCancelar);
            grpDatos.Controls.Add(btnGrabar);
            grpDatos.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            grpDatos.Location = new Point(49, 4);
            grpDatos.Margin = new Padding(5);
            grpDatos.Name = "grpDatos";
            grpDatos.Padding = new Padding(5);
            grpDatos.Size = new Size(660, 447);
            grpDatos.TabIndex = 1;
            grpDatos.TabStop = false;
            grpDatos.Text = "Datos:";
            grpDatos.Enter += grpDatos_Enter;
            // 
            // cboEstado
            // 
            cboEstado.FormattingEnabled = true;
            cboEstado.Location = new Point(233, 206);
            cboEstado.Name = "cboEstado";
            cboEstado.Size = new Size(151, 27);
            cboEstado.TabIndex = 45;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(26, 209);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(68, 19);
            label3.TabIndex = 44;
            label3.Text = "Estado:";
            // 
            // txtPass_Usuario
            // 
            txtPass_Usuario.Location = new Point(233, 123);
            txtPass_Usuario.Margin = new Padding(4);
            txtPass_Usuario.Name = "txtPass_Usuario";
            txtPass_Usuario.Size = new Size(308, 28);
            txtPass_Usuario.TabIndex = 43;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(26, 43);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(145, 19);
            label6.TabIndex = 42;
            label6.Text = "Nombre Usuario:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 123);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(119, 19);
            label2.TabIndex = 40;
            label2.Text = "Pass_Usuario:";
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.Red;
            btnCancelar.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancelar.Location = new Point(448, 355);
            btnCancelar.Margin = new Padding(4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(120, 50);
            btnCancelar.TabIndex = 4;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            // 
            // btnGrabar
            // 
            btnGrabar.BackColor = Color.RoyalBlue;
            btnGrabar.Location = new Point(290, 355);
            btnGrabar.Margin = new Padding(4);
            btnGrabar.Name = "btnGrabar";
            btnGrabar.Size = new Size(120, 50);
            btnGrabar.TabIndex = 3;
            btnGrabar.Text = "Grabar";
            btnGrabar.UseVisualStyleBackColor = false;
            btnGrabar.Click += btnGrabar_Click;
            // 
            // txtLogin_Usuario
            // 
            txtLogin_Usuario.Location = new Point(233, 34);
            txtLogin_Usuario.Margin = new Padding(4);
            txtLogin_Usuario.Name = "txtLogin_Usuario";
            txtLogin_Usuario.Size = new Size(308, 28);
            txtLogin_Usuario.TabIndex = 46;
            // 
            // AdministradorMan3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(741, 470);
            Controls.Add(grpDatos);
            Name = "AdministradorMan3";
            Text = "AdministradorMan3";
            Load += AdministradorMan3_Load;
            grpDatos.ResumeLayout(false);
            grpDatos.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpDatos;
        private Button btnCancelar;
        private Button btnGrabar;
        private ComboBox cboEstado;
        private Label label3;
        private TextBox txtPass_Usuario;
        private Label label6;
        private Label label2;
        private TextBox txtLogin_Usuario;
    }
}