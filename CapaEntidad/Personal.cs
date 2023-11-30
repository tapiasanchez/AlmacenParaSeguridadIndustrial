
namespace CapaEntidad
{
    public class Personal
    {
        public int IdPersona { get; set; }
        public string NombreCompleto { get; set; }
        public string Ci { get; set; }
        public string UserName { get; set; }
        public string Contrasena { get; set; }
        public Cargo Cargo { get; set; }
        public bool Estado { get; set; }

    }
}
