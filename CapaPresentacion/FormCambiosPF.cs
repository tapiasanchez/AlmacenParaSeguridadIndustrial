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
    public partial class FormCambiosPF : Form
    {
        private static DateTime fInicio;
        private static DateTime fFin;
        public FormCambiosPF(DateTime inicio, DateTime fin)
        {
            fInicio = inicio;
            fFin = fin;
            InitializeComponent();
        }

        private void FormCambiosPF_Load(object sender, EventArgs e)
        {
            dgvCambios.Rows.Clear();
            List<CambioDotacion> inventario = new CN_CambioDeDotacion().GetCambios(fInicio.Date, fFin.Date);
            foreach (CambioDotacion item in inventario)
            {
                dgvCambios.Rows.Add(item.Producto.Codigo, item.Producto.NombreProducto, item.Producto.Talla.Nombre, item.Producto.Unidad, item.Producto.Color, item.Producto.Cantidad, item.Cantidad);

            }
        }

        private void BtnImCambios_Click(object sender, EventArgs e)
        {
            Report_FechaCambios report = new Report_FechaCambios();
            report.dtpInicio.Value = fInicio.Date;
            report.dtpFin.Value = fFin.Date;
            report.ShowDialog();
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
