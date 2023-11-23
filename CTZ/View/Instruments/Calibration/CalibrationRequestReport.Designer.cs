namespace CTZ.View.Calibration
{
    partial class CalibrationRequestReport
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
            this.Report_CalibrationRequest = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // Report_CalibrationRequest
            // 
            this.Report_CalibrationRequest.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Report_CalibrationRequest.Location = new System.Drawing.Point(-4, 67);
            this.Report_CalibrationRequest.Name = "Report_CalibrationRequest";
            this.Report_CalibrationRequest.ServerReport.BearerToken = null;
            this.Report_CalibrationRequest.Size = new System.Drawing.Size(805, 377);
            this.Report_CalibrationRequest.TabIndex = 0;
            // 
            // CalibrationRequestReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Report_CalibrationRequest);
            this.Name = "CalibrationRequestReport";
            this.Text = "Solicitud de Calibracion";
            this.Load += new System.EventHandler(this.CalibrationRequestReport_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer Report_CalibrationRequest;
    }
}