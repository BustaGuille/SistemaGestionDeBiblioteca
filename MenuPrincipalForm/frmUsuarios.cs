using BibliotecaSystem.DAO;
using BibliotecaSystem.Entidades;
using BibliotecaSystem.Utilidades;
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

            if (dgvUsuarios.Columns["ContraseñaHash"] != null)
            {
                dgvUsuarios.Columns["ContraseñaHash"].Visible = false; // Ocultamos la columna de contraseña hash si es que existe
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //Capturamos los datos que ingreso el usuario
            string nombreUsuario = txtNombreUsuario.Text.Trim();
            string contrasena = txtContrasena.Text;


            //Aqui validamos que los campos no esten vacios
            if (string.IsNullOrWhiteSpace(nombreUsuario) || string.IsNullOrWhiteSpace(contrasena))
            {
                MessageBox.Show("Debe completar todos los campos obligatorios.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //Validamos que el nombre de usuario no exista en la base de datos
            usuarioDAO = new UsuarioDAO();
            if (usuarioDAO.ExisteUsuario(nombreUsuario))
            {
                MessageBox.Show("El nombre de usuario ya existe. Por favor, elija otro.", "Usuario duplicado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            Usuario nuevo = new Usuario
            {
                NombreUsuario = nombreUsuario,
                ContraseñaHash = LogicaSeguridad.HashPassword(contrasena)
            };

            usuarioDAO.AgregarUsuario(nuevo);
            CargarUsuarios();
            LimpiarCampos();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBuscarId.Text))
            {
                MessageBox.Show("Debes buscar un usuario antes de modificarlo.");
                return;
            }

            Usuario usuario = new Usuario
            {
                IdUser = int.Parse(txtBuscarId.Text), // Este debe venir del textbox de ID cargado tras la búsqueda
                NombreUsuario = txtNombreUsuario.Text,
                ContraseñaHash = LogicaSeguridad.HashPassword(txtContrasena.Text)
            };

            usuarioDAO.ModificarUsuario(usuario);
            MessageBox.Show("Usuario modificado con éxito.");
            CargarUsuarios(); // Este es para volver a cargar la grilla 
            LimpiarCampos();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (idUsuarioSeleccionado == null)
            {
                MessageBox.Show("Debe buscar un usuario antes de eliminar.");
                return;
            }

            DialogResult confirmacion = MessageBox.Show("¿Está seguro que desea eliminar este usuario?", "Confirmar eliminación", MessageBoxButtons.YesNo);
            if (confirmacion == DialogResult.Yes)
            {
                usuarioDAO.EliminarUsuario(idUsuarioSeleccionado.Value);
                MessageBox.Show("Usuario eliminado.");
                CargarUsuarios();
                LimpiarCampos();
            }
        }

        private void dgvUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var fila = dgvUsuarios.Rows[e.RowIndex];

                idUsuarioSeleccionado = Convert.ToInt32(fila.Cells["IdUser"].Value); // Aquí se guarda el ID
                txtNombreUsuario.Text = fila.Cells["NombreUsuario"].Value.ToString();
                txtContrasena.Text = ""; //para que no se muestre la contraseña en texto plano
            }
        }

        private void LimpiarCampos()
        {
            txtNombreUsuario.Text = "";
            txtContrasena.Text = "";
            idUsuarioSeleccionado = null;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtBuscarId.Text.Trim(), out int idUsuario))
            {
                Usuario usuario = usuarioDAO.ObtenerUsuarioPorId(idUsuario);
                if (usuario != null)
                {
                    txtNombreUsuario.Text = usuario.NombreUsuario;
                    txtContrasena.Text = "";

                    idUsuarioSeleccionado = usuario.IdUser;
                }
                else
                {
                    MessageBox.Show("No se encontró ningún usuario con ese ID.", "Búsqueda", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarCampos();
                }
            }
            else
            {
                MessageBox.Show("Ingrese un ID válido (número entero).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
