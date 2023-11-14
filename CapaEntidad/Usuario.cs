
namespace CapaEntidad
{
    public class Usuario
    {
        public int IdUsuario { get; set; }
        public string Item { get; set; }
        public string Ci { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Observaciones { get; set; }
        public Cargo NombreCargo { get; set; }
        public Unidad NombreUnidad { get; set; }
        public PuestoDeTrabajo NombrePuesto {  get; set; }
    }
}
