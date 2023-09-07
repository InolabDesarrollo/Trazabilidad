namespace CTZ.Vista
{
    partial class Estandares
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
            this.TabPageEstandares = new System.Windows.Forms.TabPage();
            this.Dgv_Estandares = new System.Windows.Forms.DataGridView();
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.TabPageEstandares.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Estandares)).BeginInit();
            this.materialTabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabPageEstandares
            // 
            this.TabPageEstandares.Controls.Add(this.Dgv_Estandares);
            this.TabPageEstandares.Location = new System.Drawing.Point(4, 22);
            this.TabPageEstandares.Name = "TabPageEstandares";
            this.TabPageEstandares.Padding = new System.Windows.Forms.Padding(3);
            this.TabPageEstandares.Size = new System.Drawing.Size(818, 357);
            this.TabPageEstandares.TabIndex = 0;
            this.TabPageEstandares.Text = "Estandares";
            this.TabPageEstandares.UseVisualStyleBackColor = true;
            // 
            // Dgv_Estandares
            // 
            this.Dgv_Estandares.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_Estandares.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Dgv_Estandares.Location = new System.Drawing.Point(3, 3);
            this.Dgv_Estandares.Name = "Dgv_Estandares";
            this.Dgv_Estandares.Size = new System.Drawing.Size(812, 351);
            this.Dgv_Estandares.TabIndex = 0;
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.TabPageEstandares);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialTabControl1.Location = new System.Drawing.Point(3, 64);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Multiline = true;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(826, 383);
            this.materialTabControl1.TabIndex = 0;
            // 
            // Estandares
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 450);
            this.Controls.Add(this.materialTabControl1);
            this.Name = "Estandares";
            this.Text = "Estandares";
            this.TabPageEstandares.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Estandares)).EndInit();
            this.materialTabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabPage TabPageEstandares;
        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.DataGridView Dgv_Estandares;
    }
}