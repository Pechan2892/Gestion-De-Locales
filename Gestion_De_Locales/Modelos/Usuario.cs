public class Usuario
{
    public int IdUsuario { get; set; }
    public string NombreUsuario { get; set; }
    public string Password { get; set; }
    public string Nombre { get; set; }
    public int IdTipo { get; set; }

    // Puedes añadir métodos adicionales si es necesario, como:
    public bool EsAdmin()
    {
        return IdTipo == 1;  // Suponiendo que 1 es el ID para administradores.
    }
}
