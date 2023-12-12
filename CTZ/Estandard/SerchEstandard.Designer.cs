namespace CTZ.View.Estandard
{
    partial class SerchEstandard
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
            this.TxtBox_EstEstandard = new MaterialSkin.Controls.MaterialTextBox();
            this.Btn_Serch = new MaterialSkin.Controls.MaterialButton();
            this.Lbl_EstEstandard = new MaterialSkin.Controls.MaterialLabel();
            this.SuspendLayout();
            // 
            // TxtBox_EstEstandard
            // 
            this.TxtBox_EstEstandard.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtBox_EstEstandard.Depth = 0;
            this.TxtBox_EstEstandard.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TxtBox_EstEstandard.LeadingIcon = null;
            this.TxtBox_EstEstandard.Location = new System.Drawing.Point(195, 143);
            this.TxtBox_EstEstandard.MaxLength = 50;
            this.TxtBox_EstEstandard.MouseState = MaterialSkin.MouseState.OUT;
            this.TxtBox_EstEstandard.Multiline = false;
            this.TxtBox_EstEstandard.Name = "TxtBox_EstEstandard";
            this.TxtBox_EstEstandard.Size = new System.Drawing.Size(559, 50);
            this.TxtBox_EstEstandard.TabIndex = 0;
            this.TxtBox_EstEstandard.Text = "";
            this.TxtBox_EstEstandard.TrailingIcon = null;
            // 
            // Btn_Serch
            // 
            this.Btn_Serch.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Btn_Serch.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.Btn_Serch.Depth = 0;
            this.Btn_Serch.HighEmphasis = true;
            this.Btn_Serch.Icon = null;
            this.Btn_Serch.Location = new System.Drawing.Point(68, 143);
            this.Btn_Serch.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Btn_Serch.MouseState = MaterialSkin.MouseState.HOVER;
            this.Btn_Serch.Name = "Btn_Serch";
            this.Btn_Serch.Size = new System.Drawing.Size(77, 36);
            this.Btn_Serch.TabIndex = 1;
            this.Btn_Serch.Text = "Buscar";
            this.Btn_Serch.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.Btn_Serch.UseAccentColor = false;
            this.Btn_Serch.UseVisualStyleBackColor = true;
            this.Btn_Serch.Click += new System.EventHandler(this.Btn_Serch_Click);
            // 
            // Lbl_EstEstandard
            // 
            this.Lbl_EstEstandard.AutoSize = true;
            this.Lbl_EstEstandard.Depth = 0;
            this.Lbl_EstEstandard.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Lbl_EstEstandard.Location = new System.Drawing.Point(204, 106);
            this.Lbl_EstEstandard.MouseState = MaterialSkin.MouseState.HOVER;
            this.Lbl_EstEstandard.Name = "Lbl_EstEstandard";
            this.Lbl_EstEstandard.Size = new System.Drawing.Size(94, 19);
            this.Lbl_EstEstandard.TabIndex = 2;
            this.Lbl_EstEstandard.Text = "Escribe el Est";
            // 
            // SerchEstandard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 349);
            this.Controls.Add(this.Lbl_EstEstandard);
            this.Controls.Add(this.Btn_Serch);
            this.Controls.Add(this.TxtBox_EstEstandard);
            this.Name = "SerchEstandard";
            this.Text = "Buscar Estandard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialTextBox TxtBox_EstEstandard;
        private MaterialSkin.Controls.MaterialButton Btn_Serch;
        private MaterialSkin.Controls.MaterialLabel Lbl_EstEstandard;
    }
}