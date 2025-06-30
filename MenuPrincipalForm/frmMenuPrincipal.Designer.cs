namespace MenuPrincipalForm
{
    partial class frmMenuPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            sistemaToolStripMenuItem = new ToolStripMenuItem();
            acercaDeToolStripMenuItem = new ToolStripMenuItem();
            salirToolStripMenuItem = new ToolStripMenuItem();
            gestionToolStripMenuItem = new ToolStripMenuItem();
            usuariosToolStripMenuItem = new ToolStripMenuItem();
            librosToolStripMenuItem = new ToolStripMenuItem();
            sociosToolStripMenuItem = new ToolStripMenuItem();
            autoresToolStripMenuItem = new ToolStripMenuItem();
            editorialesToolStripMenuItem = new ToolStripMenuItem();
            categoriasToolStripMenuItem = new ToolStripMenuItem();
            movimientosToolStripMenuItem = new ToolStripMenuItem();
            prestamosToolStripMenuItem = new ToolStripMenuItem();
            reservasToolStripMenuItem = new ToolStripMenuItem();
            multasToolStripMenuItem = new ToolStripMenuItem();
            historialToolStripMenuItem = new ToolStripMenuItem();
            ayudaToolStripMenuItem = new ToolStripMenuItem();
            manualDeUsuariosToolStripMenuItem = new ToolStripMenuItem();
            versionToolStripMenuItem = new ToolStripMenuItem();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { sistemaToolStripMenuItem, gestionToolStripMenuItem, movimientosToolStripMenuItem, ayudaToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(10, 4, 0, 4);
            menuStrip1.Size = new Size(871, 37);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // sistemaToolStripMenuItem
            // 
            sistemaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { acercaDeToolStripMenuItem, salirToolStripMenuItem });
            sistemaToolStripMenuItem.Font = new Font("Segoe UI", 14F);
            sistemaToolStripMenuItem.Name = "sistemaToolStripMenuItem";
            sistemaToolStripMenuItem.Size = new Size(89, 29);
            sistemaToolStripMenuItem.Text = "Sistema";
            // 
            // acercaDeToolStripMenuItem
            // 
            acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            acercaDeToolStripMenuItem.Size = new Size(180, 30);
            acercaDeToolStripMenuItem.Text = "Acerca de";
            acercaDeToolStripMenuItem.Click += acercaDeToolStripMenuItem_Click;
            // 
            // salirToolStripMenuItem
            // 
            salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            salirToolStripMenuItem.Size = new Size(180, 30);
            salirToolStripMenuItem.Text = "Salir";
            salirToolStripMenuItem.Click += salirToolStripMenuItem_Click;
            // 
            // gestionToolStripMenuItem
            // 
            gestionToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { usuariosToolStripMenuItem, librosToolStripMenuItem, sociosToolStripMenuItem, autoresToolStripMenuItem, editorialesToolStripMenuItem, categoriasToolStripMenuItem });
            gestionToolStripMenuItem.Font = new Font("Segoe UI", 14F);
            gestionToolStripMenuItem.Name = "gestionToolStripMenuItem";
            gestionToolStripMenuItem.Size = new Size(88, 29);
            gestionToolStripMenuItem.Text = "Gestion";
            // 
            // usuariosToolStripMenuItem
            // 
            usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            usuariosToolStripMenuItem.Size = new Size(180, 30);
            usuariosToolStripMenuItem.Text = "Usuarios";
            usuariosToolStripMenuItem.Click += usuariosToolStripMenuItem_Click;
            // 
            // librosToolStripMenuItem
            // 
            librosToolStripMenuItem.Name = "librosToolStripMenuItem";
            librosToolStripMenuItem.Size = new Size(180, 30);
            librosToolStripMenuItem.Text = "Libros";
            librosToolStripMenuItem.Click += librosToolStripMenuItem_Click;
            // 
            // sociosToolStripMenuItem
            // 
            sociosToolStripMenuItem.Name = "sociosToolStripMenuItem";
            sociosToolStripMenuItem.Size = new Size(180, 30);
            sociosToolStripMenuItem.Text = "Socios";
            sociosToolStripMenuItem.Click += sociosToolStripMenuItem_Click;
            // 
            // autoresToolStripMenuItem
            // 
            autoresToolStripMenuItem.Name = "autoresToolStripMenuItem";
            autoresToolStripMenuItem.Size = new Size(180, 30);
            autoresToolStripMenuItem.Text = "Autores";
            autoresToolStripMenuItem.Click += autoresToolStripMenuItem_Click;
            // 
            // editorialesToolStripMenuItem
            // 
            editorialesToolStripMenuItem.Name = "editorialesToolStripMenuItem";
            editorialesToolStripMenuItem.Size = new Size(180, 30);
            editorialesToolStripMenuItem.Text = "Editoriales";
            editorialesToolStripMenuItem.Click += editorialesToolStripMenuItem_Click;
            // 
            // categoriasToolStripMenuItem
            // 
            categoriasToolStripMenuItem.Name = "categoriasToolStripMenuItem";
            categoriasToolStripMenuItem.Size = new Size(180, 30);
            categoriasToolStripMenuItem.Text = "Categorias";
            categoriasToolStripMenuItem.Click += categoriasToolStripMenuItem_Click;
            // 
            // movimientosToolStripMenuItem
            // 
            movimientosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { prestamosToolStripMenuItem, reservasToolStripMenuItem, multasToolStripMenuItem, historialToolStripMenuItem });
            movimientosToolStripMenuItem.Font = new Font("Segoe UI", 14F);
            movimientosToolStripMenuItem.Name = "movimientosToolStripMenuItem";
            movimientosToolStripMenuItem.Size = new Size(133, 29);
            movimientosToolStripMenuItem.Text = "Movimientos";
            // 
            // prestamosToolStripMenuItem
            // 
            prestamosToolStripMenuItem.Name = "prestamosToolStripMenuItem";
            prestamosToolStripMenuItem.Size = new Size(171, 30);
            prestamosToolStripMenuItem.Text = "Prestamos";
            prestamosToolStripMenuItem.Click += prestamosToolStripMenuItem_Click;
            // 
            // reservasToolStripMenuItem
            // 
            reservasToolStripMenuItem.Name = "reservasToolStripMenuItem";
            reservasToolStripMenuItem.Size = new Size(171, 30);
            reservasToolStripMenuItem.Text = "Reservas";
            reservasToolStripMenuItem.Click += reservasToolStripMenuItem_Click;
            // 
            // multasToolStripMenuItem
            // 
            multasToolStripMenuItem.Name = "multasToolStripMenuItem";
            multasToolStripMenuItem.Size = new Size(171, 30);
            multasToolStripMenuItem.Text = "Multas";
            multasToolStripMenuItem.Click += multasToolStripMenuItem_Click;
            // 
            // historialToolStripMenuItem
            // 
            historialToolStripMenuItem.Name = "historialToolStripMenuItem";
            historialToolStripMenuItem.Size = new Size(171, 30);
            historialToolStripMenuItem.Text = "Historial";
            historialToolStripMenuItem.Click += historialToolStripMenuItem_Click;
            // 
            // ayudaToolStripMenuItem
            // 
            ayudaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { manualDeUsuariosToolStripMenuItem, versionToolStripMenuItem });
            ayudaToolStripMenuItem.Font = new Font("Segoe UI", 14F);
            ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            ayudaToolStripMenuItem.Size = new Size(77, 29);
            ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // manualDeUsuariosToolStripMenuItem
            // 
            manualDeUsuariosToolStripMenuItem.Name = "manualDeUsuariosToolStripMenuItem";
            manualDeUsuariosToolStripMenuItem.Size = new Size(250, 30);
            manualDeUsuariosToolStripMenuItem.Text = "Manual de usuarios";
            // 
            // versionToolStripMenuItem
            // 
            versionToolStripMenuItem.Name = "versionToolStripMenuItem";
            versionToolStripMenuItem.Size = new Size(250, 30);
            versionToolStripMenuItem.Text = "Version";
            versionToolStripMenuItem.Click += versionToolStripMenuItem_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 30F);
            label1.Location = new Point(14, 146);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(845, 54);
            label1.TabIndex = 1;
            label1.Text = "Bienvenido al sistema de gestion de biblioteca";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = BibliotecaApp.UI.Properties.Resources.ofe5l4d9e0m61;
            pictureBox1.Location = new Point(66, 283);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(723, 394);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // frmMenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(871, 866);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            Font = new Font("Segoe UI", 14F);
            Margin = new Padding(5, 5, 5, 5);
            Name = "frmMenuPrincipal";
            Text = "Menu Principal";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem sistemaToolStripMenuItem;
        private ToolStripMenuItem acercaDeToolStripMenuItem;
        private ToolStripMenuItem salirToolStripMenuItem;
        private ToolStripMenuItem gestionToolStripMenuItem;
        private ToolStripMenuItem usuariosToolStripMenuItem;
        private ToolStripMenuItem librosToolStripMenuItem;
        private ToolStripMenuItem sociosToolStripMenuItem;
        private ToolStripMenuItem autoresToolStripMenuItem;
        private ToolStripMenuItem editorialesToolStripMenuItem;
        private ToolStripMenuItem categoriasToolStripMenuItem;
        private ToolStripMenuItem movimientosToolStripMenuItem;
        private ToolStripMenuItem prestamosToolStripMenuItem;
        private ToolStripMenuItem reservasToolStripMenuItem;
        private ToolStripMenuItem multasToolStripMenuItem;
        private ToolStripMenuItem historialToolStripMenuItem;
        private ToolStripMenuItem ayudaToolStripMenuItem;
        private ToolStripMenuItem manualDeUsuariosToolStripMenuItem;
        private ToolStripMenuItem versionToolStripMenuItem;
        private Label label1;
        private PictureBox pictureBox1;
    }
}
