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
    public partial class Report_CambioDotacion : Form
    {
        public Report_CambioDotacion()
        {
            InitializeComponent();
        }

        private void Report_CambioDotacion_Load(object sender, EventArgs e)
        {
            this.sP_GETCAMBIODEDOTACIONTableAdapter.Fill(this.dS_CambioDeDotacion.SP_GETCAMBIODEDOTACION, idUsuario:Convert.ToInt32(textBoxIdUsuario.Text));
            this.reportViewer1.RefreshReport();
        }
    }
}
