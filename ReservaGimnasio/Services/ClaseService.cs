using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using System.Data;
using ReservaGimnasio.Models;
using ReservaGimnasio.Utilities;

namespace ReservaGimnasio.Services
{
    public static class ClaseService
    {
        public static List<Clase> ObtenerClasesDisponibles()
        {
            List<Clase> clases = new List<Clase>();
            using (SqlConnection con = new SqlConnection(Config.ConnectionString))
            {
                string query = @"SELECT Clases.*, Instructores.Nombre AS NombreInstructor
                                 FROM Clases
                                 INNER JOIN Instructores ON Clases.InstructorId = Instructores.Id
                                 WHERE FechaHora > @Ahora";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Ahora", DateTime.Now);

                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    clases.Add(new Clase
                    {
                        Id = (int)reader["Id"],
                        Nombre = reader["Nombre"].ToString(),
                        InstructorId = (int)reader["InstructorId"],
                        NombreInstructor = reader["NombreInstructor"].ToString(),
                        FechaHora = (DateTime)reader["FechaHora"],
                        CupoMaximo = (int)reader["CupoMaximo"]
                    });
                }
            }
            return clases;
        }

        public static void AgregarClase(Clase clase)
        {
            using (SqlConnection con = new SqlConnection(Config.ConnectionString))
            {
                string query = "INSERT INTO Clases (Nombre, InstructorId, FechaHora, CupoMaximo) VALUES (@Nombre, @InstructorId, @FechaHora, @CupoMaximo)";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Nombre", clase.Nombre);
                cmd.Parameters.AddWithValue("@InstructorId", clase.InstructorId);
                cmd.Parameters.AddWithValue("@FechaHora", clase.FechaHora);
                cmd.Parameters.AddWithValue("@CupoMaximo", clase.CupoMaximo);

                con.Open();
                cmd.ExecuteNonQuery();
            }
        }
        public static void EditarClase(Clase clase)
        {
            using (SqlConnection con = new SqlConnection(Config.ConnectionString))
            {
                string query = @"UPDATE Clases
                                 SET Nombre = @Nombre,
                                     InstructorId = @InstructorId,
                                     FechaHora = @FechaHora,
                                     CupoMaximo = @CupoMaximo
                                 WHERE Id = @Id";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Nombre", clase.Nombre);
                cmd.Parameters.AddWithValue("@InstructorId", clase.InstructorId);
                cmd.Parameters.AddWithValue("@FechaHora", clase.FechaHora);
                cmd.Parameters.AddWithValue("@CupoMaximo", clase.CupoMaximo);
                cmd.Parameters.AddWithValue("@Id", clase.Id);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }
        // Otros métodos como EditarClase, EliminarClase, etc.
    }
}
