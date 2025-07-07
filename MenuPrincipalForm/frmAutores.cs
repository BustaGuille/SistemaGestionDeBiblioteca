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
    public partial class frmAutores : Form
    {
        private AutorDAO autorDAO = new AutorDAO();

        public frmAutores()
        {
            InitializeComponent();
            CargarAutores();
        }

        private void CargarAutores()
        {
            dgvAutores.DataSource = null;
            dgvAutores.DataSource = autorDAO.ListarAutores();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombreAutor.Text) || string.IsNullOrWhiteSpace(txtNacionalidad.Text))
            {
                MessageBox.Show("Debe completar todos los campos antes de agregar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Autor nuevo = new Autor
            {
                NombreAutor = txtNombreAutor.Text,
                Nacionalidad = txtNacionalidad.Text
            };

            autorDAO.AgregarAutor(nuevo);
            CargarAutores();
            LimpiarCampos();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtIdAutor.Text))
            {
                MessageBox.Show("Debe buscar un autor antes de modificar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtNombreAutor.Text) || string.IsNullOrWhiteSpace(txtNacionalidad.Text))
            {
                MessageBox.Show("Debe completar todos los campos antes de modificar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Autor modificado = new Autor
            {
                IdAutor = int.Parse(txtIdAutor.Text),
                NombreAutor = txtNombreAutor.Text,
                Nacionalidad = txtNacionalidad.Text
            };

            autorDAO.ModificarAutor(modificado);
            CargarAutores();
            LimpiarCampos();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtIdAutor.Text))
            {
                MessageBox.Show("Debe buscar un autor antes de eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txtIdAutor.Text, out int idAutor))
            {
                MessageBox.Show("El ID del socio debe ser un número válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Autor autor = autorDAO.ObtenerAutorPorId(idAutor);
            if (autor == null)
            {
                MessageBox.Show("No se encontró un autor con ese ID.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DialogResult confirmacion = MessageBox.Show("¿Está seguro que desea eliminar este autor?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirmacion == DialogResult.Yes)
            {
                int id = int.Parse(txtIdAutor.Text);
                autorDAO.EliminarAutor(id);
                CargarAutores();
                LimpiarCampos();
            }
        }

        private void dgvAutores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var fila = dgvAutores.Rows[e.RowIndex];
                txtIdAutor.Text = fila.Cells["IdAutor"].Value.ToString();
                txtNombreAutor.Text = fila.Cells["NombreAutor"].Value.ToString();
                txtNacionalidad.Text = fila.Cells["Nacionalidad"].Value.ToString();
            }
        }

        private void LimpiarCampos()
        {
            txtIdAutor.Text = "";
            txtNombreAutor.Text = "";
            txtNacionalidad.Text = "";
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }
    }
}
