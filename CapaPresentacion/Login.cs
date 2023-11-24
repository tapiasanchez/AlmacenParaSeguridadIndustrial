using CapaEntidad;
using CapaNegocio;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            Personal persona = new CN_Personal().Listar().Where(
                u => u.Contrasena == textBoxPassword.Text && u.UserName == textBoxUserName.Text).FirstOrDefault();
            if(persona != null)
            {
                Inicio formInicio = new Inicio(persona);
                formInicio.Show();
                this.Hide();
                formInicio.FormClosing += CerrarForm;
                textBoxUserName.Text = "";
                textBoxPassword.Text = "";
            }
            else
            {
                MessageBox.Show("El usuario no se a encontrado","Mensaje",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }
        }
        private void CerrarForm(object sender, FormClosingEventArgs e)
        {
            this.Show();
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
