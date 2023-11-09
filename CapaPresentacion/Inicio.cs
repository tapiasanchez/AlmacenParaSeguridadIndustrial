using System;
using System.Drawing;
using System.Windows.Forms;
using CapaPresentacion.Reportes;
using FontAwesome.Sharp;

namespace CapaPresentacion
{
    public partial class Inicio : Form
    {
        private static IconMenuItem MenuActivo = null;
        private static Form FormulariActivo = null;

        public Inicio()
        {
            InitializeComponent();
        }
        private void AbrirFormulario(IconMenuItem menu, Form formulario)
        {
            if (MenuActivo != null)
            {
                MenuActivo.BackColor = Color.White;
            }

            menu.BackColor = Color.Silver;
            MenuActivo = menu;

            FormulariActivo?.Close();
            FormulariActivo = formulario;
            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;
            formulario.BackColor = Color.SteelBlue;

            contenedor.Controls.Add(formulario);
            formulario.Show();
        }

        private void Usuarios_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender,new FormUsuario());

        }

        private void SubMenuCargo_Click(object sender, EventArgs e)
        {
            AbrirFormulario(menuAjustes, new FormCargo());
        }

        private void SubMenuUnidad_Click(object sender, EventArgs e)
        {
            AbrirFormulario(menuAjustes, new FormUnidad());
        }

        private void SubMenuPuestoDeTrabajo_Click(object sender, EventArgs e)
        {
            AbrirFormulario(menuAjustes, new FormPuestoDeTrabajo());
        }

        private void SubMenuTalla_Click(object sender, EventArgs e)
        {
            AbrirFormulario(subMenuTalla, new FormTallas());
        }

        private void IconMenuItem1_Click(object sender, EventArgs e)
        {
            AbrirFormulario(subMenuRegistro, new FormProducto());
        }
        private void SubMenuListaDotacion_Click(object sender, EventArgs e)
        {
            AbrirFormulario(subMenuListaDotacion, new FormListaDotacion());
        }

        private void SubMenuDotacion_Click(object sender, EventArgs e)
        {
            AbrirFormulario(subMenuDotacion, new FormDotacion());
        }

        private void MenuCambio_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new FormCambioDotacion());
        }

        private void SubMenuReporteDotacion_Click(object sender, EventArgs e)
        {
            AbrirFormulario(subMenuReporteDotacion, new FormReportePorPersona());
        }

        private void SubMenuFechaDotacion_Click(object sender, EventArgs e)
        {
            AbrirFormulario(subMenuFechaDotacion, new FormDeFechas());
        }

        private void IconMenuItem1_Click_1(object sender, EventArgs e)
        {
            AbrirFormulario(subMenuActualizarStock, new FormActualizarStock());

        }
    }
}
