namespace CTZ
{
    partial class Historial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Historial));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.FilterStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.ShowAllLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.f1 = new System.Windows.Forms.DateTimePicker();
            this.f2 = new System.Windows.Forms.DateTimePicker();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialButton1 = new MaterialSkin.Controls.MaterialButton();
            this.getHistoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.datasetHistory = new CTZ.DatasetHistory();
            this.getHistoryTableAdapter = new CTZ.DatasetHistoryTableAdapters.getHistoryTableAdapter();
            this.noDeRegistroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.localizaciónDataGridViewTextBoxColumn = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.ingenieroDataGridViewTextBoxColumn = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.servicioDataGridViewTextBoxColumn = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.fechaInicialDataGridViewTextBoxColumn = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.fechaFinalDataGridViewTextBoxColumn = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.noDeRegistroDataGridViewTextBoxColumn1 = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.localizaciónDataGridViewTextBoxColumn1 = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.ingenieroDataGridViewTextBoxColumn1 = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.servicioDataGridViewTextBoxColumn1 = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.fechaInicialDataGridViewTextBoxColumn1 = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.fechaFinalDataGridViewTextBoxColumn1 = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.fechaDeRegistroDataGridViewTextBoxColumn = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.getHistoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datasetHistory)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.noDeRegistroDataGridViewTextBoxColumn1,
            this.localizaciónDataGridViewTextBoxColumn1,
            this.ingenieroDataGridViewTextBoxColumn1,
            this.servicioDataGridViewTextBoxColumn1,
            this.fechaInicialDataGridViewTextBoxColumn1,
            this.fechaFinalDataGridViewTextBoxColumn1,
            this.fechaDeRegistroDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.getHistoryBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(3, 119);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(794, 306);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseDoubleClick);
            this.dataGridView1.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridView1_DataBindingComplete);
            this.dataGridView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridView1_KeyDown);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FilterStatusLabel,
            this.ShowAllLabel});
            this.statusStrip1.Location = new System.Drawing.Point(3, 425);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(794, 22);
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
            // f1
            // 
            this.f1.Location = new System.Drawing.Point(121, 70);
            this.f1.Name = "f1";
            this.f1.Size = new System.Drawing.Size(200, 20);
            this.f1.TabIndex = 2;
            this.f1.ValueChanged += new System.EventHandler(this.f1_ValueChanged);
            // 
            // f2
            // 
            this.f2.Location = new System.Drawing.Point(446, 70);
            this.f2.Name = "f2";
            this.f2.Size = new System.Drawing.Size(200, 20);
            this.f2.TabIndex = 3;
            this.f2.ValueChanged += new System.EventHandler(this.f2_ValueChanged);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(6, 71);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(94, 19);
            this.materialLabel1.TabIndex = 4;
            this.materialLabel1.Text = "Fecha inicial:";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(344, 71);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(87, 19);
            this.materialLabel2.TabIndex = 5;
            this.materialLabel2.Text = "Fecha Final:";
            // 
            // materialButton1
            // 
            this.materialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton1.Depth = 0;
            this.materialButton1.HighEmphasis = true;
            this.materialButton1.Icon = null;
            this.materialButton1.Location = new System.Drawing.Point(706, 74);
            this.materialButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.Size = new System.Drawing.Size(87, 36);
            this.materialButton1.TabIndex = 6;
            this.materialButton1.Text = "Imprimir";
            this.materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text;
            this.materialButton1.UseAccentColor = false;
            this.materialButton1.UseVisualStyleBackColor = true;
            this.materialButton1.Click += new System.EventHandler(this.materialButton1_Click);
            // 
            // getHistoryBindingSource
            // 
            this.getHistoryBindingSource.DataMember = "getHistory";
            this.getHistoryBindingSource.DataSource = this.datasetHistory;
            // 
            // datasetHistory
            // 
            this.datasetHistory.DataSetName = "DatasetHistory";
            this.datasetHistory.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // getHistoryTableAdapter
            // 
            this.getHistoryTableAdapter.ClearBeforeFill = true;
            // 
            // noDeRegistroDataGridViewTextBoxColumn
            // 
            this.noDeRegistroDataGridViewTextBoxColumn.DataPropertyName = "No. de registro";
            this.noDeRegistroDataGridViewTextBoxColumn.HeaderText = "No. de registro";
            this.noDeRegistroDataGridViewTextBoxColumn.Name = "noDeRegistroDataGridViewTextBoxColumn";
            this.noDeRegistroDataGridViewTextBoxColumn.ReadOnly = true;
            this.noDeRegistroDataGridViewTextBoxColumn.Width = 125;
            // 
            // localizaciónDataGridViewTextBoxColumn
            // 
            this.localizaciónDataGridViewTextBoxColumn.DataPropertyName = "Localización";
            this.localizaciónDataGridViewTextBoxColumn.HeaderText = "Localización";
            this.localizaciónDataGridViewTextBoxColumn.Name = "localizaciónDataGridViewTextBoxColumn";
            this.localizaciónDataGridViewTextBoxColumn.ReadOnly = true;
            this.localizaciónDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.localizaciónDataGridViewTextBoxColumn.Width = 125;
            // 
            // ingenieroDataGridViewTextBoxColumn
            // 
            this.ingenieroDataGridViewTextBoxColumn.DataPropertyName = "Ingeniero";
            this.ingenieroDataGridViewTextBoxColumn.HeaderText = "Ingeniero";
            this.ingenieroDataGridViewTextBoxColumn.Name = "ingenieroDataGridViewTextBoxColumn";
            this.ingenieroDataGridViewTextBoxColumn.ReadOnly = true;
            this.ingenieroDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ingenieroDataGridViewTextBoxColumn.Width = 125;
            // 
            // servicioDataGridViewTextBoxColumn
            // 
            this.servicioDataGridViewTextBoxColumn.DataPropertyName = "Servicio";
            this.servicioDataGridViewTextBoxColumn.HeaderText = "Servicio";
            this.servicioDataGridViewTextBoxColumn.Name = "servicioDataGridViewTextBoxColumn";
            this.servicioDataGridViewTextBoxColumn.ReadOnly = true;
            this.servicioDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.servicioDataGridViewTextBoxColumn.Width = 126;
            // 
            // fechaInicialDataGridViewTextBoxColumn
            // 
            this.fechaInicialDataGridViewTextBoxColumn.DataPropertyName = "Fecha inicial";
            this.fechaInicialDataGridViewTextBoxColumn.HeaderText = "Fecha inicial";
            this.fechaInicialDataGridViewTextBoxColumn.Name = "fechaInicialDataGridViewTextBoxColumn";
            this.fechaInicialDataGridViewTextBoxColumn.ReadOnly = true;
            this.fechaInicialDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.fechaInicialDataGridViewTextBoxColumn.Width = 125;
            // 
            // fechaFinalDataGridViewTextBoxColumn
            // 
            this.fechaFinalDataGridViewTextBoxColumn.DataPropertyName = "Fecha final";
            this.fechaFinalDataGridViewTextBoxColumn.HeaderText = "Fecha final";
            this.fechaFinalDataGridViewTextBoxColumn.Name = "fechaFinalDataGridViewTextBoxColumn";
            this.fechaFinalDataGridViewTextBoxColumn.ReadOnly = true;
            this.fechaFinalDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.fechaFinalDataGridViewTextBoxColumn.Width = 125;
            // 
            // noDeRegistroDataGridViewTextBoxColumn1
            // 
            this.noDeRegistroDataGridViewTextBoxColumn1.DataPropertyName = "No. de registro";
            this.noDeRegistroDataGridViewTextBoxColumn1.HeaderText = "No. de registro";
            this.noDeRegistroDataGridViewTextBoxColumn1.Name = "noDeRegistroDataGridViewTextBoxColumn1";
            this.noDeRegistroDataGridViewTextBoxColumn1.ReadOnly = true;
            this.noDeRegistroDataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // localizaciónDataGridViewTextBoxColumn1
            // 
            this.localizaciónDataGridViewTextBoxColumn1.DataPropertyName = "Localización";
            this.localizaciónDataGridViewTextBoxColumn1.HeaderText = "Localización";
            this.localizaciónDataGridViewTextBoxColumn1.Name = "localizaciónDataGridViewTextBoxColumn1";
            this.localizaciónDataGridViewTextBoxColumn1.ReadOnly = true;
            this.localizaciónDataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // ingenieroDataGridViewTextBoxColumn1
            // 
            this.ingenieroDataGridViewTextBoxColumn1.DataPropertyName = "Ingeniero";
            this.ingenieroDataGridViewTextBoxColumn1.HeaderText = "Ingeniero";
            this.ingenieroDataGridViewTextBoxColumn1.Name = "ingenieroDataGridViewTextBoxColumn1";
            this.ingenieroDataGridViewTextBoxColumn1.ReadOnly = true;
            this.ingenieroDataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // servicioDataGridViewTextBoxColumn1
            // 
            this.servicioDataGridViewTextBoxColumn1.DataPropertyName = "Servicio";
            this.servicioDataGridViewTextBoxColumn1.HeaderText = "Servicio";
            this.servicioDataGridViewTextBoxColumn1.Name = "servicioDataGridViewTextBoxColumn1";
            this.servicioDataGridViewTextBoxColumn1.ReadOnly = true;
            this.servicioDataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // fechaInicialDataGridViewTextBoxColumn1
            // 
            this.fechaInicialDataGridViewTextBoxColumn1.DataPropertyName = "Fecha inicial";
            this.fechaInicialDataGridViewTextBoxColumn1.HeaderText = "Fecha inicial";
            this.fechaInicialDataGridViewTextBoxColumn1.Name = "fechaInicialDataGridViewTextBoxColumn1";
            this.fechaInicialDataGridViewTextBoxColumn1.ReadOnly = true;
            this.fechaInicialDataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // fechaFinalDataGridViewTextBoxColumn1
            // 
            this.fechaFinalDataGridViewTextBoxColumn1.DataPropertyName = "Fecha final";
            this.fechaFinalDataGridViewTextBoxColumn1.HeaderText = "Fecha final";
            this.fechaFinalDataGridViewTextBoxColumn1.Name = "fechaFinalDataGridViewTextBoxColumn1";
            this.fechaFinalDataGridViewTextBoxColumn1.ReadOnly = true;
            this.fechaFinalDataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // fechaDeRegistroDataGridViewTextBoxColumn
            // 
            this.fechaDeRegistroDataGridViewTextBoxColumn.DataPropertyName = "Fecha de registro";
            this.fechaDeRegistroDataGridViewTextBoxColumn.HeaderText = "Fecha de registro";
            this.fechaDeRegistroDataGridViewTextBoxColumn.Name = "fechaDeRegistroDataGridViewTextBoxColumn";
            this.fechaDeRegistroDataGridViewTextBoxColumn.ReadOnly = true;
            this.fechaDeRegistroDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Historial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.materialButton1);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.f2);
            this.Controls.Add(this.f1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.statusStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Historial";
            this.Text = "Historial";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.getHistoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datasetHistory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel FilterStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel ShowAllLabel;
        private System.Windows.Forms.BindingSource getHistoryBindingSource;
        private DatasetHistory datasetHistory;
        private DatasetHistoryTableAdapters.getHistoryTableAdapter getHistoryTableAdapter;
        private System.Windows.Forms.DateTimePicker f1;
        private System.Windows.Forms.DateTimePicker f2;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn noDeRegistroDataGridViewTextBoxColumn1;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn localizaciónDataGridViewTextBoxColumn1;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn ingenieroDataGridViewTextBoxColumn1;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn servicioDataGridViewTextBoxColumn1;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn fechaInicialDataGridViewTextBoxColumn1;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn fechaFinalDataGridViewTextBoxColumn1;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn fechaDeRegistroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noDeRegistroDataGridViewTextBoxColumn;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn localizaciónDataGridViewTextBoxColumn;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn ingenieroDataGridViewTextBoxColumn;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn servicioDataGridViewTextBoxColumn;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn fechaInicialDataGridViewTextBoxColumn;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn fechaFinalDataGridViewTextBoxColumn;
    }
}