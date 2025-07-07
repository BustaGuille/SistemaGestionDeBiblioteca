namespace BibliotecaApp.UI
{
    partial class frmEditoriales
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
            txtIdEditorial = new TextBox();
            txtNombreEditorial = new TextBox();
            btnAgregar = new Button();
            btnModificar = new Button();
            btnEliminar = new Button();
            btnLimpiar = new Button();
            label3 = new Label();
            label1 = new Label();
            label2 = new Label();
            dgvEditoriales = new DataGridView();
            btnBuscar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvEditoriales).BeginInit();
            SuspendLayout();
            // 
            // txtIdEditorial
            // 
            txtIdEditorial.Font = new Font("Segoe UI", 11F);
            txtIdEditorial.Location = new Point(272, 129);
            txtIdEditorial.Name = "txtIdEditorial";
            txtIdEditorial.Size = new Size(358, 32);
            txtIdEditorial.TabIndex = 0;
            // 
            // txtNombreEditorial
            // 
            txtNombreEditorial.Font = new Font("Segoe UI", 11F);
            txtNombreEditorial.Location = new Point(272, 234);
            txtNombreEditorial.Name = "txtNombreEditorial";
            txtNombreEditorial.Size = new Size(358, 32);
            txtNombreEditorial.TabIndex = 1;
            // 
            // btnAgregar
            // 
            btnAgregar.Font = new Font("Segoe UI", 12F);
            btnAgregar.Location = new Point(64, 350);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(582, 43);
            btnAgregar.TabIndex = 2;
            btnAgregar.Tag = "";
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Font = new Font("Segoe UI", 12F);
            btnModificar.Location = new Point(64, 399);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(582, 38);
            btnModificar.TabIndex = 3;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Font = new Font("Segoe UI", 12F);
            btnEliminar.Location = new Point(64, 488);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(582, 40);
            btnEliminar.TabIndex = 4;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Font = new Font("Segoe UI", 12F);
            btnLimpiar.Location = new Point(64, 443);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(582, 39);
            btnLimpiar.TabIndex = 5;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 20F);
            label3.Location = new Point(55, 49);
            label3.Name = "label3";
            label3.Size = new Size(591, 46);
            label3.TabIndex = 11;
            label3.Text = "Bienvenido al fomulario de Editoriales ";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(64, 129);
            label1.Name = "label1";
            label1.Size = new Size(109, 28);
            label1.TabIndex = 12;
            label1.Text = "ID Editorial";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(64, 234);
            label2.Name = "label2";
            label2.Size = new Size(163, 28);
            label2.TabIndex = 13;
            label2.Text = "Nombre Editorial";
            // 
            // dgvEditoriales
            // 
            dgvEditoriales.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEditoriales.Location = new Point(64, 534);
            dgvEditoriales.Name = "dgvEditoriales";
            dgvEditoriales.RowHeadersWidth = 51;
            dgvEditoriales.Size = new Size(582, 128);
            dgvEditoriales.TabIndex = 14;
            dgvEditoriales.CellContentClick += dgvEditoriales_CellContentClick;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(411, 177);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(94, 29);
            btnBuscar.TabIndex = 15;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // frmEditoriales
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(680, 708);
            Controls.Add(btnBuscar);
            Controls.Add(dgvEditoriales);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(label3);
            Controls.Add(btnLimpiar);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
            Controls.Add(btnAgregar);
            Controls.Add(txtNombreEditorial);
            Controls.Add(txtIdEditorial);
            Name = "frmEditoriales";
            Text = "Formulario de Editoriales";
            ((System.ComponentModel.ISupportInitialize)dgvEditoriales).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtIdEditorial;
        private TextBox txtNombreEditorial;
        private Button btnAgregar;
        private Button btnModificar;
        private Button btnEliminar;
        private Button btnLimpiar;
        private Label label3;
        private Label label1;
        private Label label2;
        private DataGridView dgvEditoriales;
        private Button btnBuscar;
    }
}