namespace CapaPresentacion
{
    partial class FormProducto
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
            this.textCodigo = new System.Windows.Forms.TextBox();
            this.textDescripcion = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textProducto = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textCantidad = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxTalla = new System.Windows.Forms.ComboBox();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpRegistro = new System.Windows.Forms.DateTimePicker();
            this.textUnidad = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textColor = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.color = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvProducto = new System.Windows.Forms.DataGridView();
            this.codigoProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colorProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unidadProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreTalla = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnBuscar = new FontAwesome.Sharp.IconButton();
            this.textBuscar = new System.Windows.Forms.TextBox();
            this.comboBoxBuscar = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducto)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 587);
            this.label1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 44);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "Codigo";
            // 
            // textCodigo
            // 
            this.textCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textCodigo.Location = new System.Drawing.Point(28, 68);
            this.textCodigo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textCodigo.Name = "textCodigo";
            this.textCodigo.Size = new System.Drawing.Size(171, 23);
            this.textCodigo.TabIndex = 2;
            // 
            // textDescripcion
            // 
            this.textDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textDescripcion.Location = new System.Drawing.Point(26, 166);
            this.textDescripcion.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textDescripcion.Multiline = true;
            this.textDescripcion.Name = "textDescripcion";
            this.textDescripcion.Size = new System.Drawing.Size(171, 88);
            this.textDescripcion.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(28, 146);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 27);
            this.label3.TabIndex = 3;
            this.label3.Text = "Descripcion";
            // 
            // textProducto
            // 
            this.textProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textProducto.Location = new System.Drawing.Point(28, 119);
            this.textProducto.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textProducto.Name = "textProducto";
            this.textProducto.Size = new System.Drawing.Size(171, 23);
            this.textProducto.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(30, 99);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(169, 27);
            this.label4.TabIndex = 5;
            this.label4.Text = "Producto";
            // 
            // textCantidad
            // 
            this.textCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textCantidad.Location = new System.Drawing.Point(29, 277);
            this.textCantidad.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textCantidad.Name = "textCantidad";
            this.textCantidad.Size = new System.Drawing.Size(171, 23);
            this.textCantidad.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(30, 257);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(170, 27);
            this.label5.TabIndex = 7;
            this.label5.Text = "Cantidad";
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(26, 406);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(170, 27);
            this.label6.TabIndex = 9;
            this.label6.Text = "Talla";
            // 
            // comboBoxTalla
            // 
            this.comboBoxTalla.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxTalla.FormattingEnabled = true;
            this.comboBoxTalla.Location = new System.Drawing.Point(27, 427);
            this.comboBoxTalla.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.comboBoxTalla.Name = "comboBoxTalla";
            this.comboBoxTalla.Size = new System.Drawing.Size(172, 24);
            this.comboBoxTalla.TabIndex = 10;
            // 
            // iconButton1
            // 
            this.iconButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Download;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 38;
            this.iconButton1.Location = new System.Drawing.Point(29, 468);
            this.iconButton1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(169, 45);
            this.iconButton1.TabIndex = 11;
            this.iconButton1.Text = "Guardar";
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton1.UseVisualStyleBackColor = true;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(232, 30);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(700, 40);
            this.label7.TabIndex = 12;
            this.label7.Text = "Lista de Productos existentes";
            // 
            // dtpRegistro
            // 
            this.dtpRegistro.Enabled = false;
            this.dtpRegistro.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpRegistro.Location = new System.Drawing.Point(76, 19);
            this.dtpRegistro.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dtpRegistro.Name = "dtpRegistro";
            this.dtpRegistro.Size = new System.Drawing.Size(137, 21);
            this.dtpRegistro.TabIndex = 14;
            // 
            // textUnidad
            // 
            this.textUnidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textUnidad.Location = new System.Drawing.Point(25, 376);
            this.textUnidad.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textUnidad.Name = "textUnidad";
            this.textUnidad.Size = new System.Drawing.Size(171, 23);
            this.textUnidad.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(26, 356);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(170, 27);
            this.label8.TabIndex = 15;
            this.label8.Text = "Unidad";
            // 
            // textColor
            // 
            this.textColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textColor.Location = new System.Drawing.Point(26, 327);
            this.textColor.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textColor.Name = "textColor";
            this.textColor.Size = new System.Drawing.Size(171, 23);
            this.textColor.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(27, 307);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(170, 27);
            this.label9.TabIndex = 17;
            this.label9.Text = "Color";
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.Name = "Codigo";
            // 
            // color
            // 
            this.color.HeaderText = "Color";
            this.color.Name = "color";
            // 
            // unidad
            // 
            this.unidad.HeaderText = "Unidad";
            this.unidad.Name = "unidad";
            // 
            // dgvProducto
            // 
            this.dgvProducto.AllowUserToAddRows = false;
            this.dgvProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigoProducto,
            this.NombreProducto,
            this.colorProducto,
            this.unidadProducto,
            this.descripcionP,
            this.cantidadProducto,
            this.NombreTalla});
            this.dgvProducto.Location = new System.Drawing.Point(254, 90);
            this.dgvProducto.MultiSelect = false;
            this.dgvProducto.Name = "dgvProducto";
            this.dgvProducto.Size = new System.Drawing.Size(541, 150);
            this.dgvProducto.TabIndex = 19;
            // 
            // codigoProducto
            // 
            this.codigoProducto.HeaderText = "Codigo";
            this.codigoProducto.Name = "codigoProducto";
            // 
            // NombreProducto
            // 
            this.NombreProducto.HeaderText = "Producto";
            this.NombreProducto.Name = "NombreProducto";
            // 
            // colorProducto
            // 
            this.colorProducto.HeaderText = "Color";
            this.colorProducto.Name = "colorProducto";
            // 
            // unidadProducto
            // 
            this.unidadProducto.HeaderText = "Unidad";
            this.unidadProducto.Name = "unidadProducto";
            // 
            // descripcionP
            // 
            this.descripcionP.HeaderText = "Descripcion";
            this.descripcionP.Name = "descripcionP";
            // 
            // cantidadProducto
            // 
            this.cantidadProducto.HeaderText = "Stock";
            this.cantidadProducto.Name = "cantidadProducto";
            // 
            // NombreTalla
            // 
            this.NombreTalla.HeaderText = "Talla";
            this.NombreTalla.Name = "NombreTalla";
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.SkyBlue;
            this.btnBuscar.IconChar = FontAwesome.Sharp.IconChar.Searchengin;
            this.btnBuscar.IconColor = System.Drawing.Color.White;
            this.btnBuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBuscar.IconSize = 28;
            this.btnBuscar.Location = new System.Drawing.Point(864, 37);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(61, 29);
            this.btnBuscar.TabIndex = 23;
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // textBuscar
            // 
            this.textBuscar.Location = new System.Drawing.Point(708, 42);
            this.textBuscar.Name = "textBuscar";
            this.textBuscar.Size = new System.Drawing.Size(151, 21);
            this.textBuscar.TabIndex = 22;
            // 
            // comboBoxBuscar
            // 
            this.comboBoxBuscar.FormattingEnabled = true;
            this.comboBoxBuscar.Location = new System.Drawing.Point(549, 41);
            this.comboBoxBuscar.Name = "comboBoxBuscar";
            this.comboBoxBuscar.Size = new System.Drawing.Size(153, 23);
            this.comboBoxBuscar.TabIndex = 21;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(463, 41);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(81, 17);
            this.label10.TabIndex = 20;
            this.label10.Text = "Buscar por:";
            // 
            // FormProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(959, 587);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.textBuscar);
            this.Controls.Add(this.comboBoxBuscar);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dgvProducto);
            this.Controls.Add(this.textColor);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textUnidad);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dtpRegistro);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.iconButton1);
            this.Controls.Add(this.comboBoxTalla);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textCantidad);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textProducto);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textDescripcion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textCodigo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FormProducto";
            this.Text = "FormProducto";
            this.Load += new System.EventHandler(this.FormProducto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textCodigo;
        private System.Windows.Forms.TextBox textDescripcion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textProducto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textCantidad;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBoxTalla;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtpRegistro;
        private System.Windows.Forms.TextBox textUnidad;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textColor;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn color;
        private System.Windows.Forms.DataGridViewTextBoxColumn unidad;
        private System.Windows.Forms.DataGridView dgvProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn colorProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn unidadProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionP;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreTalla;
        private FontAwesome.Sharp.IconButton btnBuscar;
        private System.Windows.Forms.TextBox textBuscar;
        private System.Windows.Forms.ComboBox comboBoxBuscar;
        private System.Windows.Forms.Label label10;
    }
}