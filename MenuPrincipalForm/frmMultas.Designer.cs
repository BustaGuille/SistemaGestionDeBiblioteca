namespace BibliotecaApp.UI
{
    partial class frmMultas
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
            label5 = new Label();
            txtIdMulta = new TextBox();
            txtMonto = new TextBox();
            txtMotivo = new TextBox();
            cmbSocio = new ComboBox();
            dtpFechaMulta = new DateTimePicker();
            btnAgregar = new Button();
            btnEliminar = new Button();
            btnLimpiar = new Button();
            dgvMultas = new DataGridView();
            label6 = new Label();
            btnBuscar = new Button();
            btnModificar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvMultas).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(75, 124);
            label1.Name = "label1";
            label1.Size = new Size(87, 28);
            label1.TabIndex = 0;
            label1.Text = "ID Multa";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(75, 176);
            label2.Name = "label2";
            label2.Size = new Size(61, 28);
            label2.TabIndex = 1;
            label2.Text = "Socio";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(75, 227);
            label3.Name = "label3";
            label3.Size = new Size(72, 28);
            label3.TabIndex = 2;
            label3.Text = "Monto";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(75, 281);
            label4.Name = "label4";
            label4.Size = new Size(76, 28);
            label4.TabIndex = 3;
            label4.Text = "Motivo";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(75, 330);
            label5.Name = "label5";
            label5.Size = new Size(145, 28);
            label5.TabIndex = 4;
            label5.Text = "Fecha de Multa";
            // 
            // txtIdMulta
            // 
            txtIdMulta.Font = new Font("Segoe UI", 11F);
            txtIdMulta.Location = new Point(292, 120);
            txtIdMulta.Name = "txtIdMulta";
            txtIdMulta.Size = new Size(339, 32);
            txtIdMulta.TabIndex = 5;
            // 
            // txtMonto
            // 
            txtMonto.Font = new Font("Segoe UI", 11F);
            txtMonto.Location = new Point(292, 223);
            txtMonto.Name = "txtMonto";
            txtMonto.Size = new Size(339, 32);
            txtMonto.TabIndex = 6;
            // 
            // txtMotivo
            // 
            txtMotivo.Font = new Font("Segoe UI", 11F);
            txtMotivo.Location = new Point(292, 277);
            txtMotivo.Name = "txtMotivo";
            txtMotivo.Size = new Size(339, 32);
            txtMotivo.TabIndex = 7;
            // 
            // cmbSocio
            // 
            cmbSocio.Font = new Font("Segoe UI", 11F);
            cmbSocio.FormattingEnabled = true;
            cmbSocio.Location = new Point(292, 171);
            cmbSocio.Name = "cmbSocio";
            cmbSocio.Size = new Size(339, 33);
            cmbSocio.TabIndex = 8;
            // 
            // dtpFechaMulta
            // 
            dtpFechaMulta.Font = new Font("Segoe UI", 11F);
            dtpFechaMulta.Location = new Point(292, 326);
            dtpFechaMulta.Name = "dtpFechaMulta";
            dtpFechaMulta.Size = new Size(339, 32);
            dtpFechaMulta.TabIndex = 9;
            // 
            // btnAgregar
            // 
            btnAgregar.Font = new Font("Segoe UI", 10F);
            btnAgregar.Location = new Point(20, 729);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(134, 43);
            btnAgregar.TabIndex = 10;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Font = new Font("Segoe UI", 10F);
            btnEliminar.Location = new Point(191, 730);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(134, 43);
            btnEliminar.TabIndex = 12;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Font = new Font("Segoe UI", 10F);
            btnLimpiar.Location = new Point(372, 730);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(134, 43);
            btnLimpiar.TabIndex = 13;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // dgvMultas
            // 
            dgvMultas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMultas.Location = new Point(21, 463);
            dgvMultas.Name = "dgvMultas";
            dgvMultas.RowHeadersWidth = 51;
            dgvMultas.Size = new Size(666, 236);
            dgvMultas.TabIndex = 14;
            dgvMultas.CellContentClick += dgvMultas_CellContentClick;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 20F);
            label6.Location = new Point(75, 22);
            label6.Name = "label6";
            label6.Size = new Size(547, 46);
            label6.TabIndex = 15;
            label6.Text = "Bienvenido al Formulario de Multas";
            // 
            // btnBuscar
            // 
            btnBuscar.Font = new Font("Segoe UI", 11F);
            btnBuscar.Location = new Point(249, 395);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(221, 43);
            btnBuscar.TabIndex = 16;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Font = new Font("Segoe UI", 10F);
            btnModificar.Location = new Point(552, 730);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(134, 43);
            btnModificar.TabIndex = 17;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // frmMultas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(707, 809);
            Controls.Add(btnModificar);
            Controls.Add(btnBuscar);
            Controls.Add(label6);
            Controls.Add(dgvMultas);
            Controls.Add(btnLimpiar);
            Controls.Add(btnEliminar);
            Controls.Add(btnAgregar);
            Controls.Add(dtpFechaMulta);
            Controls.Add(cmbSocio);
            Controls.Add(txtMotivo);
            Controls.Add(txtMonto);
            Controls.Add(txtIdMulta);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmMultas";
            Text = "Formulario de Multas";
            ((System.ComponentModel.ISupportInitialize)dgvMultas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtIdMulta;
        private TextBox txtMonto;
        private TextBox txtMotivo;
        private ComboBox cmbSocio;
        private DateTimePicker dtpFechaMulta;
        private Button btnAgregar;
        private Button btnEliminar;
        private Button btnLimpiar;
        private DataGridView dgvMultas;
        private Label label6;
        private Button btnBuscar;
        private Button btnModificar;
    }
}