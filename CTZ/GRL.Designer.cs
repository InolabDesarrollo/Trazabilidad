namespace CTZ
{
    partial class GRL
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GRL));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.identificacionDataGridViewTextBoxColumn = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.usoDataGridViewTextBoxColumn = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.estatusDataGridViewTextBoxColumn = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.certificadoDataGridViewTextBoxColumn = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.fechaCalibracionDataGridViewTextBoxColumn = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.proximaCalibracionDataGridViewTextBoxColumn = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.descripcionDataGridViewTextBoxColumn = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.marcaDataGridViewTextBoxColumn = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.IdRegistro = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.getEquiposGrlBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.grl2 = new CTZ.grl2();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.FilterStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.ShowAllLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.getEquiposGrlBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.getequiposgrl = new CTZ.getequiposgrl();
            this.getEquiposGrlTableAdapter = new CTZ.getequiposgrlTableAdapters.GetEquiposGrlTableAdapter();
            this.getEquiposGrlTableAdapter1 = new CTZ.grl2TableAdapters.GetEquiposGrlTableAdapter();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.imprimirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getEquiposGrlBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grl2)).BeginInit();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.getEquiposGrlBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getequiposgrl)).BeginInit();
            this.menuStrip1.SuspendLayout();
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
            this.identificacionDataGridViewTextBoxColumn,
            this.usoDataGridViewTextBoxColumn,
            this.estatusDataGridViewTextBoxColumn,
            this.certificadoDataGridViewTextBoxColumn,
            this.fechaCalibracionDataGridViewTextBoxColumn,
            this.proximaCalibracionDataGridViewTextBoxColumn,
            this.descripcionDataGridViewTextBoxColumn,
            this.marcaDataGridViewTextBoxColumn,
            this.IdRegistro});
            this.dataGridView1.DataSource = this.getEquiposGrlBindingSource1;
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
            // identificacionDataGridViewTextBoxColumn
            // 
            this.identificacionDataGridViewTextBoxColumn.DataPropertyName = "Identificacion";
            this.identificacionDataGridViewTextBoxColumn.HeaderText = "Identificacion";
            this.identificacionDataGridViewTextBoxColumn.Name = "identificacionDataGridViewTextBoxColumn";
            this.identificacionDataGridViewTextBoxColumn.ReadOnly = true;
            this.identificacionDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // usoDataGridViewTextBoxColumn
            // 
            this.usoDataGridViewTextBoxColumn.DataPropertyName = "Uso";
            this.usoDataGridViewTextBoxColumn.HeaderText = "Uso";
            this.usoDataGridViewTextBoxColumn.Name = "usoDataGridViewTextBoxColumn";
            this.usoDataGridViewTextBoxColumn.ReadOnly = true;
            this.usoDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // estatusDataGridViewTextBoxColumn
            // 
            this.estatusDataGridViewTextBoxColumn.DataPropertyName = "Estatus";
            this.estatusDataGridViewTextBoxColumn.HeaderText = "Estatus";
            this.estatusDataGridViewTextBoxColumn.Name = "estatusDataGridViewTextBoxColumn";
            this.estatusDataGridViewTextBoxColumn.ReadOnly = true;
            this.estatusDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // certificadoDataGridViewTextBoxColumn
            // 
            this.certificadoDataGridViewTextBoxColumn.DataPropertyName = "Certificado";
            this.certificadoDataGridViewTextBoxColumn.HeaderText = "Certificado";
            this.certificadoDataGridViewTextBoxColumn.Name = "certificadoDataGridViewTextBoxColumn";
            this.certificadoDataGridViewTextBoxColumn.ReadOnly = true;
            this.certificadoDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
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
            // descripcionDataGridViewTextBoxColumn
            // 
            this.descripcionDataGridViewTextBoxColumn.DataPropertyName = "Descripcion";
            this.descripcionDataGridViewTextBoxColumn.HeaderText = "Descripcion";
            this.descripcionDataGridViewTextBoxColumn.Name = "descripcionDataGridViewTextBoxColumn";
            this.descripcionDataGridViewTextBoxColumn.ReadOnly = true;
            this.descripcionDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // marcaDataGridViewTextBoxColumn
            // 
            this.marcaDataGridViewTextBoxColumn.DataPropertyName = "Marca";
            this.marcaDataGridViewTextBoxColumn.HeaderText = "Marca";
            this.marcaDataGridViewTextBoxColumn.Name = "marcaDataGridViewTextBoxColumn";
            this.marcaDataGridViewTextBoxColumn.ReadOnly = true;
            this.marcaDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // IdRegistro
            // 
            this.IdRegistro.DataPropertyName = "IdRegistro";
            this.IdRegistro.HeaderText = "IdRegistro";
            this.IdRegistro.Name = "IdRegistro";
            this.IdRegistro.ReadOnly = true;
            this.IdRegistro.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // getEquiposGrlBindingSource1
            // 
            this.getEquiposGrlBindingSource1.DataMember = "GetEquiposGrl";
            this.getEquiposGrlBindingSource1.DataSource = this.grl2;
            // 
            // grl2
            // 
            this.grl2.DataSetName = "grl2";
            this.grl2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.ShowAllLabel.IsLink = true;
            this.ShowAllLabel.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.ShowAllLabel.Name = "ShowAllLabel";
            this.ShowAllLabel.Size = new System.Drawing.Size(77, 17);
            this.ShowAllLabel.Text = "Mostrar Todo";
            this.ShowAllLabel.Click += new System.EventHandler(this.ShowAllLabel_Click);
            // 
            // getEquiposGrlBindingSource
            // 
            this.getEquiposGrlBindingSource.DataMember = "GetEquiposGrl";
            this.getEquiposGrlBindingSource.DataSource = this.getequiposgrl;
            // 
            // getequiposgrl
            // 
            this.getequiposgrl.DataSetName = "getequiposgrl";
            this.getequiposgrl.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // getEquiposGrlTableAdapter
            // 
            this.getEquiposGrlTableAdapter.ClearBeforeFill = true;
            // 
            // getEquiposGrlTableAdapter1
            // 
            this.getEquiposGrlTableAdapter1.ClearBeforeFill = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.imprimirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(3, 64);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(794, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // imprimirToolStripMenuItem
            // 
            this.imprimirToolStripMenuItem.Name = "imprimirToolStripMenuItem";
            this.imprimirToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.imprimirToolStripMenuItem.Text = "imprimir";
            this.imprimirToolStripMenuItem.Click += new System.EventHandler(this.imprimirToolStripMenuItem_Click);
            // 
            // GRL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "GRL";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inventario INO-FI-030";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GRL_FormClosing);
            this.Load += new System.EventHandler(this.GRL_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getEquiposGrlBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grl2)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.getEquiposGrlBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getequiposgrl)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel FilterStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel ShowAllLabel;
        private getequiposgrl getequiposgrl;
        private System.Windows.Forms.BindingSource getEquiposGrlBindingSource;
        private getequiposgrlTableAdapters.GetEquiposGrlTableAdapter getEquiposGrlTableAdapter;
        private grl2 grl2;
        private System.Windows.Forms.BindingSource getEquiposGrlBindingSource1;
        private grl2TableAdapters.GetEquiposGrlTableAdapter getEquiposGrlTableAdapter1;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn identificacionDataGridViewTextBoxColumn;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn usoDataGridViewTextBoxColumn;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn estatusDataGridViewTextBoxColumn;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn certificadoDataGridViewTextBoxColumn;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn fechaCalibracionDataGridViewTextBoxColumn;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn proximaCalibracionDataGridViewTextBoxColumn;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn descripcionDataGridViewTextBoxColumn;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn marcaDataGridViewTextBoxColumn;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn IdRegistro;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem imprimirToolStripMenuItem;
    }
}