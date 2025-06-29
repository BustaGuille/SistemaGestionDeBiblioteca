namespace BibliotecaApp.UI
{
    partial class frmUsuarios
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
            txtNombreUsuario = new TextBox();
            label2 = new Label();
            txtContraseña = new TextBox();
            btnAgregar = new Button();
            btnModificar = new Button();
            btnEliminar = new Button();
            btnBuscar = new Button();
            txtIdBuscar = new TextBox();
            dgvUsuarios = new DataGridView();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point, 1, true);
            label1.Location = new Point(442, 135);
            label1.Name = "label1";
            label1.Size = new Size(184, 28);
            label1.TabIndex = 0;
            label1.Text = "Nombre de Usuario";
            // 
            // txtNombreUsuario
            // 
            txtNombreUsuario.Location = new Point(479, 178);
            txtNombreUsuario.Name = "txtNombreUsuario";
            txtNombreUsuario.Size = new Size(100, 23);
            txtNombreUsuario.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point, 1, true);
            label2.Location = new Point(469, 216);
            label2.Name = "label2";
            label2.Size = new Size(110, 28);
            label2.TabIndex = 2;
            label2.Text = "Contraseña";
            // 
            // txtContraseña
            // 
            txtContraseña.Location = new Point(479, 275);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.Size = new Size(100, 23);
            txtContraseña.TabIndex = 3;
            txtContraseña.UseSystemPasswordChar = true;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(277, 328);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(100, 23);
            btnAgregar.TabIndex = 4;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(410, 328);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(101, 23);
            btnModificar.TabIndex = 5;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(551, 328);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(100, 23);
            btnEliminar.TabIndex = 6;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(698, 328);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(100, 23);
            btnBuscar.TabIndex = 7;
            btnBuscar.Text = "Buscar por ID";
            btnBuscar.UseVisualStyleBackColor = true;
            // 
            // txtIdBuscar
            // 
            txtIdBuscar.Location = new Point(698, 366);
            txtIdBuscar.Name = "txtIdBuscar";
            txtIdBuscar.Size = new Size(100, 23);
            txtIdBuscar.TabIndex = 8;
            txtIdBuscar.Text = "ID Usuarios";
            // 
            // dgvUsuarios
            // 
            dgvUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsuarios.Location = new Point(342, 448);
            dgvUsuarios.Name = "dgvUsuarios";
            dgvUsuarios.Size = new Size(361, 257);
            dgvUsuarios.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 50F);
            label3.Location = new Point(11, 8);
            label3.Name = "label3";
            label3.Size = new Size(1116, 89);
            label3.TabIndex = 10;
            label3.Text = "Bienvenido al fomularios de usuarios";
            // 
            // frmUsuarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1122, 884);
            Controls.Add(label3);
            Controls.Add(dgvUsuarios);
            Controls.Add(txtIdBuscar);
            Controls.Add(btnBuscar);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
            Controls.Add(btnAgregar);
            Controls.Add(txtContraseña);
            Controls.Add(label2);
            Controls.Add(txtNombreUsuario);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 1, true);
            Name = "frmUsuarios";
            Text = "frmUsuarios";
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNombreUsuario;
        private Label label2;
        private TextBox txtContraseña;
        private Button btnAgregar;
        private Button btnModificar;
        private Button btnEliminar;
        private Button btnBuscar;
        private TextBox txtIdBuscar;
        private DataGridView dgvUsuarios;
        private Label label3;
    }
}