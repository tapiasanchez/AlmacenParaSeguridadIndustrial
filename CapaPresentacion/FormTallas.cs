using CapaEntidad;
using CapaNegocio;
using SpreadsheetLight;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FormTallas : Form
    {
        public Talla talla = new Talla();
        public FormTallas()
        {
            InitializeComponent();
        }

        private void btnGuardarTalla_Click(object sender, EventArgs e)
        {
            talla.Nombre = textNombre.Text;
            registrarTalla(talla);
            limpiar();
            FormTallas_Load(sender, e);
        }
        private void registrarTalla(Talla talla)
        {
            string mensaje = String.Empty;
            int idTallaGenerado = new CN_Talla().Registrar(talla, out mensaje);

        }
        private void limpiar()
        {
            textNombre.Text = "";
        }

        private void FormTallas_Load(object sender, EventArgs e)
        {
            dgvTalla.Rows.Clear();
            List<Talla> tallas = new CN_Talla().Listar();
            foreach (Talla talla in tallas)
            {
                dgvTalla.Rows.Add(talla.IdTalla, talla.Nombre);

            }

        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            List<Talla> listaDeTallas = leerDatosDeExel();
            foreach (Talla item in listaDeTallas)
            {
                string mensaje = String.Empty;
                int idCargoGenerado = new CN_Talla().Registrar(item, out mensaje);
                FormTallas_Load(sender, e);

            }
        }

        public List<Talla> leerDatosDeExel()
        {
            string rutaArchivo = string.Empty;
            OpenFileDialog openFileDialog = new OpenFileDialog();

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                rutaArchivo = openFileDialog.FileName;
                SLDocument documento = new SLDocument(rutaArchivo);
                int indiceRow = 2;
                List<Talla> listTalla = new List<Talla>();

                while (!string.IsNullOrEmpty(documento.GetCellValueAsString(indiceRow, 1)))
                {
                    Talla talla = new Talla();

                    talla.Nombre = documento.GetCellValueAsString(indiceRow, 1);

                    listTalla.Add(talla);
                    indiceRow++;
                }
                return listTalla;
            }
            return null;
        }

    }
}
