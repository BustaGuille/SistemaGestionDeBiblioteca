﻿namespace BibliotecaApp.UI
{
    partial class frmSocios
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
            txtNombreSocio = new TextBox();
            txtCedula = new TextBox();
            txtDireccion = new TextBox();
            txtTelefono = new TextBox();
            txtEmail = new TextBox();
            btnAgregar = new Button();
            btnModificar = new Button();
            btnEliminar = new Button();
            btnLimpiar = new Button();
            label7 = new Label();
            dgvSocios = new DataGridView();
            label8 = new Label();
            btnBuscarID = new Button();
            txtIDSocio = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvSocios).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(25, 85);
            label1.Name = "label1";
            label1.Size = new Size(92, 21);
            label1.TabIndex = 0;
            label1.Text = "ID del Socio";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(25, 129);
            label2.Name = "label2";
            label2.Size = new Size(135, 21);
            label2.TabIndex = 1;
            label2.Text = "Nombre del Socio";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(25, 170);
            label3.Name = "label3";
            label3.Size = new Size(58, 21);
            label3.TabIndex = 2;
            label3.Text = "Cedula";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(25, 217);
            label4.Name = "label4";
            label4.Size = new Size(75, 21);
            label4.TabIndex = 3;
            label4.Text = "Direccion";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(25, 269);
            label5.Name = "label5";
            label5.Size = new Size(68, 21);
            label5.TabIndex = 4;
            label5.Text = "Telefono";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(25, 316);
            label6.Name = "label6";
            label6.Size = new Size(48, 21);
            label6.TabIndex = 5;
            label6.Text = "Email";
            // 
            // txtNombreSocio
            // 
            txtNombreSocio.Font = new Font("Segoe UI", 11F);
            txtNombreSocio.Location = new Point(255, 129);
            txtNombreSocio.Name = "txtNombreSocio";
            txtNombreSocio.Size = new Size(187, 27);
            txtNombreSocio.TabIndex = 7;
            // 
            // txtCedula
            // 
            txtCedula.Font = new Font("Segoe UI", 11F);
            txtCedula.Location = new Point(255, 175);
            txtCedula.Name = "txtCedula";
            txtCedula.Size = new Size(187, 27);
            txtCedula.TabIndex = 8;
            // 
            // txtDireccion
            // 
            txtDireccion.Font = new Font("Segoe UI", 11F);
            txtDireccion.Location = new Point(255, 222);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(187, 27);
            txtDireccion.TabIndex = 9;
            // 
            // txtTelefono
            // 
            txtTelefono.Font = new Font("Segoe UI", 11F);
            txtTelefono.Location = new Point(255, 274);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(187, 27);
            txtTelefono.TabIndex = 10;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 11F);
            txtEmail.Location = new Point(255, 321);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(187, 27);
            txtEmail.TabIndex = 11;
            // 
            // btnAgregar
            // 
            btnAgregar.Font = new Font("Segoe UI", 12F);
            btnAgregar.Location = new Point(12, 369);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(544, 31);
            btnAgregar.TabIndex = 12;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Font = new Font("Segoe UI", 12F);
            btnModificar.Location = new Point(12, 479);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(544, 27);
            btnModificar.TabIndex = 13;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Font = new Font("Segoe UI", 12F);
            btnEliminar.Location = new Point(12, 406);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(544, 31);
            btnEliminar.TabIndex = 14;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Font = new Font("Segoe UI", 12F);
            btnLimpiar.Location = new Point(12, 443);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(544, 30);
            btnLimpiar.TabIndex = 15;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(43, 40);
            label7.Name = "label7";
            label7.Size = new Size(0, 15);
            label7.TabIndex = 19;
            // 
            // dgvSocios
            // 
            dgvSocios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSocios.Location = new Point(12, 522);
            dgvSocios.Name = "dgvSocios";
            dgvSocios.Size = new Size(544, 182);
            dgvSocios.TabIndex = 20;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 20F);
            label8.Location = new Point(12, 22);
            label8.Name = "label8";
            label8.Size = new Size(421, 37);
            label8.TabIndex = 21;
            label8.Text = "Bienvenido al formulario del socio";
            // 
            // btnBuscarID
            // 
            btnBuscarID.Font = new Font("Segoe UI", 12F);
            btnBuscarID.Location = new Point(465, 73);
            btnBuscarID.Name = "btnBuscarID";
            btnBuscarID.Size = new Size(91, 44);
            btnBuscarID.TabIndex = 22;
            btnBuscarID.Text = "Buscar ID";
            btnBuscarID.UseVisualStyleBackColor = true;
            btnBuscarID.Click += btnBuscarID_Click;
            // 
            // txtIDSocio
            // 
            txtIDSocio.Location = new Point(255, 85);
            txtIDSocio.Name = "txtIDSocio";
            txtIDSocio.Size = new Size(187, 23);
            txtIDSocio.TabIndex = 23;
            // 
            // frmSocios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(569, 727);
            Controls.Add(txtIDSocio);
            Controls.Add(btnBuscarID);
            Controls.Add(label8);
            Controls.Add(dgvSocios);
            Controls.Add(label7);
            Controls.Add(btnLimpiar);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
            Controls.Add(btnAgregar);
            Controls.Add(txtEmail);
            Controls.Add(txtTelefono);
            Controls.Add(txtDireccion);
            Controls.Add(txtCedula);
            Controls.Add(txtNombreSocio);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmSocios";
            Text = "formulario del socio";
            ((System.ComponentModel.ISupportInitialize)dgvSocios).EndInit();
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
        private TextBox txtNombreSocio;
        private TextBox txtCedula;
        private TextBox txtDireccion;
        private TextBox txtTelefono;
        private TextBox txtEmail;
        private Button btnAgregar;
        private Button btnModificar;
        private Button btnEliminar;
        private Button btnLimpiar;
        private Label label7;
        private DataGridView dgvSocios;
        private Label label8;
        private Button btnBuscarID;
        private TextBox txtIDSocio;
    }
}