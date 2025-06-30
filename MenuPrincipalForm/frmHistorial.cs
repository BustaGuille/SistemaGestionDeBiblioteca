using BibliotecaSystem.DAO;
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
    public partial class frmHistorial : Form
    {
        private HistorialDAO histoprestDAO = new HistorialDAO();
        public frmHistorial()
        {
            InitializeComponent();
            CargarHistorial();
        }

        private void CargarHistorial()
        {
            dgvHistorial.DataSource = null;
            dgvHistorial.DataSource = histoprestDAO.ListarHistorial(); // reutilizamos el método del DAO
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cmbSocioFiltro.Text))
            {
                MessageBox.Show("Ingrese un ID de socio para buscar.");
                return;
            }

            if (!int.TryParse(cmbSocioFiltro.Text, out int socioId))
            {
                MessageBox.Show("El ID de socio debe ser un número entero.");
                return;
            }

            var prestamosFiltrados = histoprestDAO.ListarHistorial()
                .FindAll(p => p.IdSocio == socioId);

            if (prestamosFiltrados.Count == 0)
            {
                MessageBox.Show("No se encontraron préstamos para el socio ingresado.");
            }

            dgvHistorial.DataSource = null;
            dgvHistorial.DataSource = prestamosFiltrados;
        }
    }
}
