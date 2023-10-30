using System;
using System.Windows.Forms;

namespace CapaPresentacion.Reportes
{
    public partial class Report_FechaCambios : Form
    {
        public Report_FechaCambios()
        {
            InitializeComponent();
        }

        private void Report_FechaCambios_Load(object sender, EventArgs e)
        {
            dtpInicio.Format = DateTimePickerFormat.Custom;
            dtpInicio.CustomFormat = "yyyy-MM-dd";
            dtpFin.Format = DateTimePickerFormat.Custom;
            dtpFin.CustomFormat = "yyyy-MM-dd";
            
            DateTime fechaInicio = dtpInicio.Value;
            DateTime fechaFin = dtpFin.Value;
            this.sP_GETCAMBIODOTACIONPORFECHASTableAdapter.Fill(this.dS_FechaDotacion.SP_GETCAMBIODOTACIONPORFECHAS, FechaInicio: fechaInicio, FechaFin: fechaFin);
            this.reportViewer1.RefreshReport();
        }
    }
}
