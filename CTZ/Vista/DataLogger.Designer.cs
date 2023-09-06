namespace CTZ.Vista
{
    partial class DataLogger
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
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.TabPageDataLogger = new System.Windows.Forms.TabPage();
            this.ColumnaEstatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnaObservacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnaUbicacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnaNS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnaModelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnaMarca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnaInstrumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnaID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dgv_DataLogger = new System.Windows.Forms.DataGridView();
            this.materialTabControl1.SuspendLayout();
            this.TabPageDataLogger.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_DataLogger)).BeginInit();
            this.SuspendLayout();
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.TabPageDataLogger);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialTabControl1.Location = new System.Drawing.Point(3, 64);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Multiline = true;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(858, 383);
            this.materialTabControl1.TabIndex = 0;
            // 
            // TabPageDataLogger
            // 
            this.TabPageDataLogger.Controls.Add(this.Dgv_DataLogger);
            this.TabPageDataLogger.Location = new System.Drawing.Point(4, 22);
            this.TabPageDataLogger.Name = "TabPageDataLogger";
            this.TabPageDataLogger.Padding = new System.Windows.Forms.Padding(3);
            this.TabPageDataLogger.Size = new System.Drawing.Size(850, 357);
            this.TabPageDataLogger.TabIndex = 0;
            this.TabPageDataLogger.Text = "DataLogger";
            this.TabPageDataLogger.UseVisualStyleBackColor = true;
            // 
            // ColumnaEstatus
            // 
            this.ColumnaEstatus.HeaderText = "ESTATUS";
            this.ColumnaEstatus.Name = "ColumnaEstatus";
            // 
            // ColumnaObservacion
            // 
            this.ColumnaObservacion.HeaderText = "OBSERVACION";
            this.ColumnaObservacion.Name = "ColumnaObservacion";
            // 
            // ColumnaUbicacion
            // 
            this.ColumnaUbicacion.HeaderText = "UBICACION";
            this.ColumnaUbicacion.Name = "ColumnaUbicacion";
            // 
            // ColumnaNS
            // 
            this.ColumnaNS.HeaderText = "NS";
            this.ColumnaNS.Name = "ColumnaNS";
            // 
            // ColumnaModelo
            // 
            this.ColumnaModelo.HeaderText = "MODELO";
            this.ColumnaModelo.Name = "ColumnaModelo";
            // 
            // ColumnaMarca
            // 
            this.ColumnaMarca.HeaderText = "MARCA";
            this.ColumnaMarca.Name = "ColumnaMarca";
            // 
            // ColumnaInstrumento
            // 
            this.ColumnaInstrumento.HeaderText = "INSTRUMENTO";
            this.ColumnaInstrumento.Name = "ColumnaInstrumento";
            // 
            // ColumnaID
            // 
            this.ColumnaID.HeaderText = "ID";
            this.ColumnaID.Name = "ColumnaID";
            // 
            // Dgv_DataLogger
            // 
            this.Dgv_DataLogger.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_DataLogger.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnaID,
            this.ColumnaInstrumento,
            this.ColumnaMarca,
            this.ColumnaModelo,
            this.ColumnaNS,
            this.ColumnaUbicacion,
            this.ColumnaObservacion,
            this.ColumnaEstatus});
            this.Dgv_DataLogger.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Dgv_DataLogger.Location = new System.Drawing.Point(3, 3);
            this.Dgv_DataLogger.Name = "Dgv_DataLogger";
            this.Dgv_DataLogger.Size = new System.Drawing.Size(844, 351);
            this.Dgv_DataLogger.TabIndex = 1;
            // 
            // DataLogger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 450);
            this.Controls.Add(this.materialTabControl1);
            this.Name = "DataLogger";
            this.Text = "DataLogger";
            this.materialTabControl1.ResumeLayout(false);
            this.TabPageDataLogger.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_DataLogger)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage TabPageDataLogger;
        private System.Windows.Forms.DataGridView Dgv_DataLogger;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaInstrumento;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaMarca;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaModelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaNS;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaUbicacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaObservacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaEstatus;
    }
}