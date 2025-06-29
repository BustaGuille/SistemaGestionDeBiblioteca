namespace BibliotecaApp.UI
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
            txtIdSocio = new TextBox();
            txtNombreSocio = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            btnAgregar = new Button();
            btnModificar = new Button();
            btnEliminar = new Button();
            btnLimpiar = new Button();
            btnBuscar = new Button();
            txtBsucar = new TextBox();
            label7 = new Label();
            dataGridView1 = new DataGridView();
            label8 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(433, 160);
            label1.Name = "label1";
            label1.Size = new Size(117, 28);
            label1.TabIndex = 0;
            label1.Text = "ID del Socio";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F);
            label2.Location = new Point(433, 204);
            label2.Name = "label2";
            label2.Size = new Size(171, 28);
            label2.TabIndex = 1;
            label2.Text = "Nombre del Socio";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F);
            label3.Location = new Point(433, 245);
            label3.Name = "label3";
            label3.Size = new Size(72, 28);
            label3.TabIndex = 2;
            label3.Text = "Cedula";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15F);
            label4.Location = new Point(433, 292);
            label4.Name = "label4";
            label4.Size = new Size(94, 28);
            label4.TabIndex = 3;
            label4.Text = "Direccion";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15F);
            label5.Location = new Point(433, 344);
            label5.Name = "label5";
            label5.Size = new Size(86, 28);
            label5.TabIndex = 4;
            label5.Text = "Telefono";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 15F);
            label6.Location = new Point(433, 391);
            label6.Name = "label6";
            label6.Size = new Size(59, 28);
            label6.TabIndex = 5;
            label6.Text = "Email";
            // 
            // txtIdSocio
            // 
            txtIdSocio.Location = new Point(663, 165);
            txtIdSocio.Name = "txtIdSocio";
            txtIdSocio.ReadOnly = true;
            txtIdSocio.Size = new Size(187, 23);
            txtIdSocio.TabIndex = 6;
            // 
            // txtNombreSocio
            // 
            txtNombreSocio.Location = new Point(663, 209);
            txtNombreSocio.Name = "txtNombreSocio";
            txtNombreSocio.Size = new Size(187, 23);
            txtNombreSocio.TabIndex = 7;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(663, 250);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(187, 23);
            textBox3.TabIndex = 8;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(663, 297);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(187, 23);
            textBox4.TabIndex = 9;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(663, 349);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(187, 23);
            textBox5.TabIndex = 10;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(663, 396);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(187, 23);
            textBox6.TabIndex = 11;
            // 
            // btnAgregar
            // 
            btnAgregar.Font = new Font("Segoe UI", 12F);
            btnAgregar.Location = new Point(424, 461);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(91, 58);
            btnAgregar.TabIndex = 12;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            // 
            // btnModificar
            // 
            btnModificar.Font = new Font("Segoe UI", 12F);
            btnModificar.Location = new Point(563, 461);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(91, 58);
            btnModificar.TabIndex = 13;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            btnEliminar.Font = new Font("Segoe UI", 12F);
            btnEliminar.Location = new Point(708, 461);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(91, 58);
            btnEliminar.TabIndex = 14;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Font = new Font("Segoe UI", 12F);
            btnLimpiar.Location = new Point(836, 461);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(91, 58);
            btnLimpiar.TabIndex = 15;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(303, 588);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(75, 23);
            btnBuscar.TabIndex = 17;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            // 
            // txtBsucar
            // 
            txtBsucar.Location = new Point(433, 589);
            txtBsucar.Name = "txtBsucar";
            txtBsucar.Size = new Size(171, 23);
            txtBsucar.TabIndex = 18;
            txtBsucar.Text = "ID Socio";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(43, 40);
            label7.Name = "label7";
            label7.Size = new Size(0, 15);
            label7.TabIndex = 19;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(303, 637);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(773, 292);
            dataGridView1.TabIndex = 20;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 50F);
            label8.Location = new Point(67, 9);
            label8.Name = "label8";
            label8.Size = new Size(1149, 89);
            label8.TabIndex = 21;
            label8.Text = "Bienvenido al formulario de los socios";
            // 
            // frmSocios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1336, 991);
            Controls.Add(label8);
            Controls.Add(dataGridView1);
            Controls.Add(label7);
            Controls.Add(txtBsucar);
            Controls.Add(btnBuscar);
            Controls.Add(btnLimpiar);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
            Controls.Add(btnAgregar);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(txtNombreSocio);
            Controls.Add(txtIdSocio);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmSocios";
            Text = "frmSocios";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
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
        private TextBox txtIdSocio;
        private TextBox txtNombreSocio;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private Button btnAgregar;
        private Button btnModificar;
        private Button btnEliminar;
        private Button btnLimpiar;
        private Button btnBuscar;
        private TextBox txtBsucar;
        private Label label7;
        private DataGridView dataGridView1;
        private Label label8;
    }
}