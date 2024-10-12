using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
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
                string query = @"SELECT c.Id, c.TipoClaseId, tc.Nombre AS NombreTipoClase, 
                         c.InstructorId, i.Nombre AS NombreInstructor, 
                         c.FechaHora, c.Duracion, c.CupoMaximo
                         FROM Clases c
                         INNER JOIN Instructores i ON c.InstructorId = i.Id
                         INNER JOIN TiposDeClase tc ON c.TipoClaseId = tc.Id
                         WHERE c.FechaHora > @Ahora";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Ahora", DateTime.Now);

                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    clases.Add(new Clase
                    {
                        Id = (int)reader["Id"],
                        TipoClaseId = (int)reader["TipoClaseId"],
                        NombreTipoClase = reader["NombreTipoClase"].ToString(),  // Aquí asignamos el nombre
                        InstructorId = (int)reader["InstructorId"],
                        NombreInstructor = reader["NombreInstructor"].ToString(),  // Aquí asignamos el nombre del instructor
                        FechaHora = (DateTime)reader["FechaHora"],
                        Duracion = (int)reader["Duracion"],
                        CupoMaximo = (int)reader["CupoMaximo"]
                    });
                }
            }
            return clases;
        }



        // Método para agregar una clase
        public static void AgregarClase(Clase clase)
        {
            using (SqlConnection con = new SqlConnection(Config.ConnectionString))
            {
                string query = "INSERT INTO Clases (TipoClaseId, InstructorId, FechaHora, Duracion, CupoMaximo) VALUES (@TipoClaseId, @InstructorId, @FechaHora, @Duracion, @CupoMaximo)";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@TipoClaseId", clase.TipoClaseId);
                cmd.Parameters.AddWithValue("@InstructorId", clase.InstructorId);
                cmd.Parameters.AddWithValue("@FechaHora", clase.FechaHora);
                cmd.Parameters.AddWithValue("@Duracion", clase.Duracion);
                cmd.Parameters.AddWithValue("@CupoMaximo", clase.CupoMaximo);

                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        // Método para editar una clase
        public static void EditarClase(Clase clase)
        {
            using (SqlConnection con = new SqlConnection(Config.ConnectionString))
            {
                string query = @"UPDATE Clases
                                 SET TipoClaseId = @TipoClaseId,
                                     InstructorId = @InstructorId,
                                     FechaHora = @FechaHora,
                                     Duracion = @Duracion,
                                     CupoMaximo = @CupoMaximo
                                 WHERE Id = @Id";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@TipoClaseId", clase.TipoClaseId);
                cmd.Parameters.AddWithValue("@InstructorId", clase.InstructorId);
                cmd.Parameters.AddWithValue("@FechaHora", clase.FechaHora);
                cmd.Parameters.AddWithValue("@Duracion", clase.Duracion);
                cmd.Parameters.AddWithValue("@CupoMaximo", clase.CupoMaximo);
                cmd.Parameters.AddWithValue("@Id", clase.Id);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }
        public static List<TipoClase> ObtenerTiposDeClase()
        {
            List<TipoClase> tiposDeClase = new List<TipoClase>();
            using (SqlConnection con = new SqlConnection(Config.ConnectionString))
            {
                string query = "SELECT * FROM TiposDeClase";
                SqlCommand cmd = new SqlCommand(query, con);

                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    tiposDeClase.Add(new TipoClase
                    {
                        Id = (int)reader["Id"],
                        Nombre = reader["Nombre"].ToString()
                    });
                }
            }
            return tiposDeClase;
        }


        // Obtener una clase por su ID
        public static Clase ObtenerClasePorId(int id)
        {
            Clase clase = null;
            using (SqlConnection con = new SqlConnection(Config.ConnectionString))
            {
                string query = @"SELECT c.Id, c.TipoClaseId, c.InstructorId, c.FechaHora, c.Duracion, c.CupoMaximo, 
                                 tc.Nombre AS NombreClase, i.Nombre AS NombreInstructor
                                 FROM Clases c
                                 INNER JOIN Instructores i ON c.InstructorId = i.Id
                                 INNER JOIN TiposDeClase tc ON c.TipoClaseId = tc.Id
                                 WHERE c.Id = @Id";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Id", id);

                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    clase = new Clase
                    {
                        Id = (int)reader["Id"],
                        TipoClaseId = (int)reader["TipoClaseId"],
                        InstructorId = (int)reader["InstructorId"],
                        FechaHora = (DateTime)reader["FechaHora"],
                        Duracion = (int)reader["Duracion"],
                        CupoMaximo = (int)reader["CupoMaximo"]
                    };
                }
            }
            return clase;
        }

        // Método para eliminar una clase
        public static void EliminarClase(int id)
        {
            using (SqlConnection con = new SqlConnection(Config.ConnectionString))
            {
                string query = "DELETE FROM Clases WHERE Id = @Id";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Id", id);

                con.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}
