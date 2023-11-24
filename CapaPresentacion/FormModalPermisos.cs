using CapaEntidad;
using CapaNegocio;
using FontAwesome.Sharp;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FormModalPermisos : Form
    {
        private static int idCargo;
        public FormModalPermisos(int id)
        {
            idCargo = id;
            InitializeComponent();
        }

        private void FormModalPermisos_Load(object sender, EventArgs e)
        {

        }

        public void CargarLista(MenuStrip menu)
        {
           // List<String> listMenu = new List<String>();
            foreach (IconMenuItem iconMenu in menu.Items)
            {
                listBoxMenus.Items.Add(iconMenu.Name);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            RegistrarPermisos();
            this.Close();
            
        }
        private void RegistrarPermisos()
        {
            foreach (string checkedListBox in listBoxMenus.CheckedItems)
            {
                Permiso permiso = new Permiso()
                {
                    NombreMenu = checkedListBox,
                    Cargo = new Cargo()
                    {
                        IdCargo = idCargo
                    }
                };
                Permiso objPermiso = new CN_Permiso().GetPermisos().Where(
                p => p.NombreMenu == permiso.NombreMenu && p.Cargo.IdCargo == permiso.Cargo.IdCargo).FirstOrDefault();
                if (objPermiso == null)
                {
                    new CN_Permiso().Registar(permiso);
                }
            }

        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
