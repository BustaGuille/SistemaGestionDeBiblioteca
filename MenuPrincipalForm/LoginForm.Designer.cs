namespace BibliotecaApp.UI
{
    partial class LoginForm
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
            lblUsuario = new Label();
            txtUsuario = new TextBox();
            txtContrasena = new TextBox();
            lblContraseña = new Label();
            btnIniciar = new Button();
            lblMensaje = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(115, 87);
            label1.Name = "label1";
            label1.Size = new Size(339, 46);
            label1.TabIndex = 0;
            label1.Text = "Bienvenido de Nuevo";
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Font = new Font("Segoe UI", 11F);
            lblUsuario.Location = new Point(115, 213);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(77, 25);
            lblUsuario.TabIndex = 1;
            lblUsuario.Text = "Usuario";
            // 
            // txtUsuario
            // 
            txtUsuario.Font = new Font("Segoe UI", 10F);
            txtUsuario.Location = new Point(267, 213);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.PlaceholderText = "Nombre de usuario";
            txtUsuario.Size = new Size(197, 30);
            txtUsuario.TabIndex = 2;
            // 
            // txtContrasena
            // 
            txtContrasena.Font = new Font("Segoe UI", 10F);
            txtContrasena.Location = new Point(267, 288);
            txtContrasena.Name = "txtContrasena";
            txtContrasena.Size = new Size(197, 30);
            txtContrasena.TabIndex = 4;
            txtContrasena.UseSystemPasswordChar = true;
            // 
            // lblContraseña
            // 
            lblContraseña.AutoSize = true;
            lblContraseña.Font = new Font("Segoe UI", 11F);
            lblContraseña.Location = new Point(115, 288);
            lblContraseña.Name = "lblContraseña";
            lblContraseña.Size = new Size(108, 25);
            lblContraseña.TabIndex = 3;
            lblContraseña.Text = "Contraseña";
            // 
            // btnIniciar
            // 
            btnIniciar.Location = new Point(179, 364);
            btnIniciar.Name = "btnIniciar";
            btnIniciar.Size = new Size(180, 36);
            btnIniciar.TabIndex = 5;
            btnIniciar.Text = "Iniciar Sesion";
            btnIniciar.UseVisualStyleBackColor = true;
            btnIniciar.Click += btnIniciar_Click;
            // 
            // lblMensaje
            // 
            lblMensaje.AutoSize = true;
            lblMensaje.ForeColor = Color.Red;
            lblMensaje.Location = new Point(115, 432);
            lblMensaje.Name = "lblMensaje";
            lblMensaje.Size = new Size(62, 20);
            lblMensaje.TabIndex = 6;
            lblMensaje.Text = "Messaje";
            lblMensaje.Visible = false;
            // 
            // LoginForm
            // 
            AcceptButton = btnIniciar;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(582, 621);
            Controls.Add(lblMensaje);
            Controls.Add(btnIniciar);
            Controls.Add(txtContrasena);
            Controls.Add(lblContraseña);
            Controls.Add(txtUsuario);
            Controls.Add(lblUsuario);
            Controls.Add(label1);
            Name = "LoginForm";
            Text = "Formulario del Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblUsuario;
        private TextBox txtUsuario;
        private TextBox txtContrasena;
        private Label lblContraseña;
        private Button btnIniciar;
        private Label lblMensaje;
    }
}