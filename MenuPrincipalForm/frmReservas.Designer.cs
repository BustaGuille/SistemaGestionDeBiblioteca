namespace BibliotecaApp.UI
{
    partial class frmReservas
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtIdReserva = new TextBox();
            cbLibro = new ComboBox();
            cbSocio = new ComboBox();
            dtpFechaReserva = new DateTimePicker();
            label5 = new Label();
            btnAgregar = new Button();
            btnModificar = new Button();
            btnEliminar = new Button();
            btnLimpiar = new Button();
            dgvReservas = new DataGridView();
            btnBuscar = new Button();
            chkActiva = new CheckBox();
            lblActiva = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvReservas).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(72, 118);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(102, 28);
            label1.TabIndex = 0;
            label1.Text = "ID Reserva";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(72, 183);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(57, 28);
            label2.TabIndex = 1;
            label2.Text = "Libro";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(72, 258);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(61, 28);
            label3.TabIndex = 2;
            label3.Text = "Socio";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(72, 334);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(133, 28);
            label4.TabIndex = 3;
            label4.Text = "Fecha Reserva";
            // 
            // txtIdReserva
            // 
            txtIdReserva.Font = new Font("Segoe UI", 11F);
            txtIdReserva.Location = new Point(265, 114);
            txtIdReserva.Margin = new Padding(4);
            txtIdReserva.Name = "txtIdReserva";
            txtIdReserva.Size = new Size(351, 32);
            txtIdReserva.TabIndex = 4;
            // 
            // cbLibro
            // 
            cbLibro.Font = new Font("Segoe UI", 11F);
            cbLibro.FormattingEnabled = true;
            cbLibro.Location = new Point(265, 178);
            cbLibro.Margin = new Padding(4);
            cbLibro.Name = "cbLibro";
            cbLibro.Size = new Size(351, 33);
            cbLibro.TabIndex = 5;
            // 
            // cbSocio
            // 
            cbSocio.FormattingEnabled = true;
            cbSocio.Location = new Point(265, 250);
            cbSocio.Margin = new Padding(4);
            cbSocio.Name = "cbSocio";
            cbSocio.Size = new Size(351, 36);
            cbSocio.TabIndex = 6;
            // 
            // dtpFechaReserva
            // 
            dtpFechaReserva.Location = new Point(265, 328);
            dtpFechaReserva.Margin = new Padding(4);
            dtpFechaReserva.Name = "dtpFechaReserva";
            dtpFechaReserva.Size = new Size(351, 34);
            dtpFechaReserva.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 20F);
            label5.Location = new Point(72, 23);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(560, 46);
            label5.TabIndex = 8;
            label5.Text = "Bienvenido al Formulario de Reserva";
            // 
            // btnAgregar
            // 
            btnAgregar.Font = new Font("Segoe UI", 10F);
            btnAgregar.Location = new Point(26, 731);
            btnAgregar.Margin = new Padding(4);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(134, 43);
            btnAgregar.TabIndex = 9;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Font = new Font("Segoe UI", 10F);
            btnModificar.Location = new Point(198, 731);
            btnModificar.Margin = new Padding(4);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(134, 43);
            btnModificar.TabIndex = 10;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Font = new Font("Segoe UI", 10F);
            btnEliminar.Location = new Point(545, 731);
            btnEliminar.Margin = new Padding(4);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(134, 43);
            btnEliminar.TabIndex = 11;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Font = new Font("Segoe UI", 10F);
            btnLimpiar.Location = new Point(374, 731);
            btnLimpiar.Margin = new Padding(4);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(134, 43);
            btnLimpiar.TabIndex = 12;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // dgvReservas
            // 
            dgvReservas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReservas.Location = new Point(18, 523);
            dgvReservas.Margin = new Padding(4);
            dgvReservas.Name = "dgvReservas";
            dgvReservas.RowHeadersWidth = 51;
            dgvReservas.Size = new Size(666, 180);
            dgvReservas.TabIndex = 13;
            // 
            // btnBuscar
            // 
            btnBuscar.Font = new Font("Segoe UI", 11F);
            btnBuscar.Location = new Point(260, 464);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(221, 43);
            btnBuscar.TabIndex = 14;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // chkActiva
            // 
            chkActiva.AutoSize = true;
            chkActiva.Location = new Point(265, 405);
            chkActiva.Name = "chkActiva";
            chkActiva.Size = new Size(88, 32);
            chkActiva.TabIndex = 15;
            chkActiva.Text = "Activa";
            chkActiva.UseVisualStyleBackColor = true;
            // 
            // lblActiva
            // 
            lblActiva.AutoSize = true;
            lblActiva.Location = new Point(72, 409);
            lblActiva.Name = "lblActiva";
            lblActiva.Size = new Size(152, 28);
            lblActiva.TabIndex = 16;
            lblActiva.Text = "¿Activa (Sí/No)?";
            // 
            // frmReservas
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(707, 809);
            Controls.Add(lblActiva);
            Controls.Add(chkActiva);
            Controls.Add(btnBuscar);
            Controls.Add(dgvReservas);
            Controls.Add(btnLimpiar);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
            Controls.Add(btnAgregar);
            Controls.Add(label5);
            Controls.Add(dtpFechaReserva);
            Controls.Add(cbSocio);
            Controls.Add(cbLibro);
            Controls.Add(txtIdReserva);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 12F);
            Margin = new Padding(4);
            Name = "frmReservas";
            Text = "Formulario de Reservas";
            ((System.ComponentModel.ISupportInitialize)dgvReservas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtIdReserva;
        private ComboBox cbLibro;
        private ComboBox cbSocio;
        private DateTimePicker dtpFechaReserva;
        private Label label5;
        private Button btnAgregar;
        private Button btnModificar;
        private Button btnEliminar;
        private Button btnLimpiar;
        private DataGridView dgvReservas;
        private Button btnBuscar;
        private CheckBox chkActiva;
        private Label lblActiva;
    }
}