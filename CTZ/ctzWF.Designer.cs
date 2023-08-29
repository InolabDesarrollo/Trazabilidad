namespace CTZ
{
    partial class ctzWF
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ctzWF));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.identificaciónDataGridViewTextBoxColumn = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.noDeSerieDataGridViewTextBoxColumn = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.certificadoDataGridViewTextBoxColumn = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.cartaDeTrazabilidadDataGridViewTextBoxColumn = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.getCTZBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSctz = new CTZ.DSctz();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.FilterStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.ShowAllLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.getCTZTableAdapter = new CTZ.DSctzTableAdapters.GetCTZTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getCTZBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSctz)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.identificaciónDataGridViewTextBoxColumn,
            this.noDeSerieDataGridViewTextBoxColumn,
            this.certificadoDataGridViewTextBoxColumn,
            this.cartaDeTrazabilidadDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.getCTZBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(800, 428);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseDoubleClick);
            this.dataGridView1.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridView1_DataBindingComplete);
            this.dataGridView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridView1_KeyDown);
            // 
            // identificaciónDataGridViewTextBoxColumn
            // 
            this.identificaciónDataGridViewTextBoxColumn.DataPropertyName = "Identificación";
            this.identificaciónDataGridViewTextBoxColumn.HeaderText = "Identificación";
            this.identificaciónDataGridViewTextBoxColumn.Name = "identificaciónDataGridViewTextBoxColumn";
            this.identificaciónDataGridViewTextBoxColumn.ReadOnly = true;
            this.identificaciónDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // noDeSerieDataGridViewTextBoxColumn
            // 
            this.noDeSerieDataGridViewTextBoxColumn.DataPropertyName = "No. De Serie";
            this.noDeSerieDataGridViewTextBoxColumn.HeaderText = "No. De Serie";
            this.noDeSerieDataGridViewTextBoxColumn.Name = "noDeSerieDataGridViewTextBoxColumn";
            this.noDeSerieDataGridViewTextBoxColumn.ReadOnly = true;
            this.noDeSerieDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // certificadoDataGridViewTextBoxColumn
            // 
            this.certificadoDataGridViewTextBoxColumn.DataPropertyName = "Certificado";
            this.certificadoDataGridViewTextBoxColumn.HeaderText = "Certificado";
            this.certificadoDataGridViewTextBoxColumn.Name = "certificadoDataGridViewTextBoxColumn";
            this.certificadoDataGridViewTextBoxColumn.ReadOnly = true;
            this.certificadoDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // cartaDeTrazabilidadDataGridViewTextBoxColumn
            // 
            this.cartaDeTrazabilidadDataGridViewTextBoxColumn.DataPropertyName = "Carta De Trazabilidad";
            this.cartaDeTrazabilidadDataGridViewTextBoxColumn.HeaderText = "Carta De Trazabilidad";
            this.cartaDeTrazabilidadDataGridViewTextBoxColumn.Name = "cartaDeTrazabilidadDataGridViewTextBoxColumn";
            this.cartaDeTrazabilidadDataGridViewTextBoxColumn.ReadOnly = true;
            this.cartaDeTrazabilidadDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // getCTZBindingSource
            // 
            this.getCTZBindingSource.DataMember = "GetCTZ";
            this.getCTZBindingSource.DataSource = this.dSctz;
            // 
            // dSctz
            // 
            this.dSctz.DataSetName = "DSctz";
            this.dSctz.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FilterStatusLabel,
            this.ShowAllLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
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
            this.ShowAllLabel.IsLink = true;
            this.ShowAllLabel.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.ShowAllLabel.Name = "ShowAllLabel";
            this.ShowAllLabel.Size = new System.Drawing.Size(76, 17);
            this.ShowAllLabel.Text = "Mostrar todo";
            this.ShowAllLabel.Click += new System.EventHandler(this.ShowAllLabel_Click);
            // 
            // getCTZTableAdapter
            // 
            this.getCTZTableAdapter.ClearBeforeFill = true;
            // 
            // ctzWF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.statusStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ctzWF";
            this.Text = "Cartas de Trazabilidad";
            this.Load += new System.EventHandler(this.ctzWF_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getCTZBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSctz)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel FilterStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel ShowAllLabel;
        private DSctz dSctz;
        private System.Windows.Forms.BindingSource getCTZBindingSource;
        private DSctzTableAdapters.GetCTZTableAdapter getCTZTableAdapter;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn identificaciónDataGridViewTextBoxColumn;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn noDeSerieDataGridViewTextBoxColumn;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn certificadoDataGridViewTextBoxColumn;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn cartaDeTrazabilidadDataGridViewTextBoxColumn;
    }
}