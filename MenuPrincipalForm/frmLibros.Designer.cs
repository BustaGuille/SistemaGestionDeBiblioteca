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
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            txtIdLibro = new TextBox();
            txtTitulo = new TextBox();
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
            btnBuscar = new Button();
            txtCantidad = new TextBox();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvLibros).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(19, 97);
            label1.Name = "label1";
            label1.Size = new Size(113, 28);
            label1.TabIndex = 0;
            label1.Text = "ID del Libro";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(19, 154);
            label2.Name = "label2";
            label2.Size = new Size(144, 28);
            label2.TabIndex = 1;
            label2.Text = "Titulo del Libro";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(19, 232);
            label5.Name = "label5";
            label5.Size = new Size(62, 28);
            label5.TabIndex = 4;
            label5.Text = "Autor";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(19, 297);
            label6.Name = "label6";
            label6.Size = new Size(85, 28);
            label6.TabIndex = 5;
            label6.Text = "Editorial";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F);
            label7.Location = new Point(19, 378);
            label7.Name = "label7";
            label7.Size = new Size(97, 28);
            label7.TabIndex = 6;
            label7.Text = "Categoria";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F);
            label8.Location = new Point(19, 450);
            label8.Name = "label8";
            label8.Size = new Size(153, 28);
            label8.TabIndex = 7;
            label8.Text = "Estado del Libro";
            // 
            // txtIdLibro
            // 
            txtIdLibro.Font = new Font("Segoe UI", 11F);
            txtIdLibro.Location = new Point(217, 94);
            txtIdLibro.Margin = new Padding(3, 4, 3, 4);
            txtIdLibro.Name = "txtIdLibro";
            txtIdLibro.Size = new Size(299, 32);
            txtIdLibro.TabIndex = 8;
            // 
            // txtTitulo
            // 
            txtTitulo.Font = new Font("Segoe UI", 11F);
            txtTitulo.Location = new Point(217, 154);
            txtTitulo.Margin = new Padding(3, 4, 3, 4);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(299, 32);
            txtTitulo.TabIndex = 9;
            // 
            // cmbAutor
            // 
            cmbAutor.Font = new Font("Segoe UI", 11F);
            cmbAutor.FormattingEnabled = true;
            cmbAutor.Location = new Point(217, 223);
            cmbAutor.Margin = new Padding(3, 4, 3, 4);
            cmbAutor.Name = "cmbAutor";
            cmbAutor.Size = new Size(299, 33);
            cmbAutor.TabIndex = 12;
            // 
            // cmbEditorial
            // 
            cmbEditorial.Font = new Font("Segoe UI", 11F);
            cmbEditorial.FormattingEnabled = true;
            cmbEditorial.Location = new Point(217, 288);
            cmbEditorial.Margin = new Padding(3, 4, 3, 4);
            cmbEditorial.Name = "cmbEditorial";
            cmbEditorial.Size = new Size(299, 33);
            cmbEditorial.TabIndex = 13;
            // 
            // cmbCategoria
            // 
            cmbCategoria.Font = new Font("Segoe UI", 11F);
            cmbCategoria.FormattingEnabled = true;
            cmbCategoria.Location = new Point(217, 369);
            cmbCategoria.Margin = new Padding(3, 4, 3, 4);
            cmbCategoria.Name = "cmbCategoria";
            cmbCategoria.Size = new Size(299, 33);
            cmbCategoria.TabIndex = 14;
            // 
            // cmbEstado
            // 
            cmbEstado.Font = new Font("Segoe UI", 11F);
            cmbEstado.FormattingEnabled = true;
            cmbEstado.Location = new Point(217, 441);
            cmbEstado.Margin = new Padding(3, 4, 3, 4);
            cmbEstado.Name = "cmbEstado";
            cmbEstado.Size = new Size(299, 33);
            cmbEstado.TabIndex = 15;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Font = new Font("Segoe UI", 12F);
            btnLimpiar.Location = new Point(551, 739);
            btnLimpiar.Margin = new Padding(3, 4, 3, 4);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(134, 43);
            btnLimpiar.TabIndex = 21;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Font = new Font("Segoe UI", 12F);
            btnEliminar.Location = new Point(397, 738);
            btnEliminar.Margin = new Padding(3, 4, 3, 4);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(134, 44);
            btnEliminar.TabIndex = 20;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Font = new Font("Segoe UI", 10F);
            btnModificar.Location = new Point(187, 741);
            btnModificar.Margin = new Padding(3, 4, 3, 4);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(134, 43);
            btnModificar.TabIndex = 19;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Font = new Font("Segoe UI", 10F);
            btnAgregar.Location = new Point(19, 741);
            btnAgregar.Margin = new Padding(3, 4, 3, 4);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(134, 43);
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
            dgvLibros.Location = new Point(19, 560);
            dgvLibros.Margin = new Padding(3, 4, 3, 4);
            dgvLibros.Name = "dgvLibros";
            dgvLibros.ReadOnly = true;
            dgvLibros.RowHeadersWidth = 51;
            dgvLibros.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvLibros.Size = new Size(666, 170);
            dgvLibros.TabIndex = 22;
            dgvLibros.CellContentClick += dgvLibros_CellContentClick;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 20F);
            label9.Location = new Point(131, 18);
            label9.Name = "label9";
            label9.Size = new Size(522, 46);
            label9.TabIndex = 23;
            label9.Text = "Bienvenido al formulario de libros";
            // 
            // btnBuscar
            // 
            btnBuscar.Font = new Font("Segoe UI", 10F);
            btnBuscar.Location = new Point(551, 92);
            btnBuscar.Margin = new Padding(3, 4, 3, 4);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(134, 43);
            btnBuscar.TabIndex = 24;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // txtCantidad
            // 
            txtCantidad.Font = new Font("Segoe UI", 11F);
            txtCantidad.Location = new Point(217, 504);
            txtCantidad.Margin = new Padding(3, 4, 3, 4);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(299, 32);
            txtCantidad.TabIndex = 26;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(19, 504);
            label3.Name = "label3";
            label3.Size = new Size(190, 28);
            label3.TabIndex = 25;
            label3.Text = "Cantidad Disponible";
            // 
            // frmLibros
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(707, 809);
            Controls.Add(txtCantidad);
            Controls.Add(label3);
            Controls.Add(btnBuscar);
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
            Controls.Add(txtTitulo);
            Controls.Add(txtIdLibro);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmLibros";
            Text = "libros";
            ((System.ComponentModel.ISupportInitialize)dgvLibros).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox txtIdLibro;
        private TextBox txtTitulo;
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
        private Button btnBuscar;
        private TextBox txtCantidad;
        private Label label3;
    }
}