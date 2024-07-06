namespace ProyClinicOdonto_GUI
{
    partial class VistaEquipo
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
            button2 = new Button();
            lblRegistros = new Label();
            label2 = new Label();
            dtgEquipo = new DataGridView();
            txtFiltro = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dtgEquipo).BeginInit();
            SuspendLayout();
            // 
            // button2
            // 
            button2.BackColor = Color.Crimson;
            button2.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.Location = new Point(60, 628);
            button2.Margin = new Padding(5, 4, 5, 4);
            button2.Name = "button2";
            button2.Size = new Size(130, 54);
            button2.TabIndex = 13;
            button2.Text = "Regresar";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // lblRegistros
            // 
            lblRegistros.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lblRegistros.BorderStyle = BorderStyle.FixedSingle;
            lblRegistros.Font = new Font("Century Gothic", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lblRegistros.ForeColor = SystemColors.ActiveCaptionText;
            lblRegistros.Location = new Point(1259, 585);
            lblRegistros.Margin = new Padding(4, 0, 4, 0);
            lblRegistros.Name = "lblRegistros";
            lblRegistros.Size = new Size(85, 33);
            lblRegistros.TabIndex = 8;
            lblRegistros.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(1119, 588);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(122, 28);
            label2.TabIndex = 12;
            label2.Text = "Registros:";
            // 
            // dtgEquipo
            // 
            dtgEquipo.AllowUserToAddRows = false;
            dtgEquipo.AllowUserToDeleteRows = false;
            dtgEquipo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dtgEquipo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgEquipo.BackgroundColor = SystemColors.ActiveCaption;
            dtgEquipo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgEquipo.GridColor = SystemColors.ActiveCaptionText;
            dtgEquipo.Location = new Point(60, 67);
            dtgEquipo.Margin = new Padding(4);
            dtgEquipo.Name = "dtgEquipo";
            dtgEquipo.ReadOnly = true;
            dtgEquipo.RowHeadersVisible = false;
            dtgEquipo.RowHeadersWidth = 51;
            dtgEquipo.RowTemplate.Height = 29;
            dtgEquipo.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgEquipo.Size = new Size(1284, 505);
            dtgEquipo.TabIndex = 10;
            // 
            // txtFiltro
            // 
            txtFiltro.Cursor = Cursors.IBeam;
            txtFiltro.Location = new Point(392, 20);
            txtFiltro.Margin = new Padding(4);
            txtFiltro.Name = "txtFiltro";
            txtFiltro.Size = new Size(406, 27);
            txtFiltro.TabIndex = 6;
            txtFiltro.TextChanged += txtFiltro_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(60, 24);
            label1.Name = "label1";
            label1.Size = new Size(300, 23);
            label1.TabIndex = 7;
            label1.Text = "Ingrese el Nombre de Equipo:";
            // 
            // VistaEquipo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1404, 685);
            Controls.Add(button2);
            Controls.Add(lblRegistros);
            Controls.Add(label2);
            Controls.Add(dtgEquipo);
            Controls.Add(txtFiltro);
            Controls.Add(label1);
            Name = "VistaEquipo";
            Text = "VistaEquipo";
            Load += VistaEquipo_Load;
            ((System.ComponentModel.ISupportInitialize)dtgEquipo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button2;
        private Label lblRegistros;
        private Label label2;
        private DataGridView dtgEquipo;
        private TextBox txtFiltro;
        private Label label1;
    }
}