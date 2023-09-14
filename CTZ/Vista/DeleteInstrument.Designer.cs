namespace CTZ.Vista
{
    partial class DeleteInstrument
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
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.TxtBox_Id = new MaterialSkin.Controls.MaterialTextBox();
            this.BtnDelete_Instrument = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(20, 94);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(194, 19);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "Introduce Id de Instrumento";
            // 
            // TxtBox_Id
            // 
            this.TxtBox_Id.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtBox_Id.Depth = 0;
            this.TxtBox_Id.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TxtBox_Id.Hint = "ID";
            this.TxtBox_Id.LeadingIcon = null;
            this.TxtBox_Id.Location = new System.Drawing.Point(23, 144);
            this.TxtBox_Id.MaxLength = 50;
            this.TxtBox_Id.MouseState = MaterialSkin.MouseState.OUT;
            this.TxtBox_Id.Multiline = false;
            this.TxtBox_Id.Name = "TxtBox_Id";
            this.TxtBox_Id.Size = new System.Drawing.Size(226, 50);
            this.TxtBox_Id.TabIndex = 1;
            this.TxtBox_Id.Text = "";
            this.TxtBox_Id.TrailingIcon = null;
            // 
            // BtnDelete_Instrument
            // 
            this.BtnDelete_Instrument.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnDelete_Instrument.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.BtnDelete_Instrument.Depth = 0;
            this.BtnDelete_Instrument.HighEmphasis = true;
            this.BtnDelete_Instrument.Icon = null;
            this.BtnDelete_Instrument.Location = new System.Drawing.Point(161, 236);
            this.BtnDelete_Instrument.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.BtnDelete_Instrument.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnDelete_Instrument.Name = "BtnDelete_Instrument";
            this.BtnDelete_Instrument.Size = new System.Drawing.Size(88, 36);
            this.BtnDelete_Instrument.TabIndex = 39;
            this.BtnDelete_Instrument.Text = "Eliminar";
            this.BtnDelete_Instrument.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.BtnDelete_Instrument.UseAccentColor = false;
            this.BtnDelete_Instrument.UseVisualStyleBackColor = true;
            this.BtnDelete_Instrument.Click += new System.EventHandler(this.BtnDelete_Instrument_Click);
            // 
            // DeleteInstrument
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 325);
            this.Controls.Add(this.BtnDelete_Instrument);
            this.Controls.Add(this.TxtBox_Id);
            this.Controls.Add(this.materialLabel1);
            this.Name = "DeleteInstrument";
            this.Text = "Eliminar Instrumento";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialTextBox TxtBox_Id;
        private MaterialSkin.Controls.MaterialButton BtnDelete_Instrument;
    }
}