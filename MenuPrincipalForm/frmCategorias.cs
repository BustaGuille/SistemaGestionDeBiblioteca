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
    public partial class frmCategorias : Form
    {
        private CategoriaDAO categoriaDAO = new CategoriaDAO();
        public frmCategorias()
        {
            InitializeComponent();
            CargarCategorias();
        }

        private void CargarCategorias()
        {
            dgvCategorias.DataSource = null;
            dgvCategorias.DataSource = categoriaDAO.ListarCategorias();

            dgvCategorias.Columns["NombreCategoria"].HeaderText = "Categoria";
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombreCategoria.Text))
            {
                MessageBox.Show("Debe ingresar un nombre para la categoría.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Categoria nueva = new Categoria
            {
                NombreCategoria = txtNombreCategoria.Text.Trim()
            };

            categoriaDAO.AgregarCategoria(nueva);
            CargarCategorias();
            LimpiarCampos();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtIdCategoria.Text))
            {
                MessageBox.Show("Debe ingresar el ID de la categoría que desea modificar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Categoria cat = new Categoria
            {
                IdCategoria = int.Parse(txtIdCategoria.Text),
                NombreCategoria = txtNombreCategoria.Text.Trim()
            };

            categoriaDAO.ModificarCategoria(cat);
            CargarCategorias();
            LimpiarCampos();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtIdCategoria.Text))
            {
                MessageBox.Show("Debe ingresar el ID de la categoría que desea eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if(!int.TryParse(txtIdCategoria.Text, out int idCategoria))
            {
                MessageBox.Show("El ID de categoría debe ser un número válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Categoria categoria = categoriaDAO.ObtenerCategoriaPorId(idCategoria);
            if (categoria == null)
            {
                MessageBox.Show("Categoría no encontrada.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarCampos();
                return;
            }

            int id = int.Parse(txtIdCategoria.Text);
            categoriaDAO.EliminarCategoria(id);
            CargarCategorias();
            LimpiarCampos();
        }

        private void dgvCategorias_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var fila = dgvCategorias.Rows[e.RowIndex];
                txtIdCategoria.Text = fila.Cells["IdCategoria"].Value.ToString();
                txtNombreCategoria.Text = fila.Cells["NombreCategoria"].Value.ToString();
            }
        }

        private void LimpiarCampos()
        {
            txtIdCategoria.Text = "";
            txtNombreCategoria.Text = "";
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtIdCategoria.Text))
            {
                MessageBox.Show("Ingrese un ID de categoría para buscar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int id = int.Parse(txtIdCategoria.Text);
            Categoria cat = categoriaDAO.ObtenerCategoriaPorId(id);

            if (cat != null)
            {
                txtNombreCategoria.Text = cat.NombreCategoria;
            }
            else
            {
                MessageBox.Show("Categoría no encontrada.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarCampos();
            }
        }
    }
}
