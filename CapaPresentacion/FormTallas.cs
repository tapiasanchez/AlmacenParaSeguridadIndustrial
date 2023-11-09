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

        private void BtnGuardarTalla_Click(object sender, EventArgs e)
        {
            talla.Nombre = textNombre.Text;
            RegistrarTalla(talla);
            Limpiar();
            FormTallas_Load(sender, e);
        }
        private void RegistrarTalla(Talla talla)
        {
            _ = new CN_Talla().Registrar(talla, out _);

        }
        private void Limpiar()
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

        private void IconButton2_Click(object sender, EventArgs e)
        {
            List<Talla> listaDeTallas = LeerDatosDeExel();
            foreach (Talla item in listaDeTallas)
            {
                _ = new CN_Talla().Registrar(item, out _);
                FormTallas_Load(sender, e);

            }
        }

        public List<Talla> LeerDatosDeExel()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string rutaArchivo = openFileDialog.FileName;
                SLDocument documento = new SLDocument(rutaArchivo);
                int indiceRow = 2;
                List<Talla> listTalla = new List<Talla>();

                while (!string.IsNullOrEmpty(documento.GetCellValueAsString(indiceRow, 1)))
                {
                    Talla talla = new Talla
                    {
                        Nombre = documento.GetCellValueAsString(indiceRow, 1)
                    };

                    listTalla.Add(talla);
                    indiceRow++;
                }
                return listTalla;
            }
            return null;
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            string columFiltro = "NombreTalla";
            if (dgvTalla.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvTalla.Rows)
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
            foreach (DataGridViewRow row in dgvTalla.Rows)
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
