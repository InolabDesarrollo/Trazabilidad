namespace CTZ.View.Estandard.Assignment
{
    partial class Permanent_Assignment
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
            this.Lbl_Estandard = new MaterialSkin.Controls.MaterialLabel();
            this.Lbl_Date_Delivery = new MaterialSkin.Controls.MaterialLabel();
            this.Lbl_Enginner = new MaterialSkin.Controls.MaterialLabel();
            this.ComboBox_Engineers = new MaterialSkin.Controls.MaterialComboBox();
            this.TimePicker_Date_Delivery = new System.Windows.Forms.DateTimePicker();
            this.Lbl_Observation_Delivery = new MaterialSkin.Controls.MaterialLabel();
            this.TxtBox_ObservationDelivery = new MaterialSkin.Controls.MaterialTextBox();
            this.Btn_RegistEnginnerSignature = new MaterialSkin.Controls.MaterialButton();
            this.Btn_Add_DeliveryPermanently = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // Lbl_Estandard
            // 
            this.Lbl_Estandard.AutoSize = true;
            this.Lbl_Estandard.Depth = 0;
            this.Lbl_Estandard.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Lbl_Estandard.Location = new System.Drawing.Point(30, 94);
            this.Lbl_Estandard.MouseState = MaterialSkin.MouseState.HOVER;
            this.Lbl_Estandard.Name = "Lbl_Estandard";
            this.Lbl_Estandard.Size = new System.Drawing.Size(64, 19);
            this.Lbl_Estandard.TabIndex = 1;
            this.Lbl_Estandard.Text = "Estándar";
            // 
            // Lbl_Date_Delivery
            // 
            this.Lbl_Date_Delivery.AutoSize = true;
            this.Lbl_Date_Delivery.Depth = 0;
            this.Lbl_Date_Delivery.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Lbl_Date_Delivery.Location = new System.Drawing.Point(30, 141);
            this.Lbl_Date_Delivery.MouseState = MaterialSkin.MouseState.HOVER;
            this.Lbl_Date_Delivery.Name = "Lbl_Date_Delivery";
            this.Lbl_Date_Delivery.Size = new System.Drawing.Size(199, 19);
            this.Lbl_Date_Delivery.TabIndex = 3;
            this.Lbl_Date_Delivery.Text = "Fecha Entrega de Estandard";
            // 
            // Lbl_Enginner
            // 
            this.Lbl_Enginner.AutoSize = true;
            this.Lbl_Enginner.Depth = 0;
            this.Lbl_Enginner.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Lbl_Enginner.Location = new System.Drawing.Point(30, 243);
            this.Lbl_Enginner.MouseState = MaterialSkin.MouseState.HOVER;
            this.Lbl_Enginner.Name = "Lbl_Enginner";
            this.Lbl_Enginner.Size = new System.Drawing.Size(66, 19);
            this.Lbl_Enginner.TabIndex = 5;
            this.Lbl_Enginner.Text = "Ingeniero";
            // 
            // ComboBox_Engineers
            // 
            this.ComboBox_Engineers.AutoResize = false;
            this.ComboBox_Engineers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ComboBox_Engineers.Depth = 0;
            this.ComboBox_Engineers.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.ComboBox_Engineers.DropDownHeight = 174;
            this.ComboBox_Engineers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBox_Engineers.DropDownWidth = 121;
            this.ComboBox_Engineers.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.ComboBox_Engineers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ComboBox_Engineers.FormattingEnabled = true;
            this.ComboBox_Engineers.IntegralHeight = false;
            this.ComboBox_Engineers.ItemHeight = 43;
            this.ComboBox_Engineers.Location = new System.Drawing.Point(33, 282);
            this.ComboBox_Engineers.MaxDropDownItems = 4;
            this.ComboBox_Engineers.MouseState = MaterialSkin.MouseState.OUT;
            this.ComboBox_Engineers.Name = "ComboBox_Engineers";
            this.ComboBox_Engineers.Size = new System.Drawing.Size(329, 49);
            this.ComboBox_Engineers.StartIndex = 0;
            this.ComboBox_Engineers.TabIndex = 20;
            // 
            // TimePicker_Date_Delivery
            // 
            this.TimePicker_Date_Delivery.Location = new System.Drawing.Point(33, 197);
            this.TimePicker_Date_Delivery.Name = "TimePicker_Date_Delivery";
            this.TimePicker_Date_Delivery.Size = new System.Drawing.Size(329, 20);
            this.TimePicker_Date_Delivery.TabIndex = 21;
            // 
            // Lbl_Observation_Delivery
            // 
            this.Lbl_Observation_Delivery.AutoSize = true;
            this.Lbl_Observation_Delivery.Depth = 0;
            this.Lbl_Observation_Delivery.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Lbl_Observation_Delivery.Location = new System.Drawing.Point(440, 94);
            this.Lbl_Observation_Delivery.MouseState = MaterialSkin.MouseState.HOVER;
            this.Lbl_Observation_Delivery.Name = "Lbl_Observation_Delivery";
            this.Lbl_Observation_Delivery.Size = new System.Drawing.Size(163, 19);
            this.Lbl_Observation_Delivery.TabIndex = 25;
            this.Lbl_Observation_Delivery.Text = "Observaciones Entrega";
            // 
            // TxtBox_ObservationDelivery
            // 
            this.TxtBox_ObservationDelivery.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtBox_ObservationDelivery.Depth = 0;
            this.TxtBox_ObservationDelivery.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TxtBox_ObservationDelivery.LeadingIcon = null;
            this.TxtBox_ObservationDelivery.Location = new System.Drawing.Point(443, 167);
            this.TxtBox_ObservationDelivery.MaxLength = 50;
            this.TxtBox_ObservationDelivery.MouseState = MaterialSkin.MouseState.OUT;
            this.TxtBox_ObservationDelivery.Multiline = false;
            this.TxtBox_ObservationDelivery.Name = "TxtBox_ObservationDelivery";
            this.TxtBox_ObservationDelivery.Size = new System.Drawing.Size(374, 50);
            this.TxtBox_ObservationDelivery.TabIndex = 26;
            this.TxtBox_ObservationDelivery.Text = "";
            this.TxtBox_ObservationDelivery.TrailingIcon = null;
            // 
            // Btn_RegistEnginnerSignature
            // 
            this.Btn_RegistEnginnerSignature.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Btn_RegistEnginnerSignature.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.Btn_RegistEnginnerSignature.Depth = 0;
            this.Btn_RegistEnginnerSignature.HighEmphasis = true;
            this.Btn_RegistEnginnerSignature.Icon = null;
            this.Btn_RegistEnginnerSignature.Location = new System.Drawing.Point(569, 320);
            this.Btn_RegistEnginnerSignature.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Btn_RegistEnginnerSignature.MouseState = MaterialSkin.MouseState.HOVER;
            this.Btn_RegistEnginnerSignature.Name = "Btn_RegistEnginnerSignature";
            this.Btn_RegistEnginnerSignature.Size = new System.Drawing.Size(248, 36);
            this.Btn_RegistEnginnerSignature.TabIndex = 35;
            this.Btn_RegistEnginnerSignature.Text = "Registrar firma de Ingeniero";
            this.Btn_RegistEnginnerSignature.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.Btn_RegistEnginnerSignature.UseAccentColor = false;
            this.Btn_RegistEnginnerSignature.UseVisualStyleBackColor = true;
            this.Btn_RegistEnginnerSignature.Click += new System.EventHandler(this.Btn_RegistEnginnerSignature_Click);
            // 
            // Btn_Add_DeliveryPermanently
            // 
            this.Btn_Add_DeliveryPermanently.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Btn_Add_DeliveryPermanently.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.Btn_Add_DeliveryPermanently.Depth = 0;
            this.Btn_Add_DeliveryPermanently.HighEmphasis = true;
            this.Btn_Add_DeliveryPermanently.Icon = null;
            this.Btn_Add_DeliveryPermanently.Location = new System.Drawing.Point(588, 405);
            this.Btn_Add_DeliveryPermanently.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Btn_Add_DeliveryPermanently.MouseState = MaterialSkin.MouseState.HOVER;
            this.Btn_Add_DeliveryPermanently.Name = "Btn_Add_DeliveryPermanently";
            this.Btn_Add_DeliveryPermanently.Size = new System.Drawing.Size(229, 36);
            this.Btn_Add_DeliveryPermanently.TabIndex = 36;
            this.Btn_Add_DeliveryPermanently.Text = "Agregar Datos de Entrega";
            this.Btn_Add_DeliveryPermanently.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.Btn_Add_DeliveryPermanently.UseAccentColor = false;
            this.Btn_Add_DeliveryPermanently.UseVisualStyleBackColor = true;
            this.Btn_Add_DeliveryPermanently.Click += new System.EventHandler(this.Btn_Add_DeliveryPermanently_Click);
            // 
            // Permanent_Assignment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 491);
            this.Controls.Add(this.Btn_Add_DeliveryPermanently);
            this.Controls.Add(this.Btn_RegistEnginnerSignature);
            this.Controls.Add(this.TxtBox_ObservationDelivery);
            this.Controls.Add(this.Lbl_Observation_Delivery);
            this.Controls.Add(this.TimePicker_Date_Delivery);
            this.Controls.Add(this.ComboBox_Engineers);
            this.Controls.Add(this.Lbl_Enginner);
            this.Controls.Add(this.Lbl_Date_Delivery);
            this.Controls.Add(this.Lbl_Estandard);
            this.Name = "Permanent_Assignment";
            this.Text = "Asignacion Permanente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel Lbl_Estandard;
        private MaterialSkin.Controls.MaterialLabel Lbl_Date_Delivery;
        private MaterialSkin.Controls.MaterialLabel Lbl_Enginner;
        private MaterialSkin.Controls.MaterialComboBox ComboBox_Engineers;
        private System.Windows.Forms.DateTimePicker TimePicker_Date_Delivery;
        private MaterialSkin.Controls.MaterialLabel Lbl_Observation_Delivery;
        private MaterialSkin.Controls.MaterialTextBox TxtBox_ObservationDelivery;
        private MaterialSkin.Controls.MaterialButton Btn_RegistEnginnerSignature;
        private MaterialSkin.Controls.MaterialButton Btn_Add_DeliveryPermanently;
    }
}