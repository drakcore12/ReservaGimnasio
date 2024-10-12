using System;
using System.Windows.Forms;
using ReservaGimnasio.Models;
using ReservaGimnasio.Services;

namespace ReservaGimnasio.Forms
{
    public partial class GestionUsuariosForm : Form
    {
        public GestionUsuariosForm()
        {
            InitializeComponent();
        }

        private void GestionUsuariosForm_Load(object sender, EventArgs e)
        {
            CargarUsuarios();
        }

        private void CargarUsuarios()
        {
            var usuarios = UsuarioService.ObtenerUsuarios();
            dataGridViewUsuarios.DataSource = usuarios;
        }

        private void btnAgregarUsuario_Click(object sender, EventArgs e)
        {
            UsuarioForm agregarUsuarioForm = new UsuarioForm();
            agregarUsuarioForm.ShowDialog();
            CargarUsuarios();  // Refrescar la tabla después de agregar
        }

        private void btnEditarUsuario_Click(object sender, EventArgs e)
        {
            if (dataGridViewUsuarios.SelectedRows.Count > 0)
            {
                int usuarioId = Convert.ToInt32(dataGridViewUsuarios.SelectedRows[0].Cells["Id"].Value);
                Usuario usuarioSeleccionado = UsuarioService.ObtenerUsuarioPorId(usuarioId);
                UsuarioForm editarUsuarioForm = new UsuarioForm(usuarioSeleccionado);
                editarUsuarioForm.ShowDialog();
                CargarUsuarios();  // Refrescar la tabla después de editar
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un usuario.");
            }
        }

        private void btnEliminarUsuario_Click(object sender, EventArgs e)
        {
            if (dataGridViewUsuarios.SelectedRows.Count > 0)
            {
                int usuarioId = Convert.ToInt32(dataGridViewUsuarios.SelectedRows[0].Cells["Id"].Value);
                UsuarioService.EliminarUsuario(usuarioId);
                MessageBox.Show("Usuario eliminado con éxito.");
                CargarUsuarios(); // Refrescar la tabla después de eliminar
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un usuario.");
            }
        }
    }
}
