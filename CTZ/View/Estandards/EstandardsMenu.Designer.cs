namespace CTZ.View.Estandards
{
    partial class EstandardsMenu
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
            this.Btn_Estandars = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // Btn_Estandars
            // 
            this.Btn_Estandars.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Btn_Estandars.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.Btn_Estandars.Depth = 0;
            this.Btn_Estandars.HighEmphasis = true;
            this.Btn_Estandars.Icon = null;
            this.Btn_Estandars.Location = new System.Drawing.Point(277, 93);
            this.Btn_Estandars.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Btn_Estandars.MouseState = MaterialSkin.MouseState.HOVER;
            this.Btn_Estandars.Name = "Btn_Estandars";
            this.Btn_Estandars.Size = new System.Drawing.Size(158, 36);
            this.Btn_Estandars.TabIndex = 0;
            this.Btn_Estandars.Text = "Estandares";
            this.Btn_Estandars.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.Btn_Estandars.UseAccentColor = false;
            this.Btn_Estandars.UseVisualStyleBackColor = true;
            this.Btn_Estandars.Click += new System.EventHandler(this.Btn_Estandars_Click);
            // 
            // EstandardsMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Btn_Estandars);
            this.Name = "EstandardsMenu";
            this.Text = "Menu Estandares";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialButton Btn_Estandars;
    }
}