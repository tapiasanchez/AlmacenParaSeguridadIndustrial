namespace CapaPresentacion.Reportes
{
    partial class Report_Dotacion
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.sPGETULTIMADOTACIONBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dS_Dotacion = new CapaPresentacion.Reportes.DS_Dotacion();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.sP_GETULTIMADOTACIONTableAdapter = new CapaPresentacion.Reportes.DS_DotacionTableAdapters.SP_GETULTIMADOTACIONTableAdapter();
            this.textBoxIdDotacion = new System.Windows.Forms.TextBox();
            this.sPGETLISTADOTACIONBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sP_GETLISTADOTACIONTableAdapter = new CapaPresentacion.Reportes.DS_DotacionTableAdapters.SP_GETLISTADOTACIONTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.sPGETULTIMADOTACIONBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_Dotacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPGETLISTADOTACIONBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // sPGETULTIMADOTACIONBindingSource
            // 
            this.sPGETULTIMADOTACIONBindingSource.DataMember = "SP_GETULTIMADOTACION";
            this.sPGETULTIMADOTACIONBindingSource.DataSource = this.dS_Dotacion;
            // 
            // dS_Dotacion
            // 
            this.dS_Dotacion.DataSetName = "DS_Dotacion";
            this.dS_Dotacion.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.sPGETULTIMADOTACIONBindingSource;
            reportDataSource2.Name = "DataSet2";
            reportDataSource2.Value = this.sPGETLISTADOTACIONBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CapaPresentacion.Reportes.R_Dotacion.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // sP_GETULTIMADOTACIONTableAdapter
            // 
            this.sP_GETULTIMADOTACIONTableAdapter.ClearBeforeFill = true;
            // 
            // textBoxIdDotacion
            // 
            this.textBoxIdDotacion.Location = new System.Drawing.Point(35, 49);
            this.textBoxIdDotacion.Name = "textBoxIdDotacion";
            this.textBoxIdDotacion.Size = new System.Drawing.Size(125, 20);
            this.textBoxIdDotacion.TabIndex = 1;
            this.textBoxIdDotacion.Visible = false;
            // 
            // sPGETLISTADOTACIONBindingSource
            // 
            this.sPGETLISTADOTACIONBindingSource.DataMember = "SP_GETLISTADOTACION";
            this.sPGETLISTADOTACIONBindingSource.DataSource = this.dS_Dotacion;
            // 
            // sP_GETLISTADOTACIONTableAdapter
            // 
            this.sP_GETLISTADOTACIONTableAdapter.ClearBeforeFill = true;
            // 
            // Report_Dotacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxIdDotacion);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Report_Dotacion";
            this.Text = "Report_Dotacion";
            this.Load += new System.EventHandler(this.Report_Dotacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sPGETULTIMADOTACIONBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_Dotacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPGETLISTADOTACIONBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private DS_Dotacion dS_Dotacion;
        private System.Windows.Forms.BindingSource sPGETULTIMADOTACIONBindingSource;
        private DS_DotacionTableAdapters.SP_GETULTIMADOTACIONTableAdapter sP_GETULTIMADOTACIONTableAdapter;
        public System.Windows.Forms.TextBox textBoxIdDotacion;
        private System.Windows.Forms.BindingSource sPGETLISTADOTACIONBindingSource;
        private DS_DotacionTableAdapters.SP_GETLISTADOTACIONTableAdapter sP_GETLISTADOTACIONTableAdapter;
    }
}