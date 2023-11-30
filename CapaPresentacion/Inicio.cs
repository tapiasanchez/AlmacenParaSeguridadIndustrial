using System;
using System.Drawing;
using System.Windows.Forms;
using CapaPresentacion.Reportes;
using FontAwesome.Sharp;
using CapaEntidad;
using System.Collections.Generic;
using CapaNegocio;
using System.Linq;

namespace CapaPresentacion
{
    public partial class Inicio : Form
    {
        private static IconMenuItem MenuActivo = null;
        private static Form FormulariActivo = null;
        private static Personal usuarioActual;

        public Inicio(Personal objUsuario)
        {
            usuarioActual = objUsuario;
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
            AbrirFormulario(menuAjustes, new FormCargo(menu));
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
            AbrirFormulario(subMenuDotacion, new FormDotacion(usuarioActual));
        }

        private void MenuCambio_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new FormCambioDotacion(usuarioActual));
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

        private void Inicio_Load(object sender, EventArgs e)
        {
            List<Permiso> permisos = new CN_Permiso().Listar(usuarioActual.IdPersona);
            foreach(IconMenuItem iconMenu in menu.Items)
            {
                bool encontrado = permisos.Any(m => m.NombreMenu ==  iconMenu.Name);
                if(encontrado == false)
                {
                    iconMenu.Visible = false;
                }
            }
            lblUsuario.Text = usuarioActual.NombreCompleto.ToString();
        }

        private void SubMenuRDotacion_Click(object sender, EventArgs e)
        {
            Report_RDotacion report = new Report_RDotacion();
            report.ShowDialog();
        }

        private void SubMenuRCambio_Click(object sender, EventArgs e)
        {
            Report_RCambios report = new Report_RCambios();
            report.ShowDialog();
        }

        private void MenuPersonal_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new FormPersonal());
        }

        private void SubMenuRPersonal_Click(object sender, EventArgs e)
        {
            FormModalPersonal personalReport = new FormModalPersonal();
            personalReport.ShowDialog();
        }
    }
}
