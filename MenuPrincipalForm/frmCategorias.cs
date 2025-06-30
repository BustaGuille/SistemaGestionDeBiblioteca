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
        }

        private void CargarCategorias()
        {
            dgvCategorias.DataSource = null;
            dgvCategorias.DataSource = categoriaDAO.ListarCategorias();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Categoria nueva = new Categoria
            {
                NombreCategoria = txtNombreCategoria.Text
            };

            categoriaDAO.AgregarCategoria(nueva);
            CargarCategorias();
            LimpiarCampos();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtIdCategoria.Text)) return;

            Categoria modificada = new Categoria
            {
                IdCategoria = int.Parse(txtIdCategoria.Text),
                NombreCategoria = txtNombreCategoria.Text
            };

            categoriaDAO.ModificarCategoria(modificada);
            CargarCategorias();
            LimpiarCampos();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtIdCategoria.Text)) return;

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
    }
}
