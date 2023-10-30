using System;
using System.Windows.Forms;

namespace CapaPresentacion.Reportes
{
    public partial class Report_DotacionYCambio : Form
    {
        public Report_DotacionYCambio()
        {
            InitializeComponent();
        }

        private void Report_DotacionYCambio_Load(object sender, EventArgs e)
        {
            this.sP_GETDOTACIONPORUSUARIOTableAdapter.Fill(this.dS_DotacionYCambio.SP_GETDOTACIONPORUSUARIO, idUsuario: Convert.ToInt32(textBoxIdUsuario.Text));
            this.sP_GETCAMBIODEDOTACIONTableAdapter.Fill(this.dS_DotacionYCambio.SP_GETCAMBIODEDOTACION, idUsuario: Convert.ToInt32(textBoxIdUsuario.Text));
            
            this.reportViewer1.RefreshReport();
        }
    }
}
