namespace TestSpire
{
    partial class LogIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogIn));
            this.materialButton1 = new MaterialSkin.Controls.MaterialButton();
            this.version = new MaterialSkin.Controls.MaterialLabel();
            this.user = new MaterialSkin.Controls.MaterialTextBox();
            this.pass = new MaterialSkin.Controls.MaterialTextBox();
            this.SuspendLayout();
            // 
            // materialButton1
            // 
            this.materialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton1.Depth = 0;
            this.materialButton1.HighEmphasis = true;
            this.materialButton1.Icon = null;
            this.materialButton1.Location = new System.Drawing.Point(403, 212);
            this.materialButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.Size = new System.Drawing.Size(73, 36);
            this.materialButton1.TabIndex = 13;
            this.materialButton1.Text = "Iniciar";
            this.materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.materialButton1.UseAccentColor = false;
            this.materialButton1.UseVisualStyleBackColor = true;
            this.materialButton1.Click += new System.EventHandler(this.materialButton1_Click);
            // 
            // version
            // 
            this.version.AutoSize = true;
            this.version.Depth = 0;
            this.version.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.version.Location = new System.Drawing.Point(428, 254);
            this.version.MouseState = MaterialSkin.MouseState.HOVER;
            this.version.Name = "version";
            this.version.Size = new System.Drawing.Size(49, 19);
            this.version.TabIndex = 14;
            this.version.Text = "0.0.0.1";
            // 
            // user
            // 
            this.user.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.user.Depth = 0;
            this.user.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.user.Hint = "Usuario";
            this.user.LeadingIcon = null;
            this.user.Location = new System.Drawing.Point(113, 99);
            this.user.MaxLength = 50;
            this.user.MouseState = MaterialSkin.MouseState.OUT;
            this.user.Multiline = false;
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(246, 50);
            this.user.TabIndex = 15;
            this.user.Text = "";
            this.user.TrailingIcon = null;
            this.user.UseAccent = false;
            // 
            // pass
            // 
            this.pass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.pass.Depth = 0;
            this.pass.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.pass.Hint = "Contraseña";
            this.pass.LeadingIcon = null;
            this.pass.Location = new System.Drawing.Point(113, 182);
            this.pass.MaxLength = 50;
            this.pass.MouseState = MaterialSkin.MouseState.OUT;
            this.pass.Multiline = false;
            this.pass.Name = "pass";
            this.pass.Password = true;
            this.pass.Size = new System.Drawing.Size(246, 50);
            this.pass.TabIndex = 16;
            this.pass.Text = "";
            this.pass.TrailingIcon = null;
            this.pass.UseAccent = false;
            this.pass.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.pass_KeyPress);
            // 
            // LogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 276);
            this.Controls.Add(this.pass);
            this.Controls.Add(this.user);
            this.Controls.Add(this.version);
            this.Controls.Add(this.materialButton1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(483, 276);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(483, 276);
            this.Name = "LogIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio de Sesión.";
            this.Activated += new System.EventHandler(this.LogIn_Activated);
            this.Load += new System.EventHandler(this.LogIn_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private MaterialSkin.Controls.MaterialLabel version;
        private MaterialSkin.Controls.MaterialTextBox user;
        private MaterialSkin.Controls.MaterialTextBox pass;
    }
}