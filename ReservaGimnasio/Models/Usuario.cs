public class Usuario
{
    public int Id { get; set; }
    public string Nombre { get; set; } = string.Empty; // Inicializaci�n para evitar null
    public string CorreoElectronico { get; set; } = string.Empty; // Inicializaci�n para evitar null
    public string Contrase�a { get; set; } = string.Empty; // Inicializaci�n para evitar null
    public string Telefono { get; set; } = string.Empty; // Inicializaci�n para evitar null
    public int RolId { get; set; }
}
