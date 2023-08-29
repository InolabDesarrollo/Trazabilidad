namespace CTZ
{
    partial class AddModelo
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddModelo));
            this.documentacionDataSet = new CTZ.DocumentacionDataSet();
            this.documentacionDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.save = new MaterialSkin.Controls.MaterialButton();
            this.rango = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.marcas = new MaterialSkin.Controls.MaterialComboBox();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.addBrand = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.carac = new MaterialSkin.Controls.MaterialMultiLineTextBox();
            this.model = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.desc = new MaterialSkin.Controls.MaterialTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.documentacionDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentacionDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // documentacionDataSet
            // 
            this.documentacionDataSet.DataSetName = "DocumentacionDataSet";
            this.documentacionDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // documentacionDataSetBindingSource
            // 
            this.documentacionDataSetBindingSource.DataSource = this.documentacionDataSet;
            this.documentacionDataSetBindingSource.Position = 0;
            // 
            // save
            // 
            this.save.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.save.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.save.Depth = 0;
            this.save.HighEmphasis = true;
            this.save.Icon = null;
            this.save.Location = new System.Drawing.Point(390, 346);
            this.save.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.save.MouseState = MaterialSkin.MouseState.HOVER;
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(88, 36);
            this.save.TabIndex = 12;
            this.save.Text = "Guardar";
            this.save.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.save.UseAccentColor = false;
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // rango
            // 
            this.rango.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rango.Depth = 0;
            this.rango.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.rango.LeadingIcon = null;
            this.rango.Location = new System.Drawing.Point(139, 324);
            this.rango.MaxLength = 50;
            this.rango.MouseState = MaterialSkin.MouseState.OUT;
            this.rango.Multiline = false;
            this.rango.Name = "rango";
            this.rango.Size = new System.Drawing.Size(218, 36);
            this.rango.TabIndex = 13;
            this.rango.Text = "";
            this.rango.TrailingIcon = null;
            this.rango.UseTallSize = false;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(26, 341);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(47, 19);
            this.materialLabel1.TabIndex = 14;
            this.materialLabel1.Text = "Rango";
            // 
            // marcas
            // 
            this.marcas.AutoResize = false;
            this.marcas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.marcas.Depth = 0;
            this.marcas.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.marcas.DropDownHeight = 118;
            this.marcas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.marcas.DropDownWidth = 121;
            this.marcas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.marcas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.marcas.FormattingEnabled = true;
            this.marcas.IntegralHeight = false;
            this.marcas.ItemHeight = 29;
            this.marcas.Location = new System.Drawing.Point(139, 269);
            this.marcas.MaxDropDownItems = 4;
            this.marcas.MouseState = MaterialSkin.MouseState.OUT;
            this.marcas.Name = "marcas";
            this.marcas.Size = new System.Drawing.Size(218, 35);
            this.marcas.StartIndex = 0;
            this.marcas.TabIndex = 15;
            this.marcas.UseTallSize = false;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(26, 285);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(46, 19);
            this.materialLabel2.TabIndex = 16;
            this.materialLabel2.Text = "Marca";
            // 
            // addBrand
            // 
            this.addBrand.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.addBrand.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.addBrand.Depth = 0;
            this.addBrand.HighEmphasis = true;
            this.addBrand.Icon = null;
            this.addBrand.Location = new System.Drawing.Point(385, 268);
            this.addBrand.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.addBrand.MouseState = MaterialSkin.MouseState.HOVER;
            this.addBrand.Name = "addBrand";
            this.addBrand.Size = new System.Drawing.Size(88, 36);
            this.addBrand.TabIndex = 17;
            this.addBrand.Text = "Agregar";
            this.addBrand.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.addBrand.UseAccentColor = false;
            this.addBrand.UseVisualStyleBackColor = true;
            this.addBrand.Click += new System.EventHandler(this.addBrand_Click);
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.Location = new System.Drawing.Point(26, 197);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(98, 19);
            this.materialLabel3.TabIndex = 19;
            this.materialLabel3.Text = "Caracteristica";
            // 
            // carac
            // 
            this.carac.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.carac.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.carac.Depth = 0;
            this.carac.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.carac.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.carac.Location = new System.Drawing.Point(139, 197);
            this.carac.MouseState = MaterialSkin.MouseState.HOVER;
            this.carac.Name = "carac";
            this.carac.Size = new System.Drawing.Size(218, 56);
            this.carac.TabIndex = 20;
            this.carac.Text = "";
            // 
            // model
            // 
            this.model.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.model.Depth = 0;
            this.model.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.model.LeadingIcon = null;
            this.model.Location = new System.Drawing.Point(139, 136);
            this.model.MaxLength = 50;
            this.model.MouseState = MaterialSkin.MouseState.OUT;
            this.model.Multiline = false;
            this.model.Name = "model";
            this.model.Size = new System.Drawing.Size(218, 36);
            this.model.TabIndex = 21;
            this.model.Text = "";
            this.model.TrailingIcon = null;
            this.model.UseTallSize = false;
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.Location = new System.Drawing.Point(26, 153);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(54, 19);
            this.materialLabel4.TabIndex = 22;
            this.materialLabel4.Text = "Modelo";
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel5.Location = new System.Drawing.Point(26, 101);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(84, 19);
            this.materialLabel5.TabIndex = 23;
            this.materialLabel5.Text = "Descripción";
            // 
            // desc
            // 
            this.desc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.desc.Depth = 0;
            this.desc.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.desc.LeadingIcon = null;
            this.desc.Location = new System.Drawing.Point(139, 84);
            this.desc.MaxLength = 50;
            this.desc.MouseState = MaterialSkin.MouseState.OUT;
            this.desc.Multiline = false;
            this.desc.Name = "desc";
            this.desc.Size = new System.Drawing.Size(218, 36);
            this.desc.TabIndex = 24;
            this.desc.Text = "";
            this.desc.TrailingIcon = null;
            this.desc.UseTallSize = false;
            // 
            // AddModelo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 391);
            this.Controls.Add(this.desc);
            this.Controls.Add(this.materialLabel5);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.model);
            this.Controls.Add(this.carac);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.addBrand);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.marcas);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.rango);
            this.Controls.Add(this.save);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(485, 391);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(485, 391);
            this.Name = "AddModelo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddModelo";
            this.Load += new System.EventHandler(this.AddModelo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.documentacionDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentacionDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DocumentacionDataSet documentacionDataSet;
        private System.Windows.Forms.BindingSource documentacionDataSetBindingSource;
        private MaterialSkin.Controls.MaterialButton save;
        private MaterialSkin.Controls.MaterialTextBox rango;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialComboBox marcas;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialButton addBrand;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialMultiLineTextBox carac;
        private MaterialSkin.Controls.MaterialTextBox model;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialTextBox desc;
    }
}