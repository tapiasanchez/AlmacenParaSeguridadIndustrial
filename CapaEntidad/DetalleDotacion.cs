
namespace CapaEntidad
{
    public class DetalleDotacion
    {
        public int IdDetalleDotacion {  get; set; }
        public Dotacion dotacion { get; set; }
        public Producto producto { get; set; }
        public int Cantidad { get; set; }
    }
}
