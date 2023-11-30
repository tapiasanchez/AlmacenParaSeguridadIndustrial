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
    public partial class Report_RCambios : Form
    {
        public Report_RCambios()
        {
            InitializeComponent();
        }

        private void Report_RCambios_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dS_ReporteCambios.SP_GETCAMBIOS' Puede moverla o quitarla según sea necesario.
            this.sP_GETCAMBIOSTableAdapter.Fill(this.dS_ReporteCambios.SP_GETCAMBIOS);

            this.reportViewer1.RefreshReport();
        }
    }
}
