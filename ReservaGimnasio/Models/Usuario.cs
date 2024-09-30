namespace ReservaGimnasio.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string CorreoElectronico { get; set; }
        public string Contraseña { get; set; }
        public string Telefono { get; set; }
        public int RolId { get; set; } // Cliente o Administrador
    }
}
