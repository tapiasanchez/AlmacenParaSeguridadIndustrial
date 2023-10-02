namespace CapaPresentacion
{
    partial class FormPuestoDeTrabajo
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
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvPuestoDeTrabajo = new System.Windows.Forms.DataGridView();
            this.IdPuesto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombrePuesto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPuestoDeTrabajo)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(176, 372);
            this.label1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre";
            // 
            // textNombre
            // 
            this.textNombre.Location = new System.Drawing.Point(12, 194);
            this.textNombre.Name = "textNombre";
            this.textNombre.Size = new System.Drawing.Size(146, 20);
            this.textNombre.TabIndex = 2;
            // 
            // iconButton1
            // 
            this.iconButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.CircleUser;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 38;
            this.iconButton1.Location = new System.Drawing.Point(12, 254);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(146, 44);
            this.iconButton1.TabIndex = 3;
            this.iconButton1.Text = "Registrar";
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton1.UseVisualStyleBackColor = true;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // iconButton2
            // 
            this.iconButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.FileArrowUp;
            this.iconButton2.IconColor = System.Drawing.Color.Black;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.IconSize = 38;
            this.iconButton2.Location = new System.Drawing.Point(15, 304);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Size = new System.Drawing.Size(143, 40);
            this.iconButton2.TabIndex = 4;
            this.iconButton2.Text = "Cargar";
            this.iconButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton2.UseVisualStyleBackColor = true;
            this.iconButton2.Click += new System.EventHandler(this.iconButton2_Click);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(203, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(357, 39);
            this.label3.TabIndex = 5;
            this.label3.Text = "Lista de Puestos de Trabajo";
            // 
            // dgvPuestoDeTrabajo
            // 
            this.dgvPuestoDeTrabajo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPuestoDeTrabajo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdPuesto,
            this.NombrePuesto});
            this.dgvPuestoDeTrabajo.Location = new System.Drawing.Point(207, 117);
            this.dgvPuestoDeTrabajo.Name = "dgvPuestoDeTrabajo";
            this.dgvPuestoDeTrabajo.Size = new System.Drawing.Size(353, 195);
            this.dgvPuestoDeTrabajo.TabIndex = 6;
            // 
            // IdPuesto
            // 
            this.IdPuesto.HeaderText = "Nro";
            this.IdPuesto.Name = "IdPuesto";
            // 
            // NombrePuesto
            // 
            this.NombrePuesto.HeaderText = "Nombre";
            this.NombrePuesto.Name = "NombrePuesto";
            // 
            // FormPuestoDeTrabajo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(606, 372);
            this.Controls.Add(this.dgvPuestoDeTrabajo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.iconButton2);
            this.Controls.Add(this.iconButton1);
            this.Controls.Add(this.textNombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormPuestoDeTrabajo";
            this.Text = "FormPuestoDeTrabajo";
            this.Load += new System.EventHandler(this.FormPuestoDeTrabajo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPuestoDeTrabajo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textNombre;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton iconButton2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvPuestoDeTrabajo;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdPuesto;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombrePuesto;
    }
}