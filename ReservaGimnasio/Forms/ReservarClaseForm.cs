using System;
using System.Windows.Forms;
using ReservaGimnasio.Models;
using ReservaGimnasio.Services;

namespace ReservaGimnasio.Forms
{
    public partial class ReservarClaseForm : Form
    {
        private Usuario usuarioActual;

        public ReservarClaseForm(Usuario usuario)
        {
            InitializeComponent();
            usuarioActual = usuario;
        }

        private void ReservarClaseForm_Load(object sender, EventArgs e)
        {
            var clases = ClaseService.ObtenerClasesDisponibles();
            dataGridViewClases.DataSource = clases;
        }

        private void btnReservar_Click(object sender, EventArgs e)
        {
            if (dataGridViewClases.SelectedRows.Count > 0)
            {
                int claseId = Convert.ToInt32(dataGridViewClases.SelectedRows[0].Cells["Id"].Value);

                try
                {
                    ReservaService.HacerReserva(usuarioActual.Id, claseId);
                    MessageBox.Show("Reserva realizada con éxito.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al realizar la reserva: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione una clase.");
            }
        }
    }
}
