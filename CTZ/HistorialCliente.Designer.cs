namespace CTZ
{
    partial class HistorialCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HistorialCliente));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.clientes = new MaterialSkin.Controls.MaterialComboBox();
            this.clientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientesDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientesDataSet = new CTZ.ClientesDataSet();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.noDeRegistroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.identificacionDataGridViewTextBoxColumn = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.folioDataGridViewTextBoxColumn = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.fechaDeInicioDataGridViewTextBoxColumn = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.fechaFinalDataGridViewTextBoxColumn = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.gethistorybyclientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.datasetHistory = new CTZ.DatasetHistory();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.FilterStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.ShowAllLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.clientesTableAdapter = new CTZ.ClientesDataSetTableAdapters.ClientesTableAdapter();
            this.gethistorybyclientTableAdapter = new CTZ.DatasetHistoryTableAdapters.gethistorybyclientTableAdapter();
            this.print = new MaterialSkin.Controls.MaterialButton();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gethistorybyclientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datasetHistory)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.clientes, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.print, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 64);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.23238F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 82.76762F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(794, 383);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // clientes
            // 
            this.clientes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.clientes.AutoResize = false;
            this.clientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.clientes.DataSource = this.clientesBindingSource;
            this.clientes.Depth = 0;
            this.clientes.DisplayMember = "Empresa";
            this.clientes.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.clientes.DropDownHeight = 174;
            this.clientes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.clientes.DropDownWidth = 121;
            this.clientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.clientes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.clientes.FormattingEnabled = true;
            this.clientes.Hint = "Cliente";
            this.clientes.IntegralHeight = false;
            this.clientes.ItemHeight = 43;
            this.clientes.Location = new System.Drawing.Point(3, 8);
            this.clientes.MaxDropDownItems = 4;
            this.clientes.MouseState = MaterialSkin.MouseState.OUT;
            this.clientes.Name = "clientes";
            this.clientes.Size = new System.Drawing.Size(391, 49);
            this.clientes.StartIndex = 0;
            this.clientes.TabIndex = 0;
            this.clientes.ValueMember = "IdCliente";
            this.clientes.SelectedIndexChanged += new System.EventHandler(this.materialComboBox1_SelectedIndexChanged);
            // 
            // clientesBindingSource
            // 
            this.clientesBindingSource.DataMember = "Clientes";
            this.clientesBindingSource.DataSource = this.clientesDataSetBindingSource;
            // 
            // clientesDataSetBindingSource
            // 
            this.clientesDataSetBindingSource.DataSource = this.clientesDataSet;
            this.clientesDataSetBindingSource.Position = 0;
            // 
            // clientesDataSet
            // 
            this.clientesDataSet.DataSetName = "ClientesDataSet";
            this.clientesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.panel1, 2);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.statusStrip1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 69);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(788, 311);
            this.panel1.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.noDeRegistroDataGridViewTextBoxColumn,
            this.identificacionDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.folioDataGridViewTextBoxColumn,
            this.fechaDeInicioDataGridViewTextBoxColumn,
            this.fechaFinalDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.gethistorybyclientBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(788, 289);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridView1_DataBindingComplete);
            this.dataGridView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridView1_KeyDown);
            // 
            // noDeRegistroDataGridViewTextBoxColumn
            // 
            this.noDeRegistroDataGridViewTextBoxColumn.DataPropertyName = "No_ de registro";
            this.noDeRegistroDataGridViewTextBoxColumn.HeaderText = "No_ de registro";
            this.noDeRegistroDataGridViewTextBoxColumn.Name = "noDeRegistroDataGridViewTextBoxColumn";
            this.noDeRegistroDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // identificacionDataGridViewTextBoxColumn
            // 
            this.identificacionDataGridViewTextBoxColumn.DataPropertyName = "Identificacion";
            this.identificacionDataGridViewTextBoxColumn.HeaderText = "Identificacion";
            this.identificacionDataGridViewTextBoxColumn.Name = "identificacionDataGridViewTextBoxColumn";
            this.identificacionDataGridViewTextBoxColumn.ReadOnly = true;
            this.identificacionDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.ReadOnly = true;
            this.nombreDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // folioDataGridViewTextBoxColumn
            // 
            this.folioDataGridViewTextBoxColumn.DataPropertyName = "Folio";
            this.folioDataGridViewTextBoxColumn.HeaderText = "Folio";
            this.folioDataGridViewTextBoxColumn.Name = "folioDataGridViewTextBoxColumn";
            this.folioDataGridViewTextBoxColumn.ReadOnly = true;
            this.folioDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // fechaDeInicioDataGridViewTextBoxColumn
            // 
            this.fechaDeInicioDataGridViewTextBoxColumn.DataPropertyName = "Fecha de inicio";
            this.fechaDeInicioDataGridViewTextBoxColumn.HeaderText = "Fecha de inicio";
            this.fechaDeInicioDataGridViewTextBoxColumn.Name = "fechaDeInicioDataGridViewTextBoxColumn";
            this.fechaDeInicioDataGridViewTextBoxColumn.ReadOnly = true;
            this.fechaDeInicioDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // fechaFinalDataGridViewTextBoxColumn
            // 
            this.fechaFinalDataGridViewTextBoxColumn.DataPropertyName = "Fecha final";
            this.fechaFinalDataGridViewTextBoxColumn.HeaderText = "Fecha final";
            this.fechaFinalDataGridViewTextBoxColumn.Name = "fechaFinalDataGridViewTextBoxColumn";
            this.fechaFinalDataGridViewTextBoxColumn.ReadOnly = true;
            this.fechaFinalDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // gethistorybyclientBindingSource
            // 
            this.gethistorybyclientBindingSource.DataMember = "gethistorybyclient";
            this.gethistorybyclientBindingSource.DataSource = this.datasetHistory;
            // 
            // datasetHistory
            // 
            this.datasetHistory.DataSetName = "DatasetHistory";
            this.datasetHistory.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FilterStatusLabel,
            this.ShowAllLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 289);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(788, 22);
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
            // clientesTableAdapter
            // 
            this.clientesTableAdapter.ClearBeforeFill = true;
            // 
            // gethistorybyclientTableAdapter
            // 
            this.gethistorybyclientTableAdapter.ClearBeforeFill = true;
            // 
            // print
            // 
            this.print.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.print.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.print.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.print.Depth = 0;
            this.print.HighEmphasis = true;
            this.print.Icon = null;
            this.print.Location = new System.Drawing.Point(703, 15);
            this.print.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.print.MouseState = MaterialSkin.MouseState.HOVER;
            this.print.Name = "print";
            this.print.Size = new System.Drawing.Size(87, 36);
            this.print.TabIndex = 2;
            this.print.Text = "Imprimir";
            this.print.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text;
            this.print.UseAccentColor = false;
            this.print.UseVisualStyleBackColor = true;
            this.print.Click += new System.EventHandler(this.print_Click);
            // 
            // HistorialCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "HistorialCliente";
            this.Text = "Historial por cliente";
            this.Load += new System.EventHandler(this.HistorialCliente_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gethistorybyclientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datasetHistory)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private MaterialSkin.Controls.MaterialComboBox clientes;
        private System.Windows.Forms.BindingSource clientesDataSetBindingSource;
        private ClientesDataSet clientesDataSet;
        private System.Windows.Forms.BindingSource clientesBindingSource;
        private ClientesDataSetTableAdapters.ClientesTableAdapter clientesTableAdapter;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel FilterStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel ShowAllLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn noDeRegistroDataGridViewTextBoxColumn;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn identificacionDataGridViewTextBoxColumn;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn nombreDataGridViewTextBoxColumn;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn folioDataGridViewTextBoxColumn;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn fechaDeInicioDataGridViewTextBoxColumn;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn fechaFinalDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource gethistorybyclientBindingSource;
        private DatasetHistory datasetHistory;
        private DatasetHistoryTableAdapters.gethistorybyclientTableAdapter gethistorybyclientTableAdapter;
        private MaterialSkin.Controls.MaterialButton print;
    }
}