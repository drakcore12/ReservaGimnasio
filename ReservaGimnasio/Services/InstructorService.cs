using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using System.Data;
using ReservaGimnasio.Models;
using ReservaGimnasio.Utilities;

namespace ReservaGimnasio.Services
{
    public static class InstructorService
    {
        public static List<Instructor> ObtenerInstructores()
        {
            List<Instructor> instructores = new List<Instructor>();
            using (SqlConnection con = new SqlConnection(Config.ConnectionString))
            {
                string query = "SELECT * FROM Instructores";
                SqlCommand cmd = new SqlCommand(query, con);

                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    instructores.Add(new Instructor
                    {
                        Id = (int)reader["Id"],
                        Nombre = reader["Nombre"].ToString(),
                        Especialidad = reader["Especialidad"].ToString()
                    });
                }
            }
            return instructores;
        }

        // Métodos para agregar, editar y eliminar instructores
    }
}
