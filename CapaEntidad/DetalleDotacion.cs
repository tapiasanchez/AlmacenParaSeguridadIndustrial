
namespace CapaEntidad
{
    public class DetalleDotacion
    {
        public int IdDetalleDotacion {  get; set; }
        public Dotacion Dotacion { get; set; }
        public Producto Producto { get; set; }
        public int Cantidad { get; set; }
    }
}
