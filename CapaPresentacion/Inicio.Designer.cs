namespace CapaPresentacion
{
    partial class Inicio
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Usuarios = new FontAwesome.Sharp.IconMenuItem();
            this.menuAjustes = new FontAwesome.Sharp.IconMenuItem();
            this.subMenuCargo = new FontAwesome.Sharp.IconMenuItem();
            this.subMenuUnidad = new FontAwesome.Sharp.IconMenuItem();
            this.subMenuPuestoDeTrabajo = new FontAwesome.Sharp.IconMenuItem();
            this.iconMenuItem2 = new FontAwesome.Sharp.IconMenuItem();
            this.iconMenuItem3 = new FontAwesome.Sharp.IconMenuItem();
            this.iconMenuItem4 = new FontAwesome.Sharp.IconMenuItem();
            this.iconMenuItem5 = new FontAwesome.Sharp.IconMenuItem();
            this.menuTitulo = new System.Windows.Forms.MenuStrip();
            this.label1 = new System.Windows.Forms.Label();
            this.contenedor = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Usuarios,
            this.menuAjustes,
            this.iconMenuItem2,
            this.iconMenuItem3,
            this.iconMenuItem4,
            this.iconMenuItem5});
            this.menuStrip1.Location = new System.Drawing.Point(0, 48);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 73);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // Usuarios
            // 
            this.Usuarios.AutoSize = false;
            this.Usuarios.IconChar = FontAwesome.Sharp.IconChar.UserGroup;
            this.Usuarios.IconColor = System.Drawing.Color.Black;
            this.Usuarios.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Usuarios.IconSize = 50;
            this.Usuarios.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Usuarios.Name = "Usuarios";
            this.Usuarios.Size = new System.Drawing.Size(122, 69);
            this.Usuarios.Text = "Usuarios";
            this.Usuarios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Usuarios.Click += new System.EventHandler(this.Usuarios_Click);
            // 
            // menuAjustes
            // 
            this.menuAjustes.AutoSize = false;
            this.menuAjustes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.subMenuCargo,
            this.subMenuUnidad,
            this.subMenuPuestoDeTrabajo});
            this.menuAjustes.IconChar = FontAwesome.Sharp.IconChar.Tools;
            this.menuAjustes.IconColor = System.Drawing.Color.Black;
            this.menuAjustes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuAjustes.IconSize = 50;
            this.menuAjustes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuAjustes.Name = "menuAjustes";
            this.menuAjustes.Size = new System.Drawing.Size(122, 69);
            this.menuAjustes.Text = "Ajustes";
            this.menuAjustes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // subMenuCargo
            // 
            this.subMenuCargo.IconChar = FontAwesome.Sharp.IconChar.PeopleArrowsLeftRight;
            this.subMenuCargo.IconColor = System.Drawing.Color.Black;
            this.subMenuCargo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.subMenuCargo.IconSize = 60;
            this.subMenuCargo.Name = "subMenuCargo";
            this.subMenuCargo.Size = new System.Drawing.Size(180, 22);
            this.subMenuCargo.Text = "Cargo";
            this.subMenuCargo.Click += new System.EventHandler(this.subMenuCargo_Click);
            // 
            // subMenuUnidad
            // 
            this.subMenuUnidad.IconChar = FontAwesome.Sharp.IconChar.Person;
            this.subMenuUnidad.IconColor = System.Drawing.Color.Black;
            this.subMenuUnidad.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.subMenuUnidad.IconSize = 60;
            this.subMenuUnidad.Name = "subMenuUnidad";
            this.subMenuUnidad.Size = new System.Drawing.Size(180, 22);
            this.subMenuUnidad.Text = "Unidad";
            this.subMenuUnidad.Click += new System.EventHandler(this.subMenuUnidad_Click);
            // 
            // subMenuPuestoDeTrabajo
            // 
            this.subMenuPuestoDeTrabajo.IconChar = FontAwesome.Sharp.IconChar.PeopleCarryBox;
            this.subMenuPuestoDeTrabajo.IconColor = System.Drawing.Color.Black;
            this.subMenuPuestoDeTrabajo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.subMenuPuestoDeTrabajo.IconSize = 60;
            this.subMenuPuestoDeTrabajo.Name = "subMenuPuestoDeTrabajo";
            this.subMenuPuestoDeTrabajo.Size = new System.Drawing.Size(180, 22);
            this.subMenuPuestoDeTrabajo.Text = "Puesto de Trabajo";
            this.subMenuPuestoDeTrabajo.Click += new System.EventHandler(this.subMenuPuestoDeTrabajo_Click);
            // 
            // iconMenuItem2
            // 
            this.iconMenuItem2.AutoSize = false;
            this.iconMenuItem2.IconChar = FontAwesome.Sharp.IconChar.Store;
            this.iconMenuItem2.IconColor = System.Drawing.Color.Black;
            this.iconMenuItem2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconMenuItem2.IconSize = 50;
            this.iconMenuItem2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.iconMenuItem2.Name = "iconMenuItem2";
            this.iconMenuItem2.Size = new System.Drawing.Size(80, 69);
            this.iconMenuItem2.Text = "Almacen";
            this.iconMenuItem2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // iconMenuItem3
            // 
            this.iconMenuItem3.AutoSize = false;
            this.iconMenuItem3.IconChar = FontAwesome.Sharp.IconChar.TableList;
            this.iconMenuItem3.IconColor = System.Drawing.Color.Black;
            this.iconMenuItem3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconMenuItem3.IconSize = 50;
            this.iconMenuItem3.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.iconMenuItem3.Name = "iconMenuItem3";
            this.iconMenuItem3.Size = new System.Drawing.Size(80, 69);
            this.iconMenuItem3.Text = "Dotacion";
            this.iconMenuItem3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // iconMenuItem4
            // 
            this.iconMenuItem4.AutoSize = false;
            this.iconMenuItem4.IconChar = FontAwesome.Sharp.IconChar.Stream;
            this.iconMenuItem4.IconColor = System.Drawing.Color.Black;
            this.iconMenuItem4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconMenuItem4.IconSize = 50;
            this.iconMenuItem4.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.iconMenuItem4.Name = "iconMenuItem4";
            this.iconMenuItem4.Size = new System.Drawing.Size(80, 69);
            this.iconMenuItem4.Text = "Cambio";
            this.iconMenuItem4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // iconMenuItem5
            // 
            this.iconMenuItem5.AutoSize = false;
            this.iconMenuItem5.IconChar = FontAwesome.Sharp.IconChar.SortAmountDown;
            this.iconMenuItem5.IconColor = System.Drawing.Color.Black;
            this.iconMenuItem5.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconMenuItem5.IconSize = 50;
            this.iconMenuItem5.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.iconMenuItem5.Name = "iconMenuItem5";
            this.iconMenuItem5.Size = new System.Drawing.Size(80, 69);
            this.iconMenuItem5.Text = "Historico";
            this.iconMenuItem5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // menuTitulo
            // 
            this.menuTitulo.AutoSize = false;
            this.menuTitulo.BackColor = System.Drawing.Color.SteelBlue;
            this.menuTitulo.Location = new System.Drawing.Point(0, 0);
            this.menuTitulo.Name = "menuTitulo";
            this.menuTitulo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menuTitulo.Size = new System.Drawing.Size(800, 48);
            this.menuTitulo.TabIndex = 1;
            this.menuTitulo.Text = "menuStrip2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.SteelBlue;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(261, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "Sistema de Almacen";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // contenedor
            // 
            this.contenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contenedor.Location = new System.Drawing.Point(0, 121);
            this.contenedor.Name = "contenedor";
            this.contenedor.Size = new System.Drawing.Size(800, 329);
            this.contenedor.TabIndex = 3;
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.contenedor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuTitulo);
            this.Name = "Inicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.MenuStrip menuTitulo;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconMenuItem Usuarios;
        private System.Windows.Forms.Panel contenedor;
        private FontAwesome.Sharp.IconMenuItem menuAjustes;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem2;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem3;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem4;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem5;
        private FontAwesome.Sharp.IconMenuItem subMenuCargo;
        private FontAwesome.Sharp.IconMenuItem subMenuUnidad;
        private FontAwesome.Sharp.IconMenuItem subMenuPuestoDeTrabajo;
    }
}

