using BibliotecaSystem.DAO;
using BibliotecaSystem.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace BibliotecaApp.UI
{
    public partial class frmReservas : Form
    {
        private ReservaDAO reservaDAO = new ReservaDAO();
        private LibroDAO libroDAO = new LibroDAO();
        private SocioDAO socioDAO = new SocioDAO();
        int? idReservaSeleccionada = null;
        public frmReservas()
        {
            InitializeComponent();
            CargarReservas();
            CargarLibros();
            CargarSocios();
        }

        private void CargarReservas()
        {
            dgvReservas.DataSource = null;
            dgvReservas.DataSource = reservaDAO.ListarReservas();
        }

        private void CargarLibros()
        {
            cbLibro.DataSource = libroDAO.ListarLibros(); // Debe devolver una lista con IdLibro y Titulo
            cbLibro.DisplayMember = "Titulo";
            cbLibro.ValueMember = "IdLibro";
            cbLibro.SelectedIndex = -1;
        }

        private void CargarSocios()
        {
            cbSocio.DataSource = socioDAO.ListarSocios(); // Debe devolver una lista con IdSocio y NombreSocio
            cbSocio.DisplayMember = "NombreSocio";
            cbSocio.ValueMember = "IdSocio";
            cbSocio.SelectedIndex = -1;
        }

        private void LimpiarCampos()
        {
            txtIdReserva.Clear();
            cbLibro.SelectedIndex = -1;
            cbSocio.SelectedIndex = -1;
            dtpFechaReserva.Value = DateTime.Now;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            // Validar que se haya seleccionado un libro
            if (cbLibro.SelectedItem == null || cbLibro.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un libro.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validar que se haya seleccionado un socio
            if (cbSocio.SelectedItem == null || cbSocio.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un socio.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validar que la fecha no sea futura (opcional, pero recomendable)
            if (dtpFechaReserva.Value.Date > DateTime.Now.Date)
            {
                MessageBox.Show("La fecha de reserva no puede ser futura.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Si todo está correcto, creamos la reserva
            Reserva nueva = new Reserva
            {
                IdLibro = Convert.ToInt32(cbLibro.SelectedValue),
                IdSocio = Convert.ToInt32(cbSocio.SelectedValue),
                FechaReserva = dtpFechaReserva.Value,
                Activa = true
            };

            try
            {
                reservaDAO.AgregarReserva(nueva);
                MessageBox.Show("Reserva agregada exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarReservas();
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al agregar la reserva: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtIdReserva.Text, out int id))
            {
                MessageBox.Show("Debe buscar una reserva válida antes de modificar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cbLibro.SelectedIndex == -1 || cbSocio.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un libro y un socio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Reserva modificada = new Reserva
            {
                IdReserva = id,
                IdLibro = Convert.ToInt32(cbLibro.SelectedValue),
                IdSocio = Convert.ToInt32(cbSocio.SelectedValue),
                FechaReserva = dtpFechaReserva.Value
            };

            reservaDAO.ModificarReserva(modificada);
            MessageBox.Show("Reserva modificada correctamente.");
            CargarReservas();
            LimpiarCampos();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtIdReserva.Text, out int id))
            {
                MessageBox.Show("Debe buscar una reserva válida antes de eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult resultado = MessageBox.Show("¿Está seguro que desea eliminar esta reserva?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                reservaDAO.EliminarReserva(id);
                MessageBox.Show("Reserva eliminada.");
                CargarReservas();
                LimpiarCampos();
            }
        }

        private void dgvReservas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var fila = dgvReservas.Rows[e.RowIndex];
                txtIdReserva.Text = fila.Cells["IdReserva"].Value.ToString();
                cbLibro.SelectedValue = Convert.ToInt32(fila.Cells["IdLibro"].Value);
                cbSocio.SelectedValue = Convert.ToInt32(fila.Cells["IdSocio"].Value);
                dtpFechaReserva.Value = Convert.ToDateTime(fila.Cells["FechaReserva"].Value);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtIdReserva.Text, out int id))
            {
                MessageBox.Show("Ingrese un ID válido para buscar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Reserva reserva = reservaDAO.ObtenerReservaPorId(id);
            if (reserva != null)
            {
                txtIdReserva.Text = reserva.IdReserva.ToString();
                cbLibro.SelectedValue = reserva.IdLibro;
                cbSocio.SelectedValue = reserva.IdSocio;
                dtpFechaReserva.Value = reserva.FechaReserva;
                idReservaSeleccionada = reserva.IdReserva;
            }
            else
            {
                MessageBox.Show("No se encontró la reserva con ese ID.", "Búsqueda", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarCampos();
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }
    }
}
