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
using System.IO;
using System.Diagnostics;

namespace BibliotecaApp.UI
{
    public partial class frmHistorial : Form
    {
        private HistorialDAO histoprestDAO = new HistorialDAO();
        public frmHistorial()
        {
            InitializeComponent();
            CargarHistorial();
            CargarFiltros();
        }

        private void CargarHistorial()
        {
            dgvHistorial.DataSource = null;
            dgvHistorial.DataSource = histoprestDAO.ListarHistorial(); // reutilizamos el método del DAO
        }

        private void CargarFiltros()
        {
            var socios = new SocioDAO().ListarSocios();
            cmbSocioFiltro.DataSource = socios;
            cmbSocioFiltro.DisplayMember = "NombreSocio";
            cmbSocioFiltro.ValueMember = "IdSocio";
            cmbSocioFiltro.SelectedIndex = -1;

            var libros = new LibroDAO().ListarLibros();
            cmbLibroFiltro.DataSource = libros;
            cmbLibroFiltro.DisplayMember = "Titulo";
            cmbLibroFiltro.ValueMember = "IdLibro";
            cmbLibroFiltro.SelectedIndex = -1;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                // Validación de fechas
                DateTime desde = dtpDesde.Value.Date;
                DateTime hasta = dtpHasta.Value.Date;
                if (desde > hasta)
                {
                    MessageBox.Show("La fecha 'Desde' no puede ser posterior a la fecha 'Hasta'.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Obtener todos los registros
                var historial = histoprestDAO.ListarHistorial();

                // Validación y filtrado por Socio
                if (cmbSocioFiltro.SelectedIndex != -1 && cmbSocioFiltro.SelectedValue != null)
                {
                    if (int.TryParse(cmbSocioFiltro.SelectedValue.ToString(), out int idSocio))
                    {
                        historial = historial.Where(h => h.IdSocio == idSocio).ToList();
                    }
                    else
                    {
                        MessageBox.Show("El valor del socio no es válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }

                // Validación y filtrado por Libro
                if (cmbLibroFiltro.SelectedIndex != -1 && cmbLibroFiltro.SelectedValue != null)
                {
                    if (int.TryParse(cmbLibroFiltro.SelectedValue.ToString(), out int idLibro))
                    {
                        historial = historial.Where(h => h.IdLibro == idLibro).ToList();
                    }
                    else
                    {
                        MessageBox.Show("El valor del libro no es válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }

                // Filtrado por fecha de préstamo
                historial = historial.Where(h => h.FechaPrestamo.Date >= desde && h.FechaPrestamo.Date <= hasta).ToList();

                // Mostrar resultado
                if (historial.Count == 0)
                {
                    MessageBox.Show("No se encontraron registros con los filtros aplicados.", "Sin resultados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                dgvHistorial.DataSource = null;
                dgvHistorial.DataSource = historial;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al buscar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDescargar_Click(object sender, EventArgs e)
        {
            if (cmbSocioFiltro.SelectedValue == null || !int.TryParse(cmbSocioFiltro.SelectedValue.ToString(), out int idSocio))
            {
                MessageBox.Show("Debe seleccionar un socio válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Filtrar historial por socio
                var historial = histoprestDAO.ListarHistorial()
                                  .Where(h => h.IdSocio == idSocio)
                                  .ToList();

                if (historial.Count == 0)
                {
                    MessageBox.Show("No hay historial para el socio seleccionado.", "Sin datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // Ruta a la carpeta Descargas del usuario
                string rutaDescargas = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "Downloads");
                string archivo = Path.Combine(rutaDescargas, $"Historial_Socio_{idSocio}.txt");

                // Crear archivo y escribir contenido
                using (StreamWriter writer = new StreamWriter(archivo))
                {
                    writer.WriteLine($"Historial de Préstamos del Socio ID {idSocio}");
                    writer.WriteLine("-------------------------------------------------");

                    foreach (var item in historial)
                    {
                        writer.WriteLine($"ID Préstamo: {item.IdPrestamo}");
                        writer.WriteLine($"ID Libro: {item.IdLibro}");
                        writer.WriteLine($"ID Socio: {item.IdSocio}");
                        writer.WriteLine($"Fecha Préstamo: {item.FechaPrestamo:dd/MM/yyyy}");
                        writer.WriteLine($"Fecha Devolución: {(item.FechaDevolucion.HasValue ? item.FechaDevolucion.Value.ToString("dd/MM/yyyy") : "Pendiente")}");
                        writer.WriteLine($"Devuelto: {(item.Devuelto ? "Sí" : "No")}");
                        writer.WriteLine("-------------------------------------------------");
                    }
                }

                // Mostrar mensaje y abrir el archivo automáticamente
                MessageBox.Show("Archivo generado correctamente en la carpeta Descargas.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Process.Start("explorer.exe", archivo); // Abrir automáticamente el archivo generado
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al generar archivo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
