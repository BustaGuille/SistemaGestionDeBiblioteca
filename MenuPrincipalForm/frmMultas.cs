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
            CargarSocios();
            CargarMultas();
            dgvMultas.CellFormatting += dgvMultas_CellFormatting; // ← registrar el evento aquí
        }

        private void CargarMultas()
        {
            dgvMultas.DataSource = null;
            var multas = multaDAO.ListarMultas();
            var socios = new SocioDAO().ListarSocios();

            // Unimos las multas con los nombres de los socios
            var datos = multas.Select(m => new
            {
                m.IdMulta,
                Socio = socios.FirstOrDefault(s => s.IdSocio == m.IdSocio)?.NombreSocio ?? "Desconocido",
                Monto = m.Monto,
                FechaGeneracion = m.FechaGeneracion.ToString("dd/MM/yyyy"),
                m.Motivo
            }).ToList();

            dgvMultas.DataSource = datos;

            // Formatear columna Monto en formato moneda paraguaya (Gs)
            if (dgvMultas.Columns["Monto"] != null)
            {
                dgvMultas.Columns["Monto"].DefaultCellStyle.Format = "N0"; // Miles sin decimales
                dgvMultas.Columns["Monto"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            }
        }


        private void CargarSocios()
        {
            SocioDAO socioDAO = new SocioDAO();
            List<Socio> socios = socioDAO.ListarSocios();

            cmbSocio.DataSource = socios;
            cmbSocio.DisplayMember = "NombreSocio";
            cmbSocio.ValueMember = "IdSocio";
            cmbSocio.SelectedIndex = -1;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (cmbSocio.SelectedIndex == -1 || cmbSocio.SelectedValue == null)
            {
                MessageBox.Show("Debe seleccionar un socio válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(txtMonto.Text.Trim(), out decimal monto) || monto <= 0)
            {
                MessageBox.Show("Debe ingresar un monto válido mayor que cero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtMotivo.Text))
            {
                MessageBox.Show("Debe ingresar un motivo para la multa.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DateTime fecha = dtpFechaMulta.Value;
            if (fecha > DateTime.Today)
            {
                MessageBox.Show("La fecha de la multa no puede ser futura.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

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
                CargarMultas();
                LimpiarCampos();
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

            Multa multaExistente = multaDAO.ObtenerMultaPorId(idMulta);
            if (multaExistente == null)
            {
                MessageBox.Show("No se encontró ninguna multa con ese ID. No se puede eliminar.", "No encontrada", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                cmbSocio.SelectedValue = Convert.ToInt32(fila.Cells["IdSocio"].Value);
                txtMonto.Text = fila.Cells["Monto"].Value.ToString();
                txtMotivo.Text = fila.Cells["Motivo"].Value.ToString();
                dtpFechaMulta.Value = Convert.ToDateTime(fila.Cells["FechaGeneracion"].Value);
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
                txtMonto.Text = multa.Monto.ToString("N0");
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
            if (!int.TryParse(txtIdMulta.Text.Trim(), out int idMulta))
            {
                MessageBox.Show("Debe ingresar un ID de multa válido.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cmbSocio.SelectedIndex == -1 || cmbSocio.SelectedValue == null)
            {
                MessageBox.Show("Debe seleccionar un socio válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(txtMonto.Text.Trim(), out decimal monto) || monto <= 0)
            {
                MessageBox.Show("Ingrese un monto válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtMotivo.Text))
            {
                MessageBox.Show("Ingrese el motivo de la multa.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DateTime fecha = dtpFechaMulta.Value;
            if (fecha > DateTime.Today)
            {
                MessageBox.Show("La fecha de la multa no puede ser futura.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

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

        private void dgvMultas_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvMultas.Columns[e.ColumnIndex].Name == "Monto" && e.Value != null)
            {
                if (decimal.TryParse(e.Value.ToString(), out decimal monto))
                {
                    e.Value = $"₲{monto:N0}";
                    e.FormattingApplied = true;
                }
            }
        }
    }
}
