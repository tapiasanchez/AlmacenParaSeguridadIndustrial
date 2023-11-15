using System;
using System.Collections.Generic;
using System.Windows.Forms;
using CapaEntidad;
using CapaNegocio;
using CapaPresentacion.Utilidades;

namespace CapaPresentacion
{
    public partial class FormModalUsuario : Form
    {
        private readonly Usuario usuario = new Usuario();
        public FormModalUsuario()
        {
            InitializeComponent();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {   
            usuario.Item = textItem.Text;
            usuario.Ci = textCi.Text;
            usuario.Nombre = textNombre.Text;   
            usuario.Apellido = textApellido.Text;
            usuario.Observaciones = textObservaciones.Text;
            usuario.NombreCargo = new Cargo() {IdCargo =  Convert.ToInt32(((OpcionCombo)comboBoxCargo.SelectedItem).Valor) };
            usuario.NombreUnidad = new Unidad() {  IdUnidad = Convert.ToInt32(((OpcionCombo)comboBoxUnidad.SelectedItem).Valor) };
            usuario.NombrePuesto = new PuestoDeTrabajo() { IdPuestoDeTrabajo = Convert.ToInt32(((OpcionCombo)comboBoxPuestoDeTrabajo.SelectedItem).Valor) };

            RegistrarUsuario(usuario);
            this.Close();
        }

        private void RegistrarUsuario(Usuario usuario){
            _ = new CN_Usuario().Registrar(usuario, out _);

        }
       
        private void FormModalUsuario_Load(object sender, EventArgs e)
        {
            
            CargarCargos();
            CargarUnidades();
            CargarPuestosDeTrabajo();
            if (!string.IsNullOrEmpty(textId.Text))
            {
                SetCargoToUser();
                SetUnidadToUser();
                SetPuestoToUser();
                btnEditar.Enabled = true;
                btnGuardar.Enabled = false;

            }
            else
            {
                btnEditar.Enabled = false;
                btnGuardar.Enabled = true;
            }
        }

        public void CargarCargos()
        {
            List<Cargo> cargos = new CN_Cargo().Listar();
            foreach(Cargo cargo in cargos)
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

        }
        private void CargarUnidades()
        {
            List<Unidad> unidades = new CN_Unidad().Listar();
            foreach (Unidad unidad in unidades)
            {
                comboBoxUnidad.Items.Add(new OpcionCombo()
                {
                    Texto = unidad.Nombre,
                    Valor = unidad.IdUnidad
                });
            }
            comboBoxUnidad.DisplayMember = "Texto";
            comboBoxUnidad.ValueMember = "Valor";
            comboBoxUnidad.SelectedIndex = 0;
        }

        private void CargarPuestosDeTrabajo()
        {
            List<PuestoDeTrabajo> puestoDeTrabajos = new CN_PuestoDeTrabajo().Listar();
            foreach (PuestoDeTrabajo item in puestoDeTrabajos)
            {
                comboBoxPuestoDeTrabajo.Items.Add(new OpcionCombo()
                {
                    Texto = item.Nombre,
                    Valor = item.IdPuestoDeTrabajo
                });
            }
            comboBoxPuestoDeTrabajo.DisplayMember = "Texto";
            comboBoxPuestoDeTrabajo.ValueMember = "Valor";
            comboBoxPuestoDeTrabajo.SelectedIndex = 0;
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void SetCargoToUser()
        {
            foreach (OpcionCombo item in comboBoxCargo.Items)
            {
                if (item.Texto == textCargo.Text)
                {
                    comboBoxCargo.SelectedItem = item;
                    break;
                }
            }
        }
        private void SetUnidadToUser()
        {
            foreach (OpcionCombo item in comboBoxUnidad.Items)
            {
               if (item.Texto == textUnidad.Text)
               {
                    comboBoxUnidad.SelectedItem = item;
                    break;
               }
            }
        }
        private void SetPuestoToUser()
        {
            foreach (OpcionCombo item in comboBoxPuestoDeTrabajo.Items)
            {
                if (item.Texto == textPuesto.Text)
                {
                    comboBoxPuestoDeTrabajo.SelectedItem = item;
                    break;
                }
            }
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textId.Text))
            {

                usuario.IdUsuario = Convert.ToInt32(textId.Text);
            }
            usuario.Item = textItem.Text;
            usuario.Ci = textCi.Text;
            usuario.Nombre = textNombre.Text;
            usuario.Apellido = textApellido.Text;
            usuario.Observaciones = textObservaciones.Text;
            usuario.NombreCargo = new Cargo() { IdCargo = Convert.ToInt32(((OpcionCombo)comboBoxCargo.SelectedItem).Valor) };
            usuario.NombreUnidad = new Unidad() { IdUnidad = Convert.ToInt32(((OpcionCombo)comboBoxUnidad.SelectedItem).Valor) };
            usuario.NombrePuesto = new PuestoDeTrabajo() { IdPuestoDeTrabajo = Convert.ToInt32(((OpcionCombo)comboBoxPuestoDeTrabajo.SelectedItem).Valor) };
            new CN_Usuario().Update(usuario);
            this.Close();
        }
    }
}
