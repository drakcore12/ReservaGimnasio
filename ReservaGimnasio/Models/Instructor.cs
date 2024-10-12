namespace ReservaGimnasio.Models
{
    public class Instructor
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = string.Empty; // Evitar valores nulos
        public string Especialidad { get; set; } = string.Empty; // Evitar valores nulos
    }
}
