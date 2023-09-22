namespace CTZ.Vista
{
    partial class SerchInstrument
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
            this.Id_Instrument = new MaterialSkin.Controls.MaterialLabel();
            this.TxtBox_Instrument = new MaterialSkin.Controls.MaterialTextBox();
            this.Btn_Serch_Instrument = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // Id_Instrument
            // 
            this.Id_Instrument.AutoSize = true;
            this.Id_Instrument.Depth = 0;
            this.Id_Instrument.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Id_Instrument.Location = new System.Drawing.Point(39, 108);
            this.Id_Instrument.MouseState = MaterialSkin.MouseState.HOVER;
            this.Id_Instrument.Name = "Id_Instrument";
            this.Id_Instrument.Size = new System.Drawing.Size(103, 19);
            this.Id_Instrument.TabIndex = 0;
            this.Id_Instrument.Text = "Id Instrumento";
            // 
            // TxtBox_Instrument
            // 
            this.TxtBox_Instrument.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtBox_Instrument.Depth = 0;
            this.TxtBox_Instrument.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TxtBox_Instrument.LeadingIcon = null;
            this.TxtBox_Instrument.Location = new System.Drawing.Point(42, 145);
            this.TxtBox_Instrument.MaxLength = 50;
            this.TxtBox_Instrument.MouseState = MaterialSkin.MouseState.OUT;
            this.TxtBox_Instrument.Multiline = false;
            this.TxtBox_Instrument.Name = "TxtBox_Instrument";
            this.TxtBox_Instrument.Size = new System.Drawing.Size(343, 50);
            this.TxtBox_Instrument.TabIndex = 1;
            this.TxtBox_Instrument.Text = "";
            this.TxtBox_Instrument.TrailingIcon = null;
            // 
            // Btn_Serch_Instrument
            // 
            this.Btn_Serch_Instrument.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Btn_Serch_Instrument.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.Btn_Serch_Instrument.Depth = 0;
            this.Btn_Serch_Instrument.HighEmphasis = true;
            this.Btn_Serch_Instrument.Icon = null;
            this.Btn_Serch_Instrument.Location = new System.Drawing.Point(293, 236);
            this.Btn_Serch_Instrument.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Btn_Serch_Instrument.MouseState = MaterialSkin.MouseState.HOVER;
            this.Btn_Serch_Instrument.Name = "Btn_Serch_Instrument";
            this.Btn_Serch_Instrument.Size = new System.Drawing.Size(183, 36);
            this.Btn_Serch_Instrument.TabIndex = 56;
            this.Btn_Serch_Instrument.Text = "Buscar Instrumento";
            this.Btn_Serch_Instrument.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.Btn_Serch_Instrument.UseAccentColor = false;
            this.Btn_Serch_Instrument.UseVisualStyleBackColor = true;
            this.Btn_Serch_Instrument.Click += new System.EventHandler(this.Btn_Serch_Instrument_Click);
            // 
            // SerchInstrument
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 301);
            this.Controls.Add(this.Btn_Serch_Instrument);
            this.Controls.Add(this.TxtBox_Instrument);
            this.Controls.Add(this.Id_Instrument);
            this.Name = "SerchInstrument";
            this.Text = "Buscar Instrumento";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel Id_Instrument;
        private MaterialSkin.Controls.MaterialTextBox TxtBox_Instrument;
        private MaterialSkin.Controls.MaterialButton Btn_Serch_Instrument;
    }
}