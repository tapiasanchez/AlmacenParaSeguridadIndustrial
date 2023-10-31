namespace CapaPresentacion.Reportes
{
    partial class Report_Inventario
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dS_Inventario = new CapaPresentacion.Reportes.DS_Inventario();
            this.sPGETIINVENTARIOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sP_GETIINVENTARIOTableAdapter = new CapaPresentacion.Reportes.DS_InventarioTableAdapters.SP_GETIINVENTARIOTableAdapter();
            this.dtpInicio = new System.Windows.Forms.DateTimePicker();
            this.dtpFin = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dS_Inventario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPGETIINVENTARIOBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSetInventario";
            reportDataSource1.Value = this.sPGETIINVENTARIOBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CapaPresentacion.Reportes.R_Inventario.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // dS_Inventario
            // 
            this.dS_Inventario.DataSetName = "DS_Inventario";
            this.dS_Inventario.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sPGETIINVENTARIOBindingSource
            // 
            this.sPGETIINVENTARIOBindingSource.DataMember = "SP_GETIINVENTARIO";
            this.sPGETIINVENTARIOBindingSource.DataSource = this.dS_Inventario;
            // 
            // sP_GETIINVENTARIOTableAdapter
            // 
            this.sP_GETIINVENTARIOTableAdapter.ClearBeforeFill = true;
            // 
            // dtpInicio
            // 
            this.dtpInicio.Location = new System.Drawing.Point(254, 62);
            this.dtpInicio.Name = "dtpInicio";
            this.dtpInicio.Size = new System.Drawing.Size(200, 20);
            this.dtpInicio.TabIndex = 2;
            this.dtpInicio.Visible = false;
            // 
            // dtpFin
            // 
            this.dtpFin.Location = new System.Drawing.Point(30, 62);
            this.dtpFin.Name = "dtpFin";
            this.dtpFin.Size = new System.Drawing.Size(200, 20);
            this.dtpFin.TabIndex = 3;
            this.dtpFin.Visible = false;
            // 
            // Report_Inventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dtpFin);
            this.Controls.Add(this.dtpInicio);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Report_Inventario";
            this.Text = "Report_Inventario";
            this.Load += new System.EventHandler(this.Report_Inventario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dS_Inventario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPGETIINVENTARIOBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource sPGETIINVENTARIOBindingSource;
        private DS_Inventario dS_Inventario;
        private DS_InventarioTableAdapters.SP_GETIINVENTARIOTableAdapter sP_GETIINVENTARIOTableAdapter;
        public System.Windows.Forms.DateTimePicker dtpInicio;
        public System.Windows.Forms.DateTimePicker dtpFin;
    }
}