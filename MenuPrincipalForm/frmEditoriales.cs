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
    public partial class frmEditoriales : Form
    {
        private EditorialDAO editorialDAO = new EditorialDAO();

        public frmEditoriales()
        {
            InitializeComponent();
            CargarEditoriales();
        }

        private void CargarEditoriales()
        {
            dgvEditoriales.DataSource = null;
            dgvEditoriales.DataSource = editorialDAO.ListarEditoriales();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Editorial nueva = new Editorial
            {
                NombreEditorial = txtNombreEditorial.Text
            };

            editorialDAO.AgregarEditorial(nueva);
            CargarEditoriales();
            LimpiarCampos();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtIdEditorial.Text)) return;

            Editorial modificado = new Editorial
            {
                IdEditorial = int.Parse(txtIdEditorial.Text),
                NombreEditorial = txtNombreEditorial.Text
            };

            editorialDAO.ModificarEditorial(modificado);
            CargarEditoriales();
            LimpiarCampos();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtIdEditorial.Text)) return;

            int id = int.Parse(txtIdEditorial.Text);
            editorialDAO.EliminarEditorial(id);
            CargarEditoriales();
            LimpiarCampos();
        }

        private void dgvEditoriales_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var fila = dgvEditoriales.Rows[e.RowIndex];
                txtIdEditorial.Text = fila.Cells["IdEditorial"].Value.ToString();
                txtNombreEditorial.Text = fila.Cells["NombreEditorial"].Value.ToString();
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }
        private void LimpiarCampos()
        {
            txtIdEditorial.Text = "";
            txtNombreEditorial.Text = "";
        }
    }
}
