namespace CTZ.Vista.Traceability
{
    partial class SerchTraceabilityLetter
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
            this.Lbl_CertificateNumber = new MaterialSkin.Controls.MaterialLabel();
            this.Txt_Box_Certificates = new MaterialSkin.Controls.MaterialTextBox();
            this.Btn_Serch = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // Lbl_CertificateNumber
            // 
            this.Lbl_CertificateNumber.AutoSize = true;
            this.Lbl_CertificateNumber.Depth = 0;
            this.Lbl_CertificateNumber.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Lbl_CertificateNumber.Location = new System.Drawing.Point(39, 81);
            this.Lbl_CertificateNumber.MouseState = MaterialSkin.MouseState.HOVER;
            this.Lbl_CertificateNumber.Name = "Lbl_CertificateNumber";
            this.Lbl_CertificateNumber.Size = new System.Drawing.Size(159, 19);
            this.Lbl_CertificateNumber.TabIndex = 0;
            this.Lbl_CertificateNumber.Text = "Numero de Certificado";
            // 
            // Txt_Box_Certificates
            // 
            this.Txt_Box_Certificates.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txt_Box_Certificates.Depth = 0;
            this.Txt_Box_Certificates.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Txt_Box_Certificates.LeadingIcon = null;
            this.Txt_Box_Certificates.Location = new System.Drawing.Point(42, 131);
            this.Txt_Box_Certificates.MaxLength = 50;
            this.Txt_Box_Certificates.MouseState = MaterialSkin.MouseState.OUT;
            this.Txt_Box_Certificates.Multiline = false;
            this.Txt_Box_Certificates.Name = "Txt_Box_Certificates";
            this.Txt_Box_Certificates.Size = new System.Drawing.Size(703, 50);
            this.Txt_Box_Certificates.TabIndex = 1;
            this.Txt_Box_Certificates.Text = "";
            this.Txt_Box_Certificates.TrailingIcon = null;
            // 
            // Btn_Serch
            // 
            this.Btn_Serch.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Btn_Serch.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.Btn_Serch.Depth = 0;
            this.Btn_Serch.HighEmphasis = true;
            this.Btn_Serch.Icon = null;
            this.Btn_Serch.Location = new System.Drawing.Point(668, 204);
            this.Btn_Serch.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Btn_Serch.MouseState = MaterialSkin.MouseState.HOVER;
            this.Btn_Serch.Name = "Btn_Serch";
            this.Btn_Serch.Size = new System.Drawing.Size(77, 36);
            this.Btn_Serch.TabIndex = 2;
            this.Btn_Serch.Text = "Buscar";
            this.Btn_Serch.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.Btn_Serch.UseAccentColor = false;
            this.Btn_Serch.UseVisualStyleBackColor = true;
            this.Btn_Serch.Click += new System.EventHandler(this.Btn_Serch_Click);
            // 
            // SerchTraceabilityLetter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 288);
            this.Controls.Add(this.Btn_Serch);
            this.Controls.Add(this.Txt_Box_Certificates);
            this.Controls.Add(this.Lbl_CertificateNumber);
            this.Name = "SerchTraceabilityLetter";
            this.Text = "Buscar Reporte Carta de Trazabilidad";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel Lbl_CertificateNumber;
        private MaterialSkin.Controls.MaterialTextBox Txt_Box_Certificates;
        private MaterialSkin.Controls.MaterialButton Btn_Serch;
    }
}