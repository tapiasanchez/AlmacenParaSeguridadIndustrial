namespace CapaPresentacion
{
    partial class FormTallas
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
            this.textNombre = new System.Windows.Forms.TextBox();
            this.btnGuardarTalla = new FontAwesome.Sharp.IconButton();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvTalla = new System.Windows.Forms.DataGridView();
            this.idtalla = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreTalla = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSearch = new FontAwesome.Sharp.IconButton();
            this.textBuscar = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTalla)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 370);
            this.label1.TabIndex = 0;
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre";
            // 
            // textNombre
            // 
            this.textNombre.Location = new System.Drawing.Point(14, 222);
            this.textNombre.Name = "textNombre";
            this.textNombre.Size = new System.Drawing.Size(109, 20);
            this.textNombre.TabIndex = 2;
            // 
            // btnGuardarTalla
            // 
            this.btnGuardarTalla.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarTalla.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk;
            this.btnGuardarTalla.IconColor = System.Drawing.Color.Black;
            this.btnGuardarTalla.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnGuardarTalla.IconSize = 38;
            this.btnGuardarTalla.Location = new System.Drawing.Point(14, 260);
            this.btnGuardarTalla.Name = "btnGuardarTalla";
            this.btnGuardarTalla.Size = new System.Drawing.Size(109, 44);
            this.btnGuardarTalla.TabIndex = 3;
            this.btnGuardarTalla.Text = "Guardar";
            this.btnGuardarTalla.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGuardarTalla.UseVisualStyleBackColor = true;
            this.btnGuardarTalla.Click += new System.EventHandler(this.BtnGuardarTalla_Click);
            // 
            // iconButton2
            // 
            this.iconButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.FileText;
            this.iconButton2.IconColor = System.Drawing.Color.Black;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.IconSize = 38;
            this.iconButton2.Location = new System.Drawing.Point(14, 310);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Size = new System.Drawing.Size(109, 41);
            this.iconButton2.TabIndex = 4;
            this.iconButton2.Text = "Cargar";
            this.iconButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton2.UseVisualStyleBackColor = true;
            this.iconButton2.Click += new System.EventHandler(this.IconButton2_Click);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(219, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(350, 48);
            this.label3.TabIndex = 5;
            this.label3.Text = "Lista de Tallas";
            // 
            // dgvTalla
            // 
            this.dgvTalla.AllowUserToAddRows = false;
            this.dgvTalla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTalla.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idtalla,
            this.NombreTalla});
            this.dgvTalla.Location = new System.Drawing.Point(222, 117);
            this.dgvTalla.MultiSelect = false;
            this.dgvTalla.Name = "dgvTalla";
            this.dgvTalla.Size = new System.Drawing.Size(347, 150);
            this.dgvTalla.TabIndex = 6;
            // 
            // idtalla
            // 
            this.idtalla.HeaderText = "Nro";
            this.idtalla.Name = "idtalla";
            // 
            // NombreTalla
            // 
            this.NombreTalla.HeaderText = "Talla";
            this.NombreTalla.Name = "NombreTalla";
            // 
            // btnSearch
            // 
            this.btnSearch.IconChar = FontAwesome.Sharp.IconChar.Sistrix;
            this.btnSearch.IconColor = System.Drawing.Color.Black;
            this.btnSearch.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSearch.IconSize = 28;
            this.btnSearch.Location = new System.Drawing.Point(517, 62);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(42, 32);
            this.btnSearch.TabIndex = 11;
            this.btnSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // textBuscar
            // 
            this.textBuscar.Location = new System.Drawing.Point(414, 69);
            this.textBuscar.Name = "textBuscar";
            this.textBuscar.Size = new System.Drawing.Size(100, 20);
            this.textBuscar.TabIndex = 10;
            // 
            // FormTallas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(598, 370);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.textBuscar);
            this.Controls.Add(this.dgvTalla);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.iconButton2);
            this.Controls.Add(this.btnGuardarTalla);
            this.Controls.Add(this.textNombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormTallas";
            this.Text = "FormTallas";
            this.Load += new System.EventHandler(this.FormTallas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTalla)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textNombre;
        private FontAwesome.Sharp.IconButton btnGuardarTalla;
        private FontAwesome.Sharp.IconButton iconButton2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvTalla;
        private System.Windows.Forms.DataGridViewTextBoxColumn idtalla;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreTalla;
        private FontAwesome.Sharp.IconButton btnSearch;
        private System.Windows.Forms.TextBox textBuscar;
    }
}