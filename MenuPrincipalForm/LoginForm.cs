using BibliotecaSystem.DAO;
using BibliotecaSystem.Entidades;
using MenuPrincipalForm;


namespace BibliotecaApp.UI
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
                string usuario = txtUsuario.Text.Trim();
                string contrasena = txtContrasena.Text.Trim();

            UsuarioDAO userDao = new UsuarioDAO();
            Usuario user = userDao.ObtenerUsuarioPorNombre(usuario);

            if (user != null && user.VerificarPassword(contrasena))
            {
                lblMensaje.Text = string.Empty;
                MessageBox.Show("Inicio de sesión exitoso.", "Bienvenido", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Hide(); //Con esto ocultamos el formulario
                frmMenuPrincipal menuPrincipal = new frmMenuPrincipal();
                menuPrincipal.FormClosed += (s, args) => this.Close(); // Esto asegura que al cerrar el menú principal, también se cierra la aplicación
                menuPrincipal.Show();
            }
            else
            {
                // Si el usuario no existe o la contraseña es incorrecta, mostrar un mensaje de error
                lblMensaje.Text = "Usuario o contraseña incorrectos. Inténtalo de nuevo.";
                lblMensaje.ForeColor = Color.Red;
                lblMensaje.Visible = true;
            }
        }
    }
}
