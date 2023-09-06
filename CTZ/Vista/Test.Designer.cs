namespace CTZ.Vista
{
    partial class Test
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
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.Page_Instrumentos = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.Dgv_Instrumentos = new System.Windows.Forms.DataGridView();
            this.NombreProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grl2 = new CTZ.grl2();
            this.grl2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.materialTabControl1.SuspendLayout();
            this.Page_Instrumentos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Instrumentos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grl2BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.Page_Instrumentos);
            this.materialTabControl1.Controls.Add(this.tabPage2);
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
            // Page_Instrumentos
            // 
            this.Page_Instrumentos.Controls.Add(this.Dgv_Instrumentos);
            this.Page_Instrumentos.Location = new System.Drawing.Point(4, 22);
            this.Page_Instrumentos.Name = "Page_Instrumentos";
            this.Page_Instrumentos.Padding = new System.Windows.Forms.Padding(3);
            this.Page_Instrumentos.Size = new System.Drawing.Size(786, 357);
            this.Page_Instrumentos.TabIndex = 0;
            this.Page_Instrumentos.Text = "tabPage1";
            this.Page_Instrumentos.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(786, 357);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Dgv_Instrumentos
            // 
            this.Dgv_Instrumentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_Instrumentos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NombreProducto,
            this.Precio});
            this.Dgv_Instrumentos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Dgv_Instrumentos.Location = new System.Drawing.Point(3, 3);
            this.Dgv_Instrumentos.Name = "Dgv_Instrumentos";
            this.Dgv_Instrumentos.Size = new System.Drawing.Size(780, 351);
            this.Dgv_Instrumentos.TabIndex = 0;
            // 
            // NombreProducto
            // 
            this.NombreProducto.HeaderText = "Nombre";
            this.NombreProducto.Name = "NombreProducto";
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            // 
            // grl2
            // 
            this.grl2.DataSetName = "grl2";
            this.grl2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // grl2BindingSource
            // 
            this.grl2BindingSource.DataSource = this.grl2;
            this.grl2BindingSource.Position = 0;
            // 
            // Test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.materialTabControl1);
            this.Name = "Test";
            this.Text = "Test";
            this.materialTabControl1.ResumeLayout(false);
            this.Page_Instrumentos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Instrumentos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grl2BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage Page_Instrumentos;
        private System.Windows.Forms.DataGridView Dgv_Instrumentos;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private grl2 grl2;
        private System.Windows.Forms.BindingSource grl2BindingSource;
    }
}