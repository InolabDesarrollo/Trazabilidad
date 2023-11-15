﻿namespace CTZ.View.Calibration
{
    partial class SeeCalibrationRequest
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
            this.Page_Laboratory = new System.Windows.Forms.TabPage();
            this.Page_Instruents = new System.Windows.Forms.TabPage();
            this.Lbl_Instrument = new System.Windows.Forms.Label();
            this.Tab_Principal = new System.Windows.Forms.TabControl();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Btn_Serch = new System.Windows.Forms.Button();
            this.GridView_CalibrationRequestInstrument = new ADGV.AdvancedDataGridView();
            this.Page_Instruents.SuspendLayout();
            this.Tab_Principal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridView_CalibrationRequestInstrument)).BeginInit();
            this.SuspendLayout();
            // 
            // Page_Laboratory
            // 
            this.Page_Laboratory.Location = new System.Drawing.Point(4, 22);
            this.Page_Laboratory.Name = "Page_Laboratory";
            this.Page_Laboratory.Padding = new System.Windows.Forms.Padding(3);
            this.Page_Laboratory.Size = new System.Drawing.Size(788, 353);
            this.Page_Laboratory.TabIndex = 1;
            this.Page_Laboratory.Text = "Laboratorio";
            this.Page_Laboratory.UseVisualStyleBackColor = true;
            // 
            // Page_Instruents
            // 
            this.Page_Instruents.Controls.Add(this.GridView_CalibrationRequestInstrument);
            this.Page_Instruents.Controls.Add(this.Btn_Serch);
            this.Page_Instruents.Controls.Add(this.textBox1);
            this.Page_Instruents.Controls.Add(this.Lbl_Instrument);
            this.Page_Instruents.Location = new System.Drawing.Point(4, 22);
            this.Page_Instruents.Name = "Page_Instruents";
            this.Page_Instruents.Padding = new System.Windows.Forms.Padding(3);
            this.Page_Instruents.Size = new System.Drawing.Size(788, 363);
            this.Page_Instruents.TabIndex = 0;
            this.Page_Instruents.Text = "Instrumento";
            this.Page_Instruents.UseVisualStyleBackColor = true;
            // 
            // Lbl_Instrument
            // 
            this.Lbl_Instrument.AutoSize = true;
            this.Lbl_Instrument.Location = new System.Drawing.Point(39, 17);
            this.Lbl_Instrument.Name = "Lbl_Instrument";
            this.Lbl_Instrument.Size = new System.Drawing.Size(62, 13);
            this.Lbl_Instrument.TabIndex = 0;
            this.Lbl_Instrument.Text = "Instrumento";
            // 
            // Tab_Principal
            // 
            this.Tab_Principal.Controls.Add(this.Page_Instruents);
            this.Tab_Principal.Controls.Add(this.Page_Laboratory);
            this.Tab_Principal.Location = new System.Drawing.Point(12, 23);
            this.Tab_Principal.Name = "Tab_Principal";
            this.Tab_Principal.SelectedIndex = 0;
            this.Tab_Principal.Size = new System.Drawing.Size(796, 389);
            this.Tab_Principal.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(107, 17);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(230, 20);
            this.textBox1.TabIndex = 1;
            // 
            // Btn_Serch
            // 
            this.Btn_Serch.BackColor = System.Drawing.Color.LightGray;
            this.Btn_Serch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Serch.Location = new System.Drawing.Point(107, 43);
            this.Btn_Serch.Name = "Btn_Serch";
            this.Btn_Serch.Size = new System.Drawing.Size(88, 26);
            this.Btn_Serch.TabIndex = 5;
            this.Btn_Serch.Text = "Buscar";
            this.Btn_Serch.UseVisualStyleBackColor = false;
            this.Btn_Serch.Visible = false;
            // 
            // GridView_CalibrationRequestInstrument
            // 
            this.GridView_CalibrationRequestInstrument.AutoGenerateContextFilters = true;
            this.GridView_CalibrationRequestInstrument.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            this.GridView_CalibrationRequestInstrument.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridView_CalibrationRequestInstrument.DateWithTime = false;
            this.GridView_CalibrationRequestInstrument.Location = new System.Drawing.Point(6, 75);
            this.GridView_CalibrationRequestInstrument.Name = "GridView_CalibrationRequestInstrument";
            this.GridView_CalibrationRequestInstrument.Size = new System.Drawing.Size(776, 259);
            this.GridView_CalibrationRequestInstrument.TabIndex = 6;
            this.GridView_CalibrationRequestInstrument.TimeFilter = false;
            // 
            // SeeCalibrationRequest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 470);
            this.Controls.Add(this.Tab_Principal);
            this.Name = "SeeCalibrationRequest";
            this.Text = "Solicitudes de Calibracion";
            this.Page_Instruents.ResumeLayout(false);
            this.Page_Instruents.PerformLayout();
            this.Tab_Principal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridView_CalibrationRequestInstrument)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage Page_Laboratory;
        private System.Windows.Forms.TabPage Page_Instruents;
        private System.Windows.Forms.Label Lbl_Instrument;
        private System.Windows.Forms.TabControl Tab_Principal;
        private System.Windows.Forms.TextBox textBox1;
        private ADGV.AdvancedDataGridView GridView_CalibrationRequestInstrument;
        private System.Windows.Forms.Button Btn_Serch;
    }
}