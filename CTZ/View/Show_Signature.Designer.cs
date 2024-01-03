namespace CTZ.View
{
    partial class Show_Signature
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
            this.PictureBoxSignature = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxSignature)).BeginInit();
            this.SuspendLayout();
            // 
            // PictureBoxSignature
            // 
            this.PictureBoxSignature.BackColor = System.Drawing.Color.White;
            this.PictureBoxSignature.Location = new System.Drawing.Point(15, 20);
            this.PictureBoxSignature.Name = "PictureBoxSignature";
            this.PictureBoxSignature.Size = new System.Drawing.Size(771, 410);
            this.PictureBoxSignature.TabIndex = 6;
            this.PictureBoxSignature.TabStop = false;
            // 
            // Show_Signature
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PictureBoxSignature);
            this.Name = "Show_Signature";
            this.Text = "Mostrar Firma";
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxSignature)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox PictureBoxSignature;
    }
}