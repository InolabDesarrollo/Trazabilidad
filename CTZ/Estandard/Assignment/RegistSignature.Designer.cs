namespace CTZ.View.Estandard.Assignment
{
    partial class RegistSignature
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
            this.Lbl_Estandard = new System.Windows.Forms.Label();
            this.Pnl_Signature = new System.Windows.Forms.Panel();
            this.Btn_Save_Signature = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Lbl_Estandard
            // 
            this.Lbl_Estandard.AutoSize = true;
            this.Lbl_Estandard.BackColor = System.Drawing.Color.AliceBlue;
            this.Lbl_Estandard.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Estandard.Location = new System.Drawing.Point(12, 22);
            this.Lbl_Estandard.Name = "Lbl_Estandard";
            this.Lbl_Estandard.Size = new System.Drawing.Size(101, 25);
            this.Lbl_Estandard.TabIndex = 4;
            this.Lbl_Estandard.Text = "Estandard";
            // 
            // Pnl_Signature
            // 
            this.Pnl_Signature.BackColor = System.Drawing.Color.White;
            this.Pnl_Signature.Location = new System.Drawing.Point(12, 62);
            this.Pnl_Signature.Name = "Pnl_Signature";
            this.Pnl_Signature.Size = new System.Drawing.Size(776, 326);
            this.Pnl_Signature.TabIndex = 5;
            this.Pnl_Signature.Paint += new System.Windows.Forms.PaintEventHandler(this.Pnl_Signature_Paint);
            this.Pnl_Signature.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Pnl_Signature_MouseDown);
            this.Pnl_Signature.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Pnl_Signature_MouseMove);
            // 
            // Btn_Save_Signature
            // 
            this.Btn_Save_Signature.BackColor = System.Drawing.Color.LightBlue;
            this.Btn_Save_Signature.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Save_Signature.Location = new System.Drawing.Point(310, 394);
            this.Btn_Save_Signature.Name = "Btn_Save_Signature";
            this.Btn_Save_Signature.Size = new System.Drawing.Size(184, 50);
            this.Btn_Save_Signature.TabIndex = 6;
            this.Btn_Save_Signature.Text = "Guardar Firma";
            this.Btn_Save_Signature.UseVisualStyleBackColor = false;
            this.Btn_Save_Signature.Click += new System.EventHandler(this.Btn_Save_Signature_Click);
            // 
            // RegistSignature
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Btn_Save_Signature);
            this.Controls.Add(this.Pnl_Signature);
            this.Controls.Add(this.Lbl_Estandard);
            this.Name = "RegistSignature";
            this.Text = "RegistSignature";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_Estandard;
        private System.Windows.Forms.Panel Pnl_Signature;
        private System.Windows.Forms.Button Btn_Save_Signature;
    }
}