using CapaEntidad;
using CapaNegocio;
using SpreadsheetLight;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FormPuestoDeTrabajo : Form
    {
        public PuestoDeTrabajo puestoDeTrabajo = new PuestoDeTrabajo();
        public FormPuestoDeTrabajo()
        {
            InitializeComponent();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            puestoDeTrabajo.Nombre = textNombre.Text;
            registrarPuestoDeTrabajo(puestoDeTrabajo);
            limpiar();
            FormPuestoDeTrabajo_Load(sender,e);
        }
        private void registrarPuestoDeTrabajo(PuestoDeTrabajo puestoDeTrabajo)
        {
            string mensaje = String.Empty;
            int idPuestodeTrabajoGenerado = new CN_PuestoDeTrabajo().Registrar(puestoDeTrabajo, out mensaje);

        }
        private void limpiar()
        {
            textNombre.Text = "";
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            List<PuestoDeTrabajo> listaDePuesto = leerDatosDeExel();
            foreach (PuestoDeTrabajo item in listaDePuesto)
            {
                string mensaje = String.Empty;
                int idPuestodeTrabajoGenerado = new CN_PuestoDeTrabajo().Registrar(item, out mensaje);
                FormPuestoDeTrabajo_Load(sender, e);

            }
        }
        public List<PuestoDeTrabajo> leerDatosDeExel()
        {
            string rutaArchivo = string.Empty;
            OpenFileDialog openFileDialog = new OpenFileDialog();

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                rutaArchivo = openFileDialog.FileName;
                SLDocument documento = new SLDocument(rutaArchivo);
                int indiceRow = 2;
                List<PuestoDeTrabajo> listPuestoDeTrabajo = new List<PuestoDeTrabajo>();

                while (!string.IsNullOrEmpty(documento.GetCellValueAsString(indiceRow, 1)))
                {
                    PuestoDeTrabajo puestoDeTrabajo = new PuestoDeTrabajo();

                    puestoDeTrabajo.Nombre = documento.GetCellValueAsString(indiceRow, 1);

                    listPuestoDeTrabajo.Add(puestoDeTrabajo);
                    indiceRow++;
                }
                return listPuestoDeTrabajo;
            }
            return null;
        }

        private void FormPuestoDeTrabajo_Load(object sender, EventArgs e)
        {
            dgvPuestoDeTrabajo.Rows.Clear();
            List<PuestoDeTrabajo> puestos = new CN_PuestoDeTrabajo().Listar();
            foreach(PuestoDeTrabajo puesto in puestos)
            {
                dgvPuestoDeTrabajo.Rows.Add(puesto.IdPuestoDeTrabajo, puesto.Nombre);

            }
        }
    }
}
