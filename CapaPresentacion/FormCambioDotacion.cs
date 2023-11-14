using CapaEntidad;
using CapaNegocio;
using CapaPresentacion.Reportes;
using CapaPresentacion.Utilidades;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FormCambioDotacion : Form
    {
        int userId = 0;
        public FormCambioDotacion()
        {
            InitializeComponent();
        }

        private void FormCambioDotacion_Load(object sender, EventArgs e)
        {
            dtpCambio.Value = DateTime.Now;
            dtpCambio.Format = DateTimePickerFormat.Custom;
            dtpCambio.CustomFormat = "dd/MM/yyyy hh:mm";
            CargarPuestosDeTrabajo();
            CargarListaDeProductos();
        }
        private void ObtenerListCambioDeDotacion()
        {
            dgvListaCambioDotacion.Rows.Clear();
            List<CambioDotacion> listaProductos = new CN_CambioDeDotacion().GetCambioDeDotacion(userId);
            foreach (CambioDotacion item in listaProductos)
            {
                    dgvListaCambioDotacion.Rows.Add(item.Usuario.Nombre,item.Usuario.Apellido, item.Usuario.Ci, 
                    item.Producto.NombreProducto, item.Cantidad, item.Fecha);

            }
        }
        private void CargarPuestosDeTrabajo()
        {
            List<PuestoDeTrabajo> puestoDeTrabajos = new CN_PuestoDeTrabajo().Listar();
            foreach (PuestoDeTrabajo item in puestoDeTrabajos)
            {
                comboBoxPuesto.Items.Add(new OpcionCombo()
                {
                    Texto = item.Nombre,
                    Valor = item.IdPuestoDeTrabajo
                });
                comboBoxPuesto.DisplayMember = "Texto";
                comboBoxPuesto.ValueMember = "Valor";
                comboBoxPuesto.SelectedIndex = 0;
            }

        }
        private void CargarListaDeProductos()
        {
            string puesto = ((OpcionCombo)comboBoxPuesto.SelectedItem).Texto;
            List<Producto> listaProductos = new CN_ListaDotacion().GetListProductByPuesto(puesto);
            foreach(Producto producto in listaProductos)
            {
                comboBoxProducto.Items.Add(new OpcionCombo()
                {
                    Texto = producto.NombreProducto,
                    Valor = producto.IdProducto
                });
                comboBoxProducto.DisplayMember = "Texto";
                comboBoxProducto.ValueMember = "Valor";
                comboBoxProducto.SelectedIndex = 0;
            }
        }

        private void IconButton1_Click(object sender, EventArgs e)
        {
            string ci = textBoxCI.Text;
            string nombre = textBoxNombre.Text;

            Usuario usuario = new CN_Usuario().GetByCiAndNombre(ci, nombre);
            userId = usuario.IdUsuario;
            infoUsuario.Text = $"CI:{usuario.Ci} Nombre:{usuario.Nombre} {usuario.Apellido} " +
                               $"Cargo: {usuario.NombreCargo.Nombre} Unidada: {usuario.NombreUnidad.Nombre} Puesto De Trabajo: {usuario.NombrePuesto.Nombre}";
            ObtenerListCambioDeDotacion();

        }

        private void BtnRegistrarCambioDeDotacion_Click(object sender, EventArgs e)
        {
            RegistrarCambioDeDotacion();
            RegistrarInventario();
            ActualizarStockProducto();
            LimpiarFormCambioDeDotacion();
            ObtenerListCambioDeDotacion();

        }
        private void RegistrarCambioDeDotacion()
        {
            CambioDotacion cambioDotacion = new CambioDotacion
            {
                Usuario = new Usuario() { IdUsuario = userId },
                Producto = new Producto() { IdProducto = Convert.ToInt32(((OpcionCombo)comboBoxProducto.SelectedItem).Valor) },
                Cantidad = Convert.ToInt32(textBoxCantidad.Text),
                Comentario = textBoxComentario.Text,
                Fecha = dtpCambio.Value,
                CodFormulario = codForm.Text
            };
            new CN_CambioDeDotacion().Registrar(cambioDotacion);
        }
        private void RegistrarInventario()
        {
            Inventario inventario = new Inventario
            {
                Producto = new Producto() { IdProducto = Convert.ToInt32(((OpcionCombo)comboBoxProducto.SelectedItem).Valor) },
                Salida = Convert.ToInt32(textBoxCantidad.Text),
                Fecha = dtpCambio.Value
            };
            new CN_Inventario().Registrar(inventario);
        }
        private void ActualizarStockProducto()
        {
            Producto producto = new CN_Producto().GetByID(Convert.ToInt32(((OpcionCombo)comboBoxProducto.SelectedItem).Valor));
            producto.Cantidad -= Convert.ToInt32(textBoxCantidad.Text); 
            new CN_Producto().UpdateStock(producto);
        }
        private void LimpiarFormCambioDeDotacion()
        {
            textBoxCantidad.Text = "";
            textBoxCI.Text = "";
            textBoxNombre.Text = "";
            infoUsuario.Text = "";
            comboBoxPuesto.Text = "";
            textBoxComentario.Text = "";
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            Report_CambioDotacion report = new Report_CambioDotacion();
            report.textBoxIdUsuario.Text = userId.ToString();
            report.ShowDialog();
        }
    }
}
