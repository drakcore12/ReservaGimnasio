using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using System.Data;
using ReservaGimnasio.Models;
using ReservaGimnasio.Utilities;

namespace ReservaGimnasio.Services
{
    public static class ReservaService
    {
        public static void HacerReserva(int usuarioId, int claseId)
        {
            using (SqlConnection con = new SqlConnection(Config.ConnectionString))
            {
                // Verificar si hay cupos disponibles
                string cupoQuery = "SELECT COUNT(*) FROM Reservas WHERE ClaseId = @ClaseId";
                SqlCommand cupoCmd = new SqlCommand(cupoQuery, con);
                cupoCmd.Parameters.AddWithValue("@ClaseId", claseId);

                con.Open();
                int reservasActuales = (int)cupoCmd.ExecuteScalar();

                // Obtener el cupo máximo de la clase
                string claseQuery = "SELECT CupoMaximo FROM Clases WHERE Id = @ClaseId";
                SqlCommand claseCmd = new SqlCommand(claseQuery, con);
                claseCmd.Parameters.AddWithValue("@ClaseId", claseId);

                int cupoMaximo = (int)claseCmd.ExecuteScalar();

                if (reservasActuales < cupoMaximo)
                {
                    // Realizar la reserva
                    string reservaQuery = "INSERT INTO Reservas (UsuarioId, ClaseId, FechaReserva) VALUES (@UsuarioId, @ClaseId, @FechaReserva)";
                    SqlCommand reservaCmd = new SqlCommand(reservaQuery, con);
                    reservaCmd.Parameters.AddWithValue("@UsuarioId", usuarioId);
                    reservaCmd.Parameters.AddWithValue("@ClaseId", claseId);
                    reservaCmd.Parameters.AddWithValue("@FechaReserva", DateTime.Now);

                    reservaCmd.ExecuteNonQuery();
                }
                else
                {
                    throw new Exception("No hay cupos disponibles para esta clase.");
                }
            }
        }
        public static List<Reserva> ObtenerReservasPorUsuario(int usuarioId)
        {
            List<Reserva> reservas = new List<Reserva>();
            using (SqlConnection con = new SqlConnection(Config.ConnectionString))
            {
                string query = @"SELECT r.Id, r.FechaReserva, tc.Nombre AS NombreClase, c.FechaHora, 
                         i.Nombre AS NombreInstructor, c.Duracion
                         FROM Reservas r
                         INNER JOIN Clases c ON r.ClaseId = c.Id
                         INNER JOIN TiposDeClase tc ON c.TipoClaseId = tc.Id
                         INNER JOIN Instructores i ON c.InstructorId = i.Id
                         WHERE r.UsuarioId = @UsuarioId";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@UsuarioId", usuarioId);

                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    reservas.Add(new Reserva
                    {
                        Id = (int)reader["Id"],
                        FechaReserva = (DateTime)reader["FechaReserva"],
                        NombreClase = reader["NombreClase"].ToString(),
                        FechaHora = (DateTime)reader["FechaHora"],
                        NombreInstructor = reader["NombreInstructor"].ToString(),  // Nueva propiedad para el instructor
                        Duracion = (int)reader["Duracion"]  // Nueva propiedad para la duración
                    });
                }
            }
            return reservas;
        }


        public static void CancelarReserva(int reservaId)
        {
            using (SqlConnection con = new SqlConnection(Config.ConnectionString))
            {
                string query = "DELETE FROM Reservas WHERE Id = @ReservaId";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@ReservaId", reservaId);

                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        // Otros métodos para modificar reservas si es necesario
    }
}
