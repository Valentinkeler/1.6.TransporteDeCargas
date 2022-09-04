namespace _1._6.TransporteDeCargas.froms
{
    partial class frmReporteCamion
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
            this.rvCamion = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // rvCamion
            // 
            this.rvCamion.LocalReport.ReportEmbeddedResource = "_1._6.TransporteDeCargas.reports.rptCamion.rdlc";
            this.rvCamion.Location = new System.Drawing.Point(38, 24);
            this.rvCamion.Name = "rvCamion";
            this.rvCamion.ServerReport.BearerToken = null;
            this.rvCamion.Size = new System.Drawing.Size(703, 385);
            this.rvCamion.TabIndex = 0;
            // 
            // frmReporteCamion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rvCamion);
            this.Name = "frmReporteCamion";
            this.Text = "frmReporteCamion";
            this.Load += new System.EventHandler(this.frmReporteCamion_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rvCamion;
    }
}