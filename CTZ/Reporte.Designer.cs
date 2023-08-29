namespace CTZ
{
    partial class Reporte
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reporte));
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.asignacionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.asignacionDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.asignacionDataSet = new CTZ.AsignacionDataSet();
            this.modeloIBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.datasetHistory = new CTZ.DatasetHistory();
            this.modeloITableAdapter = new CTZ.DatasetHistoryTableAdapters.ModeloITableAdapter();
            this.asignacionTableAdapter = new CTZ.AsignacionDataSetTableAdapters.AsignacionTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.asignacionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.asignacionDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.asignacionDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modeloIBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datasetHistory)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer1.Location = new System.Drawing.Point(3, 64);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Remote;
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1212, 646);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // asignacionBindingSource
            // 
            this.asignacionBindingSource.DataMember = "Asignacion";
            this.asignacionBindingSource.DataSource = this.asignacionDataSetBindingSource;
            // 
            // asignacionDataSetBindingSource
            // 
            this.asignacionDataSetBindingSource.DataSource = this.asignacionDataSet;
            this.asignacionDataSetBindingSource.Position = 0;
            // 
            // asignacionDataSet
            // 
            this.asignacionDataSet.DataSetName = "AsignacionDataSet";
            this.asignacionDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // modeloIBindingSource
            // 
            this.modeloIBindingSource.DataMember = "ModeloI";
            this.modeloIBindingSource.DataSource = this.datasetHistory;
            // 
            // datasetHistory
            // 
            this.datasetHistory.DataSetName = "DatasetHistory";
            this.datasetHistory.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // modeloITableAdapter
            // 
            this.modeloITableAdapter.ClearBeforeFill = true;
            // 
            // asignacionTableAdapter
            // 
            this.asignacionTableAdapter.ClearBeforeFill = true;
            // 
            // Reporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1218, 713);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Reporte";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Reporte";
            this.Deactivate += new System.EventHandler(this.Reporte_Deactivate);
            this.Load += new System.EventHandler(this.Reporte_Load);
            ((System.ComponentModel.ISupportInitialize)(this.asignacionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.asignacionDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.asignacionDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.modeloIBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datasetHistory)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private DatasetHistory datasetHistory;
        private System.Windows.Forms.BindingSource modeloIBindingSource;
        private DatasetHistoryTableAdapters.ModeloITableAdapter modeloITableAdapter;
        private System.Windows.Forms.BindingSource asignacionDataSetBindingSource;
        private AsignacionDataSet asignacionDataSet;
        private System.Windows.Forms.BindingSource asignacionBindingSource;
        private AsignacionDataSetTableAdapters.AsignacionTableAdapter asignacionTableAdapter;
    }
}