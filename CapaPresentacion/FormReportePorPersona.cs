using CapaEntidad;
using CapaNegocio;
using CapaPresentacion.Reportes;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FormReportePorPersona : Form
    {
        private int userId = 0;
        public FormReportePorPersona()
        {
            InitializeComponent();
        }

        private void IconButton1_Click(object sender, EventArgs e)
        {
            GetUsuario();
            CargarDotacion();
            CargarCambios();
        }
        private void GetUsuario()
        {
            string ci = textBoxCI.Text;
            string nombre = textBoxNombre.Text;

            Usuario usuario = new CN_Usuario().GetByCiAndNombre(ci, nombre);
            userId = usuario.IdUsuario;
            infoUsuario.Text = $"CI:{usuario.Ci} Nombre:{usuario.Nombre} {usuario.Apellido} " +
                               $"Cargo: {usuario.NombreCargo.Nombre} Unidada: {usuario.NombreUnidad.Nombre} Puesto De Trabajo: {usuario.NombrePuesto.Nombre}";
        }
        private void CargarDotacion()
        {
            dgvDotacion.Rows.Clear();
            List<DetalleDotacion> listaProductos = new CN_DetalleDotacion().GetDetalleDeDotacionByIdUsuario(userId);
            foreach (DetalleDotacion item in listaProductos)
            {
                dgvDotacion.Rows.Add(item.Producto.NombreProducto, item.Cantidad, item.Producto.Talla.Nombre,item.Producto.Color,
                    item.Producto.Unidad, item.Dotacion.FechaDotacion, item.Dotacion.Comentario);
            }
        }
        private void CargarCambios()
        {
            dgvCambioDotacion.Rows.Clear();
            List<CambioDotacion> listaProductos = new CN_CambioDeDotacion().GetCambioDeDotacion(userId);
            foreach (CambioDotacion item in listaProductos)
            {
                dgvCambioDotacion.Rows.Add(item.Producto.NombreProducto, item.Cantidad, item.Producto.Talla.Nombre, item.Producto.Color,
                    item.Producto.Unidad, item.Fecha, item.Comentario);
            }
        }

        private void IconButton2_Click(object sender, EventArgs e)
        {
            Report_DotacionYCambio report = new Report_DotacionYCambio();
            report.textBoxIdUsuario.Text = userId.ToString();
            report.ShowDialog();
        }
    }
}
