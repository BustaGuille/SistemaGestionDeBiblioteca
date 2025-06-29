using BibliotecaApp.UI;

namespace MenuPrincipalForm
{
    public partial class frmMenuPrincipal : Form
    {
        public frmMenuPrincipal()
        {
            InitializeComponent();
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sistema de Biblioteca\nDesarrollado por: Guillermo, Edward, Santiago, Fernando y Derlis\nVersión 1.0", "Acerca de");
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUsuarios frm = new frmUsuarios();
            frm.ShowDialog();
        }

        private void librosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLibros frm = new frmLibros();
            frm.ShowDialog();
        }

        private void sociosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSocios frm = new frmSocios();
            frm.ShowDialog();
        }

        private void autoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAutores frm = new frmAutores();
            frm.ShowDialog();
        }

        private void editorialesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEditoriales frm = new frmEditoriales();
            frm.ShowDialog();
        }

        private void categoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCategorias frm = new frmCategorias();
            frm.ShowDialog();
        }

        private void prestamosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPrestamos frm = new frmPrestamos();
            frm.ShowDialog();
        }

        private void reservasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReservas frm = new frmReservas();
            frm.ShowDialog();
        }

        private void multasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMultas frm = new frmMultas();
            frm.ShowDialog();
        }

        private void historialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHistorial frm = new frmHistorial();
            frm.ShowDialog();
        }

        
        private void versionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Versión del sistema: 1.0.0", "Versión");
        }
    }
}
