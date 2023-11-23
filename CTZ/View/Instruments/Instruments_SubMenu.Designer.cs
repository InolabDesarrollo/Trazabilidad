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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.parametrosTableAdapter1 = new CTZ.DocumentacionDataSetTableAdapters.ParametrosTableAdapter();
            this.parametrosTableAdapter2 = new CTZ.DocumentacionDataSetTableAdapters.ParametrosTableAdapter();
            this.TabControl_Instruments = new System.Windows.Forms.TabControl();
            this.Page_Instruments = new System.Windows.Forms.TabPage();
            this.Dgv_Instruments = new ADGV.AdvancedDataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDInstrumentosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iNSTRUMENTODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mARCADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mODELODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uBICACIÓNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oBSERVACIÓNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eSTATUSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.instrumentosBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.trazabilidadTestInstrumentosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.trazabilidadTest_Instrumentos = new CTZ.TrazabilidadTest_Instrumentos();
            this.Page_Instruments_Certificates = new System.Windows.Forms.TabPage();
            this.Dgv_Instruments_Certificates = new ADGV.AdvancedDataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FECHA_DE_CALIBRACION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Proxima_Calibracion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Laboratorio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha_Registro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ASIGNACION_INSTRUMENTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.instrumentosCertificadoBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.trazabilidadTestDataSet3 = new CTZ.TrazabilidadTestDataSet3();
            this.instrumentosCertificadoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.instrumentos_CertificadoTableAdapter = new CTZ.TrazabilidadTestDataSet3TableAdapters.Instrumentos_CertificadoTableAdapter();
            this.instrumentosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.instrumentosTableAdapter = new CTZ.TrazabilidadTest_InstrumentosTableAdapters.InstrumentosTableAdapter();
            this.instrumentosCertificadoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.Btn_Add = new System.Windows.Forms.Button();
            this.BtnDelete_Instruments = new System.Windows.Forms.Button();
            this.BtnUpdate_Instrument = new System.Windows.Forms.Button();
            this.TabControl_Instruments.SuspendLayout();
            this.Page_Instruments.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Instruments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.instrumentosBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trazabilidadTestInstrumentosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trazabilidadTest_Instrumentos)).BeginInit();
            this.Page_Instruments_Certificates.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Instruments_Certificates)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.instrumentosCertificadoBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trazabilidadTestDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.instrumentosCertificadoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.instrumentosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.instrumentosCertificadoBindingSource1)).BeginInit();
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
            this.TabControl_Instruments.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TabControl_Instruments.Controls.Add(this.Page_Instruments);
            this.TabControl_Instruments.Controls.Add(this.Page_Instruments_Certificates);
            this.TabControl_Instruments.Location = new System.Drawing.Point(12, 89);
            this.TabControl_Instruments.Name = "TabControl_Instruments";
            this.TabControl_Instruments.SelectedIndex = 0;
            this.TabControl_Instruments.Size = new System.Drawing.Size(1128, 358);
            this.TabControl_Instruments.TabIndex = 0;
            this.TabControl_Instruments.SelectedIndexChanged += new System.EventHandler(this.TabControl_Instruments_SelectedIndexChanged);
            // 
            // Page_Instruments
            // 
            this.Page_Instruments.Controls.Add(this.Dgv_Instruments);
            this.Page_Instruments.Location = new System.Drawing.Point(4, 22);
            this.Page_Instruments.Name = "Page_Instruments";
            this.Page_Instruments.Padding = new System.Windows.Forms.Padding(3);
            this.Page_Instruments.Size = new System.Drawing.Size(1120, 332);
            this.Page_Instruments.TabIndex = 0;
            this.Page_Instruments.Text = "Instrumentos";
            this.Page_Instruments.UseVisualStyleBackColor = true;
            // 
            // Dgv_Instruments
            // 
            this.Dgv_Instruments.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Dgv_Instruments.AutoGenerateColumns = false;
            this.Dgv_Instruments.AutoGenerateContextFilters = false;
            this.Dgv_Instruments.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Dgv_Instruments.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(238)))), ((int)(((byte)(243)))));
            this.Dgv_Instruments.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Dgv_Instruments.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.Dgv_Instruments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_Instruments.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.iDInstrumentosDataGridViewTextBoxColumn,
            this.iNSTRUMENTODataGridViewTextBoxColumn,
            this.mARCADataGridViewTextBoxColumn,
            this.mODELODataGridViewTextBoxColumn,
            this.nSDataGridViewTextBoxColumn,
            this.uBICACIÓNDataGridViewTextBoxColumn,
            this.oBSERVACIÓNDataGridViewTextBoxColumn,
            this.eSTATUSDataGridViewTextBoxColumn});
            this.Dgv_Instruments.DataSource = this.instrumentosBindingSource1;
            this.Dgv_Instruments.DateWithTime = false;
            this.Dgv_Instruments.Location = new System.Drawing.Point(3, 51);
            this.Dgv_Instruments.Name = "Dgv_Instruments";
            this.Dgv_Instruments.Size = new System.Drawing.Size(1111, 275);
            this.Dgv_Instruments.TabIndex = 0;
            this.Dgv_Instruments.TimeFilter = false;
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
            // iDInstrumentosDataGridViewTextBoxColumn
            // 
            this.iDInstrumentosDataGridViewTextBoxColumn.DataPropertyName = "ID_Instrumentos";
            this.iDInstrumentosDataGridViewTextBoxColumn.HeaderText = "ID_Instrumentos";
            this.iDInstrumentosDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.iDInstrumentosDataGridViewTextBoxColumn.Name = "iDInstrumentosDataGridViewTextBoxColumn";
            this.iDInstrumentosDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // iNSTRUMENTODataGridViewTextBoxColumn
            // 
            this.iNSTRUMENTODataGridViewTextBoxColumn.DataPropertyName = "INSTRUMENTO";
            this.iNSTRUMENTODataGridViewTextBoxColumn.HeaderText = "INSTRUMENTO";
            this.iNSTRUMENTODataGridViewTextBoxColumn.MinimumWidth = 22;
            this.iNSTRUMENTODataGridViewTextBoxColumn.Name = "iNSTRUMENTODataGridViewTextBoxColumn";
            this.iNSTRUMENTODataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // mARCADataGridViewTextBoxColumn
            // 
            this.mARCADataGridViewTextBoxColumn.DataPropertyName = "MARCA";
            this.mARCADataGridViewTextBoxColumn.HeaderText = "MARCA";
            this.mARCADataGridViewTextBoxColumn.MinimumWidth = 22;
            this.mARCADataGridViewTextBoxColumn.Name = "mARCADataGridViewTextBoxColumn";
            this.mARCADataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // mODELODataGridViewTextBoxColumn
            // 
            this.mODELODataGridViewTextBoxColumn.DataPropertyName = "MODELO";
            this.mODELODataGridViewTextBoxColumn.HeaderText = "MODELO";
            this.mODELODataGridViewTextBoxColumn.MinimumWidth = 22;
            this.mODELODataGridViewTextBoxColumn.Name = "mODELODataGridViewTextBoxColumn";
            this.mODELODataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // nSDataGridViewTextBoxColumn
            // 
            this.nSDataGridViewTextBoxColumn.DataPropertyName = "N#S#";
            this.nSDataGridViewTextBoxColumn.HeaderText = "N#S#";
            this.nSDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.nSDataGridViewTextBoxColumn.Name = "nSDataGridViewTextBoxColumn";
            this.nSDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // uBICACIÓNDataGridViewTextBoxColumn
            // 
            this.uBICACIÓNDataGridViewTextBoxColumn.DataPropertyName = "UBICACIÓN";
            this.uBICACIÓNDataGridViewTextBoxColumn.HeaderText = "UBICACIÓN";
            this.uBICACIÓNDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.uBICACIÓNDataGridViewTextBoxColumn.Name = "uBICACIÓNDataGridViewTextBoxColumn";
            this.uBICACIÓNDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // oBSERVACIÓNDataGridViewTextBoxColumn
            // 
            this.oBSERVACIÓNDataGridViewTextBoxColumn.DataPropertyName = "OBSERVACIÓN";
            this.oBSERVACIÓNDataGridViewTextBoxColumn.HeaderText = "OBSERVACIÓN";
            this.oBSERVACIÓNDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.oBSERVACIÓNDataGridViewTextBoxColumn.Name = "oBSERVACIÓNDataGridViewTextBoxColumn";
            this.oBSERVACIÓNDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // eSTATUSDataGridViewTextBoxColumn
            // 
            this.eSTATUSDataGridViewTextBoxColumn.DataPropertyName = "ESTATUS";
            this.eSTATUSDataGridViewTextBoxColumn.HeaderText = "ESTATUS";
            this.eSTATUSDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.eSTATUSDataGridViewTextBoxColumn.Name = "eSTATUSDataGridViewTextBoxColumn";
            this.eSTATUSDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // instrumentosBindingSource1
            // 
            this.instrumentosBindingSource1.DataMember = "Instrumentos";
            this.instrumentosBindingSource1.DataSource = this.trazabilidadTestInstrumentosBindingSource;
            // 
            // trazabilidadTestInstrumentosBindingSource
            // 
            this.trazabilidadTestInstrumentosBindingSource.DataSource = this.trazabilidadTest_Instrumentos;
            this.trazabilidadTestInstrumentosBindingSource.Position = 0;
            // 
            // trazabilidadTest_Instrumentos
            // 
            this.trazabilidadTest_Instrumentos.DataSetName = "TrazabilidadTest_Instrumentos";
            this.trazabilidadTest_Instrumentos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Page_Instruments_Certificates
            // 
            this.Page_Instruments_Certificates.Controls.Add(this.Dgv_Instruments_Certificates);
            this.Page_Instruments_Certificates.Location = new System.Drawing.Point(4, 22);
            this.Page_Instruments_Certificates.Name = "Page_Instruments_Certificates";
            this.Page_Instruments_Certificates.Padding = new System.Windows.Forms.Padding(3);
            this.Page_Instruments_Certificates.Size = new System.Drawing.Size(1120, 332);
            this.Page_Instruments_Certificates.TabIndex = 1;
            this.Page_Instruments_Certificates.Text = "Instrumentos-Certificados";
            this.Page_Instruments_Certificates.UseVisualStyleBackColor = true;
            // 
            // Dgv_Instruments_Certificates
            // 
            this.Dgv_Instruments_Certificates.AllowUserToAddRows = false;
            this.Dgv_Instruments_Certificates.AllowUserToDeleteRows = false;
            this.Dgv_Instruments_Certificates.AllowUserToOrderColumns = true;
            this.Dgv_Instruments_Certificates.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Dgv_Instruments_Certificates.AutoGenerateColumns = false;
            this.Dgv_Instruments_Certificates.AutoGenerateContextFilters = true;
            this.Dgv_Instruments_Certificates.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.Dgv_Instruments_Certificates.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(238)))), ((int)(((byte)(243)))));
            this.Dgv_Instruments_Certificates.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Dgv_Instruments_Certificates.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dgv_Instruments_Certificates.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.Dgv_Instruments_Certificates.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_Instruments_Certificates.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.FECHA_DE_CALIBRACION,
            this.Proxima_Calibracion,
            this.Numero,
            this.Laboratorio,
            this.Fecha_Registro,
            this.ASIGNACION_INSTRUMENTO});
            this.Dgv_Instruments_Certificates.DataSource = this.instrumentosCertificadoBindingSource2;
            this.Dgv_Instruments_Certificates.DateWithTime = false;
            this.Dgv_Instruments_Certificates.Location = new System.Drawing.Point(6, 39);
            this.Dgv_Instruments_Certificates.Name = "Dgv_Instruments_Certificates";
            this.Dgv_Instruments_Certificates.ReadOnly = true;
            this.Dgv_Instruments_Certificates.Size = new System.Drawing.Size(1108, 287);
            this.Dgv_Instruments_Certificates.TabIndex = 9;
            this.Dgv_Instruments_Certificates.TimeFilter = false;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 22;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.dataGridViewTextBoxColumn1.Width = 46;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ID_Instrumentos";
            this.dataGridViewTextBoxColumn2.HeaderText = "ID_Instrumentos";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 22;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.dataGridViewTextBoxColumn2.Width = 135;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "INSTRUMENTO";
            this.dataGridViewTextBoxColumn3.HeaderText = "INSTRUMENTO";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 22;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.dataGridViewTextBoxColumn3.Width = 134;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "MARCA";
            this.dataGridViewTextBoxColumn4.HeaderText = "MARCA";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 22;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.dataGridViewTextBoxColumn4.Width = 81;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "MODELO";
            this.dataGridViewTextBoxColumn5.HeaderText = "MODELO";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 22;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.dataGridViewTextBoxColumn5.Width = 93;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "N#S#";
            this.dataGridViewTextBoxColumn6.HeaderText = "N#S#";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 22;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.dataGridViewTextBoxColumn6.Width = 68;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "UBICACIÓN";
            this.dataGridViewTextBoxColumn7.HeaderText = "UBICACIÓN";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 22;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.dataGridViewTextBoxColumn7.Width = 106;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "OBSERVACIÓN";
            this.dataGridViewTextBoxColumn8.HeaderText = "OBSERVACIÓN";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 22;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.dataGridViewTextBoxColumn8.Width = 132;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "ESTATUS";
            this.dataGridViewTextBoxColumn9.HeaderText = "ESTATUS";
            this.dataGridViewTextBoxColumn9.MinimumWidth = 22;
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.dataGridViewTextBoxColumn9.Width = 97;
            // 
            // FECHA_DE_CALIBRACION
            // 
            this.FECHA_DE_CALIBRACION.DataPropertyName = "Fecha_De_Calibracion";
            this.FECHA_DE_CALIBRACION.HeaderText = "FECHA_DE_CALIBRACION";
            this.FECHA_DE_CALIBRACION.MinimumWidth = 22;
            this.FECHA_DE_CALIBRACION.Name = "FECHA_DE_CALIBRACION";
            this.FECHA_DE_CALIBRACION.ReadOnly = true;
            this.FECHA_DE_CALIBRACION.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.FECHA_DE_CALIBRACION.Width = 203;
            // 
            // Proxima_Calibracion
            // 
            this.Proxima_Calibracion.DataPropertyName = "Proxima_Calibracion";
            this.Proxima_Calibracion.HeaderText = "PROXIMA_CALIBRACION";
            this.Proxima_Calibracion.MinimumWidth = 22;
            this.Proxima_Calibracion.Name = "Proxima_Calibracion";
            this.Proxima_Calibracion.ReadOnly = true;
            this.Proxima_Calibracion.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.Proxima_Calibracion.Width = 193;
            // 
            // Numero
            // 
            this.Numero.DataPropertyName = "Numero";
            this.Numero.HeaderText = "NUMERO";
            this.Numero.MinimumWidth = 22;
            this.Numero.Name = "Numero";
            this.Numero.ReadOnly = true;
            this.Numero.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.Numero.Width = 94;
            // 
            // Laboratorio
            // 
            this.Laboratorio.DataPropertyName = "Laboratorio";
            this.Laboratorio.HeaderText = "LABORATORIO";
            this.Laboratorio.MinimumWidth = 22;
            this.Laboratorio.Name = "Laboratorio";
            this.Laboratorio.ReadOnly = true;
            this.Laboratorio.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.Laboratorio.Width = 133;
            // 
            // Fecha_Registro
            // 
            this.Fecha_Registro.DataPropertyName = "Fecha_Registro";
            this.Fecha_Registro.HeaderText = "FECHA_REGISTRO";
            this.Fecha_Registro.MinimumWidth = 22;
            this.Fecha_Registro.Name = "Fecha_Registro";
            this.Fecha_Registro.ReadOnly = true;
            this.Fecha_Registro.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.Fecha_Registro.Width = 158;
            // 
            // ASIGNACION_INSTRUMENTO
            // 
            this.ASIGNACION_INSTRUMENTO.DataPropertyName = "ESTATUS_ASIGNACION";
            this.ASIGNACION_INSTRUMENTO.HeaderText = "ASIGNACION";
            this.ASIGNACION_INSTRUMENTO.MinimumWidth = 22;
            this.ASIGNACION_INSTRUMENTO.Name = "ASIGNACION_INSTRUMENTO";
            this.ASIGNACION_INSTRUMENTO.ReadOnly = true;
            this.ASIGNACION_INSTRUMENTO.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.ASIGNACION_INSTRUMENTO.Width = 117;
            // 
            // instrumentosCertificadoBindingSource2
            // 
            this.instrumentosCertificadoBindingSource2.DataMember = "Instrumentos_Certificado";
            this.instrumentosCertificadoBindingSource2.DataSource = this.trazabilidadTestDataSet3;
            // 
            // trazabilidadTestDataSet3
            // 
            this.trazabilidadTestDataSet3.DataSetName = "TrazabilidadTestDataSet3";
            this.trazabilidadTestDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // instrumentosCertificadoBindingSource
            // 
            this.instrumentosCertificadoBindingSource.DataMember = "Instrumentos_Certificado";
            this.instrumentosCertificadoBindingSource.DataSource = this.trazabilidadTestDataSet3;
            // 
            // instrumentos_CertificadoTableAdapter
            // 
            this.instrumentos_CertificadoTableAdapter.ClearBeforeFill = true;
            // 
            // instrumentosBindingSource
            // 
            this.instrumentosBindingSource.DataMember = "Instrumentos";
            this.instrumentosBindingSource.DataSource = this.trazabilidadTestInstrumentosBindingSource;
            // 
            // instrumentosTableAdapter
            // 
            this.instrumentosTableAdapter.ClearBeforeFill = true;
            // 
            // instrumentosCertificadoBindingSource1
            // 
            this.instrumentosCertificadoBindingSource1.DataMember = "Instrumentos_Certificado";
            this.instrumentosCertificadoBindingSource1.DataSource = this.trazabilidadTestDataSet3;
            // 
            // Btn_Add
            // 
            this.Btn_Add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(119)))), ((int)(((byte)(182)))));
            this.Btn_Add.FlatAppearance.BorderSize = 0;
            this.Btn_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Add.Location = new System.Drawing.Point(55, 468);
            this.Btn_Add.Name = "Btn_Add";
            this.Btn_Add.Size = new System.Drawing.Size(121, 44);
            this.Btn_Add.TabIndex = 9;
            this.Btn_Add.Text = "Agregar";
            this.Btn_Add.UseVisualStyleBackColor = false;
            this.Btn_Add.Click += new System.EventHandler(this.Btn_Add_Click);
            // 
            // BtnDelete_Instruments
            // 
            this.BtnDelete_Instruments.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(119)))), ((int)(((byte)(182)))));
            this.BtnDelete_Instruments.FlatAppearance.BorderSize = 0;
            this.BtnDelete_Instruments.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDelete_Instruments.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDelete_Instruments.Location = new System.Drawing.Point(202, 468);
            this.BtnDelete_Instruments.Name = "BtnDelete_Instruments";
            this.BtnDelete_Instruments.Size = new System.Drawing.Size(121, 45);
            this.BtnDelete_Instruments.TabIndex = 10;
            this.BtnDelete_Instruments.Text = "Eliminar";
            this.BtnDelete_Instruments.UseVisualStyleBackColor = false;
            this.BtnDelete_Instruments.Click += new System.EventHandler(this.BtnDelete_Instruments_Click);
            // 
            // BtnUpdate_Instrument
            // 
            this.BtnUpdate_Instrument.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(119)))), ((int)(((byte)(182)))));
            this.BtnUpdate_Instrument.FlatAppearance.BorderSize = 0;
            this.BtnUpdate_Instrument.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnUpdate_Instrument.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnUpdate_Instrument.Location = new System.Drawing.Point(343, 468);
            this.BtnUpdate_Instrument.Name = "BtnUpdate_Instrument";
            this.BtnUpdate_Instrument.Size = new System.Drawing.Size(121, 47);
            this.BtnUpdate_Instrument.TabIndex = 11;
            this.BtnUpdate_Instrument.Text = "Actualizar";
            this.BtnUpdate_Instrument.UseVisualStyleBackColor = false;
            this.BtnUpdate_Instrument.Click += new System.EventHandler(this.BtnUpdate_Instrument_Click);
            // 
            // Instruments_SubMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1152, 528);
            this.Controls.Add(this.BtnUpdate_Instrument);
            this.Controls.Add(this.BtnDelete_Instruments);
            this.Controls.Add(this.Btn_Add);
            this.Controls.Add(this.TabControl_Instruments);
            this.Name = "Instruments_SubMenu";
            this.Text = "SubMenu Instrumentos";
            this.Load += new System.EventHandler(this.Instruments_SubMenu_Load);
            this.TabControl_Instruments.ResumeLayout(false);
            this.Page_Instruments.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Instruments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.instrumentosBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trazabilidadTestInstrumentosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trazabilidadTest_Instrumentos)).EndInit();
            this.Page_Instruments_Certificates.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Instruments_Certificates)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.instrumentosCertificadoBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trazabilidadTestDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.instrumentosCertificadoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.instrumentosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.instrumentosCertificadoBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DocumentacionDataSetTableAdapters.ParametrosTableAdapter parametrosTableAdapter1;
        private DocumentacionDataSetTableAdapters.ParametrosTableAdapter parametrosTableAdapter2;
        private System.Windows.Forms.TabControl TabControl_Instruments;
        private System.Windows.Forms.TabPage Page_Instruments;
        private System.Windows.Forms.TabPage Page_Instruments_Certificates;
        private ADGV.AdvancedDataGridView Dgv_Instruments;
        private TrazabilidadTestDataSet3 trazabilidadTestDataSet3;
        private System.Windows.Forms.BindingSource instrumentosCertificadoBindingSource;
        private TrazabilidadTestDataSet3TableAdapters.Instrumentos_CertificadoTableAdapter instrumentos_CertificadoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDInstrumentosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iNSTRUMENTODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mARCADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mODELODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uBICACIÓNDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oBSERVACIÓNDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eSTATUSDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource trazabilidadTestInstrumentosBindingSource;
        private TrazabilidadTest_Instrumentos trazabilidadTest_Instrumentos;
        private System.Windows.Forms.BindingSource instrumentosBindingSource;
        private TrazabilidadTest_InstrumentosTableAdapters.InstrumentosTableAdapter instrumentosTableAdapter;
        private System.Windows.Forms.BindingSource instrumentosBindingSource1;
        private System.Windows.Forms.BindingSource instrumentosCertificadoBindingSource1;
        private System.Windows.Forms.BindingSource instrumentosCertificadoBindingSource2;
        private ADGV.AdvancedDataGridView Dgv_Instruments_Certificates;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn FECHA_DE_CALIBRACION;
        private System.Windows.Forms.DataGridViewTextBoxColumn Proxima_Calibracion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Numero;
        private System.Windows.Forms.DataGridViewTextBoxColumn Laboratorio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha_Registro;
        private System.Windows.Forms.DataGridViewTextBoxColumn ASIGNACION_INSTRUMENTO;
        private System.Windows.Forms.Button Btn_Add;
        private System.Windows.Forms.Button BtnDelete_Instruments;
        private System.Windows.Forms.Button BtnUpdate_Instrument;
    }
}