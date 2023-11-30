using CapaPresentacion.Reportes;
using System;
using System.Windows.Forms;
using CapaEntidad;
using CapaNegocio;
using System.Collections.Generic;
using FontAwesome.Sharp;
using System.Drawing;

namespace CapaPresentacion
{
    public partial class FormDeFechas : Form
    {
        private static IconButton MenuActivo = null;
        private static Form FormulariActivo = null;
        public FormDeFechas()
        {
            InitializeComponent();
        }

        private void IconButton2_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconButton)sender, new FormCambiosPF(dTPInicio.Value, dTPFin.Value));
            
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

        private void IconButton1_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconButton)sender, new FormDotacionPF(dTPInicio.Value, dTPFin.Value));
            
        }

        private void IconButton3_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconButton)sender, new FormInventarioPF(dTPInicio.Value, dTPFin.Value));
            
        }
        private void AbrirFormulario(IconButton menu, Form formulario)
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

    }
}
