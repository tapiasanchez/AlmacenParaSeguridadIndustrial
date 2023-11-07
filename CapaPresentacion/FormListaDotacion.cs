using System;
using System.Collections.Generic;
using System.Windows.Forms;
using CapaEntidad;
using CapaNegocio;
using CapaPresentacion.Utilidades;

namespace CapaPresentacion
{
    public partial class FormListaDotacion : Form
    {
        public FormListaDotacion()
        {
            InitializeComponent();
        }

        private void FormListaDotacion_Load(object sender, EventArgs e)
        {
            CargarPuestoDeTrabajo();
            CargarProductos();
        }
        private void CargarPuestoDeTrabajo()
        {
            comboBoxPuesto.Items.Clear();
            comboBoxList.Items.Clear();
            List<PuestoDeTrabajo> puestoDeTrabajos = new CN_PuestoDeTrabajo().Listar();
            foreach (PuestoDeTrabajo item in puestoDeTrabajos)
            {
                comboBoxPuesto.Items.Add(new OpcionCombo()
                {
                    Texto = item.Nombre,
                    Valor = item.IdPuestoDeTrabajo
                });
                comboBoxPuesto.DisplayMember = "Texto";
                comboBoxPuesto.ValueMember = "Valor";
                comboBoxPuesto.SelectedIndex = 0;
                comboBoxList.Items.Add(new OpcionCombo()
                {
                    Texto = item.Nombre,
                    Valor = item.IdPuestoDeTrabajo
                });
                comboBoxList.DisplayMember = "Texto";
                comboBoxList.ValueMember = "Valor";
            }
        }
        private void CargarProductos()
        {
            comboBoxProductos.Items.Clear();
            List<Producto> productos = new CN_Producto().Listar();
            foreach(Producto item in productos)
            {
                comboBoxProductos.Items.Add(new OpcionCombo()
                {
                    Texto = item.NombreProducto,
                    Valor = item.IdProducto
                });
                comboBoxProductos.DisplayMember = "Texto";
                comboBoxProductos.ValueMember = "Valor";
                comboBoxProductos.SelectedIndex = 0;

            }
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            ListaDotacion listaDeDotacion = new ListaDotacion
            {
                NombreProducto = new Producto() { IdProducto = Convert.ToInt32(((OpcionCombo)comboBoxProductos.SelectedItem).Valor) },
                NombrePuesto = new PuestoDeTrabajo() { IdPuestoDeTrabajo = Convert.ToInt32(((OpcionCombo)comboBoxPuesto.SelectedItem).Valor) }
            };

            RegistrarListaDotacion(listaDeDotacion);
            FormListaDotacion_Load(sender,e);

        }

        private void RegistrarListaDotacion(ListaDotacion lista)
        {
            new CN_ListaDotacion().Registrar(lista);
        }
        private void ComboBoxList_SelectedIndexChanged(object sender, EventArgs e)
        {
            string puesto = ((OpcionCombo)comboBoxList.SelectedItem).Texto;
            dgvListaPorPuesto.Rows.Clear();
            List<Producto> listaProductos = new CN_ListaDotacion().GetListProductByPuesto(puesto);
            foreach (Producto item in listaProductos)
            {
                dgvListaPorPuesto.Rows.Add(item.IdProducto, item.NombreProducto);
            }
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            if(dgvListaPorPuesto.SelectedRows.Count > 0)
            {
                DataGridViewCell celdaSeleccionada = dgvListaPorPuesto.SelectedCells[0];

                
                int idProducto = Convert.ToInt32(celdaSeleccionada.Value);
                int puesto = Convert.ToInt32(((OpcionCombo)comboBoxList.SelectedItem).Valor);
                new CN_ListaDotacion().Eliminar(idProducto, puesto);
            }

        }
    }
}
