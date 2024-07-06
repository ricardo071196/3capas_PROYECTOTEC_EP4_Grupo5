namespace ProyClinicOdonto_GUI
{
    partial class VistaHorario
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
            button1 = new Button();
            lblRegistros = new Label();
            label1 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            dtgOdontologo = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dtgOdontologo).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.Crimson;
            button1.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(91, 505);
            button1.Margin = new Padding(5, 4, 5, 4);
            button1.Name = "button1";
            button1.Size = new Size(130, 54);
            button1.TabIndex = 24;
            button1.Text = "Regresar";
            button1.UseVisualStyleBackColor = false;
            // 
            // lblRegistros
            // 
            lblRegistros.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lblRegistros.BorderStyle = BorderStyle.FixedSingle;
            lblRegistros.Font = new Font("Century Gothic", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lblRegistros.Location = new Point(1204, 505);
            lblRegistros.Margin = new Padding(5, 0, 5, 0);
            lblRegistros.Name = "lblRegistros";
            lblRegistros.Size = new Size(110, 43);
            lblRegistros.TabIndex = 20;
            lblRegistros.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(1048, 513);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(122, 28);
            label1.TabIndex = 23;
            label1.Text = "Registros:";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(434, 23);
            textBox1.Margin = new Padding(5, 4, 5, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(396, 27);
            textBox1.TabIndex = 19;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(91, 27);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(309, 23);
            label2.TabIndex = 22;
            label2.Text = "Ingrese el nombre odontologo:";
            // 
            // dtgOdontologo
            // 
            dtgOdontologo.AllowUserToAddRows = false;
            dtgOdontologo.AllowUserToDeleteRows = false;
            dtgOdontologo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dtgOdontologo.BackgroundColor = SystemColors.ActiveCaption;
            dtgOdontologo.ColumnHeadersHeight = 29;
            dtgOdontologo.Location = new Point(91, 78);
            dtgOdontologo.Margin = new Padding(5, 4, 5, 4);
            dtgOdontologo.Name = "dtgOdontologo";
            dtgOdontologo.ReadOnly = true;
            dtgOdontologo.RowHeadersVisible = false;
            dtgOdontologo.RowHeadersWidth = 51;
            dtgOdontologo.RowTemplate.Height = 29;
            dtgOdontologo.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgOdontologo.Size = new Size(1223, 384);
            dtgOdontologo.TabIndex = 21;
            // 
            // VistaHorario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1404, 582);
            Controls.Add(button1);
            Controls.Add(lblRegistros);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(dtgOdontologo);
            Name = "VistaHorario";
            Text = "VistaHorario";
            Load += VistaHorario_Load;
            ((System.ComponentModel.ISupportInitialize)dtgOdontologo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label lblRegistros;
        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private DataGridView dtgOdontologo;
    }
}