﻿using BibliotecaSystem.DAO;
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
    public partial class frmPrestamos : Form
    {
        private LibroDAO libroDAO = new LibroDAO();

        private PrestamoDAO prestamoDAO = new PrestamoDAO();

        private SocioDAO socioDAO = new SocioDAO();

        private UsuarioDAO usuarioDAO = new UsuarioDAO();

        public frmPrestamos()
        {
            InitializeComponent();
            CargarPrestamos();
            CargarSocios();
            CargarUsuarios();
            CargarLibros();
        }

        private void CargarPrestamos()
        {
            dgvPrestamos.DataSource = null;
            dgvPrestamos.DataSource = prestamoDAO.ObtenerTodosLosPrestamos();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (cmbLibro.SelectedIndex == -1 || cmbUsuario.SelectedIndex == -1 || cmbSocio.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un libro, un usuario y un socio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int idLibroSeleccionado = Convert.ToInt32(cmbLibro.SelectedValue);
            Libro libro = libroDAO.ObtenerLibroPorId(idLibroSeleccionado);

            if (libro == null)
            {
                MessageBox.Show("El libro seleccionado no existe.");
                return;
            }

            if (libro.Cantidad <= 0)
            {
                MessageBox.Show("No hay unidades disponibles del libro seleccionado.", "Sin stock", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Prestamo prestamo = new Prestamo
            {
                LibroId = idLibroSeleccionado,
                UsuarioId = Convert.ToInt32(cmbUsuario.SelectedValue),
                SocioId = Convert.ToInt32(cmbSocio.SelectedValue),
                FechaPrestamo = dtpFechaPrestamo.Value,
                FechaDevolucion = dtpFechaDevolucion.Checked ? dtpFechaDevolucion.Value : (DateTime?)null,
                Devuelto = chkDevuelto.Checked
            };

            prestamoDAO.RegistrarPrestamo(prestamo);
            CargarPrestamos();
            LimpiarCampos();
        }

        private void btnMarcarDevuelto_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtIdPrestamo.Text))
            {
                MessageBox.Show("Debe ingresar un ID de préstamo para marcarlo como devuelto.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int id = int.Parse(txtIdPrestamo.Text);
            Prestamo prestamo = prestamoDAO.ObtenerPrestamoPorId(id);
            if (prestamo == null)
            {
                MessageBox.Show("No se encontró el préstamo especificado.");
                return;
            }

            prestamoDAO.MarcarComoDevuelto(id);
            libroDAO.AumentarCantidadDisponible(prestamo.LibroId);

            CargarPrestamos();
            LimpiarCampos();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtIdPrestamo.Text))
            {
                MessageBox.Show("Debe ingresar un ID de préstamo para eliminarlo.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult confirm = MessageBox.Show("¿Está seguro que desea eliminar este préstamo?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.Yes)
            {
                int id = int.Parse(txtIdPrestamo.Text);
                prestamoDAO.EliminarPrestamo(id);
                CargarPrestamos();
                LimpiarCampos();
            }
        }

        private void dgvPrestamos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var fila = dgvPrestamos.Rows[e.RowIndex];
                txtIdPrestamo.Text = fila.Cells["IdPrestamo"].Value.ToString();
                cmbLibro.SelectedValue = fila.Cells["NombreLibro"].Value;
                //cmbLibro.Text = fila.Cells["LibroId"].Value.ToString();
                cmbUsuario.SelectedValue = fila.Cells["NombreUsuario"].Value;
                //cmbUsuario.Text = fila.Cells["UsuarioId"].Value.ToString();
                cmbSocio.SelectedValue = fila.Cells["NombreSocio"].Value;
                //cmbSocio.Text = fila.Cells["SocioId"].Value.ToString();
                dtpFechaPrestamo.Value = Convert.ToDateTime(fila.Cells["FechaPrestamo"].Value);

                if (fila.Cells["FechaDevolucion"].Value != DBNull.Value)
                {
                    dtpFechaDevolucion.Value = Convert.ToDateTime(fila.Cells["FechaDevolucion"].Value);
                    dtpFechaDevolucion.Checked = true;
                }
                else
                {
                    dtpFechaDevolucion.Checked = false;
                }

                chkDevuelto.Checked = Convert.ToBoolean(fila.Cells["Devuelto"].Value);
            }
        }

        private void LimpiarCampos()
        {
            txtIdPrestamo.Text = "";
            cmbLibro.Text = "";
            cmbUsuario.Text = "";
            cmbSocio.Text = "";
            dtpFechaPrestamo.Value = DateTime.Now;
            dtpFechaDevolucion.Value = DateTime.Now;
            dtpFechaDevolucion.Checked = false;
            chkDevuelto.Checked = false;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtIdPrestamo.Text))
            {
                MessageBox.Show("Debe ingresar el ID del préstamo a modificar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            if (cmbLibro.SelectedItem == null || cmbSocio.SelectedItem == null || cmbUsuario.SelectedItem == null)
            {
                MessageBox.Show("Debe seleccionar un libro, un socio y un usuario.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                Prestamo prestamo = new Prestamo
                {
                    IdPrestamo = int.Parse(txtIdPrestamo.Text),
                    LibroId = (int)cmbLibro.SelectedValue,
                    SocioId = (int)cmbSocio.SelectedValue,
                    UsuarioId = (int)cmbUsuario.SelectedValue,
                    FechaPrestamo = dtpFechaPrestamo.Value,
                    FechaDevolucion = dtpFechaDevolucion.Checked ? dtpFechaDevolucion.Value : (DateTime?)null,
                    Devuelto = chkDevuelto.Checked
                };

                prestamoDAO.ModificarPrestamo(prestamo);

                MessageBox.Show("Préstamo modificado correctamente.");
                CargarPrestamos();
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar el préstamo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            {
                if (string.IsNullOrWhiteSpace(txtIdPrestamo.Text))
                {
                    MessageBox.Show("Debe ingresar el ID del préstamo a buscar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!int.TryParse(txtIdPrestamo.Text, out int idPrestamo))
                {
                    MessageBox.Show("El ID del préstamo debe ser un número válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                Prestamo prestamo = prestamoDAO.ObtenerPrestamoPorId(idPrestamo);

                if (prestamo == null)
                {
                    MessageBox.Show("No se encontró ningún préstamo con ese ID.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // Si encontró, llena los campos del formulario
                cmbLibro.SelectedValue = prestamo.LibroId;
                cmbUsuario.SelectedValue = prestamo.UsuarioId;
                cmbSocio.SelectedValue = prestamo.SocioId;
                dtpFechaPrestamo.Value = prestamo.FechaPrestamo;

                if (prestamo.FechaDevolucion.HasValue)
                {
                    dtpFechaDevolucion.Value = prestamo.FechaDevolucion.Value;
                    dtpFechaDevolucion.Checked = true;
                }
                else
                {
                    dtpFechaDevolucion.Checked = false;
                }

                chkDevuelto.Checked = prestamo.Devuelto;
            }
        }
        private void CargarSocios()
        {
            var listaSocios = socioDAO.ListarSocios();

            cmbSocio.DataSource = listaSocios;
            cmbSocio.DisplayMember = "NombreSocio";
            cmbSocio.ValueMember = "IdSocio";
            cmbSocio.SelectedIndex = -1;
        }

        private void CargarLibros()
        {
            var listaLibros = libroDAO.ListarLibrosDisponibles();

            cmbLibro.DataSource = listaLibros;
            cmbLibro.DisplayMember = "Titulo";     
            cmbLibro.ValueMember = "IdLibro";        
            cmbLibro.SelectedIndex = -1;             
        }

        private void CargarUsuarios()
        {
            var usuarios = usuarioDAO.ListarUsuarios();
            cmbUsuario.DataSource = usuarios;
            cmbUsuario.DisplayMember = "NombreUsuario";
            cmbUsuario.ValueMember = "IdUser";
            cmbUsuario.SelectedIndex = -1;
        }

    }
}

