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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Inicio formInicio = new Inicio();
            formInicio.Show();
            this.Hide();
            //formInicio.FormClosing += Form_Closing;
        }
        //private void Form_Closing(object sender, FormClosingEventArgs e)
        //{
        //    textUserName.Text = string.Empty;
        //    textBoxPassword.Text = string.Empty;
        //    this.Show();
        //}

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
