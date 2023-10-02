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

        private void iconButton1_Click(object sender, EventArgs e)
        {
            unidad.Nombre = textNombre.Text;
            registrarUnidad(unidad);
            limpiar();
            FormUnidad_Load(sender, e);
        }

        private void registrarUnidad(Unidad unidad)
        {
            string mensaje = String.Empty;
            int idUnidadGenerado = new CN_Unidad().Registrar(unidad, out mensaje);

        }
        private void limpiar()
        {
            textNombre.Text = "";
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            List<Unidad> listaDeUnidades = leerDatosDeExel();
            foreach (Unidad item in listaDeUnidades)
            {
                string mensaje = String.Empty;
                int idUnidadGenerado = new CN_Unidad().Registrar(item, out mensaje);
                FormUnidad_Load(sender, e);

            }
        }
        public List<Unidad> leerDatosDeExel()
        {
            string rutaArchivo = string.Empty;
            OpenFileDialog openFileDialog = new OpenFileDialog();

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                rutaArchivo = openFileDialog.FileName;
                SLDocument documento = new SLDocument(rutaArchivo);
                int indiceRow = 2;
                List<Unidad> listUnidades = new List<Unidad>();

                while (!string.IsNullOrEmpty(documento.GetCellValueAsString(indiceRow, 1)))
                {
                    Unidad unidad = new Unidad();

                    unidad.Nombre = documento.GetCellValueAsString(indiceRow, 1);

                    listUnidades.Add(unidad);
                    indiceRow++;
                }
                return listUnidades;
            }
            return null;
        }

    }
}
