using CapaEntidad;
using CapaNegocio;
using CapaPresentacion.Utilidades;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FormActualizarStock : Form
    {
        public FormActualizarStock()
        {
            InitializeComponent();
        }

        private void FormActualizarStock_Load(object sender, EventArgs e)
        {
            dtpFecha.Value = DateTime.Now;
            dtpFecha.Format = DateTimePickerFormat.Custom;
            dtpFecha.CustomFormat = "dd/MM/yyyy hh:mm";
            CargarProductos();
        }
        private void CargarProductos()
        {
            comboBoxProducto.Items.Clear();
            List<Producto> productos = new CN_Producto().Listar();
            foreach (Producto item in productos)
            {
                comboBoxProducto.Items.Add(new OpcionCombo()
                {
                    Texto = item.NombreProducto,
                    Valor = item.IdProducto
                });
                comboBoxProducto.DisplayMember = "Texto";
                comboBoxProducto.ValueMember = "Valor";
                comboBoxProducto.SelectedIndex = 0;

            }

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            ActualizarStock();
            RegistarInventario();
            LimpiarForm();
        }
        private void ActualizarStock()
        {
            Producto producto = new CN_Producto().GetByID(Convert.ToInt32(((OpcionCombo)comboBoxProducto.SelectedItem).Valor));
            producto.Cantidad += Convert.ToInt32(textBoxCantidad.Text);
            new CN_Producto().UpdateStock(producto);
        }
        private void RegistarInventario()
        {
            Inventario inventario = new Inventario
            {
                Producto = new Producto() { IdProducto = Convert.ToInt32(((OpcionCombo)comboBoxProducto.SelectedItem).Valor) },
                Salida = Convert.ToInt32(textBoxCantidad.Text),
                Fecha = dtpFecha.Value
            };
            new CN_Inventario().Registrar(inventario);
        }
        private void LimpiarForm()
        {
            comboBoxProducto.SelectedIndex = 0;
            textBoxCantidad.Text = "";
        }
    }
}
