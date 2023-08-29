namespace CTZ
{
    partial class DetalleCert
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DetalleCert));
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.certificadoDataGridViewTextBoxColumn = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.intervaloDeMedidaDataGridViewTextBoxColumn = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.fechaCalibracionDataGridViewTextBoxColumn = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.proximaCalibracionDataGridViewTextBoxColumn = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.getCertBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.getCertGRL = new CTZ.GetCertGRL();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.FilterStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.ShowAllLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.getCertTableAdapter = new CTZ.GetCertGRLTableAdapters.GetCertTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getCertBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getCertGRL)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.statusStrip1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 64);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(795, 383);
            this.panel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.certificadoDataGridViewTextBoxColumn,
            this.intervaloDeMedidaDataGridViewTextBoxColumn,
            this.fechaCalibracionDataGridViewTextBoxColumn,
            this.proximaCalibracionDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.getCertBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(795, 361);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseDoubleClick);
            this.dataGridView1.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridView1_DataBindingComplete);
            this.dataGridView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridView1_KeyDown);
            // 
            // certificadoDataGridViewTextBoxColumn
            // 
            this.certificadoDataGridViewTextBoxColumn.DataPropertyName = "certificado";
            this.certificadoDataGridViewTextBoxColumn.HeaderText = "certificado";
            this.certificadoDataGridViewTextBoxColumn.Name = "certificadoDataGridViewTextBoxColumn";
            this.certificadoDataGridViewTextBoxColumn.ReadOnly = true;
            this.certificadoDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // intervaloDeMedidaDataGridViewTextBoxColumn
            // 
            this.intervaloDeMedidaDataGridViewTextBoxColumn.DataPropertyName = "IntervaloDeMedida";
            this.intervaloDeMedidaDataGridViewTextBoxColumn.HeaderText = "IntervaloDeMedida";
            this.intervaloDeMedidaDataGridViewTextBoxColumn.Name = "intervaloDeMedidaDataGridViewTextBoxColumn";
            this.intervaloDeMedidaDataGridViewTextBoxColumn.ReadOnly = true;
            this.intervaloDeMedidaDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // fechaCalibracionDataGridViewTextBoxColumn
            // 
            this.fechaCalibracionDataGridViewTextBoxColumn.DataPropertyName = "FechaCalibracion";
            this.fechaCalibracionDataGridViewTextBoxColumn.HeaderText = "FechaCalibracion";
            this.fechaCalibracionDataGridViewTextBoxColumn.Name = "fechaCalibracionDataGridViewTextBoxColumn";
            this.fechaCalibracionDataGridViewTextBoxColumn.ReadOnly = true;
            this.fechaCalibracionDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // proximaCalibracionDataGridViewTextBoxColumn
            // 
            this.proximaCalibracionDataGridViewTextBoxColumn.DataPropertyName = "ProximaCalibracion";
            this.proximaCalibracionDataGridViewTextBoxColumn.HeaderText = "ProximaCalibracion";
            this.proximaCalibracionDataGridViewTextBoxColumn.Name = "proximaCalibracionDataGridViewTextBoxColumn";
            this.proximaCalibracionDataGridViewTextBoxColumn.ReadOnly = true;
            this.proximaCalibracionDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // getCertBindingSource
            // 
            this.getCertBindingSource.DataMember = "GetCert";
            this.getCertBindingSource.DataSource = this.getCertGRL;
            // 
            // getCertGRL
            // 
            this.getCertGRL.DataSetName = "GetCertGRL";
            this.getCertGRL.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FilterStatusLabel,
            this.ShowAllLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 361);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(795, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // FilterStatusLabel
            // 
            this.FilterStatusLabel.Name = "FilterStatusLabel";
            this.FilterStatusLabel.Size = new System.Drawing.Size(0, 17);
            this.FilterStatusLabel.Visible = false;
            // 
            // ShowAllLabel
            // 
            this.ShowAllLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.ShowAllLabel.IsLink = true;
            this.ShowAllLabel.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.ShowAllLabel.Name = "ShowAllLabel";
            this.ShowAllLabel.Size = new System.Drawing.Size(86, 17);
            this.ShowAllLabel.Text = "Mostrar Todos";
            this.ShowAllLabel.Click += new System.EventHandler(this.ShowAllLabel_Click);
            // 
            // getCertTableAdapter
            // 
            this.getCertTableAdapter.ClearBeforeFill = true;
            // 
            // DetalleCert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 450);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DetalleCert";
            this.Text = "Detalle del certificado";
            this.Load += new System.EventHandler(this.DetalleCert_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getCertBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getCertGRL)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel FilterStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel ShowAllLabel;
        private GetCertGRL getCertGRL;
        private System.Windows.Forms.BindingSource getCertBindingSource;
        private GetCertGRLTableAdapters.GetCertTableAdapter getCertTableAdapter;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn certificadoDataGridViewTextBoxColumn;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn intervaloDeMedidaDataGridViewTextBoxColumn;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn fechaCalibracionDataGridViewTextBoxColumn;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn proximaCalibracionDataGridViewTextBoxColumn;
    }
}