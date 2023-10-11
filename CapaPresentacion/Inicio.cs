﻿using System;
using System.Drawing;
using System.Windows.Forms;
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

            if(FormulariActivo != null)
            {
                FormulariActivo.Close();
            }
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

        private void subMenuCargo_Click(object sender, EventArgs e)
        {
            AbrirFormulario(menuAjustes, new FormCargo());
        }

        private void subMenuUnidad_Click(object sender, EventArgs e)
        {
            AbrirFormulario(menuAjustes, new FormUnidad());
        }

        private void subMenuPuestoDeTrabajo_Click(object sender, EventArgs e)
        {
            AbrirFormulario(menuAjustes, new FormPuestoDeTrabajo());
        }

        private void subMenuTalla_Click(object sender, EventArgs e)
        {
            AbrirFormulario(subMenuTalla, new FormTallas());
        }

        private void iconMenuItem1_Click(object sender, EventArgs e)
        {
            AbrirFormulario(subMenuRegistro, new FormProducto());
        }
        private void subMenuListaDotacion_Click(object sender, EventArgs e)
        {
            AbrirFormulario(subMenuListaDotacion, new FormListaDotacion());
        }

        private void subMenuDotacion_Click(object sender, EventArgs e)
        {
            AbrirFormulario(subMenuDotacion, new FormDotacion());
        }
    }
}
