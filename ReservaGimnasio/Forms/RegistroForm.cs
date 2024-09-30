using System;
using System.Windows.Forms;
using ReservaGimnasio.Models;
using ReservaGimnasio.Services;

namespace ReservaGimnasio.Forms
{
    public partial class RegistroForm : Form
    {
        public RegistroForm()
        {
            InitializeComponent();
        }

        private void btnRegistrarse_Click(object sender, EventArgs e)
        {
            if (txtContraseña.Text != txtConfirmarContraseña.Text)
            {
                MessageBox.Show("Las contraseñas no coinciden.");
                return;
            }

            Usuario nuevoUsuario = new Usuario
            {
                Nombre = txtNombre.Text,
                CorreoElectronico = txtCorreo.Text,
                Contraseña = txtContraseña.Text,
                Telefono = txtTelefono.Text,
                RolId = 2
            };

            try
            {
                UsuarioService.AgregarUsuario(nuevoUsuario);
                MessageBox.Show("Registro exitoso. Por favor, inicie sesión.");
                LoginForm loginForm = new LoginForm();
                loginForm.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar el usuario: " + ex.Message);
            }
        }

        private void linkIniciarSesion_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }
    }
}
