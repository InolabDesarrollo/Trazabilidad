namespace CTZ.Vista.Traceability
{
    partial class ReportTraceabilityLetter
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
            this.Report_TraceabilityLetter = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // Report_TraceabilityLetter
            // 
            this.Report_TraceabilityLetter.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Report_TraceabilityLetter.Location = new System.Drawing.Point(-2, 60);
            this.Report_TraceabilityLetter.Name = "Report_TraceabilityLetter";
            this.Report_TraceabilityLetter.ServerReport.BearerToken = null;
            this.Report_TraceabilityLetter.Size = new System.Drawing.Size(796, 384);
            this.Report_TraceabilityLetter.TabIndex = 0;
            this.Report_TraceabilityLetter.Load += new System.EventHandler(this.Report_TraceabilityLetter_Load);
            // 
            // ReportTraceabilityLetter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Report_TraceabilityLetter);
            this.Name = "ReportTraceabilityLetter";
            this.Text = "Reporte Carta De Trazabilidad";
            this.TopMost = true;
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer Report_TraceabilityLetter;
    }
}