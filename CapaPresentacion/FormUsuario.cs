using System;
using System.Collections.Generic;
using System.Windows.Forms;
using CapaNegocio;
using CapaEntidad;
using SpreadsheetLight;
using CapaPresentacion.Utilidades;

namespace CapaPresentacion
{
    public partial class FormUsuario : Form
    {
        public FormUsuario()
        {
            InitializeComponent();
        }

        private void FormUsuario_Load(object sender, EventArgs e)
        {
            foreach(DataGridViewColumn columna in dGVData.Columns)
            {
                comboBoxBuscar.Items.Add(new OpcionCombo() { Valor = columna.Name, Texto = columna.HeaderText});
            }
            comboBoxBuscar.DisplayMember = "Texto";
            comboBoxBuscar.ValueMember = "Value";
            comboBoxBuscar.SelectedIndex = 0;


            dGVData.Rows.Clear();
            List<Usuario> listaUsuarios = new CN_Usuario().Listar();
            foreach (Usuario item in listaUsuarios)
            {
                dGVData.Rows.Add(item.Item, item.Ci, item.Nombre, item.Apellido, item.NombreCargo.Nombre ,item.NombreUnidad.Nombre,item.NombrePuesto.Nombre);
            }

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            FormModalUsuario formModalUsuario = new FormModalUsuario();
            formModalUsuario.ShowDialog();
            FormUsuario_Load(sender, e);

        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            List<Usuario> listaPersonas = leerDatosDeExel();
            foreach(Usuario item in listaPersonas)
            {
                string mensaje = String.Empty;
                item.NombreCargo.IdCargo = new CN_Cargo().GetId(item.NombreCargo.Nombre).IdCargo;
                item.NombreUnidad.IdUnidad = new CN_Unidad().GetUnidad(item.NombreUnidad.Nombre).IdUnidad;
                item.NombrePuesto.IdPuestoDeTrabajo = new CN_PuestoDeTrabajo().GetPuestoDeTrabajo(item.NombrePuesto.Nombre).IdPuestoDeTrabajo;
                int idUsuarioGenerado = new CN_Usuario().Registrar(item, out mensaje);
               
            }
            FormUsuario_Load(sender, e);
        }
        public List<Usuario> leerDatosDeExel() {
            string rutaArchivo = string.Empty;
            OpenFileDialog openFileDialog = new OpenFileDialog();

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                rutaArchivo = openFileDialog.FileName;
                SLDocument documento = new SLDocument(rutaArchivo);
                int indiceRow = 2;
                List<Usuario> listUsuario = new List<Usuario>();

                while (!string.IsNullOrEmpty(documento.GetCellValueAsString(indiceRow, 1)))
                {
                    Usuario persona = new Usuario();
                    persona.Item = documento.GetCellValueAsString(indiceRow, 1);
                    persona.Ci = documento.GetCellValueAsString(indiceRow, 2);
                    persona.Nombre = documento.GetCellValueAsString(indiceRow, 3);
                    persona.Apellido = documento.GetCellValueAsString(indiceRow, 4);
                    persona.NombreCargo = new Cargo() { Nombre = documento.GetCellValueAsString(indiceRow, 5)};
                    persona.NombreUnidad = new Unidad() { Nombre = documento.GetCellValueAsString(indiceRow, 6) };
                    persona.NombrePuesto = new PuestoDeTrabajo() { Nombre = documento.GetCellValueAsString(indiceRow, 7) };

                    listUsuario.Add(persona);
                    indiceRow++;
                }
                return listUsuario;
            }
            return null;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dGVData.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Value != null && cell.Value.ToString().ToLower().Contains(textBuscar.Text))
                    {
                        row.Selected = true;
                        textBuscar.Text = "";
                        return; 
                    }
                }
            }
        }
    }
}
