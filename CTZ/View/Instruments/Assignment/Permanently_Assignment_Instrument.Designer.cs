namespace CTZ.View.Instruments.Assignment
{
    partial class Permanently_Assignment_Instrument
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
            this.MaterialComboBox_Engineers = new MaterialSkin.Controls.MaterialComboBox();
            this.Lbl_Observation_Delivery = new MaterialSkin.Controls.MaterialLabel();
            this.TxtBox_ObservationDelivery = new MaterialSkin.Controls.MaterialTextBox();
            this.Btn_AddEnginnerSignature = new MaterialSkin.Controls.MaterialButton();
            this.Btn_Add_Assignment = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // Lbl_Instrument
            // 
            this.Lbl_Instrument.AutoSize = true;
            this.Lbl_Instrument.Depth = 0;
            this.Lbl_Instrument.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Lbl_Instrument.Location = new System.Drawing.Point(43, 94);
            this.Lbl_Instrument.MouseState = MaterialSkin.MouseState.HOVER;
            this.Lbl_Instrument.Name = "Lbl_Instrument";
            this.Lbl_Instrument.Size = new System.Drawing.Size(86, 19);
            this.Lbl_Instrument.TabIndex = 2;
            this.Lbl_Instrument.Text = "Instrumento";
            // 
            // Lbl_Date_Delivery
            // 
            this.Lbl_Date_Delivery.AutoSize = true;
            this.Lbl_Date_Delivery.Depth = 0;
            this.Lbl_Date_Delivery.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Lbl_Date_Delivery.Location = new System.Drawing.Point(43, 147);
            this.Lbl_Date_Delivery.MouseState = MaterialSkin.MouseState.HOVER;
            this.Lbl_Date_Delivery.Name = "Lbl_Date_Delivery";
            this.Lbl_Date_Delivery.Size = new System.Drawing.Size(235, 19);
            this.Lbl_Date_Delivery.TabIndex = 30;
            this.Lbl_Date_Delivery.Text = "Fecha De Entrega de Instrumento";
            // 
            // TimePicker_Date_Delivery
            // 
            this.TimePicker_Date_Delivery.Location = new System.Drawing.Point(46, 195);
            this.TimePicker_Date_Delivery.Name = "TimePicker_Date_Delivery";
            this.TimePicker_Date_Delivery.Size = new System.Drawing.Size(340, 20);
            this.TimePicker_Date_Delivery.TabIndex = 31;
            // 
            // Lbl_Enginner
            // 
            this.Lbl_Enginner.AutoSize = true;
            this.Lbl_Enginner.Depth = 0;
            this.Lbl_Enginner.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Lbl_Enginner.Location = new System.Drawing.Point(43, 244);
            this.Lbl_Enginner.MouseState = MaterialSkin.MouseState.HOVER;
            this.Lbl_Enginner.Name = "Lbl_Enginner";
            this.Lbl_Enginner.Size = new System.Drawing.Size(66, 19);
            this.Lbl_Enginner.TabIndex = 32;
            this.Lbl_Enginner.Text = "Ingeniero";
            // 
            // MaterialComboBox_Engineers
            // 
            this.MaterialComboBox_Engineers.AutoResize = false;
            this.MaterialComboBox_Engineers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.MaterialComboBox_Engineers.Depth = 0;
            this.MaterialComboBox_Engineers.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.MaterialComboBox_Engineers.DropDownHeight = 174;
            this.MaterialComboBox_Engineers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MaterialComboBox_Engineers.DropDownWidth = 121;
            this.MaterialComboBox_Engineers.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.MaterialComboBox_Engineers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.MaterialComboBox_Engineers.FormattingEnabled = true;
            this.MaterialComboBox_Engineers.IntegralHeight = false;
            this.MaterialComboBox_Engineers.ItemHeight = 43;
            this.MaterialComboBox_Engineers.Location = new System.Drawing.Point(46, 277);
            this.MaterialComboBox_Engineers.MaxDropDownItems = 4;
            this.MaterialComboBox_Engineers.MouseState = MaterialSkin.MouseState.OUT;
            this.MaterialComboBox_Engineers.Name = "MaterialComboBox_Engineers";
            this.MaterialComboBox_Engineers.Size = new System.Drawing.Size(340, 49);
            this.MaterialComboBox_Engineers.StartIndex = 0;
            this.MaterialComboBox_Engineers.TabIndex = 33;
            // 
            // Lbl_Observation_Delivery
            // 
            this.Lbl_Observation_Delivery.AutoSize = true;
            this.Lbl_Observation_Delivery.Depth = 0;
            this.Lbl_Observation_Delivery.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Lbl_Observation_Delivery.Location = new System.Drawing.Point(432, 94);
            this.Lbl_Observation_Delivery.MouseState = MaterialSkin.MouseState.HOVER;
            this.Lbl_Observation_Delivery.Name = "Lbl_Observation_Delivery";
            this.Lbl_Observation_Delivery.Size = new System.Drawing.Size(163, 19);
            this.Lbl_Observation_Delivery.TabIndex = 34;
            this.Lbl_Observation_Delivery.Text = "Observaciones Entrega";
            // 
            // TxtBox_ObservationDelivery
            // 
            this.TxtBox_ObservationDelivery.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtBox_ObservationDelivery.Depth = 0;
            this.TxtBox_ObservationDelivery.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TxtBox_ObservationDelivery.LeadingIcon = null;
            this.TxtBox_ObservationDelivery.Location = new System.Drawing.Point(435, 144);
            this.TxtBox_ObservationDelivery.MaxLength = 50;
            this.TxtBox_ObservationDelivery.MouseState = MaterialSkin.MouseState.OUT;
            this.TxtBox_ObservationDelivery.Multiline = false;
            this.TxtBox_ObservationDelivery.Name = "TxtBox_ObservationDelivery";
            this.TxtBox_ObservationDelivery.Size = new System.Drawing.Size(380, 50);
            this.TxtBox_ObservationDelivery.TabIndex = 35;
            this.TxtBox_ObservationDelivery.Text = "";
            this.TxtBox_ObservationDelivery.TrailingIcon = null;
            // 
            // Btn_AddEnginnerSignature
            // 
            this.Btn_AddEnginnerSignature.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Btn_AddEnginnerSignature.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.Btn_AddEnginnerSignature.Depth = 0;
            this.Btn_AddEnginnerSignature.HighEmphasis = true;
            this.Btn_AddEnginnerSignature.Icon = null;
            this.Btn_AddEnginnerSignature.Location = new System.Drawing.Point(578, 255);
            this.Btn_AddEnginnerSignature.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Btn_AddEnginnerSignature.MouseState = MaterialSkin.MouseState.HOVER;
            this.Btn_AddEnginnerSignature.Name = "Btn_AddEnginnerSignature";
            this.Btn_AddEnginnerSignature.Size = new System.Drawing.Size(237, 36);
            this.Btn_AddEnginnerSignature.TabIndex = 36;
            this.Btn_AddEnginnerSignature.Text = "Agregar Firma de Ingeniero";
            this.Btn_AddEnginnerSignature.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.Btn_AddEnginnerSignature.UseAccentColor = false;
            this.Btn_AddEnginnerSignature.UseVisualStyleBackColor = true;
            this.Btn_AddEnginnerSignature.Click += new System.EventHandler(this.Btn_AddEnginnerSignature_Click);
            // 
            // Btn_Add_Assignment
            // 
            this.Btn_Add_Assignment.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Btn_Add_Assignment.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.Btn_Add_Assignment.Depth = 0;
            this.Btn_Add_Assignment.HighEmphasis = true;
            this.Btn_Add_Assignment.Icon = null;
            this.Btn_Add_Assignment.Location = new System.Drawing.Point(621, 341);
            this.Btn_Add_Assignment.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Btn_Add_Assignment.MouseState = MaterialSkin.MouseState.HOVER;
            this.Btn_Add_Assignment.Name = "Btn_Add_Assignment";
            this.Btn_Add_Assignment.Size = new System.Drawing.Size(194, 36);
            this.Btn_Add_Assignment.TabIndex = 37;
            this.Btn_Add_Assignment.Text = "Agregar Instrumento";
            this.Btn_Add_Assignment.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.Btn_Add_Assignment.UseAccentColor = false;
            this.Btn_Add_Assignment.UseVisualStyleBackColor = true;
            this.Btn_Add_Assignment.Click += new System.EventHandler(this.Btn_Add_Assignment_Click);
            // 
            // Permanently_Assignment_Instrument
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 443);
            this.Controls.Add(this.Btn_Add_Assignment);
            this.Controls.Add(this.Btn_AddEnginnerSignature);
            this.Controls.Add(this.TxtBox_ObservationDelivery);
            this.Controls.Add(this.Lbl_Observation_Delivery);
            this.Controls.Add(this.MaterialComboBox_Engineers);
            this.Controls.Add(this.Lbl_Enginner);
            this.Controls.Add(this.TimePicker_Date_Delivery);
            this.Controls.Add(this.Lbl_Date_Delivery);
            this.Controls.Add(this.Lbl_Instrument);
            this.Name = "Permanently_Assignment_Instrument";
            this.Text = "Asignacion permanente de instrumento";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel Lbl_Instrument;
        private MaterialSkin.Controls.MaterialLabel Lbl_Date_Delivery;
        private System.Windows.Forms.DateTimePicker TimePicker_Date_Delivery;
        private MaterialSkin.Controls.MaterialLabel Lbl_Enginner;
        private MaterialSkin.Controls.MaterialComboBox MaterialComboBox_Engineers;
        private MaterialSkin.Controls.MaterialLabel Lbl_Observation_Delivery;
        private MaterialSkin.Controls.MaterialTextBox TxtBox_ObservationDelivery;
        private MaterialSkin.Controls.MaterialButton Btn_AddEnginnerSignature;
        private MaterialSkin.Controls.MaterialButton Btn_Add_Assignment;
    }
}