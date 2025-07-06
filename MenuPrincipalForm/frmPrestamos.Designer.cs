namespace BibliotecaApp.UI
{
    partial class frmPrestamos
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
            label6 = new Label();
            label7 = new Label();
            txtIdPrestamo = new TextBox();
            cmbLibro = new ComboBox();
            cmbUsuario = new ComboBox();
            cmbSocio = new ComboBox();
            dtpFechaPrestamo = new DateTimePicker();
            dtpFechaDevolucion = new DateTimePicker();
            chkDevuelto = new CheckBox();
            button1 = new Button();
            btnModificar = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            dgvPrestamos = new DataGridView();
            label8 = new Label();
            btnBuscar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvPrestamos).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(22, 109);
            label1.Name = "label1";
            label1.Size = new Size(118, 28);
            label1.TabIndex = 0;
            label1.Text = "ID Prestamo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(18, 203);
            label2.Name = "label2";
            label2.Size = new Size(57, 28);
            label2.TabIndex = 1;
            label2.Text = "Libro";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(18, 267);
            label3.Name = "label3";
            label3.Size = new Size(79, 28);
            label3.TabIndex = 2;
            label3.Text = "Usuario";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(22, 329);
            label4.Name = "label4";
            label4.Size = new Size(61, 28);
            label4.TabIndex = 3;
            label4.Text = "Socio";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(22, 389);
            label5.Name = "label5";
            label5.Size = new Size(181, 28);
            label5.TabIndex = 4;
            label5.Text = "Fecha del Prestamo";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(22, 444);
            label6.Name = "label6";
            label6.Size = new Size(211, 28);
            label6.TabIndex = 5;
            label6.Text = "Fecha de la devolucion";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F);
            label7.Location = new Point(22, 504);
            label7.Name = "label7";
            label7.Size = new Size(159, 28);
            label7.TabIndex = 6;
            label7.Text = "Devuelto (Sí/No)";
            // 
            // txtIdPrestamo
            // 
            txtIdPrestamo.Font = new Font("Segoe UI", 11F);
            txtIdPrestamo.Location = new Point(235, 108);
            txtIdPrestamo.Margin = new Padding(3, 4, 3, 4);
            txtIdPrestamo.Name = "txtIdPrestamo";
            txtIdPrestamo.Size = new Size(317, 32);
            txtIdPrestamo.TabIndex = 7;
            // 
            // cmbLibro
            // 
            cmbLibro.Font = new Font("Segoe UI", 11F);
            cmbLibro.FormattingEnabled = true;
            cmbLibro.Location = new Point(235, 203);
            cmbLibro.Margin = new Padding(3, 4, 3, 4);
            cmbLibro.Name = "cmbLibro";
            cmbLibro.Size = new Size(317, 33);
            cmbLibro.TabIndex = 8;
            // 
            // cmbUsuario
            // 
            cmbUsuario.Font = new Font("Segoe UI", 11F);
            cmbUsuario.FormattingEnabled = true;
            cmbUsuario.Location = new Point(235, 262);
            cmbUsuario.Margin = new Padding(3, 4, 3, 4);
            cmbUsuario.Name = "cmbUsuario";
            cmbUsuario.Size = new Size(317, 33);
            cmbUsuario.TabIndex = 9;
            // 
            // cmbSocio
            // 
            cmbSocio.Font = new Font("Segoe UI", 11F);
            cmbSocio.FormattingEnabled = true;
            cmbSocio.Location = new Point(235, 324);
            cmbSocio.Margin = new Padding(3, 4, 3, 4);
            cmbSocio.Name = "cmbSocio";
            cmbSocio.Size = new Size(317, 33);
            cmbSocio.TabIndex = 10;
            // 
            // dtpFechaPrestamo
            // 
            dtpFechaPrestamo.Font = new Font("Segoe UI", 11F);
            dtpFechaPrestamo.Location = new Point(235, 385);
            dtpFechaPrestamo.Margin = new Padding(3, 4, 3, 4);
            dtpFechaPrestamo.Name = "dtpFechaPrestamo";
            dtpFechaPrestamo.Size = new Size(317, 32);
            dtpFechaPrestamo.TabIndex = 11;
            // 
            // dtpFechaDevolucion
            // 
            dtpFechaDevolucion.Font = new Font("Segoe UI", 11F);
            dtpFechaDevolucion.Location = new Point(235, 444);
            dtpFechaDevolucion.Margin = new Padding(3, 4, 3, 4);
            dtpFechaDevolucion.Name = "dtpFechaDevolucion";
            dtpFechaDevolucion.Size = new Size(317, 32);
            dtpFechaDevolucion.TabIndex = 12;
            // 
            // chkDevuelto
            // 
            chkDevuelto.AutoSize = true;
            chkDevuelto.Font = new Font("Segoe UI", 11F);
            chkDevuelto.Location = new Point(235, 506);
            chkDevuelto.Margin = new Padding(3, 4, 3, 4);
            chkDevuelto.Name = "chkDevuelto";
            chkDevuelto.Size = new Size(109, 29);
            chkDevuelto.TabIndex = 13;
            chkDevuelto.Text = "Devuelto";
            chkDevuelto.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F);
            button1.Location = new Point(12, 543);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(613, 39);
            button1.TabIndex = 14;
            button1.Text = "Registrar préstamo";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnRegistrar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Font = new Font("Segoe UI", 12F);
            btnModificar.Location = new Point(12, 590);
            btnModificar.Margin = new Padding(3, 4, 3, 4);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(613, 39);
            btnModificar.TabIndex = 15;
            btnModificar.Text = "Modificar préstamo";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 12F);
            button3.Location = new Point(12, 637);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(613, 39);
            button3.TabIndex = 16;
            button3.Text = "Eliminar préstamo";
            button3.UseVisualStyleBackColor = true;
            button3.Click += btnEliminar_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 12F);
            button4.Location = new Point(12, 683);
            button4.Margin = new Padding(3, 4, 3, 4);
            button4.Name = "button4";
            button4.Size = new Size(613, 39);
            button4.TabIndex = 17;
            button4.Text = "Marcar como devuelto";
            button4.UseVisualStyleBackColor = true;
            button4.Click += btnMarcarDevuelto_Click;
            // 
            // button5
            // 
            button5.Font = new Font("Segoe UI", 12F);
            button5.Location = new Point(12, 730);
            button5.Margin = new Padding(3, 4, 3, 4);
            button5.Name = "button5";
            button5.Size = new Size(613, 39);
            button5.TabIndex = 18;
            button5.Text = "Limpiar";
            button5.UseVisualStyleBackColor = true;
            // 
            // dgvPrestamos
            // 
            dgvPrestamos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPrestamos.Location = new Point(18, 777);
            dgvPrestamos.Margin = new Padding(3, 4, 3, 4);
            dgvPrestamos.Name = "dgvPrestamos";
            dgvPrestamos.RowHeadersWidth = 51;
            dgvPrestamos.Size = new Size(609, 163);
            dgvPrestamos.TabIndex = 19;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 20F);
            label8.Location = new Point(48, 29);
            label8.Name = "label8";
            label8.Size = new Size(596, 46);
            label8.TabIndex = 20;
            label8.Text = "Bienvenido al formulario de prestamos";
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(334, 147);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(107, 36);
            btnBuscar.TabIndex = 21;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // frmPrestamos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(649, 952);
            Controls.Add(btnBuscar);
            Controls.Add(label8);
            Controls.Add(dgvPrestamos);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(btnModificar);
            Controls.Add(button1);
            Controls.Add(chkDevuelto);
            Controls.Add(dtpFechaDevolucion);
            Controls.Add(dtpFechaPrestamo);
            Controls.Add(cmbSocio);
            Controls.Add(cmbUsuario);
            Controls.Add(cmbLibro);
            Controls.Add(txtIdPrestamo);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmPrestamos";
            Text = "formulario de Prestamos";
            ((System.ComponentModel.ISupportInitialize)dgvPrestamos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txtIdPrestamo;
        private ComboBox cmbLibro;
        private ComboBox cmbUsuario;
        private ComboBox cmbSocio;
        private DateTimePicker dtpFechaPrestamo;
        private DateTimePicker dtpFechaDevolucion;
        private CheckBox chkDevuelto;
        private Button button1;
        private Button btnModificar;
        private Button button3;
        private Button button4;
        private Button button5;
        private DataGridView dgvPrestamos;
        private Label label8;
        private Button btnBuscar;
    }
}