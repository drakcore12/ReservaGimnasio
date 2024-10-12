using System;
using System.Windows.Forms;
using ReservaGimnasio.Services;

namespace ReservaGimnasio.Forms
{
    public partial class EstadisticasForm : Form
    {
        public EstadisticasForm()
        {
            InitializeComponent();
            CargarEstadisticas();
        }

        private void CargarEstadisticas()
        {
            // Total de reservas
            lblTotalReservas.Text = "Total de reservas: " + EstadisticasService.ObtenerTotalReservas().ToString();

            // Reservas por clase
            var reservasPorClase = EstadisticasService.ObtenerReservasPorClase();
            foreach (var clase in reservasPorClase)
            {
                lstReservasPorClase.Items.Add($"{clase.Key}: {clase.Value} reservas");
            }

            // Top 5 clases más reservadas
            var topClases = EstadisticasService.ObtenerTop5Clases();
            foreach (var clase in topClases)
            {
                lstTop5Clases.Items.Add($"{clase.Item1}: {clase.Item2} reservas");
            }

            // Reservas por instructor
            var reservasPorInstructor = EstadisticasService.ObtenerReservasPorInstructor();
            foreach (var instructor in reservasPorInstructor)
            {
                lstReservasPorInstructor.Items.Add($"{instructor.Key}: {instructor.Value} reservas");
            }
        }
        // Este método se ejecuta cuando el botón "Cerrar" es presionado
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();  // Cierra el formulario
        }
    }
}
