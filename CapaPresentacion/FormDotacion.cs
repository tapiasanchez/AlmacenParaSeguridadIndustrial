using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using CapaNegocio;
using CapaEntidad;
using CapaPresentacion.Utilidades;


namespace CapaPresentacion
{
    public partial class FormDotacion : Form
    {
        public FormDotacion()
        {
            InitializeComponent();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            string ci = textCi.Text;
            string nombre = textNombre.Text;

            Usuario usuario = new CN_Usuario().GetByCiAndNombre(ci, nombre);
            infoUsuario.Text = $"CI:{usuario.Ci} Nombre:{usuario.Nombre} {usuario.Apellido} " +
                               $"Cargo: {usuario.NombreCargo.Nombre} Unidada: {usuario.NombreUnidad.Nombre} Puesto De Trabajo: {usuario.NombrePuesto.Nombre}";
            infoUsuario.Font = new Font("Arial", 10, FontStyle.Bold);
        }

        private void FormDotacion_Load(object sender, EventArgs e)
        {
            dtpDotacion.Value = DateTime.Now;
            dtpDotacion.Format = DateTimePickerFormat.Custom;
            dtpDotacion.CustomFormat = "dd/MM/yyyy hh:mm";
            CargarPuestosDeTrabajo();
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

        private void comboBoxPuesto_SelectedIndexChanged(object sender, EventArgs e)
        {
            string puesto = ((OpcionCombo)comboBoxPuesto.SelectedItem).Texto;
            dgvListaDotacion.Rows.Clear();
            List<Producto> listaProductos = new CN_ListaDotacion().GetListProductByPuesto(puesto);
            foreach (Producto item in listaProductos)
            {
                checkList.ValueType = typeof(bool);
                dgvListaDotacion.Rows.Add(item.IdProducto , item.NombreProducto);
                
            }
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            RegistrarDotacion();
            RegistrarDetalleDotacion();
            LimpiarFormDotacion(sender, e);
           
        }
        private void RegistrarDotacion()
        {
            Usuario usuario = new CN_Usuario().GetByCiAndNombre(textCi.Text, textNombre.Text);
            Dotacion dotacion = new Dotacion();
            dotacion.usuario = new Usuario() { IdUsuario = usuario.IdUsuario };
            dotacion.Comentario = textBoxComentario.Text;
            dotacion.FechaDotacion = dtpDotacion.Value;
            new CN_Dotacion().Registrar(dotacion);

        }
        private void RegistrarDetalleDotacion()
        {
           foreach (DataGridViewRow row in dgvListaDotacion.Rows)
            {
                if(row.Cells["checkList"].Value != null && (bool)row.Cells["checkList"].Value)
                {
                    Dotacion dotacion = new CN_Dotacion().GetUltimaDotacion();
                    DetalleDotacion detalle = new DetalleDotacion();
                    detalle.dotacion = dotacion;
                    detalle.producto = new Producto() { IdProducto = (int)row.Cells["idProducto"].Value };
                    detalle.Cantidad = Convert.ToInt32(row.Cells["textboxCantidad"].Value);
                    new CN_DetalleDotacion().Registrar(detalle);
                    ActualizarStockProducto(detalle);
                }
            }
            
        }
        private void ActualizarStockProducto(DetalleDotacion detalle)
        {
            Producto producto = new CN_Producto().GetByID(detalle.producto.IdProducto);
            producto.Cantidad = producto.Cantidad - detalle.Cantidad;
            new CN_Producto().UpdateStock(producto);
        }
        private void LimpiarFormDotacion(object sender, EventArgs e)
        {
            textCi.Text = "";
            textNombre.Text = "";
            infoUsuario.Text = "";
            comboBoxPuesto.Text = "";
            dgvListaDotacion.Rows.Clear();
            textBoxComentario.Text = "";
        }
    }
}
