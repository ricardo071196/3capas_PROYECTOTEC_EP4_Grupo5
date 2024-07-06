namespace ProyClinicOdonto_GUI
{
    partial class VistaGuiaRemision
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
            dtgGuia = new DataGridView();
            txtFiltro = new TextBox();
            label1 = new Label();
            btnInsertar = new Button();
            ((System.ComponentModel.ISupportInitialize)dtgGuia).BeginInit();
            SuspendLayout();
            // 
            // button2
            // 
            button2.BackColor = Color.Crimson;
            button2.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.Location = new Point(118, 700);
            button2.Margin = new Padding(5, 4, 5, 4);
            button2.Name = "button2";
            button2.Size = new Size(130, 54);
            button2.TabIndex = 19;
            button2.Text = "Regresar";
            button2.UseVisualStyleBackColor = false;
            // 
            // lblRegistros
            // 
            lblRegistros.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lblRegistros.BorderStyle = BorderStyle.FixedSingle;
            lblRegistros.Font = new Font("Century Gothic", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lblRegistros.ForeColor = SystemColors.ActiveCaptionText;
            lblRegistros.Location = new Point(1327, 700);
            lblRegistros.Margin = new Padding(4, 0, 4, 0);
            lblRegistros.Name = "lblRegistros";
            lblRegistros.Size = new Size(85, 33);
            lblRegistros.TabIndex = 16;
            lblRegistros.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(1172, 703);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(122, 28);
            label2.TabIndex = 18;
            label2.Text = "Registros:";
            // 
            // dtgGuia
            // 
            dtgGuia.AllowUserToAddRows = false;
            dtgGuia.AllowUserToDeleteRows = false;
            dtgGuia.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dtgGuia.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgGuia.BackgroundColor = SystemColors.ActiveCaption;
            dtgGuia.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgGuia.GridColor = SystemColors.ActiveCaptionText;
            dtgGuia.Location = new Point(118, 66);
            dtgGuia.Margin = new Padding(4);
            dtgGuia.Name = "dtgGuia";
            dtgGuia.ReadOnly = true;
            dtgGuia.RowHeadersVisible = false;
            dtgGuia.RowHeadersWidth = 51;
            dtgGuia.RowTemplate.Height = 29;
            dtgGuia.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgGuia.Size = new Size(1294, 623);
            dtgGuia.TabIndex = 17;
            // 
            // txtFiltro
            // 
            txtFiltro.Cursor = Cursors.IBeam;
            txtFiltro.Location = new Point(436, 20);
            txtFiltro.Margin = new Padding(4);
            txtFiltro.Name = "txtFiltro";
            txtFiltro.Size = new Size(406, 27);
            txtFiltro.TabIndex = 14;
            txtFiltro.TextChanged += txtFiltro_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(118, 20);
            label1.Name = "label1";
            label1.Size = new Size(212, 23);
            label1.TabIndex = 15;
            label1.Text = "Ingrese descripcion:";
            // 
            // btnInsertar
            // 
            btnInsertar.BackColor = Color.ForestGreen;
            btnInsertar.ForeColor = SystemColors.ButtonHighlight;
            btnInsertar.Location = new Point(910, 701);
            btnInsertar.Margin = new Padding(5, 4, 5, 4);
            btnInsertar.Name = "btnInsertar";
            btnInsertar.Size = new Size(139, 54);
            btnInsertar.TabIndex = 20;
            btnInsertar.Text = "Insertar";
            btnInsertar.UseVisualStyleBackColor = false;
            btnInsertar.Click += btnInsertar_Click_1;
            // 
            // VistaGuiaRemision
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1531, 769);
            Controls.Add(btnInsertar);
            Controls.Add(button2);
            Controls.Add(lblRegistros);
            Controls.Add(label2);
            Controls.Add(dtgGuia);
            Controls.Add(txtFiltro);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(2, 3, 2, 3);
            Name = "VistaGuiaRemision";
            Text = "VistaGuiaRemision";
            Load += VistaGuiaRemision_Load;
            ((System.ComponentModel.ISupportInitialize)dtgGuia).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button2;
        private Label lblRegistros;
        private Label label2;
        private DataGridView dtgGuia;
        private TextBox txtFiltro;
        private Label label1;
        private Button btnInsertar;
    }
}