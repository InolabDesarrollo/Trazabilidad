namespace CTZ
{
    partial class AddDetalleCert
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddDetalleCert));
            this.certificado = new MaterialSkin.Controls.MaterialTextBox();
            this.uso = new MaterialSkin.Controls.MaterialComboBox();
            this.usoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.documentacionDataSet = new CTZ.DocumentacionDataSet();
            this.usoTableAdapter = new CTZ.DocumentacionDataSetTableAdapters.UsoTableAdapter();
            this.save = new MaterialSkin.Controls.MaterialButton();
            ((System.ComponentModel.ISupportInitialize)(this.usoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentacionDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // certificado
            // 
            this.certificado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.certificado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.certificado.Depth = 0;
            this.certificado.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.certificado.Hint = "Certificado";
            this.certificado.LeadingIcon = null;
            this.certificado.Location = new System.Drawing.Point(48, 104);
            this.certificado.MaxLength = 50;
            this.certificado.MouseState = MaterialSkin.MouseState.OUT;
            this.certificado.Multiline = false;
            this.certificado.Name = "certificado";
            this.certificado.Size = new System.Drawing.Size(306, 50);
            this.certificado.TabIndex = 0;
            this.certificado.Text = "";
            this.certificado.TrailingIcon = null;
            // 
            // uso
            // 
            this.uso.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uso.AutoResize = false;
            this.uso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.uso.DataSource = this.usoBindingSource;
            this.uso.Depth = 0;
            this.uso.DisplayMember = "Descripcion";
            this.uso.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.uso.DropDownHeight = 174;
            this.uso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.uso.DropDownWidth = 121;
            this.uso.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.uso.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uso.FormattingEnabled = true;
            this.uso.Hint = "Uso";
            this.uso.IntegralHeight = false;
            this.uso.ItemHeight = 43;
            this.uso.Location = new System.Drawing.Point(48, 201);
            this.uso.MaxDropDownItems = 4;
            this.uso.MouseState = MaterialSkin.MouseState.OUT;
            this.uso.Name = "uso";
            this.uso.Size = new System.Drawing.Size(306, 49);
            this.uso.StartIndex = 0;
            this.uso.TabIndex = 1;
            this.uso.ValueMember = "IdUso";
            this.uso.SelectedIndexChanged += new System.EventHandler(this.uso_SelectedIndexChanged);
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
            // save
            // 
            this.save.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.save.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.save.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.save.Depth = 0;
            this.save.HighEmphasis = true;
            this.save.Icon = null;
            this.save.Location = new System.Drawing.Point(295, 284);
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
            // AddDetalleCert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 342);
            this.Controls.Add(this.save);
            this.Controls.Add(this.uso);
            this.Controls.Add(this.certificado);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddDetalleCert";
            this.Load += new System.EventHandler(this.AddDetalleCert_Load);
            ((System.ComponentModel.ISupportInitialize)(this.usoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentacionDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialTextBox certificado;
        private MaterialSkin.Controls.MaterialComboBox uso;
        private DocumentacionDataSet documentacionDataSet;
        private System.Windows.Forms.BindingSource usoBindingSource;
        private DocumentacionDataSetTableAdapters.UsoTableAdapter usoTableAdapter;
        private MaterialSkin.Controls.MaterialButton save;
    }
}