namespace CapaPresentacion.Reportes
{
    partial class Report_DotacionYCambio
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
            this.sPGETDOTACIONPORUSUARIOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSDotacionYCambioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dS_DotacionYCambio = new CapaPresentacion.Reportes.DS_DotacionYCambio();
            this.sPGETCAMBIODEDOTACIONBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.textBoxIdUsuario = new System.Windows.Forms.TextBox();
            this.sP_GETDOTACIONPORUSUARIOTableAdapter = new CapaPresentacion.Reportes.DS_DotacionYCambioTableAdapters.SP_GETDOTACIONPORUSUARIOTableAdapter();
            this.sP_GETCAMBIODEDOTACIONTableAdapter = new CapaPresentacion.Reportes.DS_DotacionYCambioTableAdapters.SP_GETCAMBIODEDOTACIONTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.sPGETDOTACIONPORUSUARIOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSDotacionYCambioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_DotacionYCambio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPGETCAMBIODEDOTACIONBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // sPGETDOTACIONPORUSUARIOBindingSource
            // 
            this.sPGETDOTACIONPORUSUARIOBindingSource.DataMember = "SP_GETDOTACIONPORUSUARIO";
            this.sPGETDOTACIONPORUSUARIOBindingSource.DataSource = this.dSDotacionYCambioBindingSource;
            // 
            // dSDotacionYCambioBindingSource
            // 
            this.dSDotacionYCambioBindingSource.DataSource = this.dS_DotacionYCambio;
            this.dSDotacionYCambioBindingSource.Position = 0;
            // 
            // dS_DotacionYCambio
            // 
            this.dS_DotacionYCambio.DataSetName = "DS_DotacionYCambio";
            this.dS_DotacionYCambio.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sPGETCAMBIODEDOTACIONBindingSource
            // 
            this.sPGETCAMBIODEDOTACIONBindingSource.DataMember = "SP_GETCAMBIODEDOTACION";
            this.sPGETCAMBIODEDOTACIONBindingSource.DataSource = this.dSDotacionYCambioBindingSource;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSetDotacionYCambio";
            reportDataSource1.Value = this.sPGETDOTACIONPORUSUARIOBindingSource;
            reportDataSource2.Name = "DataSetCambio";
            reportDataSource2.Value = this.sPGETCAMBIODEDOTACIONBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CapaPresentacion.Reportes.R_DotacionYCambio.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // textBoxIdUsuario
            // 
            this.textBoxIdUsuario.Location = new System.Drawing.Point(35, 46);
            this.textBoxIdUsuario.Name = "textBoxIdUsuario";
            this.textBoxIdUsuario.ReadOnly = true;
            this.textBoxIdUsuario.Size = new System.Drawing.Size(70, 20);
            this.textBoxIdUsuario.TabIndex = 1;
            this.textBoxIdUsuario.Visible = false;
            // 
            // sP_GETDOTACIONPORUSUARIOTableAdapter
            // 
            this.sP_GETDOTACIONPORUSUARIOTableAdapter.ClearBeforeFill = true;
            // 
            // sP_GETCAMBIODEDOTACIONTableAdapter
            // 
            this.sP_GETCAMBIODEDOTACIONTableAdapter.ClearBeforeFill = true;
            // 
            // Report_DotacionYCambio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxIdUsuario);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Report_DotacionYCambio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Report_DotacionYCambio";
            this.Load += new System.EventHandler(this.Report_DotacionYCambio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sPGETDOTACIONPORUSUARIOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSDotacionYCambioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_DotacionYCambio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPGETCAMBIODEDOTACIONBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        public System.Windows.Forms.TextBox textBoxIdUsuario;
        private System.Windows.Forms.BindingSource sPGETDOTACIONPORUSUARIOBindingSource;
        private System.Windows.Forms.BindingSource dSDotacionYCambioBindingSource;
        private DS_DotacionYCambio dS_DotacionYCambio;
        private System.Windows.Forms.BindingSource sPGETCAMBIODEDOTACIONBindingSource;
        private DS_DotacionYCambioTableAdapters.SP_GETDOTACIONPORUSUARIOTableAdapter sP_GETDOTACIONPORUSUARIOTableAdapter;
        private DS_DotacionYCambioTableAdapters.SP_GETCAMBIODEDOTACIONTableAdapter sP_GETCAMBIODEDOTACIONTableAdapter;
    }
}