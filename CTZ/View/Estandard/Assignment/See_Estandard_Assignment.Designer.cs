namespace CTZ.View.Estandard.Assignment
{
    partial class See_Estandard_Assignment
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
            this.Dgv_Assignment = new ADGV.AdvancedDataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eSTEstandardDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaEntregaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ingenieroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.folioEmpresaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreEmpresaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.observacionesEntregaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firmaIngenieroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaEstimadaDevolucionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.observacionesDevolucionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firmaCalidadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.correoIngenieroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaDevolucionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firmaIngenieroDevolucionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.asignacionEstandaresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.trazabilidadTestDataSet4BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.trazabilidadTestDataSet4 = new CTZ.TrazabilidadTestDataSet4();
            this.TxtBox_Enginner = new System.Windows.Forms.TextBox();
            this.Lbl_Engineer = new TheArtOfDev.HtmlRenderer.WinForms.HtmlLabel();
            this.Btn_Serch_Enginner = new System.Windows.Forms.Button();
            this.Lbl_Estandard = new TheArtOfDev.HtmlRenderer.WinForms.HtmlLabel();
            this.TxtBox_Estandard = new System.Windows.Forms.TextBox();
            this.Btn_Serch_Estandard = new System.Windows.Forms.Button();
            this.Lbl_Brand = new TheArtOfDev.HtmlRenderer.WinForms.HtmlLabel();
            this.TxtBox_Brand = new System.Windows.Forms.TextBox();
            this.Btn_Serch_Brand = new System.Windows.Forms.Button();
            this.Btn_Clean = new System.Windows.Forms.Button();
            this.asignacionEstandaresTableAdapter = new CTZ.TrazabilidadTestDataSet4TableAdapters.AsignacionEstandaresTableAdapter();
            this.Dgv_Standar_Information = new ADGV.AdvancedDataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Assignment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.asignacionEstandaresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trazabilidadTestDataSet4BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trazabilidadTestDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Standar_Information)).BeginInit();
            this.SuspendLayout();
            // 
            // Dgv_Assignment
            // 
            this.Dgv_Assignment.AllowUserToAddRows = false;
            this.Dgv_Assignment.AllowUserToDeleteRows = false;
            this.Dgv_Assignment.AllowUserToOrderColumns = true;
            this.Dgv_Assignment.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Dgv_Assignment.AutoGenerateColumns = false;
            this.Dgv_Assignment.AutoGenerateContextFilters = true;
            this.Dgv_Assignment.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(238)))), ((int)(((byte)(243)))));
            this.Dgv_Assignment.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.Dgv_Assignment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_Assignment.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.eSTEstandardDataGridViewTextBoxColumn,
            this.fechaEntregaDataGridViewTextBoxColumn,
            this.ingenieroDataGridViewTextBoxColumn,
            this.folioEmpresaDataGridViewTextBoxColumn,
            this.nombreEmpresaDataGridViewTextBoxColumn,
            this.observacionesEntregaDataGridViewTextBoxColumn,
            this.firmaIngenieroDataGridViewTextBoxColumn,
            this.fechaEstimadaDevolucionDataGridViewTextBoxColumn,
            this.observacionesDevolucionDataGridViewTextBoxColumn,
            this.firmaCalidadDataGridViewTextBoxColumn,
            this.correoIngenieroDataGridViewTextBoxColumn,
            this.fechaDevolucionDataGridViewTextBoxColumn,
            this.firmaIngenieroDevolucionDataGridViewTextBoxColumn});
            this.Dgv_Assignment.DataSource = this.asignacionEstandaresBindingSource;
            this.Dgv_Assignment.DateWithTime = false;
            this.Dgv_Assignment.Location = new System.Drawing.Point(6, 228);
            this.Dgv_Assignment.Name = "Dgv_Assignment";
            this.Dgv_Assignment.Size = new System.Drawing.Size(936, 388);
            this.Dgv_Assignment.TabIndex = 0;
            this.Dgv_Assignment.TimeFilter = false;
            this.Dgv_Assignment.FilterStringChanged += new System.EventHandler(this.Dgv_Assignment_FilterStringChanged);
            this.Dgv_Assignment.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_Assignment_CellContentDoubleClick);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // eSTEstandardDataGridViewTextBoxColumn
            // 
            this.eSTEstandardDataGridViewTextBoxColumn.DataPropertyName = "EST_Estandard";
            this.eSTEstandardDataGridViewTextBoxColumn.HeaderText = "EST_Estandard";
            this.eSTEstandardDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.eSTEstandardDataGridViewTextBoxColumn.Name = "eSTEstandardDataGridViewTextBoxColumn";
            this.eSTEstandardDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // fechaEntregaDataGridViewTextBoxColumn
            // 
            this.fechaEntregaDataGridViewTextBoxColumn.DataPropertyName = "Fecha_Entrega";
            this.fechaEntregaDataGridViewTextBoxColumn.HeaderText = "Fecha_Entrega";
            this.fechaEntregaDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.fechaEntregaDataGridViewTextBoxColumn.Name = "fechaEntregaDataGridViewTextBoxColumn";
            this.fechaEntregaDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // ingenieroDataGridViewTextBoxColumn
            // 
            this.ingenieroDataGridViewTextBoxColumn.DataPropertyName = "Ingeniero";
            this.ingenieroDataGridViewTextBoxColumn.HeaderText = "Ingeniero";
            this.ingenieroDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.ingenieroDataGridViewTextBoxColumn.Name = "ingenieroDataGridViewTextBoxColumn";
            this.ingenieroDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // folioEmpresaDataGridViewTextBoxColumn
            // 
            this.folioEmpresaDataGridViewTextBoxColumn.DataPropertyName = "Folio_Empresa";
            this.folioEmpresaDataGridViewTextBoxColumn.HeaderText = "Folio_Empresa";
            this.folioEmpresaDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.folioEmpresaDataGridViewTextBoxColumn.Name = "folioEmpresaDataGridViewTextBoxColumn";
            this.folioEmpresaDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // nombreEmpresaDataGridViewTextBoxColumn
            // 
            this.nombreEmpresaDataGridViewTextBoxColumn.DataPropertyName = "Nombre_Empresa";
            this.nombreEmpresaDataGridViewTextBoxColumn.HeaderText = "Nombre_Empresa";
            this.nombreEmpresaDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.nombreEmpresaDataGridViewTextBoxColumn.Name = "nombreEmpresaDataGridViewTextBoxColumn";
            this.nombreEmpresaDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // observacionesEntregaDataGridViewTextBoxColumn
            // 
            this.observacionesEntregaDataGridViewTextBoxColumn.DataPropertyName = "Observaciones_Entrega";
            this.observacionesEntregaDataGridViewTextBoxColumn.HeaderText = "Observaciones_Entrega";
            this.observacionesEntregaDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.observacionesEntregaDataGridViewTextBoxColumn.Name = "observacionesEntregaDataGridViewTextBoxColumn";
            this.observacionesEntregaDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // firmaIngenieroDataGridViewTextBoxColumn
            // 
            this.firmaIngenieroDataGridViewTextBoxColumn.DataPropertyName = "Firma_Ingeniero";
            this.firmaIngenieroDataGridViewTextBoxColumn.HeaderText = "Firma_Ingeniero";
            this.firmaIngenieroDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.firmaIngenieroDataGridViewTextBoxColumn.Name = "firmaIngenieroDataGridViewTextBoxColumn";
            this.firmaIngenieroDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // fechaEstimadaDevolucionDataGridViewTextBoxColumn
            // 
            this.fechaEstimadaDevolucionDataGridViewTextBoxColumn.DataPropertyName = "Fecha_Estimada_Devolucion";
            this.fechaEstimadaDevolucionDataGridViewTextBoxColumn.HeaderText = "Fecha_Estimada_Devolucion";
            this.fechaEstimadaDevolucionDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.fechaEstimadaDevolucionDataGridViewTextBoxColumn.Name = "fechaEstimadaDevolucionDataGridViewTextBoxColumn";
            this.fechaEstimadaDevolucionDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // observacionesDevolucionDataGridViewTextBoxColumn
            // 
            this.observacionesDevolucionDataGridViewTextBoxColumn.DataPropertyName = "Observaciones_Devolucion";
            this.observacionesDevolucionDataGridViewTextBoxColumn.HeaderText = "Observaciones_Devolucion";
            this.observacionesDevolucionDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.observacionesDevolucionDataGridViewTextBoxColumn.Name = "observacionesDevolucionDataGridViewTextBoxColumn";
            this.observacionesDevolucionDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // firmaCalidadDataGridViewTextBoxColumn
            // 
            this.firmaCalidadDataGridViewTextBoxColumn.DataPropertyName = "Firma_Calidad";
            this.firmaCalidadDataGridViewTextBoxColumn.HeaderText = "Firma_Calidad";
            this.firmaCalidadDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.firmaCalidadDataGridViewTextBoxColumn.Name = "firmaCalidadDataGridViewTextBoxColumn";
            this.firmaCalidadDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // correoIngenieroDataGridViewTextBoxColumn
            // 
            this.correoIngenieroDataGridViewTextBoxColumn.DataPropertyName = "Correo_Ingeniero";
            this.correoIngenieroDataGridViewTextBoxColumn.HeaderText = "Correo_Ingeniero";
            this.correoIngenieroDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.correoIngenieroDataGridViewTextBoxColumn.Name = "correoIngenieroDataGridViewTextBoxColumn";
            this.correoIngenieroDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // fechaDevolucionDataGridViewTextBoxColumn
            // 
            this.fechaDevolucionDataGridViewTextBoxColumn.DataPropertyName = "Fecha_Devolucion";
            this.fechaDevolucionDataGridViewTextBoxColumn.HeaderText = "Fecha_Devolucion";
            this.fechaDevolucionDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.fechaDevolucionDataGridViewTextBoxColumn.Name = "fechaDevolucionDataGridViewTextBoxColumn";
            this.fechaDevolucionDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // firmaIngenieroDevolucionDataGridViewTextBoxColumn
            // 
            this.firmaIngenieroDevolucionDataGridViewTextBoxColumn.DataPropertyName = "Firma_Ingeniero_Devolucion";
            this.firmaIngenieroDevolucionDataGridViewTextBoxColumn.HeaderText = "Firma_Ingeniero_Devolucion";
            this.firmaIngenieroDevolucionDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.firmaIngenieroDevolucionDataGridViewTextBoxColumn.Name = "firmaIngenieroDevolucionDataGridViewTextBoxColumn";
            this.firmaIngenieroDevolucionDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // asignacionEstandaresBindingSource
            // 
            this.asignacionEstandaresBindingSource.DataMember = "AsignacionEstandares";
            this.asignacionEstandaresBindingSource.DataSource = this.trazabilidadTestDataSet4BindingSource;
            // 
            // trazabilidadTestDataSet4BindingSource
            // 
            this.trazabilidadTestDataSet4BindingSource.DataSource = this.trazabilidadTestDataSet4;
            this.trazabilidadTestDataSet4BindingSource.Position = 0;
            // 
            // trazabilidadTestDataSet4
            // 
            this.trazabilidadTestDataSet4.DataSetName = "TrazabilidadTestDataSet4";
            this.trazabilidadTestDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // TxtBox_Enginner
            // 
            this.TxtBox_Enginner.Location = new System.Drawing.Point(117, 93);
            this.TxtBox_Enginner.Name = "TxtBox_Enginner";
            this.TxtBox_Enginner.Size = new System.Drawing.Size(170, 20);
            this.TxtBox_Enginner.TabIndex = 2;
            // 
            // Lbl_Engineer
            // 
            this.Lbl_Engineer.BackColor = System.Drawing.SystemColors.Window;
            this.Lbl_Engineer.BaseStylesheet = null;
            this.Lbl_Engineer.Location = new System.Drawing.Point(38, 93);
            this.Lbl_Engineer.Name = "Lbl_Engineer";
            this.Lbl_Engineer.Size = new System.Drawing.Size(63, 20);
            this.Lbl_Engineer.TabIndex = 3;
            this.Lbl_Engineer.Text = "Ingeniero";
            // 
            // Btn_Serch_Enginner
            // 
            this.Btn_Serch_Enginner.Location = new System.Drawing.Point(293, 91);
            this.Btn_Serch_Enginner.Name = "Btn_Serch_Enginner";
            this.Btn_Serch_Enginner.Size = new System.Drawing.Size(75, 23);
            this.Btn_Serch_Enginner.TabIndex = 4;
            this.Btn_Serch_Enginner.Text = "Buscar";
            this.Btn_Serch_Enginner.UseVisualStyleBackColor = true;
            this.Btn_Serch_Enginner.Click += new System.EventHandler(this.Btn_Serch_Enginner_Click);
            // 
            // Lbl_Estandard
            // 
            this.Lbl_Estandard.BackColor = System.Drawing.SystemColors.Window;
            this.Lbl_Estandard.BaseStylesheet = null;
            this.Lbl_Estandard.Location = new System.Drawing.Point(386, 94);
            this.Lbl_Estandard.Name = "Lbl_Estandard";
            this.Lbl_Estandard.Size = new System.Drawing.Size(57, 20);
            this.Lbl_Estandard.TabIndex = 5;
            this.Lbl_Estandard.Text = "Estándar";
            // 
            // TxtBox_Estandard
            // 
            this.TxtBox_Estandard.Location = new System.Drawing.Point(459, 94);
            this.TxtBox_Estandard.Name = "TxtBox_Estandard";
            this.TxtBox_Estandard.Size = new System.Drawing.Size(140, 20);
            this.TxtBox_Estandard.TabIndex = 6;
            // 
            // Btn_Serch_Estandard
            // 
            this.Btn_Serch_Estandard.Location = new System.Drawing.Point(614, 93);
            this.Btn_Serch_Estandard.Name = "Btn_Serch_Estandard";
            this.Btn_Serch_Estandard.Size = new System.Drawing.Size(75, 23);
            this.Btn_Serch_Estandard.TabIndex = 7;
            this.Btn_Serch_Estandard.Text = "Buscar";
            this.Btn_Serch_Estandard.UseVisualStyleBackColor = true;
            this.Btn_Serch_Estandard.Click += new System.EventHandler(this.Btn_Serch_Estandard_Click);
            // 
            // Lbl_Brand
            // 
            this.Lbl_Brand.BackColor = System.Drawing.SystemColors.Window;
            this.Lbl_Brand.BaseStylesheet = null;
            this.Lbl_Brand.Location = new System.Drawing.Point(722, 93);
            this.Lbl_Brand.Name = "Lbl_Brand";
            this.Lbl_Brand.Size = new System.Drawing.Size(57, 20);
            this.Lbl_Brand.TabIndex = 8;
            this.Lbl_Brand.Text = "Empresa";
            // 
            // TxtBox_Brand
            // 
            this.TxtBox_Brand.Location = new System.Drawing.Point(785, 95);
            this.TxtBox_Brand.Name = "TxtBox_Brand";
            this.TxtBox_Brand.Size = new System.Drawing.Size(179, 20);
            this.TxtBox_Brand.TabIndex = 9;
            // 
            // Btn_Serch_Brand
            // 
            this.Btn_Serch_Brand.Location = new System.Drawing.Point(984, 94);
            this.Btn_Serch_Brand.Name = "Btn_Serch_Brand";
            this.Btn_Serch_Brand.Size = new System.Drawing.Size(75, 23);
            this.Btn_Serch_Brand.TabIndex = 10;
            this.Btn_Serch_Brand.Text = "Buscar";
            this.Btn_Serch_Brand.UseVisualStyleBackColor = true;
            this.Btn_Serch_Brand.Click += new System.EventHandler(this.Btn_Serch_Brand_Click);
            // 
            // Btn_Clean
            // 
            this.Btn_Clean.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(112)))), ((int)(((byte)(192)))));
            this.Btn_Clean.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Clean.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Clean.ForeColor = System.Drawing.SystemColors.Control;
            this.Btn_Clean.Location = new System.Drawing.Point(38, 142);
            this.Btn_Clean.Name = "Btn_Clean";
            this.Btn_Clean.Size = new System.Drawing.Size(87, 49);
            this.Btn_Clean.TabIndex = 16;
            this.Btn_Clean.Text = "Limpiar Busqueda";
            this.Btn_Clean.UseVisualStyleBackColor = false;
            this.Btn_Clean.Click += new System.EventHandler(this.Btn_Clean_Click);
            // 
            // asignacionEstandaresTableAdapter
            // 
            this.asignacionEstandaresTableAdapter.ClearBeforeFill = true;
            // 
            // Dgv_Standar_Information
            // 
            this.Dgv_Standar_Information.AllowUserToAddRows = false;
            this.Dgv_Standar_Information.AllowUserToDeleteRows = false;
            this.Dgv_Standar_Information.AllowUserToOrderColumns = true;
            this.Dgv_Standar_Information.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Dgv_Standar_Information.AutoGenerateContextFilters = true;
            this.Dgv_Standar_Information.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(238)))), ((int)(((byte)(243)))));
            this.Dgv_Standar_Information.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.Dgv_Standar_Information.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_Standar_Information.DateWithTime = false;
            this.Dgv_Standar_Information.Location = new System.Drawing.Point(963, 228);
            this.Dgv_Standar_Information.Name = "Dgv_Standar_Information";
            this.Dgv_Standar_Information.Size = new System.Drawing.Size(277, 132);
            this.Dgv_Standar_Information.TabIndex = 17;
            this.Dgv_Standar_Information.TimeFilter = false;
            // 
            // See_Estandard_Assignment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1261, 622);
            this.Controls.Add(this.Dgv_Standar_Information);
            this.Controls.Add(this.Btn_Clean);
            this.Controls.Add(this.Btn_Serch_Brand);
            this.Controls.Add(this.TxtBox_Brand);
            this.Controls.Add(this.Lbl_Brand);
            this.Controls.Add(this.Dgv_Assignment);
            this.Controls.Add(this.Btn_Serch_Estandard);
            this.Controls.Add(this.TxtBox_Estandard);
            this.Controls.Add(this.Lbl_Engineer);
            this.Controls.Add(this.Lbl_Estandard);
            this.Controls.Add(this.TxtBox_Enginner);
            this.Controls.Add(this.Btn_Serch_Enginner);
            this.Name = "See_Estandard_Assignment";
            this.Text = "Consultar Asignacion de Estándar";
            this.Load += new System.EventHandler(this.See_Estandard_Assignment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Assignment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.asignacionEstandaresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trazabilidadTestDataSet4BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trazabilidadTestDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Standar_Information)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ADGV.AdvancedDataGridView Dgv_Assignment;
        private System.Windows.Forms.TextBox TxtBox_Enginner;
        private TheArtOfDev.HtmlRenderer.WinForms.HtmlLabel Lbl_Engineer;
        private System.Windows.Forms.Button Btn_Serch_Enginner;
        private TheArtOfDev.HtmlRenderer.WinForms.HtmlLabel Lbl_Estandard;
        private System.Windows.Forms.TextBox TxtBox_Estandard;
        private System.Windows.Forms.Button Btn_Serch_Estandard;
        private TheArtOfDev.HtmlRenderer.WinForms.HtmlLabel Lbl_Brand;
        private System.Windows.Forms.TextBox TxtBox_Brand;
        private System.Windows.Forms.Button Btn_Serch_Brand;
        private System.Windows.Forms.Button Btn_Clean;
        private System.Windows.Forms.BindingSource trazabilidadTestDataSet4BindingSource;
        private TrazabilidadTestDataSet4 trazabilidadTestDataSet4;
        private System.Windows.Forms.BindingSource asignacionEstandaresBindingSource;
        private TrazabilidadTestDataSet4TableAdapters.AsignacionEstandaresTableAdapter asignacionEstandaresTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eSTEstandardDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaEntregaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ingenieroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn folioEmpresaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreEmpresaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn observacionesEntregaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firmaIngenieroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaEstimadaDevolucionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn observacionesDevolucionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firmaCalidadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn correoIngenieroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaDevolucionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firmaIngenieroDevolucionDataGridViewTextBoxColumn;
        private ADGV.AdvancedDataGridView Dgv_Standar_Information;
    }
}