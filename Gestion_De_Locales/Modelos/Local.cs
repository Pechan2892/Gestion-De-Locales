namespace Gestion_De_Locales.Modelos
{
    public enum TipoLocal
    {
        Abierto,
        Cerrado
    }

    public class Local
    {
        public int IdLocal { get; set; }
        public string NombreLocal { get; set; }
        public int Capacidad { get; set; }
        public string Direccion { get; set; }
        public string DistribucionFisica { get; set; }
        public bool Iluminacion { get; set; }
        public bool Sonido { get; set; }
        public bool Sillas { get; set; }
        public TipoLocal Tipo { get; set; }

        public bool TieneEquipamientoCompleto()
        {
            return Iluminacion && Sonido && Sillas;
        }
    }
}

