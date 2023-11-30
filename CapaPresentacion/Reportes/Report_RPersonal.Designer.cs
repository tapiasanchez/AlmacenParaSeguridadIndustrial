namespace CapaPresentacion.Reportes
{
    partial class Report_RPersonal
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource4 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.sPGETDOTACIONESPORPERSONALBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dS_ReportePersonal = new CapaPresentacion.Reportes.DS_ReportePersonal();
            this.sPGETCAMBIOSPORPERSONALBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.sP_GETDOTACIONESPORPERSONALTableAdapter = new CapaPresentacion.Reportes.DS_ReportePersonalTableAdapters.SP_GETDOTACIONESPORPERSONALTableAdapter();
            this.sP_GETCAMBIOSPORPERSONALTableAdapter = new CapaPresentacion.Reportes.DS_ReportePersonalTableAdapters.SP_GETCAMBIOSPORPERSONALTableAdapter();
            this.textBoxCI = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.sPGETDOTACIONESPORPERSONALBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_ReportePersonal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPGETCAMBIOSPORPERSONALBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // sPGETDOTACIONESPORPERSONALBindingSource
            // 
            this.sPGETDOTACIONESPORPERSONALBindingSource.DataMember = "SP_GETDOTACIONESPORPERSONAL";
            this.sPGETDOTACIONESPORPERSONALBindingSource.DataSource = this.dS_ReportePersonal;
            // 
            // dS_ReportePersonal
            // 
            this.dS_ReportePersonal.DataSetName = "DS_ReportePersonal";
            this.dS_ReportePersonal.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sPGETCAMBIOSPORPERSONALBindingSource
            // 
            this.sPGETCAMBIOSPORPERSONALBindingSource.DataMember = "SP_GETCAMBIOSPORPERSONAL";
            this.sPGETCAMBIOSPORPERSONALBindingSource.DataSource = this.dS_ReportePersonal;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource3.Name = "DataSet1";
            reportDataSource3.Value = this.sPGETDOTACIONESPORPERSONALBindingSource;
            reportDataSource4.Name = "DataSet2";
            reportDataSource4.Value = this.sPGETCAMBIOSPORPERSONALBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource4);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CapaPresentacion.Reportes.R_ReportePersonal.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // sP_GETDOTACIONESPORPERSONALTableAdapter
            // 
            this.sP_GETDOTACIONESPORPERSONALTableAdapter.ClearBeforeFill = true;
            // 
            // sP_GETCAMBIOSPORPERSONALTableAdapter
            // 
            this.sP_GETCAMBIOSPORPERSONALTableAdapter.ClearBeforeFill = true;
            // 
            // textBoxCI
            // 
            this.textBoxCI.Location = new System.Drawing.Point(12, 39);
            this.textBoxCI.Name = "textBoxCI";
            this.textBoxCI.Size = new System.Drawing.Size(100, 20);
            this.textBoxCI.TabIndex = 1;
            this.textBoxCI.Visible = false;
            // 
            // Report_RPersonal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxCI);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Report_RPersonal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Report_RPersonal";
            this.Load += new System.EventHandler(this.Report_RPersonal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sPGETDOTACIONESPORPERSONALBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_ReportePersonal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPGETCAMBIOSPORPERSONALBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource sPGETDOTACIONESPORPERSONALBindingSource;
        private DS_ReportePersonal dS_ReportePersonal;
        private System.Windows.Forms.BindingSource sPGETCAMBIOSPORPERSONALBindingSource;
        private DS_ReportePersonalTableAdapters.SP_GETDOTACIONESPORPERSONALTableAdapter sP_GETDOTACIONESPORPERSONALTableAdapter;
        private DS_ReportePersonalTableAdapters.SP_GETCAMBIOSPORPERSONALTableAdapter sP_GETCAMBIOSPORPERSONALTableAdapter;
        public System.Windows.Forms.TextBox textBoxCI;
    }
}