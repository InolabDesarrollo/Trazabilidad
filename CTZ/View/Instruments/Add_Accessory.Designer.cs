namespace CTZ.View.Instruments
{
    partial class Add_Accessory
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
            this.Lbl_Instrument = new MaterialSkin.Controls.MaterialLabel();
            this.TxtBox_Description = new MaterialSkin.Controls.MaterialTextBox();
            this.SuspendLayout();
            // 
            // Lbl_Instrument
            // 
            this.Lbl_Instrument.AutoSize = true;
            this.Lbl_Instrument.Depth = 0;
            this.Lbl_Instrument.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Lbl_Instrument.Location = new System.Drawing.Point(27, 87);
            this.Lbl_Instrument.MouseState = MaterialSkin.MouseState.HOVER;
            this.Lbl_Instrument.Name = "Lbl_Instrument";
            this.Lbl_Instrument.Size = new System.Drawing.Size(130, 19);
            this.Lbl_Instrument.TabIndex = 0;
            this.Lbl_Instrument.Text = "Equino Instrument";
            // 
            // TxtBox_Description
            // 
            this.TxtBox_Description.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtBox_Description.Depth = 0;
            this.TxtBox_Description.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TxtBox_Description.Hint = "DESCRIPCION";
            this.TxtBox_Description.LeadingIcon = null;
            this.TxtBox_Description.Location = new System.Drawing.Point(21, 135);
            this.TxtBox_Description.MaxLength = 50;
            this.TxtBox_Description.MouseState = MaterialSkin.MouseState.OUT;
            this.TxtBox_Description.Multiline = false;
            this.TxtBox_Description.Name = "TxtBox_Description";
            this.TxtBox_Description.Size = new System.Drawing.Size(301, 50);
            this.TxtBox_Description.TabIndex = 1;
            this.TxtBox_Description.Text = "";
            this.TxtBox_Description.TrailingIcon = null;
            // 
            // Add_Accessory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 450);
            this.Controls.Add(this.TxtBox_Description);
            this.Controls.Add(this.Lbl_Instrument);
            this.Name = "Add_Accessory";
            this.Text = "Agregar Accesorio";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel Lbl_Instrument;
        private MaterialSkin.Controls.MaterialTextBox TxtBox_Description;
    }
}