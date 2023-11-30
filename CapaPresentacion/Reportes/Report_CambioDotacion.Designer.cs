namespace CapaPresentacion.Reportes
{
    partial class Report_CambioDotacion
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
            this.sPGETCAMBIODEDOTACIONBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dS_CambioDeDotacion = new CapaPresentacion.Reportes.DS_CambioDeDotacion();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.textBoxIdUsuario = new System.Windows.Forms.TextBox();
            this.sP_GETCAMBIODEDOTACIONTableAdapter = new CapaPresentacion.Reportes.DS_CambioDeDotacionTableAdapters.SP_GETCAMBIODEDOTACIONTableAdapter();
            this.sPGETCAMBIODEDOTACIONBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.sPGETCAMBIODEDOTACIONBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_CambioDeDotacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPGETCAMBIODEDOTACIONBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // sPGETCAMBIODEDOTACIONBindingSource
            // 
            this.sPGETCAMBIODEDOTACIONBindingSource.DataMember = "SP_GETCAMBIODEDOTACION";
            this.sPGETCAMBIODEDOTACIONBindingSource.DataSource = this.dS_CambioDeDotacion;
            // 
            // dS_CambioDeDotacion
            // 
            this.dS_CambioDeDotacion.DataSetName = "DS_CambioDeDotacion";
            this.dS_CambioDeDotacion.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataCambioDotacion";
            reportDataSource1.Value = this.sPGETCAMBIODEDOTACIONBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CapaPresentacion.Reportes.R_CambioDotacion.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // textBoxIdUsuario
            // 
            this.textBoxIdUsuario.Location = new System.Drawing.Point(40, 51);
            this.textBoxIdUsuario.Name = "textBoxIdUsuario";
            this.textBoxIdUsuario.ReadOnly = true;
            this.textBoxIdUsuario.Size = new System.Drawing.Size(100, 20);
            this.textBoxIdUsuario.TabIndex = 1;
            this.textBoxIdUsuario.Visible = false;
            // 
            // sP_GETCAMBIODEDOTACIONTableAdapter
            // 
            this.sP_GETCAMBIODEDOTACIONTableAdapter.ClearBeforeFill = true;
            // 
            // sPGETCAMBIODEDOTACIONBindingSource1
            // 
            this.sPGETCAMBIODEDOTACIONBindingSource1.DataMember = "SP_GETCAMBIODEDOTACION";
            this.sPGETCAMBIODEDOTACIONBindingSource1.DataSource = this.dS_CambioDeDotacion;
            // 
            // Report_CambioDotacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxIdUsuario);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Report_CambioDotacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Report_CambioDotacion";
            this.Load += new System.EventHandler(this.Report_CambioDotacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sPGETCAMBIODEDOTACIONBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_CambioDeDotacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPGETCAMBIODEDOTACIONBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        public System.Windows.Forms.TextBox textBoxIdUsuario;
        private System.Windows.Forms.BindingSource sPGETCAMBIODEDOTACIONBindingSource;
        private DS_CambioDeDotacion dS_CambioDeDotacion;
        private DS_CambioDeDotacionTableAdapters.SP_GETCAMBIODEDOTACIONTableAdapter sP_GETCAMBIODEDOTACIONTableAdapter;
        private System.Windows.Forms.BindingSource sPGETCAMBIODEDOTACIONBindingSource1;
    }
}