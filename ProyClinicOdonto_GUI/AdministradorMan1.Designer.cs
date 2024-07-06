namespace ProyClinicOdonto_GUI
{
    partial class AdministradorMan1
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
            lblRegistros2 = new Label();
            btnInsertar = new Button();
            button2 = new Button();
            label2 = new Label();
            dtgUsuarioAdmin = new DataGridView();
            txtFiltro = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dtgUsuarioAdmin).BeginInit();
            SuspendLayout();
            // 
            // lblRegistros2
            // 
            lblRegistros2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lblRegistros2.BorderStyle = BorderStyle.FixedSingle;
            lblRegistros2.Font = new Font("Century Gothic", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lblRegistros2.Location = new Point(1108, 656);
            lblRegistros2.Margin = new Padding(5, 0, 5, 0);
            lblRegistros2.Name = "lblRegistros2";
            lblRegistros2.Size = new Size(110, 43);
            lblRegistros2.TabIndex = 19;
            lblRegistros2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnInsertar
            // 
            btnInsertar.BackColor = Color.ForestGreen;
            btnInsertar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnInsertar.ForeColor = SystemColors.ButtonHighlight;
            btnInsertar.Location = new Point(896, 720);
            btnInsertar.Margin = new Padding(5, 4, 5, 4);
            btnInsertar.Name = "btnInsertar";
            btnInsertar.Size = new Size(139, 54);
            btnInsertar.TabIndex = 18;
            btnInsertar.Text = "Insertar";
            btnInsertar.UseVisualStyleBackColor = false;
            btnInsertar.Click += btnInsertar_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Crimson;
            button2.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.Location = new Point(1067, 720);
            button2.Margin = new Padding(5, 4, 5, 4);
            button2.Name = "button2";
            button2.Size = new Size(152, 54);
            button2.TabIndex = 17;
            button2.Text = "Regresar";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(960, 671);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(122, 28);
            label2.TabIndex = 16;
            label2.Text = "Registros:";
            // 
            // dtgUsuarioAdmin
            // 
            dtgUsuarioAdmin.AllowUserToAddRows = false;
            dtgUsuarioAdmin.AllowUserToDeleteRows = false;
            dtgUsuarioAdmin.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dtgUsuarioAdmin.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgUsuarioAdmin.BackgroundColor = SystemColors.ActiveCaption;
            dtgUsuarioAdmin.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgUsuarioAdmin.GridColor = SystemColors.ActiveCaptionText;
            dtgUsuarioAdmin.Location = new Point(15, 88);
            dtgUsuarioAdmin.Margin = new Padding(4);
            dtgUsuarioAdmin.Name = "dtgUsuarioAdmin";
            dtgUsuarioAdmin.ReadOnly = true;
            dtgUsuarioAdmin.RowHeadersVisible = false;
            dtgUsuarioAdmin.RowHeadersWidth = 51;
            dtgUsuarioAdmin.RowTemplate.Height = 29;
            dtgUsuarioAdmin.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgUsuarioAdmin.Size = new Size(1204, 558);
            dtgUsuarioAdmin.TabIndex = 14;
            dtgUsuarioAdmin.Tag = "";
            dtgUsuarioAdmin.CellContentClick += dtgUsuarioAdmin_CellContentClick;
            // 
            // txtFiltro
            // 
            txtFiltro.Cursor = Cursors.IBeam;
            txtFiltro.Location = new Point(354, 22);
            txtFiltro.Margin = new Padding(4);
            txtFiltro.Name = "txtFiltro";
            txtFiltro.Size = new Size(406, 27);
            txtFiltro.TabIndex = 12;
            txtFiltro.TextChanged += txtFiltro_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(40, 26);
            label1.Name = "label1";
            label1.Size = new Size(276, 25);
            label1.TabIndex = 13;
            label1.Text = "Ingrese el Nombre de Usuario:";
            // 
            // AdministradorMan1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1234, 797);
            Controls.Add(lblRegistros2);
            Controls.Add(btnInsertar);
            Controls.Add(button2);
            Controls.Add(label2);
            Controls.Add(dtgUsuarioAdmin);
            Controls.Add(txtFiltro);
            Controls.Add(label1);
            Name = "AdministradorMan1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdministradorMan1";
            Load += AdministradorMan1_Load;
            ((System.ComponentModel.ISupportInitialize)dtgUsuarioAdmin).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblRegistros2;
        private Button btnInsertar;
        private Button button2;
        private Label label2;
        private DataGridView dtgUsuarioAdmin;
        private TextBox txtFiltro;
        private Label label1;
    }
}