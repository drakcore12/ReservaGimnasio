using System;
using System.Windows.Forms;
using ReservaGimnasio.Models;

namespace ReservaGimnasio.Forms
{
    public partial class AdminForm : Form
    {
        private Usuario usuarioActual;

        public AdminForm(Usuario usuario)
        {
            InitializeComponent();
            usuarioActual = usuario;
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            lblBienvenida.Text = $"Administrador: {usuarioActual.Nombre}";
        }

        private void btnGestionarClases_Click(object sender, EventArgs e)
        {
            GestionClasesForm gestionClasesForm = new GestionClasesForm();
            gestionClasesForm.Show();
        }

        private void btnGestionarUsuarios_Click(object sender, EventArgs e)
        {
            GestionUsuariosForm gestionUsuariosForm = new GestionUsuariosForm();
            gestionUsuariosForm.Show();
        }

        private void btnVerEstadisticas_Click(object sender, EventArgs e)
        {
            EstadisticasForm estadisticasForm = new EstadisticasForm();
            estadisticasForm.Show();
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            this.Close();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }
    }
}
