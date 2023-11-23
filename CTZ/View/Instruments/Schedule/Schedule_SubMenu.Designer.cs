namespace CTZ.View.Instruments.Schedule
{
    partial class Schedule_SubMenu
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
            this.Btn_CalibrationShedule = new MaterialSkin.Controls.MaterialButton();
            this.Btn_Maintenance = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // Btn_CalibrationShedule
            // 
            this.Btn_CalibrationShedule.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Btn_CalibrationShedule.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.Btn_CalibrationShedule.Depth = 0;
            this.Btn_CalibrationShedule.HighEmphasis = true;
            this.Btn_CalibrationShedule.Icon = null;
            this.Btn_CalibrationShedule.Location = new System.Drawing.Point(225, 119);
            this.Btn_CalibrationShedule.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Btn_CalibrationShedule.MouseState = MaterialSkin.MouseState.HOVER;
            this.Btn_CalibrationShedule.Name = "Btn_CalibrationShedule";
            this.Btn_CalibrationShedule.Size = new System.Drawing.Size(226, 36);
            this.Btn_CalibrationShedule.TabIndex = 0;
            this.Btn_CalibrationShedule.Text = "Calendario Calibraciones";
            this.Btn_CalibrationShedule.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.Btn_CalibrationShedule.UseAccentColor = false;
            this.Btn_CalibrationShedule.UseVisualStyleBackColor = true;
            this.Btn_CalibrationShedule.Click += new System.EventHandler(this.Btn_CalibrationShedule_Click);
            // 
            // Btn_Maintenance
            // 
            this.Btn_Maintenance.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Btn_Maintenance.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.Btn_Maintenance.Depth = 0;
            this.Btn_Maintenance.HighEmphasis = true;
            this.Btn_Maintenance.Icon = null;
            this.Btn_Maintenance.Location = new System.Drawing.Point(225, 195);
            this.Btn_Maintenance.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Btn_Maintenance.MouseState = MaterialSkin.MouseState.HOVER;
            this.Btn_Maintenance.Name = "Btn_Maintenance";
            this.Btn_Maintenance.Size = new System.Drawing.Size(235, 36);
            this.Btn_Maintenance.TabIndex = 1;
            this.Btn_Maintenance.Text = "Calendario Mantenimiento";
            this.Btn_Maintenance.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.Btn_Maintenance.UseAccentColor = false;
            this.Btn_Maintenance.UseVisualStyleBackColor = true;
            // 
            // Schedule_SubMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 450);
            this.Controls.Add(this.Btn_Maintenance);
            this.Controls.Add(this.Btn_CalibrationShedule);
            this.Name = "Schedule_SubMenu";
            this.Text = "Calendarios";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialButton Btn_CalibrationShedule;
        private MaterialSkin.Controls.MaterialButton Btn_Maintenance;
    }
}