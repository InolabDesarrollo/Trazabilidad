namespace CTZ.Vista.Instruments
{
    partial class See_Instrument_Assignment
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
            this.Pnl_Instrument = new System.Windows.Forms.Panel();
            this.Lbl_Equino_Instrument = new System.Windows.Forms.Label();
            this.Pnl_Body = new System.Windows.Forms.Panel();
            this.Dgv_Instrument_Assignment = new System.Windows.Forms.DataGridView();
            this.Pnl_Instrument.SuspendLayout();
            this.Pnl_Body.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Instrument_Assignment)).BeginInit();
            this.SuspendLayout();
            // 
            // Pnl_Instrument
            // 
            this.Pnl_Instrument.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Pnl_Instrument.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Pnl_Instrument.Controls.Add(this.Lbl_Equino_Instrument);
            this.Pnl_Instrument.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.Pnl_Instrument.Location = new System.Drawing.Point(-3, 0);
            this.Pnl_Instrument.Name = "Pnl_Instrument";
            this.Pnl_Instrument.Size = new System.Drawing.Size(822, 71);
            this.Pnl_Instrument.TabIndex = 0;
            // 
            // Lbl_Equino_Instrument
            // 
            this.Lbl_Equino_Instrument.AutoSize = true;
            this.Lbl_Equino_Instrument.BackColor = System.Drawing.Color.LightSkyBlue;
            this.Lbl_Equino_Instrument.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Equino_Instrument.Location = new System.Drawing.Point(31, 22);
            this.Lbl_Equino_Instrument.Name = "Lbl_Equino_Instrument";
            this.Lbl_Equino_Instrument.Size = new System.Drawing.Size(192, 24);
            this.Lbl_Equino_Instrument.TabIndex = 0;
            this.Lbl_Equino_Instrument.Text = "Equino Instrumento";
            // 
            // Pnl_Body
            // 
            this.Pnl_Body.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Pnl_Body.Controls.Add(this.Dgv_Instrument_Assignment);
            this.Pnl_Body.Location = new System.Drawing.Point(0, 69);
            this.Pnl_Body.Name = "Pnl_Body";
            this.Pnl_Body.Size = new System.Drawing.Size(822, 405);
            this.Pnl_Body.TabIndex = 1;
            // 
            // Dgv_Instrument_Assignment
            // 
            this.Dgv_Instrument_Assignment.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Dgv_Instrument_Assignment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_Instrument_Assignment.Location = new System.Drawing.Point(0, 3);
            this.Dgv_Instrument_Assignment.Name = "Dgv_Instrument_Assignment";
            this.Dgv_Instrument_Assignment.Size = new System.Drawing.Size(819, 399);
            this.Dgv_Instrument_Assignment.TabIndex = 0;
            // 
            // See_Instrument_Assignment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 474);
            this.Controls.Add(this.Pnl_Body);
            this.Controls.Add(this.Pnl_Instrument);
            this.Name = "See_Instrument_Assignment";
            this.Text = "Asignacion de Instrumento";
            this.Pnl_Instrument.ResumeLayout(false);
            this.Pnl_Instrument.PerformLayout();
            this.Pnl_Body.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Instrument_Assignment)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Pnl_Instrument;
        private System.Windows.Forms.Label Lbl_Equino_Instrument;
        private System.Windows.Forms.Panel Pnl_Body;
        private System.Windows.Forms.DataGridView Dgv_Instrument_Assignment;
    }
}