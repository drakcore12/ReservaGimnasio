using ReservaGimnasio.Forms;
using System;
using System.Windows.Forms;

namespace ReservaGimnasio
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Iniciar con el formulario de inicio de sesión
            Application.Run(new LoginForm());
        }
    }
}
