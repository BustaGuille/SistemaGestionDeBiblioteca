using BibliotecaSystem.DAO;
using BibliotecaSystem.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
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

            var reservas = reservaDAO.ListarReservas();
            var socios = socioDAO.ListarSocios();
            var libros = libroDAO.ListarLibros();

            var datos = reservas.Select(r => new
            {
                r.IdReserva,
                Libro = libros.FirstOrDefault(l => l.IdLibro == r.IdLibro)?.Titulo ?? "Desconocido",
                Socio = socios.FirstOrDefault(s => s.IdSocio == r.IdSocio)?.NombreSocio ?? "Desconocido",
                FechaReserva = r.FechaReserva.ToString("dd/MM/yyyy"),
                r.Activa
            }).ToList();

            dgvReservas.DataSource = datos;
        }

        private void CargarLibros()
        {
            cbLibro.DataSource = libroDAO.ListarLibros();
            cbLibro.DisplayMember = "Titulo";
            cbLibro.ValueMember = "IdLibro";
            cbLibro.SelectedIndex = -1;
        }

        private void CargarSocios()
        {
            cbSocio.DataSource = socioDAO.ListarSocios();
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
            txtActivaManual.Clear(); // limpia el campo manual de Activa
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (cbLibro.SelectedItem == null || cbLibro.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un libro.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cbSocio.SelectedItem == null || cbSocio.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un socio.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string textoActiva = txtActivaManual.Text.Trim().ToUpper();
            bool activa;

            if (textoActiva == "SI") activa = true;
            else if (textoActiva == "NO") activa = false;
            else
            {
                MessageBox.Show("Debe escribir SI o NO en el campo de Activa.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Reserva nueva = new Reserva
            {
                IdLibro = Convert.ToInt32(cbLibro.SelectedValue),
                IdSocio = Convert.ToInt32(cbSocio.SelectedValue),
                FechaReserva = dtpFechaReserva.Value,
                Activa = activa
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

            // Interpretar SI o NO como valor booleano
            bool activa = txtActivaManual.Text.Trim().ToUpper() == "SI";

            Reserva modificada = new Reserva
            {
                IdReserva = id,
                IdLibro = Convert.ToInt32(cbLibro.SelectedValue),
                IdSocio = Convert.ToInt32(cbSocio.SelectedValue),
                FechaReserva = dtpFechaReserva.Value,
                Activa = activa
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

            Reserva reservaExistente = reservaDAO.ObtenerReservaPorId(id);
            if (reservaExistente == null)
            {
                MessageBox.Show("No se encontró ninguna reserva con ese ID. No se puede eliminar.", "No encontrada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DialogResult resultado = MessageBox.Show("¿Está seguro que desea eliminar esta reserva?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                try
                {
                    reservaDAO.EliminarReserva(id);
                    MessageBox.Show("Reserva eliminada correctamente.");
                    CargarReservas();
                    LimpiarCampos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar la reserva: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dgvReservas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var fila = dgvReservas.Rows[e.RowIndex];
                txtIdReserva.Text = fila.Cells["IdReserva"].Value.ToString();

                string nombreLibro = fila.Cells["Libro"].Value.ToString();
                string nombreSocio = fila.Cells["Socio"].Value.ToString();

                var libro = libroDAO.ListarLibros().FirstOrDefault(l => l.Titulo == nombreLibro);
                var socio = socioDAO.ListarSocios().FirstOrDefault(s => s.NombreSocio == nombreSocio);

                if (libro != null) cbLibro.SelectedValue = libro.IdLibro;
                if (socio != null) cbSocio.SelectedValue = socio.IdSocio;

                dtpFechaReserva.Value = DateTime.Parse(fila.Cells["FechaReserva"].Value.ToString());

                bool activa = Convert.ToBoolean(fila.Cells["Activa"].Value);
                txtActivaManual.Text = activa ? "Sí" : "No";
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
                txtActivaManual.Text = reserva.Activa ? "SI" : "NO";
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