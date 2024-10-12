using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using ReservaGimnasio.Models;
using ReservaGimnasio.Utilities;

namespace ReservaGimnasio.Services
{
    public static class UsuarioService
    {
        // Obtener lista de usuarios
        public static List<Usuario> ObtenerUsuarios()
        {
            List<Usuario> usuarios = new List<Usuario>();
            using (SqlConnection con = new SqlConnection(Config.ConnectionString))
            {
                string query = "SELECT * FROM Usuarios";
                SqlCommand cmd = new SqlCommand(query, con);

                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    usuarios.Add(new Usuario
                    {
                        Id = reader["Id"] != DBNull.Value ? (int)reader["Id"] : 0,
                        Nombre = reader["Nombre"].ToString(),
                        CorreoElectronico = reader["CorreoElectronico"].ToString(),
                        Telefono = reader["Telefono"].ToString(),
                        RolId = reader["RolId"] != DBNull.Value ? (int)reader["RolId"] : 0
                    });
                }
            }
            return usuarios;
        }

        // Obtener un usuario por ID
        public static Usuario ObtenerUsuarioPorId(int id)
        {
            Usuario usuario = null;
            using (SqlConnection con = new SqlConnection(Config.ConnectionString))
            {
                string query = "SELECT * FROM Usuarios WHERE Id = @Id";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Id", id);

                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    usuario = new Usuario
                    {
                        Id = reader["Id"] != DBNull.Value ? (int)reader["Id"] : 0,
                        Nombre = reader["Nombre"].ToString(),
                        CorreoElectronico = reader["CorreoElectronico"].ToString(),
                        Telefono = reader["Telefono"].ToString(),
                        RolId = reader["RolId"] != DBNull.Value ? (int)reader["RolId"] : 0
                    };
                }
            }
            return usuario;
        }

        // Eliminar un usuario por ID
        public static void EliminarUsuario(int id)
        {
            using (SqlConnection con = new SqlConnection(Config.ConnectionString))
            {
                string query = "DELETE FROM Usuarios WHERE Id = @Id";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Id", id);

                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        // Método para agregar un nuevo usuario
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
            Usuario usuario = null;
            using (SqlConnection con = new SqlConnection(Config.ConnectionString))
            {
                string query = @"SELECT Id, Nombre, CorreoElectronico, Telefono, RolId
                         FROM Usuarios 
                         WHERE CorreoElectronico = @Correo AND Contraseña = @Contraseña";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Correo", correo);
                cmd.Parameters.AddWithValue("@Contraseña", contraseña);

                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    usuario = new Usuario
                    {
                        Id = (int)reader["Id"],
                        Nombre = reader["Nombre"].ToString(),
                        CorreoElectronico = reader["CorreoElectronico"].ToString(),
                        Telefono = reader["Telefono"].ToString(),
                        RolId = (int)reader["RolId"]
                    };
                }
            }

            return usuario;
        }

        // Método para editar un usuario
        public static void EditarUsuario(Usuario usuario)
        {
            using (SqlConnection con = new SqlConnection(Config.ConnectionString))
            {
                string query = @"UPDATE Usuarios 
                                 SET Nombre = @Nombre, 
                                     CorreoElectronico = @Correo, 
                                     Telefono = @Telefono, 
                                     RolId = @RolId 
                                 WHERE Id = @Id";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Nombre", usuario.Nombre);
                cmd.Parameters.AddWithValue("@Correo", usuario.CorreoElectronico);
                cmd.Parameters.AddWithValue("@Telefono", usuario.Telefono);
                cmd.Parameters.AddWithValue("@RolId", usuario.RolId);
                cmd.Parameters.AddWithValue("@Id", usuario.Id);

                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        // Método para obtener los roles de usuario
        public static List<Rol> ObtenerRoles()
        {
            List<Rol> roles = new List<Rol>();
            using (SqlConnection con = new SqlConnection(Config.ConnectionString))
            {
                string query = "SELECT * FROM Roles";
                SqlCommand cmd = new SqlCommand(query, con);

                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    roles.Add(new Rol
                    {
                        Id = reader["Id"] != DBNull.Value ? (int)reader["Id"] : 0,
                        Nombre = reader["Nombre"].ToString()
                    });
                }
            }
            return roles;
        }
    }
}
