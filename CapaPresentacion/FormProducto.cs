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
        private readonly Inventario inventario = new Inventario();
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
            LoadComboBoxTalla();
            CargarDGVProducto();
            HabilitarBoton();
        }
        private void HabilitarBoton()
        {
            if (string.IsNullOrEmpty(textBoxId.Text))
            {
                btnEditar.Enabled = false;
                btnGuardar.Enabled = true;
            }
            else
            {
                btnEditar.Enabled = true;
                btnGuardar.Enabled = false;
            }
        }

        private void LoadComboBoxTalla()
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
        private void CargarDGVProducto()
        {
            dgvProducto.Rows.Clear();
            List<Producto> listaProducto = cn_Producto.Listar();
            foreach (Producto item in listaProducto)
            {
                dgvProducto.Rows.Add(item.IdProducto,item.Codigo, item.NombreProducto, item.Color, item.Unidad, item.Descripcion, item.Cantidad, item.Talla.Nombre);
            }
        }
        private Producto CargarDatos()
        {
            if (!string.IsNullOrEmpty(textBoxId.Text))
            {

                producto.IdProducto = Convert.ToInt32(textBoxId.Text);
            }
            producto.Codigo = textCodigo.Text;
            producto.NombreProducto = textProducto.Text;
            producto.Descripcion = textDescripcion.Text;
            producto.Color = textColor.Text;
            producto.Unidad = textUnidad.Text;
            producto.Cantidad = Convert.ToInt32(textCantidad.Text);
            producto.Talla = new Talla() { IdTalla = Convert.ToInt32(((OpcionCombo)comboBoxTalla.SelectedItem).Valor) };
            producto.Fecha = dtpRegistro.Value;
            return producto;
        }

        private void IconButton1_Click(object sender, EventArgs e)
        {
            producto = CargarDatos();
            cn_Producto.Registrar(producto);
            CargarDGVProducto();
            CargarInventario();
            LimpiarText();
        }
        private void CargarInventario()
        {
            producto = cn_Producto.GetProducto();
            inventario.Ingreso = Convert.ToInt32(textCantidad.Text);
            inventario.Fecha = dtpRegistro.Value;
            inventario.Producto = producto;
            cn_Inventario.Registrar(inventario);
        }
        private void LimpiarText()
        {
            textBoxId.Text = "";
            textCodigo.Text = "";
            textProducto.Text = "";
            textDescripcion.Text = "";
            textCantidad.Text = "";
            textColor.Text = "";
            textUnidad.Text = "";
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
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
 
        private void Seleccionar(object sender, DataGridViewCellMouseEventArgs e)
        {
            int indice = e.RowIndex;
            textBoxId.Text = dgvProducto.Rows[indice].Cells[0].Value.ToString();
            textCodigo.Text = dgvProducto.Rows[indice].Cells[1].Value.ToString();
            textProducto.Text = dgvProducto.Rows[indice].Cells[2].Value.ToString(); 
            textDescripcion.Text = dgvProducto.Rows[indice].Cells[5].Value.ToString(); 
            textCantidad.Text = dgvProducto.Rows[indice].Cells[6].Value.ToString(); 
            textColor.Text = dgvProducto.Rows[indice].Cells[3].Value.ToString(); 
            textUnidad.Text = dgvProducto.Rows[indice].Cells[4].Value.ToString();
            foreach (OpcionCombo item in comboBoxTalla.Items)
            {
                if (item.Texto == dgvProducto.Rows[indice].Cells[7].Value.ToString())
                {
                    comboBoxTalla.SelectedIndex = comboBoxTalla.Items.IndexOf(item);
                    break;
                }
            }
            HabilitarBoton();
            CargarDatos();

        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            string result = new CN_DetalleDotacion().VerificarProducto(Convert.ToInt32(textBoxId.Text));
            if(result.Equals("El ID existe"))
            {
                MessageBox.Show("Lo sentios pero no se pueden realizar los cambios debido a que "+ result +" esto nos indica que ya se realizaron registros con el producto", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                producto = CargarDatos();
                cn_Producto.Actualizar(producto);
                LimpiarText();
                CargarDGVProducto();
            }
        }
    }
}
