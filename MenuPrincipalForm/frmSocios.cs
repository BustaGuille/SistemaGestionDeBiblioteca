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
    public partial class frmSocios : Form
    {
        private SocioDAO socioDAO = new SocioDAO();

        public frmSocios()
        {
            InitializeComponent();
            CargarSocios();
        }

        private void CargarSocios()
        {
            dgvSocios.DataSource = null;
            dgvSocios.DataSource = socioDAO.ListarSocios();

            dgvSocios.Columns["IdSocio"].HeaderText = "ID";
            dgvSocios.Columns["NombreSocio"].HeaderText = "Nombre";
            dgvSocios.Columns["CedulaSocio"].HeaderText = "Cédula";
            dgvSocios.Columns["Direccion"].HeaderText = "Dirección";
            dgvSocios.Columns["TelefonoSocio"].HeaderText = "Teléfono";
            dgvSocios.Columns["Email"].HeaderText = "Email";
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombreSocio.Text) ||
                string.IsNullOrWhiteSpace(txtCedula.Text) ||
                string.IsNullOrWhiteSpace(txtDireccion.Text) ||
                string.IsNullOrWhiteSpace(txtTelefono.Text) ||
                string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show("Debe completar todos los campos antes de agregar.", "Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Socio nuevo = new Socio
            {
                NombreSocio = txtNombreSocio.Text,
                CedulaSocio = txtCedula.Text,
                Direccion = txtDireccion.Text,
                TelefonoSocio = txtTelefono.Text,
                Email = txtEmail.Text
            };

            socioDAO.AgregarSocio(nuevo);
            MessageBox.Show("Socio agregado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            CargarSocios();
            LimpiarCampos();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

            if (!int.TryParse(txtIDSocio.Text.Trim(), out int idSocio))
            {
                MessageBox.Show("Ingrese un ID válido para modificar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtNombreSocio.Text) ||
                string.IsNullOrWhiteSpace(txtCedula.Text) ||
                string.IsNullOrWhiteSpace(txtDireccion.Text) ||
                string.IsNullOrWhiteSpace(txtTelefono.Text) ||
                string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show("Debe completar todos los campos antes de modificar.", "Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Socio modificado = new Socio
            {
                IdSocio = int.Parse(txtIDSocio.Text),
                NombreSocio = txtNombreSocio.Text,
                CedulaSocio = txtCedula.Text,
                Direccion = txtDireccion.Text,
                TelefonoSocio = txtTelefono.Text,
                Email = txtEmail.Text
            };

            socioDAO.ModificarSocio(modificado);
            MessageBox.Show("Socio modificado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            CargarSocios();
            LimpiarCampos();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

            if (!int.TryParse(txtIDSocio.Text, out int idSocio))
            {
                MessageBox.Show("El ID del socio debe ser un número válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Socio socio = socioDAO.ObtenerSocioPorId(idSocio);
            if (socio == null)
            {
                MessageBox.Show("No se encontró un socio con ese ID.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtIDSocio.Text))
            {
                MessageBox.Show("Por favor, ingrese un ID de socio para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DialogResult confirmacion = MessageBox.Show("¿Está seguro que desea eliminar este socio?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmacion == DialogResult.Yes)
            {
                int id = int.Parse(txtIDSocio.Text);
                socioDAO.EliminarSocio(idSocio);
                MessageBox.Show("Socio eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarSocios();
                LimpiarCampos();
            }
        }

        private void dgvSocios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var fila = dgvSocios.Rows[e.RowIndex];
                txtIDSocio.Text = fila.Cells["IdSocio"].Value.ToString();
                txtNombreSocio.Text = fila.Cells["NombreSocio"].Value.ToString();
                txtCedula.Text = fila.Cells["CedulaSocio"].Value.ToString();
                txtDireccion.Text = fila.Cells["Direccion"].Value.ToString();
                txtTelefono.Text = fila.Cells["TelefonoSocio"].Value.ToString();
                txtEmail.Text = fila.Cells["Email"].Value.ToString();
            }
        }

        private void LimpiarCampos()
        {
            txtIDSocio.Text = "";
            txtNombreSocio.Text = "";
            txtCedula.Text = "";
            txtDireccion.Text = "";
            txtTelefono.Text = "";
            txtEmail.Text = "";

            // dgvSocios.ClearSelection(); 
            // idSocioSeleccionado = null; 
        }


        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void btnBuscarID_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtIDSocio.Text.Trim(), out int idSocio))
            {
                Socio socio = socioDAO.ObtenerSocioPorId(idSocio);
                if (socio != null)
                {
                    txtNombreSocio.Text = socio.NombreSocio;
                    txtCedula.Text = socio.CedulaSocio;
                    txtDireccion.Text = socio.Direccion;
                    txtTelefono.Text = socio.TelefonoSocio;
                    txtEmail.Text = socio.Email;
                }
                else
                {
                    MessageBox.Show("No se encontró ningún socio con ese ID.", "Búsqueda", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarCampos();
                }
            }
            else
            {
                MessageBox.Show("Ingrese un ID válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
