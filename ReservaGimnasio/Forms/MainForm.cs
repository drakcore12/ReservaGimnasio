using System;
using System.Windows.Forms;
using ReservaGimnasio.Models;

namespace ReservaGimnasio.Forms
{
    public partial class MainForm : Form
    {
        private Usuario usuarioActual;

        public MainForm(Usuario usuario)
        {
            InitializeComponent();
            usuarioActual = usuario;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            lblBienvenida.Text = $"Bienvenido, {usuarioActual.Nombre}";
        }

        private void btnReservarClase_Click(object sender, EventArgs e)
        {
            ReservarClaseForm reservarClaseForm = new ReservarClaseForm(usuarioActual);
            reservarClaseForm.Show();
        }

        private void btnMisReservas_Click(object sender, EventArgs e)
        {
            MisReservasForm misReservasForm = new MisReservasForm(usuarioActual);
            misReservasForm.Show();
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            this.Close();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }
    }
}
