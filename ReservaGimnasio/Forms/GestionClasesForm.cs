using System;
using System.Windows.Forms;
using ReservaGimnasio.Models;
using ReservaGimnasio.Services;

namespace ReservaGimnasio.Forms
{
    public partial class GestionClasesForm : Form
    {
        public GestionClasesForm()
        {
            InitializeComponent();
        }

        private void GestionClasesForm_Load(object sender, EventArgs e)
        {
            CargarClases();
            ConfigurarColumnasDataGridView();
        }

        private void CargarClases()
        {
            var clases = ClaseService.ObtenerClasesDisponibles();
            dataGridViewClases.DataSource = clases;
        }

        private void ConfigurarColumnasDataGridView()
        {
            dataGridViewClases.AutoGenerateColumns = false;  // No autogenerar columnas
            dataGridViewClases.Columns.Clear();  // Limpiar cualquier columna previa

            // Definir las columnas a mano
            dataGridViewClases.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Id",
                HeaderText = "Id",
                Name = "Id"
            });
            dataGridViewClases.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "NombreTipoClase",  // Mostrar el nombre del tipo de clase
                HeaderText = "Tipo de Clase"
            });
            dataGridViewClases.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "NombreInstructor",  // Mostrar el nombre del instructor
                HeaderText = "Instructor"
            });
            dataGridViewClases.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "FechaHora",
                HeaderText = "Fecha y Hora"
            });
            dataGridViewClases.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Duracion",
                HeaderText = "Duración"
            });
            dataGridViewClases.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "CupoMaximo",
                HeaderText = "Cupo Máximo"
            });
        }


        private void btnAgregarClase_Click(object sender, EventArgs e)
        {
            ClaseForm agregarClaseForm = new ClaseForm();
            agregarClaseForm.ShowDialog();
            CargarClases(); // Refrescar la tabla después de agregar
        }

        private void btnEditarClase_Click(object sender, EventArgs e)
        {
            if (dataGridViewClases.SelectedRows.Count > 0)
            {
                int claseId = Convert.ToInt32(dataGridViewClases.SelectedRows[0].Cells["Id"].Value);
                Clase claseSeleccionada = ClaseService.ObtenerClasePorId(claseId);
                ClaseForm editarClaseForm = new ClaseForm(claseSeleccionada);
                editarClaseForm.ShowDialog();
                CargarClases(); // Refrescar la tabla después de editar
            }
            else
            {
                MessageBox.Show("Por favor, seleccione una clase.");
            }
        }

        private void btnEliminarClase_Click(object sender, EventArgs e)
        {
            if (dataGridViewClases.SelectedRows.Count > 0)
            {
                int claseId = Convert.ToInt32(dataGridViewClases.SelectedRows[0].Cells["Id"].Value);
                ClaseService.EliminarClase(claseId);
                MessageBox.Show("Clase eliminada con éxito.");
                CargarClases(); // Refrescar la tabla después de eliminar
            }
            else
            {
                MessageBox.Show("Por favor, seleccione una clase.");
            }
        }
    }
}
