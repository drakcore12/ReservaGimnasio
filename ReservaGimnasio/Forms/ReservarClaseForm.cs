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

            // Ocultar las columnas de ID
            if (dataGridViewClases.Columns["Id"] != null)
            {
                dataGridViewClases.Columns["Id"].Visible = false;
            }
            if (dataGridViewClases.Columns["InstructorId"] != null)
            {
                dataGridViewClases.Columns["InstructorId"].Visible = false;
            }
            if (dataGridViewClases.Columns["TipoClaseId"] != null)
            {
                dataGridViewClases.Columns["TipoClaseId"].Visible = false;
            }

            // Cambiar los encabezados de las columnas
            if (dataGridViewClases.Columns["NombreInstructor"] != null)
            {
                dataGridViewClases.Columns["NombreInstructor"].HeaderText = "Instructor";
            }
            if (dataGridViewClases.Columns["NombreTipoClase"] != null)
            {
                dataGridViewClases.Columns["NombreTipoClase"].HeaderText = "Clase";
            }
            if (dataGridViewClases.Columns["FechaHora"] != null)
            {
                dataGridViewClases.Columns["FechaHora"].HeaderText = "Fecha";
            }
            if (dataGridViewClases.Columns["Duracion"] != null)
            {
                dataGridViewClases.Columns["Duracion"].HeaderText = "Duración";
            }
            if (dataGridViewClases.Columns["CupoMaximo"] != null)
            {
                dataGridViewClases.Columns["CupoMaximo"].HeaderText = "Cupo Máximo";
            }
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
