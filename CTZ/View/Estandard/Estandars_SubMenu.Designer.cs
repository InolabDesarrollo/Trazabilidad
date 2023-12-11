﻿namespace CTZ.View.Estandard
{
    partial class Estandars_SubMenu
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
            this.TabControl_Estandards = new System.Windows.Forms.TabControl();
            this.Page_Instruments = new System.Windows.Forms.TabPage();
            this.Btn_CleanSerch = new System.Windows.Forms.Button();
            this.Btn_Brand = new System.Windows.Forms.Button();
            this.Lbl_Brand = new System.Windows.Forms.Label();
            this.TxtBox_Brand = new System.Windows.Forms.TextBox();
            this.Btn_SerchByEstandardName = new System.Windows.Forms.Button();
            this.TxtBox_EstandardName = new System.Windows.Forms.TextBox();
            this.Lbl_Estandard = new System.Windows.Forms.Label();
            this.Btn_SerchEST = new System.Windows.Forms.Button();
            this.TxtBox_EST = new System.Windows.Forms.TextBox();
            this.Lbl_EST = new System.Windows.Forms.Label();
            this.Dgv_Estandards = new ADGV.AdvancedDataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idEstandaresDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estandarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marcaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.presentacionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noLoteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaDeFabricacionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaDeCaducidadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ubicacionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inventarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estandaresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.trazabilidadTestDataSet4 = new CTZ.TrazabilidadTestDataSet4();
            this.Btn_Add = new System.Windows.Forms.Button();
            this.Btn_Delete = new System.Windows.Forms.Button();
            this.Btn_Update = new System.Windows.Forms.Button();
            this.estandaresTableAdapter = new CTZ.TrazabilidadTestDataSet4TableAdapters.EstandaresTableAdapter();
            this.TabControl_Estandards.SuspendLayout();
            this.Page_Instruments.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Estandards)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.estandaresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trazabilidadTestDataSet4)).BeginInit();
            this.SuspendLayout();
            // 
            // TabControl_Estandards
            // 
            this.TabControl_Estandards.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TabControl_Estandards.Controls.Add(this.Page_Instruments);
            this.TabControl_Estandards.Location = new System.Drawing.Point(17, 67);
            this.TabControl_Estandards.Name = "TabControl_Estandards";
            this.TabControl_Estandards.SelectedIndex = 0;
            this.TabControl_Estandards.Size = new System.Drawing.Size(1024, 330);
            this.TabControl_Estandards.TabIndex = 0;
            // 
            // Page_Instruments
            // 
            this.Page_Instruments.Controls.Add(this.Btn_CleanSerch);
            this.Page_Instruments.Controls.Add(this.Btn_Brand);
            this.Page_Instruments.Controls.Add(this.Lbl_Brand);
            this.Page_Instruments.Controls.Add(this.TxtBox_Brand);
            this.Page_Instruments.Controls.Add(this.Btn_SerchByEstandardName);
            this.Page_Instruments.Controls.Add(this.TxtBox_EstandardName);
            this.Page_Instruments.Controls.Add(this.Lbl_Estandard);
            this.Page_Instruments.Controls.Add(this.Btn_SerchEST);
            this.Page_Instruments.Controls.Add(this.TxtBox_EST);
            this.Page_Instruments.Controls.Add(this.Lbl_EST);
            this.Page_Instruments.Controls.Add(this.Dgv_Estandards);
            this.Page_Instruments.Location = new System.Drawing.Point(4, 22);
            this.Page_Instruments.Name = "Page_Instruments";
            this.Page_Instruments.Padding = new System.Windows.Forms.Padding(3);
            this.Page_Instruments.Size = new System.Drawing.Size(1016, 304);
            this.Page_Instruments.TabIndex = 0;
            this.Page_Instruments.Text = "Estandares";
            this.Page_Instruments.UseVisualStyleBackColor = true;
            // 
            // Btn_CleanSerch
            // 
            this.Btn_CleanSerch.Location = new System.Drawing.Point(896, 14);
            this.Btn_CleanSerch.Name = "Btn_CleanSerch";
            this.Btn_CleanSerch.Size = new System.Drawing.Size(114, 23);
            this.Btn_CleanSerch.TabIndex = 23;
            this.Btn_CleanSerch.Text = "Limpiar Busqueda";
            this.Btn_CleanSerch.UseVisualStyleBackColor = true;
            this.Btn_CleanSerch.Click += new System.EventHandler(this.Btn_CleanSerch_Click);
            // 
            // Btn_Brand
            // 
            this.Btn_Brand.Location = new System.Drawing.Point(817, 14);
            this.Btn_Brand.Name = "Btn_Brand";
            this.Btn_Brand.Size = new System.Drawing.Size(63, 23);
            this.Btn_Brand.TabIndex = 22;
            this.Btn_Brand.Text = "Buscar";
            this.Btn_Brand.UseVisualStyleBackColor = true;
            this.Btn_Brand.Click += new System.EventHandler(this.Btn_Brand_Click);
            // 
            // Lbl_Brand
            // 
            this.Lbl_Brand.AutoSize = true;
            this.Lbl_Brand.Location = new System.Drawing.Point(617, 19);
            this.Lbl_Brand.Name = "Lbl_Brand";
            this.Lbl_Brand.Size = new System.Drawing.Size(37, 13);
            this.Lbl_Brand.TabIndex = 21;
            this.Lbl_Brand.Text = "Marca";
            // 
            // TxtBox_Brand
            // 
            this.TxtBox_Brand.Location = new System.Drawing.Point(658, 16);
            this.TxtBox_Brand.Name = "TxtBox_Brand";
            this.TxtBox_Brand.Size = new System.Drawing.Size(151, 20);
            this.TxtBox_Brand.TabIndex = 20;
            // 
            // Btn_SerchByEstandardName
            // 
            this.Btn_SerchByEstandardName.Location = new System.Drawing.Point(537, 14);
            this.Btn_SerchByEstandardName.Name = "Btn_SerchByEstandardName";
            this.Btn_SerchByEstandardName.Size = new System.Drawing.Size(74, 23);
            this.Btn_SerchByEstandardName.TabIndex = 18;
            this.Btn_SerchByEstandardName.Text = "Buscar";
            this.Btn_SerchByEstandardName.UseVisualStyleBackColor = true;
            this.Btn_SerchByEstandardName.Click += new System.EventHandler(this.Btn_SerchByEstandardName_Click);
            // 
            // TxtBox_EstandardName
            // 
            this.TxtBox_EstandardName.Location = new System.Drawing.Point(377, 14);
            this.TxtBox_EstandardName.Name = "TxtBox_EstandardName";
            this.TxtBox_EstandardName.Size = new System.Drawing.Size(154, 20);
            this.TxtBox_EstandardName.TabIndex = 17;
            // 
            // Lbl_Estandard
            // 
            this.Lbl_Estandard.AutoSize = true;
            this.Lbl_Estandard.Location = new System.Drawing.Point(316, 17);
            this.Lbl_Estandard.Name = "Lbl_Estandard";
            this.Lbl_Estandard.Size = new System.Drawing.Size(55, 13);
            this.Lbl_Estandard.TabIndex = 16;
            this.Lbl_Estandard.Text = "Estandard";
            // 
            // Btn_SerchEST
            // 
            this.Btn_SerchEST.Location = new System.Drawing.Point(236, 14);
            this.Btn_SerchEST.Name = "Btn_SerchEST";
            this.Btn_SerchEST.Size = new System.Drawing.Size(74, 23);
            this.Btn_SerchEST.TabIndex = 15;
            this.Btn_SerchEST.Text = "Buscar";
            this.Btn_SerchEST.UseVisualStyleBackColor = true;
            this.Btn_SerchEST.Click += new System.EventHandler(this.Btn_SerchEST_Click);
            // 
            // TxtBox_EST
            // 
            this.TxtBox_EST.Location = new System.Drawing.Point(97, 17);
            this.TxtBox_EST.Name = "TxtBox_EST";
            this.TxtBox_EST.Size = new System.Drawing.Size(133, 20);
            this.TxtBox_EST.TabIndex = 14;
            // 
            // Lbl_EST
            // 
            this.Lbl_EST.AutoSize = true;
            this.Lbl_EST.Location = new System.Drawing.Point(63, 20);
            this.Lbl_EST.Name = "Lbl_EST";
            this.Lbl_EST.Size = new System.Drawing.Size(28, 13);
            this.Lbl_EST.TabIndex = 2;
            this.Lbl_EST.Text = "EST";
            // 
            // Dgv_Estandards
            // 
            this.Dgv_Estandards.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Dgv_Estandards.AutoGenerateColumns = false;
            this.Dgv_Estandards.AutoGenerateContextFilters = true;
            this.Dgv_Estandards.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Dgv_Estandards.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(238)))), ((int)(((byte)(243)))));
            this.Dgv_Estandards.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Dgv_Estandards.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_Estandards.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.idEstandaresDataGridViewTextBoxColumn,
            this.estandarDataGridViewTextBoxColumn,
            this.usoDataGridViewTextBoxColumn,
            this.marcaDataGridViewTextBoxColumn,
            this.presentacionDataGridViewTextBoxColumn,
            this.noLoteDataGridViewTextBoxColumn,
            this.fechaDeFabricacionDataGridViewTextBoxColumn,
            this.fechaDeCaducidadDataGridViewTextBoxColumn,
            this.cantidadDataGridViewTextBoxColumn,
            this.ubicacionDataGridViewTextBoxColumn,
            this.estatusDataGridViewTextBoxColumn,
            this.inventarioDataGridViewTextBoxColumn});
            this.Dgv_Estandards.DataSource = this.estandaresBindingSource;
            this.Dgv_Estandards.DateWithTime = false;
            this.Dgv_Estandards.Location = new System.Drawing.Point(6, 61);
            this.Dgv_Estandards.Name = "Dgv_Estandards";
            this.Dgv_Estandards.Size = new System.Drawing.Size(1004, 237);
            this.Dgv_Estandards.TabIndex = 0;
            this.Dgv_Estandards.TimeFilter = false;
            this.Dgv_Estandards.FilterStringChanged += new System.EventHandler(this.Dgv_Estandards_FilterStringChanged);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // idEstandaresDataGridViewTextBoxColumn
            // 
            this.idEstandaresDataGridViewTextBoxColumn.DataPropertyName = "Id_Estandares";
            this.idEstandaresDataGridViewTextBoxColumn.HeaderText = "Id_Estandares";
            this.idEstandaresDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.idEstandaresDataGridViewTextBoxColumn.Name = "idEstandaresDataGridViewTextBoxColumn";
            this.idEstandaresDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // estandarDataGridViewTextBoxColumn
            // 
            this.estandarDataGridViewTextBoxColumn.DataPropertyName = "Estandar";
            this.estandarDataGridViewTextBoxColumn.HeaderText = "Estandar";
            this.estandarDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.estandarDataGridViewTextBoxColumn.Name = "estandarDataGridViewTextBoxColumn";
            this.estandarDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // usoDataGridViewTextBoxColumn
            // 
            this.usoDataGridViewTextBoxColumn.DataPropertyName = "Uso";
            this.usoDataGridViewTextBoxColumn.HeaderText = "Uso";
            this.usoDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.usoDataGridViewTextBoxColumn.Name = "usoDataGridViewTextBoxColumn";
            this.usoDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // marcaDataGridViewTextBoxColumn
            // 
            this.marcaDataGridViewTextBoxColumn.DataPropertyName = "Marca";
            this.marcaDataGridViewTextBoxColumn.HeaderText = "Marca";
            this.marcaDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.marcaDataGridViewTextBoxColumn.Name = "marcaDataGridViewTextBoxColumn";
            this.marcaDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // presentacionDataGridViewTextBoxColumn
            // 
            this.presentacionDataGridViewTextBoxColumn.DataPropertyName = "Presentacion";
            this.presentacionDataGridViewTextBoxColumn.HeaderText = "Presentacion";
            this.presentacionDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.presentacionDataGridViewTextBoxColumn.Name = "presentacionDataGridViewTextBoxColumn";
            this.presentacionDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // noLoteDataGridViewTextBoxColumn
            // 
            this.noLoteDataGridViewTextBoxColumn.DataPropertyName = "NoLote";
            this.noLoteDataGridViewTextBoxColumn.HeaderText = "NoLote";
            this.noLoteDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.noLoteDataGridViewTextBoxColumn.Name = "noLoteDataGridViewTextBoxColumn";
            this.noLoteDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // fechaDeFabricacionDataGridViewTextBoxColumn
            // 
            this.fechaDeFabricacionDataGridViewTextBoxColumn.DataPropertyName = "FechaDeFabricacion";
            this.fechaDeFabricacionDataGridViewTextBoxColumn.HeaderText = "FechaDeFabricacion";
            this.fechaDeFabricacionDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.fechaDeFabricacionDataGridViewTextBoxColumn.Name = "fechaDeFabricacionDataGridViewTextBoxColumn";
            this.fechaDeFabricacionDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // fechaDeCaducidadDataGridViewTextBoxColumn
            // 
            this.fechaDeCaducidadDataGridViewTextBoxColumn.DataPropertyName = "FechaDeCaducidad";
            this.fechaDeCaducidadDataGridViewTextBoxColumn.HeaderText = "FechaDeCaducidad";
            this.fechaDeCaducidadDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.fechaDeCaducidadDataGridViewTextBoxColumn.Name = "fechaDeCaducidadDataGridViewTextBoxColumn";
            this.fechaDeCaducidadDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // cantidadDataGridViewTextBoxColumn
            // 
            this.cantidadDataGridViewTextBoxColumn.DataPropertyName = "Cantidad";
            this.cantidadDataGridViewTextBoxColumn.HeaderText = "Cantidad";
            this.cantidadDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.cantidadDataGridViewTextBoxColumn.Name = "cantidadDataGridViewTextBoxColumn";
            this.cantidadDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // ubicacionDataGridViewTextBoxColumn
            // 
            this.ubicacionDataGridViewTextBoxColumn.DataPropertyName = "Ubicacion";
            this.ubicacionDataGridViewTextBoxColumn.HeaderText = "Ubicacion";
            this.ubicacionDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.ubicacionDataGridViewTextBoxColumn.Name = "ubicacionDataGridViewTextBoxColumn";
            this.ubicacionDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // estatusDataGridViewTextBoxColumn
            // 
            this.estatusDataGridViewTextBoxColumn.DataPropertyName = "Estatus";
            this.estatusDataGridViewTextBoxColumn.HeaderText = "Estatus";
            this.estatusDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.estatusDataGridViewTextBoxColumn.Name = "estatusDataGridViewTextBoxColumn";
            this.estatusDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // inventarioDataGridViewTextBoxColumn
            // 
            this.inventarioDataGridViewTextBoxColumn.DataPropertyName = "Inventario";
            this.inventarioDataGridViewTextBoxColumn.HeaderText = "Inventario";
            this.inventarioDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.inventarioDataGridViewTextBoxColumn.Name = "inventarioDataGridViewTextBoxColumn";
            this.inventarioDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // estandaresBindingSource
            // 
            this.estandaresBindingSource.DataMember = "Estandares";
            this.estandaresBindingSource.DataSource = this.trazabilidadTestDataSet4;
            // 
            // trazabilidadTestDataSet4
            // 
            this.trazabilidadTestDataSet4.DataSetName = "TrazabilidadTestDataSet4";
            this.trazabilidadTestDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Btn_Add
            // 
            this.Btn_Add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(119)))), ((int)(((byte)(182)))));
            this.Btn_Add.FlatAppearance.BorderSize = 0;
            this.Btn_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Add.Location = new System.Drawing.Point(120, 403);
            this.Btn_Add.Name = "Btn_Add";
            this.Btn_Add.Size = new System.Drawing.Size(121, 44);
            this.Btn_Add.TabIndex = 10;
            this.Btn_Add.Text = "Agregar";
            this.Btn_Add.UseVisualStyleBackColor = false;
            this.Btn_Add.Click += new System.EventHandler(this.Btn_Add_Click);
            // 
            // Btn_Delete
            // 
            this.Btn_Delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(119)))), ((int)(((byte)(182)))));
            this.Btn_Delete.FlatAppearance.BorderSize = 0;
            this.Btn_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Delete.Location = new System.Drawing.Point(264, 403);
            this.Btn_Delete.Name = "Btn_Delete";
            this.Btn_Delete.Size = new System.Drawing.Size(121, 45);
            this.Btn_Delete.TabIndex = 11;
            this.Btn_Delete.Text = "Eliminar";
            this.Btn_Delete.UseVisualStyleBackColor = false;
            this.Btn_Delete.Click += new System.EventHandler(this.Btn_Delete_Click);
            // 
            // Btn_Update
            // 
            this.Btn_Update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(119)))), ((int)(((byte)(182)))));
            this.Btn_Update.FlatAppearance.BorderSize = 0;
            this.Btn_Update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Update.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Update.Location = new System.Drawing.Point(424, 403);
            this.Btn_Update.Name = "Btn_Update";
            this.Btn_Update.Size = new System.Drawing.Size(121, 47);
            this.Btn_Update.TabIndex = 12;
            this.Btn_Update.Text = "Actualizar";
            this.Btn_Update.UseVisualStyleBackColor = false;
            this.Btn_Update.Click += new System.EventHandler(this.Btn_Update_Click);
            // 
            // estandaresTableAdapter
            // 
            this.estandaresTableAdapter.ClearBeforeFill = true;
            // 
            // Estandars_SubMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1047, 467);
            this.Controls.Add(this.Btn_Update);
            this.Controls.Add(this.Btn_Delete);
            this.Controls.Add(this.Btn_Add);
            this.Controls.Add(this.TabControl_Estandards);
            this.Name = "Estandars_SubMenu";
            this.Text = "Estandares";
            this.Load += new System.EventHandler(this.Estandars_SubMenu_Load);
            this.TabControl_Estandards.ResumeLayout(false);
            this.Page_Instruments.ResumeLayout(false);
            this.Page_Instruments.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Estandards)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.estandaresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trazabilidadTestDataSet4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TabControl_Estandards;
        private System.Windows.Forms.TabPage Page_Instruments;
        private System.Windows.Forms.Button Btn_Add;
        private System.Windows.Forms.Button Btn_Delete;
        private System.Windows.Forms.Button Btn_Update;
        private ADGV.AdvancedDataGridView Dgv_Estandards;
        private TrazabilidadTestDataSet4 trazabilidadTestDataSet4;
        private System.Windows.Forms.BindingSource estandaresBindingSource;
        private TrazabilidadTestDataSet4TableAdapters.EstandaresTableAdapter estandaresTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idEstandaresDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estandarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn marcaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn presentacionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noLoteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaDeFabricacionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaDeCaducidadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ubicacionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn inventarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label Lbl_EST;
        private System.Windows.Forms.TextBox TxtBox_EST;
        private System.Windows.Forms.Button Btn_SerchEST;
        private System.Windows.Forms.Label Lbl_Estandard;
        private System.Windows.Forms.TextBox TxtBox_EstandardName;
        private System.Windows.Forms.Button Btn_SerchByEstandardName;
        private System.Windows.Forms.TextBox TxtBox_Brand;
        private System.Windows.Forms.Label Lbl_Brand;
        private System.Windows.Forms.Button Btn_Brand;
        private System.Windows.Forms.Button Btn_CleanSerch;
    }
}