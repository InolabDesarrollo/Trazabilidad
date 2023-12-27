namespace CTZ.View.Instruments.Assignment
{
    partial class Assignment_SubMenu
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
            this.Btn_Serch_Assignments = new System.Windows.Forms.Button();
            this.Btn_Add_Assignments_ByGroup = new System.Windows.Forms.Button();
            this.Btn_Regist_Return_Instrument_ByGroup = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Btn_Serch_Assignments
            // 
            this.Btn_Serch_Assignments.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(119)))), ((int)(((byte)(182)))));
            this.Btn_Serch_Assignments.FlatAppearance.BorderSize = 0;
            this.Btn_Serch_Assignments.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Serch_Assignments.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Serch_Assignments.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Btn_Serch_Assignments.Location = new System.Drawing.Point(206, 116);
            this.Btn_Serch_Assignments.Name = "Btn_Serch_Assignments";
            this.Btn_Serch_Assignments.Size = new System.Drawing.Size(195, 50);
            this.Btn_Serch_Assignments.TabIndex = 15;
            this.Btn_Serch_Assignments.Text = "Buscar";
            this.Btn_Serch_Assignments.UseVisualStyleBackColor = false;
            this.Btn_Serch_Assignments.Click += new System.EventHandler(this.Btn_Serch_Assignments_Click);
            // 
            // Btn_Add_Assignments_ByGroup
            // 
            this.Btn_Add_Assignments_ByGroup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(119)))), ((int)(((byte)(182)))));
            this.Btn_Add_Assignments_ByGroup.FlatAppearance.BorderSize = 0;
            this.Btn_Add_Assignments_ByGroup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Add_Assignments_ByGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Add_Assignments_ByGroup.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Btn_Add_Assignments_ByGroup.Location = new System.Drawing.Point(206, 205);
            this.Btn_Add_Assignments_ByGroup.Name = "Btn_Add_Assignments_ByGroup";
            this.Btn_Add_Assignments_ByGroup.Size = new System.Drawing.Size(195, 63);
            this.Btn_Add_Assignments_ByGroup.TabIndex = 18;
            this.Btn_Add_Assignments_ByGroup.Text = "Entrega de Instrumento";
            this.Btn_Add_Assignments_ByGroup.UseVisualStyleBackColor = false;
            this.Btn_Add_Assignments_ByGroup.Click += new System.EventHandler(this.Btn_Add_Assignments_ByGroup_Click);
            // 
            // Btn_Regist_Return_Instrument_ByGroup
            // 
            this.Btn_Regist_Return_Instrument_ByGroup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(119)))), ((int)(((byte)(182)))));
            this.Btn_Regist_Return_Instrument_ByGroup.FlatAppearance.BorderSize = 0;
            this.Btn_Regist_Return_Instrument_ByGroup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Regist_Return_Instrument_ByGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Regist_Return_Instrument_ByGroup.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Btn_Regist_Return_Instrument_ByGroup.Location = new System.Drawing.Point(206, 309);
            this.Btn_Regist_Return_Instrument_ByGroup.Name = "Btn_Regist_Return_Instrument_ByGroup";
            this.Btn_Regist_Return_Instrument_ByGroup.Size = new System.Drawing.Size(195, 63);
            this.Btn_Regist_Return_Instrument_ByGroup.TabIndex = 19;
            this.Btn_Regist_Return_Instrument_ByGroup.Text = "Devolucion de Instrumento";
            this.Btn_Regist_Return_Instrument_ByGroup.UseVisualStyleBackColor = false;
            this.Btn_Regist_Return_Instrument_ByGroup.Click += new System.EventHandler(this.Btn_Regist_Return_Instrument_ByGroup_Click);
            // 
            // Assignment_SubMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 456);
            this.Controls.Add(this.Btn_Regist_Return_Instrument_ByGroup);
            this.Controls.Add(this.Btn_Add_Assignments_ByGroup);
            this.Controls.Add(this.Btn_Serch_Assignments);
            this.Name = "Assignment_SubMenu";
            this.Text = "Asignaciones";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Btn_Serch_Assignments;
        private System.Windows.Forms.Button Btn_Add_Assignments_ByGroup;
        private System.Windows.Forms.Button Btn_Regist_Return_Instrument_ByGroup;
    }
}