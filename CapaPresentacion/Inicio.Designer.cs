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
            this.menu = new System.Windows.Forms.MenuStrip();
            this.menuAjustes = new FontAwesome.Sharp.IconMenuItem();
            this.subMenuCargo = new FontAwesome.Sharp.IconMenuItem();
            this.subMenuUnidad = new FontAwesome.Sharp.IconMenuItem();
            this.subMenuPuestoDeTrabajo = new FontAwesome.Sharp.IconMenuItem();
            this.menuPersonal = new FontAwesome.Sharp.IconMenuItem();
            this.Usuarios = new FontAwesome.Sharp.IconMenuItem();
            this.menuAlmacen = new FontAwesome.Sharp.IconMenuItem();
            this.subMenuTalla = new FontAwesome.Sharp.IconMenuItem();
            this.subMenuRegistro = new FontAwesome.Sharp.IconMenuItem();
            this.subMenuActualizarStock = new FontAwesome.Sharp.IconMenuItem();
            this.menuDotacion = new FontAwesome.Sharp.IconMenuItem();
            this.subMenuListaDotacion = new FontAwesome.Sharp.IconMenuItem();
            this.subMenuDotacion = new FontAwesome.Sharp.IconMenuItem();
            this.menuCambio = new FontAwesome.Sharp.IconMenuItem();
            this.menuHistorico = new FontAwesome.Sharp.IconMenuItem();
            this.subMenuReporteDotacion = new FontAwesome.Sharp.IconMenuItem();
            this.subMenuFechaDotacion = new FontAwesome.Sharp.IconMenuItem();
            this.menuReporte = new FontAwesome.Sharp.IconMenuItem();
            this.subMenuRDotacion = new FontAwesome.Sharp.IconMenuItem();
            this.subMenuRCambio = new FontAwesome.Sharp.IconMenuItem();
            this.subMenuRFecha = new FontAwesome.Sharp.IconMenuItem();
            this.subMenuRPersonal = new FontAwesome.Sharp.IconMenuItem();
            this.menuTitulo = new System.Windows.Forms.MenuStrip();
            this.label1 = new System.Windows.Forms.Label();
            this.contenedor = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuAjustes,
            this.menuPersonal,
            this.Usuarios,
            this.menuAlmacen,
            this.menuDotacion,
            this.menuCambio,
            this.menuHistorico,
            this.menuReporte});
            this.menu.Location = new System.Drawing.Point(0, 48);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(800, 73);
            this.menu.TabIndex = 0;
            this.menu.Text = "menuStrip1";
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
            this.menuAjustes.Size = new System.Drawing.Size(80, 69);
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
            // menuPersonal
            // 
            this.menuPersonal.IconChar = FontAwesome.Sharp.IconChar.UsersCog;
            this.menuPersonal.IconColor = System.Drawing.Color.Black;
            this.menuPersonal.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuPersonal.IconSize = 50;
            this.menuPersonal.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuPersonal.Name = "menuPersonal";
            this.menuPersonal.Size = new System.Drawing.Size(64, 69);
            this.menuPersonal.Text = "Personal";
            this.menuPersonal.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.menuPersonal.Click += new System.EventHandler(this.menuPersonal_Click);
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
            this.Usuarios.Size = new System.Drawing.Size(80, 69);
            this.Usuarios.Text = "Usuarios";
            this.Usuarios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Usuarios.Click += new System.EventHandler(this.Usuarios_Click);
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
            this.subMenuReporteDotacion.Size = new System.Drawing.Size(181, 22);
            this.subMenuReporteDotacion.Text = "Reporte Por Persona";
            this.subMenuReporteDotacion.Click += new System.EventHandler(this.SubMenuReporteDotacion_Click);
            // 
            // subMenuFechaDotacion
            // 
            this.subMenuFechaDotacion.IconChar = FontAwesome.Sharp.IconChar.None;
            this.subMenuFechaDotacion.IconColor = System.Drawing.Color.Black;
            this.subMenuFechaDotacion.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.subMenuFechaDotacion.Name = "subMenuFechaDotacion";
            this.subMenuFechaDotacion.Size = new System.Drawing.Size(181, 22);
            this.subMenuFechaDotacion.Text = "Reporte Por Fechas";
            this.subMenuFechaDotacion.Click += new System.EventHandler(this.SubMenuFechaDotacion_Click);
            // 
            // menuReporte
            // 
            this.menuReporte.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.subMenuRDotacion,
            this.subMenuRCambio,
            this.subMenuRFecha,
            this.subMenuRPersonal});
            this.menuReporte.IconChar = FontAwesome.Sharp.IconChar.SquarePollHorizontal;
            this.menuReporte.IconColor = System.Drawing.Color.Black;
            this.menuReporte.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuReporte.IconSize = 50;
            this.menuReporte.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuReporte.Name = "menuReporte";
            this.menuReporte.Size = new System.Drawing.Size(62, 69);
            this.menuReporte.Text = "Reporte";
            this.menuReporte.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // subMenuRDotacion
            // 
            this.subMenuRDotacion.IconChar = FontAwesome.Sharp.IconChar.Outdent;
            this.subMenuRDotacion.IconColor = System.Drawing.Color.Black;
            this.subMenuRDotacion.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.subMenuRDotacion.Name = "subMenuRDotacion";
            this.subMenuRDotacion.Size = new System.Drawing.Size(133, 22);
            this.subMenuRDotacion.Text = "Dotaciones";
            this.subMenuRDotacion.Click += new System.EventHandler(this.subMenuRDotacion_Click);
            // 
            // subMenuRCambio
            // 
            this.subMenuRCambio.IconChar = FontAwesome.Sharp.IconChar.Outdent;
            this.subMenuRCambio.IconColor = System.Drawing.Color.Black;
            this.subMenuRCambio.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.subMenuRCambio.Name = "subMenuRCambio";
            this.subMenuRCambio.Size = new System.Drawing.Size(133, 22);
            this.subMenuRCambio.Text = "Cambios";
            this.subMenuRCambio.Click += new System.EventHandler(this.subMenuRCambio_Click);
            // 
            // subMenuRFecha
            // 
            this.subMenuRFecha.IconChar = FontAwesome.Sharp.IconChar.CalendarCheck;
            this.subMenuRFecha.IconColor = System.Drawing.Color.Black;
            this.subMenuRFecha.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.subMenuRFecha.Name = "subMenuRFecha";
            this.subMenuRFecha.Size = new System.Drawing.Size(133, 22);
            this.subMenuRFecha.Text = "Por Fechas";
            // 
            // subMenuRPersonal
            // 
            this.subMenuRPersonal.IconChar = FontAwesome.Sharp.IconChar.Person;
            this.subMenuRPersonal.IconColor = System.Drawing.Color.Black;
            this.subMenuRPersonal.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.subMenuRPersonal.Name = "subMenuRPersonal";
            this.subMenuRPersonal.Size = new System.Drawing.Size(133, 22);
            this.subMenuRPersonal.Text = "Personal";
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
            this.contenedor.Size = new System.Drawing.Size(800, 429);
            this.contenedor.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.SteelBlue;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(454, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Usuario:";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.BackColor = System.Drawing.Color.SteelBlue;
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.ForeColor = System.Drawing.Color.White;
            this.lblUsuario.Location = new System.Drawing.Point(518, 12);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(77, 17);
            this.lblUsuario.TabIndex = 5;
            this.lblUsuario.Text = "El Usuario:";
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 550);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.contenedor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.menuTitulo);
            this.Name = "Inicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form De Inicio";
            this.Load += new System.EventHandler(this.Inicio_Load);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblUsuario;
        private FontAwesome.Sharp.IconMenuItem menuReporte;
        private FontAwesome.Sharp.IconMenuItem subMenuRDotacion;
        private FontAwesome.Sharp.IconMenuItem subMenuRCambio;
        private FontAwesome.Sharp.IconMenuItem subMenuRFecha;
        private FontAwesome.Sharp.IconMenuItem subMenuRPersonal;
        private FontAwesome.Sharp.IconMenuItem menuPersonal;
        public System.Windows.Forms.MenuStrip menu;
    }
}

