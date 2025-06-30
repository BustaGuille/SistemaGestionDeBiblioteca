using BibliotecaSystem.DAO;
using BibliotecaSystem.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BibliotecaApp.UI
{
    public partial class frmReservas : Form
    {
        private ReservaDAO reservaDAO = new ReservaDAO();
        public frmReservas()
        {
            InitializeComponent();
            CargarReservas();
        }
        private void CargarReservas()
        {
            dgvReservas.DataSource = null;
            dgvReservas.DataSource = reservaDAO.ListarReservas();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Reserva nueva = new Reserva
            {
                IdLibro = Convert.ToInt32(cbLibro.SelectedValue),
                IdSocio = Convert.ToInt32(cbSocio.SelectedValue),
                //IdLibro = int.Parse(cbLibro.Text),
                //IdSocio = int.Parse(cbSocio.Text),
                FechaReserva = dtpFechaReserva.Value
            };

            reservaDAO.AgregarReserva(nueva);
            CargarReservas();
            LimpiarCampos();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtIdReserva.Text)) return;

            int id = int.Parse(txtIdReserva.Text);
            reservaDAO.EliminarReserva(id);
            CargarReservas();
            LimpiarCampos();
        }

        private void dgvReservas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var fila = dgvReservas.Rows[e.RowIndex];
                txtIdReserva.Text = fila.Cells["IdReserva"].Value.ToString();
                cbLibro.Text = fila.Cells["LibroId"].Value.ToString();
                cbSocio.Text = fila.Cells["SocioId"].Value.ToString();
                dtpFechaReserva.Value = Convert.ToDateTime(fila.Cells["FechaReserva"].Value);
            }
        }

        private void LimpiarCampos()
        {
            txtIdReserva.Text = "";
            cbLibro.Text = "";
            cbSocio.Text = "";
            dtpFechaReserva.Value = DateTime.Now;
        }
    }
}