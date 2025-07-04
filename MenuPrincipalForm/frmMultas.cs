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
            // Validar socio
            if (cmbSocio.SelectedIndex == -1 || cmbSocio.SelectedValue == null)
            {
                MessageBox.Show("Debe seleccionar un socio válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validar monto
            if (!decimal.TryParse(txtMonto.Text.Trim(), out decimal monto) || monto <= 0)
            {
                MessageBox.Show("Debe ingresar un monto válido mayor que cero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validar motivo
            if (string.IsNullOrWhiteSpace(txtMotivo.Text))
            {
                MessageBox.Show("Debe ingresar un motivo para la multa.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validar fecha
            DateTime fecha = dtpFechaMulta.Value;
            if (fecha > DateTime.Today)
            {
                MessageBox.Show("La fecha de la multa no puede ser futura.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Crear multa
            Multa nueva = new Multa
            {
                IdSocio = Convert.ToInt32(cmbSocio.SelectedValue),
                Monto = monto,
                Motivo = txtMotivo.Text.Trim(),
                FechaGeneracion = fecha,
                Pagada = false
            };

            try
            {
                multaDAO.RegistrarMulta(nueva);
                MessageBox.Show("Multa agregada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarMultas();   // Refresca el DataGridView
                LimpiarCampos();  // Limpia los campos
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar la multa: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtIdMulta.Text.Trim(), out int idMulta))
            {
                MessageBox.Show("Debe ingresar un ID válido para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult confirm = MessageBox.Show("¿Está seguro de eliminar esta multa?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.Yes)
            {
                try
                {
                    multaDAO.EliminarMulta(idMulta);
                    CargarMultas();
                    LimpiarCampos();
                    MessageBox.Show("Multa eliminada correctamente.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar la multa: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
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

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtIdMulta.Text.Trim(), out int idMulta))
            {
                MessageBox.Show("Ingrese un ID válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Multa multa = multaDAO.ObtenerMultaPorId(idMulta);
            if (multa != null)
            {
                txtIdMulta.Text = multa.IdMulta.ToString();
                cmbSocio.SelectedValue = multa.IdSocio;
                txtMonto.Text = multa.Monto.ToString("0.00");
                txtMotivo.Text = multa.Motivo;
                dtpFechaMulta.Value = multa.FechaGeneracion;
            }
            else
            {
                MessageBox.Show("No se encontró una multa con ese ID.", "Búsqueda", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarCampos();
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            // Validar que el ID de la multa sea válido
            if (!int.TryParse(txtIdMulta.Text.Trim(), out int idMulta))
            {
                MessageBox.Show("Debe ingresar un ID de multa válido.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validar selección de socio
            if (cmbSocio.SelectedIndex == -1 || cmbSocio.SelectedValue == null)
            {
                MessageBox.Show("Debe seleccionar un socio válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validar monto
            if (!decimal.TryParse(txtMonto.Text.Trim(), out decimal monto) || monto <= 0)
            {
                MessageBox.Show("Ingrese un monto válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validar motivo
            if (string.IsNullOrWhiteSpace(txtMotivo.Text))
            {
                MessageBox.Show("Ingrese el motivo de la multa.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validar fecha
            DateTime fecha = dtpFechaMulta.Value;
            if (fecha > DateTime.Today)
            {
                MessageBox.Show("La fecha de la multa no puede ser futura.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Crear objeto Modificado
            Multa modificada = new Multa
            {
                IdMulta = idMulta,
                IdSocio = Convert.ToInt32(cmbSocio.SelectedValue),
                Monto = monto,
                Motivo = txtMotivo.Text.Trim(),
                FechaGeneracion = fecha,
                Pagada = false
            };

            try
            {
                multaDAO.ModificarMulta(modificada);
                MessageBox.Show("Multa modificada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarMultas();
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar la multa: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
