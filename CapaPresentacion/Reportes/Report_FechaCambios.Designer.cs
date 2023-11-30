namespace CapaPresentacion.Reportes
{
    partial class Report_FechaCambios
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
            this.sPGETCAMBIODOTACIONPORFECHASBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dS_FechaDotacion = new CapaPresentacion.Reportes.DS_FechaDotacion();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.sP_GETCAMBIODOTACIONPORFECHASTableAdapter = new CapaPresentacion.Reportes.DS_FechaDotacionTableAdapters.SP_GETCAMBIODOTACIONPORFECHASTableAdapter();
            this.dtpInicio = new System.Windows.Forms.DateTimePicker();
            this.dtpFin = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.sPGETCAMBIODOTACIONPORFECHASBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_FechaDotacion)).BeginInit();
            this.SuspendLayout();
            // 
            // sPGETCAMBIODOTACIONPORFECHASBindingSource
            // 
            this.sPGETCAMBIODOTACIONPORFECHASBindingSource.DataMember = "SP_GETCAMBIODOTACIONPORFECHAS";
            this.sPGETCAMBIODOTACIONPORFECHASBindingSource.DataSource = this.dS_FechaDotacion;
            // 
            // dS_FechaDotacion
            // 
            this.dS_FechaDotacion.DataSetName = "DS_FechaDotacion";
            this.dS_FechaDotacion.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.sPGETCAMBIODOTACIONPORFECHASBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CapaPresentacion.Reportes.R_FechaCambios.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // sP_GETCAMBIODOTACIONPORFECHASTableAdapter
            // 
            this.sP_GETCAMBIODOTACIONPORFECHASTableAdapter.ClearBeforeFill = true;
            // 
            // dtpInicio
            // 
            this.dtpInicio.Location = new System.Drawing.Point(21, 58);
            this.dtpInicio.Name = "dtpInicio";
            this.dtpInicio.Size = new System.Drawing.Size(86, 20);
            this.dtpInicio.TabIndex = 4;
            this.dtpInicio.Visible = false;
            // 
            // dtpFin
            // 
            this.dtpFin.Location = new System.Drawing.Point(137, 58);
            this.dtpFin.Name = "dtpFin";
            this.dtpFin.Size = new System.Drawing.Size(86, 20);
            this.dtpFin.TabIndex = 5;
            this.dtpFin.Visible = false;
            // 
            // Report_FechaCambios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dtpFin);
            this.Controls.Add(this.dtpInicio);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Report_FechaCambios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Report_FechaCambios";
            this.Load += new System.EventHandler(this.Report_FechaCambios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sPGETCAMBIODOTACIONPORFECHASBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_FechaDotacion)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource sPGETCAMBIODOTACIONPORFECHASBindingSource;
        private DS_FechaDotacion dS_FechaDotacion;
        private DS_FechaDotacionTableAdapters.SP_GETCAMBIODOTACIONPORFECHASTableAdapter sP_GETCAMBIODOTACIONPORFECHASTableAdapter;
        public System.Windows.Forms.DateTimePicker dtpInicio;
        public System.Windows.Forms.DateTimePicker dtpFin;
    }
}