namespace CTZ
{
    partial class modEQ
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(modEQ));
            this.disponibilidadBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.documentacionDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.documentacionDataSet = new CTZ.DocumentacionDataSet();
            this.usoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.modeloIBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.modeloITableAdapter = new CTZ.DocumentacionDataSetTableAdapters.ModeloITableAdapter();
            this.usoTableAdapter = new CTZ.DocumentacionDataSetTableAdapters.UsoTableAdapter();
            this.disponibilidadTableAdapter = new CTZ.DocumentacionDataSetTableAdapters.DisponibilidadTableAdapter();
            this.certificadoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.certificadoTableAdapter = new CTZ.DocumentacionDataSetTableAdapters.CertificadoTableAdapter();
            this.label3 = new MaterialSkin.Controls.MaterialLabel();
            this.noserie = new MaterialSkin.Controls.MaterialTextBox();
            this.ident = new MaterialSkin.Controls.MaterialTextBox();
            this.uso = new MaterialSkin.Controls.MaterialComboBox();
            this.disp = new MaterialSkin.Controls.MaterialComboBox();
            this.modelo = new MaterialSkin.Controls.MaterialComboBox();
            this.brand = new MaterialSkin.Controls.MaterialComboBox();
            this.Range = new MaterialSkin.Controls.MaterialTextBox();
            this.certCheck = new MaterialSkin.Controls.MaterialCheckbox();
            this.cert = new MaterialSkin.Controls.MaterialComboBox();
            this.addCert = new MaterialSkin.Controls.MaterialButton();
            this.save = new MaterialSkin.Controls.MaterialButton();
            this.delete = new MaterialSkin.Controls.MaterialButton();
            this.descr = new MaterialSkin.Controls.MaterialMultiLineTextBox();
            this.history = new MaterialSkin.Controls.MaterialButton();
            this.unassign = new MaterialSkin.Controls.MaterialButton();
            ((System.ComponentModel.ISupportInitialize)(this.disponibilidadBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentacionDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentacionDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modeloIBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.certificadoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // disponibilidadBindingSource
            // 
            this.disponibilidadBindingSource.DataMember = "Disponibilidad";
            this.disponibilidadBindingSource.DataSource = this.documentacionDataSetBindingSource;
            // 
            // documentacionDataSetBindingSource
            // 
            this.documentacionDataSetBindingSource.DataSource = this.documentacionDataSet;
            this.documentacionDataSetBindingSource.Position = 0;
            // 
            // documentacionDataSet
            // 
            this.documentacionDataSet.DataSetName = "DocumentacionDataSet";
            this.documentacionDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usoBindingSource
            // 
            this.usoBindingSource.DataMember = "Uso";
            this.usoBindingSource.DataSource = this.documentacionDataSetBindingSource;
            // 
            // modeloIBindingSource
            // 
            this.modeloIBindingSource.DataMember = "ModeloI";
            this.modeloIBindingSource.DataSource = this.documentacionDataSet;
            // 
            // modeloITableAdapter
            // 
            this.modeloITableAdapter.ClearBeforeFill = true;
            // 
            // usoTableAdapter
            // 
            this.usoTableAdapter.ClearBeforeFill = true;
            // 
            // disponibilidadTableAdapter
            // 
            this.disponibilidadTableAdapter.ClearBeforeFill = true;
            // 
            // certificadoBindingSource
            // 
            this.certificadoBindingSource.DataMember = "Certificado";
            this.certificadoBindingSource.DataSource = this.documentacionDataSetBindingSource;
            // 
            // certificadoTableAdapter
            // 
            this.certificadoTableAdapter.ClearBeforeFill = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Depth = 0;
            this.label3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label3.Location = new System.Drawing.Point(32, 76);
            this.label3.MouseState = MaterialSkin.MouseState.HOVER;
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 19);
            this.label3.TabIndex = 37;
            this.label3.Text = "materialLabel1";
            // 
            // noserie
            // 
            this.noserie.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.noserie.Depth = 0;
            this.noserie.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.noserie.Hint = "No. Serie";
            this.noserie.LeadingIcon = null;
            this.noserie.Location = new System.Drawing.Point(80, 120);
            this.noserie.MaxLength = 50;
            this.noserie.MouseState = MaterialSkin.MouseState.OUT;
            this.noserie.Multiline = false;
            this.noserie.Name = "noserie";
            this.noserie.Size = new System.Drawing.Size(323, 50);
            this.noserie.TabIndex = 38;
            this.noserie.Text = "";
            this.noserie.TrailingIcon = null;
            // 
            // ident
            // 
            this.ident.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ident.Depth = 0;
            this.ident.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ident.Hint = "Identificación";
            this.ident.LeadingIcon = null;
            this.ident.Location = new System.Drawing.Point(80, 176);
            this.ident.MaxLength = 50;
            this.ident.MouseState = MaterialSkin.MouseState.OUT;
            this.ident.Multiline = false;
            this.ident.Name = "ident";
            this.ident.Size = new System.Drawing.Size(323, 50);
            this.ident.TabIndex = 39;
            this.ident.Text = "";
            this.ident.TrailingIcon = null;
            // 
            // uso
            // 
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
            this.uso.Location = new System.Drawing.Point(80, 232);
            this.uso.MaxDropDownItems = 4;
            this.uso.MouseState = MaterialSkin.MouseState.OUT;
            this.uso.Name = "uso";
            this.uso.Size = new System.Drawing.Size(323, 49);
            this.uso.StartIndex = 0;
            this.uso.TabIndex = 41;
            this.uso.ValueMember = "IdUso";
            this.uso.SelectedIndexChanged += new System.EventHandler(this.uso_SelectedIndexChanged);
            this.uso.SelectedValueChanged += new System.EventHandler(this.uso_SelectedValueChanged);
            // 
            // disp
            // 
            this.disp.AutoResize = false;
            this.disp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.disp.DataSource = this.disponibilidadBindingSource;
            this.disp.Depth = 0;
            this.disp.DisplayMember = "Descripcion";
            this.disp.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.disp.DropDownHeight = 174;
            this.disp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.disp.DropDownWidth = 121;
            this.disp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.disp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.disp.FormattingEnabled = true;
            this.disp.Hint = "Estatus";
            this.disp.IntegralHeight = false;
            this.disp.ItemHeight = 43;
            this.disp.Location = new System.Drawing.Point(80, 287);
            this.disp.MaxDropDownItems = 4;
            this.disp.MouseState = MaterialSkin.MouseState.OUT;
            this.disp.Name = "disp";
            this.disp.Size = new System.Drawing.Size(323, 49);
            this.disp.StartIndex = 0;
            this.disp.TabIndex = 42;
            this.disp.ValueMember = "IdDisp";
            // 
            // modelo
            // 
            this.modelo.AutoResize = false;
            this.modelo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.modelo.DataSource = this.modeloIBindingSource;
            this.modelo.Depth = 0;
            this.modelo.DisplayMember = "ModeloI";
            this.modelo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.modelo.DropDownHeight = 174;
            this.modelo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.modelo.DropDownWidth = 121;
            this.modelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.modelo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.modelo.FormattingEnabled = true;
            this.modelo.Hint = "Modelo";
            this.modelo.IntegralHeight = false;
            this.modelo.ItemHeight = 43;
            this.modelo.Location = new System.Drawing.Point(80, 397);
            this.modelo.MaxDropDownItems = 4;
            this.modelo.MouseState = MaterialSkin.MouseState.OUT;
            this.modelo.Name = "modelo";
            this.modelo.Size = new System.Drawing.Size(323, 49);
            this.modelo.StartIndex = 0;
            this.modelo.TabIndex = 43;
            this.modelo.ValueMember = "IdModeloI";
            this.modelo.SelectedIndexChanged += new System.EventHandler(this.modelo_SelectedIndexChanged);
            // 
            // brand
            // 
            this.brand.AutoResize = false;
            this.brand.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.brand.Depth = 0;
            this.brand.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.brand.DropDownHeight = 174;
            this.brand.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.brand.DropDownWidth = 121;
            this.brand.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.brand.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.brand.FormattingEnabled = true;
            this.brand.Hint = "Marca";
            this.brand.IntegralHeight = false;
            this.brand.ItemHeight = 43;
            this.brand.Location = new System.Drawing.Point(80, 342);
            this.brand.MaxDropDownItems = 4;
            this.brand.MouseState = MaterialSkin.MouseState.OUT;
            this.brand.Name = "brand";
            this.brand.Size = new System.Drawing.Size(323, 49);
            this.brand.StartIndex = 0;
            this.brand.TabIndex = 44;
            this.brand.SelectedIndexChanged += new System.EventHandler(this.brand_SelectedIndexChanged);
            // 
            // Range
            // 
            this.Range.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Range.Depth = 0;
            this.Range.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Range.Hint = "Rango";
            this.Range.LeadingIcon = null;
            this.Range.Location = new System.Drawing.Point(80, 452);
            this.Range.MaxLength = 50;
            this.Range.MouseState = MaterialSkin.MouseState.OUT;
            this.Range.Multiline = false;
            this.Range.Name = "Range";
            this.Range.Size = new System.Drawing.Size(323, 50);
            this.Range.TabIndex = 45;
            this.Range.Text = "";
            this.Range.TrailingIcon = null;
            // 
            // certCheck
            // 
            this.certCheck.AutoSize = true;
            this.certCheck.Depth = 0;
            this.certCheck.Location = new System.Drawing.Point(42, 609);
            this.certCheck.Margin = new System.Windows.Forms.Padding(0);
            this.certCheck.MouseLocation = new System.Drawing.Point(-1, -1);
            this.certCheck.MouseState = MaterialSkin.MouseState.HOVER;
            this.certCheck.Name = "certCheck";
            this.certCheck.Ripple = true;
            this.certCheck.Size = new System.Drawing.Size(35, 37);
            this.certCheck.TabIndex = 46;
            this.certCheck.UseVisualStyleBackColor = true;
            this.certCheck.CheckedChanged += new System.EventHandler(this.certCheck_CheckedChanged);
            // 
            // cert
            // 
            this.cert.AutoResize = false;
            this.cert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cert.DataSource = this.certificadoBindingSource;
            this.cert.Depth = 0;
            this.cert.DisplayMember = "certificado";
            this.cert.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cert.DropDownHeight = 174;
            this.cert.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cert.DropDownWidth = 121;
            this.cert.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cert.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cert.FormattingEnabled = true;
            this.cert.Hint = "Certificado";
            this.cert.IntegralHeight = false;
            this.cert.ItemHeight = 43;
            this.cert.Location = new System.Drawing.Point(80, 597);
            this.cert.MaxDropDownItems = 4;
            this.cert.MouseState = MaterialSkin.MouseState.OUT;
            this.cert.Name = "cert";
            this.cert.Size = new System.Drawing.Size(323, 49);
            this.cert.StartIndex = 0;
            this.cert.TabIndex = 47;
            this.cert.ValueMember = "IdCertificado";
            // 
            // addCert
            // 
            this.addCert.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.addCert.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.addCert.Depth = 0;
            this.addCert.HighEmphasis = true;
            this.addCert.Icon = null;
            this.addCert.Location = new System.Drawing.Point(418, 608);
            this.addCert.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.addCert.MouseState = MaterialSkin.MouseState.HOVER;
            this.addCert.Name = "addCert";
            this.addCert.Size = new System.Drawing.Size(70, 36);
            this.addCert.TabIndex = 48;
            this.addCert.Text = "Nuevo";
            this.addCert.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.addCert.UseAccentColor = false;
            this.addCert.UseVisualStyleBackColor = true;
            this.addCert.Click += new System.EventHandler(this.addCert_Click);
            // 
            // save
            // 
            this.save.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.save.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.save.Depth = 0;
            this.save.HighEmphasis = true;
            this.save.Icon = null;
            this.save.Location = new System.Drawing.Point(400, 669);
            this.save.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.save.MouseState = MaterialSkin.MouseState.HOVER;
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(88, 36);
            this.save.TabIndex = 49;
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
            this.delete.Location = new System.Drawing.Point(304, 669);
            this.delete.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.delete.MouseState = MaterialSkin.MouseState.HOVER;
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(88, 36);
            this.delete.TabIndex = 50;
            this.delete.Text = "Eliminar";
            this.delete.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.delete.UseAccentColor = false;
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // descr
            // 
            this.descr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.descr.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.descr.Depth = 0;
            this.descr.Enabled = false;
            this.descr.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.descr.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.descr.Location = new System.Drawing.Point(80, 520);
            this.descr.MouseState = MaterialSkin.MouseState.HOVER;
            this.descr.Name = "descr";
            this.descr.Size = new System.Drawing.Size(323, 60);
            this.descr.TabIndex = 51;
            this.descr.Text = "";
            // 
            // history
            // 
            this.history.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.history.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.history.Depth = 0;
            this.history.HighEmphasis = true;
            this.history.Icon = null;
            this.history.Location = new System.Drawing.Point(393, 75);
            this.history.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.history.MouseState = MaterialSkin.MouseState.HOVER;
            this.history.Name = "history";
            this.history.Size = new System.Drawing.Size(95, 36);
            this.history.TabIndex = 52;
            this.history.Text = "Historial";
            this.history.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text;
            this.history.UseAccentColor = false;
            this.history.UseVisualStyleBackColor = true;
            this.history.Click += new System.EventHandler(this.history_Click);
            // 
            // unassign
            // 
            this.unassign.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.unassign.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.unassign.Depth = 0;
            this.unassign.HighEmphasis = true;
            this.unassign.Icon = null;
            this.unassign.Location = new System.Drawing.Point(42, 669);
            this.unassign.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.unassign.MouseState = MaterialSkin.MouseState.HOVER;
            this.unassign.Name = "unassign";
            this.unassign.Size = new System.Drawing.Size(203, 36);
            this.unassign.TabIndex = 53;
            this.unassign.Text = "Desasignar Certificado";
            this.unassign.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.unassign.UseAccentColor = false;
            this.unassign.UseVisualStyleBackColor = true;
            this.unassign.Click += new System.EventHandler(this.materialButton1_Click);
            // 
            // modEQ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 726);
            this.Controls.Add(this.unassign);
            this.Controls.Add(this.history);
            this.Controls.Add(this.descr);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.save);
            this.Controls.Add(this.addCert);
            this.Controls.Add(this.cert);
            this.Controls.Add(this.certCheck);
            this.Controls.Add(this.Range);
            this.Controls.Add(this.brand);
            this.Controls.Add(this.modelo);
            this.Controls.Add(this.disp);
            this.Controls.Add(this.uso);
            this.Controls.Add(this.ident);
            this.Controls.Add(this.noserie);
            this.Controls.Add(this.label3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(510, 726);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(510, 726);
            this.Name = "modEQ";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modificar Equipo";
            this.Load += new System.EventHandler(this.modEQ_Load);
            ((System.ComponentModel.ISupportInitialize)(this.disponibilidadBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentacionDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentacionDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.modeloIBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.certificadoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DocumentacionDataSet documentacionDataSet;
        private System.Windows.Forms.BindingSource modeloIBindingSource;
        private DocumentacionDataSetTableAdapters.ModeloITableAdapter modeloITableAdapter;
        private System.Windows.Forms.BindingSource documentacionDataSetBindingSource;
        private System.Windows.Forms.BindingSource usoBindingSource;
        private DocumentacionDataSetTableAdapters.UsoTableAdapter usoTableAdapter;
        private System.Windows.Forms.BindingSource disponibilidadBindingSource;
        private DocumentacionDataSetTableAdapters.DisponibilidadTableAdapter disponibilidadTableAdapter;
        private System.Windows.Forms.BindingSource certificadoBindingSource;
        private DocumentacionDataSetTableAdapters.CertificadoTableAdapter certificadoTableAdapter;
        private MaterialSkin.Controls.MaterialLabel label3;
        private MaterialSkin.Controls.MaterialTextBox noserie;
        private MaterialSkin.Controls.MaterialTextBox ident;
        private MaterialSkin.Controls.MaterialComboBox uso;
        private MaterialSkin.Controls.MaterialComboBox disp;
        private MaterialSkin.Controls.MaterialComboBox modelo;
        private MaterialSkin.Controls.MaterialComboBox brand;
        private MaterialSkin.Controls.MaterialTextBox Range;
        private MaterialSkin.Controls.MaterialCheckbox certCheck;
        private MaterialSkin.Controls.MaterialComboBox cert;
        private MaterialSkin.Controls.MaterialButton addCert;
        private MaterialSkin.Controls.MaterialButton save;
        private MaterialSkin.Controls.MaterialButton delete;
        private MaterialSkin.Controls.MaterialMultiLineTextBox descr;
        private MaterialSkin.Controls.MaterialButton history;
        private MaterialSkin.Controls.MaterialButton unassign;
    }
}