using System;
using Microsoft.Data.SqlClient;
using System.Data;
using ReservaGimnasio.Models;
using ReservaGimnasio.Utilities;

namespace ReservaGimnasio.Services
{
    public static class UsuarioService
    {
        public static void AgregarUsuario(Usuario usuario)
        {
            using (SqlConnection con = new SqlConnection(Config.ConnectionString))
            {
                string query = "INSERT INTO Usuarios (Nombre, CorreoElectronico, Contrase�a, Telefono, RolId) VALUES (@Nombre, @Correo, @Contrase�a, @Telefono, @RolId)";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Nombre", usuario.Nombre);
                cmd.Parameters.AddWithValue("@Correo", usuario.CorreoElectronico);
                cmd.Parameters.AddWithValue("@Contrase�a", usuario.Contrase�a);
                cmd.Parameters.AddWithValue("@Telefono", usuario.Telefono);
                cmd.Parameters.AddWithValue("@RolId", usuario.RolId);

                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public static Usuario IniciarSesion(string correo, string contrase�a)
        {
            using (SqlConnection con = new SqlConnection(Config.ConnectionString))
            {
                string query = "SELECT * FROM Usuarios WHERE CorreoElectronico = @Correo AND Contrase�a = @Contrase�a";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Correo", correo);
                cmd.Parameters.AddWithValue("@Contrase�a", contrase�a);

                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    return new Usuario
                    {
                        Id = (int)reader["Id"],
                        Nombre = reader["Nombre"].ToString(),
                        CorreoElectronico = reader["CorreoElectronico"].ToString(),
                        Telefono = reader["Telefono"].ToString(),
                        RolId = (int)reader["RolId"],
                        Contrase�a = reader["Contrase�a"].ToString()
                    };
                }
                else
                {
                    return null;
                }
            }
        }

        // Otros m�todos como RecuperarContrase�a, EditarUsuario, etc.
    }
}
