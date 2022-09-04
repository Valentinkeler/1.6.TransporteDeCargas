namespace _1._6.TransporteDeCargas.froms
{
    partial class frmReporteTipoCarga
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
            this.dsTipoCarga = new _1._6.TransporteDeCargas.reports.dsTipoCarga();
            this.tipoCargaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tipoCargaTableAdapter = new _1._6.TransporteDeCargas.reports.dsTipoCargaTableAdapters.tipoCargaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dsTipoCarga)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoCargaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.tipoCargaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "_1._6.TransporteDeCargas.reports.rptTipoCarga.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(53, 45);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(657, 345);
            this.reportViewer1.TabIndex = 0;
            // 
            // dsTipoCarga
            // 
            this.dsTipoCarga.DataSetName = "dsTipoCarga";
            this.dsTipoCarga.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tipoCargaBindingSource
            // 
            this.tipoCargaBindingSource.DataMember = "tipoCarga";
            this.tipoCargaBindingSource.DataSource = this.dsTipoCarga;
            // 
            // tipoCargaTableAdapter
            // 
            this.tipoCargaTableAdapter.ClearBeforeFill = true;
            // 
            // frmReporteTipoCarga
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmReporteTipoCarga";
            this.Text = "frmReporteTipoCarga";
            this.Load += new System.EventHandler(this.frmReporteTipoCarga_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsTipoCarga)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoCargaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private reports.dsTipoCarga dsTipoCarga;
        private System.Windows.Forms.BindingSource tipoCargaBindingSource;
        private reports.dsTipoCargaTableAdapters.tipoCargaTableAdapter tipoCargaTableAdapter;
    }
}