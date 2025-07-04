namespace BibliotecaApp.UI
{
    partial class frmHistorial
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
            btnBuscar = new Button();
            dtpDesde = new DateTimePicker();
            dtpHasta = new DateTimePicker();
            cmbSocioFiltro = new ComboBox();
            cmbLibroFiltro = new ComboBox();
            dgvHistorial = new DataGridView();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            btnDescargar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvHistorial).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(77, 109);
            label1.Name = "label1";
            label1.Size = new Size(111, 20);
            label1.TabIndex = 0;
            label1.Text = "Filtro por Socio";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(76, 185);
            label2.Name = "label2";
            label2.Size = new Size(108, 20);
            label2.TabIndex = 1;
            label2.Text = "Filtro por Libro";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(76, 259);
            label3.Name = "label3";
            label3.Size = new Size(112, 20);
            label3.TabIndex = 2;
            label3.Text = "Filtro por Fecha";
            // 
            // btnBuscar
            // 
            btnBuscar.Font = new Font("Segoe UI", 11F);
            btnBuscar.Location = new Point(21, 400);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(221, 43);
            btnBuscar.TabIndex = 3;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // dtpDesde
            // 
            dtpDesde.Font = new Font("Segoe UI", 11F);
            dtpDesde.Location = new Point(348, 249);
            dtpDesde.Name = "dtpDesde";
            dtpDesde.Size = new Size(339, 32);
            dtpDesde.TabIndex = 4;
            // 
            // dtpHasta
            // 
            dtpHasta.Font = new Font("Segoe UI", 11F);
            dtpHasta.Location = new Point(348, 295);
            dtpHasta.Name = "dtpHasta";
            dtpHasta.Size = new Size(339, 32);
            dtpHasta.TabIndex = 5;
            // 
            // cmbSocioFiltro
            // 
            cmbSocioFiltro.Font = new Font("Segoe UI", 11F);
            cmbSocioFiltro.FormattingEnabled = true;
            cmbSocioFiltro.Location = new Point(348, 109);
            cmbSocioFiltro.Name = "cmbSocioFiltro";
            cmbSocioFiltro.Size = new Size(339, 33);
            cmbSocioFiltro.TabIndex = 6;
            // 
            // cmbLibroFiltro
            // 
            cmbLibroFiltro.Font = new Font("Segoe UI", 11F);
            cmbLibroFiltro.FormattingEnabled = true;
            cmbLibroFiltro.Location = new Point(348, 180);
            cmbLibroFiltro.Name = "cmbLibroFiltro";
            cmbLibroFiltro.Size = new Size(339, 33);
            cmbLibroFiltro.TabIndex = 7;
            // 
            // dgvHistorial
            // 
            dgvHistorial.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHistorial.Location = new Point(21, 467);
            dgvHistorial.Name = "dgvHistorial";
            dgvHistorial.RowHeadersWidth = 51;
            dgvHistorial.Size = new Size(666, 300);
            dgvHistorial.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 20F);
            label4.Location = new Point(76, 11);
            label4.Name = "label4";
            label4.Size = new Size(569, 46);
            label4.TabIndex = 9;
            label4.Text = "Bienvenido al Formulario de Historial";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(292, 257);
            label5.Name = "label5";
            label5.Size = new Size(51, 20);
            label5.TabIndex = 10;
            label5.Text = "Desde";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(292, 305);
            label6.Name = "label6";
            label6.Size = new Size(47, 20);
            label6.TabIndex = 11;
            label6.Text = "Hasta";
            // 
            // btnDescargar
            // 
            btnDescargar.Font = new Font("Segoe UI", 11F);
            btnDescargar.Location = new Point(466, 400);
            btnDescargar.Name = "btnDescargar";
            btnDescargar.Size = new Size(221, 43);
            btnDescargar.TabIndex = 12;
            btnDescargar.Text = "Descargar Historial";
            btnDescargar.UseVisualStyleBackColor = true;
            btnDescargar.Click += btnDescargar_Click;
            // 
            // frmHistorial
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(707, 809);
            Controls.Add(btnDescargar);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(dgvHistorial);
            Controls.Add(cmbLibroFiltro);
            Controls.Add(cmbSocioFiltro);
            Controls.Add(dtpHasta);
            Controls.Add(dtpDesde);
            Controls.Add(btnBuscar);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmHistorial";
            Text = "D";
            ((System.ComponentModel.ISupportInitialize)dgvHistorial).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnBuscar;
        private DateTimePicker dtpDesde;
        private DateTimePicker dtpHasta;
        private ComboBox cmbSocioFiltro;
        private ComboBox cmbLibroFiltro;
        private DataGridView dgvHistorial;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button btnDescargar;
    }
}