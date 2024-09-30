namespace ReservaGimnasio.Models
{
    public class Clase
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int InstructorId { get; set; }
        public string NombreInstructor { get; set; } // Para mostrar el nombre en listados
        public DateTime FechaHora { get; set; }
        public int CupoMaximo { get; set; }
    }
}
