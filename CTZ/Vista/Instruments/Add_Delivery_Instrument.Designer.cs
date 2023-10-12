﻿namespace CTZ.Vista.Instruments
{
    partial class Add_Delivery_Instrument
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
            this.Lbl_Date_Delivery = new MaterialSkin.Controls.MaterialLabel();
            this.TimePicker_Date_Delivery = new System.Windows.Forms.DateTimePicker();
            this.Lbl_Enginner = new MaterialSkin.Controls.MaterialLabel();
            this.ListBoxEngineers = new MaterialSkin.Controls.MaterialListBox();
            this.Lbl_Number_Enterprise = new MaterialSkin.Controls.MaterialLabel();
            this.TxtBox_Enterprise = new MaterialSkin.Controls.MaterialTextBox();
            this.Lbl_Name_Enterprise = new MaterialSkin.Controls.MaterialLabel();
            this.TxtBox_NameEnterprise = new MaterialSkin.Controls.MaterialTextBox();
            this.Lbl_Observation_Delivery = new MaterialSkin.Controls.MaterialLabel();
            this.TxtBox_ObservationDelivery = new MaterialSkin.Controls.MaterialTextBox();
            this.Lbl_Estimate_Date_Return = new MaterialSkin.Controls.MaterialLabel();
            this.TimePicker_Date_Estimate_Return = new System.Windows.Forms.DateTimePicker();
            this.Btn_Add_Delivery = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // Lbl_Instrument
            // 
            this.Lbl_Instrument.AutoSize = true;
            this.Lbl_Instrument.Depth = 0;
            this.Lbl_Instrument.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Lbl_Instrument.Location = new System.Drawing.Point(43, 84);
            this.Lbl_Instrument.MouseState = MaterialSkin.MouseState.HOVER;
            this.Lbl_Instrument.Name = "Lbl_Instrument";
            this.Lbl_Instrument.Size = new System.Drawing.Size(86, 19);
            this.Lbl_Instrument.TabIndex = 0;
            this.Lbl_Instrument.Text = "Instrumento";
            // 
            // Lbl_Date_Delivery
            // 
            this.Lbl_Date_Delivery.AutoSize = true;
            this.Lbl_Date_Delivery.Depth = 0;
            this.Lbl_Date_Delivery.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Lbl_Date_Delivery.Location = new System.Drawing.Point(43, 122);
            this.Lbl_Date_Delivery.MouseState = MaterialSkin.MouseState.HOVER;
            this.Lbl_Date_Delivery.Name = "Lbl_Date_Delivery";
            this.Lbl_Date_Delivery.Size = new System.Drawing.Size(235, 19);
            this.Lbl_Date_Delivery.TabIndex = 1;
            this.Lbl_Date_Delivery.Text = "Fecha De Entrega de Instrumento";
            // 
            // TimePicker_Date_Delivery
            // 
            this.TimePicker_Date_Delivery.Location = new System.Drawing.Point(46, 162);
            this.TimePicker_Date_Delivery.Name = "TimePicker_Date_Delivery";
            this.TimePicker_Date_Delivery.Size = new System.Drawing.Size(329, 20);
            this.TimePicker_Date_Delivery.TabIndex = 2;
            // 
            // Lbl_Enginner
            // 
            this.Lbl_Enginner.AutoSize = true;
            this.Lbl_Enginner.Depth = 0;
            this.Lbl_Enginner.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Lbl_Enginner.Location = new System.Drawing.Point(43, 204);
            this.Lbl_Enginner.MouseState = MaterialSkin.MouseState.HOVER;
            this.Lbl_Enginner.Name = "Lbl_Enginner";
            this.Lbl_Enginner.Size = new System.Drawing.Size(66, 19);
            this.Lbl_Enginner.TabIndex = 3;
            this.Lbl_Enginner.Text = "Ingeniero";
            // 
            // ListBoxEngineers
            // 
            this.ListBoxEngineers.BackColor = System.Drawing.Color.White;
            this.ListBoxEngineers.BorderColor = System.Drawing.Color.LightGray;
            this.ListBoxEngineers.Depth = 0;
            this.ListBoxEngineers.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ListBoxEngineers.Location = new System.Drawing.Point(46, 246);
            this.ListBoxEngineers.MouseState = MaterialSkin.MouseState.HOVER;
            this.ListBoxEngineers.Name = "ListBoxEngineers";
            this.ListBoxEngineers.SelectedIndex = -1;
            this.ListBoxEngineers.SelectedItem = null;
            this.ListBoxEngineers.Size = new System.Drawing.Size(329, 23);
            this.ListBoxEngineers.TabIndex = 5;
            // 
            // Lbl_Number_Enterprise
            // 
            this.Lbl_Number_Enterprise.AutoSize = true;
            this.Lbl_Number_Enterprise.Depth = 0;
            this.Lbl_Number_Enterprise.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Lbl_Number_Enterprise.Location = new System.Drawing.Point(46, 297);
            this.Lbl_Number_Enterprise.MouseState = MaterialSkin.MouseState.HOVER;
            this.Lbl_Number_Enterprise.Name = "Lbl_Number_Enterprise";
            this.Lbl_Number_Enterprise.Size = new System.Drawing.Size(125, 19);
            this.Lbl_Number_Enterprise.TabIndex = 6;
            this.Lbl_Number_Enterprise.Text = "Folio De Empresa";
            // 
            // TxtBox_Enterprise
            // 
            this.TxtBox_Enterprise.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtBox_Enterprise.Depth = 0;
            this.TxtBox_Enterprise.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TxtBox_Enterprise.LeadingIcon = null;
            this.TxtBox_Enterprise.Location = new System.Drawing.Point(46, 336);
            this.TxtBox_Enterprise.MaxLength = 50;
            this.TxtBox_Enterprise.MouseState = MaterialSkin.MouseState.OUT;
            this.TxtBox_Enterprise.Multiline = false;
            this.TxtBox_Enterprise.Name = "TxtBox_Enterprise";
            this.TxtBox_Enterprise.Size = new System.Drawing.Size(329, 50);
            this.TxtBox_Enterprise.TabIndex = 7;
            this.TxtBox_Enterprise.Text = "";
            this.TxtBox_Enterprise.TrailingIcon = null;
            // 
            // Lbl_Name_Enterprise
            // 
            this.Lbl_Name_Enterprise.AutoSize = true;
            this.Lbl_Name_Enterprise.Depth = 0;
            this.Lbl_Name_Enterprise.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Lbl_Name_Enterprise.Location = new System.Drawing.Point(46, 407);
            this.Lbl_Name_Enterprise.MouseState = MaterialSkin.MouseState.HOVER;
            this.Lbl_Name_Enterprise.Name = "Lbl_Name_Enterprise";
            this.Lbl_Name_Enterprise.Size = new System.Drawing.Size(127, 19);
            this.Lbl_Name_Enterprise.TabIndex = 8;
            this.Lbl_Name_Enterprise.Text = "Nombre  Empresa";
            // 
            // TxtBox_NameEnterprise
            // 
            this.TxtBox_NameEnterprise.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtBox_NameEnterprise.Depth = 0;
            this.TxtBox_NameEnterprise.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TxtBox_NameEnterprise.LeadingIcon = null;
            this.TxtBox_NameEnterprise.Location = new System.Drawing.Point(46, 429);
            this.TxtBox_NameEnterprise.MaxLength = 50;
            this.TxtBox_NameEnterprise.MouseState = MaterialSkin.MouseState.OUT;
            this.TxtBox_NameEnterprise.Multiline = false;
            this.TxtBox_NameEnterprise.Name = "TxtBox_NameEnterprise";
            this.TxtBox_NameEnterprise.Size = new System.Drawing.Size(329, 50);
            this.TxtBox_NameEnterprise.TabIndex = 9;
            this.TxtBox_NameEnterprise.Text = "";
            this.TxtBox_NameEnterprise.TrailingIcon = null;
            // 
            // Lbl_Observation_Delivery
            // 
            this.Lbl_Observation_Delivery.AutoSize = true;
            this.Lbl_Observation_Delivery.Depth = 0;
            this.Lbl_Observation_Delivery.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Lbl_Observation_Delivery.Location = new System.Drawing.Point(43, 498);
            this.Lbl_Observation_Delivery.MouseState = MaterialSkin.MouseState.HOVER;
            this.Lbl_Observation_Delivery.Name = "Lbl_Observation_Delivery";
            this.Lbl_Observation_Delivery.Size = new System.Drawing.Size(163, 19);
            this.Lbl_Observation_Delivery.TabIndex = 10;
            this.Lbl_Observation_Delivery.Text = "Observaciones Entrega";
            // 
            // TxtBox_ObservationDelivery
            // 
            this.TxtBox_ObservationDelivery.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtBox_ObservationDelivery.Depth = 0;
            this.TxtBox_ObservationDelivery.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TxtBox_ObservationDelivery.LeadingIcon = null;
            this.TxtBox_ObservationDelivery.Location = new System.Drawing.Point(46, 532);
            this.TxtBox_ObservationDelivery.MaxLength = 50;
            this.TxtBox_ObservationDelivery.MouseState = MaterialSkin.MouseState.OUT;
            this.TxtBox_ObservationDelivery.Multiline = false;
            this.TxtBox_ObservationDelivery.Name = "TxtBox_ObservationDelivery";
            this.TxtBox_ObservationDelivery.Size = new System.Drawing.Size(316, 50);
            this.TxtBox_ObservationDelivery.TabIndex = 11;
            this.TxtBox_ObservationDelivery.Text = "";
            this.TxtBox_ObservationDelivery.TrailingIcon = null;
            // 
            // Lbl_Estimate_Date_Return
            // 
            this.Lbl_Estimate_Date_Return.AutoSize = true;
            this.Lbl_Estimate_Date_Return.Depth = 0;
            this.Lbl_Estimate_Date_Return.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Lbl_Estimate_Date_Return.Location = new System.Drawing.Point(413, 94);
            this.Lbl_Estimate_Date_Return.MouseState = MaterialSkin.MouseState.HOVER;
            this.Lbl_Estimate_Date_Return.Name = "Lbl_Estimate_Date_Return";
            this.Lbl_Estimate_Date_Return.Size = new System.Drawing.Size(219, 19);
            this.Lbl_Estimate_Date_Return.TabIndex = 15;
            this.Lbl_Estimate_Date_Return.Text = "Fecha Estimada de Devolucion";
            // 
            // TimePicker_Date_Estimate_Return
            // 
            this.TimePicker_Date_Estimate_Return.Location = new System.Drawing.Point(416, 131);
            this.TimePicker_Date_Estimate_Return.Name = "TimePicker_Date_Estimate_Return";
            this.TimePicker_Date_Estimate_Return.Size = new System.Drawing.Size(237, 20);
            this.TimePicker_Date_Estimate_Return.TabIndex = 16;
            // 
            // Btn_Add_Delivery
            // 
            this.Btn_Add_Delivery.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Btn_Add_Delivery.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.Btn_Add_Delivery.Depth = 0;
            this.Btn_Add_Delivery.HighEmphasis = true;
            this.Btn_Add_Delivery.Icon = null;
            this.Btn_Add_Delivery.Location = new System.Drawing.Point(424, 546);
            this.Btn_Add_Delivery.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Btn_Add_Delivery.MouseState = MaterialSkin.MouseState.HOVER;
            this.Btn_Add_Delivery.Name = "Btn_Add_Delivery";
            this.Btn_Add_Delivery.Size = new System.Drawing.Size(229, 36);
            this.Btn_Add_Delivery.TabIndex = 17;
            this.Btn_Add_Delivery.Text = "Agregar Datos de Entrega";
            this.Btn_Add_Delivery.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.Btn_Add_Delivery.UseAccentColor = false;
            this.Btn_Add_Delivery.UseVisualStyleBackColor = true;
            this.Btn_Add_Delivery.Click += new System.EventHandler(this.Btn_Add_Delivery_Click);
            // 
            // Add_Delivery_Instrument
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 617);
            this.Controls.Add(this.Btn_Add_Delivery);
            this.Controls.Add(this.TimePicker_Date_Estimate_Return);
            this.Controls.Add(this.Lbl_Estimate_Date_Return);
            this.Controls.Add(this.TxtBox_ObservationDelivery);
            this.Controls.Add(this.Lbl_Observation_Delivery);
            this.Controls.Add(this.TxtBox_NameEnterprise);
            this.Controls.Add(this.Lbl_Name_Enterprise);
            this.Controls.Add(this.TxtBox_Enterprise);
            this.Controls.Add(this.Lbl_Number_Enterprise);
            this.Controls.Add(this.ListBoxEngineers);
            this.Controls.Add(this.Lbl_Enginner);
            this.Controls.Add(this.TimePicker_Date_Delivery);
            this.Controls.Add(this.Lbl_Date_Delivery);
            this.Controls.Add(this.Lbl_Instrument);
            this.Name = "Add_Delivery_Instrument";
            this.Text = "Registrar Entrega de Instrumento";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel Lbl_Instrument;
        private MaterialSkin.Controls.MaterialLabel Lbl_Date_Delivery;
        private System.Windows.Forms.DateTimePicker TimePicker_Date_Delivery;
        private MaterialSkin.Controls.MaterialLabel Lbl_Enginner;
        private MaterialSkin.Controls.MaterialListBox ListBoxEngineers;
        private MaterialSkin.Controls.MaterialLabel Lbl_Number_Enterprise;
        private MaterialSkin.Controls.MaterialTextBox TxtBox_Enterprise;
        private MaterialSkin.Controls.MaterialLabel Lbl_Name_Enterprise;
        private MaterialSkin.Controls.MaterialTextBox TxtBox_NameEnterprise;
        private MaterialSkin.Controls.MaterialLabel Lbl_Observation_Delivery;
        private MaterialSkin.Controls.MaterialTextBox TxtBox_ObservationDelivery;
        private MaterialSkin.Controls.MaterialLabel Lbl_Estimate_Date_Return;
        private System.Windows.Forms.DateTimePicker TimePicker_Date_Estimate_Return;
        private MaterialSkin.Controls.MaterialButton Btn_Add_Delivery;
    }
}