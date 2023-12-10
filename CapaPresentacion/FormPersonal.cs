using CapaEntidad;
using CapaNegocio;
using CapaPresentacion.Utilidades;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FormPersonal : Form
    {
        public FormPersonal()
        {
            InitializeComponent();
        }

        private void FormPersonal_Load(object sender, EventArgs e)
        {
            comboBoxCargo.Items.Clear();
            List<Cargo> cargos = new CN_Cargo().Listar();
            foreach (Cargo cargo in cargos)
            {
                comboBoxCargo.Items.Add(new OpcionCombo()
                {
                    Texto = cargo.Nombre,
                    Valor = cargo.IdCargo
                });
            }
            comboBoxCargo.DisplayMember = "Texto";
            comboBoxCargo.ValueMember = "Valor";
            comboBoxCargo.SelectedIndex = 0;
            dGVData.Rows.Clear();
            List<Personal> listaUsuarios = new CN_Personal().Listar();
            foreach (Personal item in listaUsuarios)
            {
                dGVData.Rows.Add(item.IdPersona, item.NombreCompleto, item.Ci,item.UserName, item.Contrasena, item.Cargo.Nombre);
            }
            if (!string.IsNullOrEmpty(textBoxIDPersonal.Text))
            {
                btnEditarPersonal.Enabled = true;
                btnGuardar.Enabled = false;
            }
            else
            {
                btnEditarPersonal.Enabled = false;
                btnGuardar.Enabled = true;
            }

        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            Personal persona = new Personal()
            {
                NombreCompleto = textNombreCompleto.Text,
                Ci = textCI.Text,
                UserName = textUserName.Text,
                Contrasena = textPassword.Text,
                Cargo = new Cargo() { IdCargo = Convert.ToInt32(((OpcionCombo)comboBoxCargo.SelectedItem).Valor) }

            };
            new CN_Personal().Registrar(persona);
            Limpiar();
            FormPersonal_Load(sender, e);
        }
        private void Limpiar()
        {
            textNombreCompleto.Text = "";
            textCI.Text = "";
            textUserName.Text = "";
            textPassword.Text = "";
            comboBoxCargo.SelectedIndex = 0;
        }

        private void DgvData_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            if (e.ColumnIndex == 6)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                var w = Properties.Resources.checkIcon.Width;
                var h = Properties.Resources.checkIcon.Height;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                e.Graphics.DrawImage(Properties.Resources.checkIcon, new Rectangle(x, y, w, h));
                e.Handled = true;
            }
        }

        private void DGVData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string ciPersonal = dGVData.Rows[e.RowIndex].Cells["CI"].Value.ToString();
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dGVData.Rows[e.RowIndex];
                textBoxIDPersonal.Text = row.Cells["ibPersonal"].Value.ToString();
                textNombreCompleto.Text = row.Cells["NombreCompleto"].Value.ToString();
                textCI.Text = row.Cells["CI"].Value.ToString();
                textUserName.Text = row.Cells["userName"].Value.ToString();
                textPassword.Text = row.Cells["contrasena"].Value.ToString();
                comboBoxCargo.Text = row.Cells["NombreCargo"].Value.ToString();
            }
            btnEditarPersonal.Enabled = true;
            btnGuardar.Enabled = false;
            //FormPersonal_Load(sender, e);
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {


        }

        private void btnEditarPersonal_Click(object sender, EventArgs e)
        {
            Personal persona = new Personal()
            {
                IdPersona = Convert.ToInt32(textBoxIDPersonal.Text),
                NombreCompleto = textNombreCompleto.Text,
                Ci = textCI.Text,
                UserName = textUserName.Text,
                Contrasena = textPassword.Text,
                Cargo = new Cargo() { IdCargo = Convert.ToInt32(((OpcionCombo)comboBoxCargo.SelectedItem).Valor) }

            };
            new CN_Personal().Actualizar(persona);
            Limpiar();
            btnEditarPersonal.Enabled = false;
            btnGuardar.Enabled = true;
            FormPersonal_Load(sender, e);
            
        }
    }
}
