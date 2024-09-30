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
                string query = "INSERT INTO Usuarios (Nombre, CorreoElectronico, Contraseña, Telefono, RolId) VALUES (@Nombre, @Correo, @Contraseña, @Telefono, @RolId)";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Nombre", usuario.Nombre);
                cmd.Parameters.AddWithValue("@Correo", usuario.CorreoElectronico);
                cmd.Parameters.AddWithValue("@Contraseña", usuario.Contraseña);
                cmd.Parameters.AddWithValue("@Telefono", usuario.Telefono);
                cmd.Parameters.AddWithValue("@RolId", usuario.RolId);

                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public static Usuario IniciarSesion(string correo, string contraseña)
        {
            using (SqlConnection con = new SqlConnection(Config.ConnectionString))
            {
                string query = "SELECT * FROM Usuarios WHERE CorreoElectronico = @Correo AND Contraseña = @Contraseña";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Correo", correo);
                cmd.Parameters.AddWithValue("@Contraseña", contraseña);

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
                        Contraseña = reader["Contraseña"].ToString()
                    };
                }
                else
                {
                    return null;
                }
            }
        }

        // Otros métodos como RecuperarContraseña, EditarUsuario, etc.
    }
}
