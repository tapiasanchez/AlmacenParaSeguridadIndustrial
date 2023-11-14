using System;

namespace CapaEntidad
{
    public class Dotacion
    {
        public int IdDotacion { get; set; }
        public Usuario usuario { get; set; }
        public string Comentario { get; set; }
        public DateTime FechaDotacion { get; set; }
        public string CodigoFormulario { get; set; }
    }
}
