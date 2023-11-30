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
    public partial class FormDotacionPF : Form
    {
        private static DateTime fInicio;
        private static DateTime fFin;
        public FormDotacionPF(DateTime inicio,DateTime fin)
        {
            fInicio = inicio;
            fFin = fin;
            InitializeComponent();
        }

        private void BtnDotacion_Click(object sender, EventArgs e)
        {
            Report_FechaDotacion report = new Report_FechaDotacion();
            report.dtpInicio.Value = fInicio.Date;
            report.dtpFin.Value = fFin.Date;
            report.ShowDialog();
        }

        private void FormDotacionPrueba_Load(object sender, EventArgs e)
        {
            dgvDotacion.Rows.Clear();
            List<DetalleDotacion> inventario = new CN_DetalleDotacion().GetDotacionesList(fInicio.Date, fFin.Date);
            foreach (DetalleDotacion item in inventario)
            {
                dgvDotacion.Rows.Add(item.Producto.Codigo, item.Producto.NombreProducto, item.Producto.Talla.Nombre, item.Producto.Unidad, item.Producto.Color, item.Producto.Cantidad, item.Cantidad);

            }
        }

        private void IconButton6_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
