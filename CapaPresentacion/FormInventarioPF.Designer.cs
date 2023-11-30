namespace CapaPresentacion
{
    partial class FormInventarioPF
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
            this.iconButton5 = new FontAwesome.Sharp.IconButton();
            this.btnImInventario = new FontAwesome.Sharp.IconButton();
            this.dgvInventario = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Talla = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Unidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Color = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IngresoTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SalidaTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventario)).BeginInit();
            this.SuspendLayout();
            // 
            // iconButton5
            // 
            this.iconButton5.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButton5.IconColor = System.Drawing.Color.Black;
            this.iconButton5.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton5.Location = new System.Drawing.Point(313, 242);
            this.iconButton5.Name = "iconButton5";
            this.iconButton5.Size = new System.Drawing.Size(75, 23);
            this.iconButton5.TabIndex = 7;
            this.iconButton5.Text = "Cerrar";
            this.iconButton5.UseVisualStyleBackColor = true;
            this.iconButton5.Click += new System.EventHandler(this.IconButton5_Click);
            // 
            // btnImInventario
            // 
            this.btnImInventario.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnImInventario.IconColor = System.Drawing.Color.Black;
            this.btnImInventario.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnImInventario.Location = new System.Drawing.Point(197, 242);
            this.btnImInventario.Name = "btnImInventario";
            this.btnImInventario.Size = new System.Drawing.Size(75, 23);
            this.btnImInventario.TabIndex = 6;
            this.btnImInventario.Text = "Imprimir";
            this.btnImInventario.UseVisualStyleBackColor = true;
            this.btnImInventario.Click += new System.EventHandler(this.BtnImInventario_Click);
            // 
            // dgvInventario
            // 
            this.dgvInventario.AllowUserToAddRows = false;
            this.dgvInventario.AllowUserToDeleteRows = false;
            this.dgvInventario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInventario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.NombreProducto,
            this.Talla,
            this.Unidad,
            this.Color,
            this.IngresoTotal,
            this.SalidaTotal,
            this.Cantidad});
            this.dgvInventario.Location = new System.Drawing.Point(16, 69);
            this.dgvInventario.Name = "dgvInventario";
            this.dgvInventario.Size = new System.Drawing.Size(643, 150);
            this.dgvInventario.TabIndex = 5;
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.Name = "Codigo";
            // 
            // NombreProducto
            // 
            this.NombreProducto.HeaderText = "Producto";
            this.NombreProducto.Name = "NombreProducto";
            // 
            // Talla
            // 
            this.Talla.HeaderText = "Talla";
            this.Talla.Name = "Talla";
            // 
            // Unidad
            // 
            this.Unidad.HeaderText = "Unidad";
            this.Unidad.Name = "Unidad";
            // 
            // Color
            // 
            this.Color.HeaderText = "Color";
            this.Color.Name = "Color";
            // 
            // IngresoTotal
            // 
            this.IngresoTotal.HeaderText = "Ingreso Total";
            this.IngresoTotal.Name = "IngresoTotal";
            // 
            // SalidaTotal
            // 
            this.SalidaTotal.HeaderText = "Salida Total";
            this.SalidaTotal.Name = "SalidaTotal";
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Stock";
            this.Cantidad.Name = "Cantidad";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(13, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(646, 43);
            this.label4.TabIndex = 4;
            this.label4.Text = "Inventario";
            // 
            // FormInventarioPF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.iconButton5);
            this.Controls.Add(this.btnImInventario);
            this.Controls.Add(this.dgvInventario);
            this.Controls.Add(this.label4);
            this.Name = "FormInventarioPF";
            this.Text = "FormInventarioPF";
            this.Load += new System.EventHandler(this.FormInventarioPF_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventario)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private FontAwesome.Sharp.IconButton iconButton5;
        private FontAwesome.Sharp.IconButton btnImInventario;
        private System.Windows.Forms.DataGridView dgvInventario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Talla;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Color;
        private System.Windows.Forms.DataGridViewTextBoxColumn IngresoTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn SalidaTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.Label label4;
    }
}