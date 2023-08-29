namespace CTZ
{
    partial class AddEquipoP1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddEquipoP1));
            this.noserie = new MaterialSkin.Controls.MaterialTextBox();
            this.ident = new MaterialSkin.Controls.MaterialTextBox();
            this.materialButton1 = new MaterialSkin.Controls.MaterialButton();
            this.manual = new MaterialSkin.Controls.MaterialTextBox();
            this.SuspendLayout();
            // 
            // noserie
            // 
            this.noserie.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.noserie.Depth = 0;
            this.noserie.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.noserie.Hint = "No. Serie";
            this.noserie.LeadingIcon = null;
            this.noserie.Location = new System.Drawing.Point(32, 87);
            this.noserie.MaxLength = 50;
            this.noserie.MouseState = MaterialSkin.MouseState.OUT;
            this.noserie.Multiline = false;
            this.noserie.Name = "noserie";
            this.noserie.Size = new System.Drawing.Size(260, 50);
            this.noserie.TabIndex = 17;
            this.noserie.Text = "";
            this.noserie.TrailingIcon = null;
            this.noserie.UseAccent = false;
            // 
            // ident
            // 
            this.ident.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ident.Depth = 0;
            this.ident.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ident.Hint = "Identificación";
            this.ident.LeadingIcon = null;
            this.ident.Location = new System.Drawing.Point(32, 156);
            this.ident.MaxLength = 50;
            this.ident.MouseState = MaterialSkin.MouseState.OUT;
            this.ident.Multiline = false;
            this.ident.Name = "ident";
            this.ident.Size = new System.Drawing.Size(260, 50);
            this.ident.TabIndex = 18;
            this.ident.Text = "";
            this.ident.TrailingIcon = null;
            this.ident.UseAccent = false;
            // 
            // materialButton1
            // 
            this.materialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton1.Depth = 0;
            this.materialButton1.HighEmphasis = true;
            this.materialButton1.Icon = null;
            this.materialButton1.Location = new System.Drawing.Point(292, 295);
            this.materialButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.Size = new System.Drawing.Size(88, 36);
            this.materialButton1.TabIndex = 19;
            this.materialButton1.Text = "Guardar";
            this.materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton1.UseAccentColor = false;
            this.materialButton1.UseVisualStyleBackColor = true;
            this.materialButton1.Click += new System.EventHandler(this.materialButton1_Click);
            // 
            // manual
            // 
            this.manual.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.manual.Depth = 0;
            this.manual.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.manual.Hint = "Link del manual de usuario";
            this.manual.LeadingIcon = null;
            this.manual.Location = new System.Drawing.Point(32, 226);
            this.manual.MaxLength = 50;
            this.manual.MouseState = MaterialSkin.MouseState.OUT;
            this.manual.Multiline = false;
            this.manual.Name = "manual";
            this.manual.Size = new System.Drawing.Size(260, 50);
            this.manual.TabIndex = 20;
            this.manual.Text = "";
            this.manual.TrailingIcon = null;
            // 
            // AddEquipoP1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(387, 340);
            this.Controls.Add(this.manual);
            this.Controls.Add(this.materialButton1);
            this.Controls.Add(this.ident);
            this.Controls.Add(this.noserie);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(387, 340);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(387, 340);
            this.Name = "AddEquipoP1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nuevo Equipo";
            this.Load += new System.EventHandler(this.AddEquipoP1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialTextBox noserie;
        private MaterialSkin.Controls.MaterialTextBox ident;
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private MaterialSkin.Controls.MaterialTextBox manual;
    }
}