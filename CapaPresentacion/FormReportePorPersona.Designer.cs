namespace CapaPresentacion
{
    partial class FormReportePorPersona
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxCI = new System.Windows.Forms.TextBox();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvDotacion = new System.Windows.Forms.DataGridView();
            this.NombreProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreTalla = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Color = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Unidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaDotacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Comentario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCambioDotacion = new System.Windows.Forms.DataGridView();
            this.NombreP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dcantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DTalla = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DColor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DUnidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DComentario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.infoUsuario = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDotacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCambioDotacion)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 450);
            this.label1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(26, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "CI:";
            // 
            // textBoxCI
            // 
            this.textBoxCI.Location = new System.Drawing.Point(29, 101);
            this.textBoxCI.Name = "textBoxCI";
            this.textBoxCI.Size = new System.Drawing.Size(114, 20);
            this.textBoxCI.TabIndex = 2;
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(29, 140);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(114, 20);
            this.textBoxNombre.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(26, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nombre:";
            // 
            // iconButton1
            // 
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.SearchLocation;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 28;
            this.iconButton1.Location = new System.Drawing.Point(29, 166);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(114, 32);
            this.iconButton1.TabIndex = 5;
            this.iconButton1.Text = "Buscar";
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton1.UseVisualStyleBackColor = true;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // iconButton2
            // 
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.Print;
            this.iconButton2.IconColor = System.Drawing.Color.Black;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.IconSize = 28;
            this.iconButton2.Location = new System.Drawing.Point(29, 204);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Size = new System.Drawing.Size(114, 32);
            this.iconButton2.TabIndex = 6;
            this.iconButton2.Text = "Imprimir";
            this.iconButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton2.UseVisualStyleBackColor = true;
            this.iconButton2.Click += new System.EventHandler(this.iconButton2_Click);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(187, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(497, 28);
            this.label4.TabIndex = 7;
            this.label4.Text = "Lista De Dotacion Ropa de Trabajo";
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(196, 253);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(488, 32);
            this.label5.TabIndex = 8;
            this.label5.Text = "Lista de Cambios";
            // 
            // dgvDotacion
            // 
            this.dgvDotacion.AllowUserToAddRows = false;
            this.dgvDotacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDotacion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NombreProducto,
            this.Cantidad,
            this.NombreTalla,
            this.Color,
            this.Unidad,
            this.FechaDotacion,
            this.Comentario});
            this.dgvDotacion.Location = new System.Drawing.Point(190, 101);
            this.dgvDotacion.MultiSelect = false;
            this.dgvDotacion.Name = "dgvDotacion";
            this.dgvDotacion.ReadOnly = true;
            this.dgvDotacion.Size = new System.Drawing.Size(494, 138);
            this.dgvDotacion.TabIndex = 9;
            // 
            // NombreProducto
            // 
            this.NombreProducto.HeaderText = "Producto";
            this.NombreProducto.Name = "NombreProducto";
            this.NombreProducto.ReadOnly = true;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            // 
            // NombreTalla
            // 
            this.NombreTalla.HeaderText = "Talla";
            this.NombreTalla.Name = "NombreTalla";
            this.NombreTalla.ReadOnly = true;
            // 
            // Color
            // 
            this.Color.HeaderText = "Color";
            this.Color.Name = "Color";
            this.Color.ReadOnly = true;
            // 
            // Unidad
            // 
            this.Unidad.HeaderText = "Unidad";
            this.Unidad.Name = "Unidad";
            this.Unidad.ReadOnly = true;
            // 
            // FechaDotacion
            // 
            this.FechaDotacion.HeaderText = "Fecha";
            this.FechaDotacion.Name = "FechaDotacion";
            this.FechaDotacion.ReadOnly = true;
            // 
            // Comentario
            // 
            this.Comentario.HeaderText = "Comentario";
            this.Comentario.Name = "Comentario";
            this.Comentario.ReadOnly = true;
            // 
            // dgvCambioDotacion
            // 
            this.dgvCambioDotacion.AllowUserToAddRows = false;
            this.dgvCambioDotacion.AllowUserToDeleteRows = false;
            this.dgvCambioDotacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCambioDotacion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NombreP,
            this.Dcantidad,
            this.DTalla,
            this.DColor,
            this.DUnidad,
            this.Fecha,
            this.DComentario});
            this.dgvCambioDotacion.Location = new System.Drawing.Point(190, 288);
            this.dgvCambioDotacion.Name = "dgvCambioDotacion";
            this.dgvCambioDotacion.Size = new System.Drawing.Size(494, 150);
            this.dgvCambioDotacion.TabIndex = 10;
            // 
            // NombreP
            // 
            this.NombreP.HeaderText = "Producto";
            this.NombreP.Name = "NombreP";
            // 
            // Dcantidad
            // 
            this.Dcantidad.HeaderText = "Cantidad";
            this.Dcantidad.Name = "Dcantidad";
            // 
            // DTalla
            // 
            this.DTalla.HeaderText = "Talla";
            this.DTalla.Name = "DTalla";
            // 
            // DColor
            // 
            this.DColor.HeaderText = "Color";
            this.DColor.Name = "DColor";
            // 
            // DUnidad
            // 
            this.DUnidad.HeaderText = "Unidad";
            this.DUnidad.Name = "DUnidad";
            // 
            // Fecha
            // 
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            // 
            // DComentario
            // 
            this.DComentario.HeaderText = "Comentario";
            this.DComentario.Name = "DComentario";
            // 
            // infoUsuario
            // 
            this.infoUsuario.BackColor = System.Drawing.Color.White;
            this.infoUsuario.Location = new System.Drawing.Point(187, 9);
            this.infoUsuario.Name = "infoUsuario";
            this.infoUsuario.Size = new System.Drawing.Size(497, 40);
            this.infoUsuario.TabIndex = 11;
            // 
            // FormReportePorPersona
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.infoUsuario);
            this.Controls.Add(this.dgvCambioDotacion);
            this.Controls.Add(this.dgvDotacion);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.iconButton2);
            this.Controls.Add(this.iconButton1);
            this.Controls.Add(this.textBoxNombre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxCI);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormReportePorPersona";
            this.Text = "FormReportePorPersona";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDotacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCambioDotacion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxCI;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.Label label3;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton iconButton2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvDotacion;
        private System.Windows.Forms.DataGridView dgvCambioDotacion;
        private System.Windows.Forms.Label infoUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreTalla;
        private System.Windows.Forms.DataGridViewTextBoxColumn Color;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaDotacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Comentario;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreP;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dcantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn DTalla;
        private System.Windows.Forms.DataGridViewTextBoxColumn DColor;
        private System.Windows.Forms.DataGridViewTextBoxColumn DUnidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn DComentario;
    }
}