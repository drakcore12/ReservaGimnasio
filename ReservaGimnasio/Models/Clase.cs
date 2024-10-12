namespace ReservaGimnasio.Models
{
    public class Clase
    {
        public int Id { get; set; }
        public int TipoClaseId { get; set; }
        public string NombreTipoClase { get; set; }  // Nueva propiedad para el nombre de la clase
        public int InstructorId { get; set; }
        public string NombreInstructor { get; set; }  // Nueva propiedad para el nombre del instructor
        public DateTime FechaHora { get; set; }
        public int Duracion { get; set; }
        public int CupoMaximo { get; set; }
    }

}
