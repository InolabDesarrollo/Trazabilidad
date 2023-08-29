namespace CTZ
{
    partial class ModUsosCert
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModUsosCert));
            this.save = new MaterialSkin.Controls.MaterialButton();
            this.delete = new MaterialSkin.Controls.MaterialButton();
            this.materialComboBox1 = new MaterialSkin.Controls.MaterialComboBox();
            this.usoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.documentacionDataSet = new CTZ.DocumentacionDataSet();
            this.usoTableAdapter = new CTZ.DocumentacionDataSetTableAdapters.UsoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.usoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentacionDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // save
            // 
            this.save.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.save.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.save.Depth = 0;
            this.save.HighEmphasis = true;
            this.save.Icon = null;
            this.save.Location = new System.Drawing.Point(354, 405);
            this.save.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.save.MouseState = MaterialSkin.MouseState.HOVER;
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(88, 36);
            this.save.TabIndex = 0;
            this.save.Text = "Guardar";
            this.save.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.save.UseAccentColor = false;
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // delete
            // 
            this.delete.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.delete.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.delete.Depth = 0;
            this.delete.HighEmphasis = true;
            this.delete.Icon = null;
            this.delete.Location = new System.Drawing.Point(7, 405);
            this.delete.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.delete.MouseState = MaterialSkin.MouseState.HOVER;
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(88, 36);
            this.delete.TabIndex = 1;
            this.delete.Text = "Eliminar";
            this.delete.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.delete.UseAccentColor = false;
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // materialComboBox1
            // 
            this.materialComboBox1.AutoResize = false;
            this.materialComboBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialComboBox1.DataSource = this.usoBindingSource;
            this.materialComboBox1.Depth = 0;
            this.materialComboBox1.DisplayMember = "Descripcion";
            this.materialComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.materialComboBox1.DropDownHeight = 174;
            this.materialComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.materialComboBox1.DropDownWidth = 121;
            this.materialComboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialComboBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialComboBox1.FormattingEnabled = true;
            this.materialComboBox1.Hint = "Uso";
            this.materialComboBox1.IntegralHeight = false;
            this.materialComboBox1.ItemHeight = 43;
            this.materialComboBox1.Location = new System.Drawing.Point(53, 208);
            this.materialComboBox1.MaxDropDownItems = 4;
            this.materialComboBox1.MouseState = MaterialSkin.MouseState.OUT;
            this.materialComboBox1.Name = "materialComboBox1";
            this.materialComboBox1.Size = new System.Drawing.Size(338, 49);
            this.materialComboBox1.StartIndex = 0;
            this.materialComboBox1.TabIndex = 2;
            this.materialComboBox1.ValueMember = "IdUso";
            // 
            // usoBindingSource
            // 
            this.usoBindingSource.DataMember = "Uso";
            this.usoBindingSource.DataSource = this.documentacionDataSet;
            // 
            // documentacionDataSet
            // 
            this.documentacionDataSet.DataSetName = "DocumentacionDataSet";
            this.documentacionDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usoTableAdapter
            // 
            this.usoTableAdapter.ClearBeforeFill = true;
            // 
            // ModUsosCert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 450);
            this.Controls.Add(this.materialComboBox1);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.save);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(449, 450);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(449, 450);
            this.Name = "ModUsosCert";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ModUsosCert";
            this.Load += new System.EventHandler(this.ModUsosCert_Load);
            ((System.ComponentModel.ISupportInitialize)(this.usoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentacionDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialButton save;
        private MaterialSkin.Controls.MaterialButton delete;
        private MaterialSkin.Controls.MaterialComboBox materialComboBox1;
        private DocumentacionDataSet documentacionDataSet;
        private System.Windows.Forms.BindingSource usoBindingSource;
        private DocumentacionDataSetTableAdapters.UsoTableAdapter usoTableAdapter;
    }
}