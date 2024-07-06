namespace ProyClinicOdonto_GUI
{
    partial class GuiaRemisionMan
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
            mskCantidad = new MaskedTextBox();
            label10 = new Label();
            txtUMedida = new TextBox();
            label8 = new Label();
            txtDireccion = new TextBox();
            mskTelefono = new MaskedTextBox();
            dtpFecLlega = new DateTimePicker();
            dtpFecPart = new DateTimePicker();
            dtpFecEmi = new DateTimePicker();
            cboDistrito = new ComboBox();
            label12 = new Label();
            mskRUC = new MaskedTextBox();
            txtProveedor = new TextBox();
            btnCancelar = new Button();
            btnGrabar = new Button();
            label9 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            txtDescripcion = new TextBox();
            grpDatos.SuspendLayout();
            SuspendLayout();
            // 
            // grpDatos
            // 
            grpDatos.Controls.Add(txtDescripcion);
            grpDatos.Controls.Add(label3);
            grpDatos.Controls.Add(mskCantidad);
            grpDatos.Controls.Add(label10);
            grpDatos.Controls.Add(txtUMedida);
            grpDatos.Controls.Add(label8);
            grpDatos.Controls.Add(txtDireccion);
            grpDatos.Controls.Add(mskTelefono);
            grpDatos.Controls.Add(dtpFecLlega);
            grpDatos.Controls.Add(dtpFecPart);
            grpDatos.Controls.Add(dtpFecEmi);
            grpDatos.Controls.Add(cboDistrito);
            grpDatos.Controls.Add(label12);
            grpDatos.Controls.Add(mskRUC);
            grpDatos.Controls.Add(txtProveedor);
            grpDatos.Controls.Add(btnCancelar);
            grpDatos.Controls.Add(btnGrabar);
            grpDatos.Controls.Add(label9);
            grpDatos.Controls.Add(label7);
            grpDatos.Controls.Add(label6);
            grpDatos.Controls.Add(label5);
            grpDatos.Controls.Add(label4);
            grpDatos.Controls.Add(label2);
            grpDatos.Controls.Add(label1);
            grpDatos.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            grpDatos.Location = new Point(13, 14);
            grpDatos.Margin = new Padding(4);
            grpDatos.Name = "grpDatos";
            grpDatos.Padding = new Padding(4);
            grpDatos.Size = new Size(726, 620);
            grpDatos.TabIndex = 1;
            grpDatos.TabStop = false;
            grpDatos.Text = "Datos:";
            grpDatos.UseWaitCursor = true;
            grpDatos.Enter += grpDatos_Enter;
            // 
            // mskCantidad
            // 
            mskCantidad.Location = new Point(282, 491);
            mskCantidad.Mask = "999999999";
            mskCantidad.Name = "mskCantidad";
            mskCantidad.Size = new Size(188, 28);
            mskCantidad.TabIndex = 40;
            mskCantidad.UseWaitCursor = true;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(25, 494);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(87, 19);
            label10.TabIndex = 39;
            label10.Text = "cantidad:";
            label10.UseWaitCursor = true;
            // 
            // txtUMedida
            // 
            txtUMedida.Location = new Point(282, 448);
            txtUMedida.Name = "txtUMedida";
            txtUMedida.Size = new Size(423, 28);
            txtUMedida.TabIndex = 38;
            txtUMedida.UseWaitCursor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(25, 451);
            label8.Name = "label8";
            label8.Size = new Size(194, 19);
            label8.TabIndex = 37;
            label8.Text = "UMedida_Descripcion:";
            label8.UseWaitCursor = true;
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(282, 353);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(423, 28);
            txtDireccion.TabIndex = 34;
            txtDireccion.UseWaitCursor = true;
            // 
            // mskTelefono
            // 
            mskTelefono.Location = new Point(284, 313);
            mskTelefono.Mask = "999999999";
            mskTelefono.Name = "mskTelefono";
            mskTelefono.Size = new Size(188, 28);
            mskTelefono.TabIndex = 33;
            mskTelefono.UseWaitCursor = true;
            // 
            // dtpFecLlega
            // 
            dtpFecLlega.Location = new Point(282, 163);
            dtpFecLlega.Name = "dtpFecLlega";
            dtpFecLlega.Size = new Size(367, 28);
            dtpFecLlega.TabIndex = 32;
            dtpFecLlega.UseWaitCursor = true;
            // 
            // dtpFecPart
            // 
            dtpFecPart.Location = new Point(282, 116);
            dtpFecPart.Name = "dtpFecPart";
            dtpFecPart.Size = new Size(367, 28);
            dtpFecPart.TabIndex = 31;
            dtpFecPart.UseWaitCursor = true;
            // 
            // dtpFecEmi
            // 
            dtpFecEmi.Location = new Point(282, 74);
            dtpFecEmi.Name = "dtpFecEmi";
            dtpFecEmi.Size = new Size(367, 28);
            dtpFecEmi.TabIndex = 30;
            dtpFecEmi.UseWaitCursor = true;
            // 
            // cboDistrito
            // 
            cboDistrito.BackColor = SystemColors.ScrollBar;
            cboDistrito.DropDownStyle = ComboBoxStyle.DropDownList;
            cboDistrito.FormattingEnabled = true;
            cboDistrito.Location = new Point(283, 399);
            cboDistrito.Name = "cboDistrito";
            cboDistrito.Size = new Size(189, 27);
            cboDistrito.TabIndex = 7;
            cboDistrito.UseWaitCursor = true;
            cboDistrito.SelectedIndexChanged += cboDistrito_SelectedIndexChanged;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(27, 407);
            label12.Name = "label12";
            label12.Size = new Size(66, 19);
            label12.TabIndex = 28;
            label12.Text = "Distrito:";
            label12.UseWaitCursor = true;
            // 
            // mskRUC
            // 
            mskRUC.Location = new Point(282, 267);
            mskRUC.Mask = "99999999999";
            mskRUC.Name = "mskRUC";
            mskRUC.Size = new Size(253, 28);
            mskRUC.TabIndex = 4;
            mskRUC.UseWaitCursor = true;
            // 
            // txtProveedor
            // 
            txtProveedor.Location = new Point(282, 212);
            txtProveedor.Name = "txtProveedor";
            txtProveedor.Size = new Size(253, 28);
            txtProveedor.TabIndex = 3;
            txtProveedor.UseWaitCursor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.OrangeRed;
            btnCancelar.Location = new Point(585, 539);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(120, 50);
            btnCancelar.TabIndex = 10;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.UseWaitCursor = true;
            // 
            // btnGrabar
            // 
            btnGrabar.BackColor = Color.RoyalBlue;
            btnGrabar.Location = new Point(450, 539);
            btnGrabar.Name = "btnGrabar";
            btnGrabar.Size = new Size(120, 50);
            btnGrabar.TabIndex = 9;
            btnGrabar.Text = "Grabar";
            btnGrabar.UseVisualStyleBackColor = false;
            btnGrabar.UseWaitCursor = true;
            btnGrabar.Click += btnGrabar_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(25, 362);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(93, 19);
            label9.TabIndex = 16;
            label9.Text = "Direccion:";
            label9.UseWaitCursor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(29, 316);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(81, 19);
            label7.TabIndex = 12;
            label7.Text = "telefono:";
            label7.UseWaitCursor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(27, 270);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(47, 19);
            label6.TabIndex = 10;
            label6.Text = "RUC:";
            label6.UseWaitCursor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(29, 221);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(99, 19);
            label5.TabIndex = 8;
            label5.Text = "Proveedor:";
            label5.UseWaitCursor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(32, 170);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(160, 19);
            label4.TabIndex = 6;
            label4.Text = "Fecha de llegada:";
            label4.UseWaitCursor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(32, 125);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(154, 19);
            label2.TabIndex = 2;
            label2.Text = "Fecha de partida:";
            label2.UseWaitCursor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 83);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(161, 19);
            label1.TabIndex = 0;
            label1.Text = "Fecha de emision:";
            label1.UseWaitCursor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(32, 41);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(99, 19);
            label3.TabIndex = 41;
            label3.Text = "Proveedor:";
            label3.UseWaitCursor = true;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(284, 28);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(253, 28);
            txtDescripcion.TabIndex = 42;
            txtDescripcion.UseWaitCursor = true;
            // 
            // GuiaRemisionMan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(758, 647);
            Controls.Add(grpDatos);
            Name = "GuiaRemisionMan";
            Text = "GuiaRemisionMan";
            Load += GuiaRemisionMan_Load;
            grpDatos.ResumeLayout(false);
            grpDatos.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpDatos;
        private TextBox txtDireccion;
        private MaskedTextBox mskTelefono;
        private DateTimePicker dtpFecLlega;
        private DateTimePicker dtpFecPart;
        private DateTimePicker dtpFecEmi;
        private ComboBox cboDistrito;
        private Label label12;
        private MaskedTextBox mskRUC;
        private TextBox txtProveedor;
        private Button btnCancelar;
        private Button btnGrabar;
        private Label label9;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label2;
        private Label label1;
        private MaskedTextBox mskCantidad;
        private Label label10;
        private TextBox txtUMedida;
        private Label label8;
        private TextBox txtDescripcion;
        private Label label3;
    }
}