namespace CTZ
{
    partial class AsignarP2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AsignarP2));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Location = new MaterialSkin.Controls.MaterialComboBox();
            this.getClienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.getClienteDataSet = new CTZ.GetClienteDataSet();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.IdEquipo = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.Identificacion = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.Uso = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.certificado = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.Asignación = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.Modelo = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.idEquipoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.identificacionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noSerieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.certificadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.asignaciónDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modeloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.getAvailableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.getAvailableDataSet = new CTZ.GetAvailableDataSet();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.FilterStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.ShowAllLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Save = new MaterialSkin.Controls.MaterialButton();
            this.date1 = new System.Windows.Forms.DateTimePicker();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.Clear = new MaterialSkin.Controls.MaterialButton();
            this.date2 = new System.Windows.Forms.DateTimePicker();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.perm = new MaterialSkin.Controls.MaterialComboBox();
            this.asignacionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.asignacionDataSet = new CTZ.AsignacionDataSet();
            this.Ings = new MaterialSkin.Controls.MaterialComboBox();
            this.getIngesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ingesDataSet = new CTZ.IngesDataSet();
            this.fsr = new MaterialSkin.Controls.MaterialTextBox();
            this.clientesDataSet = new CTZ.ClientesDataSet();
            this.clientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientesTableAdapter = new CTZ.ClientesDataSetTableAdapters.ClientesTableAdapter();
            this.getIngesTableAdapter = new CTZ.IngesDataSetTableAdapters.GetIngesTableAdapter();
            this.getClienteTableAdapter = new CTZ.GetClienteDataSetTableAdapters.GetClienteTableAdapter();
            this.getAvailableTableAdapter = new CTZ.GetAvailableDataSetTableAdapters.GetAvailableTableAdapter();
            this.asignacionTableAdapter = new CTZ.AsignacionDataSetTableAdapters.AsignacionTableAdapter();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.getClienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getClienteDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getAvailableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getAvailableDataSet)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.asignacionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.asignacionDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getIngesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ingesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.22453F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 69.77547F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 116F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 250F));
            this.tableLayoutPanel1.Controls.Add(this.Location, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.Save, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.date1, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.materialLabel3, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.Clear, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.date2, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.materialLabel4, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.perm, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.Ings, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.fsr, 1, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 64);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 82.82353F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.17647F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 58F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 61F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 57F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(844, 583);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // Location
            // 
            this.Location.AutoResize = false;
            this.Location.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Location.DataSource = this.getClienteBindingSource;
            this.Location.Depth = 0;
            this.Location.DisplayMember = "Empresa";
            this.Location.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Location.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.Location.DropDownHeight = 174;
            this.Location.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Location.DropDownWidth = 121;
            this.Location.Enabled = false;
            this.Location.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.Location.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Location.FormattingEnabled = true;
            this.Location.Hint = "Locación";
            this.Location.IntegralHeight = false;
            this.Location.ItemHeight = 43;
            this.Location.Location = new System.Drawing.Point(147, 409);
            this.Location.MaxDropDownItems = 4;
            this.Location.MouseState = MaterialSkin.MouseState.OUT;
            this.Location.Name = "Location";
            this.Location.Size = new System.Drawing.Size(327, 49);
            this.Location.StartIndex = 0;
            this.Location.TabIndex = 5;
            this.Location.ValueMember = "IdCliente";
            // 
            // getClienteBindingSource
            // 
            this.getClienteBindingSource.DataMember = "GetCliente";
            this.getClienteBindingSource.DataSource = this.getClienteDataSet;
            // 
            // getClienteDataSet
            // 
            this.getClienteDataSet.DataSetName = "GetClienteDataSet";
            this.getClienteDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.panel1, 2);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.statusStrip1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(471, 331);
            this.panel1.TabIndex = 7;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdEquipo,
            this.Identificacion,
            this.Uso,
            this.certificado,
            this.Asignación,
            this.Modelo,
            this.idEquipoDataGridViewTextBoxColumn,
            this.identificacionDataGridViewTextBoxColumn,
            this.noSerieDataGridViewTextBoxColumn,
            this.certificadoDataGridViewTextBoxColumn,
            this.asignaciónDataGridViewTextBoxColumn,
            this.modeloDataGridViewTextBoxColumn,
            this.usoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.getAvailableBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(471, 309);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            this.dataGridView1.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseDown);
            this.dataGridView1.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridView1_DataBindingComplete);
            this.dataGridView1.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dataGridView1_RowPostPaint);
            this.dataGridView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridView1_KeyDown);
            // 
            // IdEquipo
            // 
            this.IdEquipo.DataPropertyName = "IdEquipo";
            this.IdEquipo.HeaderText = "IdEquipo";
            this.IdEquipo.Name = "IdEquipo";
            this.IdEquipo.ReadOnly = true;
            this.IdEquipo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Identificacion
            // 
            this.Identificacion.DataPropertyName = "Identificacion";
            this.Identificacion.HeaderText = "Identificacion";
            this.Identificacion.Name = "Identificacion";
            this.Identificacion.ReadOnly = true;
            this.Identificacion.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Uso
            // 
            this.Uso.DataPropertyName = "Uso";
            this.Uso.HeaderText = "Uso";
            this.Uso.Name = "Uso";
            this.Uso.ReadOnly = true;
            this.Uso.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // certificado
            // 
            this.certificado.DataPropertyName = "certificado";
            this.certificado.HeaderText = "certificado";
            this.certificado.Name = "certificado";
            this.certificado.ReadOnly = true;
            this.certificado.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Asignación
            // 
            this.Asignación.DataPropertyName = "Asignación";
            this.Asignación.HeaderText = "Asignación";
            this.Asignación.Name = "Asignación";
            this.Asignación.ReadOnly = true;
            this.Asignación.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Modelo
            // 
            this.Modelo.DataPropertyName = "Modelo";
            this.Modelo.HeaderText = "Modelo";
            this.Modelo.Name = "Modelo";
            this.Modelo.ReadOnly = true;
            this.Modelo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // idEquipoDataGridViewTextBoxColumn
            // 
            this.idEquipoDataGridViewTextBoxColumn.DataPropertyName = "IdEquipo";
            this.idEquipoDataGridViewTextBoxColumn.HeaderText = "IdEquipo";
            this.idEquipoDataGridViewTextBoxColumn.Name = "idEquipoDataGridViewTextBoxColumn";
            this.idEquipoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // identificacionDataGridViewTextBoxColumn
            // 
            this.identificacionDataGridViewTextBoxColumn.DataPropertyName = "Identificacion";
            this.identificacionDataGridViewTextBoxColumn.HeaderText = "Identificacion";
            this.identificacionDataGridViewTextBoxColumn.Name = "identificacionDataGridViewTextBoxColumn";
            this.identificacionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // noSerieDataGridViewTextBoxColumn
            // 
            this.noSerieDataGridViewTextBoxColumn.DataPropertyName = "NoSerie";
            this.noSerieDataGridViewTextBoxColumn.HeaderText = "NoSerie";
            this.noSerieDataGridViewTextBoxColumn.Name = "noSerieDataGridViewTextBoxColumn";
            this.noSerieDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // certificadoDataGridViewTextBoxColumn
            // 
            this.certificadoDataGridViewTextBoxColumn.DataPropertyName = "certificado";
            this.certificadoDataGridViewTextBoxColumn.HeaderText = "certificado";
            this.certificadoDataGridViewTextBoxColumn.Name = "certificadoDataGridViewTextBoxColumn";
            this.certificadoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // asignaciónDataGridViewTextBoxColumn
            // 
            this.asignaciónDataGridViewTextBoxColumn.DataPropertyName = "Asignación";
            this.asignaciónDataGridViewTextBoxColumn.HeaderText = "Asignación";
            this.asignaciónDataGridViewTextBoxColumn.Name = "asignaciónDataGridViewTextBoxColumn";
            this.asignaciónDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // modeloDataGridViewTextBoxColumn
            // 
            this.modeloDataGridViewTextBoxColumn.DataPropertyName = "Modelo";
            this.modeloDataGridViewTextBoxColumn.HeaderText = "Modelo";
            this.modeloDataGridViewTextBoxColumn.Name = "modeloDataGridViewTextBoxColumn";
            this.modeloDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // usoDataGridViewTextBoxColumn
            // 
            this.usoDataGridViewTextBoxColumn.DataPropertyName = "Uso";
            this.usoDataGridViewTextBoxColumn.HeaderText = "Uso";
            this.usoDataGridViewTextBoxColumn.Name = "usoDataGridViewTextBoxColumn";
            this.usoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // getAvailableBindingSource
            // 
            this.getAvailableBindingSource.DataMember = "GetAvailable";
            this.getAvailableBindingSource.DataSource = this.getAvailableDataSet;
            // 
            // getAvailableDataSet
            // 
            this.getAvailableDataSet.DataSetName = "GetAvailableDataSet";
            this.getAvailableDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FilterStatusLabel,
            this.ShowAllLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 309);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(471, 22);
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
            // panel2
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.panel2, 2);
            this.panel2.Controls.Add(this.dataGridView2);
            this.panel2.Location = new System.Drawing.Point(480, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(310, 331);
            this.panel2.TabIndex = 8;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowDrop = true;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(0, 0);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(310, 331);
            this.dataGridView2.TabIndex = 0;
            this.dataGridView2.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dataGridView2_RowPostPaint);
            this.dataGridView2.DragDrop += new System.Windows.Forms.DragEventHandler(this.dataGridView2_DragDrop);
            this.dataGridView2.DragEnter += new System.Windows.Forms.DragEventHandler(this.dataGridView2_DragEnter);
            // 
            // Save
            // 
            this.Save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Save.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Save.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.Save.Depth = 0;
            this.Save.HighEmphasis = true;
            this.Save.Icon = null;
            this.Save.Location = new System.Drawing.Point(752, 531);
            this.Save.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Save.MouseState = MaterialSkin.MouseState.HOVER;
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(88, 36);
            this.Save.TabIndex = 6;
            this.Save.Text = "Guardar";
            this.Save.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.Save.UseAccentColor = false;
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // date1
            // 
            this.date1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.date1.Location = new System.Drawing.Point(596, 383);
            this.date1.Name = "date1";
            this.date1.Size = new System.Drawing.Size(194, 20);
            this.date1.TabIndex = 9;
            // 
            // materialLabel3
            // 
            this.materialLabel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.Location = new System.Drawing.Point(500, 387);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(90, 19);
            this.materialLabel3.TabIndex = 10;
            this.materialLabel3.Text = "Fecha Inicial";
            // 
            // Clear
            // 
            this.Clear.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Clear.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.Clear.Depth = 0;
            this.Clear.HighEmphasis = true;
            this.Clear.Icon = null;
            this.Clear.Location = new System.Drawing.Point(4, 531);
            this.Clear.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Clear.MouseState = MaterialSkin.MouseState.HOVER;
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(79, 36);
            this.Clear.TabIndex = 11;
            this.Clear.Text = "Limpiar";
            this.Clear.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.Clear.UseAccentColor = false;
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // date2
            // 
            this.date2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.date2.Location = new System.Drawing.Point(596, 441);
            this.date2.Name = "date2";
            this.date2.Size = new System.Drawing.Size(194, 20);
            this.date2.TabIndex = 12;
            // 
            // materialLabel4
            // 
            this.materialLabel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.Location = new System.Drawing.Point(507, 445);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(83, 19);
            this.materialLabel4.TabIndex = 13;
            this.materialLabel4.Text = "Fecha Final";
            // 
            // perm
            // 
            this.perm.AutoResize = false;
            this.perm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.perm.DataSource = this.asignacionBindingSource;
            this.perm.Depth = 0;
            this.perm.DisplayMember = "Descripcion";
            this.perm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.perm.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.perm.DropDownHeight = 174;
            this.perm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.perm.DropDownWidth = 121;
            this.perm.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.perm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.perm.FormattingEnabled = true;
            this.perm.Hint = "Asignación";
            this.perm.IntegralHeight = false;
            this.perm.ItemHeight = 43;
            this.perm.Location = new System.Drawing.Point(147, 340);
            this.perm.MaxDropDownItems = 4;
            this.perm.MouseState = MaterialSkin.MouseState.OUT;
            this.perm.Name = "perm";
            this.perm.Size = new System.Drawing.Size(327, 49);
            this.perm.StartIndex = 0;
            this.perm.TabIndex = 15;
            this.perm.ValueMember = "IdAsignacion";
            this.perm.SelectedIndexChanged += new System.EventHandler(this.perm_SelectedIndexChanged);
            // 
            // asignacionBindingSource
            // 
            this.asignacionBindingSource.DataMember = "Asignacion";
            this.asignacionBindingSource.DataSource = this.asignacionDataSet;
            // 
            // asignacionDataSet
            // 
            this.asignacionDataSet.DataSetName = "AsignacionDataSet";
            this.asignacionDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Ings
            // 
            this.Ings.AutoResize = false;
            this.Ings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Ings.DataSource = this.getIngesBindingSource;
            this.Ings.Depth = 0;
            this.Ings.DisplayMember = "Nombre";
            this.Ings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Ings.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.Ings.DropDownHeight = 174;
            this.Ings.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Ings.DropDownWidth = 121;
            this.Ings.Enabled = false;
            this.Ings.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.Ings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Ings.FormattingEnabled = true;
            this.Ings.Hint = "Ingeniero";
            this.Ings.IntegralHeight = false;
            this.Ings.ItemHeight = 43;
            this.Ings.Location = new System.Drawing.Point(147, 467);
            this.Ings.MaxDropDownItems = 4;
            this.Ings.MouseState = MaterialSkin.MouseState.OUT;
            this.Ings.Name = "Ings";
            this.Ings.Size = new System.Drawing.Size(327, 49);
            this.Ings.StartIndex = 0;
            this.Ings.TabIndex = 3;
            this.Ings.ValueMember = "IdUsuario";
            // 
            // getIngesBindingSource
            // 
            this.getIngesBindingSource.DataMember = "GetInges";
            this.getIngesBindingSource.DataSource = this.ingesDataSet;
            // 
            // ingesDataSet
            // 
            this.ingesDataSet.DataSetName = "IngesDataSet";
            this.ingesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fsr
            // 
            this.fsr.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.fsr.Depth = 0;
            this.fsr.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fsr.Enabled = false;
            this.fsr.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.fsr.Hint = "Folio";
            this.fsr.LeadingIcon = null;
            this.fsr.Location = new System.Drawing.Point(147, 528);
            this.fsr.MaxLength = 250;
            this.fsr.MouseState = MaterialSkin.MouseState.OUT;
            this.fsr.Multiline = false;
            this.fsr.Name = "fsr";
            this.fsr.Size = new System.Drawing.Size(327, 50);
            this.fsr.TabIndex = 16;
            this.fsr.Text = "";
            this.fsr.TrailingIcon = null;
            // 
            // clientesDataSet
            // 
            this.clientesDataSet.DataSetName = "ClientesDataSet";
            this.clientesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clientesBindingSource
            // 
            this.clientesBindingSource.DataMember = "Clientes";
            this.clientesBindingSource.DataSource = this.clientesDataSet;
            // 
            // clientesTableAdapter
            // 
            this.clientesTableAdapter.ClearBeforeFill = true;
            // 
            // getIngesTableAdapter
            // 
            this.getIngesTableAdapter.ClearBeforeFill = true;
            // 
            // getClienteTableAdapter
            // 
            this.getClienteTableAdapter.ClearBeforeFill = true;
            // 
            // getAvailableTableAdapter
            // 
            this.getAvailableTableAdapter.ClearBeforeFill = true;
            // 
            // asignacionTableAdapter
            // 
            this.asignacionTableAdapter.ClearBeforeFill = true;
            // 
            // AsignarP2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 650);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AsignarP2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Asignar EQ\'s";
            this.Load += new System.EventHandler(this.AsignarP2_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.getClienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getClienteDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getAvailableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getAvailableDataSet)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.asignacionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.asignacionDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getIngesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ingesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private new MaterialSkin.Controls.MaterialComboBox Location;
        private MaterialSkin.Controls.MaterialButton Save;
        private ClientesDataSet clientesDataSet;
        private System.Windows.Forms.BindingSource clientesBindingSource;
        private ClientesDataSetTableAdapters.ClientesTableAdapter clientesTableAdapter;
        private IngesDataSet ingesDataSet;
        private System.Windows.Forms.BindingSource getIngesBindingSource;
        private IngesDataSetTableAdapters.GetIngesTableAdapter getIngesTableAdapter;
        private GetClienteDataSet getClienteDataSet;
        private System.Windows.Forms.BindingSource getClienteBindingSource;
        private GetClienteDataSetTableAdapters.GetClienteTableAdapter getClienteTableAdapter;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel FilterStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel ShowAllLabel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private GetAvailableDataSet getAvailableDataSet;
        private System.Windows.Forms.BindingSource getAvailableBindingSource;
        private GetAvailableDataSetTableAdapters.GetAvailableTableAdapter getAvailableTableAdapter;
        private System.Windows.Forms.DateTimePicker date1;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialButton Clear;
        private System.Windows.Forms.DateTimePicker date2;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private AsignacionDataSet asignacionDataSet;
        private System.Windows.Forms.BindingSource asignacionBindingSource;
        private AsignacionDataSetTableAdapters.AsignacionTableAdapter asignacionTableAdapter;
        private MaterialSkin.Controls.MaterialComboBox perm;
        private MaterialSkin.Controls.MaterialComboBox Ings;
        private MaterialSkin.Controls.MaterialTextBox fsr;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn IdEquipo;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn Identificacion;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn Uso;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn certificado;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn Asignación;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn Modelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn idEquipoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn identificacionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noSerieDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn certificadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn asignaciónDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modeloDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usoDataGridViewTextBoxColumn;
    }
}