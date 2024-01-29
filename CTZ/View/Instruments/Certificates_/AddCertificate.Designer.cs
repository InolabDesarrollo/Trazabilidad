namespace CTZ.Vista.Responsabilitis
{
    partial class AddCertificate
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
            this.TxtBox_Interval = new MaterialSkin.Controls.MaterialTextBox();
            this.Lbl_DateCalibration = new MaterialSkin.Controls.MaterialLabel();
            this.DatePicker_Calibration = new System.Windows.Forms.DateTimePicker();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.DatePicker_NextCalibration = new System.Windows.Forms.DateTimePicker();
            this.TxtBox_Link = new MaterialSkin.Controls.MaterialTextBox();
            this.TxtBox_Number = new MaterialSkin.Controls.MaterialTextBox();
            this.BtnAdd = new MaterialSkin.Controls.MaterialButton();
            this.TxtBox_Laboratory = new MaterialSkin.Controls.MaterialTextBox();
            this.ComboBox_Use = new MaterialSkin.Controls.MaterialComboBox();
            this.Lbl_Instrument = new MaterialSkin.Controls.MaterialLabel();
            this.TxtBox_Uncertainty = new MaterialSkin.Controls.MaterialTextBox();
            this.TxtBox_Number_Temperature_Certificate = new MaterialSkin.Controls.MaterialTextBox();
            this.TxtBox_Number_Certificate_HR = new MaterialSkin.Controls.MaterialTextBox();
            this.TxtBox_Maximum_Error_T = new MaterialSkin.Controls.MaterialTextBox();
            this.TxtBox_HR_Interval = new MaterialSkin.Controls.MaterialTextBox();
            this.TxtBox_Maximun_Error_HR = new MaterialSkin.Controls.MaterialTextBox();
            this.SuspendLayout();
            // 
            // TxtBox_Interval
            // 
            this.TxtBox_Interval.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtBox_Interval.Depth = 0;
            this.TxtBox_Interval.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TxtBox_Interval.Hint = "Intervalo de medida";
            this.TxtBox_Interval.LeadingIcon = null;
            this.TxtBox_Interval.Location = new System.Drawing.Point(27, 124);
            this.TxtBox_Interval.MaxLength = 250;
            this.TxtBox_Interval.MouseState = MaterialSkin.MouseState.OUT;
            this.TxtBox_Interval.Multiline = false;
            this.TxtBox_Interval.Name = "TxtBox_Interval";
            this.TxtBox_Interval.Size = new System.Drawing.Size(409, 50);
            this.TxtBox_Interval.TabIndex = 14;
            this.TxtBox_Interval.Text = "";
            this.TxtBox_Interval.TrailingIcon = null;
            // 
            // Lbl_DateCalibration
            // 
            this.Lbl_DateCalibration.AutoSize = true;
            this.Lbl_DateCalibration.Depth = 0;
            this.Lbl_DateCalibration.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Lbl_DateCalibration.Location = new System.Drawing.Point(24, 193);
            this.Lbl_DateCalibration.MouseState = MaterialSkin.MouseState.HOVER;
            this.Lbl_DateCalibration.Name = "Lbl_DateCalibration";
            this.Lbl_DateCalibration.Size = new System.Drawing.Size(147, 19);
            this.Lbl_DateCalibration.TabIndex = 15;
            this.Lbl_DateCalibration.Text = "Fecha de calibración";
            // 
            // DatePicker_Calibration
            // 
            this.DatePicker_Calibration.Location = new System.Drawing.Point(220, 193);
            this.DatePicker_Calibration.Name = "DatePicker_Calibration";
            this.DatePicker_Calibration.Size = new System.Drawing.Size(216, 20);
            this.DatePicker_Calibration.TabIndex = 16;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(24, 249);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(142, 19);
            this.materialLabel2.TabIndex = 17;
            this.materialLabel2.Text = "Proxíma calibración";
            // 
            // DatePicker_NextCalibration
            // 
            this.DatePicker_NextCalibration.Location = new System.Drawing.Point(220, 248);
            this.DatePicker_NextCalibration.Name = "DatePicker_NextCalibration";
            this.DatePicker_NextCalibration.Size = new System.Drawing.Size(216, 20);
            this.DatePicker_NextCalibration.TabIndex = 18;
            // 
            // TxtBox_Link
            // 
            this.TxtBox_Link.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtBox_Link.Depth = 0;
            this.TxtBox_Link.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TxtBox_Link.Hint = "Link al certifiado";
            this.TxtBox_Link.LeadingIcon = null;
            this.TxtBox_Link.Location = new System.Drawing.Point(27, 304);
            this.TxtBox_Link.MaxLength = 280;
            this.TxtBox_Link.MouseState = MaterialSkin.MouseState.OUT;
            this.TxtBox_Link.Multiline = false;
            this.TxtBox_Link.Name = "TxtBox_Link";
            this.TxtBox_Link.Size = new System.Drawing.Size(409, 50);
            this.TxtBox_Link.TabIndex = 19;
            this.TxtBox_Link.Text = "";
            this.TxtBox_Link.TrailingIcon = null;
            // 
            // TxtBox_Number
            // 
            this.TxtBox_Number.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtBox_Number.Depth = 0;
            this.TxtBox_Number.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TxtBox_Number.Hint = "No. de certificado";
            this.TxtBox_Number.LeadingIcon = null;
            this.TxtBox_Number.Location = new System.Drawing.Point(27, 379);
            this.TxtBox_Number.MaxLength = 50;
            this.TxtBox_Number.MouseState = MaterialSkin.MouseState.OUT;
            this.TxtBox_Number.Multiline = false;
            this.TxtBox_Number.Name = "TxtBox_Number";
            this.TxtBox_Number.Size = new System.Drawing.Size(409, 50);
            this.TxtBox_Number.TabIndex = 20;
            this.TxtBox_Number.Text = "";
            this.TxtBox_Number.TrailingIcon = null;
            // 
            // BtnAdd
            // 
            this.BtnAdd.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnAdd.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.BtnAdd.Depth = 0;
            this.BtnAdd.HighEmphasis = true;
            this.BtnAdd.Icon = null;
            this.BtnAdd.Location = new System.Drawing.Point(714, 575);
            this.BtnAdd.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.BtnAdd.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(88, 36);
            this.BtnAdd.TabIndex = 25;
            this.BtnAdd.Text = "Agregar";
            this.BtnAdd.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.BtnAdd.UseAccentColor = false;
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // TxtBox_Laboratory
            // 
            this.TxtBox_Laboratory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtBox_Laboratory.Depth = 0;
            this.TxtBox_Laboratory.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TxtBox_Laboratory.Hint = "Laboratorio";
            this.TxtBox_Laboratory.LeadingIcon = null;
            this.TxtBox_Laboratory.Location = new System.Drawing.Point(27, 511);
            this.TxtBox_Laboratory.MaxLength = 250;
            this.TxtBox_Laboratory.MouseState = MaterialSkin.MouseState.OUT;
            this.TxtBox_Laboratory.Multiline = false;
            this.TxtBox_Laboratory.Name = "TxtBox_Laboratory";
            this.TxtBox_Laboratory.Size = new System.Drawing.Size(409, 50);
            this.TxtBox_Laboratory.TabIndex = 26;
            this.TxtBox_Laboratory.Text = "";
            this.TxtBox_Laboratory.TrailingIcon = null;
            // 
            // ComboBox_Use
            // 
            this.ComboBox_Use.AutoResize = false;
            this.ComboBox_Use.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ComboBox_Use.Depth = 0;
            this.ComboBox_Use.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.ComboBox_Use.DropDownHeight = 174;
            this.ComboBox_Use.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBox_Use.DropDownWidth = 121;
            this.ComboBox_Use.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.ComboBox_Use.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ComboBox_Use.FormattingEnabled = true;
            this.ComboBox_Use.IntegralHeight = false;
            this.ComboBox_Use.ItemHeight = 43;
            this.ComboBox_Use.Items.AddRange(new object[] {
            "CONEXION",
            "TEMPERATURA",
            "TEMPERATURA Y HUMEDAD"});
            this.ComboBox_Use.Location = new System.Drawing.Point(27, 444);
            this.ComboBox_Use.MaxDropDownItems = 4;
            this.ComboBox_Use.MouseState = MaterialSkin.MouseState.OUT;
            this.ComboBox_Use.Name = "ComboBox_Use";
            this.ComboBox_Use.Size = new System.Drawing.Size(409, 49);
            this.ComboBox_Use.StartIndex = 0;
            this.ComboBox_Use.TabIndex = 55;
            // 
            // Lbl_Instrument
            // 
            this.Lbl_Instrument.AutoSize = true;
            this.Lbl_Instrument.Depth = 0;
            this.Lbl_Instrument.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Lbl_Instrument.Location = new System.Drawing.Point(24, 77);
            this.Lbl_Instrument.MouseState = MaterialSkin.MouseState.HOVER;
            this.Lbl_Instrument.Name = "Lbl_Instrument";
            this.Lbl_Instrument.Size = new System.Drawing.Size(77, 19);
            this.Lbl_Instrument.TabIndex = 56;
            this.Lbl_Instrument.Text = "Instrument";
            // 
            // TxtBox_Uncertainty
            // 
            this.TxtBox_Uncertainty.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtBox_Uncertainty.Depth = 0;
            this.TxtBox_Uncertainty.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TxtBox_Uncertainty.Hint = "Incertidumbre";
            this.TxtBox_Uncertainty.LeadingIcon = null;
            this.TxtBox_Uncertainty.Location = new System.Drawing.Point(478, 123);
            this.TxtBox_Uncertainty.MaxLength = 250;
            this.TxtBox_Uncertainty.MouseState = MaterialSkin.MouseState.OUT;
            this.TxtBox_Uncertainty.Multiline = false;
            this.TxtBox_Uncertainty.Name = "TxtBox_Uncertainty";
            this.TxtBox_Uncertainty.Size = new System.Drawing.Size(324, 50);
            this.TxtBox_Uncertainty.TabIndex = 57;
            this.TxtBox_Uncertainty.Text = "";
            this.TxtBox_Uncertainty.TrailingIcon = null;
            // 
            // TxtBox_Number_Temperature_Certificate
            // 
            this.TxtBox_Number_Temperature_Certificate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtBox_Number_Temperature_Certificate.Depth = 0;
            this.TxtBox_Number_Temperature_Certificate.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TxtBox_Number_Temperature_Certificate.Hint = "No Certificado de temperatura";
            this.TxtBox_Number_Temperature_Certificate.LeadingIcon = null;
            this.TxtBox_Number_Temperature_Certificate.Location = new System.Drawing.Point(478, 190);
            this.TxtBox_Number_Temperature_Certificate.MaxLength = 250;
            this.TxtBox_Number_Temperature_Certificate.MouseState = MaterialSkin.MouseState.OUT;
            this.TxtBox_Number_Temperature_Certificate.Multiline = false;
            this.TxtBox_Number_Temperature_Certificate.Name = "TxtBox_Number_Temperature_Certificate";
            this.TxtBox_Number_Temperature_Certificate.Size = new System.Drawing.Size(324, 50);
            this.TxtBox_Number_Temperature_Certificate.TabIndex = 58;
            this.TxtBox_Number_Temperature_Certificate.Text = "";
            this.TxtBox_Number_Temperature_Certificate.TrailingIcon = null;
            // 
            // TxtBox_Number_Certificate_HR
            // 
            this.TxtBox_Number_Certificate_HR.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtBox_Number_Certificate_HR.Depth = 0;
            this.TxtBox_Number_Certificate_HR.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TxtBox_Number_Certificate_HR.Hint = "No Certificado de HR";
            this.TxtBox_Number_Certificate_HR.LeadingIcon = null;
            this.TxtBox_Number_Certificate_HR.Location = new System.Drawing.Point(478, 260);
            this.TxtBox_Number_Certificate_HR.MaxLength = 250;
            this.TxtBox_Number_Certificate_HR.MouseState = MaterialSkin.MouseState.OUT;
            this.TxtBox_Number_Certificate_HR.Multiline = false;
            this.TxtBox_Number_Certificate_HR.Name = "TxtBox_Number_Certificate_HR";
            this.TxtBox_Number_Certificate_HR.Size = new System.Drawing.Size(324, 50);
            this.TxtBox_Number_Certificate_HR.TabIndex = 59;
            this.TxtBox_Number_Certificate_HR.Text = "";
            this.TxtBox_Number_Certificate_HR.TrailingIcon = null;
            // 
            // TxtBox_Maximum_Error_T
            // 
            this.TxtBox_Maximum_Error_T.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtBox_Maximum_Error_T.Depth = 0;
            this.TxtBox_Maximum_Error_T.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TxtBox_Maximum_Error_T.Hint = "Error Maximo T";
            this.TxtBox_Maximum_Error_T.LeadingIcon = null;
            this.TxtBox_Maximum_Error_T.Location = new System.Drawing.Point(478, 343);
            this.TxtBox_Maximum_Error_T.MaxLength = 250;
            this.TxtBox_Maximum_Error_T.MouseState = MaterialSkin.MouseState.OUT;
            this.TxtBox_Maximum_Error_T.Multiline = false;
            this.TxtBox_Maximum_Error_T.Name = "TxtBox_Maximum_Error_T";
            this.TxtBox_Maximum_Error_T.Size = new System.Drawing.Size(324, 50);
            this.TxtBox_Maximum_Error_T.TabIndex = 61;
            this.TxtBox_Maximum_Error_T.Text = "";
            this.TxtBox_Maximum_Error_T.TrailingIcon = null;
            // 
            // TxtBox_HR_Interval
            // 
            this.TxtBox_HR_Interval.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtBox_HR_Interval.Depth = 0;
            this.TxtBox_HR_Interval.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TxtBox_HR_Interval.Hint = "Intervalo de HR";
            this.TxtBox_HR_Interval.LeadingIcon = null;
            this.TxtBox_HR_Interval.Location = new System.Drawing.Point(478, 421);
            this.TxtBox_HR_Interval.MaxLength = 250;
            this.TxtBox_HR_Interval.MouseState = MaterialSkin.MouseState.OUT;
            this.TxtBox_HR_Interval.Multiline = false;
            this.TxtBox_HR_Interval.Name = "TxtBox_HR_Interval";
            this.TxtBox_HR_Interval.Size = new System.Drawing.Size(324, 50);
            this.TxtBox_HR_Interval.TabIndex = 62;
            this.TxtBox_HR_Interval.Text = "";
            this.TxtBox_HR_Interval.TrailingIcon = null;
            // 
            // TxtBox_Maximun_Error_HR
            // 
            this.TxtBox_Maximun_Error_HR.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtBox_Maximun_Error_HR.Depth = 0;
            this.TxtBox_Maximun_Error_HR.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TxtBox_Maximun_Error_HR.Hint = "Error Maximo HR";
            this.TxtBox_Maximun_Error_HR.LeadingIcon = null;
            this.TxtBox_Maximun_Error_HR.Location = new System.Drawing.Point(478, 501);
            this.TxtBox_Maximun_Error_HR.MaxLength = 250;
            this.TxtBox_Maximun_Error_HR.MouseState = MaterialSkin.MouseState.OUT;
            this.TxtBox_Maximun_Error_HR.Multiline = false;
            this.TxtBox_Maximun_Error_HR.Name = "TxtBox_Maximun_Error_HR";
            this.TxtBox_Maximun_Error_HR.Size = new System.Drawing.Size(324, 50);
            this.TxtBox_Maximun_Error_HR.TabIndex = 63;
            this.TxtBox_Maximun_Error_HR.Text = "";
            this.TxtBox_Maximun_Error_HR.TrailingIcon = null;
            // 
            // AddCertificate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 643);
            this.Controls.Add(this.TxtBox_Maximun_Error_HR);
            this.Controls.Add(this.TxtBox_HR_Interval);
            this.Controls.Add(this.TxtBox_Maximum_Error_T);
            this.Controls.Add(this.TxtBox_Number_Certificate_HR);
            this.Controls.Add(this.TxtBox_Number_Temperature_Certificate);
            this.Controls.Add(this.TxtBox_Uncertainty);
            this.Controls.Add(this.Lbl_Instrument);
            this.Controls.Add(this.ComboBox_Use);
            this.Controls.Add(this.TxtBox_Laboratory);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.TxtBox_Number);
            this.Controls.Add(this.TxtBox_Link);
            this.Controls.Add(this.DatePicker_NextCalibration);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.DatePicker_Calibration);
            this.Controls.Add(this.Lbl_DateCalibration);
            this.Controls.Add(this.TxtBox_Interval);
            this.Name = "AddCertificate";
            this.Text = "Agregar Certificado";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialTextBox TxtBox_Interval;
        private MaterialSkin.Controls.MaterialLabel Lbl_DateCalibration;
        private System.Windows.Forms.DateTimePicker DatePicker_Calibration;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private System.Windows.Forms.DateTimePicker DatePicker_NextCalibration;
        private MaterialSkin.Controls.MaterialTextBox TxtBox_Link;
        private MaterialSkin.Controls.MaterialTextBox TxtBox_Number;
        private MaterialSkin.Controls.MaterialButton BtnAdd;
        private MaterialSkin.Controls.MaterialTextBox TxtBox_Laboratory;
        private MaterialSkin.Controls.MaterialComboBox ComboBox_Use;
        private MaterialSkin.Controls.MaterialLabel Lbl_Instrument;
        private MaterialSkin.Controls.MaterialTextBox TxtBox_Uncertainty;
        private MaterialSkin.Controls.MaterialTextBox TxtBox_Number_Temperature_Certificate;
        private MaterialSkin.Controls.MaterialTextBox TxtBox_Number_Certificate_HR;
        private MaterialSkin.Controls.MaterialTextBox TxtBox_Maximum_Error_T;
        private MaterialSkin.Controls.MaterialTextBox TxtBox_HR_Interval;
        private MaterialSkin.Controls.MaterialTextBox TxtBox_Maximun_Error_HR;
    }
}