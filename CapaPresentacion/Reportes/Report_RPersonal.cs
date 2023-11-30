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
    public partial class Report_RPersonal : Form
    {
        public Report_RPersonal()
        {
            InitializeComponent();
        }

        private void Report_RPersonal_Load(object sender, EventArgs e)
        {
            this.sP_GETDOTACIONESPORPERSONALTableAdapter.Fill(this.dS_ReportePersonal.SP_GETDOTACIONESPORPERSONAL, textBoxCI.Text);
            this.sP_GETCAMBIOSPORPERSONALTableAdapter.Fill(this.dS_ReportePersonal.SP_GETCAMBIOSPORPERSONAL, textBoxCI.Text);
            this.reportViewer1.RefreshReport();
        }
    }
}
