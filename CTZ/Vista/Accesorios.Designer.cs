namespace CTZ.Vista.Responsabilitis
{
    partial class Accesorios
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
            this.MaterialControlAccesorios = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.Dgv_Accesorios = new System.Windows.Forms.DataGridView();
            this.asignacionDataSet1 = new CTZ.AsignacionDataSet();
            this.MaterialControlAccesorios.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Accesorios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.asignacionDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // MaterialControlAccesorios
            // 
            this.MaterialControlAccesorios.Controls.Add(this.tabPage2);
            this.MaterialControlAccesorios.Depth = 0;
            this.MaterialControlAccesorios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MaterialControlAccesorios.Location = new System.Drawing.Point(3, 64);
            this.MaterialControlAccesorios.MouseState = MaterialSkin.MouseState.HOVER;
            this.MaterialControlAccesorios.Multiline = true;
            this.MaterialControlAccesorios.Name = "MaterialControlAccesorios";
            this.MaterialControlAccesorios.SelectedIndex = 0;
            this.MaterialControlAccesorios.Size = new System.Drawing.Size(765, 383);
            this.MaterialControlAccesorios.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.Dgv_Accesorios);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(757, 357);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Accesorios";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Dgv_Accesorios
            // 
            this.Dgv_Accesorios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_Accesorios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Dgv_Accesorios.Location = new System.Drawing.Point(3, 3);
            this.Dgv_Accesorios.Name = "Dgv_Accesorios";
            this.Dgv_Accesorios.Size = new System.Drawing.Size(751, 351);
            this.Dgv_Accesorios.TabIndex = 0;
            // 
            // asignacionDataSet1
            // 
            this.asignacionDataSet1.DataSetName = "AsignacionDataSet";
            this.asignacionDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Accesorios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 450);
            this.Controls.Add(this.MaterialControlAccesorios);
            this.Name = "Accesorios";
            this.Text = "Accesorios";
            this.MaterialControlAccesorios.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Accesorios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.asignacionDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl MaterialControlAccesorios;
        private System.Windows.Forms.TabPage tabPage2;
        private AsignacionDataSet asignacionDataSet1;
        private System.Windows.Forms.DataGridView Dgv_Accesorios;
    }
}