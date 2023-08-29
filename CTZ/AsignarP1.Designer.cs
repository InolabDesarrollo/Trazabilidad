namespace CTZ
{
    partial class AsignarP1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AsignarP1));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idEquipoDataGridViewTextBoxColumn1 = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.identificacionDataGridViewTextBoxColumn1 = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.noSerieDataGridViewTextBoxColumn1 = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.modeloDataGridViewTextBoxColumn1 = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.locacionDataGridViewTextBoxColumn1 = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.ingenieroAsignadoDataGridViewTextBoxColumn1 = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.Uso = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.certificadoDataGridViewTextBoxColumn1 = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.asignaciónDataGridViewTextBoxColumn1 = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.fechaInicialDataGridViewTextBoxColumn = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.fechaFinalDataGridViewTextBoxColumn = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.permanenciaDataGridViewTextBoxColumn = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.asignatedEQBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.asignatedEQ2 = new CTZ.AsignatedEQ2();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.FilterStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.ShowAllLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.asignarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.desasignarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.idEquipoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.identificacionDataGridViewTextBoxColumn = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.noSerieDataGridViewTextBoxColumn = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.modeloDataGridViewTextBoxColumn = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.locacionDataGridViewTextBoxColumn = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.ingenieroAsignadoDataGridViewTextBoxColumn = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.certificadoDataGridViewTextBoxColumn = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.asignaciónDataGridViewTextBoxColumn = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.IdEquipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Identificacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NoSerie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Modelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Locacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.asignatedEQBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.asignatedEQTableAdapter = new CTZ.AsignatedEQ2TableAdapters.AsignatedEQTableAdapter();
            this.imprimirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.asignatedEQBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.asignatedEQ2)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.asignatedEQBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idEquipoDataGridViewTextBoxColumn1,
            this.identificacionDataGridViewTextBoxColumn1,
            this.noSerieDataGridViewTextBoxColumn1,
            this.modeloDataGridViewTextBoxColumn1,
            this.locacionDataGridViewTextBoxColumn1,
            this.ingenieroAsignadoDataGridViewTextBoxColumn1,
            this.Uso,
            this.certificadoDataGridViewTextBoxColumn1,
            this.asignaciónDataGridViewTextBoxColumn1,
            this.fechaInicialDataGridViewTextBoxColumn,
            this.fechaFinalDataGridViewTextBoxColumn,
            this.permanenciaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.asignatedEQBindingSource1;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 88);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(794, 337);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseDoubleClick);
            this.dataGridView1.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridView1_DataBindingComplete);
            this.dataGridView1.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dataGridView1_RowPostPaint);
            this.dataGridView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridView1_KeyDown);
            // 
            // idEquipoDataGridViewTextBoxColumn1
            // 
            this.idEquipoDataGridViewTextBoxColumn1.DataPropertyName = "IdEquipo";
            this.idEquipoDataGridViewTextBoxColumn1.HeaderText = "IdEquipo";
            this.idEquipoDataGridViewTextBoxColumn1.Name = "idEquipoDataGridViewTextBoxColumn1";
            this.idEquipoDataGridViewTextBoxColumn1.ReadOnly = true;
            this.idEquipoDataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // identificacionDataGridViewTextBoxColumn1
            // 
            this.identificacionDataGridViewTextBoxColumn1.DataPropertyName = "Identificacion";
            this.identificacionDataGridViewTextBoxColumn1.HeaderText = "Identificacion";
            this.identificacionDataGridViewTextBoxColumn1.Name = "identificacionDataGridViewTextBoxColumn1";
            this.identificacionDataGridViewTextBoxColumn1.ReadOnly = true;
            this.identificacionDataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // noSerieDataGridViewTextBoxColumn1
            // 
            this.noSerieDataGridViewTextBoxColumn1.DataPropertyName = "NoSerie";
            this.noSerieDataGridViewTextBoxColumn1.HeaderText = "NoSerie";
            this.noSerieDataGridViewTextBoxColumn1.Name = "noSerieDataGridViewTextBoxColumn1";
            this.noSerieDataGridViewTextBoxColumn1.ReadOnly = true;
            this.noSerieDataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // modeloDataGridViewTextBoxColumn1
            // 
            this.modeloDataGridViewTextBoxColumn1.DataPropertyName = "Modelo";
            this.modeloDataGridViewTextBoxColumn1.HeaderText = "Modelo";
            this.modeloDataGridViewTextBoxColumn1.Name = "modeloDataGridViewTextBoxColumn1";
            this.modeloDataGridViewTextBoxColumn1.ReadOnly = true;
            this.modeloDataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // locacionDataGridViewTextBoxColumn1
            // 
            this.locacionDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.locacionDataGridViewTextBoxColumn1.DataPropertyName = "Locacion";
            this.locacionDataGridViewTextBoxColumn1.HeaderText = "Locación";
            this.locacionDataGridViewTextBoxColumn1.Name = "locacionDataGridViewTextBoxColumn1";
            this.locacionDataGridViewTextBoxColumn1.ReadOnly = true;
            this.locacionDataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // ingenieroAsignadoDataGridViewTextBoxColumn1
            // 
            this.ingenieroAsignadoDataGridViewTextBoxColumn1.DataPropertyName = "Ingeniero asignado";
            this.ingenieroAsignadoDataGridViewTextBoxColumn1.HeaderText = "Ingeniero asignado";
            this.ingenieroAsignadoDataGridViewTextBoxColumn1.Name = "ingenieroAsignadoDataGridViewTextBoxColumn1";
            this.ingenieroAsignadoDataGridViewTextBoxColumn1.ReadOnly = true;
            this.ingenieroAsignadoDataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Uso
            // 
            this.Uso.DataPropertyName = "Uso";
            this.Uso.HeaderText = "Uso";
            this.Uso.Name = "Uso";
            this.Uso.ReadOnly = true;
            this.Uso.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // certificadoDataGridViewTextBoxColumn1
            // 
            this.certificadoDataGridViewTextBoxColumn1.DataPropertyName = "certificado";
            this.certificadoDataGridViewTextBoxColumn1.HeaderText = "certificado";
            this.certificadoDataGridViewTextBoxColumn1.Name = "certificadoDataGridViewTextBoxColumn1";
            this.certificadoDataGridViewTextBoxColumn1.ReadOnly = true;
            this.certificadoDataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // asignaciónDataGridViewTextBoxColumn1
            // 
            this.asignaciónDataGridViewTextBoxColumn1.DataPropertyName = "Asignación";
            this.asignaciónDataGridViewTextBoxColumn1.HeaderText = "Asignación";
            this.asignaciónDataGridViewTextBoxColumn1.Name = "asignaciónDataGridViewTextBoxColumn1";
            this.asignaciónDataGridViewTextBoxColumn1.ReadOnly = true;
            this.asignaciónDataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // fechaInicialDataGridViewTextBoxColumn
            // 
            this.fechaInicialDataGridViewTextBoxColumn.DataPropertyName = "Fecha inicial";
            this.fechaInicialDataGridViewTextBoxColumn.HeaderText = "Fecha inicial";
            this.fechaInicialDataGridViewTextBoxColumn.Name = "fechaInicialDataGridViewTextBoxColumn";
            this.fechaInicialDataGridViewTextBoxColumn.ReadOnly = true;
            this.fechaInicialDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // fechaFinalDataGridViewTextBoxColumn
            // 
            this.fechaFinalDataGridViewTextBoxColumn.DataPropertyName = "Fecha Final";
            this.fechaFinalDataGridViewTextBoxColumn.HeaderText = "Fecha Final";
            this.fechaFinalDataGridViewTextBoxColumn.Name = "fechaFinalDataGridViewTextBoxColumn";
            this.fechaFinalDataGridViewTextBoxColumn.ReadOnly = true;
            this.fechaFinalDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // permanenciaDataGridViewTextBoxColumn
            // 
            this.permanenciaDataGridViewTextBoxColumn.DataPropertyName = "Permanencia";
            this.permanenciaDataGridViewTextBoxColumn.HeaderText = "Permanencia";
            this.permanenciaDataGridViewTextBoxColumn.Name = "permanenciaDataGridViewTextBoxColumn";
            this.permanenciaDataGridViewTextBoxColumn.ReadOnly = true;
            this.permanenciaDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // asignatedEQBindingSource1
            // 
            this.asignatedEQBindingSource1.DataMember = "AsignatedEQ";
            this.asignatedEQBindingSource1.DataSource = this.asignatedEQ2;
            // 
            // asignatedEQ2
            // 
            this.asignatedEQ2.DataSetName = "AsignatedEQ2";
            this.asignatedEQ2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.asignarToolStripMenuItem,
            this.desasignarToolStripMenuItem,
            this.imprimirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(3, 64);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(794, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // asignarToolStripMenuItem
            // 
            this.asignarToolStripMenuItem.Name = "asignarToolStripMenuItem";
            this.asignarToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.asignarToolStripMenuItem.Text = "Asignar";
            this.asignarToolStripMenuItem.Click += new System.EventHandler(this.asignarToolStripMenuItem_Click);
            // 
            // desasignarToolStripMenuItem
            // 
            this.desasignarToolStripMenuItem.Name = "desasignarToolStripMenuItem";
            this.desasignarToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.desasignarToolStripMenuItem.Text = "Desasignar";
            this.desasignarToolStripMenuItem.Click += new System.EventHandler(this.desasignarToolStripMenuItem_Click);
            // 
            // idEquipoDataGridViewTextBoxColumn
            // 
            this.idEquipoDataGridViewTextBoxColumn.DataPropertyName = "IdEquipo";
            this.idEquipoDataGridViewTextBoxColumn.HeaderText = "IdEquipo";
            this.idEquipoDataGridViewTextBoxColumn.Name = "idEquipoDataGridViewTextBoxColumn";
            this.idEquipoDataGridViewTextBoxColumn.ReadOnly = true;
            this.idEquipoDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.idEquipoDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.idEquipoDataGridViewTextBoxColumn.Width = 83;
            // 
            // identificacionDataGridViewTextBoxColumn
            // 
            this.identificacionDataGridViewTextBoxColumn.DataPropertyName = "Identificacion";
            this.identificacionDataGridViewTextBoxColumn.HeaderText = "Identificacion";
            this.identificacionDataGridViewTextBoxColumn.Name = "identificacionDataGridViewTextBoxColumn";
            this.identificacionDataGridViewTextBoxColumn.ReadOnly = true;
            this.identificacionDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.identificacionDataGridViewTextBoxColumn.Width = 84;
            // 
            // noSerieDataGridViewTextBoxColumn
            // 
            this.noSerieDataGridViewTextBoxColumn.DataPropertyName = "NoSerie";
            this.noSerieDataGridViewTextBoxColumn.HeaderText = "NoSerie";
            this.noSerieDataGridViewTextBoxColumn.Name = "noSerieDataGridViewTextBoxColumn";
            this.noSerieDataGridViewTextBoxColumn.ReadOnly = true;
            this.noSerieDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.noSerieDataGridViewTextBoxColumn.Width = 83;
            // 
            // modeloDataGridViewTextBoxColumn
            // 
            this.modeloDataGridViewTextBoxColumn.DataPropertyName = "Modelo";
            this.modeloDataGridViewTextBoxColumn.HeaderText = "Modelo";
            this.modeloDataGridViewTextBoxColumn.Name = "modeloDataGridViewTextBoxColumn";
            this.modeloDataGridViewTextBoxColumn.ReadOnly = true;
            this.modeloDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.modeloDataGridViewTextBoxColumn.Width = 84;
            // 
            // locacionDataGridViewTextBoxColumn
            // 
            this.locacionDataGridViewTextBoxColumn.DataPropertyName = "Locacion";
            this.locacionDataGridViewTextBoxColumn.HeaderText = "Locacion";
            this.locacionDataGridViewTextBoxColumn.Name = "locacionDataGridViewTextBoxColumn";
            this.locacionDataGridViewTextBoxColumn.ReadOnly = true;
            this.locacionDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.locacionDataGridViewTextBoxColumn.Width = 83;
            // 
            // ingenieroAsignadoDataGridViewTextBoxColumn
            // 
            this.ingenieroAsignadoDataGridViewTextBoxColumn.DataPropertyName = "Ingeniero asignado";
            this.ingenieroAsignadoDataGridViewTextBoxColumn.HeaderText = "Ingeniero asignado";
            this.ingenieroAsignadoDataGridViewTextBoxColumn.Name = "ingenieroAsignadoDataGridViewTextBoxColumn";
            this.ingenieroAsignadoDataGridViewTextBoxColumn.ReadOnly = true;
            this.ingenieroAsignadoDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ingenieroAsignadoDataGridViewTextBoxColumn.Width = 84;
            // 
            // certificadoDataGridViewTextBoxColumn
            // 
            this.certificadoDataGridViewTextBoxColumn.DataPropertyName = "certificado";
            this.certificadoDataGridViewTextBoxColumn.HeaderText = "certificado";
            this.certificadoDataGridViewTextBoxColumn.Name = "certificadoDataGridViewTextBoxColumn";
            this.certificadoDataGridViewTextBoxColumn.ReadOnly = true;
            this.certificadoDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.certificadoDataGridViewTextBoxColumn.Width = 83;
            // 
            // asignaciónDataGridViewTextBoxColumn
            // 
            this.asignaciónDataGridViewTextBoxColumn.DataPropertyName = "Asignación";
            this.asignaciónDataGridViewTextBoxColumn.HeaderText = "Asignación";
            this.asignaciónDataGridViewTextBoxColumn.Name = "asignaciónDataGridViewTextBoxColumn";
            this.asignaciónDataGridViewTextBoxColumn.ReadOnly = true;
            this.asignaciónDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.asignaciónDataGridViewTextBoxColumn.Width = 84;
            // 
            // IdEquipo
            // 
            this.IdEquipo.DataPropertyName = "IdEquipo";
            this.IdEquipo.HeaderText = "IdEquipo";
            this.IdEquipo.Name = "IdEquipo";
            // 
            // Identificacion
            // 
            this.Identificacion.DataPropertyName = "Identificacion";
            this.Identificacion.HeaderText = "Identificacion";
            this.Identificacion.Name = "Identificacion";
            // 
            // NoSerie
            // 
            this.NoSerie.DataPropertyName = "NoSerie";
            this.NoSerie.HeaderText = "NoSerie";
            this.NoSerie.Name = "NoSerie";
            // 
            // Modelo
            // 
            this.Modelo.DataPropertyName = "Modelo";
            this.Modelo.HeaderText = "Modelo";
            this.Modelo.Name = "Modelo";
            // 
            // Locacion
            // 
            this.Locacion.DataPropertyName = "Locacion";
            this.Locacion.HeaderText = "Locacion";
            this.Locacion.Name = "Locacion";
            // 
            // asignatedEQBindingSource
            // 
            this.asignatedEQBindingSource.DataMember = "AsignatedEQ";
            // 
            // asignatedEQTableAdapter
            // 
            this.asignatedEQTableAdapter.ClearBeforeFill = true;
            // 
            // imprimirToolStripMenuItem
            // 
            this.imprimirToolStripMenuItem.Name = "imprimirToolStripMenuItem";
            this.imprimirToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.imprimirToolStripMenuItem.Text = "Imprimir";
            this.imprimirToolStripMenuItem.Click += new System.EventHandler(this.imprimirToolStripMenuItem_Click);
            // 
            // AsignarP1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "AsignarP1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Resumen de Asignación";
            this.Load += new System.EventHandler(this.AsignarP1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.asignatedEQBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.asignatedEQ2)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.asignatedEQBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel FilterStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel ShowAllLabel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem asignarToolStripMenuItem;
        //private AsignatedDataSet asignatedDataSet;
        private System.Windows.Forms.BindingSource asignatedEQBindingSource;
        //private AsignatedDataSetTableAdapters.AsignatedEQTableAdapter asignatedEQTableAdapter;
        private System.Windows.Forms.DataGridViewButtonColumn idEquipoDataGridViewTextBoxColumn;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn identificacionDataGridViewTextBoxColumn;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn noSerieDataGridViewTextBoxColumn;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn modeloDataGridViewTextBoxColumn;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn locacionDataGridViewTextBoxColumn;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn ingenieroAsignadoDataGridViewTextBoxColumn;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn certificadoDataGridViewTextBoxColumn;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn asignaciónDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdEquipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Identificacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn NoSerie;
        private System.Windows.Forms.DataGridViewTextBoxColumn Modelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Locacion;
        private AsignatedEQ2 asignatedEQ2;
        private System.Windows.Forms.BindingSource asignatedEQBindingSource1;
        private AsignatedEQ2TableAdapters.AsignatedEQTableAdapter asignatedEQTableAdapter;
        private System.Windows.Forms.ToolStripMenuItem desasignarToolStripMenuItem;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn idEquipoDataGridViewTextBoxColumn1;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn identificacionDataGridViewTextBoxColumn1;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn noSerieDataGridViewTextBoxColumn1;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn modeloDataGridViewTextBoxColumn1;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn locacionDataGridViewTextBoxColumn1;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn ingenieroAsignadoDataGridViewTextBoxColumn1;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn Uso;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn certificadoDataGridViewTextBoxColumn1;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn asignaciónDataGridViewTextBoxColumn1;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn fechaInicialDataGridViewTextBoxColumn;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn fechaFinalDataGridViewTextBoxColumn;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn permanenciaDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStripMenuItem imprimirToolStripMenuItem;
    }
}