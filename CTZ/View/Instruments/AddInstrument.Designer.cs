namespace CTZ.Vista.Responsabilitis
{
    partial class AddInstrument
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
            this.Btn_Add_Instrument = new MaterialSkin.Controls.MaterialButton();
            this.materialContextMenuStrip1 = new MaterialSkin.Controls.MaterialContextMenuStrip();
            this.TxtBox_Id = new MaterialSkin.Controls.MaterialTextBox();
            this.TxBox_Brand = new MaterialSkin.Controls.MaterialTextBox();
            this.TxtBox_Model = new MaterialSkin.Controls.MaterialTextBox();
            this.TxtBox_NumSerie = new MaterialSkin.Controls.MaterialTextBox();
            this.TxtBox_Observation = new MaterialSkin.Controls.MaterialTextBox();
            this.TxtBox_Instrument = new MaterialSkin.Controls.MaterialTextBox();
            this.ComboBox_Status = new MaterialSkin.Controls.MaterialComboBox();
            this.ComboBox_Ubication = new MaterialSkin.Controls.MaterialComboBox();
            this.TxtBox_Magnitud = new MaterialSkin.Controls.MaterialTextBox();
            this.Switch_Assignment = new MaterialSkin.Controls.MaterialSwitch();
            this.TxtBox_USE = new MaterialSkin.Controls.MaterialTextBox();
            this.TxtBox_Mean_Interval = new MaterialSkin.Controls.MaterialTextBox();
            this.Btn_Add_Accessory = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // Btn_Add_Instrument
            // 
            this.Btn_Add_Instrument.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Btn_Add_Instrument.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.Btn_Add_Instrument.Depth = 0;
            this.Btn_Add_Instrument.HighEmphasis = true;
            this.Btn_Add_Instrument.Icon = null;
            this.Btn_Add_Instrument.Location = new System.Drawing.Point(705, 530);
            this.Btn_Add_Instrument.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Btn_Add_Instrument.MouseState = MaterialSkin.MouseState.HOVER;
            this.Btn_Add_Instrument.Name = "Btn_Add_Instrument";
            this.Btn_Add_Instrument.Size = new System.Drawing.Size(88, 36);
            this.Btn_Add_Instrument.TabIndex = 38;
            this.Btn_Add_Instrument.Text = "Agregar";
            this.Btn_Add_Instrument.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.Btn_Add_Instrument.UseAccentColor = false;
            this.Btn_Add_Instrument.UseVisualStyleBackColor = true;
            this.Btn_Add_Instrument.Click += new System.EventHandler(this.Btn_Add_Instrument_Click);
            // 
            // materialContextMenuStrip1
            // 
            this.materialContextMenuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialContextMenuStrip1.Depth = 0;
            this.materialContextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.materialContextMenuStrip1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialContextMenuStrip1.Name = "materialContextMenuStrip1";
            this.materialContextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // TxtBox_Id
            // 
            this.TxtBox_Id.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtBox_Id.Depth = 0;
            this.TxtBox_Id.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TxtBox_Id.Hint = "Equino";
            this.TxtBox_Id.LeadingIcon = null;
            this.TxtBox_Id.Location = new System.Drawing.Point(25, 76);
            this.TxtBox_Id.MaxLength = 50;
            this.TxtBox_Id.MouseState = MaterialSkin.MouseState.OUT;
            this.TxtBox_Id.Multiline = false;
            this.TxtBox_Id.Name = "TxtBox_Id";
            this.TxtBox_Id.Size = new System.Drawing.Size(374, 50);
            this.TxtBox_Id.TabIndex = 40;
            this.TxtBox_Id.Text = "";
            this.TxtBox_Id.TrailingIcon = null;
            // 
            // TxBox_Brand
            // 
            this.TxBox_Brand.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxBox_Brand.Depth = 0;
            this.TxBox_Brand.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TxBox_Brand.Hint = "Marca";
            this.TxBox_Brand.LeadingIcon = null;
            this.TxBox_Brand.Location = new System.Drawing.Point(25, 214);
            this.TxBox_Brand.MaxLength = 50;
            this.TxBox_Brand.MouseState = MaterialSkin.MouseState.OUT;
            this.TxBox_Brand.Multiline = false;
            this.TxBox_Brand.Name = "TxBox_Brand";
            this.TxBox_Brand.Size = new System.Drawing.Size(374, 50);
            this.TxBox_Brand.TabIndex = 41;
            this.TxBox_Brand.Text = "";
            this.TxBox_Brand.TrailingIcon = null;
            // 
            // TxtBox_Model
            // 
            this.TxtBox_Model.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtBox_Model.Depth = 0;
            this.TxtBox_Model.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TxtBox_Model.Hint = "Modelo";
            this.TxtBox_Model.LeadingIcon = null;
            this.TxtBox_Model.Location = new System.Drawing.Point(25, 283);
            this.TxtBox_Model.MaxLength = 50;
            this.TxtBox_Model.MouseState = MaterialSkin.MouseState.OUT;
            this.TxtBox_Model.Multiline = false;
            this.TxtBox_Model.Name = "TxtBox_Model";
            this.TxtBox_Model.Size = new System.Drawing.Size(374, 50);
            this.TxtBox_Model.TabIndex = 42;
            this.TxtBox_Model.Text = "";
            this.TxtBox_Model.TrailingIcon = null;
            // 
            // TxtBox_NumSerie
            // 
            this.TxtBox_NumSerie.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtBox_NumSerie.Depth = 0;
            this.TxtBox_NumSerie.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TxtBox_NumSerie.Hint = "Numero de serie";
            this.TxtBox_NumSerie.LeadingIcon = null;
            this.TxtBox_NumSerie.Location = new System.Drawing.Point(25, 349);
            this.TxtBox_NumSerie.MaxLength = 50;
            this.TxtBox_NumSerie.MouseState = MaterialSkin.MouseState.OUT;
            this.TxtBox_NumSerie.Multiline = false;
            this.TxtBox_NumSerie.Name = "TxtBox_NumSerie";
            this.TxtBox_NumSerie.Size = new System.Drawing.Size(374, 50);
            this.TxtBox_NumSerie.TabIndex = 43;
            this.TxtBox_NumSerie.Text = "";
            this.TxtBox_NumSerie.TrailingIcon = null;
            // 
            // TxtBox_Observation
            // 
            this.TxtBox_Observation.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtBox_Observation.Depth = 0;
            this.TxtBox_Observation.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TxtBox_Observation.Hint = "Observacion";
            this.TxtBox_Observation.LeadingIcon = null;
            this.TxtBox_Observation.Location = new System.Drawing.Point(419, 145);
            this.TxtBox_Observation.MaxLength = 50;
            this.TxtBox_Observation.MouseState = MaterialSkin.MouseState.OUT;
            this.TxtBox_Observation.Multiline = false;
            this.TxtBox_Observation.Name = "TxtBox_Observation";
            this.TxtBox_Observation.Size = new System.Drawing.Size(374, 50);
            this.TxtBox_Observation.TabIndex = 45;
            this.TxtBox_Observation.Text = "";
            this.TxtBox_Observation.TrailingIcon = null;
            // 
            // TxtBox_Instrument
            // 
            this.TxtBox_Instrument.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtBox_Instrument.Depth = 0;
            this.TxtBox_Instrument.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TxtBox_Instrument.Hint = "Instrumento";
            this.TxtBox_Instrument.LeadingIcon = null;
            this.TxtBox_Instrument.Location = new System.Drawing.Point(25, 145);
            this.TxtBox_Instrument.MaxLength = 50;
            this.TxtBox_Instrument.MouseState = MaterialSkin.MouseState.OUT;
            this.TxtBox_Instrument.Multiline = false;
            this.TxtBox_Instrument.Name = "TxtBox_Instrument";
            this.TxtBox_Instrument.Size = new System.Drawing.Size(374, 50);
            this.TxtBox_Instrument.TabIndex = 47;
            this.TxtBox_Instrument.Text = "";
            this.TxtBox_Instrument.TrailingIcon = null;
            // 
            // ComboBox_Status
            // 
            this.ComboBox_Status.AutoResize = false;
            this.ComboBox_Status.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ComboBox_Status.Depth = 0;
            this.ComboBox_Status.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.ComboBox_Status.DropDownHeight = 174;
            this.ComboBox_Status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBox_Status.DropDownWidth = 121;
            this.ComboBox_Status.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.ComboBox_Status.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ComboBox_Status.FormattingEnabled = true;
            this.ComboBox_Status.Hint = "Estatus";
            this.ComboBox_Status.IntegralHeight = false;
            this.ComboBox_Status.ItemHeight = 43;
            this.ComboBox_Status.Items.AddRange(new object[] {
            "ACTIVO",
            "FUERA DE USO",
            "ASIGNADO",
            "ASIGNADO GUADALAJARA"});
            this.ComboBox_Status.Location = new System.Drawing.Point(419, 215);
            this.ComboBox_Status.MaxDropDownItems = 4;
            this.ComboBox_Status.MouseState = MaterialSkin.MouseState.OUT;
            this.ComboBox_Status.Name = "ComboBox_Status";
            this.ComboBox_Status.Size = new System.Drawing.Size(374, 49);
            this.ComboBox_Status.StartIndex = 0;
            this.ComboBox_Status.TabIndex = 48;
            // 
            // ComboBox_Ubication
            // 
            this.ComboBox_Ubication.AutoResize = false;
            this.ComboBox_Ubication.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ComboBox_Ubication.Depth = 0;
            this.ComboBox_Ubication.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.ComboBox_Ubication.DropDownHeight = 174;
            this.ComboBox_Ubication.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBox_Ubication.DropDownWidth = 121;
            this.ComboBox_Ubication.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.ComboBox_Ubication.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ComboBox_Ubication.FormattingEnabled = true;
            this.ComboBox_Ubication.Hint = "Ubicacion";
            this.ComboBox_Ubication.IntegralHeight = false;
            this.ComboBox_Ubication.ItemHeight = 43;
            this.ComboBox_Ubication.Items.AddRange(new object[] {
            "GUADALAJARA",
            "ALMACEN",
            "PENDIENTE"});
            this.ComboBox_Ubication.Location = new System.Drawing.Point(419, 77);
            this.ComboBox_Ubication.MaxDropDownItems = 4;
            this.ComboBox_Ubication.MouseState = MaterialSkin.MouseState.OUT;
            this.ComboBox_Ubication.Name = "ComboBox_Ubication";
            this.ComboBox_Ubication.Size = new System.Drawing.Size(374, 49);
            this.ComboBox_Ubication.StartIndex = 0;
            this.ComboBox_Ubication.TabIndex = 49;
            // 
            // TxtBox_Magnitud
            // 
            this.TxtBox_Magnitud.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtBox_Magnitud.Depth = 0;
            this.TxtBox_Magnitud.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TxtBox_Magnitud.Hint = "Magnitud";
            this.TxtBox_Magnitud.LeadingIcon = null;
            this.TxtBox_Magnitud.Location = new System.Drawing.Point(25, 415);
            this.TxtBox_Magnitud.MaxLength = 50;
            this.TxtBox_Magnitud.MouseState = MaterialSkin.MouseState.OUT;
            this.TxtBox_Magnitud.Multiline = false;
            this.TxtBox_Magnitud.Name = "TxtBox_Magnitud";
            this.TxtBox_Magnitud.Size = new System.Drawing.Size(374, 50);
            this.TxtBox_Magnitud.TabIndex = 50;
            this.TxtBox_Magnitud.Text = "";
            this.TxtBox_Magnitud.TrailingIcon = null;
            // 
            // Switch_Assignment
            // 
            this.Switch_Assignment.AutoSize = true;
            this.Switch_Assignment.Depth = 0;
            this.Switch_Assignment.Location = new System.Drawing.Point(599, 487);
            this.Switch_Assignment.Margin = new System.Windows.Forms.Padding(0);
            this.Switch_Assignment.MouseLocation = new System.Drawing.Point(-1, -1);
            this.Switch_Assignment.MouseState = MaterialSkin.MouseState.HOVER;
            this.Switch_Assignment.Name = "Switch_Assignment";
            this.Switch_Assignment.Ripple = true;
            this.Switch_Assignment.Size = new System.Drawing.Size(194, 37);
            this.Switch_Assignment.TabIndex = 54;
            this.Switch_Assignment.Text = "Asignar a Ingeniero";
            this.Switch_Assignment.UseVisualStyleBackColor = true;
            // 
            // TxtBox_USE
            // 
            this.TxtBox_USE.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtBox_USE.Depth = 0;
            this.TxtBox_USE.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TxtBox_USE.Hint = "USO";
            this.TxtBox_USE.LeadingIcon = null;
            this.TxtBox_USE.Location = new System.Drawing.Point(419, 283);
            this.TxtBox_USE.MaxLength = 50;
            this.TxtBox_USE.MouseState = MaterialSkin.MouseState.OUT;
            this.TxtBox_USE.Multiline = false;
            this.TxtBox_USE.Name = "TxtBox_USE";
            this.TxtBox_USE.Size = new System.Drawing.Size(374, 50);
            this.TxtBox_USE.TabIndex = 55;
            this.TxtBox_USE.Text = "";
            this.TxtBox_USE.TrailingIcon = null;
            // 
            // TxtBox_Mean_Interval
            // 
            this.TxtBox_Mean_Interval.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtBox_Mean_Interval.Depth = 0;
            this.TxtBox_Mean_Interval.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TxtBox_Mean_Interval.Hint = "INTERVALO DE MEDIA";
            this.TxtBox_Mean_Interval.LeadingIcon = null;
            this.TxtBox_Mean_Interval.Location = new System.Drawing.Point(419, 349);
            this.TxtBox_Mean_Interval.MaxLength = 50;
            this.TxtBox_Mean_Interval.MouseState = MaterialSkin.MouseState.OUT;
            this.TxtBox_Mean_Interval.Multiline = false;
            this.TxtBox_Mean_Interval.Name = "TxtBox_Mean_Interval";
            this.TxtBox_Mean_Interval.Size = new System.Drawing.Size(374, 50);
            this.TxtBox_Mean_Interval.TabIndex = 56;
            this.TxtBox_Mean_Interval.Text = "";
            this.TxtBox_Mean_Interval.TrailingIcon = null;
            // 
            // Btn_Add_Accessory
            // 
            this.Btn_Add_Accessory.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Btn_Add_Accessory.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.Btn_Add_Accessory.Depth = 0;
            this.Btn_Add_Accessory.HighEmphasis = true;
            this.Btn_Add_Accessory.Icon = null;
            this.Btn_Add_Accessory.Location = new System.Drawing.Point(622, 429);
            this.Btn_Add_Accessory.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Btn_Add_Accessory.MouseState = MaterialSkin.MouseState.HOVER;
            this.Btn_Add_Accessory.Name = "Btn_Add_Accessory";
            this.Btn_Add_Accessory.Size = new System.Drawing.Size(171, 36);
            this.Btn_Add_Accessory.TabIndex = 57;
            this.Btn_Add_Accessory.Text = "Agregar Accesorio";
            this.Btn_Add_Accessory.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.Btn_Add_Accessory.UseAccentColor = false;
            this.Btn_Add_Accessory.UseVisualStyleBackColor = true;
            this.Btn_Add_Accessory.Click += new System.EventHandler(this.Btn_Add_Accessory_Click);
            // 
            // AddInstrument
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 593);
            this.Controls.Add(this.Btn_Add_Accessory);
            this.Controls.Add(this.TxtBox_Mean_Interval);
            this.Controls.Add(this.TxtBox_USE);
            this.Controls.Add(this.Switch_Assignment);
            this.Controls.Add(this.TxtBox_Magnitud);
            this.Controls.Add(this.ComboBox_Ubication);
            this.Controls.Add(this.ComboBox_Status);
            this.Controls.Add(this.TxtBox_Instrument);
            this.Controls.Add(this.TxtBox_Observation);
            this.Controls.Add(this.TxtBox_NumSerie);
            this.Controls.Add(this.TxtBox_Model);
            this.Controls.Add(this.TxBox_Brand);
            this.Controls.Add(this.TxtBox_Id);
            this.Controls.Add(this.Btn_Add_Instrument);
            this.Name = "AddInstrument";
            this.Sizable = false;
            this.Text = "Agregar Instrumento";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialButton Btn_Add_Instrument;
        private MaterialSkin.Controls.MaterialContextMenuStrip materialContextMenuStrip1;
        private MaterialSkin.Controls.MaterialTextBox TxtBox_Id;
        private MaterialSkin.Controls.MaterialTextBox TxBox_Brand;
        private MaterialSkin.Controls.MaterialTextBox TxtBox_Model;
        private MaterialSkin.Controls.MaterialTextBox TxtBox_NumSerie;
        private MaterialSkin.Controls.MaterialTextBox TxtBox_Observation;
        private MaterialSkin.Controls.MaterialTextBox TxtBox_Instrument;
        private MaterialSkin.Controls.MaterialComboBox ComboBox_Status;
        private MaterialSkin.Controls.MaterialComboBox ComboBox_Ubication;
        private MaterialSkin.Controls.MaterialTextBox TxtBox_Magnitud;
        private MaterialSkin.Controls.MaterialSwitch Switch_Assignment;
        private MaterialSkin.Controls.MaterialTextBox TxtBox_USE;
        private MaterialSkin.Controls.MaterialTextBox TxtBox_Mean_Interval;
        private MaterialSkin.Controls.MaterialButton Btn_Add_Accessory;
    }
}