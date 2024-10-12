using System;
using System.Windows.Forms;
using ReservaGimnasio.Models;
using ReservaGimnasio.Services;

namespace ReservaGimnasio.Forms
{
    public partial class MisReservasForm : Form
    {
        private Usuario usuarioActual;

        public MisReservasForm(Usuario usuario)
        {
            InitializeComponent();
            usuarioActual = usuario;
        }

        private void MisReservasForm_Load(object sender, EventArgs e)
        {
            CargarReservas();
        }

        private void CargarReservas()
        {
            var reservas = ReservaService.ObtenerReservasPorUsuario(usuarioActual.Id);
            dataGridViewReservas.DataSource = reservas;

            // Ocultar columnas que no quieres mostrar
            if (dataGridViewReservas.Columns.Contains("Id"))
            {
                dataGridViewReservas.Columns["Id"].Visible = false;
            }
            if (dataGridViewReservas.Columns.Contains("UsuarioId"))
            {
                dataGridViewReservas.Columns["UsuarioId"].Visible = false;
            }
            if (dataGridViewReservas.Columns.Contains("ClaseId"))
            {
                dataGridViewReservas.Columns["ClaseId"].Visible = false;
            }

            // Cambiar los encabezados de las columnas
            if (dataGridViewReservas.Columns.Contains("NombreClase"))
            {
                dataGridViewReservas.Columns["NombreClase"].HeaderText = "Clase";
            }
            if (dataGridViewReservas.Columns.Contains("FechaHora"))
            {
                dataGridViewReservas.Columns["FechaHora"].HeaderText = "Fecha";
            }
            if (dataGridViewReservas.Columns.Contains("FechaReserva"))
            {
                dataGridViewReservas.Columns["FechaReserva"].HeaderText = "Fecha de Reserva";
            }
            if (dataGridViewReservas.Columns.Contains("NombreInstructor"))
            {
                dataGridViewReservas.Columns["NombreInstructor"].HeaderText = "Instructor";
            }
            if (dataGridViewReservas.Columns.Contains("Duracion"))
            {
                dataGridViewReservas.Columns["Duracion"].HeaderText = "Duración";
            }
        }

        private void btnCancelarReserva_Click(object sender, EventArgs e)
        {
            if (dataGridViewReservas.SelectedRows.Count > 0)
            {
                int reservaId = Convert.ToInt32(dataGridViewReservas.SelectedRows[0].Cells["Id"].Value);

                ReservaService.CancelarReserva(reservaId);
                MessageBox.Show("Reserva cancelada con éxito.");
                CargarReservas();
            }
            else
            {
                MessageBox.Show("Por favor, seleccione una reserva.");
            }
        }
    }
}
