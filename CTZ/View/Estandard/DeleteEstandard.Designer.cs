namespace CTZ.View.Estandard
{
    partial class DeleteEstandard
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
            this.Lbl_Estandard = new MaterialSkin.Controls.MaterialLabel();
            this.TxtBox_EST = new MaterialSkin.Controls.MaterialTextBox();
            this.Btn_Delete = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // Lbl_Estandard
            // 
            this.Lbl_Estandard.AutoSize = true;
            this.Lbl_Estandard.Depth = 0;
            this.Lbl_Estandard.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Lbl_Estandard.Location = new System.Drawing.Point(64, 109);
            this.Lbl_Estandard.MouseState = MaterialSkin.MouseState.HOVER;
            this.Lbl_Estandard.Name = "Lbl_Estandard";
            this.Lbl_Estandard.Size = new System.Drawing.Size(97, 19);
            this.Lbl_Estandard.TabIndex = 0;
            this.Lbl_Estandard.Text = "Estandar EST";
            // 
            // TxtBox_EST
            // 
            this.TxtBox_EST.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtBox_EST.Depth = 0;
            this.TxtBox_EST.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TxtBox_EST.LeadingIcon = null;
            this.TxtBox_EST.Location = new System.Drawing.Point(61, 158);
            this.TxtBox_EST.MaxLength = 50;
            this.TxtBox_EST.MouseState = MaterialSkin.MouseState.OUT;
            this.TxtBox_EST.Multiline = false;
            this.TxtBox_EST.Name = "TxtBox_EST";
            this.TxtBox_EST.Size = new System.Drawing.Size(437, 50);
            this.TxtBox_EST.TabIndex = 1;
            this.TxtBox_EST.Text = "";
            this.TxtBox_EST.TrailingIcon = null;
            // 
            // Btn_Delete
            // 
            this.Btn_Delete.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Btn_Delete.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.Btn_Delete.Depth = 0;
            this.Btn_Delete.HighEmphasis = true;
            this.Btn_Delete.Icon = null;
            this.Btn_Delete.Location = new System.Drawing.Point(332, 267);
            this.Btn_Delete.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Btn_Delete.MouseState = MaterialSkin.MouseState.HOVER;
            this.Btn_Delete.Name = "Btn_Delete";
            this.Btn_Delete.Size = new System.Drawing.Size(156, 36);
            this.Btn_Delete.TabIndex = 2;
            this.Btn_Delete.Text = "Borrar Estandar";
            this.Btn_Delete.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.Btn_Delete.UseAccentColor = false;
            this.Btn_Delete.UseVisualStyleBackColor = true;
            this.Btn_Delete.Click += new System.EventHandler(this.Btn_Delete_Click);
            // 
            // DeleteEstandard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 385);
            this.Controls.Add(this.Btn_Delete);
            this.Controls.Add(this.TxtBox_EST);
            this.Controls.Add(this.Lbl_Estandard);
            this.Name = "DeleteEstandard";
            this.Text = "Borrar Estandar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel Lbl_Estandard;
        private MaterialSkin.Controls.MaterialTextBox TxtBox_EST;
        private MaterialSkin.Controls.MaterialButton Btn_Delete;
    }
}