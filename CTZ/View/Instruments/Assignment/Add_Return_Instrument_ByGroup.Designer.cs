namespace CTZ.Vista.Instruments
{
    partial class Add_Return_Instrument_ByGroup
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
            this.Lbl_Instrument = new MaterialSkin.Controls.MaterialLabel();
            this.TxtBox_Instrumenst = new MaterialSkin.Controls.MaterialTextBox();
            this.ComboBox_Instruments = new MaterialSkin.Controls.MaterialComboBox();
            this.Btn_Add_Equino = new MaterialSkin.Controls.MaterialButton();
            this.Lbl_Estimate_Date_Return = new MaterialSkin.Controls.MaterialLabel();
            this.Lbl_Date_Of_Return = new MaterialSkin.Controls.MaterialLabel();
            this.DatePicker_DateOfReturn = new System.Windows.Forms.DateTimePicker();
            this.Lbl_Observations = new MaterialSkin.Controls.MaterialLabel();
            this.TxtBox_ObservationReturn = new MaterialSkin.Controls.MaterialTextBox();
            this.Btn_Regist_ReturnOfInstruments = new MaterialSkin.Controls.MaterialButton();
            this.Btn_Delete_Instrument = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // Lbl_Instrument
            // 
            this.Lbl_Instrument.AutoSize = true;
            this.Lbl_Instrument.Depth = 0;
            this.Lbl_Instrument.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Lbl_Instrument.Location = new System.Drawing.Point(27, 89);
            this.Lbl_Instrument.MouseState = MaterialSkin.MouseState.HOVER;
            this.Lbl_Instrument.Name = "Lbl_Instrument";
            this.Lbl_Instrument.Size = new System.Drawing.Size(94, 19);
            this.Lbl_Instrument.TabIndex = 2;
            this.Lbl_Instrument.Text = "Instrumentos";
            // 
            // TxtBox_Instrumenst
            // 
            this.TxtBox_Instrumenst.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtBox_Instrumenst.Depth = 0;
            this.TxtBox_Instrumenst.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TxtBox_Instrumenst.LeadingIcon = null;
            this.TxtBox_Instrumenst.Location = new System.Drawing.Point(30, 132);
            this.TxtBox_Instrumenst.MaxLength = 50;
            this.TxtBox_Instrumenst.MouseState = MaterialSkin.MouseState.OUT;
            this.TxtBox_Instrumenst.Multiline = false;
            this.TxtBox_Instrumenst.Name = "TxtBox_Instrumenst";
            this.TxtBox_Instrumenst.Size = new System.Drawing.Size(413, 50);
            this.TxtBox_Instrumenst.TabIndex = 29;
            this.TxtBox_Instrumenst.Text = "";
            this.TxtBox_Instrumenst.TrailingIcon = null;
            // 
            // ComboBox_Instruments
            // 
            this.ComboBox_Instruments.AutoResize = false;
            this.ComboBox_Instruments.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ComboBox_Instruments.Depth = 0;
            this.ComboBox_Instruments.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.ComboBox_Instruments.DropDownHeight = 174;
            this.ComboBox_Instruments.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBox_Instruments.DropDownWidth = 121;
            this.ComboBox_Instruments.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.ComboBox_Instruments.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ComboBox_Instruments.FormattingEnabled = true;
            this.ComboBox_Instruments.IntegralHeight = false;
            this.ComboBox_Instruments.ItemHeight = 43;
            this.ComboBox_Instruments.Location = new System.Drawing.Point(30, 207);
            this.ComboBox_Instruments.MaxDropDownItems = 4;
            this.ComboBox_Instruments.MouseState = MaterialSkin.MouseState.OUT;
            this.ComboBox_Instruments.Name = "ComboBox_Instruments";
            this.ComboBox_Instruments.Size = new System.Drawing.Size(413, 49);
            this.ComboBox_Instruments.StartIndex = 0;
            this.ComboBox_Instruments.TabIndex = 31;
            // 
            // Btn_Add_Equino
            // 
            this.Btn_Add_Equino.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Btn_Add_Equino.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.Btn_Add_Equino.Depth = 0;
            this.Btn_Add_Equino.HighEmphasis = true;
            this.Btn_Add_Equino.Icon = null;
            this.Btn_Add_Equino.Location = new System.Drawing.Point(30, 280);
            this.Btn_Add_Equino.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Btn_Add_Equino.MouseState = MaterialSkin.MouseState.HOVER;
            this.Btn_Add_Equino.Name = "Btn_Add_Equino";
            this.Btn_Add_Equino.Size = new System.Drawing.Size(194, 36);
            this.Btn_Add_Equino.TabIndex = 32;
            this.Btn_Add_Equino.Text = "Agregar Instrumento";
            this.Btn_Add_Equino.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.Btn_Add_Equino.UseAccentColor = false;
            this.Btn_Add_Equino.UseVisualStyleBackColor = true;
            this.Btn_Add_Equino.Click += new System.EventHandler(this.Btn_Add_Equino_Click);
            // 
            // Lbl_Estimate_Date_Return
            // 
            this.Lbl_Estimate_Date_Return.AutoSize = true;
            this.Lbl_Estimate_Date_Return.Depth = 0;
            this.Lbl_Estimate_Date_Return.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Lbl_Estimate_Date_Return.Location = new System.Drawing.Point(27, 357);
            this.Lbl_Estimate_Date_Return.MouseState = MaterialSkin.MouseState.HOVER;
            this.Lbl_Estimate_Date_Return.Name = "Lbl_Estimate_Date_Return";
            this.Lbl_Estimate_Date_Return.Size = new System.Drawing.Size(221, 19);
            this.Lbl_Estimate_Date_Return.TabIndex = 33;
            this.Lbl_Estimate_Date_Return.Text = "Fecha registrada de devolucion";
            // 
            // Lbl_Date_Of_Return
            // 
            this.Lbl_Date_Of_Return.AutoSize = true;
            this.Lbl_Date_Of_Return.Depth = 0;
            this.Lbl_Date_Of_Return.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Lbl_Date_Of_Return.Location = new System.Drawing.Point(27, 403);
            this.Lbl_Date_Of_Return.MouseState = MaterialSkin.MouseState.HOVER;
            this.Lbl_Date_Of_Return.Name = "Lbl_Date_Of_Return";
            this.Lbl_Date_Of_Return.Size = new System.Drawing.Size(148, 19);
            this.Lbl_Date_Of_Return.TabIndex = 34;
            this.Lbl_Date_Of_Return.Text = "Fecha de Devolucion";
            // 
            // DatePicker_DateOfReturn
            // 
            this.DatePicker_DateOfReturn.Location = new System.Drawing.Point(30, 449);
            this.DatePicker_DateOfReturn.Name = "DatePicker_DateOfReturn";
            this.DatePicker_DateOfReturn.Size = new System.Drawing.Size(308, 20);
            this.DatePicker_DateOfReturn.TabIndex = 35;
            // 
            // Lbl_Observations
            // 
            this.Lbl_Observations.AutoSize = true;
            this.Lbl_Observations.Depth = 0;
            this.Lbl_Observations.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Lbl_Observations.Location = new System.Drawing.Point(527, 89);
            this.Lbl_Observations.MouseState = MaterialSkin.MouseState.HOVER;
            this.Lbl_Observations.Name = "Lbl_Observations";
            this.Lbl_Observations.Size = new System.Drawing.Size(105, 19);
            this.Lbl_Observations.TabIndex = 36;
            this.Lbl_Observations.Text = "Observaciones";
            // 
            // TxtBox_ObservationReturn
            // 
            this.TxtBox_ObservationReturn.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtBox_ObservationReturn.Depth = 0;
            this.TxtBox_ObservationReturn.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TxtBox_ObservationReturn.LeadingIcon = null;
            this.TxtBox_ObservationReturn.Location = new System.Drawing.Point(530, 122);
            this.TxtBox_ObservationReturn.MaxLength = 50;
            this.TxtBox_ObservationReturn.MouseState = MaterialSkin.MouseState.OUT;
            this.TxtBox_ObservationReturn.Multiline = false;
            this.TxtBox_ObservationReturn.Name = "TxtBox_ObservationReturn";
            this.TxtBox_ObservationReturn.Size = new System.Drawing.Size(602, 50);
            this.TxtBox_ObservationReturn.TabIndex = 37;
            this.TxtBox_ObservationReturn.Text = "";
            this.TxtBox_ObservationReturn.TrailingIcon = null;
            // 
            // Btn_Regist_ReturnOfInstruments
            // 
            this.Btn_Regist_ReturnOfInstruments.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Btn_Regist_ReturnOfInstruments.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.Btn_Regist_ReturnOfInstruments.Depth = 0;
            this.Btn_Regist_ReturnOfInstruments.HighEmphasis = true;
            this.Btn_Regist_ReturnOfInstruments.Icon = null;
            this.Btn_Regist_ReturnOfInstruments.Location = new System.Drawing.Point(814, 207);
            this.Btn_Regist_ReturnOfInstruments.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Btn_Regist_ReturnOfInstruments.MouseState = MaterialSkin.MouseState.HOVER;
            this.Btn_Regist_ReturnOfInstruments.Name = "Btn_Regist_ReturnOfInstruments";
            this.Btn_Regist_ReturnOfInstruments.Size = new System.Drawing.Size(318, 36);
            this.Btn_Regist_ReturnOfInstruments.TabIndex = 38;
            this.Btn_Regist_ReturnOfInstruments.Text = "Registrar Informacion de Devolucion";
            this.Btn_Regist_ReturnOfInstruments.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.Btn_Regist_ReturnOfInstruments.UseAccentColor = false;
            this.Btn_Regist_ReturnOfInstruments.UseVisualStyleBackColor = true;
            this.Btn_Regist_ReturnOfInstruments.Click += new System.EventHandler(this.Btn_Regist_ReturnOfInstruments_Click);
            // 
            // Btn_Delete_Instrument
            // 
            this.Btn_Delete_Instrument.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Btn_Delete_Instrument.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.Btn_Delete_Instrument.Depth = 0;
            this.Btn_Delete_Instrument.HighEmphasis = true;
            this.Btn_Delete_Instrument.Icon = null;
            this.Btn_Delete_Instrument.Location = new System.Drawing.Point(249, 280);
            this.Btn_Delete_Instrument.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Btn_Delete_Instrument.MouseState = MaterialSkin.MouseState.HOVER;
            this.Btn_Delete_Instrument.Name = "Btn_Delete_Instrument";
            this.Btn_Delete_Instrument.Size = new System.Drawing.Size(194, 36);
            this.Btn_Delete_Instrument.TabIndex = 39;
            this.Btn_Delete_Instrument.Text = "Eliminar Instrumento";
            this.Btn_Delete_Instrument.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.Btn_Delete_Instrument.UseAccentColor = false;
            this.Btn_Delete_Instrument.UseVisualStyleBackColor = true;
            this.Btn_Delete_Instrument.Click += new System.EventHandler(this.Btn_Delete_Instrument_Click);
            // 
            // Add_Return_Instrument_ByGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1151, 515);
            this.Controls.Add(this.Btn_Delete_Instrument);
            this.Controls.Add(this.Btn_Regist_ReturnOfInstruments);
            this.Controls.Add(this.TxtBox_ObservationReturn);
            this.Controls.Add(this.Lbl_Observations);
            this.Controls.Add(this.DatePicker_DateOfReturn);
            this.Controls.Add(this.Lbl_Date_Of_Return);
            this.Controls.Add(this.Lbl_Estimate_Date_Return);
            this.Controls.Add(this.Btn_Add_Equino);
            this.Controls.Add(this.ComboBox_Instruments);
            this.Controls.Add(this.TxtBox_Instrumenst);
            this.Controls.Add(this.Lbl_Instrument);
            this.Name = "Add_Return_Instrument_ByGroup";
            this.Text = "Entrega de Instrumento por Grupo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel Lbl_Instrument;
        private MaterialSkin.Controls.MaterialTextBox TxtBox_Instrumenst;
        private MaterialSkin.Controls.MaterialComboBox ComboBox_Instruments;
        private MaterialSkin.Controls.MaterialButton Btn_Add_Equino;
        private MaterialSkin.Controls.MaterialLabel Lbl_Estimate_Date_Return;
        private MaterialSkin.Controls.MaterialLabel Lbl_Date_Of_Return;
        private System.Windows.Forms.DateTimePicker DatePicker_DateOfReturn;
        private MaterialSkin.Controls.MaterialLabel Lbl_Observations;
        private MaterialSkin.Controls.MaterialTextBox TxtBox_ObservationReturn;
        private MaterialSkin.Controls.MaterialButton Btn_Regist_ReturnOfInstruments;
        private MaterialSkin.Controls.MaterialButton Btn_Delete_Instrument;
    }
}