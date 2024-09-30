using System;
using Microsoft.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace ReservaGimnasio.Utilities
{
    public static class DatabaseHelper
    {
        public static bool ProbarConexion()
        {
            using (SqlConnection con = new SqlConnection(Config.ConnectionString))
            {
                try
                {
                    con.Open();
                    return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo conectar a la base de datos: " + ex.Message);
                    return false;
                }
            }
        }
    }
}
