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
            txtContrasena = new TextBox();
            btnAgregar = new Button();
            btnModificar = new Button();
            btnEliminar = new Button();
            dgvUsuarios = new DataGridView();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(503, 136);
            label1.Name = "label1";
            label1.Size = new Size(147, 21);
            label1.TabIndex = 0;
            label1.Text = "Nombre de Usuario";
            // 
            // txtNombreUsuario
            // 
            txtNombreUsuario.Font = new Font("Segoe UI", 11F);
            txtNombreUsuario.Location = new Point(426, 180);
            txtNombreUsuario.Name = "txtNombreUsuario";
            txtNombreUsuario.Size = new Size(312, 27);
            txtNombreUsuario.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(524, 229);
            label2.Name = "label2";
            label2.Size = new Size(89, 21);
            label2.TabIndex = 2;
            label2.Text = "Contraseña";
            // 
            // txtContrasena
            // 
            txtContrasena.Font = new Font("Segoe UI", 11F);
            txtContrasena.Location = new Point(426, 268);
            txtContrasena.Name = "txtContrasena";
            txtContrasena.Size = new Size(312, 27);
            txtContrasena.TabIndex = 3;
            txtContrasena.UseSystemPasswordChar = true;
            // 
            // btnAgregar
            // 
            btnAgregar.Font = new Font("Segoe UI", 12F);
            btnAgregar.Location = new Point(263, 329);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(150, 50);
            btnAgregar.TabIndex = 4;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            // 
            // btnModificar
            // 
            btnModificar.Font = new Font("Segoe UI", 12F);
            btnModificar.Location = new Point(503, 329);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(150, 50);
            btnModificar.TabIndex = 5;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            btnEliminar.Font = new Font("Segoe UI", 12F);
            btnEliminar.Location = new Point(740, 329);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(150, 50);
            btnEliminar.TabIndex = 6;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // dgvUsuarios
            // 
            dgvUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsuarios.Location = new Point(143, 513);
            dgvUsuarios.Name = "dgvUsuarios";
            dgvUsuarios.Size = new Size(848, 319);
            dgvUsuarios.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 30F);
            label3.Location = new Point(251, 66);
            label3.Name = "label3";
            label3.Size = new Size(649, 54);
            label3.TabIndex = 10;
            label3.Text = "Bienvenido al fomulario del usuario";
            // 
            // frmUsuarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1122, 884);
            Controls.Add(label3);
            Controls.Add(dgvUsuarios);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
            Controls.Add(btnAgregar);
            Controls.Add(txtContrasena);
            Controls.Add(label2);
            Controls.Add(txtNombreUsuario);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 1, true);
            Name = "frmUsuarios";
            Text = "Usuario";
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNombreUsuario;
        private Label label2;
        private TextBox txtContrasena;
        private Button btnAgregar;
        private Button btnModificar;
        private Button btnEliminar;
        private DataGridView dgvUsuarios;
        private Label label3;
    }
}