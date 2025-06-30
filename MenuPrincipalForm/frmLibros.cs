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
    public partial class frmLibros : Form
    {
        private LibroDAO libroDAO = new LibroDAO();
        private AutorDAO autorDAO = new AutorDAO();
        private EditorialDAO editorialDAO = new EditorialDAO();
        private CategoriaDAO categoriaDAO = new CategoriaDAO(); 

        public frmLibros()
        {
            InitializeComponent();
            CargarCombos();
            CargarLibros();
        }

        private void CargarCombos()
        {
            cmbAutor.DataSource = autorDAO.ListarAutores();
            cmbAutor.DisplayMember = "NombreAutor";
            cmbAutor.ValueMember = "IdAutor";

            cmbEditorial.DataSource = editorialDAO.ListarEditoriales();
            cmbEditorial.DisplayMember = "NombreEditorial";
            cmbEditorial.ValueMember = "IdEditorial";

            cmbCategoria.DataSource = categoriaDAO.ListarCategorias();
            cmbCategoria.DisplayMember = "NombreCategoria";
            cmbCategoria.ValueMember = "IdCategoria";

            cmbEstado.DataSource = Enum.GetValues(typeof(EstadoDeLibroEnum));
        }

        private void CargarLibros()
        {
            dgvLibros.DataSource = null;
            dgvLibros.DataSource = libroDAO.ListarLibros();
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Libro nuevo = new Libro
            {
                Titulo = txtTitulo.Text,
                AutorId = Convert.ToInt32(cmbAutor.SelectedValue),
                //AutorId = (int)cmbAutor.SelectedValue,
                EditorialId = Convert.ToInt32(cmbEditorial.SelectedValue),
                //EditorialId = (int)cmbEditorial.SelectedValue,
                CategoriaId = Convert.ToInt32(cmbCategoria.SelectedValue),
                //CategoriaId = (int)cmbCategoria.SelectedValue,
                Estado = (EstadoDeLibroEnum)cmbEstado.SelectedItem
            };

            libroDAO.AgregarLibro(nuevo);
            CargarLibros();
            LimpiarCampos();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtIDLibro.Text)) return;

            Libro modificado = new Libro
            {
                IdLibro = int.Parse(txtIDLibro.Text),
                Titulo = txtTitulo.Text,
                AutorId = Convert.ToInt32(cmbAutor.SelectedValue),
                //AutorId = (int)cmbAutor.SelectedValue,
                EditorialId = Convert.ToInt32(cmbEditorial.SelectedValue),
                //EditorialId = (int)cmbEditorial.SelectedValue,
                CategoriaId = Convert.ToInt32(cmbCategoria.SelectedValue),
                //CategoriaId = (int)cmbCategoria.SelectedValue,
                Estado = (EstadoDeLibroEnum)cmbEstado.SelectedItem
            };

            libroDAO.ModificarLibro(modificado);
            CargarLibros();
            LimpiarCampos();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtIDLibro.Text)) return;

            int id = int.Parse(txtIDLibro.Text);
            libroDAO.EliminarLibro(id);
            CargarLibros();
            LimpiarCampos();
        }

        private void dgvLibros_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dgvLibros.Rows[e.RowIndex];
                txtIDLibro.Text = fila.Cells["IdLibro"].Value.ToString();
                txtTitulo.Text = fila.Cells["Titulo"].Value.ToString();
                cmbAutor.SelectedValue = fila.Cells["AutorId"].Value;
                cmbEditorial.SelectedValue = fila.Cells["EditorialId"].Value;
                cmbCategoria.SelectedValue = fila.Cells["CategoriaId"].Value;
                cmbEstado.SelectedItem = (EstadoDeLibroEnum)fila.Cells["Estado"].Value;
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtIDLibro.Text = "";
            txtTitulo.Text = "";
            cmbAutor.SelectedIndex = 0;
            cmbEditorial.SelectedIndex = 0;
            cmbCategoria.SelectedIndex = 0;
            cmbEstado.SelectedIndex = 0;
        }

        private void LimpiarCampos()
        {
            txtIDLibro.Text = "";
            txtTitulo.Text = "";
            cmbAutor.SelectedIndex = 0;
            cmbEditorial.SelectedIndex = 0;
            cmbCategoria.SelectedIndex = 0;
            cmbEstado.SelectedIndex = 0;
        }
    }
}
