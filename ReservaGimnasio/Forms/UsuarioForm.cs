using System;
using System.Windows.Forms;
using ReservaGimnasio.Models;
using ReservaGimnasio.Services;

namespace ReservaGimnasio.Forms
{
    public partial class UsuarioForm : Form
    {
        private bool esEdicion;
        private Usuario usuarioActual;

        public UsuarioForm()
        {
            InitializeComponent();
            esEdicion = false;
            CargarRoles();
        }

        public UsuarioForm(Usuario usuario)
        {
            InitializeComponent();
            esEdicion = true;
            usuarioActual = usuario;
            CargarDatosUsuario();
            CargarRoles();
        }

        private void CargarRoles()
        {
            var roles = UsuarioService.ObtenerRoles();  // Asume que tienes un método para obtener roles
            cmbRol.DataSource = roles;
            cmbRol.DisplayMember = "Nombre";
            cmbRol.ValueMember = "Id";
        }

        private void CargarDatosUsuario()
        {
            txtNombre.Text = usuarioActual.Nombre;
            txtCorreo.Text = usuarioActual.CorreoElectronico;
            txtTelefono.Text = usuarioActual.Telefono;
            cmbRol.SelectedValue = usuarioActual.RolId;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario
            {
                Nombre = txtNombre.Text,
                CorreoElectronico = txtCorreo.Text,
                Telefono = txtTelefono.Text,
                RolId = (int)cmbRol.SelectedValue
            };

            if (esEdicion)
            {
                usuario.Id = usuarioActual.Id;
                UsuarioService.EditarUsuario(usuario);
                MessageBox.Show("Usuario actualizado con éxito.");
            }
            else
            {
                usuario.Contraseña = txtContraseña.Text;  // Solo para usuarios nuevos
                UsuarioService.AgregarUsuario(usuario);
                MessageBox.Show("Usuario agregado con éxito.");
            }

            this.Close();
        }
    }
}
