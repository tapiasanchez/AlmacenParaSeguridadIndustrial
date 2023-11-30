using System;

namespace CapaEntidad
{
    public class CambioDotacion
    {
        public int IDCambioDotacion {  get; set; }
        public Usuario Usuario { get; set; }
        public Personal Personal { get; set; }
        public Producto Producto { get; set; }
        public int Cantidad { get; set; }
        public string Comentario { get; set; }
        public DateTime Fecha { get; set; }
        public string CodFormulario { get; set; }
    }
}
