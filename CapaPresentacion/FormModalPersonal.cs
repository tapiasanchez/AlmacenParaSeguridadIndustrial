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
    public partial class FormModalPersonal : Form
    {
        public FormModalPersonal()
        {
            InitializeComponent();
        }

        private void BtnImprimirRep_Click(object sender, EventArgs e)
        {
            Report_RPersonal report = new Report_RPersonal();
            report.textBoxCI.Text = textBoxCI.Text;
            report.ShowDialog();
            textBoxCI.Text = "";
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
