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
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Socio nuevo = new Socio
            {
                NombreSocio = txtNombreSocio.Text,
                CedulaSocio = txtCedula.Text,
                Direccion = txtDireccion.Text,
                TelefonoSocio = txtTelefono.Text,
                Email = txtEmail.Text
            };

            socioDAO.AgregarSocio(nuevo);
            CargarSocios();
            LimpiarCampos();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtIdSocio.Text)) return;

            Socio modificado = new Socio
            {
                IdSocio = int.Parse(txtIdSocio.Text),
                NombreSocio = txtNombreSocio.Text,
                CedulaSocio = txtCedula.Text,
                Direccion = txtDireccion.Text,
                TelefonoSocio = txtTelefono.Text,
                Email = txtEmail.Text
            };

            socioDAO.ModificarSocio(modificado);
            CargarSocios();
            LimpiarCampos();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtIdSocio.Text)) return;

            int id = int.Parse(txtIdSocio.Text);
            socioDAO.EliminarSocio(id);
            CargarSocios();
            LimpiarCampos();
        }

        private void dgvSocios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var fila = dgvSocios.Rows[e.RowIndex];
                txtIdSocio.Text = fila.Cells["IdSocio"].Value.ToString();
                txtNombreSocio.Text = fila.Cells["NombreSocio"].Value.ToString();
                txtCedula.Text = fila.Cells["CedulaSocio"].Value.ToString();
                txtDireccion.Text = fila.Cells["Direccion"].Value.ToString();
                txtTelefono.Text = fila.Cells["TelefonoSocio"].Value.ToString();
                txtEmail.Text = fila.Cells["Email"].Value.ToString();
            }
        }

        private void LimpiarCampos()
        {
            txtIdSocio.Text = "";
            txtNombreSocio.Text = "";
            txtCedula.Text = "";
            txtDireccion.Text = "";
            txtTelefono.Text = "";
            txtEmail.Text = "";
        }
    }
}
