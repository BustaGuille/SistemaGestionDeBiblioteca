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
            var historial = histoprestDAO.ListarHistorial();

            var socios = new SocioDAO().ListarSocios();
            var libros = new LibroDAO().ListarLibros();

            var datos = historial.Select(h => new
            {
                h.IdHistorial,
                h.IdPrestamo,
                Libro = libros.FirstOrDefault(l => l.IdLibro == h.IdLibro)?.Titulo ?? "Desconocido",
                Socio = socios.FirstOrDefault(s => s.IdSocio == h.IdSocio)?.NombreSocio ?? "Desconocido",
                FechaPrestamo = h.FechaPrestamo.ToString("dd/MM/yyyy"),
                FechaDevolucion = h.FechaDevolucion?.ToString("dd/MM/yyyy") ?? "Pendiente",
                Devuelto = h.Devuelto ? "Sí" : "No"
            }).ToList();

            dgvHistorial.DataSource = null;
            dgvHistorial.DataSource = datos;
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

                // Reemplazar IDs por nombres
                var socios = new SocioDAO().ListarSocios();
                var libros = new LibroDAO().ListarLibros();

                var datos = historial.Select(h => new
                {
                    h.IdHistorial,
                    h.IdPrestamo,
                    Libro = libros.FirstOrDefault(l => l.IdLibro == h.IdLibro)?.Titulo ?? "Desconocido",
                    Socio = socios.FirstOrDefault(s => s.IdSocio == h.IdSocio)?.NombreSocio ?? "Desconocido",
                    FechaPrestamo = h.FechaPrestamo.ToString("dd/MM/yyyy"),
                    FechaDevolucion = h.FechaDevolucion?.ToString("dd/MM/yyyy") ?? "Pendiente",
                    Devuelto = h.Devuelto ? "Sí" : "No"
                }).ToList();

                dgvHistorial.DataSource = null;
                dgvHistorial.DataSource = datos;
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

            Socio socioSeleccionado = new SocioDAO().ObtenerSocioPorId(idSocio);
            if (socioSeleccionado == null)
            {
                MessageBox.Show("No se encontró el socio especificado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Obtener historial de préstamos
                var historial = histoprestDAO.ListarHistorial().Where(h => h.IdSocio == idSocio).ToList();
                var multas = new MultaDAO().ListarMultas().Where(m => m.IdSocio == idSocio).ToList();
                var reservas = new ReservaDAO().ListarReservas().Where(r => r.IdSocio == idSocio).ToList();

                if (historial.Count == 0 && multas.Count == 0 && reservas.Count == 0)
                {
                    MessageBox.Show("El socio no tiene registros de préstamos, multas ni reservas.", "Sin datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // Crear contenido del archivo
                StringBuilder contenido = new StringBuilder();
                contenido.AppendLine($"Historial del Socio: {socioSeleccionado.NombreSocio} (ID: {socioSeleccionado.IdSocio})");
                contenido.AppendLine(new string('-', 60));

                contenido.AppendLine($"Total de Multas: {multas.Count}");
                foreach (var m in multas)
                {
                    contenido.AppendLine($"Motivo: {m.Motivo}");
                    contenido.AppendLine($"Monto: ₲{m.Monto:N0}");
                    contenido.AppendLine("");
                }

                contenido.AppendLine(new string('-', 60));
                contenido.AppendLine($"Total de Reservas: {reservas.Count}");
                foreach (var r in reservas)
                {
                    var libro = new LibroDAO().ObtenerLibroPorId(r.IdLibro);
                    contenido.AppendLine($"Libro reservado: {libro?.Titulo ?? "Desconocido"} - Fecha: {r.FechaReserva:dd/MM/yyyy}");
                }

                contenido.AppendLine(new string('-', 60));
                contenido.AppendLine($"Total de Préstamos: {historial.Count}");
                foreach (var item in historial)
                {
                    var libro = new LibroDAO().ObtenerLibroPorId(item.IdLibro);
                    contenido.AppendLine($"Libro: {libro?.Titulo ?? "Desconocido"}");
                    contenido.AppendLine($"Fecha Préstamo: {item.FechaPrestamo:dd/MM/yyyy}");
                    contenido.AppendLine($"Fecha Devolución: {(item.FechaDevolucion.HasValue ? item.FechaDevolucion.Value.ToString("dd/MM/yyyy") : "Pendiente")}");
                    contenido.AppendLine($"Devuelto: {(item.Devuelto ? "Sí" : "No")}");
                    contenido.AppendLine("");
                }
                
                // Ruta del archivo
                string rutaDescargas = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "Downloads");
                string nombreSocioLimpio = string.Join("_", socioSeleccionado.NombreSocio.Split(Path.GetInvalidFileNameChars()));
                string archivo = Path.Combine(rutaDescargas, $"Historial_Socio_{nombreSocioLimpio}.txt");


                // Guardar archivo
                File.WriteAllText(archivo, contenido.ToString(), Encoding.UTF8);
                MessageBox.Show("Archivo generado correctamente en la carpeta Descargas.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Abrir el archivo automáticamente
                Process.Start("explorer.exe", archivo);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al generar archivo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
