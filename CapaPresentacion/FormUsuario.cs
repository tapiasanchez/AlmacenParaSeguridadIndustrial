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
                dGVData.Rows.Add(item.IdUsuario,item.Item, item.Ci, item.Nombre, item.Apellido,item.Observaciones, item.NombreCargo.Nombre ,item.NombreUnidad.Nombre,item.NombrePuesto.Nombre);
            }

        }

        private void BtnRegistrar_Click(object sender, EventArgs e)
        {
            FormModalUsuario formModalUsuario = new FormModalUsuario();
            formModalUsuario.ShowDialog();
            FormUsuario_Load(sender, e);

        }

        private void BtnCargar_Click(object sender, EventArgs e)
        {
            List<Usuario> listaPersonas = LeerDatosDeExel;
            if(listaPersonas != null)
            {
                foreach (Usuario item in listaPersonas)
                {
                    item.NombreCargo.IdCargo = new CN_Cargo().GetId(item.NombreCargo.Nombre).IdCargo;
                    item.NombreUnidad.IdUnidad = new CN_Unidad().GetUnidad(item.NombreUnidad.Nombre).IdUnidad;
                    item.NombrePuesto.IdPuestoDeTrabajo = new CN_PuestoDeTrabajo().GetPuestoDeTrabajo(item.NombrePuesto.Nombre).IdPuestoDeTrabajo;
                    _ = new CN_Usuario().Registrar(item, out _);

                }
            }
            FormUsuario_Load(sender, e);
        }
        public List<Usuario> LeerDatosDeExel
        {
            get
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string rutaArchivo = openFileDialog.FileName;
                    SLDocument documento = new SLDocument(rutaArchivo);
                    int indiceRow = 2;
                    List<Usuario> listUsuario = new List<Usuario>();

                    while (!string.IsNullOrEmpty(documento.GetCellValueAsString(indiceRow, 1)))
                    {
                        Usuario persona = new Usuario
                        {
                            Item = documento.GetCellValueAsString(indiceRow, 1),
                            Ci = documento.GetCellValueAsString(indiceRow, 2),
                            Nombre = documento.GetCellValueAsString(indiceRow, 3),
                            Apellido = documento.GetCellValueAsString(indiceRow, 4),
                            NombreCargo = new Cargo() { Nombre = documento.GetCellValueAsString(indiceRow, 5) },
                            NombreUnidad = new Unidad() { Nombre = documento.GetCellValueAsString(indiceRow, 6) },
                            NombrePuesto = new PuestoDeTrabajo() { Nombre = documento.GetCellValueAsString(indiceRow, 7) }
                        };

                        listUsuario.Add(persona);
                        indiceRow++;
                    }
                    return listUsuario;
                }
                return null;
            }
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            string columFiltro = ((OpcionCombo)comboBoxBuscar.SelectedItem).Valor.ToString();
            if (dGVData.Rows.Count > 0)
            {
                foreach(DataGridViewRow row in dGVData.Rows)
                {
                    if (row.Cells[columFiltro].Value.ToString().Trim().ToUpper().Contains(textBuscar.Text.Trim().ToUpper()))
                    {
                        row.Visible = true;
                    }
                    else
                    {
                        row.Visible = false;    
                    }
                }
            }
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

        private void Seleccionar(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dGVData.Rows[e.RowIndex];
                FormModalUsuario modal = new FormModalUsuario();
                modal.textId.Text = row.Cells["IdUsuario"].Value.ToString();
                modal.textItem.Text = row.Cells["Item"].Value.ToString();
                modal.textCi.Text = row.Cells["CI"].Value.ToString();
                modal.textNombre.Text = row.Cells["Nombre"].Value.ToString();
                modal.textApellido.Text = row.Cells["Apellido"].Value.ToString();
                modal.textObservaciones.Text = row.Cells["Observaciones"].Value.ToString();
                modal.textCargo.Text = row.Cells["cargo"].Value.ToString();
                modal.textUnidad.Text = row.Cells["unidad"].Value.ToString();
                modal.textPuesto.Text = row.Cells["PuestoDeTrabajo"].Value.ToString();
                modal.ShowDialog();

            }
            
        }
    }
}
