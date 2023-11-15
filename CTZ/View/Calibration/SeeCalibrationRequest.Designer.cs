namespace CTZ.View.Calibration
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
            this.Btn_DeleteFilter = new System.Windows.Forms.Button();
            this.GridView_CalibrationRequestInstrument = new ADGV.AdvancedDataGridView();
            this.Btn_Serch_Instrument = new System.Windows.Forms.Button();
            this.TxtBox_Instrument = new System.Windows.Forms.TextBox();
            this.Lbl_Instrument = new System.Windows.Forms.Label();
            this.Tab_Principal = new System.Windows.Forms.TabControl();
            this.Page_Instruents.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridView_CalibrationRequestInstrument)).BeginInit();
            this.Tab_Principal.SuspendLayout();
            this.SuspendLayout();
            // 
            // Page_Laboratory
            // 
            this.Page_Laboratory.Location = new System.Drawing.Point(4, 22);
            this.Page_Laboratory.Name = "Page_Laboratory";
            this.Page_Laboratory.Padding = new System.Windows.Forms.Padding(3);
            this.Page_Laboratory.Size = new System.Drawing.Size(805, 380);
            this.Page_Laboratory.TabIndex = 1;
            this.Page_Laboratory.Text = "Laboratorio";
            this.Page_Laboratory.UseVisualStyleBackColor = true;
            // 
            // Page_Instruents
            // 
            this.Page_Instruents.Controls.Add(this.Btn_DeleteFilter);
            this.Page_Instruents.Controls.Add(this.GridView_CalibrationRequestInstrument);
            this.Page_Instruents.Controls.Add(this.Btn_Serch_Instrument);
            this.Page_Instruents.Controls.Add(this.TxtBox_Instrument);
            this.Page_Instruents.Controls.Add(this.Lbl_Instrument);
            this.Page_Instruents.Location = new System.Drawing.Point(4, 22);
            this.Page_Instruents.Name = "Page_Instruents";
            this.Page_Instruents.Padding = new System.Windows.Forms.Padding(3);
            this.Page_Instruents.Size = new System.Drawing.Size(805, 380);
            this.Page_Instruents.TabIndex = 0;
            this.Page_Instruents.Text = "Instrumento";
            this.Page_Instruents.UseVisualStyleBackColor = true;
            // 
            // Btn_DeleteFilter
            // 
            this.Btn_DeleteFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(112)))), ((int)(((byte)(192)))));
            this.Btn_DeleteFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_DeleteFilter.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Btn_DeleteFilter.Location = new System.Drawing.Point(249, 43);
            this.Btn_DeleteFilter.Name = "Btn_DeleteFilter";
            this.Btn_DeleteFilter.Size = new System.Drawing.Size(88, 26);
            this.Btn_DeleteFilter.TabIndex = 7;
            this.Btn_DeleteFilter.Text = "Eliminar Filtro";
            this.Btn_DeleteFilter.UseVisualStyleBackColor = false;
            this.Btn_DeleteFilter.Click += new System.EventHandler(this.Btn_DeleteFilter_Click);
            // 
            // GridView_CalibrationRequestInstrument
            // 
            this.GridView_CalibrationRequestInstrument.AllowUserToAddRows = false;
            this.GridView_CalibrationRequestInstrument.AllowUserToDeleteRows = false;
            this.GridView_CalibrationRequestInstrument.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GridView_CalibrationRequestInstrument.AutoGenerateContextFilters = true;
            this.GridView_CalibrationRequestInstrument.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GridView_CalibrationRequestInstrument.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            this.GridView_CalibrationRequestInstrument.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GridView_CalibrationRequestInstrument.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridView_CalibrationRequestInstrument.DateWithTime = false;
            this.GridView_CalibrationRequestInstrument.Location = new System.Drawing.Point(6, 90);
            this.GridView_CalibrationRequestInstrument.Name = "GridView_CalibrationRequestInstrument";
            this.GridView_CalibrationRequestInstrument.Size = new System.Drawing.Size(793, 284);
            this.GridView_CalibrationRequestInstrument.TabIndex = 6;
            this.GridView_CalibrationRequestInstrument.TimeFilter = false;
            this.GridView_CalibrationRequestInstrument.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridView_CalibrationRequestInstrument_CellContentDoubleClick);
            // 
            // Btn_Serch_Instrument
            // 
            this.Btn_Serch_Instrument.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(112)))), ((int)(((byte)(192)))));
            this.Btn_Serch_Instrument.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Serch_Instrument.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Btn_Serch_Instrument.Location = new System.Drawing.Point(107, 43);
            this.Btn_Serch_Instrument.Name = "Btn_Serch_Instrument";
            this.Btn_Serch_Instrument.Size = new System.Drawing.Size(88, 26);
            this.Btn_Serch_Instrument.TabIndex = 5;
            this.Btn_Serch_Instrument.Text = "Buscar";
            this.Btn_Serch_Instrument.UseVisualStyleBackColor = false;
            this.Btn_Serch_Instrument.Click += new System.EventHandler(this.Btn_Serch_Instrument_Click);
            // 
            // TxtBox_Instrument
            // 
            this.TxtBox_Instrument.Location = new System.Drawing.Point(107, 17);
            this.TxtBox_Instrument.Name = "TxtBox_Instrument";
            this.TxtBox_Instrument.Size = new System.Drawing.Size(230, 20);
            this.TxtBox_Instrument.TabIndex = 1;
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
            this.Tab_Principal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Tab_Principal.Controls.Add(this.Page_Instruents);
            this.Tab_Principal.Controls.Add(this.Page_Laboratory);
            this.Tab_Principal.Location = new System.Drawing.Point(8, 22);
            this.Tab_Principal.Name = "Tab_Principal";
            this.Tab_Principal.SelectedIndex = 0;
            this.Tab_Principal.Size = new System.Drawing.Size(813, 406);
            this.Tab_Principal.TabIndex = 0;
            // 
            // SeeCalibrationRequest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 481);
            this.Controls.Add(this.Tab_Principal);
            this.Name = "SeeCalibrationRequest";
            this.Text = "Solicitudes de Calibracion";
            this.Page_Instruents.ResumeLayout(false);
            this.Page_Instruents.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridView_CalibrationRequestInstrument)).EndInit();
            this.Tab_Principal.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage Page_Laboratory;
        private System.Windows.Forms.TabPage Page_Instruents;
        private System.Windows.Forms.Label Lbl_Instrument;
        private System.Windows.Forms.TabControl Tab_Principal;
        private System.Windows.Forms.TextBox TxtBox_Instrument;
        private ADGV.AdvancedDataGridView GridView_CalibrationRequestInstrument;
        private System.Windows.Forms.Button Btn_Serch_Instrument;
        private System.Windows.Forms.Button Btn_DeleteFilter;
    }
}