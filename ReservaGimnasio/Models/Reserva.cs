namespace ReservaGimnasio.Models
{
    public class Reserva
    {
        public int Id { get; set; }
        public int UsuarioId { get; set; }
        public int ClaseId { get; set; }
        public DateTime FechaReserva { get; set; }
    }
}
