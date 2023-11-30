namespace CapaPresentacion.Reportes
{
    partial class Report_RCambios
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
            this.sPGETCAMBIOSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dS_ReporteCambios = new CapaPresentacion.Reportes.DS_ReporteCambios();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.sP_GETCAMBIOSTableAdapter = new CapaPresentacion.Reportes.DS_ReporteCambiosTableAdapters.SP_GETCAMBIOSTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.sPGETCAMBIOSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_ReporteCambios)).BeginInit();
            this.SuspendLayout();
            // 
            // sPGETCAMBIOSBindingSource
            // 
            this.sPGETCAMBIOSBindingSource.DataMember = "SP_GETCAMBIOS";
            this.sPGETCAMBIOSBindingSource.DataSource = this.dS_ReporteCambios;
            // 
            // dS_ReporteCambios
            // 
            this.dS_ReporteCambios.DataSetName = "DS_ReporteCambios";
            this.dS_ReporteCambios.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.sPGETCAMBIOSBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CapaPresentacion.Reportes.R_ReporteCambio.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(584, 328);
            this.reportViewer1.TabIndex = 0;
            // 
            // sP_GETCAMBIOSTableAdapter
            // 
            this.sP_GETCAMBIOSTableAdapter.ClearBeforeFill = true;
            // 
            // Report_RCambios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 328);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Report_RCambios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Report_RCambios";
            this.Load += new System.EventHandler(this.Report_RCambios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sPGETCAMBIOSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_ReporteCambios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private DS_ReporteCambios dS_ReporteCambios;
        private System.Windows.Forms.BindingSource sPGETCAMBIOSBindingSource;
        private DS_ReporteCambiosTableAdapters.SP_GETCAMBIOSTableAdapter sP_GETCAMBIOSTableAdapter;
    }
}