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
    public partial class frmUsuarios : Form
    {

        private int? idUsuarioSeleccionado = null;
        private UsuarioDAO usuarioDAO = new UsuarioDAO();

        public frmUsuarios()
        {
            InitializeComponent();
            CargarUsuarios();
        }

        private void CargarUsuarios()
        {
            dgvUsuarios.DataSource = null;
            dgvUsuarios.DataSource = usuarioDAO.ListarUsuarios();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombreUsuario.Text) || string.IsNullOrWhiteSpace(txtContrasena.Text))
            {
                MessageBox.Show("Complete los campos obligatorios.");
                return;
            }

            Usuario nuevo = new Usuario
            {
                NombreUsuario = txtNombreUsuario.Text,
                ContraseñaHash = BibliotecaSystem.Utilidades.LogicaSeguridad.HashPassword(txtContrasena.Text)
            };

            usuarioDAO.AgregarUsuario(nuevo);
            CargarUsuarios();
            LimpiarCampos();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (idUsuarioSeleccionado == null) return;

            Usuario modificado = new Usuario
            {
                IdUser = idUsuarioSeleccionado.Value,
                NombreUsuario = txtNombreUsuario.Text,
                ContraseñaHash = BibliotecaSystem.Utilidades.LogicaSeguridad.HashPassword(txtContrasena.Text)
            };

            usuarioDAO.ModificarUsuario(modificado);
            CargarUsuarios();
            LimpiarCampos();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (idUsuarioSeleccionado == null) return;

            usuarioDAO.EliminarUsuario(idUsuarioSeleccionado.Value);
            CargarUsuarios();
            LimpiarCampos();
        }

        private void dgvUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var fila = dgvUsuarios.Rows[e.RowIndex];

                idUsuarioSeleccionado = Convert.ToInt32(fila.Cells["IdUser"].Value); // Aquí se guarda el ID
                txtNombreUsuario.Text = fila.Cells["NombreUsuario"].Value.ToString();
                txtContrasena.Text = ""; // O podés dejar vacío para no mostrar hash
            }
        }

        private void LimpiarCampos()
        {
            txtNombreUsuario.Text = "";
            txtContrasena.Text = "";
            idUsuarioSeleccionado = null;
        }
    }
}
