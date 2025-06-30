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
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            dgvPrestamos = new DataGridView();
            label8 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvPrestamos).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(52, 119);
            label1.Name = "label1";
            label1.Size = new Size(95, 21);
            label1.TabIndex = 0;
            label1.Text = "ID Prestamo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(52, 187);
            label2.Name = "label2";
            label2.Size = new Size(46, 21);
            label2.TabIndex = 1;
            label2.Text = "Libro";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(52, 245);
            label3.Name = "label3";
            label3.Size = new Size(64, 21);
            label3.TabIndex = 2;
            label3.Text = "Usuario";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(52, 302);
            label4.Name = "label4";
            label4.Size = new Size(48, 21);
            label4.TabIndex = 3;
            label4.Text = "Socio";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(52, 354);
            label5.Name = "label5";
            label5.Size = new Size(145, 21);
            label5.TabIndex = 4;
            label5.Text = "Fecha del Prestamo";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(52, 409);
            label6.Name = "label6";
            label6.Size = new Size(167, 21);
            label6.TabIndex = 5;
            label6.Text = "Fecha de la devolucion";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F);
            label7.Location = new Point(52, 454);
            label7.Name = "label7";
            label7.Size = new Size(126, 21);
            label7.TabIndex = 6;
            label7.Text = "Devuelto (Sí/No)";
            // 
            // txtIdPrestamo
            // 
            txtIdPrestamo.Font = new Font("Segoe UI", 11F);
            txtIdPrestamo.Location = new Point(225, 119);
            txtIdPrestamo.Name = "txtIdPrestamo";
            txtIdPrestamo.Size = new Size(274, 27);
            txtIdPrestamo.TabIndex = 7;
            // 
            // cmbLibro
            // 
            cmbLibro.Font = new Font("Segoe UI", 11F);
            cmbLibro.FormattingEnabled = true;
            cmbLibro.Location = new Point(225, 187);
            cmbLibro.Name = "cmbLibro";
            cmbLibro.Size = new Size(274, 28);
            cmbLibro.TabIndex = 8;
            // 
            // cmbUsuario
            // 
            cmbUsuario.Font = new Font("Segoe UI", 11F);
            cmbUsuario.FormattingEnabled = true;
            cmbUsuario.Location = new Point(225, 245);
            cmbUsuario.Name = "cmbUsuario";
            cmbUsuario.Size = new Size(278, 28);
            cmbUsuario.TabIndex = 9;
            // 
            // cmbSocio
            // 
            cmbSocio.Font = new Font("Segoe UI", 11F);
            cmbSocio.FormattingEnabled = true;
            cmbSocio.Location = new Point(225, 303);
            cmbSocio.Name = "cmbSocio";
            cmbSocio.Size = new Size(274, 28);
            cmbSocio.TabIndex = 10;
            // 
            // dtpFechaPrestamo
            // 
            dtpFechaPrestamo.Font = new Font("Segoe UI", 11F);
            dtpFechaPrestamo.Location = new Point(225, 354);
            dtpFechaPrestamo.Name = "dtpFechaPrestamo";
            dtpFechaPrestamo.Size = new Size(274, 27);
            dtpFechaPrestamo.TabIndex = 11;
            // 
            // dtpFechaDevolucion
            // 
            dtpFechaDevolucion.Font = new Font("Segoe UI", 11F);
            dtpFechaDevolucion.Location = new Point(225, 409);
            dtpFechaDevolucion.Name = "dtpFechaDevolucion";
            dtpFechaDevolucion.Size = new Size(274, 27);
            dtpFechaDevolucion.TabIndex = 12;
            // 
            // chkDevuelto
            // 
            chkDevuelto.AutoSize = true;
            chkDevuelto.Font = new Font("Segoe UI", 11F);
            chkDevuelto.Location = new Point(225, 454);
            chkDevuelto.Name = "chkDevuelto";
            chkDevuelto.Size = new Size(88, 24);
            chkDevuelto.TabIndex = 13;
            chkDevuelto.Text = "Devuelto";
            chkDevuelto.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F);
            button1.Location = new Point(28, 568);
            button1.Name = "button1";
            button1.Size = new Size(150, 50);
            button1.TabIndex = 14;
            button1.Text = "Registrar préstamo";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 12F);
            button2.Location = new Point(207, 568);
            button2.Name = "button2";
            button2.Size = new Size(150, 50);
            button2.TabIndex = 15;
            button2.Text = "Modificar préstamo";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 12F);
            button3.Location = new Point(398, 568);
            button3.Name = "button3";
            button3.Size = new Size(150, 50);
            button3.TabIndex = 16;
            button3.Text = "Eliminar préstamo";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 12F);
            button4.Location = new Point(598, 568);
            button4.Name = "button4";
            button4.Size = new Size(150, 50);
            button4.TabIndex = 17;
            button4.Text = "Marcar como devuelto";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Font = new Font("Segoe UI", 12F);
            button5.Location = new Point(782, 568);
            button5.Name = "button5";
            button5.Size = new Size(150, 50);
            button5.TabIndex = 18;
            button5.Text = "Limpiar";
            button5.UseVisualStyleBackColor = true;
            // 
            // dgvPrestamos
            // 
            dgvPrestamos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPrestamos.Location = new Point(225, 687);
            dgvPrestamos.Name = "dgvPrestamos";
            dgvPrestamos.Size = new Size(240, 150);
            dgvPrestamos.TabIndex = 19;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 30F);
            label8.Location = new Point(107, 26);
            label8.Name = "label8";
            label8.Size = new Size(708, 54);
            label8.TabIndex = 20;
            label8.Text = "bienvenido al formulario de prestamos";
            // 
            // frmPrestamos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1148, 932);
            Controls.Add(label8);
            Controls.Add(dgvPrestamos);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
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
            Name = "frmPrestamos";
            Text = "Prestamos";
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
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private DataGridView dgvPrestamos;
        private Label label8;
    }
}