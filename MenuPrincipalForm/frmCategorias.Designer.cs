﻿namespace BibliotecaApp.UI
{
    partial class frmCategorias
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
            txtIdCategoria = new TextBox();
            txtNombreCategoria = new TextBox();
            btnAgregar = new Button();
            btnModificar = new Button();
            btnEliminar = new Button();
            btnLimpiar = new Button();
            dgvCategorias = new DataGridView();
            label3 = new Label();
            btnBuscar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvCategorias).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(25, 126);
            label1.Name = "label1";
            label1.Size = new Size(121, 28);
            label1.TabIndex = 0;
            label1.Text = "ID Categoría";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(25, 228);
            label2.Name = "label2";
            label2.Size = new Size(175, 28);
            label2.TabIndex = 1;
            label2.Text = "Nombre Categoría";
            // 
            // txtIdCategoria
            // 
            txtIdCategoria.Font = new Font("Segoe UI", 11F);
            txtIdCategoria.Location = new Point(315, 126);
            txtIdCategoria.Name = "txtIdCategoria";
            txtIdCategoria.Size = new Size(358, 32);
            txtIdCategoria.TabIndex = 2;
            // 
            // txtNombreCategoria
            // 
            txtNombreCategoria.Font = new Font("Segoe UI", 11F);
            txtNombreCategoria.Location = new Point(315, 228);
            txtNombreCategoria.Name = "txtNombreCategoria";
            txtNombreCategoria.Size = new Size(358, 32);
            txtNombreCategoria.TabIndex = 3;
            // 
            // btnAgregar
            // 
            btnAgregar.Font = new Font("Segoe UI", 12F);
            btnAgregar.Location = new Point(25, 312);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(648, 38);
            btnAgregar.TabIndex = 4;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Font = new Font("Segoe UI", 12F);
            btnModificar.Location = new Point(25, 458);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(648, 39);
            btnModificar.TabIndex = 5;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Font = new Font("Segoe UI", 12F);
            btnEliminar.Location = new Point(25, 356);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(648, 42);
            btnEliminar.TabIndex = 6;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Font = new Font("Segoe UI", 12F);
            btnLimpiar.Location = new Point(25, 404);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(648, 37);
            btnLimpiar.TabIndex = 7;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // dgvCategorias
            // 
            dgvCategorias.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCategorias.Location = new Point(25, 511);
            dgvCategorias.Name = "dgvCategorias";
            dgvCategorias.RowHeadersWidth = 51;
            dgvCategorias.Size = new Size(648, 166);
            dgvCategorias.TabIndex = 10;
            dgvCategorias.CellContentClick += dgvCategorias_CellContentClick;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 20F);
            label3.Location = new Point(25, 47);
            label3.Name = "label3";
            label3.Size = new Size(587, 46);
            label3.TabIndex = 12;
            label3.Text = "Bienvenido al fomulario de Categorias";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(438, 173);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(94, 29);
            btnBuscar.TabIndex = 13;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // frmCategorias
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(704, 703);
            Controls.Add(btnBuscar);
            Controls.Add(label3);
            Controls.Add(dgvCategorias);
            Controls.Add(btnLimpiar);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
            Controls.Add(btnAgregar);
            Controls.Add(txtNombreCategoria);
            Controls.Add(txtIdCategoria);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmCategorias";
            Text = "Formulario de Categorias";
            ((System.ComponentModel.ISupportInitialize)dgvCategorias).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtIdCategoria;
        private TextBox txtNombreCategoria;
        private Button btnAgregar;
        private Button btnModificar;
        private Button btnEliminar;
        private Button btnLimpiar;
        private DataGridView dgvCategorias;
        private Label label3;
        private Button btnBuscar;
    }
}