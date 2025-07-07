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
            if (string.IsNullOrWhiteSpace(txtNombreEditorial.Text))
            {
                MessageBox.Show("Debe ingresar un nombre de editorial.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Editorial nueva = new Editorial
            {
                NombreEditorial = txtNombreEditorial.Text.Trim()
            };

            editorialDAO.AgregarEditorial(nueva);
            CargarEditoriales();
            LimpiarCampos();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtIdEditorial.Text))
            {
                MessageBox.Show("Debe ingresar el ID de la editorial que desea modificar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Editorial edit = new Editorial
            {
                IdEditorial = int.Parse(txtIdEditorial.Text),
                NombreEditorial = txtNombreEditorial.Text.Trim()
            };

            editorialDAO.ModificarEditorial(edit);
            CargarEditoriales();
            LimpiarCampos();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtIdEditorial.Text))
            {
                MessageBox.Show("Debe ingresar el ID de la editorial que desea eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txtIdEditorial.Text, out int idEditorial))
            {
                MessageBox.Show("ID inválido. Debe ser un número entero positivo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Editorial editorial = editorialDAO.ObtenerEditorialPorId(idEditorial);
            if (editorial == null)
            {
                MessageBox.Show("No se encontró una editorial con ese ID.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarCampos();
                return;
            }

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

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtIdEditorial.Text))
            {
                MessageBox.Show("Ingrese un ID de editorial para buscar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int id = int.Parse(txtIdEditorial.Text);
            Editorial edit = editorialDAO.ObtenerEditorialPorId(id);

            if (edit != null)
            {
                txtNombreEditorial.Text = edit.NombreEditorial;
            }
            else
            {
                MessageBox.Show("Editorial no encontrada.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarCampos();
            }
        }
    }
}
