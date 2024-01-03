namespace CTZ.View.Estandard.Assignment
{
    partial class Regist_Return_Estandard
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
            this.TxtBox_Estandards = new MaterialSkin.Controls.MaterialTextBox();
            this.ComboBox_Estandards = new MaterialSkin.Controls.MaterialComboBox();
            this.Btn_AddEstandard = new MaterialSkin.Controls.MaterialButton();
            this.Btn_DeleteEstandard = new MaterialSkin.Controls.MaterialButton();
            this.Lbl_Date_Return = new MaterialSkin.Controls.MaterialLabel();
            this.TimePicker_Date_Return = new System.Windows.Forms.DateTimePicker();
            this.Lbl_Observation_Return = new MaterialSkin.Controls.MaterialLabel();
            this.TxtBox_ObservationReturn = new MaterialSkin.Controls.MaterialTextBox();
            this.Btn_Add_Return = new MaterialSkin.Controls.MaterialButton();
            this.Btn_Add_QualitySignature = new MaterialSkin.Controls.MaterialButton();
            this.Btn_Add_EnginnerSignature = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // Lbl_Estandard
            // 
            this.Lbl_Estandard.AutoSize = true;
            this.Lbl_Estandard.Depth = 0;
            this.Lbl_Estandard.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Lbl_Estandard.Location = new System.Drawing.Point(23, 80);
            this.Lbl_Estandard.MouseState = MaterialSkin.MouseState.HOVER;
            this.Lbl_Estandard.Name = "Lbl_Estandard";
            this.Lbl_Estandard.Size = new System.Drawing.Size(80, 19);
            this.Lbl_Estandard.TabIndex = 2;
            this.Lbl_Estandard.Text = "Estándares";
            // 
            // TxtBox_Estandards
            // 
            this.TxtBox_Estandards.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtBox_Estandards.Depth = 0;
            this.TxtBox_Estandards.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TxtBox_Estandards.LeadingIcon = null;
            this.TxtBox_Estandards.Location = new System.Drawing.Point(26, 120);
            this.TxtBox_Estandards.MaxLength = 50;
            this.TxtBox_Estandards.MouseState = MaterialSkin.MouseState.OUT;
            this.TxtBox_Estandards.Multiline = false;
            this.TxtBox_Estandards.Name = "TxtBox_Estandards";
            this.TxtBox_Estandards.Size = new System.Drawing.Size(379, 50);
            this.TxtBox_Estandards.TabIndex = 30;
            this.TxtBox_Estandards.Text = "";
            this.TxtBox_Estandards.TrailingIcon = null;
            // 
            // ComboBox_Estandards
            // 
            this.ComboBox_Estandards.AutoResize = false;
            this.ComboBox_Estandards.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ComboBox_Estandards.Depth = 0;
            this.ComboBox_Estandards.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.ComboBox_Estandards.DropDownHeight = 174;
            this.ComboBox_Estandards.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBox_Estandards.DropDownWidth = 121;
            this.ComboBox_Estandards.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.ComboBox_Estandards.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ComboBox_Estandards.FormattingEnabled = true;
            this.ComboBox_Estandards.IntegralHeight = false;
            this.ComboBox_Estandards.ItemHeight = 43;
            this.ComboBox_Estandards.Location = new System.Drawing.Point(26, 191);
            this.ComboBox_Estandards.MaxDropDownItems = 4;
            this.ComboBox_Estandards.MouseState = MaterialSkin.MouseState.OUT;
            this.ComboBox_Estandards.Name = "ComboBox_Estandards";
            this.ComboBox_Estandards.Size = new System.Drawing.Size(379, 49);
            this.ComboBox_Estandards.StartIndex = 0;
            this.ComboBox_Estandards.TabIndex = 32;
            // 
            // Btn_AddEstandard
            // 
            this.Btn_AddEstandard.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Btn_AddEstandard.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.Btn_AddEstandard.Depth = 0;
            this.Btn_AddEstandard.HighEmphasis = true;
            this.Btn_AddEstandard.Icon = null;
            this.Btn_AddEstandard.Location = new System.Drawing.Point(26, 261);
            this.Btn_AddEstandard.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Btn_AddEstandard.MouseState = MaterialSkin.MouseState.HOVER;
            this.Btn_AddEstandard.Name = "Btn_AddEstandard";
            this.Btn_AddEstandard.Size = new System.Drawing.Size(176, 36);
            this.Btn_AddEstandard.TabIndex = 33;
            this.Btn_AddEstandard.Text = "Agregar Estandard";
            this.Btn_AddEstandard.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.Btn_AddEstandard.UseAccentColor = false;
            this.Btn_AddEstandard.UseVisualStyleBackColor = true;
            this.Btn_AddEstandard.Click += new System.EventHandler(this.Btn_AddEstandard_Click);
            // 
            // Btn_DeleteEstandard
            // 
            this.Btn_DeleteEstandard.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Btn_DeleteEstandard.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.Btn_DeleteEstandard.Depth = 0;
            this.Btn_DeleteEstandard.HighEmphasis = true;
            this.Btn_DeleteEstandard.Icon = null;
            this.Btn_DeleteEstandard.Location = new System.Drawing.Point(228, 261);
            this.Btn_DeleteEstandard.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Btn_DeleteEstandard.MouseState = MaterialSkin.MouseState.HOVER;
            this.Btn_DeleteEstandard.Name = "Btn_DeleteEstandard";
            this.Btn_DeleteEstandard.Size = new System.Drawing.Size(177, 36);
            this.Btn_DeleteEstandard.TabIndex = 34;
            this.Btn_DeleteEstandard.Text = "Eliminar Estandard";
            this.Btn_DeleteEstandard.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.Btn_DeleteEstandard.UseAccentColor = false;
            this.Btn_DeleteEstandard.UseVisualStyleBackColor = true;
            this.Btn_DeleteEstandard.Click += new System.EventHandler(this.Btn_DeleteEstandard_Click);
            // 
            // Lbl_Date_Return
            // 
            this.Lbl_Date_Return.AutoSize = true;
            this.Lbl_Date_Return.Depth = 0;
            this.Lbl_Date_Return.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Lbl_Date_Return.Location = new System.Drawing.Point(23, 321);
            this.Lbl_Date_Return.MouseState = MaterialSkin.MouseState.HOVER;
            this.Lbl_Date_Return.Name = "Lbl_Date_Return";
            this.Lbl_Date_Return.Size = new System.Drawing.Size(203, 19);
            this.Lbl_Date_Return.TabIndex = 35;
            this.Lbl_Date_Return.Text = "Fecha Devolucion Estándard";
            // 
            // TimePicker_Date_Return
            // 
            this.TimePicker_Date_Return.Location = new System.Drawing.Point(26, 377);
            this.TimePicker_Date_Return.Name = "TimePicker_Date_Return";
            this.TimePicker_Date_Return.Size = new System.Drawing.Size(379, 20);
            this.TimePicker_Date_Return.TabIndex = 36;
            // 
            // Lbl_Observation_Return
            // 
            this.Lbl_Observation_Return.AutoSize = true;
            this.Lbl_Observation_Return.Depth = 0;
            this.Lbl_Observation_Return.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Lbl_Observation_Return.Location = new System.Drawing.Point(444, 80);
            this.Lbl_Observation_Return.MouseState = MaterialSkin.MouseState.HOVER;
            this.Lbl_Observation_Return.Name = "Lbl_Observation_Return";
            this.Lbl_Observation_Return.Size = new System.Drawing.Size(163, 19);
            this.Lbl_Observation_Return.TabIndex = 37;
            this.Lbl_Observation_Return.Text = "Observaciones Entrega";
            // 
            // TxtBox_ObservationReturn
            // 
            this.TxtBox_ObservationReturn.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtBox_ObservationReturn.Depth = 0;
            this.TxtBox_ObservationReturn.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TxtBox_ObservationReturn.LeadingIcon = null;
            this.TxtBox_ObservationReturn.Location = new System.Drawing.Point(447, 120);
            this.TxtBox_ObservationReturn.MaxLength = 50;
            this.TxtBox_ObservationReturn.MouseState = MaterialSkin.MouseState.OUT;
            this.TxtBox_ObservationReturn.Multiline = false;
            this.TxtBox_ObservationReturn.Name = "TxtBox_ObservationReturn";
            this.TxtBox_ObservationReturn.Size = new System.Drawing.Size(374, 50);
            this.TxtBox_ObservationReturn.TabIndex = 38;
            this.TxtBox_ObservationReturn.Text = "";
            this.TxtBox_ObservationReturn.TrailingIcon = null;
            // 
            // Btn_Add_Return
            // 
            this.Btn_Add_Return.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Btn_Add_Return.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.Btn_Add_Return.Depth = 0;
            this.Btn_Add_Return.HighEmphasis = true;
            this.Btn_Add_Return.Icon = null;
            this.Btn_Add_Return.Location = new System.Drawing.Point(592, 391);
            this.Btn_Add_Return.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Btn_Add_Return.MouseState = MaterialSkin.MouseState.HOVER;
            this.Btn_Add_Return.Name = "Btn_Add_Return";
            this.Btn_Add_Return.Size = new System.Drawing.Size(254, 36);
            this.Btn_Add_Return.TabIndex = 39;
            this.Btn_Add_Return.Text = "Agregar Datos de Devolucion";
            this.Btn_Add_Return.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.Btn_Add_Return.UseAccentColor = false;
            this.Btn_Add_Return.UseVisualStyleBackColor = true;
            this.Btn_Add_Return.Click += new System.EventHandler(this.Btn_Add_Return_Click);
            // 
            // Btn_Add_QualitySignature
            // 
            this.Btn_Add_QualitySignature.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Btn_Add_QualitySignature.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.Btn_Add_QualitySignature.Depth = 0;
            this.Btn_Add_QualitySignature.HighEmphasis = true;
            this.Btn_Add_QualitySignature.Icon = null;
            this.Btn_Add_QualitySignature.Location = new System.Drawing.Point(543, 235);
            this.Btn_Add_QualitySignature.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Btn_Add_QualitySignature.MouseState = MaterialSkin.MouseState.HOVER;
            this.Btn_Add_QualitySignature.Name = "Btn_Add_QualitySignature";
            this.Btn_Add_QualitySignature.Size = new System.Drawing.Size(303, 36);
            this.Btn_Add_QualitySignature.TabIndex = 40;
            this.Btn_Add_QualitySignature.Text = "Agregar firma de agente de calidad";
            this.Btn_Add_QualitySignature.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.Btn_Add_QualitySignature.UseAccentColor = false;
            this.Btn_Add_QualitySignature.UseVisualStyleBackColor = true;
            this.Btn_Add_QualitySignature.Click += new System.EventHandler(this.Btn_Add_QualitySignature_Click);
            // 
            // Btn_Add_EnginnerSignature
            // 
            this.Btn_Add_EnginnerSignature.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Btn_Add_EnginnerSignature.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.Btn_Add_EnginnerSignature.Depth = 0;
            this.Btn_Add_EnginnerSignature.HighEmphasis = true;
            this.Btn_Add_EnginnerSignature.Icon = null;
            this.Btn_Add_EnginnerSignature.Location = new System.Drawing.Point(609, 304);
            this.Btn_Add_EnginnerSignature.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Btn_Add_EnginnerSignature.MouseState = MaterialSkin.MouseState.HOVER;
            this.Btn_Add_EnginnerSignature.Name = "Btn_Add_EnginnerSignature";
            this.Btn_Add_EnginnerSignature.Size = new System.Drawing.Size(237, 36);
            this.Btn_Add_EnginnerSignature.TabIndex = 41;
            this.Btn_Add_EnginnerSignature.Text = "Agregar firma de ingeniero";
            this.Btn_Add_EnginnerSignature.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.Btn_Add_EnginnerSignature.UseAccentColor = false;
            this.Btn_Add_EnginnerSignature.UseVisualStyleBackColor = true;
            this.Btn_Add_EnginnerSignature.Click += new System.EventHandler(this.Btn_Add_EnginnerSignature_Click);
            // 
            // Regist_Return_Estandard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 467);
            this.Controls.Add(this.Btn_Add_EnginnerSignature);
            this.Controls.Add(this.Btn_Add_QualitySignature);
            this.Controls.Add(this.Btn_Add_Return);
            this.Controls.Add(this.TxtBox_ObservationReturn);
            this.Controls.Add(this.Lbl_Observation_Return);
            this.Controls.Add(this.TimePicker_Date_Return);
            this.Controls.Add(this.Lbl_Date_Return);
            this.Controls.Add(this.Btn_DeleteEstandard);
            this.Controls.Add(this.Btn_AddEstandard);
            this.Controls.Add(this.ComboBox_Estandards);
            this.Controls.Add(this.TxtBox_Estandards);
            this.Controls.Add(this.Lbl_Estandard);
            this.Name = "Regist_Return_Estandard";
            this.Text = "Registrar devolucion de estándar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel Lbl_Estandard;
        private MaterialSkin.Controls.MaterialTextBox TxtBox_Estandards;
        private MaterialSkin.Controls.MaterialComboBox ComboBox_Estandards;
        private MaterialSkin.Controls.MaterialButton Btn_AddEstandard;
        private MaterialSkin.Controls.MaterialButton Btn_DeleteEstandard;
        private MaterialSkin.Controls.MaterialLabel Lbl_Date_Return;
        private System.Windows.Forms.DateTimePicker TimePicker_Date_Return;
        private MaterialSkin.Controls.MaterialLabel Lbl_Observation_Return;
        private MaterialSkin.Controls.MaterialTextBox TxtBox_ObservationReturn;
        private MaterialSkin.Controls.MaterialButton Btn_Add_Return;
        private MaterialSkin.Controls.MaterialButton Btn_Add_QualitySignature;
        private MaterialSkin.Controls.MaterialButton Btn_Add_EnginnerSignature;
    }
}