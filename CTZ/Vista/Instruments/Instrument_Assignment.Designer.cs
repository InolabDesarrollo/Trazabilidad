namespace CTZ.Vista.Instruments
{
    partial class Instrument_Assignment
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
            this.Dgv_Instrument_Assignment = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Instrument_Assignment)).BeginInit();
            this.SuspendLayout();
            // 
            // Dgv_Instrument_Assignment
            // 
            this.Dgv_Instrument_Assignment.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Dgv_Instrument_Assignment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_Instrument_Assignment.Location = new System.Drawing.Point(6, 67);
            this.Dgv_Instrument_Assignment.Name = "Dgv_Instrument_Assignment";
            this.Dgv_Instrument_Assignment.Size = new System.Drawing.Size(788, 377);
            this.Dgv_Instrument_Assignment.TabIndex = 0;
            // 
            // Instrument_Assignment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Dgv_Instrument_Assignment);
            this.Name = "Instrument_Assignment";
            this.Text = "Asignacion de Instrumento";
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Instrument_Assignment)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView Dgv_Instrument_Assignment;
    }
}