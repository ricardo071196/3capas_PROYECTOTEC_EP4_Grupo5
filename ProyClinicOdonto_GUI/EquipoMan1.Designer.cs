namespace ProyClinicOdonto_GUI
{
    partial class EquipoMan1
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
            label1 = new Label();
            txtFiltro = new TextBox();
            dtgEquipo = new DataGridView();
            label2 = new Label();
            lblRegistros = new Label();
            btnActualizar = new Button();
            button2 = new Button();
            btnInsertar = new Button();
            lblRegistros2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dtgEquipo).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(38, 37);
            label1.Name = "label1";
            label1.Size = new Size(270, 25);
            label1.TabIndex = 0;
            label1.Text = "Ingrese el Nombre de Equipo:";
            // 
            // txtFiltro
            // 
            txtFiltro.Cursor = Cursors.IBeam;
            txtFiltro.Location = new Point(352, 33);
            txtFiltro.Margin = new Padding(4);
            txtFiltro.Name = "txtFiltro";
            txtFiltro.Size = new Size(406, 28);
            txtFiltro.TabIndex = 0;
            txtFiltro.TextChanged += txtFiltro_TextChanged;
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
            dtgEquipo.Location = new Point(13, 99);
            dtgEquipo.Margin = new Padding(4);
            dtgEquipo.Name = "dtgEquipo";
            dtgEquipo.ReadOnly = true;
            dtgEquipo.RowHeadersVisible = false;
            dtgEquipo.RowHeadersWidth = 51;
            dtgEquipo.RowTemplate.Height = 29;
            dtgEquipo.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgEquipo.Size = new Size(1204, 558);
            dtgEquipo.TabIndex = 2;
            dtgEquipo.Tag = "";
            dtgEquipo.CellContentClick += dtgEquipo_CellContentClick_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(958, 682);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(122, 28);
            label2.TabIndex = 3;
            label2.Text = "Registros:";
            // 
            // lblRegistros
            // 
            lblRegistros.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lblRegistros.BorderStyle = BorderStyle.FixedSingle;
            lblRegistros.Font = new Font("Century Gothic", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lblRegistros.ForeColor = SystemColors.ActiveCaptionText;
            lblRegistros.Location = new Point(2379, 577);
            lblRegistros.Margin = new Padding(4, 0, 4, 0);
            lblRegistros.Name = "lblRegistros";
            lblRegistros.Size = new Size(85, 33);
            lblRegistros.TabIndex = 1;
            lblRegistros.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnActualizar
            // 
            btnActualizar.BackColor = SystemColors.HotTrack;
            btnActualizar.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnActualizar.ForeColor = SystemColors.ButtonHighlight;
            btnActualizar.Location = new Point(897, 731);
            btnActualizar.Margin = new Padding(4);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(139, 54);
            btnActualizar.TabIndex = 3;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = false;
            btnActualizar.Click += btnActualizar_Click_1;
            // 
            // button2
            // 
            button2.BackColor = Color.Crimson;
            button2.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.Location = new Point(1065, 731);
            button2.Margin = new Padding(5, 4, 5, 4);
            button2.Name = "button2";
            button2.Size = new Size(152, 54);
            button2.TabIndex = 5;
            button2.Text = "Cerrar Sesion";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // btnInsertar
            // 
            btnInsertar.BackColor = Color.ForestGreen;
            btnInsertar.ForeColor = SystemColors.ButtonHighlight;
            btnInsertar.Location = new Point(720, 731);
            btnInsertar.Margin = new Padding(5, 4, 5, 4);
            btnInsertar.Name = "btnInsertar";
            btnInsertar.Size = new Size(139, 54);
            btnInsertar.TabIndex = 10;
            btnInsertar.Text = "Insertar";
            btnInsertar.UseVisualStyleBackColor = false;
            btnInsertar.Click += btnInsertar_Click_2;
            // 
            // lblRegistros2
            // 
            lblRegistros2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lblRegistros2.BorderStyle = BorderStyle.FixedSingle;
            lblRegistros2.Font = new Font("Century Gothic", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lblRegistros2.Location = new Point(1106, 667);
            lblRegistros2.Margin = new Padding(5, 0, 5, 0);
            lblRegistros2.Name = "lblRegistros2";
            lblRegistros2.Size = new Size(110, 43);
            lblRegistros2.TabIndex = 11;
            lblRegistros2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // EquipoMan1
            // 
            AutoScaleDimensions = new SizeF(10F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(1230, 788);
            Controls.Add(lblRegistros2);
            Controls.Add(btnInsertar);
            Controls.Add(button2);
            Controls.Add(btnActualizar);
            Controls.Add(lblRegistros);
            Controls.Add(label2);
            Controls.Add(dtgEquipo);
            Controls.Add(txtFiltro);
            Controls.Add(label1);
            Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "EquipoMan1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Mantenimiento de Equipo";
            Load += EquipoMan1_Load_1;
            ((System.ComponentModel.ISupportInitialize)dtgEquipo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtFiltro;
        private DataGridView dtgEquipo;
        private Label label2;
        private Label lblRegistros;
        private Button btnActualizar;
        private Button button2;
        private Button btnInsertar;
        private Label lblRegistros2;
    }
}