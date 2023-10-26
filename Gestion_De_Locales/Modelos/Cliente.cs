using System;

public class Cliente
{
    public int IdCliente { get; set; }
    public string Nombre { get; set; }
    public string Apellido { get; set; }
    public string CorreoElectronico { get; set; }
    public string Telefono { get; set; }
    public string Direccion { get; set; }
    public DateTime FechaNacimiento { get; set; }
    public string Genero { get; set; }
    public string Ocupacion { get; set; }
    public int IdUsuario { get; internal set; }

    // Métodos adicionales:
    public string NombreCompleto()
    {
        return $"{Nombre} {Apellido}";
    }

    public int Edad()
    {
        DateTime now = DateTime.Today;
        int age = now.Year - FechaNacimiento.Year;
        if (now < FechaNacimiento.AddYears(age))
            age--;
        return age;
    }
}
