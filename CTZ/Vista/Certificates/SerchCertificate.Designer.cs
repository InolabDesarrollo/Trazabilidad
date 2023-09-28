namespace CTZ.Vista.Certificates
{
    partial class SerchCertificate
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
            this.Lbl_Certificate = new MaterialSkin.Controls.MaterialLabel();
            this.TxtBox_Certificate = new MaterialSkin.Controls.MaterialTextBox();
            this.Btn_Serch_Certificate = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // Lbl_Certificate
            // 
            this.Lbl_Certificate.AutoSize = true;
            this.Lbl_Certificate.Depth = 0;
            this.Lbl_Certificate.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Lbl_Certificate.Location = new System.Drawing.Point(54, 114);
            this.Lbl_Certificate.MouseState = MaterialSkin.MouseState.HOVER;
            this.Lbl_Certificate.Name = "Lbl_Certificate";
            this.Lbl_Certificate.Size = new System.Drawing.Size(159, 19);
            this.Lbl_Certificate.TabIndex = 1;
            this.Lbl_Certificate.Text = "Numero de Certificado";
            // 
            // TxtBox_Certificate
            // 
            this.TxtBox_Certificate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtBox_Certificate.Depth = 0;
            this.TxtBox_Certificate.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TxtBox_Certificate.LeadingIcon = null;
            this.TxtBox_Certificate.Location = new System.Drawing.Point(57, 164);
            this.TxtBox_Certificate.MaxLength = 50;
            this.TxtBox_Certificate.MouseState = MaterialSkin.MouseState.OUT;
            this.TxtBox_Certificate.Multiline = false;
            this.TxtBox_Certificate.Name = "TxtBox_Certificate";
            this.TxtBox_Certificate.Size = new System.Drawing.Size(435, 50);
            this.TxtBox_Certificate.TabIndex = 2;
            this.TxtBox_Certificate.Text = "";
            this.TxtBox_Certificate.TrailingIcon = null;
            // 
            // Btn_Serch_Certificate
            // 
            this.Btn_Serch_Certificate.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Btn_Serch_Certificate.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.Btn_Serch_Certificate.Depth = 0;
            this.Btn_Serch_Certificate.HighEmphasis = true;
            this.Btn_Serch_Certificate.Icon = null;
            this.Btn_Serch_Certificate.Location = new System.Drawing.Point(319, 239);
            this.Btn_Serch_Certificate.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Btn_Serch_Certificate.MouseState = MaterialSkin.MouseState.HOVER;
            this.Btn_Serch_Certificate.Name = "Btn_Serch_Certificate";
            this.Btn_Serch_Certificate.Size = new System.Drawing.Size(173, 36);
            this.Btn_Serch_Certificate.TabIndex = 57;
            this.Btn_Serch_Certificate.Text = "Buscar Certificado";
            this.Btn_Serch_Certificate.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.Btn_Serch_Certificate.UseAccentColor = false;
            this.Btn_Serch_Certificate.UseVisualStyleBackColor = true;
            this.Btn_Serch_Certificate.Click += new System.EventHandler(this.Btn_Serch_Certificate_Click);
            // 
            // SerchCertificate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 329);
            this.Controls.Add(this.Btn_Serch_Certificate);
            this.Controls.Add(this.TxtBox_Certificate);
            this.Controls.Add(this.Lbl_Certificate);
            this.Name = "SerchCertificate";
            this.Text = "Buscar Certificado";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel Lbl_Certificate;
        private MaterialSkin.Controls.MaterialTextBox TxtBox_Certificate;
        private MaterialSkin.Controls.MaterialButton Btn_Serch_Certificate;
    }
}