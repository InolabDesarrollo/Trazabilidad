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
            this.Dgv_CalibrationRequestByLaboratory = new ADGV.AdvancedDataGridView();
            this.Btn_SelectLaboratory = new System.Windows.Forms.Button();
            this.ComboBox_Laboratory = new System.Windows.Forms.ComboBox();
            this.Lbl_Laboratory = new System.Windows.Forms.Label();
            this.Page_Instruents = new System.Windows.Forms.TabPage();
            this.Btn_DeleteFilter = new System.Windows.Forms.Button();
            this.Dgv_CalibrationRequestByInstrument = new ADGV.AdvancedDataGridView();
            this.Btn_Serch_Instrument = new System.Windows.Forms.Button();
            this.TxtBox_Instrument = new System.Windows.Forms.TextBox();
            this.Lbl_Instrument = new System.Windows.Forms.Label();
            this.Tab_Principal = new System.Windows.Forms.TabControl();
            this.PageDate = new System.Windows.Forms.TabPage();
            this.Btn_DeleteFilterDates = new System.Windows.Forms.Button();
            this.Btn_SelectByDates = new System.Windows.Forms.Button();
            this.Dgv_CalibrationRequestByDates = new ADGV.AdvancedDataGridView();
            this.TimePicker_Final = new System.Windows.Forms.DateTimePicker();
            this.Lbl_FinalDate = new System.Windows.Forms.Label();
            this.Lbl_BeganDate = new System.Windows.Forms.Label();
            this.TimePicker_Began = new System.Windows.Forms.DateTimePicker();
            this.Btn_CreateCalibrationRequest = new System.Windows.Forms.Button();
            this.Page_Laboratory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_CalibrationRequestByLaboratory)).BeginInit();
            this.Page_Instruents.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_CalibrationRequestByInstrument)).BeginInit();
            this.Tab_Principal.SuspendLayout();
            this.PageDate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_CalibrationRequestByDates)).BeginInit();
            this.SuspendLayout();
            // 
            // Page_Laboratory
            // 
            this.Page_Laboratory.Controls.Add(this.Dgv_CalibrationRequestByLaboratory);
            this.Page_Laboratory.Controls.Add(this.Btn_SelectLaboratory);
            this.Page_Laboratory.Controls.Add(this.ComboBox_Laboratory);
            this.Page_Laboratory.Controls.Add(this.Lbl_Laboratory);
            this.Page_Laboratory.Location = new System.Drawing.Point(4, 22);
            this.Page_Laboratory.Name = "Page_Laboratory";
            this.Page_Laboratory.Padding = new System.Windows.Forms.Padding(3);
            this.Page_Laboratory.Size = new System.Drawing.Size(807, 331);
            this.Page_Laboratory.TabIndex = 1;
            this.Page_Laboratory.Text = "Laboratorio";
            this.Page_Laboratory.UseVisualStyleBackColor = true;
            // 
            // Dgv_CalibrationRequestByLaboratory
            // 
            this.Dgv_CalibrationRequestByLaboratory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Dgv_CalibrationRequestByLaboratory.AutoGenerateContextFilters = true;
            this.Dgv_CalibrationRequestByLaboratory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Dgv_CalibrationRequestByLaboratory.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            this.Dgv_CalibrationRequestByLaboratory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Dgv_CalibrationRequestByLaboratory.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.Dgv_CalibrationRequestByLaboratory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_CalibrationRequestByLaboratory.DateWithTime = false;
            this.Dgv_CalibrationRequestByLaboratory.Location = new System.Drawing.Point(6, 79);
            this.Dgv_CalibrationRequestByLaboratory.Name = "Dgv_CalibrationRequestByLaboratory";
            this.Dgv_CalibrationRequestByLaboratory.Size = new System.Drawing.Size(795, 246);
            this.Dgv_CalibrationRequestByLaboratory.TabIndex = 7;
            this.Dgv_CalibrationRequestByLaboratory.TimeFilter = false;
            this.Dgv_CalibrationRequestByLaboratory.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_CalibrationRequestByLaboratory_CellContentDoubleClick);
            // 
            // Btn_SelectLaboratory
            // 
            this.Btn_SelectLaboratory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(112)))), ((int)(((byte)(192)))));
            this.Btn_SelectLaboratory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_SelectLaboratory.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Btn_SelectLaboratory.Location = new System.Drawing.Point(141, 47);
            this.Btn_SelectLaboratory.Name = "Btn_SelectLaboratory";
            this.Btn_SelectLaboratory.Size = new System.Drawing.Size(88, 26);
            this.Btn_SelectLaboratory.TabIndex = 6;
            this.Btn_SelectLaboratory.Text = "Seleccionar";
            this.Btn_SelectLaboratory.UseVisualStyleBackColor = false;
            this.Btn_SelectLaboratory.Click += new System.EventHandler(this.Btn_SelectLaboratory_Click);
            // 
            // ComboBox_Laboratory
            // 
            this.ComboBox_Laboratory.FormattingEnabled = true;
            this.ComboBox_Laboratory.Location = new System.Drawing.Point(141, 20);
            this.ComboBox_Laboratory.Name = "ComboBox_Laboratory";
            this.ComboBox_Laboratory.Size = new System.Drawing.Size(212, 21);
            this.ComboBox_Laboratory.TabIndex = 1;
            // 
            // Lbl_Laboratory
            // 
            this.Lbl_Laboratory.AutoSize = true;
            this.Lbl_Laboratory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Laboratory.Location = new System.Drawing.Point(45, 21);
            this.Lbl_Laboratory.Name = "Lbl_Laboratory";
            this.Lbl_Laboratory.Size = new System.Drawing.Size(90, 20);
            this.Lbl_Laboratory.TabIndex = 0;
            this.Lbl_Laboratory.Text = "Laboratorio";
            // 
            // Page_Instruents
            // 
            this.Page_Instruents.Controls.Add(this.Btn_DeleteFilter);
            this.Page_Instruents.Controls.Add(this.Dgv_CalibrationRequestByInstrument);
            this.Page_Instruents.Controls.Add(this.Btn_Serch_Instrument);
            this.Page_Instruents.Controls.Add(this.TxtBox_Instrument);
            this.Page_Instruents.Controls.Add(this.Lbl_Instrument);
            this.Page_Instruents.Location = new System.Drawing.Point(4, 22);
            this.Page_Instruents.Name = "Page_Instruents";
            this.Page_Instruents.Padding = new System.Windows.Forms.Padding(3);
            this.Page_Instruents.Size = new System.Drawing.Size(807, 331);
            this.Page_Instruents.TabIndex = 0;
            this.Page_Instruents.Text = "Instrumento";
            this.Page_Instruents.UseVisualStyleBackColor = true;
            // 
            // Btn_DeleteFilter
            // 
            this.Btn_DeleteFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(112)))), ((int)(((byte)(192)))));
            this.Btn_DeleteFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_DeleteFilter.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Btn_DeleteFilter.Location = new System.Drawing.Point(275, 43);
            this.Btn_DeleteFilter.Name = "Btn_DeleteFilter";
            this.Btn_DeleteFilter.Size = new System.Drawing.Size(88, 26);
            this.Btn_DeleteFilter.TabIndex = 7;
            this.Btn_DeleteFilter.Text = "Eliminar Filtro";
            this.Btn_DeleteFilter.UseVisualStyleBackColor = false;
            this.Btn_DeleteFilter.Click += new System.EventHandler(this.Btn_DeleteFilter_Click);
            // 
            // Dgv_CalibrationRequestByInstrument
            // 
            this.Dgv_CalibrationRequestByInstrument.AllowUserToAddRows = false;
            this.Dgv_CalibrationRequestByInstrument.AllowUserToDeleteRows = false;
            this.Dgv_CalibrationRequestByInstrument.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Dgv_CalibrationRequestByInstrument.AutoGenerateContextFilters = true;
            this.Dgv_CalibrationRequestByInstrument.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Dgv_CalibrationRequestByInstrument.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            this.Dgv_CalibrationRequestByInstrument.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Dgv_CalibrationRequestByInstrument.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.Dgv_CalibrationRequestByInstrument.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_CalibrationRequestByInstrument.DateWithTime = false;
            this.Dgv_CalibrationRequestByInstrument.Location = new System.Drawing.Point(6, 75);
            this.Dgv_CalibrationRequestByInstrument.Name = "Dgv_CalibrationRequestByInstrument";
            this.Dgv_CalibrationRequestByInstrument.Size = new System.Drawing.Size(795, 254);
            this.Dgv_CalibrationRequestByInstrument.TabIndex = 6;
            this.Dgv_CalibrationRequestByInstrument.TimeFilter = false;
            this.Dgv_CalibrationRequestByInstrument.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_CalibrationRequestByInstrument_CellContentDoubleClick);
            // 
            // Btn_Serch_Instrument
            // 
            this.Btn_Serch_Instrument.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(112)))), ((int)(((byte)(192)))));
            this.Btn_Serch_Instrument.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Serch_Instrument.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Btn_Serch_Instrument.Location = new System.Drawing.Point(133, 43);
            this.Btn_Serch_Instrument.Name = "Btn_Serch_Instrument";
            this.Btn_Serch_Instrument.Size = new System.Drawing.Size(88, 26);
            this.Btn_Serch_Instrument.TabIndex = 5;
            this.Btn_Serch_Instrument.Text = "Buscar";
            this.Btn_Serch_Instrument.UseVisualStyleBackColor = false;
            this.Btn_Serch_Instrument.Click += new System.EventHandler(this.Btn_Serch_Instrument_Click);
            // 
            // TxtBox_Instrument
            // 
            this.TxtBox_Instrument.Location = new System.Drawing.Point(133, 17);
            this.TxtBox_Instrument.Name = "TxtBox_Instrument";
            this.TxtBox_Instrument.Size = new System.Drawing.Size(230, 20);
            this.TxtBox_Instrument.TabIndex = 1;
            // 
            // Lbl_Instrument
            // 
            this.Lbl_Instrument.AutoSize = true;
            this.Lbl_Instrument.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Instrument.Location = new System.Drawing.Point(32, 15);
            this.Lbl_Instrument.Name = "Lbl_Instrument";
            this.Lbl_Instrument.Size = new System.Drawing.Size(95, 20);
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
            this.Tab_Principal.Controls.Add(this.PageDate);
            this.Tab_Principal.Location = new System.Drawing.Point(6, 80);
            this.Tab_Principal.Margin = new System.Windows.Forms.Padding(3, 3, 3, 9);
            this.Tab_Principal.Name = "Tab_Principal";
            this.Tab_Principal.SelectedIndex = 0;
            this.Tab_Principal.Size = new System.Drawing.Size(815, 357);
            this.Tab_Principal.TabIndex = 0;
            // 
            // PageDate
            // 
            this.PageDate.Controls.Add(this.Btn_DeleteFilterDates);
            this.PageDate.Controls.Add(this.Btn_SelectByDates);
            this.PageDate.Controls.Add(this.Dgv_CalibrationRequestByDates);
            this.PageDate.Controls.Add(this.TimePicker_Final);
            this.PageDate.Controls.Add(this.Lbl_FinalDate);
            this.PageDate.Controls.Add(this.Lbl_BeganDate);
            this.PageDate.Controls.Add(this.TimePicker_Began);
            this.PageDate.Location = new System.Drawing.Point(4, 22);
            this.PageDate.Margin = new System.Windows.Forms.Padding(3, 3, 5, 3);
            this.PageDate.Name = "PageDate";
            this.PageDate.Padding = new System.Windows.Forms.Padding(3);
            this.PageDate.Size = new System.Drawing.Size(807, 331);
            this.PageDate.TabIndex = 2;
            this.PageDate.Text = "Fechas";
            this.PageDate.UseVisualStyleBackColor = true;
            // 
            // Btn_DeleteFilterDates
            // 
            this.Btn_DeleteFilterDates.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(112)))), ((int)(((byte)(192)))));
            this.Btn_DeleteFilterDates.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_DeleteFilterDates.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Btn_DeleteFilterDates.Location = new System.Drawing.Point(243, 58);
            this.Btn_DeleteFilterDates.Name = "Btn_DeleteFilterDates";
            this.Btn_DeleteFilterDates.Size = new System.Drawing.Size(88, 26);
            this.Btn_DeleteFilterDates.TabIndex = 8;
            this.Btn_DeleteFilterDates.Text = "Eliminar Filtro";
            this.Btn_DeleteFilterDates.UseVisualStyleBackColor = false;
            this.Btn_DeleteFilterDates.Click += new System.EventHandler(this.Btn_DeleteFilterDates_Click);
            // 
            // Btn_SelectByDates
            // 
            this.Btn_SelectByDates.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(112)))), ((int)(((byte)(192)))));
            this.Btn_SelectByDates.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_SelectByDates.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Btn_SelectByDates.Location = new System.Drawing.Point(131, 58);
            this.Btn_SelectByDates.Name = "Btn_SelectByDates";
            this.Btn_SelectByDates.Size = new System.Drawing.Size(88, 26);
            this.Btn_SelectByDates.TabIndex = 7;
            this.Btn_SelectByDates.Text = "Seleccionar";
            this.Btn_SelectByDates.UseVisualStyleBackColor = false;
            this.Btn_SelectByDates.Click += new System.EventHandler(this.Btn_SelectByDates_Click);
            // 
            // Dgv_CalibrationRequestByDates
            // 
            this.Dgv_CalibrationRequestByDates.AllowUserToAddRows = false;
            this.Dgv_CalibrationRequestByDates.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Dgv_CalibrationRequestByDates.AutoGenerateContextFilters = true;
            this.Dgv_CalibrationRequestByDates.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Dgv_CalibrationRequestByDates.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            this.Dgv_CalibrationRequestByDates.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Dgv_CalibrationRequestByDates.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.Dgv_CalibrationRequestByDates.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_CalibrationRequestByDates.DateWithTime = false;
            this.Dgv_CalibrationRequestByDates.Location = new System.Drawing.Point(6, 90);
            this.Dgv_CalibrationRequestByDates.Margin = new System.Windows.Forms.Padding(3, 1, 6, 1);
            this.Dgv_CalibrationRequestByDates.Name = "Dgv_CalibrationRequestByDates";
            this.Dgv_CalibrationRequestByDates.Size = new System.Drawing.Size(795, 226);
            this.Dgv_CalibrationRequestByDates.TabIndex = 4;
            this.Dgv_CalibrationRequestByDates.TimeFilter = false;
            this.Dgv_CalibrationRequestByDates.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_CalibrationRequestByDates_CellContentDoubleClick);
            // 
            // TimePicker_Final
            // 
            this.TimePicker_Final.Location = new System.Drawing.Point(471, 25);
            this.TimePicker_Final.Name = "TimePicker_Final";
            this.TimePicker_Final.Size = new System.Drawing.Size(200, 20);
            this.TimePicker_Final.TabIndex = 3;
            // 
            // Lbl_FinalDate
            // 
            this.Lbl_FinalDate.AutoSize = true;
            this.Lbl_FinalDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_FinalDate.Location = new System.Drawing.Point(373, 25);
            this.Lbl_FinalDate.Name = "Lbl_FinalDate";
            this.Lbl_FinalDate.Size = new System.Drawing.Size(92, 20);
            this.Lbl_FinalDate.TabIndex = 2;
            this.Lbl_FinalDate.Text = "Fecha Final";
            // 
            // Lbl_BeganDate
            // 
            this.Lbl_BeganDate.AutoSize = true;
            this.Lbl_BeganDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_BeganDate.Location = new System.Drawing.Point(27, 25);
            this.Lbl_BeganDate.Name = "Lbl_BeganDate";
            this.Lbl_BeganDate.Size = new System.Drawing.Size(98, 20);
            this.Lbl_BeganDate.TabIndex = 1;
            this.Lbl_BeganDate.Text = "Fecha Inicial";
            // 
            // TimePicker_Began
            // 
            this.TimePicker_Began.Location = new System.Drawing.Point(131, 24);
            this.TimePicker_Began.Name = "TimePicker_Began";
            this.TimePicker_Began.Size = new System.Drawing.Size(200, 20);
            this.TimePicker_Began.TabIndex = 0;
            // 
            // Btn_CreateCalibrationRequest
            // 
            this.Btn_CreateCalibrationRequest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(112)))), ((int)(((byte)(192)))));
            this.Btn_CreateCalibrationRequest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_CreateCalibrationRequest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_CreateCalibrationRequest.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Btn_CreateCalibrationRequest.Location = new System.Drawing.Point(41, 449);
            this.Btn_CreateCalibrationRequest.Name = "Btn_CreateCalibrationRequest";
            this.Btn_CreateCalibrationRequest.Size = new System.Drawing.Size(129, 55);
            this.Btn_CreateCalibrationRequest.TabIndex = 6;
            this.Btn_CreateCalibrationRequest.Text = "Crear Solicitud ";
            this.Btn_CreateCalibrationRequest.UseVisualStyleBackColor = false;
            this.Btn_CreateCalibrationRequest.Click += new System.EventHandler(this.Btn_CreateCalibrationRequest_Click);
            // 
            // SeeCalibrationRequest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(833, 510);
            this.Controls.Add(this.Btn_CreateCalibrationRequest);
            this.Controls.Add(this.Tab_Principal);
            this.Name = "SeeCalibrationRequest";
            this.Text = "Solicitudes de Calibracion";
            this.Page_Laboratory.ResumeLayout(false);
            this.Page_Laboratory.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_CalibrationRequestByLaboratory)).EndInit();
            this.Page_Instruents.ResumeLayout(false);
            this.Page_Instruents.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_CalibrationRequestByInstrument)).EndInit();
            this.Tab_Principal.ResumeLayout(false);
            this.PageDate.ResumeLayout(false);
            this.PageDate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_CalibrationRequestByDates)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage Page_Laboratory;
        private System.Windows.Forms.TabPage Page_Instruents;
        private System.Windows.Forms.Label Lbl_Instrument;
        private System.Windows.Forms.TabControl Tab_Principal;
        private System.Windows.Forms.TextBox TxtBox_Instrument;
        private ADGV.AdvancedDataGridView Dgv_CalibrationRequestByInstrument;
        private System.Windows.Forms.Button Btn_Serch_Instrument;
        private System.Windows.Forms.Button Btn_DeleteFilter;
        private System.Windows.Forms.Button Btn_CreateCalibrationRequest;
        private System.Windows.Forms.Button Btn_SelectLaboratory;
        private System.Windows.Forms.ComboBox ComboBox_Laboratory;
        private System.Windows.Forms.Label Lbl_Laboratory;
        private ADGV.AdvancedDataGridView Dgv_CalibrationRequestByLaboratory;
        private System.Windows.Forms.TabPage PageDate;
        private System.Windows.Forms.DateTimePicker TimePicker_Began;
        private System.Windows.Forms.Label Lbl_BeganDate;
        private System.Windows.Forms.DateTimePicker TimePicker_Final;
        private System.Windows.Forms.Label Lbl_FinalDate;
        private ADGV.AdvancedDataGridView Dgv_CalibrationRequestByDates;
        private System.Windows.Forms.Button Btn_SelectByDates;
        private System.Windows.Forms.Button Btn_DeleteFilterDates;
    }
}