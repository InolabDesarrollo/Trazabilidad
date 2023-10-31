namespace CTZ.Vista.Instruments
{
    partial class ShowSignature
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
            this.Lbl_Instrument = new System.Windows.Forms.Label();
            this.PictureBoxSignature = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxSignature)).BeginInit();
            this.SuspendLayout();
            // 
            // Lbl_Instrument
            // 
            this.Lbl_Instrument.AutoSize = true;
            this.Lbl_Instrument.BackColor = System.Drawing.Color.AliceBlue;
            this.Lbl_Instrument.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Instrument.Location = new System.Drawing.Point(12, 9);
            this.Lbl_Instrument.Name = "Lbl_Instrument";
            this.Lbl_Instrument.Size = new System.Drawing.Size(114, 25);
            this.Lbl_Instrument.TabIndex = 4;
            this.Lbl_Instrument.Text = "Instrumento";
            // 
            // PictureBoxSignature
            // 
            this.PictureBoxSignature.BackColor = System.Drawing.Color.White;
            this.PictureBoxSignature.Location = new System.Drawing.Point(17, 49);
            this.PictureBoxSignature.Name = "PictureBoxSignature";
            this.PictureBoxSignature.Size = new System.Drawing.Size(771, 410);
            this.PictureBoxSignature.TabIndex = 5;
            this.PictureBoxSignature.TabStop = false;
            // 
            // Signature
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(800, 471);
            this.Controls.Add(this.PictureBoxSignature);
            this.Controls.Add(this.Lbl_Instrument);
            this.Name = "Signature";
            this.Text = "Firma";
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxSignature)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Lbl_Instrument;
        private System.Windows.Forms.PictureBox PictureBoxSignature;
    }
}