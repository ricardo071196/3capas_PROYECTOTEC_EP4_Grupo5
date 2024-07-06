namespace ProyClinicOdonto_GUI
{
    partial class ReservaMan1
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
            btnActualizar = new Button();
            btnInsertar = new Button();
            lblRegistros = new Label();
            label2 = new Label();
            dtgReserva = new DataGridView();
            txtFiltro = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dtgReserva).BeginInit();
            SuspendLayout();
            // 
            // button2
            // 
            button2.BackColor = Color.Crimson;
            button2.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.Location = new Point(1247, 617);
            button2.Margin = new Padding(5, 4, 5, 4);
            button2.Name = "button2";
            button2.Size = new Size(130, 54);
            button2.TabIndex = 13;
            button2.Text = "Regresar";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.BackColor = SystemColors.HotTrack;
            btnActualizar.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnActualizar.ForeColor = SystemColors.ButtonHighlight;
            btnActualizar.Location = new Point(1074, 617);
            btnActualizar.Margin = new Padding(4);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(139, 54);
            btnActualizar.TabIndex = 11;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = false;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnInsertar
            // 
            btnInsertar.BackColor = Color.ForestGreen;
            btnInsertar.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnInsertar.ForeColor = SystemColors.ButtonHighlight;
            btnInsertar.Location = new Point(900, 617);
            btnInsertar.Margin = new Padding(4);
            btnInsertar.Name = "btnInsertar";
            btnInsertar.Size = new Size(139, 54);
            btnInsertar.TabIndex = 9;
            btnInsertar.Text = "Insertar";
            btnInsertar.UseVisualStyleBackColor = false;
            btnInsertar.Click += btnInsertar_Click;
            // 
            // lblRegistros
            // 
            lblRegistros.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lblRegistros.BorderStyle = BorderStyle.FixedSingle;
            lblRegistros.Font = new Font("Century Gothic", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lblRegistros.ForeColor = SystemColors.ActiveCaptionText;
            lblRegistros.Location = new Point(1292, 571);
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
            label2.Location = new Point(1162, 574);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(122, 28);
            label2.TabIndex = 12;
            label2.Text = "Registros:";
            // 
            // dtgReserva
            // 
            dtgReserva.AllowUserToAddRows = false;
            dtgReserva.AllowUserToDeleteRows = false;
            dtgReserva.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dtgReserva.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgReserva.BackgroundColor = SystemColors.ActiveCaption;
            dtgReserva.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgReserva.GridColor = SystemColors.ActiveCaptionText;
            dtgReserva.Location = new Point(93, 90);
            dtgReserva.Margin = new Padding(4);
            dtgReserva.Name = "dtgReserva";
            dtgReserva.ReadOnly = true;
            dtgReserva.RowHeadersVisible = false;
            dtgReserva.RowHeadersWidth = 51;
            dtgReserva.RowTemplate.Height = 29;
            dtgReserva.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgReserva.Size = new Size(1284, 468);
            dtgReserva.TabIndex = 10;
            dtgReserva.CellContentClick += dtgEquipo_CellContentClick;
            // 
            // txtFiltro
            // 
            txtFiltro.Cursor = Cursors.IBeam;
            txtFiltro.Location = new Point(567, 43);
            txtFiltro.Margin = new Padding(4);
            txtFiltro.Name = "txtFiltro";
            txtFiltro.Size = new Size(277, 27);
            txtFiltro.TabIndex = 6;
            txtFiltro.TextChanged += txtFiltro_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(93, 47);
            label1.Name = "label1";
            label1.Size = new Size(457, 23);
            label1.TabIndex = 7;
            label1.Text = "Ingrese nombre de paciente y/o fecha de cita:";
            // 
            // ReservaMan1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1470, 694);
            Controls.Add(button2);
            Controls.Add(btnActualizar);
            Controls.Add(btnInsertar);
            Controls.Add(lblRegistros);
            Controls.Add(label2);
            Controls.Add(dtgReserva);
            Controls.Add(txtFiltro);
            Controls.Add(label1);
            Name = "ReservaMan1";
            Text = "ReservaMan1";
            Load += ReservaMan1_Load;
            ((System.ComponentModel.ISupportInitialize)dtgReserva).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button2;
        private Button btnActualizar;
        private Button btnInsertar;
        private Label lblRegistros;
        private Label label2;
        private DataGridView dtgReserva;
        private TextBox txtFiltro;
        private Label label1;
    }
}