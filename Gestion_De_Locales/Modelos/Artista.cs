using System;

namespace Gestion_De_Locales.Modelos
{
    public class Artista
    {
        private int valoracion;

        public int IdArtista { get; set; }
        public string NombreArtista { get; set; }
        public string GeneroMusical { get; set; }
        public string Nacionalidad { get; set; }
        public DateTime FechaDebut { get; set; }
        public string Descripcion { get; set; }
        public bool EnActividad { get; set; }
        public string RedesSociales { get; set; }
        public string SitioWeb { get; set; }
        public string Premios { get; set; }
        public int NumeroAlbumes { get; set; }

        public int Valoracion
        {
            get { return valoracion; }
            set
            {
                if (value >= 0 && value <= 10)  // Asumiendo que la valoración es de 0 a 10
                {
                    valoracion = value;
                }
                else
                {
                    throw new Exception("La valoración debe estar entre 0 y 10.");
                }
            }
        }

        public bool EsReconocido()
        {
            // Asumiendo que un artista es reconocido si su valoración es 8 o más
            return valoracion >= 8;
        }
    }
}

