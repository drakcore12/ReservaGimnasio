namespace ReservaGimnasio.Models
{
    public class Reserva
    {
        public int Id { get; set; }
        public int UsuarioId { get; set; }
        public int ClaseId { get; set; }
        public DateTime FechaReserva { get; set; }
        public string NombreClase { get; set; }  // Nombre de la clase
        public DateTime FechaHora { get; set; }  // Fecha y hora de la clase
        public string NombreInstructor { get; set; }  // Nombre del instructor
        public int Duracion { get; set; }  // Duración de la clase
    }


}
