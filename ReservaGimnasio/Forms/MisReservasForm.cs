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
