using CapaEntidad;
using CapaNegocio;
using CapaPresentacion.Utilidades;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FormProducto : Form
    {
        private Producto producto = new Producto();
        private Inventario inventario = new Inventario();
        public CN_Producto cn_Producto = new CN_Producto();
        public CN_Inventario cn_Inventario = new CN_Inventario();
        public FormProducto()
        {
            InitializeComponent();
        }

        private void FormProducto_Load(object sender, EventArgs e)
        {
            foreach (DataGridViewColumn columna in dgvProducto.Columns)
            {
                comboBoxBuscar.Items.Add(new OpcionCombo() { Valor = columna.Name, Texto = columna.HeaderText });
            }
            comboBoxBuscar.DisplayMember = "Texto";
            comboBoxBuscar.ValueMember = "Value";
            comboBoxBuscar.SelectedIndex = 0;

            dtpRegistro.Value = DateTime.Now;
            dtpRegistro.Format = DateTimePickerFormat.Custom;
            dtpRegistro.CustomFormat = "dd/MM/yyyy hh:mm";
            loadComboBoxTalla();
            cargarDGVProducto();
        }

        private void loadComboBoxTalla()
        {
            List<Talla> tallas = new CN_Talla().Listar();
            foreach (Talla talla in tallas)
            {
                comboBoxTalla.Items.Add(new OpcionCombo()
                {
                    Texto = talla.Nombre,
                    Valor = talla.IdTalla
                });
                comboBoxTalla.DisplayMember = "Texto";
                comboBoxTalla.ValueMember = "Valor";
                comboBoxTalla.SelectedIndex = 0;
            }
        }
        private void cargarDGVProducto()
        {
            dgvProducto.Rows.Clear();
            List<Producto> listaProducto = cn_Producto.Listar();
            foreach (Producto item in listaProducto)
            {
                dgvProducto.Rows.Add(item.Codigo, item.NombreProducto, item.Color, item.Unidad, item.Descripcion, item.Cantidad, item.Talla.Nombre);
            }
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            producto.Codigo = textCodigo.Text;
            producto.NombreProducto = textProducto.Text;
            producto.Descripcion = textDescripcion.Text;
            producto.Color = textColor.Text;
            producto.Unidad = textUnidad.Text;
            producto.Cantidad = Convert.ToInt32(textCantidad.Text);
            producto.Talla = new Talla() { IdTalla = Convert.ToInt32(((OpcionCombo)comboBoxTalla.SelectedItem).Valor) };
            producto.Fecha = dtpRegistro.Value;
            cn_Producto.Registrar(producto);
            cargarDGVProducto();
            producto = cn_Producto.GetProducto();
            inventario.Ingreso = Convert.ToInt32(textCantidad.Text);
            inventario.Fecha = dtpRegistro.Value;
            inventario.Producto = producto;
            cn_Inventario.Registrar(inventario);
            limpiarText();
        }
        private void limpiarText()
        {
            textCodigo.Text = "";
            textProducto.Text = "";
            textDescripcion.Text = "";
            textCantidad.Text = "";
            textColor.Text = "";
            textUnidad.Text = "";
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string columFiltro = ((OpcionCombo)comboBoxBuscar.SelectedItem).Valor.ToString();
            if (dgvProducto.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvProducto.Rows)
                {
                    if (row.Cells[columFiltro].Value.ToString().Trim().ToUpper().Contains(textBuscar.Text.Trim().ToUpper()))
                    {
                        row.Visible = true;
                    }
                    else
                    {
                        row.Visible = false;
                    }
                }
            }
            foreach (DataGridViewRow row in dgvProducto.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Value != null && cell.Value.ToString().ToLower().Contains(textBuscar.Text))
                    {
                        row.Selected = true;
                        textBuscar.Text = "";
                        return;
                    }
                }
            }
        }
    }
}
