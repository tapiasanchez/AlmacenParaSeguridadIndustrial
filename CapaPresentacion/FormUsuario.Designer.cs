namespace CapaPresentacion
{
    partial class FormUsuario
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
            this.btnRegistrar = new FontAwesome.Sharp.IconButton();
            this.btnCargar = new FontAwesome.Sharp.IconButton();
            this.dGVData = new System.Windows.Forms.DataGridView();
            this.Item = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cargo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PuestoDeTrabajo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxBuscar = new System.Windows.Forms.ComboBox();
            this.textBuscar = new System.Windows.Forms.TextBox();
            this.btnBuscar = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.dGVData)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnRegistrar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrar.ForeColor = System.Drawing.Color.White;
            this.btnRegistrar.IconChar = FontAwesome.Sharp.IconChar.CircleUser;
            this.btnRegistrar.IconColor = System.Drawing.Color.White;
            this.btnRegistrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRegistrar.IconSize = 35;
            this.btnRegistrar.Location = new System.Drawing.Point(88, 21);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(96, 42);
            this.btnRegistrar.TabIndex = 0;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRegistrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnCargar
            // 
            this.btnCargar.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnCargar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnCargar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCargar.ForeColor = System.Drawing.Color.White;
            this.btnCargar.IconChar = FontAwesome.Sharp.IconChar.FileArrowUp;
            this.btnCargar.IconColor = System.Drawing.Color.White;
            this.btnCargar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCargar.IconSize = 30;
            this.btnCargar.Location = new System.Drawing.Point(458, 21);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(95, 42);
            this.btnCargar.TabIndex = 1;
            this.btnCargar.Text = "Cargar";
            this.btnCargar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCargar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCargar.UseVisualStyleBackColor = false;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // dGVData
            // 
            this.dGVData.AllowUserToAddRows = false;
            this.dGVData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Item,
            this.CI,
            this.Nombre,
            this.Apellido,
            this.cargo,
            this.unidad,
            this.PuestoDeTrabajo});
            this.dGVData.Location = new System.Drawing.Point(23, 126);
            this.dGVData.MultiSelect = false;
            this.dGVData.Name = "dGVData";
            this.dGVData.Size = new System.Drawing.Size(753, 312);
            this.dGVData.TabIndex = 2;
            // 
            // Item
            // 
            this.Item.HeaderText = "Item";
            this.Item.Name = "Item";
            // 
            // CI
            // 
            this.CI.HeaderText = "CI";
            this.CI.Name = "CI";
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            // 
            // Apellido
            // 
            this.Apellido.HeaderText = "Apellido";
            this.Apellido.Name = "Apellido";
            // 
            // cargo
            // 
            this.cargo.HeaderText = "Cargo";
            this.cargo.Name = "cargo";
            // 
            // unidad
            // 
            this.unidad.HeaderText = "Unidad";
            this.unidad.Name = "unidad";
            // 
            // PuestoDeTrabajo
            // 
            this.PuestoDeTrabajo.HeaderText = "Puesto De Trabajo";
            this.PuestoDeTrabajo.Name = "PuestoDeTrabajo";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(752, 57);
            this.label1.TabIndex = 3;
            this.label1.Text = "Lista de Usuarios";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(314, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Buscar por:";
            // 
            // comboBoxBuscar
            // 
            this.comboBoxBuscar.FormattingEnabled = true;
            this.comboBoxBuscar.Location = new System.Drawing.Point(400, 94);
            this.comboBoxBuscar.Name = "comboBoxBuscar";
            this.comboBoxBuscar.Size = new System.Drawing.Size(153, 21);
            this.comboBoxBuscar.TabIndex = 5;
            this.comboBoxBuscar.Visible = false;
            // 
            // textBuscar
            // 
            this.textBuscar.Location = new System.Drawing.Point(559, 95);
            this.textBuscar.Name = "textBuscar";
            this.textBuscar.Size = new System.Drawing.Size(151, 20);
            this.textBuscar.TabIndex = 6;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.SkyBlue;
            this.btnBuscar.IconChar = FontAwesome.Sharp.IconChar.Searchengin;
            this.btnBuscar.IconColor = System.Drawing.Color.White;
            this.btnBuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBuscar.IconSize = 28;
            this.btnBuscar.Location = new System.Drawing.Point(715, 90);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(61, 29);
            this.btnBuscar.TabIndex = 7;
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // FormUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.textBuscar);
            this.Controls.Add(this.comboBoxBuscar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dGVData);
            this.Controls.Add(this.btnCargar);
            this.Controls.Add(this.btnRegistrar);
            this.Name = "FormUsuario";
            this.Text = "FormUsuario";
            this.Load += new System.EventHandler(this.FormUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGVData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton btnRegistrar;
        private FontAwesome.Sharp.IconButton btnCargar;
        private System.Windows.Forms.DataGridView dGVData;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Item;
        private System.Windows.Forms.DataGridViewTextBoxColumn CI;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn cargo;
        private System.Windows.Forms.DataGridViewTextBoxColumn unidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn PuestoDeTrabajo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxBuscar;
        private System.Windows.Forms.TextBox textBuscar;
        private FontAwesome.Sharp.IconButton btnBuscar;
    }
}