namespace CTZ.View.Instruments
{
    partial class Instruments_SubMenu
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
            this.parametrosTableAdapter1 = new CTZ.DocumentacionDataSetTableAdapters.ParametrosTableAdapter();
            this.parametrosTableAdapter2 = new CTZ.DocumentacionDataSetTableAdapters.ParametrosTableAdapter();
            this.TabControl_Instruments = new System.Windows.Forms.TabControl();
            this.Page_Instruments = new System.Windows.Forms.TabPage();
            this.advancedDataGridView1 = new ADGV.AdvancedDataGridView();
            this.Page_Instruments_Certificates = new System.Windows.Forms.TabPage();
            this.TabControl_Instruments.SuspendLayout();
            this.Page_Instruments.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.advancedDataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // parametrosTableAdapter1
            // 
            this.parametrosTableAdapter1.ClearBeforeFill = true;
            // 
            // parametrosTableAdapter2
            // 
            this.parametrosTableAdapter2.ClearBeforeFill = true;
            // 
            // TabControl_Instruments
            // 
            this.TabControl_Instruments.Controls.Add(this.Page_Instruments);
            this.TabControl_Instruments.Controls.Add(this.Page_Instruments_Certificates);
            this.TabControl_Instruments.Location = new System.Drawing.Point(12, 89);
            this.TabControl_Instruments.Name = "TabControl_Instruments";
            this.TabControl_Instruments.SelectedIndex = 0;
            this.TabControl_Instruments.Size = new System.Drawing.Size(828, 323);
            this.TabControl_Instruments.TabIndex = 0;
            // 
            // Page_Instruments
            // 
            this.Page_Instruments.Controls.Add(this.advancedDataGridView1);
            this.Page_Instruments.Location = new System.Drawing.Point(4, 22);
            this.Page_Instruments.Name = "Page_Instruments";
            this.Page_Instruments.Padding = new System.Windows.Forms.Padding(3);
            this.Page_Instruments.Size = new System.Drawing.Size(820, 297);
            this.Page_Instruments.TabIndex = 0;
            this.Page_Instruments.Text = "Instrumentos";
            this.Page_Instruments.UseVisualStyleBackColor = true;
            // 
            // advancedDataGridView1
            // 
            this.advancedDataGridView1.AutoGenerateContextFilters = true;
            this.advancedDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.advancedDataGridView1.DateWithTime = false;
            this.advancedDataGridView1.Location = new System.Drawing.Point(3, 6);
            this.advancedDataGridView1.Name = "advancedDataGridView1";
            this.advancedDataGridView1.Size = new System.Drawing.Size(811, 355);
            this.advancedDataGridView1.TabIndex = 0;
            this.advancedDataGridView1.TimeFilter = false;
            // 
            // Page_Instruments_Certificates
            // 
            this.Page_Instruments_Certificates.Location = new System.Drawing.Point(4, 22);
            this.Page_Instruments_Certificates.Name = "Page_Instruments_Certificates";
            this.Page_Instruments_Certificates.Padding = new System.Windows.Forms.Padding(3);
            this.Page_Instruments_Certificates.Size = new System.Drawing.Size(820, 325);
            this.Page_Instruments_Certificates.TabIndex = 1;
            this.Page_Instruments_Certificates.Text = "Instrumentos-Certificados";
            this.Page_Instruments_Certificates.UseVisualStyleBackColor = true;
            // 
            // Instruments_SubMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 477);
            this.Controls.Add(this.TabControl_Instruments);
            this.Name = "Instruments_SubMenu";
            this.Text = "SubMenu Instrumentos";
            this.TabControl_Instruments.ResumeLayout(false);
            this.Page_Instruments.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.advancedDataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DocumentacionDataSetTableAdapters.ParametrosTableAdapter parametrosTableAdapter1;
        private DocumentacionDataSetTableAdapters.ParametrosTableAdapter parametrosTableAdapter2;
        private System.Windows.Forms.TabControl TabControl_Instruments;
        private System.Windows.Forms.TabPage Page_Instruments;
        private System.Windows.Forms.TabPage Page_Instruments_Certificates;
        private ADGV.AdvancedDataGridView advancedDataGridView1;
    }
}