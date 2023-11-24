namespace CapaPresentacion.Reportes
{
    partial class Report_RDotacion
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
            this.dS_ReporteDotacion = new CapaPresentacion.Reportes.DS_ReporteDotacion();
            this.sPGETDOTACIONESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sP_GETDOTACIONESTableAdapter = new CapaPresentacion.Reportes.DS_ReporteDotacionTableAdapters.SP_GETDOTACIONESTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dS_ReporteDotacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPGETDOTACIONESBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.sPGETDOTACIONESBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CapaPresentacion.Reportes.R_ReporteDotacion.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(600, 271);
            this.reportViewer1.TabIndex = 0;
            // 
            // dS_ReporteDotacion
            // 
            this.dS_ReporteDotacion.DataSetName = "DS_ReporteDotacion";
            this.dS_ReporteDotacion.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sPGETDOTACIONESBindingSource
            // 
            this.sPGETDOTACIONESBindingSource.DataMember = "SP_GETDOTACIONES";
            this.sPGETDOTACIONESBindingSource.DataSource = this.dS_ReporteDotacion;
            // 
            // sP_GETDOTACIONESTableAdapter
            // 
            this.sP_GETDOTACIONESTableAdapter.ClearBeforeFill = true;
            // 
            // Report_RDotacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 271);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Report_RDotacion";
            this.Text = "Report_DotacionPersonal";
            this.Load += new System.EventHandler(this.Report_RDotacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dS_ReporteDotacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPGETDOTACIONESBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private DS_ReporteDotacion dS_ReporteDotacion;
        private System.Windows.Forms.BindingSource sPGETDOTACIONESBindingSource;
        private DS_ReporteDotacionTableAdapters.SP_GETDOTACIONESTableAdapter sP_GETDOTACIONESTableAdapter;
    }
}