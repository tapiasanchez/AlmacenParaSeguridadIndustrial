using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion.Reportes
{
    public partial class Report_Inventario : Form
    {
        public Report_Inventario()
        {
            InitializeComponent();
        }

        private void Report_Inventario_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            DateTime fechaInicio = dtpInicio.Value;
            DateTime fechaFin = dtpFin.Value;
            this.sP_GETIINVENTARIOTableAdapter.Fill(this.dS_Inventario.SP_GETIINVENTARIO, fechaInicio: fechaInicio, fechaFin: fechaFin);
        }
    }
}
