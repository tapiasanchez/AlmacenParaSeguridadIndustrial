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
            this.menuAlmacen = new FontAwesome.Sharp.IconMenuItem();
            this.subMenuTalla = new FontAwesome.Sharp.IconMenuItem();
            this.subMenuRegistro = new FontAwesome.Sharp.IconMenuItem();
            this.menuDotacion = new FontAwesome.Sharp.IconMenuItem();
            this.subMenuListaDotacion = new FontAwesome.Sharp.IconMenuItem();
            this.subMenuDotacion = new FontAwesome.Sharp.IconMenuItem();
            this.menuCambio = new FontAwesome.Sharp.IconMenuItem();
            this.menuHistorico = new FontAwesome.Sharp.IconMenuItem();
            this.subMenuReporteDotacion = new FontAwesome.Sharp.IconMenuItem();
            this.subMenuFechaDotacion = new FontAwesome.Sharp.IconMenuItem();
            this.menuTitulo = new System.Windows.Forms.MenuStrip();
            this.label1 = new System.Windows.Forms.Label();
            this.contenedor = new System.Windows.Forms.Panel();
            this.subMenuActualizarStock = new FontAwesome.Sharp.IconMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Usuarios,
            this.menuAjustes,
            this.menuAlmacen,
            this.menuDotacion,
            this.menuCambio,
            this.menuHistorico});
            this.menuStrip1.Location = new System.Drawing.Point(0, 48);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 73);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
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
            this.subMenuCargo.Size = new System.Drawing.Size(168, 22);
            this.subMenuCargo.Text = "Cargo";
            this.subMenuCargo.Click += new System.EventHandler(this.SubMenuCargo_Click);
            // 
            // subMenuUnidad
            // 
            this.subMenuUnidad.IconChar = FontAwesome.Sharp.IconChar.Person;
            this.subMenuUnidad.IconColor = System.Drawing.Color.Black;
            this.subMenuUnidad.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.subMenuUnidad.IconSize = 60;
            this.subMenuUnidad.Name = "subMenuUnidad";
            this.subMenuUnidad.Size = new System.Drawing.Size(168, 22);
            this.subMenuUnidad.Text = "Unidad";
            this.subMenuUnidad.Click += new System.EventHandler(this.SubMenuUnidad_Click);
            // 
            // subMenuPuestoDeTrabajo
            // 
            this.subMenuPuestoDeTrabajo.IconChar = FontAwesome.Sharp.IconChar.PeopleCarryBox;
            this.subMenuPuestoDeTrabajo.IconColor = System.Drawing.Color.Black;
            this.subMenuPuestoDeTrabajo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.subMenuPuestoDeTrabajo.IconSize = 60;
            this.subMenuPuestoDeTrabajo.Name = "subMenuPuestoDeTrabajo";
            this.subMenuPuestoDeTrabajo.Size = new System.Drawing.Size(168, 22);
            this.subMenuPuestoDeTrabajo.Text = "Puesto de Trabajo";
            this.subMenuPuestoDeTrabajo.Click += new System.EventHandler(this.SubMenuPuestoDeTrabajo_Click);
            // 
            // menuAlmacen
            // 
            this.menuAlmacen.AutoSize = false;
            this.menuAlmacen.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.subMenuTalla,
            this.subMenuRegistro,
            this.subMenuActualizarStock});
            this.menuAlmacen.IconChar = FontAwesome.Sharp.IconChar.Store;
            this.menuAlmacen.IconColor = System.Drawing.Color.Black;
            this.menuAlmacen.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuAlmacen.IconSize = 50;
            this.menuAlmacen.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuAlmacen.Name = "menuAlmacen";
            this.menuAlmacen.Size = new System.Drawing.Size(80, 69);
            this.menuAlmacen.Text = "Almacen";
            this.menuAlmacen.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // subMenuTalla
            // 
            this.subMenuTalla.IconChar = FontAwesome.Sharp.IconChar.Paste;
            this.subMenuTalla.IconColor = System.Drawing.Color.Black;
            this.subMenuTalla.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.subMenuTalla.Name = "subMenuTalla";
            this.subMenuTalla.Size = new System.Drawing.Size(190, 22);
            this.subMenuTalla.Text = "Tallas";
            this.subMenuTalla.Click += new System.EventHandler(this.SubMenuTalla_Click);
            // 
            // subMenuRegistro
            // 
            this.subMenuRegistro.IconChar = FontAwesome.Sharp.IconChar.ListAlt;
            this.subMenuRegistro.IconColor = System.Drawing.Color.Black;
            this.subMenuRegistro.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.subMenuRegistro.Name = "subMenuRegistro";
            this.subMenuRegistro.Size = new System.Drawing.Size(190, 22);
            this.subMenuRegistro.Text = "Registro de Productos";
            this.subMenuRegistro.Click += new System.EventHandler(this.IconMenuItem1_Click);
            // 
            // menuDotacion
            // 
            this.menuDotacion.AutoSize = false;
            this.menuDotacion.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.subMenuListaDotacion,
            this.subMenuDotacion});
            this.menuDotacion.IconChar = FontAwesome.Sharp.IconChar.TableList;
            this.menuDotacion.IconColor = System.Drawing.Color.Black;
            this.menuDotacion.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuDotacion.IconSize = 50;
            this.menuDotacion.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuDotacion.Name = "menuDotacion";
            this.menuDotacion.Size = new System.Drawing.Size(80, 69);
            this.menuDotacion.Text = "Dotacion";
            this.menuDotacion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // subMenuListaDotacion
            // 
            this.subMenuListaDotacion.IconChar = FontAwesome.Sharp.IconChar.List;
            this.subMenuListaDotacion.IconColor = System.Drawing.Color.Black;
            this.subMenuListaDotacion.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.subMenuListaDotacion.IconSize = 28;
            this.subMenuListaDotacion.Name = "subMenuListaDotacion";
            this.subMenuListaDotacion.Size = new System.Drawing.Size(170, 22);
            this.subMenuListaDotacion.Text = "Listas de Dotacion";
            this.subMenuListaDotacion.Click += new System.EventHandler(this.SubMenuListaDotacion_Click);
            // 
            // subMenuDotacion
            // 
            this.subMenuDotacion.IconChar = FontAwesome.Sharp.IconChar.ListCheck;
            this.subMenuDotacion.IconColor = System.Drawing.Color.Black;
            this.subMenuDotacion.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.subMenuDotacion.IconSize = 28;
            this.subMenuDotacion.Name = "subMenuDotacion";
            this.subMenuDotacion.Size = new System.Drawing.Size(170, 22);
            this.subMenuDotacion.Text = "Dotacion";
            this.subMenuDotacion.Click += new System.EventHandler(this.SubMenuDotacion_Click);
            // 
            // menuCambio
            // 
            this.menuCambio.AutoSize = false;
            this.menuCambio.IconChar = FontAwesome.Sharp.IconChar.Stream;
            this.menuCambio.IconColor = System.Drawing.Color.Black;
            this.menuCambio.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuCambio.IconSize = 50;
            this.menuCambio.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuCambio.Name = "menuCambio";
            this.menuCambio.Size = new System.Drawing.Size(80, 69);
            this.menuCambio.Text = "Cambio";
            this.menuCambio.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.menuCambio.Click += new System.EventHandler(this.MenuCambio_Click);
            // 
            // menuHistorico
            // 
            this.menuHistorico.AutoSize = false;
            this.menuHistorico.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.subMenuReporteDotacion,
            this.subMenuFechaDotacion});
            this.menuHistorico.IconChar = FontAwesome.Sharp.IconChar.SortAmountDown;
            this.menuHistorico.IconColor = System.Drawing.Color.Black;
            this.menuHistorico.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuHistorico.IconSize = 50;
            this.menuHistorico.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuHistorico.Name = "menuHistorico";
            this.menuHistorico.Size = new System.Drawing.Size(80, 69);
            this.menuHistorico.Text = "Historico";
            this.menuHistorico.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // subMenuReporteDotacion
            // 
            this.subMenuReporteDotacion.IconChar = FontAwesome.Sharp.IconChar.Sliders;
            this.subMenuReporteDotacion.IconColor = System.Drawing.Color.Black;
            this.subMenuReporteDotacion.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.subMenuReporteDotacion.Name = "subMenuReporteDotacion";
            this.subMenuReporteDotacion.Size = new System.Drawing.Size(166, 22);
            this.subMenuReporteDotacion.Text = "Reporte Dotacion";
            this.subMenuReporteDotacion.Click += new System.EventHandler(this.SubMenuReporteDotacion_Click);
            // 
            // subMenuFechaDotacion
            // 
            this.subMenuFechaDotacion.IconChar = FontAwesome.Sharp.IconChar.None;
            this.subMenuFechaDotacion.IconColor = System.Drawing.Color.Black;
            this.subMenuFechaDotacion.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.subMenuFechaDotacion.Name = "subMenuFechaDotacion";
            this.subMenuFechaDotacion.Size = new System.Drawing.Size(166, 22);
            this.subMenuFechaDotacion.Text = "Fechas Dotacion";
            this.subMenuFechaDotacion.Click += new System.EventHandler(this.SubMenuFechaDotacion_Click);
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
            // 
            // contenedor
            // 
            this.contenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contenedor.Location = new System.Drawing.Point(0, 121);
            this.contenedor.Name = "contenedor";
            this.contenedor.Size = new System.Drawing.Size(800, 329);
            this.contenedor.TabIndex = 3;
            // 
            // subMenuActualizarStock
            // 
            this.subMenuActualizarStock.IconChar = FontAwesome.Sharp.IconChar.FileEdit;
            this.subMenuActualizarStock.IconColor = System.Drawing.Color.Black;
            this.subMenuActualizarStock.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.subMenuActualizarStock.IconSize = 28;
            this.subMenuActualizarStock.Name = "subMenuActualizarStock";
            this.subMenuActualizarStock.Size = new System.Drawing.Size(190, 22);
            this.subMenuActualizarStock.Text = "Actualizar stock";
            this.subMenuActualizarStock.Click += new System.EventHandler(this.IconMenuItem1_Click_1);
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
        private FontAwesome.Sharp.IconMenuItem menuDotacion;
        private FontAwesome.Sharp.IconMenuItem menuCambio;
        private FontAwesome.Sharp.IconMenuItem menuHistorico;
        private FontAwesome.Sharp.IconMenuItem subMenuCargo;
        private FontAwesome.Sharp.IconMenuItem subMenuUnidad;
        private FontAwesome.Sharp.IconMenuItem subMenuPuestoDeTrabajo;
        private FontAwesome.Sharp.IconMenuItem menuAlmacen;
        private FontAwesome.Sharp.IconMenuItem subMenuTalla;
        private FontAwesome.Sharp.IconMenuItem subMenuRegistro;
        private FontAwesome.Sharp.IconMenuItem subMenuListaDotacion;
        private FontAwesome.Sharp.IconMenuItem subMenuDotacion;
        private FontAwesome.Sharp.IconMenuItem subMenuReporteDotacion;
        private FontAwesome.Sharp.IconMenuItem subMenuFechaDotacion;
        private FontAwesome.Sharp.IconMenuItem subMenuActualizarStock;
    }
}

