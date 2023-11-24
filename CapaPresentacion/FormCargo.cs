using CapaEntidad;
using CapaNegocio;
using SpreadsheetLight;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FormCargo : Form
    {
        public Cargo cargo = new Cargo();
        public MenuStrip items;

        public FormCargo(MenuStrip menus)
        {
            items = menus;
            InitializeComponent();
        }
        
        private void IconButton1_Click(object sender, EventArgs e)
        {
            cargo.Nombre = textNombre.Text;
            RegistrarCargo(cargo);
            Limpiar();
            FormCargo_Load(sender, e);
        }

        private void RegistrarCargo(Cargo cargo)
        {
            _ = new CN_Cargo().Registrar(cargo, out _);

        }
        private void Limpiar()
        {
            textNombre.Text = "";
        }

        private void IconButton2_Click(object sender, EventArgs e)
        {
            List<Cargo> listaDeCargos = LeerDatosDeExel();
            foreach (Cargo item in listaDeCargos)
            {
                _ = new CN_Cargo().Registrar(item, out _);
                FormCargo_Load(sender, e);

            }
        }

        public List<Cargo> LeerDatosDeExel()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string rutaArchivo = openFileDialog.FileName;
                SLDocument documento = new SLDocument(rutaArchivo);
                int indiceRow = 2;
                List<Cargo> listCargo = new List<Cargo>();

                while (!string.IsNullOrEmpty(documento.GetCellValueAsString(indiceRow, 1)))
                {
                    Cargo cargo = new Cargo
                    {
                        Nombre = documento.GetCellValueAsString(indiceRow, 1)
                    };

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

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            string columFiltro = "NombreCargo";
            if (dgvCargo.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvCargo.Rows)
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
            foreach (DataGridViewRow row in dgvCargo.Rows)
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

        private void dgvCargo_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if(e.RowIndex < 0)
                return;
            if(e.ColumnIndex == 2)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                var w = Properties.Resources.checkIcon.Width;
                var h = Properties.Resources.checkIcon.Height;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                e.Graphics.DrawImage(Properties.Resources.checkIcon, new Rectangle(x,y,w,h));
                e.Handled = true;
            }

        }

        private void dgvCargo_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int idCargo = Convert.ToInt32(dgvCargo.Rows[e.RowIndex].Cells["IdCargo"].Value);
            FormModalPermisos permisos = new FormModalPermisos(idCargo);
            permisos.CargarLista(items);
            permisos.ShowDialog();
        }
    }
}
