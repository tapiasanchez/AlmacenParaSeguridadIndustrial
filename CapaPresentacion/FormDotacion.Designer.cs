namespace CapaPresentacion
{
    partial class FormDotacion
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
            this.dtpDotacion = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textCi = new System.Windows.Forms.TextBox();
            this.textNombre = new System.Windows.Forms.TextBox();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.infoUsuario = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxPuesto = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxComentario = new System.Windows.Forms.TextBox();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.iconButton3 = new FontAwesome.Sharp.IconButton();
            this.dgvListaDotacion = new System.Windows.Forms.DataGridView();
            this.idProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textboxCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkList = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.codForm = new System.Windows.Forms.TextBox();
            this.codigoFormulario = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaDotacion)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(157, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(619, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "Registro de Dotacion";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dtpDotacion
            // 
            this.dtpDotacion.Enabled = false;
            this.dtpDotacion.Location = new System.Drawing.Point(609, 29);
            this.dtpDotacion.Name = "dtpDotacion";
            this.dtpDotacion.Size = new System.Drawing.Size(154, 20);
            this.dtpDotacion.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(162, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "CI:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(326, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nombre:";
            // 
            // textCi
            // 
            this.textCi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textCi.Location = new System.Drawing.Point(192, 64);
            this.textCi.Name = "textCi";
            this.textCi.Size = new System.Drawing.Size(128, 21);
            this.textCi.TabIndex = 4;
            // 
            // textNombre
            // 
            this.textNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textNombre.Location = new System.Drawing.Point(394, 67);
            this.textNombre.Name = "textNombre";
            this.textNombre.Size = new System.Drawing.Size(190, 21);
            this.textNombre.TabIndex = 5;
            // 
            // iconButton1
            // 
            this.iconButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.SearchLocation;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 28;
            this.iconButton1.Location = new System.Drawing.Point(617, 63);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(103, 32);
            this.iconButton1.TabIndex = 6;
            this.iconButton1.Text = "Buscar";
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton1.UseVisualStyleBackColor = true;
            this.iconButton1.Click += new System.EventHandler(this.IconButton1_Click);
            // 
            // infoUsuario
            // 
            this.infoUsuario.BackColor = System.Drawing.Color.White;
            this.infoUsuario.Location = new System.Drawing.Point(160, 98);
            this.infoUsuario.Name = "infoUsuario";
            this.infoUsuario.Size = new System.Drawing.Size(560, 36);
            this.infoUsuario.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(160, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(269, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Lista de Dotacion Por Puesto de Trabajo:";
            // 
            // comboBoxPuesto
            // 
            this.comboBoxPuesto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxPuesto.FormattingEnabled = true;
            this.comboBoxPuesto.Location = new System.Drawing.Point(435, 141);
            this.comboBoxPuesto.Name = "comboBoxPuesto";
            this.comboBoxPuesto.Size = new System.Drawing.Size(157, 23);
            this.comboBoxPuesto.TabIndex = 9;
            this.comboBoxPuesto.SelectedIndexChanged += new System.EventHandler(this.ComboBoxPuesto_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(616, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Comentario:";
            // 
            // textBoxComentario
            // 
            this.textBoxComentario.Location = new System.Drawing.Point(532, 173);
            this.textBoxComentario.Multiline = true;
            this.textBoxComentario.Name = "textBoxComentario";
            this.textBoxComentario.Size = new System.Drawing.Size(188, 184);
            this.textBoxComentario.TabIndex = 12;
            // 
            // iconButton2
            // 
            this.iconButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.FileZipper;
            this.iconButton2.IconColor = System.Drawing.Color.Black;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.IconSize = 28;
            this.iconButton2.Location = new System.Drawing.Point(245, 367);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Size = new System.Drawing.Size(112, 41);
            this.iconButton2.TabIndex = 13;
            this.iconButton2.Text = "Guardar";
            this.iconButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton2.UseVisualStyleBackColor = true;
            this.iconButton2.Click += new System.EventHandler(this.IconButton2_Click);
            // 
            // iconButton3
            // 
            this.iconButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton3.IconChar = FontAwesome.Sharp.IconChar.Print;
            this.iconButton3.IconColor = System.Drawing.Color.Black;
            this.iconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton3.IconSize = 28;
            this.iconButton3.Location = new System.Drawing.Point(402, 369);
            this.iconButton3.Name = "iconButton3";
            this.iconButton3.Size = new System.Drawing.Size(96, 42);
            this.iconButton3.TabIndex = 14;
            this.iconButton3.Text = "Imprimir";
            this.iconButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton3.UseVisualStyleBackColor = true;
            this.iconButton3.Click += new System.EventHandler(this.IconButton3_Click);
            // 
            // dgvListaDotacion
            // 
            this.dgvListaDotacion.AllowUserToAddRows = false;
            this.dgvListaDotacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaDotacion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idProducto,
            this.NombreProducto,
            this.textboxCantidad,
            this.checkList});
            this.dgvListaDotacion.Location = new System.Drawing.Point(165, 182);
            this.dgvListaDotacion.Name = "dgvListaDotacion";
            this.dgvListaDotacion.Size = new System.Drawing.Size(363, 175);
            this.dgvListaDotacion.TabIndex = 15;
            // 
            // idProducto
            // 
            this.idProducto.HeaderText = "nro";
            this.idProducto.Name = "idProducto";
            this.idProducto.Visible = false;
            this.idProducto.Width = 50;
            // 
            // NombreProducto
            // 
            this.NombreProducto.HeaderText = "Producto";
            this.NombreProducto.Name = "NombreProducto";
            this.NombreProducto.ReadOnly = true;
            this.NombreProducto.Width = 200;
            // 
            // textboxCantidad
            // 
            this.textboxCantidad.HeaderText = "Cantidad";
            this.textboxCantidad.Name = "textboxCantidad";
            this.textboxCantidad.Width = 50;
            // 
            // checkList
            // 
            this.checkList.HeaderText = "";
            this.checkList.Name = "checkList";
            this.checkList.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.checkList.Width = 50;
            // 
            // codForm
            // 
            this.codForm.Location = new System.Drawing.Point(461, 32);
            this.codForm.Name = "codForm";
            this.codForm.Size = new System.Drawing.Size(128, 20);
            this.codForm.TabIndex = 17;
            // 
            // codigoFormulario
            // 
            this.codigoFormulario.AutoSize = true;
            this.codigoFormulario.BackColor = System.Drawing.Color.White;
            this.codigoFormulario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codigoFormulario.Location = new System.Drawing.Point(313, 33);
            this.codigoFormulario.Name = "codigoFormulario";
            this.codigoFormulario.Size = new System.Drawing.Size(147, 17);
            this.codigoFormulario.TabIndex = 18;
            this.codigoFormulario.Text = "Codigo de Formulario:";
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Dock = System.Windows.Forms.DockStyle.Left;
            this.label6.Location = new System.Drawing.Point(0, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(151, 413);
            this.label6.TabIndex = 19;
            // 
            // FormDotacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(788, 413);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.codigoFormulario);
            this.Controls.Add(this.codForm);
            this.Controls.Add(this.dgvListaDotacion);
            this.Controls.Add(this.iconButton3);
            this.Controls.Add(this.iconButton2);
            this.Controls.Add(this.textBoxComentario);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBoxPuesto);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.infoUsuario);
            this.Controls.Add(this.iconButton1);
            this.Controls.Add(this.textNombre);
            this.Controls.Add(this.textCi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpDotacion);
            this.Controls.Add(this.label1);
            this.Name = "FormDotacion";
            this.Text = "FormDotacion";
            this.Load += new System.EventHandler(this.FormDotacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaDotacion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpDotacion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textCi;
        private System.Windows.Forms.TextBox textNombre;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.Label infoUsuario;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxPuesto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxComentario;
        private FontAwesome.Sharp.IconButton iconButton2;
        private FontAwesome.Sharp.IconButton iconButton3;
        private System.Windows.Forms.DataGridView dgvListaDotacion;
        private System.Windows.Forms.TextBox codForm;
        private System.Windows.Forms.Label codigoFormulario;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn textboxCantidad;
        private System.Windows.Forms.DataGridViewCheckBoxColumn checkList;
        private System.Windows.Forms.Label label6;
    }
}