using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BibliotecaSystem.DAO;
using BibliotecaSystem.Entidades;


namespace BibliotecaApp.UI
{
    public partial class frmMultas : Form
    {
        private MultaDAO multaDAO = new MultaDAO();

        public frmMultas()
        {
            InitializeComponent();
            CargarMultas();
        }

        private void CargarMultas()
        {
            dgvMultas.DataSource = null;
            dgvMultas.DataSource = multaDAO.ListarMultas();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Multa nueva = new Multa
            {
                IdSocio = int.Parse(cmbSocio.Text),
                Monto = decimal.Parse(txtMonto.Text),
                Motivo = txtMotivo.Text,
                FechaGeneracion = dtpFechaMulta.Value
            };

            multaDAO.RegistrarMulta(nueva);
            CargarMultas();
            LimpiarCampos();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtIdMulta.Text)) return;

            int id = int.Parse(txtIdMulta.Text);
            //multaDAO.EliminarMulta(id);
            CargarMultas();
            LimpiarCampos();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void LimpiarCampos()
        {
            txtIdMulta.Clear();
            cmbSocio.SelectedIndex = -1;
            txtMonto.Clear();
            txtMotivo.Clear();
            dtpFechaMulta.Value = DateTime.Now;
        }

        private void dgvMultas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var fila = dgvMultas.Rows[e.RowIndex];
                txtIdMulta.Text = fila.Cells["IdMulta"].Value.ToString();
                cmbSocio.Text = fila.Cells["SocioId"].Value.ToString();
                txtMonto.Text = fila.Cells["Monto"].Value.ToString();
                txtMotivo.Text = fila.Cells["Motivo"].Value.ToString();
                dtpFechaMulta.Value = Convert.ToDateTime(fila.Cells["FechaMulta"].Value);
            }
        }
    }
}
