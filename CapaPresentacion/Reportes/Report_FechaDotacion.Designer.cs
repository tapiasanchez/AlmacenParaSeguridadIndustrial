namespace CapaPresentacion.Reportes
{
    partial class Report_FechaDotacion
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
            this.sPGETDOTACIONPORFECHASBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dS_FechaDotacion = new CapaPresentacion.Reportes.DS_FechaDotacion();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.sP_GETDOTACIONPORFECHASTableAdapter = new CapaPresentacion.Reportes.DS_FechaDotacionTableAdapters.SP_GETDOTACIONPORFECHASTableAdapter();
            this.dtpInicio = new System.Windows.Forms.DateTimePicker();
            this.dtpFin = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.sPGETDOTACIONPORFECHASBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_FechaDotacion)).BeginInit();
            this.SuspendLayout();
            // 
            // sPGETDOTACIONPORFECHASBindingSource
            // 
            this.sPGETDOTACIONPORFECHASBindingSource.DataMember = "SP_GETDOTACIONPORFECHAS";
            this.sPGETDOTACIONPORFECHASBindingSource.DataSource = this.dS_FechaDotacion;
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
            reportDataSource1.Value = this.sPGETDOTACIONPORFECHASBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CapaPresentacion.Reportes.R_FechaDotacion.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // sP_GETDOTACIONPORFECHASTableAdapter
            // 
            this.sP_GETDOTACIONPORFECHASTableAdapter.ClearBeforeFill = true;
            // 
            // dtpInicio
            // 
            this.dtpInicio.Location = new System.Drawing.Point(34, 61);
            this.dtpInicio.Name = "dtpInicio";
            this.dtpInicio.Size = new System.Drawing.Size(200, 20);
            this.dtpInicio.TabIndex = 1;
            this.dtpInicio.Visible = false;
            // 
            // dtpFin
            // 
            this.dtpFin.Location = new System.Drawing.Point(256, 61);
            this.dtpFin.Name = "dtpFin";
            this.dtpFin.Size = new System.Drawing.Size(200, 20);
            this.dtpFin.TabIndex = 2;
            this.dtpFin.Visible = false;
            // 
            // Report_FechaDotacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dtpFin);
            this.Controls.Add(this.dtpInicio);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Report_FechaDotacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Report_FechaDotacion";
            this.Load += new System.EventHandler(this.Report_FechaDotacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sPGETDOTACIONPORFECHASBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_FechaDotacion)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource sPGETDOTACIONPORFECHASBindingSource;
        private DS_FechaDotacion dS_FechaDotacion;
        private DS_FechaDotacionTableAdapters.SP_GETDOTACIONPORFECHASTableAdapter sP_GETDOTACIONPORFECHASTableAdapter;
        public System.Windows.Forms.DateTimePicker dtpInicio;
        public System.Windows.Forms.DateTimePicker dtpFin;
    }
}