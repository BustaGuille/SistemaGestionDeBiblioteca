namespace BibliotecaApp.UI
{
    partial class frmAutores
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
            txtIdAutor = new TextBox();
            txtNombreAutor = new TextBox();
            txtNacionalidad = new TextBox();
            btnAgregar = new Button();
            btnModificar = new Button();
            btnEliminar = new Button();
            btnLimpiar = new Button();
            dgvAutores = new DataGridView();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvAutores).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(28, 126);
            label1.Name = "label1";
            label1.Size = new Size(93, 21);
            label1.TabIndex = 0;
            label1.Text = "ID del Autor";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(28, 179);
            label2.Name = "label2";
            label2.Size = new Size(136, 21);
            label2.TabIndex = 1;
            label2.Text = "Nombre del Autor";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(28, 238);
            label3.Name = "label3";
            label3.Size = new Size(101, 21);
            label3.TabIndex = 2;
            label3.Text = "Nacionalidad";
            // 
            // txtIdAutor
            // 
            txtIdAutor.Font = new Font("Segoe UI", 11F);
            txtIdAutor.Location = new Point(362, 126);
            txtIdAutor.Name = "txtIdAutor";
            txtIdAutor.Size = new Size(277, 27);
            txtIdAutor.TabIndex = 3;
            // 
            // txtNombreAutor
            // 
            txtNombreAutor.Font = new Font("Segoe UI", 11F);
            txtNombreAutor.Location = new Point(362, 179);
            txtNombreAutor.Name = "txtNombreAutor";
            txtNombreAutor.Size = new Size(277, 27);
            txtNombreAutor.TabIndex = 4;
            // 
            // txtNacionalidad
            // 
            txtNacionalidad.Font = new Font("Segoe UI", 11F);
            txtNacionalidad.Location = new Point(362, 236);
            txtNacionalidad.Name = "txtNacionalidad";
            txtNacionalidad.Size = new Size(277, 27);
            txtNacionalidad.TabIndex = 5;
            // 
            // btnAgregar
            // 
            btnAgregar.Font = new Font("Segoe UI", 12F);
            btnAgregar.Location = new Point(12, 293);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(627, 31);
            btnAgregar.TabIndex = 6;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Font = new Font("Segoe UI", 12F);
            btnModificar.Location = new Point(12, 367);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(627, 31);
            btnModificar.TabIndex = 7;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Font = new Font("Segoe UI", 12F);
            btnEliminar.Location = new Point(12, 330);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(627, 31);
            btnEliminar.TabIndex = 8;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Font = new Font("Segoe UI", 12F);
            btnLimpiar.Location = new Point(12, 404);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(627, 31);
            btnLimpiar.TabIndex = 9;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // dgvAutores
            // 
            dgvAutores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAutores.Location = new Point(12, 465);
            dgvAutores.Name = "dgvAutores";
            dgvAutores.Size = new Size(627, 207);
            dgvAutores.TabIndex = 12;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 20F);
            label4.Location = new Point(28, 29);
            label4.Name = "label4";
            label4.Size = new Size(434, 37);
            label4.TabIndex = 13;
            label4.Text = "Bienvenido al fomulario de Autores";
            // 
            // frmAutores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(651, 705);
            Controls.Add(label4);
            Controls.Add(dgvAutores);
            Controls.Add(btnLimpiar);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
            Controls.Add(btnAgregar);
            Controls.Add(txtNacionalidad);
            Controls.Add(txtNombreAutor);
            Controls.Add(txtIdAutor);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmAutores";
            Text = "formulario de Autores";
            ((System.ComponentModel.ISupportInitialize)dgvAutores).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtIdAutor;
        private TextBox txtNombreAutor;
        private TextBox txtNacionalidad;
        private Button btnAgregar;
        private Button btnModificar;
        private Button btnEliminar;
        private Button btnLimpiar;
        private DataGridView dgvAutores;
        private Label label4;
    }
}