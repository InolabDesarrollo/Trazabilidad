namespace CTZ.Vista.Instruments
{
    partial class EngineerSignature
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
            this.Pnl_Signature = new System.Windows.Forms.Panel();
            this.Btn_Save_Signature = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Pnl_Signature
            // 
            this.Pnl_Signature.BackColor = System.Drawing.Color.White;
            this.Pnl_Signature.Location = new System.Drawing.Point(12, 39);
            this.Pnl_Signature.Name = "Pnl_Signature";
            this.Pnl_Signature.Size = new System.Drawing.Size(752, 360);
            this.Pnl_Signature.TabIndex = 1;
            this.Pnl_Signature.Paint += new System.Windows.Forms.PaintEventHandler(this.Pnl_Signature_Paint);
            this.Pnl_Signature.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Pnl_Signature_MouseDown);
            this.Pnl_Signature.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Pnl_Signature_MouseMove);
            // 
            // Btn_Save_Signature
            // 
            this.Btn_Save_Signature.BackColor = System.Drawing.Color.LightBlue;
            this.Btn_Save_Signature.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Save_Signature.Location = new System.Drawing.Point(315, 405);
            this.Btn_Save_Signature.Name = "Btn_Save_Signature";
            this.Btn_Save_Signature.Size = new System.Drawing.Size(184, 50);
            this.Btn_Save_Signature.TabIndex = 2;
            this.Btn_Save_Signature.Text = "Guardar Firma";
            this.Btn_Save_Signature.UseVisualStyleBackColor = false;
            this.Btn_Save_Signature.Click += new System.EventHandler(this.Btn_Save_Signature_Click);
            // 
            // EngineerSignature
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(800, 502);
            this.Controls.Add(this.Btn_Save_Signature);
            this.Controls.Add(this.Pnl_Signature);
            this.Name = "EngineerSignature";
            this.Text = "Registro Firma de Ingeniero";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Pnl_Signature;
        private System.Windows.Forms.Button Btn_Save_Signature;
    }
}