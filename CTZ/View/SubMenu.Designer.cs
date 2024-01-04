namespace CTZ.Vista
{
    partial class SubMenu
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
            this.Btn_Instrumentos = new MaterialSkin.Controls.MaterialButton();
            this.Btn_Estandares = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // Btn_Instrumentos
            // 
            this.Btn_Instrumentos.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Btn_Instrumentos.BackColor = System.Drawing.SystemColors.Highlight;
            this.Btn_Instrumentos.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.Btn_Instrumentos.Depth = 0;
            this.Btn_Instrumentos.HighEmphasis = true;
            this.Btn_Instrumentos.Icon = null;
            this.Btn_Instrumentos.Location = new System.Drawing.Point(172, 109);
            this.Btn_Instrumentos.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Btn_Instrumentos.MouseState = MaterialSkin.MouseState.HOVER;
            this.Btn_Instrumentos.Name = "Btn_Instrumentos";
            this.Btn_Instrumentos.Size = new System.Drawing.Size(132, 36);
            this.Btn_Instrumentos.TabIndex = 5;
            this.Btn_Instrumentos.Text = "Instrumentos";
            this.Btn_Instrumentos.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.Btn_Instrumentos.UseAccentColor = false;
            this.Btn_Instrumentos.UseVisualStyleBackColor = false;
            this.Btn_Instrumentos.Click += new System.EventHandler(this.Btn_Instrumentos_Click);
            // 
            // Btn_Estandares
            // 
            this.Btn_Estandares.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Btn_Estandares.BackColor = System.Drawing.SystemColors.Highlight;
            this.Btn_Estandares.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.Btn_Estandares.Depth = 0;
            this.Btn_Estandares.HighEmphasis = true;
            this.Btn_Estandares.Icon = null;
            this.Btn_Estandares.Location = new System.Drawing.Point(172, 175);
            this.Btn_Estandares.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Btn_Estandares.MouseState = MaterialSkin.MouseState.HOVER;
            this.Btn_Estandares.Name = "Btn_Estandares";
            this.Btn_Estandares.Size = new System.Drawing.Size(114, 36);
            this.Btn_Estandares.TabIndex = 6;
            this.Btn_Estandares.Text = "Estandares";
            this.Btn_Estandares.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.Btn_Estandares.UseAccentColor = false;
            this.Btn_Estandares.UseVisualStyleBackColor = false;
            this.Btn_Estandares.Click += new System.EventHandler(this.Btn_Estandares_Click);
            // 
            // SubMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(482, 294);
            this.Controls.Add(this.Btn_Estandares);
            this.Controls.Add(this.Btn_Instrumentos);
            this.ForeColor = System.Drawing.SystemColors.Highlight;
            this.MinimizeBox = false;
            this.Name = "SubMenu";
            this.Text = "SubMenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialButton Btn_Instrumentos;
        private MaterialSkin.Controls.MaterialButton Btn_Estandares;
    }
}