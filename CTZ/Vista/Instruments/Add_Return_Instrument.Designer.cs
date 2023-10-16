namespace CTZ.Vista.Instruments
{
    partial class Add_Return_Instrument
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
            this.DatePicker_DateOfReturn = new System.Windows.Forms.DateTimePicker();
            this.Lbl_Date_Of_Return = new MaterialSkin.Controls.MaterialLabel();
            this.Lbl_Observations = new MaterialSkin.Controls.MaterialLabel();
            this.TxtBox_ObservationReturn = new MaterialSkin.Controls.MaterialTextBox();
            this.Btn_Regist_InformationReturn = new MaterialSkin.Controls.MaterialButton();
            this.Lbl_Estimate_Date_Return = new MaterialSkin.Controls.MaterialLabel();
            this.SuspendLayout();
            // 
            // DatePicker_DateOfReturn
            // 
            this.DatePicker_DateOfReturn.Location = new System.Drawing.Point(38, 206);
            this.DatePicker_DateOfReturn.Name = "DatePicker_DateOfReturn";
            this.DatePicker_DateOfReturn.Size = new System.Drawing.Size(308, 20);
            this.DatePicker_DateOfReturn.TabIndex = 0;
            // 
            // Lbl_Date_Of_Return
            // 
            this.Lbl_Date_Of_Return.AutoSize = true;
            this.Lbl_Date_Of_Return.Depth = 0;
            this.Lbl_Date_Of_Return.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Lbl_Date_Of_Return.Location = new System.Drawing.Point(35, 166);
            this.Lbl_Date_Of_Return.MouseState = MaterialSkin.MouseState.HOVER;
            this.Lbl_Date_Of_Return.Name = "Lbl_Date_Of_Return";
            this.Lbl_Date_Of_Return.Size = new System.Drawing.Size(148, 19);
            this.Lbl_Date_Of_Return.TabIndex = 1;
            this.Lbl_Date_Of_Return.Text = "Fecha de Devolucion";
            // 
            // Lbl_Observations
            // 
            this.Lbl_Observations.AutoSize = true;
            this.Lbl_Observations.Depth = 0;
            this.Lbl_Observations.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Lbl_Observations.Location = new System.Drawing.Point(35, 246);
            this.Lbl_Observations.MouseState = MaterialSkin.MouseState.HOVER;
            this.Lbl_Observations.Name = "Lbl_Observations";
            this.Lbl_Observations.Size = new System.Drawing.Size(105, 19);
            this.Lbl_Observations.TabIndex = 2;
            this.Lbl_Observations.Text = "Observaciones";
            // 
            // TxtBox_ObservationReturn
            // 
            this.TxtBox_ObservationReturn.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtBox_ObservationReturn.Depth = 0;
            this.TxtBox_ObservationReturn.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TxtBox_ObservationReturn.LeadingIcon = null;
            this.TxtBox_ObservationReturn.Location = new System.Drawing.Point(38, 289);
            this.TxtBox_ObservationReturn.MaxLength = 50;
            this.TxtBox_ObservationReturn.MouseState = MaterialSkin.MouseState.OUT;
            this.TxtBox_ObservationReturn.Multiline = false;
            this.TxtBox_ObservationReturn.Name = "TxtBox_ObservationReturn";
            this.TxtBox_ObservationReturn.Size = new System.Drawing.Size(683, 50);
            this.TxtBox_ObservationReturn.TabIndex = 3;
            this.TxtBox_ObservationReturn.Text = "";
            this.TxtBox_ObservationReturn.TrailingIcon = null;
            // 
            // Btn_Regist_InformationReturn
            // 
            this.Btn_Regist_InformationReturn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Btn_Regist_InformationReturn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.Btn_Regist_InformationReturn.Depth = 0;
            this.Btn_Regist_InformationReturn.HighEmphasis = true;
            this.Btn_Regist_InformationReturn.Icon = null;
            this.Btn_Regist_InformationReturn.Location = new System.Drawing.Point(38, 402);
            this.Btn_Regist_InformationReturn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Btn_Regist_InformationReturn.MouseState = MaterialSkin.MouseState.HOVER;
            this.Btn_Regist_InformationReturn.Name = "Btn_Regist_InformationReturn";
            this.Btn_Regist_InformationReturn.Size = new System.Drawing.Size(318, 36);
            this.Btn_Regist_InformationReturn.TabIndex = 6;
            this.Btn_Regist_InformationReturn.Text = "Registrar Informacion de Devolucion";
            this.Btn_Regist_InformationReturn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.Btn_Regist_InformationReturn.UseAccentColor = false;
            this.Btn_Regist_InformationReturn.UseVisualStyleBackColor = true;
            this.Btn_Regist_InformationReturn.Click += new System.EventHandler(this.Btn_Add_Click);
            // 
            // Lbl_Estimate_Date_Return
            // 
            this.Lbl_Estimate_Date_Return.AutoSize = true;
            this.Lbl_Estimate_Date_Return.Depth = 0;
            this.Lbl_Estimate_Date_Return.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Lbl_Estimate_Date_Return.Location = new System.Drawing.Point(35, 88);
            this.Lbl_Estimate_Date_Return.MouseState = MaterialSkin.MouseState.HOVER;
            this.Lbl_Estimate_Date_Return.Name = "Lbl_Estimate_Date_Return";
            this.Lbl_Estimate_Date_Return.Size = new System.Drawing.Size(221, 19);
            this.Lbl_Estimate_Date_Return.TabIndex = 7;
            this.Lbl_Estimate_Date_Return.Text = "Fecha registrada de devolucion";
            // 
            // Add_Return_Instrument
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 493);
            this.Controls.Add(this.Lbl_Estimate_Date_Return);
            this.Controls.Add(this.Btn_Regist_InformationReturn);
            this.Controls.Add(this.TxtBox_ObservationReturn);
            this.Controls.Add(this.Lbl_Observations);
            this.Controls.Add(this.Lbl_Date_Of_Return);
            this.Controls.Add(this.DatePicker_DateOfReturn);
            this.Name = "Add_Return_Instrument";
            this.Text = "Registrar Devolucion de Instrumento";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker DatePicker_DateOfReturn;
        private MaterialSkin.Controls.MaterialLabel Lbl_Date_Of_Return;
        private MaterialSkin.Controls.MaterialLabel Lbl_Observations;
        private MaterialSkin.Controls.MaterialTextBox TxtBox_ObservationReturn;
        private MaterialSkin.Controls.MaterialButton Btn_Regist_InformationReturn;
        private MaterialSkin.Controls.MaterialLabel Lbl_Estimate_Date_Return;
    }
}