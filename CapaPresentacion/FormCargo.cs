using CapaEntidad;
using CapaNegocio;
using SpreadsheetLight;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FormCargo : Form
    {
        public Cargo cargo = new Cargo();
        public FormCargo()
        {
            InitializeComponent();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            cargo.Nombre = textNombre.Text;
            registrarCargo(cargo);
            limpiar();
            FormCargo_Load(sender, e);
        }

        private void registrarCargo(Cargo cargo)
        {
            string mensaje = String.Empty;
            int idUsuarioGenerado = new CN_Cargo().Registrar(cargo, out mensaje);

        }
        private void limpiar()
        {
            textNombre.Text = "";
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            List<Cargo> listaDeCargos = leerDatosDeExel();
            foreach (Cargo item in listaDeCargos)
            {
                string mensaje = String.Empty;
                int idCargoGenerado = new CN_Cargo().Registrar(item, out mensaje);
                FormCargo_Load(sender, e);

            }
        }

        public List<Cargo> leerDatosDeExel()
        {
            string rutaArchivo = string.Empty;
            OpenFileDialog openFileDialog = new OpenFileDialog();

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                rutaArchivo = openFileDialog.FileName;
                SLDocument documento = new SLDocument(rutaArchivo);
                int indiceRow = 2;
                List<Cargo> listCargo = new List<Cargo>();

                while (!string.IsNullOrEmpty(documento.GetCellValueAsString(indiceRow, 1)))
                {
                    Cargo cargo = new Cargo();

                    cargo.Nombre = documento.GetCellValueAsString(indiceRow, 1);

                    listCargo.Add(cargo);
                    indiceRow++;
                }
                return listCargo;
            }
            return null;
        }

        private void FormCargo_Load(object sender, EventArgs e)
        {
            dgvCargo.Rows.Clear();
            List<Cargo> cargos = new CN_Cargo().Listar();
            foreach(Cargo cargo in cargos)
            {
                dgvCargo.Rows.Add(cargo.IdCargo, cargo.Nombre);

            }
        }
    }
}
