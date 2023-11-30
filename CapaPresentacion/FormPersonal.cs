using CapaEntidad;
using CapaNegocio;
using CapaPresentacion.Utilidades;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FormPersonal : Form
    {
        public FormPersonal()
        {
            InitializeComponent();
        }

        private void FormPersonal_Load(object sender, EventArgs e)
        {
            List<Cargo> cargos = new CN_Cargo().Listar();
            foreach (Cargo cargo in cargos)
            {
                comboBoxCargo.Items.Add(new OpcionCombo()
                {
                    Texto = cargo.Nombre,
                    Valor = cargo.IdCargo
                });
            }
            comboBoxCargo.DisplayMember = "Texto";
            comboBoxCargo.ValueMember = "Valor";
            comboBoxCargo.SelectedIndex = 0;
            dGVData.Rows.Clear();
            List<Personal> listaUsuarios = new CN_Personal().Listar();
            foreach (Personal item in listaUsuarios)
            {
                dGVData.Rows.Add(item.NombreCompleto, item.Ci,item.UserName, item.Contrasena, item.Cargo.Nombre);
            }
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            Personal persona = new Personal()
            {
                NombreCompleto = textNombreCompleto.Text,
                Ci = textCI.Text,
                UserName = textUserName.Text,
                Contrasena = textPassword.Text,
                Cargo = new Cargo() { IdCargo = Convert.ToInt32(((OpcionCombo)comboBoxCargo.SelectedItem).Valor) }

            };
            new CN_Personal().Registrar(persona);
            Limpiar();
            FormPersonal_Load(sender, e);
        }
        private void Limpiar()
        {
            textNombreCompleto.Text = "";
            textCI.Text = "";
            textUserName.Text = "";
            textPassword.Text = "";
            comboBoxCargo.SelectedIndex = 0;
        }
    }
}
