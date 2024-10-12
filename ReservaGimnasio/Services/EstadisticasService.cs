using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using ReservaGimnasio.Models;
using ReservaGimnasio.Utilities;

namespace ReservaGimnasio.Services
{
    public static class EstadisticasService
    {
        // Total de reservas
        public static int ObtenerTotalReservas()
        {
            int totalReservas = 0;
            using (SqlConnection con = new SqlConnection(Config.ConnectionString))
            {
                string query = "SELECT COUNT(*) FROM Reservas";
                SqlCommand cmd = new SqlCommand(query, con);

                con.Open();
                totalReservas = (int)cmd.ExecuteScalar();
            }
            return totalReservas;
        }

        // Reservas por clase
        public static Dictionary<string, int> ObtenerReservasPorClase()
        {
            Dictionary<string, int> reservasPorClase = new Dictionary<string, int>();
            using (SqlConnection con = new SqlConnection(Config.ConnectionString))
            {
                string query = @"SELECT tc.Nombre, COUNT(r.Id) AS NumeroDeReservas
                                 FROM Reservas r
                                 INNER JOIN Clases c ON r.ClaseId = c.Id
                                 INNER JOIN TiposDeClase tc ON c.TipoClaseId = tc.Id
                                 GROUP BY tc.Nombre";
                SqlCommand cmd = new SqlCommand(query, con);

                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    reservasPorClase.Add(reader["Nombre"].ToString(), (int)reader["NumeroDeReservas"]);
                }
            }
            return reservasPorClase;
        }

        // Top 5 clases más reservadas
        public static List<Tuple<string, int>> ObtenerTop5Clases()
        {
            List<Tuple<string, int>> topClases = new List<Tuple<string, int>>();
            using (SqlConnection con = new SqlConnection(Config.ConnectionString))
            {
                string query = @"SELECT TOP 5 tc.Nombre, COUNT(r.Id) AS NumeroDeReservas
                                 FROM Reservas r
                                 INNER JOIN Clases c ON r.ClaseId = c.Id
                                 INNER JOIN TiposDeClase tc ON c.TipoClaseId = tc.Id
                                 GROUP BY tc.Nombre
                                 ORDER BY NumeroDeReservas DESC";
                SqlCommand cmd = new SqlCommand(query, con);

                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    topClases.Add(new Tuple<string, int>(reader["Nombre"].ToString(), (int)reader["NumeroDeReservas"]));
                }
            }
            return topClases;
        }

        // Reservas por instructor
        public static Dictionary<string, int> ObtenerReservasPorInstructor()
        {
            Dictionary<string, int> reservasPorInstructor = new Dictionary<string, int>();
            using (SqlConnection con = new SqlConnection(Config.ConnectionString))
            {
                string query = @"SELECT i.Nombre, COUNT(r.Id) AS NumeroDeReservas
                                 FROM Reservas r
                                 INNER JOIN Clases c ON r.ClaseId = c.Id
                                 INNER JOIN Instructores i ON c.InstructorId = i.Id
                                 GROUP BY i.Nombre";
                SqlCommand cmd = new SqlCommand(query, con);

                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    reservasPorInstructor.Add(reader["Nombre"].ToString(), (int)reader["NumeroDeReservas"]);
                }
            }
            return reservasPorInstructor;
        }
    }
}
