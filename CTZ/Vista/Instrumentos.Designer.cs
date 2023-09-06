namespace CTZ.Vista
{
    partial class Instrumentos
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
            this.TabPageInstrumentos = new System.Windows.Forms.TabPage();
            this.Dgv_Instrumentos = new System.Windows.Forms.DataGridView();
            this.materialTabControl1.SuspendLayout();
            this.TabPageInstrumentos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Instrumentos)).BeginInit();
            this.SuspendLayout();
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.TabPageInstrumentos);
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
            // TabPageInstrumentos
            // 
            this.TabPageInstrumentos.Controls.Add(this.Dgv_Instrumentos);
            this.TabPageInstrumentos.Location = new System.Drawing.Point(4, 22);
            this.TabPageInstrumentos.Name = "TabPageInstrumentos";
            this.TabPageInstrumentos.Padding = new System.Windows.Forms.Padding(3);
            this.TabPageInstrumentos.Size = new System.Drawing.Size(786, 357);
            this.TabPageInstrumentos.TabIndex = 1;
            this.TabPageInstrumentos.Text = "Instrumentos";
            this.TabPageInstrumentos.UseVisualStyleBackColor = true;
            // 
            // Dgv_Instrumentos
            // 
            this.Dgv_Instrumentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_Instrumentos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Dgv_Instrumentos.Location = new System.Drawing.Point(3, 3);
            this.Dgv_Instrumentos.Name = "Dgv_Instrumentos";
            this.Dgv_Instrumentos.Size = new System.Drawing.Size(780, 351);
            this.Dgv_Instrumentos.TabIndex = 0;
            // 
            // Instrumentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.materialTabControl1);
            this.Name = "Instrumentos";
            this.Text = "Instrumentos";
            this.materialTabControl1.ResumeLayout(false);
            this.TabPageInstrumentos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Instrumentos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage TabPageInstrumentos;
        private System.Windows.Forms.DataGridView Dgv_Instrumentos;
    }
}