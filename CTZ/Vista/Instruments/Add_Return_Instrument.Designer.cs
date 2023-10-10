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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.Lbl_Date_Of_Return = new MaterialSkin.Controls.MaterialLabel();
            this.Lbl_Observations = new MaterialSkin.Controls.MaterialLabel();
            this.materialTextBox1 = new MaterialSkin.Controls.MaterialTextBox();
            this.Lbl_Sign = new MaterialSkin.Controls.MaterialLabel();
            this.Btn_Add = new MaterialSkin.Controls.MaterialButton();
            this.Sign = new MaterialSkin.Controls.MaterialLabel();
            this.Btn_Sign = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(38, 134);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(301, 20);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // Lbl_Date_Of_Return
            // 
            this.Lbl_Date_Of_Return.AutoSize = true;
            this.Lbl_Date_Of_Return.Depth = 0;
            this.Lbl_Date_Of_Return.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Lbl_Date_Of_Return.Location = new System.Drawing.Point(35, 103);
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
            this.Lbl_Observations.Location = new System.Drawing.Point(35, 191);
            this.Lbl_Observations.MouseState = MaterialSkin.MouseState.HOVER;
            this.Lbl_Observations.Name = "Lbl_Observations";
            this.Lbl_Observations.Size = new System.Drawing.Size(105, 19);
            this.Lbl_Observations.TabIndex = 2;
            this.Lbl_Observations.Text = "Observaciones";
            // 
            // materialTextBox1
            // 
            this.materialTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialTextBox1.Depth = 0;
            this.materialTextBox1.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTextBox1.LeadingIcon = null;
            this.materialTextBox1.Location = new System.Drawing.Point(38, 227);
            this.materialTextBox1.MaxLength = 50;
            this.materialTextBox1.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBox1.Multiline = false;
            this.materialTextBox1.Name = "materialTextBox1";
            this.materialTextBox1.Size = new System.Drawing.Size(683, 50);
            this.materialTextBox1.TabIndex = 3;
            this.materialTextBox1.Text = "";
            this.materialTextBox1.TrailingIcon = null;
            // 
            // Lbl_Sign
            // 
            this.Lbl_Sign.AutoSize = true;
            this.Lbl_Sign.Depth = 0;
            this.Lbl_Sign.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Lbl_Sign.Location = new System.Drawing.Point(38, 310);
            this.Lbl_Sign.MouseState = MaterialSkin.MouseState.HOVER;
            this.Lbl_Sign.Name = "Lbl_Sign";
            this.Lbl_Sign.Size = new System.Drawing.Size(100, 19);
            this.Lbl_Sign.TabIndex = 4;
            this.Lbl_Sign.Text = "Firma Calidad";
            // 
            // Btn_Add
            // 
            this.Btn_Add.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Btn_Add.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.Btn_Add.Depth = 0;
            this.Btn_Add.HighEmphasis = true;
            this.Btn_Add.Icon = null;
            this.Btn_Add.Location = new System.Drawing.Point(424, 431);
            this.Btn_Add.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Btn_Add.MouseState = MaterialSkin.MouseState.HOVER;
            this.Btn_Add.Name = "Btn_Add";
            this.Btn_Add.Size = new System.Drawing.Size(306, 36);
            this.Btn_Add.TabIndex = 6;
            this.Btn_Add.Text = "Agregar Informacion de Devolucion";
            this.Btn_Add.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.Btn_Add.UseAccentColor = false;
            this.Btn_Add.UseVisualStyleBackColor = true;
            // 
            // Sign
            // 
            this.Sign.AccessibleRole = System.Windows.Forms.AccessibleRole.Cursor;
            this.Sign.AutoSize = true;
            this.Sign.Depth = 0;
            this.Sign.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Sign.Location = new System.Drawing.Point(208, 309);
            this.Sign.MouseState = MaterialSkin.MouseState.HOVER;
            this.Sign.Name = "Sign";
            this.Sign.Size = new System.Drawing.Size(42, 19);
            this.Sign.TabIndex = 7;
            this.Sign.Text = "Firma";
            // 
            // Btn_Sign
            // 
            this.Btn_Sign.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Btn_Sign.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.Btn_Sign.Depth = 0;
            this.Btn_Sign.HighEmphasis = true;
            this.Btn_Sign.Icon = null;
            this.Btn_Sign.Location = new System.Drawing.Point(38, 359);
            this.Btn_Sign.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Btn_Sign.MouseState = MaterialSkin.MouseState.HOVER;
            this.Btn_Sign.Name = "Btn_Sign";
            this.Btn_Sign.Size = new System.Drawing.Size(135, 36);
            this.Btn_Sign.TabIndex = 8;
            this.Btn_Sign.Text = "Agregar Firma";
            this.Btn_Sign.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.Btn_Sign.UseAccentColor = false;
            this.Btn_Sign.UseVisualStyleBackColor = true;
            // 
            // Add_Return_Instrument
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 493);
            this.Controls.Add(this.Btn_Sign);
            this.Controls.Add(this.Sign);
            this.Controls.Add(this.Btn_Add);
            this.Controls.Add(this.Lbl_Sign);
            this.Controls.Add(this.materialTextBox1);
            this.Controls.Add(this.Lbl_Observations);
            this.Controls.Add(this.Lbl_Date_Of_Return);
            this.Controls.Add(this.dateTimePicker1);
            this.Name = "Add_Return_Instrument";
            this.Text = "Registrar Devolucion de Instrumento";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private MaterialSkin.Controls.MaterialLabel Lbl_Date_Of_Return;
        private MaterialSkin.Controls.MaterialLabel Lbl_Observations;
        private MaterialSkin.Controls.MaterialTextBox materialTextBox1;
        private MaterialSkin.Controls.MaterialLabel Lbl_Sign;
        private MaterialSkin.Controls.MaterialButton Btn_Add;
        private MaterialSkin.Controls.MaterialLabel Sign;
        private MaterialSkin.Controls.MaterialButton Btn_Sign;
    }
}