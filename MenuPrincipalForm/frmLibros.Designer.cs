namespace BibliotecaApp.UI
{
    partial class frmLibros
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
            label8 = new Label();
            txtIDLibro = new TextBox();
            txtTitulo = new TextBox();
            txtISBN = new TextBox();
            txtAñoPublicacion = new TextBox();
            cmbAutor = new ComboBox();
            cmbEditorial = new ComboBox();
            cmbCategoria = new ComboBox();
            cmbEstado = new ComboBox();
            btnLimpiar = new Button();
            btnEliminar = new Button();
            btnModificar = new Button();
            btnAgregar = new Button();
            dgvLibros = new DataGridView();
            label9 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvLibros).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(76, 236);
            label1.Name = "label1";
            label1.Size = new Size(90, 21);
            label1.TabIndex = 0;
            label1.Text = "ID del Libro";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(76, 291);
            label2.Name = "label2";
            label2.Size = new Size(114, 21);
            label2.TabIndex = 1;
            label2.Text = "Titulo del Libro";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(76, 353);
            label3.Name = "label3";
            label3.Size = new Size(44, 21);
            label3.TabIndex = 2;
            label3.Text = "ISBN";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(76, 418);
            label4.Name = "label4";
            label4.Size = new Size(142, 21);
            label4.TabIndex = 3;
            label4.Text = "Año de publicacion";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(76, 475);
            label5.Name = "label5";
            label5.Size = new Size(49, 21);
            label5.TabIndex = 4;
            label5.Text = "Autor";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(76, 537);
            label6.Name = "label6";
            label6.Size = new Size(67, 21);
            label6.TabIndex = 5;
            label6.Text = "Editorial";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F);
            label7.Location = new Point(76, 598);
            label7.Name = "label7";
            label7.Size = new Size(77, 21);
            label7.TabIndex = 6;
            label7.Text = "Categoria";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F);
            label8.Location = new Point(76, 652);
            label8.Name = "label8";
            label8.Size = new Size(121, 21);
            label8.TabIndex = 7;
            label8.Text = "Estado del Libro";
            // 
            // txtIDLibro
            // 
            txtIDLibro.Font = new Font("Segoe UI", 11F);
            txtIDLibro.Location = new Point(249, 234);
            txtIDLibro.Name = "txtIDLibro";
            txtIDLibro.Size = new Size(262, 27);
            txtIDLibro.TabIndex = 8;
            // 
            // txtTitulo
            // 
            txtTitulo.Font = new Font("Segoe UI", 11F);
            txtTitulo.Location = new Point(249, 291);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(262, 27);
            txtTitulo.TabIndex = 9;
            // 
            // txtISBN
            // 
            txtISBN.Font = new Font("Segoe UI", 11F);
            txtISBN.Location = new Point(249, 353);
            txtISBN.Name = "txtISBN";
            txtISBN.Size = new Size(262, 27);
            txtISBN.TabIndex = 10;
            // 
            // txtAñoPublicacion
            // 
            txtAñoPublicacion.Font = new Font("Segoe UI", 11F);
            txtAñoPublicacion.Location = new Point(249, 412);
            txtAñoPublicacion.Name = "txtAñoPublicacion";
            txtAñoPublicacion.Size = new Size(262, 27);
            txtAñoPublicacion.TabIndex = 11;
            // 
            // cmbAutor
            // 
            cmbAutor.Font = new Font("Segoe UI", 11F);
            cmbAutor.FormattingEnabled = true;
            cmbAutor.Location = new Point(249, 468);
            cmbAutor.Name = "cmbAutor";
            cmbAutor.Size = new Size(262, 28);
            cmbAutor.TabIndex = 12;
            // 
            // cmbEditorial
            // 
            cmbEditorial.Font = new Font("Segoe UI", 11F);
            cmbEditorial.FormattingEnabled = true;
            cmbEditorial.Location = new Point(249, 530);
            cmbEditorial.Name = "cmbEditorial";
            cmbEditorial.Size = new Size(262, 28);
            cmbEditorial.TabIndex = 13;
            // 
            // cmbCategoria
            // 
            cmbCategoria.Font = new Font("Segoe UI", 11F);
            cmbCategoria.FormattingEnabled = true;
            cmbCategoria.Location = new Point(249, 591);
            cmbCategoria.Name = "cmbCategoria";
            cmbCategoria.Size = new Size(262, 28);
            cmbCategoria.TabIndex = 14;
            // 
            // cmbEstado
            // 
            cmbEstado.Font = new Font("Segoe UI", 11F);
            cmbEstado.FormattingEnabled = true;
            cmbEstado.Location = new Point(249, 645);
            cmbEstado.Name = "cmbEstado";
            cmbEstado.Size = new Size(262, 28);
            cmbEstado.TabIndex = 15;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Font = new Font("Segoe UI", 12F);
            btnLimpiar.Location = new Point(742, 727);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(150, 50);
            btnLimpiar.TabIndex = 21;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Font = new Font("Segoe UI", 12F);
            btnEliminar.Location = new Point(508, 727);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(150, 50);
            btnEliminar.TabIndex = 20;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Font = new Font("Segoe UI", 12F);
            btnModificar.Location = new Point(285, 727);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(150, 50);
            btnModificar.TabIndex = 19;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Font = new Font("Segoe UI", 12F);
            btnAgregar.Location = new Point(76, 727);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(150, 50);
            btnAgregar.TabIndex = 18;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // dgvLibros
            // 
            dgvLibros.AllowUserToAddRows = false;
            dgvLibros.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvLibros.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLibros.Location = new Point(568, 300);
            dgvLibros.Name = "dgvLibros";
            dgvLibros.ReadOnly = true;
            dgvLibros.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvLibros.Size = new Size(848, 319);
            dgvLibros.TabIndex = 22;
            dgvLibros.CellContentClick += dgvLibros_CellContentClick;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 30F);
            label9.Location = new Point(451, 74);
            label9.Name = "label9";
            label9.Size = new Size(621, 54);
            label9.TabIndex = 23;
            label9.Text = "Bienvenido al formulario de libros";
            // 
            // frmLibros
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1467, 972);
            Controls.Add(label9);
            Controls.Add(dgvLibros);
            Controls.Add(btnLimpiar);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
            Controls.Add(btnAgregar);
            Controls.Add(cmbEstado);
            Controls.Add(cmbCategoria);
            Controls.Add(cmbEditorial);
            Controls.Add(cmbAutor);
            Controls.Add(txtAñoPublicacion);
            Controls.Add(txtISBN);
            Controls.Add(txtTitulo);
            Controls.Add(txtIDLibro);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmLibros";
            Text = "libros";
            ((System.ComponentModel.ISupportInitialize)dgvLibros).EndInit();
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
        private Label label8;
        private TextBox txtIDLibro;
        private TextBox txtTitulo;
        private TextBox txtISBN;
        private TextBox txtAñoPublicacion;
        private ComboBox cmbAutor;
        private ComboBox cmbEditorial;
        private ComboBox cmbCategoria;
        private ComboBox cmbEstado;
        private Button btnLimpiar;
        private Button btnEliminar;
        private Button btnModificar;
        private Button btnAgregar;
        private DataGridView dgvLibros;
        private Label label9;
    }
}