namespace CapaPresentacion
{
    partial class FormDotacionPF
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
            this.iconButton6 = new FontAwesome.Sharp.IconButton();
            this.btnDotacion = new FontAwesome.Sharp.IconButton();
            this.dgvDotacion = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.codigoPro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombrePro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tallaPro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColorPro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnidadPro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantidadPro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantidadTotalPro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDotacion)).BeginInit();
            this.SuspendLayout();
            // 
            // iconButton6
            // 
            this.iconButton6.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButton6.IconColor = System.Drawing.Color.Black;
            this.iconButton6.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton6.Location = new System.Drawing.Point(327, 221);
            this.iconButton6.Name = "iconButton6";
            this.iconButton6.Size = new System.Drawing.Size(75, 23);
            this.iconButton6.TabIndex = 7;
            this.iconButton6.Text = "Cerrar";
            this.iconButton6.UseVisualStyleBackColor = true;
            this.iconButton6.Click += new System.EventHandler(this.IconButton6_Click);
            // 
            // btnDotacion
            // 
            this.btnDotacion.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnDotacion.IconColor = System.Drawing.Color.Black;
            this.btnDotacion.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDotacion.Location = new System.Drawing.Point(210, 221);
            this.btnDotacion.Name = "btnDotacion";
            this.btnDotacion.Size = new System.Drawing.Size(75, 23);
            this.btnDotacion.TabIndex = 6;
            this.btnDotacion.Text = "Imprimir";
            this.btnDotacion.UseVisualStyleBackColor = true;
            this.btnDotacion.Click += new System.EventHandler(this.BtnDotacion_Click);
            // 
            // dgvDotacion
            // 
            this.dgvDotacion.AllowUserToAddRows = false;
            this.dgvDotacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDotacion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigoPro,
            this.NombrePro,
            this.tallaPro,
            this.ColorPro,
            this.UnidadPro,
            this.CantidadPro,
            this.CantidadTotalPro});
            this.dgvDotacion.Location = new System.Drawing.Point(15, 58);
            this.dgvDotacion.Name = "dgvDotacion";
            this.dgvDotacion.Size = new System.Drawing.Size(645, 150);
            this.dgvDotacion.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(12, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(648, 43);
            this.label6.TabIndex = 4;
            this.label6.Text = "Dotacion";
            // 
            // codigoPro
            // 
            this.codigoPro.HeaderText = "Codigo";
            this.codigoPro.Name = "codigoPro";
            // 
            // NombrePro
            // 
            this.NombrePro.HeaderText = "Producto";
            this.NombrePro.Name = "NombrePro";
            // 
            // tallaPro
            // 
            this.tallaPro.HeaderText = "Talla";
            this.tallaPro.Name = "tallaPro";
            // 
            // ColorPro
            // 
            this.ColorPro.HeaderText = "Color";
            this.ColorPro.Name = "ColorPro";
            // 
            // UnidadPro
            // 
            this.UnidadPro.HeaderText = "Unidad";
            this.UnidadPro.Name = "UnidadPro";
            // 
            // CantidadPro
            // 
            this.CantidadPro.HeaderText = "Stock";
            this.CantidadPro.Name = "CantidadPro";
            // 
            // CantidadTotalPro
            // 
            this.CantidadTotalPro.HeaderText = "Salida Total";
            this.CantidadTotalPro.Name = "CantidadTotalPro";
            // 
            // FormDotacionPF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 251);
            this.Controls.Add(this.iconButton6);
            this.Controls.Add(this.btnDotacion);
            this.Controls.Add(this.dgvDotacion);
            this.Controls.Add(this.label6);
            this.Name = "FormDotacionPF";
            this.Text = "FormDotacionPrueba";
            this.Load += new System.EventHandler(this.FormDotacionPrueba_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDotacion)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private FontAwesome.Sharp.IconButton iconButton6;
        private FontAwesome.Sharp.IconButton btnDotacion;
        private System.Windows.Forms.DataGridView dgvDotacion;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoPro;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombrePro;
        private System.Windows.Forms.DataGridViewTextBoxColumn tallaPro;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColorPro;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnidadPro;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantidadPro;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantidadTotalPro;
    }
}