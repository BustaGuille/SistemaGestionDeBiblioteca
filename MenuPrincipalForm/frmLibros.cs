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
        private int? idLibroSeleccionado = null;
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
            if (string.IsNullOrWhiteSpace(txtTitulo.Text) ||
                cmbAutor.SelectedItem == null ||
                cmbEditorial.SelectedItem == null ||
                cmbCategoria.SelectedItem == null ||
                cmbEstado.SelectedItem == null ||
                string.IsNullOrWhiteSpace(txtCantidad.Text))
            {
                MessageBox.Show("Por favor complete todos los campos obligatorios.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                Libro nuevoLibro = new Libro
                {
                    Titulo = txtTitulo.Text.Trim(),
                    AutorId = ((Autor)cmbAutor.SelectedItem).IdAutor,
                    EditorialId = ((Editorial)cmbEditorial.SelectedItem).IdEditorial,
                    CategoriaId = ((Categoria)cmbCategoria.SelectedItem).IdCategoria,
                    Estado = (EstadoDeLibroEnum)cmbEstado.SelectedItem,
                    CantidadDisponible = int.Parse(txtCantidad.Text.Trim())
                };

                libroDAO.AgregarLibro(nuevoLibro);
                MessageBox.Show("Libro agregado correctamente.");
                CargarLibros();
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al agregar el libro: " + ex.Message);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtIdLibro.Text))
            {
                MessageBox.Show("Debe buscar un libro antes de modificar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Valida campos obligatorios
            if (string.IsNullOrWhiteSpace(txtTitulo.Text) ||
                cmbAutor.SelectedItem == null ||
                cmbEditorial.SelectedItem == null ||
                cmbCategoria.SelectedItem == null ||
                cmbEstado.SelectedItem == null ||
                string.IsNullOrWhiteSpace(txtCantidad.Text))
            {
                MessageBox.Show("Debe completar todos los campos obligatorios.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Valida que cantidad sea un numero Valido Tambien
            if (!int.TryParse(txtCantidad.Text.Trim(), out int cantidad) || cantidad < 0)
            {
                MessageBox.Show("Ingrese una cantidad válida (mayor o igual a 0).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Creamos un objeto del libro modificado
            Libro libro = new Libro
            {
                IdLibro = int.Parse(txtIdLibro.Text),
                Titulo = txtTitulo.Text.Trim(),
                AutorId = (int)cmbAutor.SelectedValue,
                EditorialId = (int)cmbEditorial.SelectedValue,
                CategoriaId = (int)cmbCategoria.SelectedValue,
                Estado = (EstadoDeLibroEnum)cmbEstado.SelectedItem,
                CantidadDisponible = cantidad
            };

            try
            {
                libroDAO.ModificarLibro(libro);
                MessageBox.Show("Libro modificado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarLibros();
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al modificar el libro: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (idLibroSeleccionado == null)
            {
                MessageBox.Show("Debe buscar un libro antes de eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult confirmacion = MessageBox.Show("¿Está seguro que desea eliminar este libro?", "Confirmar eliminación", MessageBoxButtons.YesNo);
            if (confirmacion == DialogResult.Yes)
            {
                libroDAO.EliminarLibro(idLibroSeleccionado.Value);
                MessageBox.Show("Libro eliminado.");
                CargarLibros(); // Si tenés un DataGridView
                LimpiarCampos();
            }
        }

        private void dgvLibros_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dgvLibros.Rows[e.RowIndex];
                txtIdLibro.Text = fila.Cells["IdLibro"].Value.ToString();
                txtTitulo.Text = fila.Cells["Titulo"].Value.ToString();
                cmbAutor.SelectedValue = fila.Cells["AutorId"].Value;
                cmbEditorial.SelectedValue = fila.Cells["EditorialId"].Value;
                cmbCategoria.SelectedValue = fila.Cells["CategoriaId"].Value;
                cmbEstado.SelectedItem = (EstadoDeLibroEnum)fila.Cells["Estado"].Value;
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void LimpiarCampos()
        {
            txtIdLibro.Text = "";
            txtTitulo.Text = "";
          

            if (cmbAutor.Items.Count > 0) cmbAutor.SelectedIndex = -1;
            if (cmbEditorial.Items.Count > 0) cmbEditorial.SelectedIndex = -1;
            if (cmbCategoria.Items.Count > 0) cmbCategoria.SelectedIndex = -1;
            if (cmbEstado.Items.Count > 0) cmbEstado.SelectedIndex = -1;

            idLibroSeleccionado = null;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtIdLibro.Text.Trim(), out int idLibro))
            {
                Libro libro = libroDAO.ObtenerLibroPorId(idLibro);
                if (libro != null)
                {
                    idLibroSeleccionado = libro.IdLibro;
                    txtTitulo.Text = libro.Titulo;
                    cmbAutor.SelectedValue = libro.AutorId;
                    cmbEditorial.SelectedValue = libro.EditorialId;
                    cmbCategoria.SelectedValue = libro.CategoriaId;
                    cmbEstado.SelectedIndex = (int)libro.Estado;
                    txtCantidad.Text = libro.CantidadDisponible.ToString();
                }
                else
                {
                    MessageBox.Show("No se encontró un libro con ese ID.");
                    LimpiarCampos();
                }
            }
            else
            {
                MessageBox.Show("Ingrese un ID válido.");
            }
        }
    }
}
