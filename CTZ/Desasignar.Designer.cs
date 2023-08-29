namespace CTZ
{
    partial class Desasignar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Desasignar));
            this.ingesDataSet = new CTZ.IngesDataSet();
            this.ingesDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.getIngesUnas = new CTZ.GetIngesUnas();
            this.getIngesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.getIngesTableAdapter = new CTZ.GetIngesUnasTableAdapters.GetIngesTableAdapter();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.clear = new MaterialSkin.Controls.MaterialButton();
            this.dgv_asignados = new System.Windows.Forms.DataGridView();
            this.getAssignedBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.documentacionDataSet1 = new CTZ.DocumentacionDataSet1();
            this.un = new MaterialSkin.Controls.MaterialButton();
            this.inge = new MaterialSkin.Controls.MaterialComboBox();
            this.assigned = new MaterialSkin.Controls.MaterialComboBox();
            this.asignacionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.asignacionDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.asignacionDataSet = new CTZ.AsignacionDataSet();
            this.getAssignedTableAdapter = new CTZ.DocumentacionDataSet1TableAdapters.GetAssignedTableAdapter();
            this.asignacionTableAdapter = new CTZ.AsignacionDataSetTableAdapters.AsignacionTableAdapter();
            this.idequipoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.identificacionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fSRDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.locacionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaInicialDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaFinalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noSerieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modeloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.permanenteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ingesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ingesDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getIngesUnas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getIngesBindingSource)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_asignados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getAssignedBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentacionDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.asignacionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.asignacionDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.asignacionDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // ingesDataSet
            // 
            this.ingesDataSet.DataSetName = "IngesDataSet";
            this.ingesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ingesDataSetBindingSource
            // 
            this.ingesDataSetBindingSource.DataSource = this.ingesDataSet;
            this.ingesDataSetBindingSource.Position = 0;
            // 
            // getIngesUnas
            // 
            this.getIngesUnas.DataSetName = "GetIngesUnas";
            this.getIngesUnas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // getIngesBindingSource
            // 
            this.getIngesBindingSource.DataMember = "GetInges";
            this.getIngesBindingSource.DataSource = this.getIngesUnas;
            // 
            // getIngesTableAdapter
            // 
            this.getIngesTableAdapter.ClearBeforeFill = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.57431F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 73.42569F));
            this.tableLayoutPanel1.Controls.Add(this.clear, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.dgv_asignados, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.un, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.inge, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.assigned, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 64);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 55.75758F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 44.24242F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 58F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 208F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 51F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(794, 483);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // clear
            // 
            this.clear.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.clear.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.clear.Depth = 0;
            this.clear.HighEmphasis = true;
            this.clear.Icon = null;
            this.clear.Location = new System.Drawing.Point(4, 437);
            this.clear.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.clear.MouseState = MaterialSkin.MouseState.HOVER;
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(79, 36);
            this.clear.TabIndex = 5;
            this.clear.Text = "Limpiar";
            this.clear.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.clear.UseAccentColor = false;
            this.clear.UseVisualStyleBackColor = true;
            // 
            // dgv_asignados
            // 
            this.dgv_asignados.AllowUserToAddRows = false;
            this.dgv_asignados.AllowUserToDeleteRows = false;
            this.dgv_asignados.AutoGenerateColumns = false;
            this.dgv_asignados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_asignados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idequipoDataGridViewTextBoxColumn,
            this.identificacionDataGridViewTextBoxColumn,
            this.fSRDataGridViewTextBoxColumn,
            this.locacionDataGridViewTextBoxColumn,
            this.fechaInicialDataGridViewTextBoxColumn,
            this.fechaFinalDataGridViewTextBoxColumn,
            this.noSerieDataGridViewTextBoxColumn,
            this.modeloDataGridViewTextBoxColumn,
            this.usoDataGridViewTextBoxColumn,
            this.permanenteDataGridViewTextBoxColumn,
            this.idADataGridViewTextBoxColumn});
            this.dgv_asignados.DataSource = this.getAssignedBindingSource;
            this.dgv_asignados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_asignados.Location = new System.Drawing.Point(214, 3);
            this.dgv_asignados.Name = "dgv_asignados";
            this.dgv_asignados.ReadOnly = true;
            this.tableLayoutPanel1.SetRowSpan(this.dgv_asignados, 5);
            this.dgv_asignados.Size = new System.Drawing.Size(577, 477);
            this.dgv_asignados.TabIndex = 6;
            this.dgv_asignados.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_asignados_CellMouseClick);
            this.dgv_asignados.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgv_asignados_RowPostPaint);
            // 
            // getAssignedBindingSource
            // 
            this.getAssignedBindingSource.DataMember = "GetAssigned";
            this.getAssignedBindingSource.DataSource = this.documentacionDataSet1;
            // 
            // documentacionDataSet1
            // 
            this.documentacionDataSet1.DataSetName = "DocumentacionDataSet1";
            this.documentacionDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // un
            // 
            this.un.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.un.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.un.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.un.Depth = 0;
            this.un.HighEmphasis = true;
            this.un.Icon = null;
            this.un.Location = new System.Drawing.Point(4, 181);
            this.un.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.un.MouseState = MaterialSkin.MouseState.HOVER;
            this.un.Name = "un";
            this.un.Size = new System.Drawing.Size(111, 36);
            this.un.TabIndex = 2;
            this.un.Text = "Desasignar";
            this.un.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.un.UseAccentColor = false;
            this.un.UseVisualStyleBackColor = true;
            this.un.Click += new System.EventHandler(this.un_Click);
            // 
            // inge
            // 
            this.inge.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.inge.AutoResize = false;
            this.inge.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.inge.DataSource = this.getIngesBindingSource;
            this.inge.Depth = 0;
            this.inge.DisplayMember = "Nombre";
            this.inge.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.inge.DropDownHeight = 174;
            this.inge.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.inge.DropDownWidth = 121;
            this.inge.Enabled = false;
            this.inge.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.inge.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.inge.FormattingEnabled = true;
            this.inge.Hint = "Ingeniero";
            this.inge.IntegralHeight = false;
            this.inge.ItemHeight = 43;
            this.inge.Location = new System.Drawing.Point(3, 113);
            this.inge.MaxDropDownItems = 4;
            this.inge.MouseState = MaterialSkin.MouseState.OUT;
            this.inge.Name = "inge";
            this.inge.Size = new System.Drawing.Size(205, 49);
            this.inge.StartIndex = 0;
            this.inge.TabIndex = 1;
            this.inge.ValueMember = "IdUsuario";
            this.inge.SelectedIndexChanged += new System.EventHandler(this.inge_SelectedIndexChanged);
            // 
            // assigned
            // 
            this.assigned.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.assigned.AutoResize = false;
            this.assigned.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.assigned.DataSource = this.asignacionBindingSource;
            this.assigned.Depth = 0;
            this.assigned.DisplayMember = "Descripcion";
            this.assigned.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.assigned.DropDownHeight = 174;
            this.assigned.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.assigned.DropDownWidth = 121;
            this.assigned.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.assigned.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.assigned.FormattingEnabled = true;
            this.assigned.Hint = "Asignación";
            this.assigned.IntegralHeight = false;
            this.assigned.ItemHeight = 43;
            this.assigned.Location = new System.Drawing.Point(3, 40);
            this.assigned.MaxDropDownItems = 4;
            this.assigned.MouseState = MaterialSkin.MouseState.OUT;
            this.assigned.Name = "assigned";
            this.assigned.Size = new System.Drawing.Size(205, 49);
            this.assigned.StartIndex = 0;
            this.assigned.TabIndex = 7;
            this.assigned.ValueMember = "IdAsignacion";
            this.assigned.SelectedIndexChanged += new System.EventHandler(this.assigned_SelectedIndexChanged);
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
            // getAssignedTableAdapter
            // 
            this.getAssignedTableAdapter.ClearBeforeFill = true;
            // 
            // asignacionTableAdapter
            // 
            this.asignacionTableAdapter.ClearBeforeFill = true;
            // 
            // idequipoDataGridViewTextBoxColumn
            // 
            this.idequipoDataGridViewTextBoxColumn.DataPropertyName = "idequipo";
            this.idequipoDataGridViewTextBoxColumn.HeaderText = "idequipo";
            this.idequipoDataGridViewTextBoxColumn.Name = "idequipoDataGridViewTextBoxColumn";
            this.idequipoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // identificacionDataGridViewTextBoxColumn
            // 
            this.identificacionDataGridViewTextBoxColumn.DataPropertyName = "identificacion";
            this.identificacionDataGridViewTextBoxColumn.HeaderText = "identificacion";
            this.identificacionDataGridViewTextBoxColumn.Name = "identificacionDataGridViewTextBoxColumn";
            this.identificacionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fSRDataGridViewTextBoxColumn
            // 
            this.fSRDataGridViewTextBoxColumn.DataPropertyName = "FSR";
            this.fSRDataGridViewTextBoxColumn.HeaderText = "FSR";
            this.fSRDataGridViewTextBoxColumn.Name = "fSRDataGridViewTextBoxColumn";
            this.fSRDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // locacionDataGridViewTextBoxColumn
            // 
            this.locacionDataGridViewTextBoxColumn.DataPropertyName = "Locacion";
            this.locacionDataGridViewTextBoxColumn.HeaderText = "Locacion";
            this.locacionDataGridViewTextBoxColumn.Name = "locacionDataGridViewTextBoxColumn";
            this.locacionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fechaInicialDataGridViewTextBoxColumn
            // 
            this.fechaInicialDataGridViewTextBoxColumn.DataPropertyName = "Fecha inicial";
            this.fechaInicialDataGridViewTextBoxColumn.HeaderText = "Fecha inicial";
            this.fechaInicialDataGridViewTextBoxColumn.Name = "fechaInicialDataGridViewTextBoxColumn";
            this.fechaInicialDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fechaFinalDataGridViewTextBoxColumn
            // 
            this.fechaFinalDataGridViewTextBoxColumn.DataPropertyName = "Fecha Final";
            this.fechaFinalDataGridViewTextBoxColumn.HeaderText = "Fecha Final";
            this.fechaFinalDataGridViewTextBoxColumn.Name = "fechaFinalDataGridViewTextBoxColumn";
            this.fechaFinalDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // noSerieDataGridViewTextBoxColumn
            // 
            this.noSerieDataGridViewTextBoxColumn.DataPropertyName = "NoSerie";
            this.noSerieDataGridViewTextBoxColumn.HeaderText = "NoSerie";
            this.noSerieDataGridViewTextBoxColumn.Name = "noSerieDataGridViewTextBoxColumn";
            this.noSerieDataGridViewTextBoxColumn.ReadOnly = true;
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
            // permanenteDataGridViewTextBoxColumn
            // 
            this.permanenteDataGridViewTextBoxColumn.DataPropertyName = "permanente";
            this.permanenteDataGridViewTextBoxColumn.HeaderText = "permanente";
            this.permanenteDataGridViewTextBoxColumn.Name = "permanenteDataGridViewTextBoxColumn";
            this.permanenteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idADataGridViewTextBoxColumn
            // 
            this.idADataGridViewTextBoxColumn.DataPropertyName = "IdA";
            this.idADataGridViewTextBoxColumn.HeaderText = "IdA";
            this.idADataGridViewTextBoxColumn.Name = "idADataGridViewTextBoxColumn";
            this.idADataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Desasignar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 550);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Desasignar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Desasignar";
            this.Load += new System.EventHandler(this.Desasignar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ingesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ingesDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getIngesUnas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getIngesBindingSource)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_asignados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getAssignedBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentacionDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.asignacionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.asignacionDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.asignacionDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private IngesDataSet ingesDataSet;
        private System.Windows.Forms.BindingSource ingesDataSetBindingSource;
        private GetIngesUnas getIngesUnas;
        private System.Windows.Forms.BindingSource getIngesBindingSource;
        private GetIngesUnasTableAdapters.GetIngesTableAdapter getIngesTableAdapter;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private MaterialSkin.Controls.MaterialComboBox inge;
        private MaterialSkin.Controls.MaterialButton un;
        private MaterialSkin.Controls.MaterialButton clear;
        private System.Windows.Forms.DataGridView dgv_asignados;
        private System.Windows.Forms.BindingSource getAssignedBindingSource;
        private DocumentacionDataSet1 documentacionDataSet1;
        private DocumentacionDataSet1TableAdapters.GetAssignedTableAdapter getAssignedTableAdapter;
        private MaterialSkin.Controls.MaterialComboBox assigned;
        private System.Windows.Forms.BindingSource asignacionDataSetBindingSource;
        private AsignacionDataSet asignacionDataSet;
        private System.Windows.Forms.BindingSource asignacionBindingSource;
        private AsignacionDataSetTableAdapters.AsignacionTableAdapter asignacionTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idequipoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn identificacionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fSRDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn locacionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaInicialDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaFinalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noSerieDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modeloDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn permanenteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idADataGridViewTextBoxColumn;
    }
}