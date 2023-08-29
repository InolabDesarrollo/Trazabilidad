namespace CTZ
{
    partial class AddUso
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddUso));
            this.save = new MaterialSkin.Controls.MaterialButton();
            this.uso = new MaterialSkin.Controls.MaterialTextBox();
            this.direccion = new MaterialSkin.Controls.MaterialTextBox();
            this.SuspendLayout();
            // 
            // save
            // 
            this.save.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.save.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.save.Depth = 0;
            this.save.HighEmphasis = true;
            this.save.Icon = null;
            this.save.Location = new System.Drawing.Point(194, 225);
            this.save.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.save.MouseState = MaterialSkin.MouseState.HOVER;
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(88, 36);
            this.save.TabIndex = 2;
            this.save.Text = "Guardar";
            this.save.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.save.UseAccentColor = false;
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // uso
            // 
            this.uso.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.uso.Depth = 0;
            this.uso.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.uso.Hint = "Nombre";
            this.uso.LeadingIcon = null;
            this.uso.Location = new System.Drawing.Point(28, 100);
            this.uso.MaxLength = 255;
            this.uso.MouseState = MaterialSkin.MouseState.OUT;
            this.uso.Multiline = false;
            this.uso.Name = "uso";
            this.uso.Size = new System.Drawing.Size(297, 50);
            this.uso.TabIndex = 3;
            this.uso.Text = "";
            this.uso.TrailingIcon = null;
            // 
            // direccion
            // 
            this.direccion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.direccion.Depth = 0;
            this.direccion.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.direccion.Hint = "Dirección";
            this.direccion.LeadingIcon = null;
            this.direccion.Location = new System.Drawing.Point(28, 166);
            this.direccion.MaxLength = 500;
            this.direccion.MouseState = MaterialSkin.MouseState.OUT;
            this.direccion.Multiline = false;
            this.direccion.Name = "direccion";
            this.direccion.Size = new System.Drawing.Size(297, 50);
            this.direccion.TabIndex = 4;
            this.direccion.Text = "";
            this.direccion.TrailingIcon = null;
            this.direccion.Visible = false;
            // 
            // AddUso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 270);
            this.Controls.Add(this.direccion);
            this.Controls.Add(this.uso);
            this.Controls.Add(this.save);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(349, 270);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(349, 270);
            this.Name = "AddUso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nuevo Uso";
            this.Load += new System.EventHandler(this.AddUso_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialButton save;
        private MaterialSkin.Controls.MaterialTextBox uso;
        private MaterialSkin.Controls.MaterialTextBox direccion;
    }
}