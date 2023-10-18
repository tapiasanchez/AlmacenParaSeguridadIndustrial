
using System;
using System.Windows.Forms;

namespace CapaPresentacion.Reportes
{
    public partial class Report_Dotacion : Form
    {
        public Report_Dotacion()
        {
            InitializeComponent();
        }

        private void Report_Dotacion_Load(object sender, EventArgs e)
        {
            this.sP_GETULTIMADOTACIONTableAdapter.Fill(this.dS_Dotacion.SP_GETULTIMADOTACION);

           
            if (this.dS_Dotacion.SP_GETULTIMADOTACION.Rows.Count > 0)
            {
                int idDotacion = this.dS_Dotacion.SP_GETULTIMADOTACION[0].IDDotacion;
                textBoxIdDotacion.Text = idDotacion.ToString();
            }
            else
            {
                textBoxIdDotacion.Text = "No hay datos disponibles";
            }

            this.sP_GETLISTADOTACIONTableAdapter.Fill(this.dS_Dotacion.SP_GETLISTADOTACION, idDotacion: Convert.ToInt32(textBoxIdDotacion.Text));
            this.reportViewer1.RefreshReport();
        }
    }
}
