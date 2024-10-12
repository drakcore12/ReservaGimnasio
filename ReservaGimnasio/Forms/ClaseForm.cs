using System;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using ReservaGimnasio.Models;
using ReservaGimnasio.Services;
using ReservaGimnasio.Utilities;

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
            this.Load += new EventHandler(ClaseForm_Load);
        }

        public ClaseForm(Clase clase)
        {
            InitializeComponent();
            esEdicion = true;
            claseActual = clase;
            this.Load += new EventHandler(ClaseForm_Load); // Aseguramos que los ComboBox se llenen antes de cargar los datos de la clase.
        }

        private void ClaseForm_Load(object sender, EventArgs e)
        {
            // Cargar instructores
            var instructores = InstructorService.ObtenerInstructores();
            if (instructores != null && instructores.Count > 0)
            {
                cmbInstructor.DataSource = instructores;
                cmbInstructor.DisplayMember = "Nombre";  // Mostrar nombre en el ComboBox
                cmbInstructor.ValueMember = "Id";  // Usar el ID del instructor
            }
            else
            {
                MessageBox.Show("No se encontraron instructores.");
            }

            // Cargar tipos de clase
            var tiposDeClase = ClaseService.ObtenerTiposDeClase();
            if (tiposDeClase != null && tiposDeClase.Count > 0)
            {
                cmbTipoClase.DataSource = tiposDeClase;
                cmbTipoClase.DisplayMember = "Nombre";  // Mostrar nombre en el ComboBox
                cmbTipoClase.ValueMember = "Id";  // Usar el ID del tipo de clase
            }
            else
            {
                MessageBox.Show("No se encontraron tipos de clase.");
            }

            // Si estamos en modo edición, cargar los datos de la clase seleccionada
            if (esEdicion)
            {
                CargarDatosClase();
            }
        }

        // Método para cargar los datos de la clase en los controles
        private void CargarDatosClase()
        {
            // Asegurarse de que los ComboBox ya están llenos antes de seleccionar los valores
            cmbTipoClase.SelectedValue = claseActual.TipoClaseId;
            cmbInstructor.SelectedValue = claseActual.InstructorId;
            dateTimePickerFechaHora.Value = claseActual.FechaHora;
            numCupoMaximo.Value = claseActual.CupoMaximo;
        }

        // Botón Guardar
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Clase clase = new Clase
            {
                TipoClaseId = (int)cmbTipoClase.SelectedValue,  // Guardamos TipoClaseId desde el ComboBox
                InstructorId = (int)cmbInstructor.SelectedValue,
                FechaHora = dateTimePickerFechaHora.Value,
                Duracion = int.Parse(cmbDuracionClase.SelectedItem.ToString()),  // Duración seleccionada
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
