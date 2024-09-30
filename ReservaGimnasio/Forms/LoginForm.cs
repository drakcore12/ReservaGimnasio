using System;
using System.Windows.Forms;
using ReservaGimnasio.Models;
using ReservaGimnasio.Services;

namespace ReservaGimnasio.Forms
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            string correo = txtCorreo.Text;
            string contraseña = txtContraseña.Text;

            Usuario usuario = UsuarioService.IniciarSesion(correo, contraseña);

            if (usuario != null)
            {
                if (usuario.RolId == 1)
                {
                    AdminForm adminForm = new AdminForm(usuario);
                    adminForm.Show();
                }
                else
                {
                    MainForm mainForm = new MainForm(usuario);
                    mainForm.Show();
                }
                this.Hide();
            }
            else
            {
                MessageBox.Show("Correo o contraseña incorrectos.");
            }
        }

        private void linkRegistro_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegistroForm registroForm = new RegistroForm();
            registroForm.Show();
            this.Hide();
        }
    }
}
