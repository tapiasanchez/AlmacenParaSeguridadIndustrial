namespace CapaPresentacion
{
    partial class FormCambiosPF
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
            this.btnCerrar = new FontAwesome.Sharp.IconButton();
            this.btnImCambios = new FontAwesome.Sharp.IconButton();
            this.dgvCambios = new System.Windows.Forms.DataGridView();
            this.CodigoP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TallaP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColorP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnidadP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantidadP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantidadTol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCambios)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCerrar
            // 
            this.btnCerrar.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnCerrar.IconColor = System.Drawing.Color.Black;
            this.btnCerrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCerrar.Location = new System.Drawing.Point(275, 242);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(75, 23);
            this.btnCerrar.TabIndex = 7;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // btnImCambios
            // 
            this.btnImCambios.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnImCambios.IconColor = System.Drawing.Color.Black;
            this.btnImCambios.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnImCambios.Location = new System.Drawing.Point(156, 242);
            this.btnImCambios.Name = "btnImCambios";
            this.btnImCambios.Size = new System.Drawing.Size(75, 23);
            this.btnImCambios.TabIndex = 6;
            this.btnImCambios.Text = "Imprimir";
            this.btnImCambios.UseVisualStyleBackColor = true;
            this.btnImCambios.Click += new System.EventHandler(this.BtnImCambios_Click);
            // 
            // dgvCambios
            // 
            this.dgvCambios.AllowUserToAddRows = false;
            this.dgvCambios.AllowUserToDeleteRows = false;
            this.dgvCambios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCambios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodigoP,
            this.NombreP,
            this.TallaP,
            this.ColorP,
            this.UnidadP,
            this.CantidadP,
            this.CantidadTol});
            this.dgvCambios.Location = new System.Drawing.Point(16, 60);
            this.dgvCambios.Name = "dgvCambios";
            this.dgvCambios.Size = new System.Drawing.Size(642, 150);
            this.dgvCambios.TabIndex = 5;
            // 
            // CodigoP
            // 
            this.CodigoP.HeaderText = "Codigo";
            this.CodigoP.Name = "CodigoP";
            // 
            // NombreP
            // 
            this.NombreP.HeaderText = "Producto";
            this.NombreP.Name = "NombreP";
            // 
            // TallaP
            // 
            this.TallaP.HeaderText = "Talla";
            this.TallaP.Name = "TallaP";
            // 
            // ColorP
            // 
            this.ColorP.HeaderText = "Color";
            this.ColorP.Name = "ColorP";
            // 
            // UnidadP
            // 
            this.UnidadP.HeaderText = "Unidad";
            this.UnidadP.Name = "UnidadP";
            // 
            // CantidadP
            // 
            this.CantidadP.HeaderText = "Stock";
            this.CantidadP.Name = "CantidadP";
            // 
            // CantidadTol
            // 
            this.CantidadTol.HeaderText = "Salida Total";
            this.CantidadTol.Name = "CantidadTol";
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(15, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(643, 44);
            this.label5.TabIndex = 4;
            this.label5.Text = "Cambios";
            // 
            // FormCambiosPF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnImCambios);
            this.Controls.Add(this.dgvCambios);
            this.Controls.Add(this.label5);
            this.Name = "FormCambiosPF";
            this.Text = "FormCambiosPF";
            this.Load += new System.EventHandler(this.FormCambiosPF_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCambios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private FontAwesome.Sharp.IconButton btnCerrar;
        private FontAwesome.Sharp.IconButton btnImCambios;
        private System.Windows.Forms.DataGridView dgvCambios;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoP;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreP;
        private System.Windows.Forms.DataGridViewTextBoxColumn TallaP;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColorP;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnidadP;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantidadP;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantidadTol;
        private System.Windows.Forms.Label label5;
    }
}