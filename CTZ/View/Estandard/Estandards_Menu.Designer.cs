namespace CTZ.View.Estandard
{
    partial class Estandards_Menu
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
            this.Btn_Estandards = new MaterialSkin.Controls.MaterialButton();
            this.Btn_Assignment = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // Btn_Estandards
            // 
            this.Btn_Estandards.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Btn_Estandards.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.Btn_Estandards.Depth = 0;
            this.Btn_Estandards.HighEmphasis = true;
            this.Btn_Estandards.Icon = null;
            this.Btn_Estandards.Location = new System.Drawing.Point(219, 109);
            this.Btn_Estandards.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Btn_Estandards.MouseState = MaterialSkin.MouseState.HOVER;
            this.Btn_Estandards.Name = "Btn_Estandards";
            this.Btn_Estandards.Size = new System.Drawing.Size(114, 36);
            this.Btn_Estandards.TabIndex = 0;
            this.Btn_Estandards.Text = "Estandares";
            this.Btn_Estandards.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.Btn_Estandards.UseAccentColor = false;
            this.Btn_Estandards.UseVisualStyleBackColor = true;
            this.Btn_Estandards.Click += new System.EventHandler(this.Btn_Estandards_Click);
            // 
            // Btn_Assignment
            // 
            this.Btn_Assignment.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Btn_Assignment.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.Btn_Assignment.Depth = 0;
            this.Btn_Assignment.HighEmphasis = true;
            this.Btn_Assignment.Icon = null;
            this.Btn_Assignment.Location = new System.Drawing.Point(219, 176);
            this.Btn_Assignment.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Btn_Assignment.MouseState = MaterialSkin.MouseState.HOVER;
            this.Btn_Assignment.Name = "Btn_Assignment";
            this.Btn_Assignment.Size = new System.Drawing.Size(126, 36);
            this.Btn_Assignment.TabIndex = 1;
            this.Btn_Assignment.Text = "Asignaciones ";
            this.Btn_Assignment.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.Btn_Assignment.UseAccentColor = false;
            this.Btn_Assignment.UseVisualStyleBackColor = true;
            this.Btn_Assignment.Click += new System.EventHandler(this.Btn_Assignment_Click);
            // 
            // Estandards_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 450);
            this.Controls.Add(this.Btn_Assignment);
            this.Controls.Add(this.Btn_Estandards);
            this.Name = "Estandards_Menu";
            this.Text = "Menu Estandares";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialButton Btn_Estandards;
        private MaterialSkin.Controls.MaterialButton Btn_Assignment;
    }
}