namespace CapaPresentacion
{
    partial class FormModalPersonal
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
            this.textBoxCI = new System.Windows.Forms.TextBox();
            this.btnImprimirRep = new FontAwesome.Sharp.IconButton();
            this.btnCancelar = new FontAwesome.Sharp.IconButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(58, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "CI Del Personal:";
            // 
            // textBoxCI
            // 
            this.textBoxCI.Location = new System.Drawing.Point(61, 74);
            this.textBoxCI.Name = "textBoxCI";
            this.textBoxCI.Size = new System.Drawing.Size(180, 20);
            this.textBoxCI.TabIndex = 1;
            // 
            // btnImprimirRep
            // 
            this.btnImprimirRep.IconChar = FontAwesome.Sharp.IconChar.PlusSquare;
            this.btnImprimirRep.IconColor = System.Drawing.Color.Black;
            this.btnImprimirRep.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnImprimirRep.IconSize = 28;
            this.btnImprimirRep.Location = new System.Drawing.Point(45, 132);
            this.btnImprimirRep.Name = "btnImprimirRep";
            this.btnImprimirRep.Size = new System.Drawing.Size(93, 34);
            this.btnImprimirRep.TabIndex = 2;
            this.btnImprimirRep.Text = "Mostrar";
            this.btnImprimirRep.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnImprimirRep.UseVisualStyleBackColor = true;
            this.btnImprimirRep.Click += new System.EventHandler(this.BtnImprimirRep_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.IconChar = FontAwesome.Sharp.IconChar.Cancel;
            this.btnCancelar.IconColor = System.Drawing.Color.Black;
            this.btnCancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCancelar.IconSize = 28;
            this.btnCancelar.Location = new System.Drawing.Point(173, 133);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(87, 33);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // FormModalPersonal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 195);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnImprimirRep);
            this.Controls.Add(this.textBoxCI);
            this.Controls.Add(this.label1);
            this.Name = "FormModalPersonal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormModalPersonal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxCI;
        private FontAwesome.Sharp.IconButton btnImprimirRep;
        private FontAwesome.Sharp.IconButton btnCancelar;
    }
}