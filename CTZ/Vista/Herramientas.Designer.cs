namespace CTZ.Vista
{
    partial class Herramientas
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
            this.TabPageHerramientas = new System.Windows.Forms.TabPage();
            this.Dgv_Herramientas = new System.Windows.Forms.DataGridView();
            this.ColumnaID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnaInstrumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnaMarca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnaModelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnaNS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnaUbicacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnaObservacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnaEstatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materialTabControl1.SuspendLayout();
            this.TabPageHerramientas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Herramientas)).BeginInit();
            this.SuspendLayout();
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.TabPageHerramientas);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialTabControl1.Location = new System.Drawing.Point(3, 64);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Multiline = true;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(794, 383);
            this.materialTabControl1.TabIndex = 0;
            // 
            // TabPageHerramientas
            // 
            this.TabPageHerramientas.Controls.Add(this.Dgv_Herramientas);
            this.TabPageHerramientas.Location = new System.Drawing.Point(4, 22);
            this.TabPageHerramientas.Name = "TabPageHerramientas";
            this.TabPageHerramientas.Padding = new System.Windows.Forms.Padding(3);
            this.TabPageHerramientas.Size = new System.Drawing.Size(786, 357);
            this.TabPageHerramientas.TabIndex = 0;
            this.TabPageHerramientas.Text = "Herramientas";
            // 
            // Dgv_Herramientas
            // 
            this.Dgv_Herramientas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_Herramientas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnaID,
            this.ColumnaInstrumento,
            this.ColumnaMarca,
            this.ColumnaModelo,
            this.ColumnaNS,
            this.ColumnaUbicacion,
            this.ColumnaObservacion,
            this.ColumnaEstatus});
            this.Dgv_Herramientas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Dgv_Herramientas.Location = new System.Drawing.Point(3, 3);
            this.Dgv_Herramientas.Name = "Dgv_Herramientas";
            this.Dgv_Herramientas.Size = new System.Drawing.Size(780, 351);
            this.Dgv_Herramientas.TabIndex = 0;
            // 
            // ColumnaID
            // 
            this.ColumnaID.HeaderText = "ID";
            this.ColumnaID.Name = "ColumnaID";
            // 
            // ColumnaInstrumento
            // 
            this.ColumnaInstrumento.HeaderText = "INSTRUMENTO";
            this.ColumnaInstrumento.Name = "ColumnaInstrumento";
            // 
            // ColumnaMarca
            // 
            this.ColumnaMarca.HeaderText = "MARCA";
            this.ColumnaMarca.Name = "ColumnaMarca";
            // 
            // ColumnaModelo
            // 
            this.ColumnaModelo.HeaderText = "MODELO";
            this.ColumnaModelo.Name = "ColumnaModelo";
            // 
            // ColumnaNS
            // 
            this.ColumnaNS.HeaderText = "NS";
            this.ColumnaNS.Name = "ColumnaNS";
            // 
            // ColumnaUbicacion
            // 
            this.ColumnaUbicacion.HeaderText = "UBICACION";
            this.ColumnaUbicacion.Name = "ColumnaUbicacion";
            // 
            // ColumnaObservacion
            // 
            this.ColumnaObservacion.HeaderText = "OBSERVACION";
            this.ColumnaObservacion.Name = "ColumnaObservacion";
            // 
            // ColumnaEstatus
            // 
            this.ColumnaEstatus.HeaderText = "ESTATUS";
            this.ColumnaEstatus.Name = "ColumnaEstatus";
            // 
            // Herramientas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.materialTabControl1);
            this.Name = "Herramientas";
            this.Text = "Herramientas";
            this.materialTabControl1.ResumeLayout(false);
            this.TabPageHerramientas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Herramientas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        protected internal System.Windows.Forms.TabPage TabPageHerramientas;
        private System.Windows.Forms.DataGridView Dgv_Herramientas;
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