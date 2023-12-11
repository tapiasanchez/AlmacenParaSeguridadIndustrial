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

        private void IconButton1_Click(object sender, EventArgs e)
        {
            puestoDeTrabajo.Nombre = textNombre.Text;
            RegistrarPuestoDeTrabajo(puestoDeTrabajo);
            Limpiar();
            FormPuestoDeTrabajo_Load(sender,e);
        }
        private void RegistrarPuestoDeTrabajo(PuestoDeTrabajo puestoDeTrabajo)
        {
            _ = new CN_PuestoDeTrabajo().Registrar(puestoDeTrabajo, out _);

        }
        private void Limpiar()
        {
            textNombre.Text = "";
        }

        private void IconButton2_Click(object sender, EventArgs e)
        {
            List<PuestoDeTrabajo> listaDePuesto = LeerDatosDeExel();
            if(listaDePuesto != null)
            {
                foreach (PuestoDeTrabajo item in listaDePuesto)
                {
                    _ = new CN_PuestoDeTrabajo().Registrar(item, out _);
                    FormPuestoDeTrabajo_Load(sender, e);
                }
            }
        }
        public List<PuestoDeTrabajo> LeerDatosDeExel()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string rutaArchivo = openFileDialog.FileName;
                SLDocument documento = new SLDocument(rutaArchivo);
                int indiceRow = 2;
                List<PuestoDeTrabajo> listPuestoDeTrabajo = new List<PuestoDeTrabajo>();

                while (!string.IsNullOrEmpty(documento.GetCellValueAsString(indiceRow, 1)))
                {
                    PuestoDeTrabajo puestoDeTrabajo = new PuestoDeTrabajo
                    {
                        Nombre = documento.GetCellValueAsString(indiceRow, 1)
                    };

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

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            string columFiltro = "NombrePuesto";
            if (dgvPuestoDeTrabajo.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvPuestoDeTrabajo.Rows)
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
            foreach (DataGridViewRow row in dgvPuestoDeTrabajo.Rows)
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
