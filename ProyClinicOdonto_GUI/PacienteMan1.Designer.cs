namespace ProyClinicOdonto_GUI
{
    partial class PacienteMan1
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
            txtFiltro = new TextBox();
            label1 = new Label();
            dtgPaciente = new DataGridView();
            btnSalir = new Button();
            btnActualizar = new Button();
            btnInsertar = new Button();
            lblRegistros = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dtgPaciente).BeginInit();
            SuspendLayout();
            // 
            // txtFiltro
            // 
            txtFiltro.Cursor = Cursors.IBeam;
            txtFiltro.Location = new Point(315, 29);
            txtFiltro.Margin = new Padding(5, 4, 5, 4);
            txtFiltro.Name = "txtFiltro";
            txtFiltro.Size = new Size(413, 28);
            txtFiltro.TabIndex = 0;
            txtFiltro.TextChanged += txtFiltro_TextChanged_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 38);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(271, 19);
            label1.TabIndex = 2;
            label1.Text = "Ingrese el Nombre de Paciente:";
            // 
            // dtgPaciente
            // 
            dtgPaciente.AllowUserToAddRows = false;
            dtgPaciente.AllowUserToDeleteRows = false;
            dtgPaciente.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dtgPaciente.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgPaciente.BackgroundColor = SystemColors.ActiveCaption;
            dtgPaciente.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgPaciente.Location = new Point(16, 90);
            dtgPaciente.Margin = new Padding(5, 4, 5, 4);
            dtgPaciente.Name = "dtgPaciente";
            dtgPaciente.ReadOnly = true;
            dtgPaciente.RowHeadersVisible = false;
            dtgPaciente.RowHeadersWidth = 51;
            dtgPaciente.RowTemplate.Height = 29;
            dtgPaciente.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgPaciente.Size = new Size(1398, 492);
            dtgPaciente.TabIndex = 4;
            dtgPaciente.CellContentClick += dtgPaciente_CellContentClick_1;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.Crimson;
            btnSalir.ForeColor = SystemColors.ButtonHighlight;
            btnSalir.Location = new Point(1275, 650);
            btnSalir.Margin = new Padding(5, 4, 5, 4);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(139, 54);
            btnSalir.TabIndex = 6;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click_1;
            // 
            // btnActualizar
            // 
            btnActualizar.BackColor = SystemColors.HotTrack;
            btnActualizar.ForeColor = SystemColors.ButtonHighlight;
            btnActualizar.Location = new Point(1102, 650);
            btnActualizar.Margin = new Padding(5, 4, 5, 4);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(139, 54);
            btnActualizar.TabIndex = 3;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = false;
            btnActualizar.Click += btnActualizar_Click_1;
            // 
            // btnInsertar
            // 
            btnInsertar.BackColor = Color.ForestGreen;
            btnInsertar.ForeColor = SystemColors.ButtonHighlight;
            btnInsertar.Location = new Point(923, 650);
            btnInsertar.Margin = new Padding(5, 4, 5, 4);
            btnInsertar.Name = "btnInsertar";
            btnInsertar.Size = new Size(139, 54);
            btnInsertar.TabIndex = 2;
            btnInsertar.Text = "Insertar";
            btnInsertar.UseVisualStyleBackColor = false;
            btnInsertar.Click += btnInsertar_Click_1;
            // 
            // lblRegistros
            // 
            lblRegistros.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lblRegistros.BorderStyle = BorderStyle.FixedSingle;
            lblRegistros.Font = new Font("Century Gothic", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lblRegistros.Location = new Point(1302, 586);
            lblRegistros.Margin = new Padding(5, 0, 5, 0);
            lblRegistros.Name = "lblRegistros";
            lblRegistros.Size = new Size(112, 43);
            lblRegistros.TabIndex = 1;
            lblRegistros.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(1161, 593);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(122, 28);
            label2.TabIndex = 8;
            label2.Text = "Registros:";
            // 
            // PacienteMan1
            // 
            AutoScaleDimensions = new SizeF(10F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1428, 727);
            Controls.Add(btnSalir);
            Controls.Add(btnActualizar);
            Controls.Add(btnInsertar);
            Controls.Add(lblRegistros);
            Controls.Add(label2);
            Controls.Add(dtgPaciente);
            Controls.Add(txtFiltro);
            Controls.Add(label1);
            Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4, 2, 4, 2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "PacienteMan1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Mantenimiento de Paciente";
            Load += PacienteMan1_Load_1;
            ((System.ComponentModel.ISupportInitialize)dtgPaciente).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtFiltro;
        private Label label1;
        private DataGridView dtgPaciente;
        private Button btnSalir;
        private Button btnActualizar;
        private Button btnInsertar;
        private Label lblRegistros;
        private Label label2;
    }
}