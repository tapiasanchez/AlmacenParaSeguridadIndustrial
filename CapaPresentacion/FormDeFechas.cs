using CapaPresentacion.Reportes;
using System;
using System.Windows.Forms;
using System.Globalization;

namespace CapaPresentacion
{
    public partial class FormDeFechas : Form
    {
        public FormDeFechas()
        {
            InitializeComponent();
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            Report_FechaCambios report = new Report_FechaCambios();
            report.dtpInicio.Value = dTPInicio.Value;
            report.dtpFin.Value = dTPFin.Value;
            report.ShowDialog();
        }

        private void FormDeFechas_Load(object sender, EventArgs e)
        {
            dTPInicio.Value = DateTime.Now;
            dTPInicio.Format = DateTimePickerFormat.Custom;
            dTPInicio.CustomFormat = "yyyy-MM-dd";
            dTPFin.Value = DateTime.Now;
            dTPFin.Format = DateTimePickerFormat.Custom;
            dTPFin.CustomFormat = "yyyy-MM-dd";

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            Report_FechaDotacion report = new Report_FechaDotacion();
            report.dtpInicio.Value = dTPInicio.Value;
            report.dtpFin.Value = dTPFin.Value;
            report.ShowDialog();
        }
    }
}
