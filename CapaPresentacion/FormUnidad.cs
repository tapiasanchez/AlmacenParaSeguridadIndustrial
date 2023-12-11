using CapaEntidad;
using CapaNegocio;
using SpreadsheetLight;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FormUnidad : Form
    {
        public Unidad unidad = new Unidad();
        public FormUnidad()
        {
            InitializeComponent();
        }

        private void FormUnidad_Load(object sender, EventArgs e)
        {
            dgvUnidad.Rows.Clear();
            List<Unidad> unidades = new CN_Unidad().Listar();
            foreach (Unidad item in unidades)
            {
                dgvUnidad.Rows.Add(item.IdUnidad, item.Nombre);
            }
        }

        private void IconButton1_Click(object sender, EventArgs e)
        {
            unidad.Nombre = textNombre.Text;
            RegistrarUnidad(unidad);
            Limpiar();
            FormUnidad_Load(sender, e);
        }

        private void RegistrarUnidad(Unidad unidad)
        {
            _ = new CN_Unidad().Registrar(unidad, out _);

        }
        private void Limpiar()
        {
            textNombre.Text = "";
        }

        private void IconButton2_Click(object sender, EventArgs e)
        {
            List<Unidad> listaDeUnidades = LeerDatosDeExel();
            if(listaDeUnidades != null)
            {
                foreach (Unidad item in listaDeUnidades)
                {
                    _ = new CN_Unidad().Registrar(item, out _);
                    FormUnidad_Load(sender, e);
                }
            }
        }
        public List<Unidad> LeerDatosDeExel()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string rutaArchivo = openFileDialog.FileName;
                SLDocument documento = new SLDocument(rutaArchivo);
                int indiceRow = 2;
                List<Unidad> listUnidades = new List<Unidad>();

                while (!string.IsNullOrEmpty(documento.GetCellValueAsString(indiceRow, 1)))
                {
                    Unidad unidad = new Unidad
                    {
                        Nombre = documento.GetCellValueAsString(indiceRow, 1)
                    };

                    listUnidades.Add(unidad);
                    indiceRow++;
                }
                return listUnidades;
            }
            return null;
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            string columFiltro = "Nombre";
            if (dgvUnidad.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvUnidad.Rows)
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
            foreach (DataGridViewRow row in dgvUnidad.Rows)
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
