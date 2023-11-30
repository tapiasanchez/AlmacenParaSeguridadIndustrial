using CapaEntidad;
using CapaNegocio;
using CapaPresentacion.Reportes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FormInventarioPF : Form
    {
        private static DateTime fInicio;
        private static DateTime fFin;
        public FormInventarioPF(DateTime inicio, DateTime fin)
        {
            fInicio = inicio;
            fFin = fin;
            InitializeComponent();
        }

        private void FormInventarioPF_Load(object sender, EventArgs e)
        {
            dgvInventario.Rows.Clear();
            List<Inventario> inventario = new CN_Inventario().GETInventario(fInicio.Date, fFin.Date);
            foreach (Inventario item in inventario)
            {
                dgvInventario.Rows.Add(item.Producto.Codigo, item.Producto.NombreProducto, item.Producto.Talla.Nombre, item.Producto.Unidad, item.Producto.Color, item.Ingreso, item.Salida, item.Producto.Cantidad);

            }
        }

        private void BtnImInventario_Click(object sender, EventArgs e)
        {
            Report_Inventario report = new Report_Inventario();
            report.dtpInicio.Value = fInicio.Date;
            report.dtpFin.Value = fFin.Date;
            report.ShowDialog();
        }

        private void IconButton5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
