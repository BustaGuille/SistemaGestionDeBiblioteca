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
            ((System.ComponentModel.ISupportInitialize)dgvHistorial).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(84, 109);
            label1.Name = "label1";
            label1.Size = new Size(111, 20);
            label1.TabIndex = 0;
            label1.Text = "Filtro por Socio";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(83, 170);
            label2.Name = "label2";
            label2.Size = new Size(108, 20);
            label2.TabIndex = 1;
            label2.Text = "Filtro por Libro";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(83, 231);
            label3.Name = "label3";
            label3.Size = new Size(112, 20);
            label3.TabIndex = 2;
            label3.Text = "Filtro por Fecha";
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(847, 286);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(94, 29);
            btnBuscar.TabIndex = 3;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // dtpDesde
            // 
            dtpDesde.Location = new Point(362, 231);
            dtpDesde.Name = "dtpDesde";
            dtpDesde.Size = new Size(250, 27);
            dtpDesde.TabIndex = 4;
            // 
            // dtpHasta
            // 
            dtpHasta.Location = new Point(691, 231);
            dtpHasta.Name = "dtpHasta";
            dtpHasta.Size = new Size(250, 27);
            dtpHasta.TabIndex = 5;
            // 
            // cmbSocioFiltro
            // 
            cmbSocioFiltro.FormattingEnabled = true;
            cmbSocioFiltro.Location = new Point(691, 101);
            cmbSocioFiltro.Name = "cmbSocioFiltro";
            cmbSocioFiltro.Size = new Size(250, 28);
            cmbSocioFiltro.TabIndex = 6;
            // 
            // cmbLibroFiltro
            // 
            cmbLibroFiltro.FormattingEnabled = true;
            cmbLibroFiltro.Location = new Point(691, 162);
            cmbLibroFiltro.Name = "cmbLibroFiltro";
            cmbLibroFiltro.Size = new Size(250, 28);
            cmbLibroFiltro.TabIndex = 7;
            // 
            // dgvHistorial
            // 
            dgvHistorial.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHistorial.Location = new Point(83, 347);
            dgvHistorial.Name = "dgvHistorial";
            dgvHistorial.RowHeadersWidth = 51;
            dgvHistorial.Size = new Size(858, 321);
            dgvHistorial.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 30F);
            label4.Location = new Point(83, 11);
            label4.Name = "label4";
            label4.Size = new Size(837, 67);
            label4.TabIndex = 9;
            label4.Text = "Bienvenido al Formulario de Historial";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(306, 236);
            label5.Name = "label5";
            label5.Size = new Size(51, 20);
            label5.TabIndex = 10;
            label5.Text = "Desde";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(635, 236);
            label6.Name = "label6";
            label6.Size = new Size(47, 20);
            label6.TabIndex = 11;
            label6.Text = "Hasta";
            // 
            // frmHistorial
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1020, 688);
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
            Text = "frmHistorial";
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
    }
}