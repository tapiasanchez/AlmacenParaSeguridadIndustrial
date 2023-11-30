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
    public partial class Report_RDotacion : Form
    {
        public Report_RDotacion()
        {
            InitializeComponent();
        }

        private void Report_RDotacion_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dS_ReporteDotacion.SP_GETDOTACIONES' Puede moverla o quitarla según sea necesario.
            this.sP_GETDOTACIONESTableAdapter.Fill(this.dS_ReporteDotacion.SP_GETDOTACIONES);

            this.reportViewer1.RefreshReport();
        }
    }
}
