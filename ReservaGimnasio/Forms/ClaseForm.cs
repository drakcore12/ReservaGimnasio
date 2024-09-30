using System;
using System.Windows.Forms;
using ReservaGimnasio.Models;
using ReservaGimnasio.Services;

namespace ReservaGimnasio.Forms
{
    public partial class ClaseForm : Form
    {
        private bool esEdicion;
        private Clase claseActual;

        public ClaseForm()
        {
            InitializeComponent();
            esEdicion = false;
        }

        public ClaseForm(Clase clase)
        {
            InitializeComponent();
            esEdicion = true;
            claseActual = clase;
            CargarDatosClase();
        }

        private void ClaseForm_Load(object sender, EventArgs e)
        {
            var instructores = InstructorService.ObtenerInstructores();
            cmbInstructor.DataSource = instructores;
            cmbInstructor.DisplayMember = "Nombre";
            cmbInstructor.ValueMember = "Id";
        }

        private void CargarDatosClase()
        {
            txtNombre.Text = claseActual.Nombre;
            cmbInstructor.SelectedValue = claseActual.InstructorId;
            dateTimePickerFechaHora.Value = claseActual.FechaHora;
            numCupoMaximo.Value = claseActual.CupoMaximo;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Clase clase = new Clase
            {
                Nombre = txtNombre.Text,
                InstructorId = (int)cmbInstructor.SelectedValue,
                FechaHora = dateTimePickerFechaHora.Value,
                CupoMaximo = (int)numCupoMaximo.Value
            };

            if (esEdicion)
            {
                clase.Id = claseActual.Id;
                ClaseService.EditarClase(clase);
                MessageBox.Show("Clase actualizada con éxito.");
            }
            else
            {
                ClaseService.AgregarClase(clase);
                MessageBox.Show("Clase agregada con éxito.");
            }

            this.Close();
        }
    }
}
