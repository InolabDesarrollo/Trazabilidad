namespace CTZ
{
    partial class AddEquipo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddEquipo));
            this.usoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.documentacionDataSet = new CTZ.DocumentacionDataSet();
            this.disponibilidadBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.modeloIBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.certificadoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usoTableAdapter = new CTZ.DocumentacionDataSetTableAdapters.UsoTableAdapter();
            this.disponibilidadTableAdapter = new CTZ.DocumentacionDataSetTableAdapters.DisponibilidadTableAdapter();
            this.modeloIBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.modeloITableAdapter = new CTZ.DocumentacionDataSetTableAdapters.ModeloITableAdapter();
            this.certificadoTableAdapter = new CTZ.DocumentacionDataSetTableAdapters.CertificadoTableAdapter();
            this.equipoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.documentacionDataSet1 = new CTZ.DocumentacionDataSet1();
            this.equipoTableAdapter = new CTZ.DocumentacionDataSet1TableAdapters.EquipoTableAdapter();
            this.fKDetalleEqIdMod18EBB532BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.detalleEquipoTableAdapter = new CTZ.DocumentacionDataSetTableAdapters.DetalleEquipoTableAdapter();
            this.save = new MaterialSkin.Controls.MaterialButton();
            this.certChBx = new MaterialSkin.Controls.MaterialCheckbox();
            this.certificado = new MaterialSkin.Controls.MaterialComboBox();
            this.addCert = new MaterialSkin.Controls.MaterialButton();
            this.modelo = new MaterialSkin.Controls.MaterialComboBox();
            this.addMod = new MaterialSkin.Controls.MaterialButton();
            this.disp = new MaterialSkin.Controls.MaterialComboBox();
            this.uso = new MaterialSkin.Controls.MaterialComboBox();
            this.equipo = new MaterialSkin.Controls.MaterialComboBox();
            this.observaciones = new MaterialSkin.Controls.MaterialMultiLineTextBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.descr = new MaterialSkin.Controls.MaterialMultiLineTextBox();
            this.Range = new MaterialSkin.Controls.MaterialTextBox();
            this.brand = new MaterialSkin.Controls.MaterialComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.usoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentacionDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.disponibilidadBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modeloIBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.certificadoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modeloIBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentacionDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKDetalleEqIdMod18EBB532BindingSource)).BeginInit();
            this.SuspendLayout();
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
            // disponibilidadBindingSource
            // 
            this.disponibilidadBindingSource.DataMember = "Disponibilidad";
            this.disponibilidadBindingSource.DataSource = this.documentacionDataSet;
            // 
            // modeloIBindingSource1
            // 
            this.modeloIBindingSource1.DataMember = "ModeloI";
            this.modeloIBindingSource1.DataSource = this.documentacionDataSet;
            // 
            // certificadoBindingSource
            // 
            this.certificadoBindingSource.DataMember = "Certificado";
            this.certificadoBindingSource.DataSource = this.documentacionDataSet;
            // 
            // usoTableAdapter
            // 
            this.usoTableAdapter.ClearBeforeFill = true;
            // 
            // disponibilidadTableAdapter
            // 
            this.disponibilidadTableAdapter.ClearBeforeFill = true;
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
            // certificadoTableAdapter
            // 
            this.certificadoTableAdapter.ClearBeforeFill = true;
            // 
            // equipoBindingSource
            // 
            this.equipoBindingSource.DataMember = "Equipo";
            this.equipoBindingSource.DataSource = this.documentacionDataSet1;
            // 
            // documentacionDataSet1
            // 
            this.documentacionDataSet1.DataSetName = "DocumentacionDataSet1";
            this.documentacionDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // equipoTableAdapter
            // 
            this.equipoTableAdapter.ClearBeforeFill = true;
            // 
            // fKDetalleEqIdMod18EBB532BindingSource
            // 
            this.fKDetalleEqIdMod18EBB532BindingSource.DataMember = "FK__DetalleEq__IdMod__18EBB532";
            this.fKDetalleEqIdMod18EBB532BindingSource.DataSource = this.modeloIBindingSource1;
            // 
            // detalleEquipoTableAdapter
            // 
            this.detalleEquipoTableAdapter.ClearBeforeFill = true;
            // 
            // save
            // 
            this.save.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.save.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.save.Depth = 0;
            this.save.HighEmphasis = true;
            this.save.Icon = null;
            this.save.Location = new System.Drawing.Point(362, 681);
            this.save.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.save.MouseState = MaterialSkin.MouseState.HOVER;
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(88, 36);
            this.save.TabIndex = 18;
            this.save.Text = "Guardar";
            this.save.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.save.UseAccentColor = false;
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // certChBx
            // 
            this.certChBx.AutoSize = true;
            this.certChBx.Depth = 0;
            this.certChBx.Location = new System.Drawing.Point(18, 538);
            this.certChBx.Margin = new System.Windows.Forms.Padding(0);
            this.certChBx.MouseLocation = new System.Drawing.Point(-1, -1);
            this.certChBx.MouseState = MaterialSkin.MouseState.HOVER;
            this.certChBx.Name = "certChBx";
            this.certChBx.Ripple = true;
            this.certChBx.Size = new System.Drawing.Size(112, 37);
            this.certChBx.TabIndex = 19;
            this.certChBx.Text = "Certificado";
            this.certChBx.UseVisualStyleBackColor = true;
            this.certChBx.CheckedChanged += new System.EventHandler(this.certChBx_CheckedChanged);
            // 
            // certificado
            // 
            this.certificado.AutoResize = false;
            this.certificado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.certificado.DataSource = this.certificadoBindingSource;
            this.certificado.Depth = 0;
            this.certificado.DisplayMember = "certificado";
            this.certificado.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.certificado.DropDownHeight = 118;
            this.certificado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.certificado.DropDownWidth = 121;
            this.certificado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.certificado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.certificado.FormattingEnabled = true;
            this.certificado.IntegralHeight = false;
            this.certificado.ItemHeight = 29;
            this.certificado.Location = new System.Drawing.Point(144, 538);
            this.certificado.MaxDropDownItems = 4;
            this.certificado.MouseState = MaterialSkin.MouseState.OUT;
            this.certificado.Name = "certificado";
            this.certificado.Size = new System.Drawing.Size(184, 35);
            this.certificado.StartIndex = 0;
            this.certificado.TabIndex = 20;
            this.certificado.UseTallSize = false;
            this.certificado.ValueMember = "IdCertificado";
            this.certificado.SelectedIndexChanged += new System.EventHandler(this.certificado_SelectedIndexChanged);
            // 
            // addCert
            // 
            this.addCert.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.addCert.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.addCert.Depth = 0;
            this.addCert.HighEmphasis = true;
            this.addCert.Icon = null;
            this.addCert.Location = new System.Drawing.Point(362, 540);
            this.addCert.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.addCert.MouseState = MaterialSkin.MouseState.HOVER;
            this.addCert.Name = "addCert";
            this.addCert.Size = new System.Drawing.Size(88, 36);
            this.addCert.TabIndex = 21;
            this.addCert.Text = "Agregar";
            this.addCert.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.addCert.UseAccentColor = false;
            this.addCert.UseVisualStyleBackColor = true;
            this.addCert.Click += new System.EventHandler(this.addCert_Click);
            // 
            // modelo
            // 
            this.modelo.AutoResize = false;
            this.modelo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.modelo.DataSource = this.modeloIBindingSource1;
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
            this.modelo.Location = new System.Drawing.Point(39, 335);
            this.modelo.MaxDropDownItems = 4;
            this.modelo.MouseState = MaterialSkin.MouseState.OUT;
            this.modelo.Name = "modelo";
            this.modelo.Size = new System.Drawing.Size(289, 49);
            this.modelo.StartIndex = 0;
            this.modelo.TabIndex = 22;
            this.modelo.ValueMember = "IdModeloI";
            this.modelo.SelectedIndexChanged += new System.EventHandler(this.modelo_SelectedIndexChanged);
            // 
            // addMod
            // 
            this.addMod.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.addMod.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.addMod.Depth = 0;
            this.addMod.HighEmphasis = true;
            this.addMod.Icon = null;
            this.addMod.Location = new System.Drawing.Point(362, 348);
            this.addMod.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.addMod.MouseState = MaterialSkin.MouseState.HOVER;
            this.addMod.Name = "addMod";
            this.addMod.Size = new System.Drawing.Size(88, 36);
            this.addMod.TabIndex = 24;
            this.addMod.Text = "Agregar";
            this.addMod.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.addMod.UseAccentColor = false;
            this.addMod.UseVisualStyleBackColor = true;
            this.addMod.Click += new System.EventHandler(this.button1_Click);
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
            this.disp.Location = new System.Drawing.Point(39, 208);
            this.disp.MaxDropDownItems = 4;
            this.disp.MouseState = MaterialSkin.MouseState.OUT;
            this.disp.Name = "disp";
            this.disp.Size = new System.Drawing.Size(289, 49);
            this.disp.StartIndex = 0;
            this.disp.TabIndex = 26;
            this.disp.ValueMember = "IdDisp";
            this.disp.SelectedIndexChanged += new System.EventHandler(this.disp_SelectedIndexChanged);
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
            this.uso.Location = new System.Drawing.Point(39, 140);
            this.uso.MaxDropDownItems = 4;
            this.uso.MouseState = MaterialSkin.MouseState.OUT;
            this.uso.Name = "uso";
            this.uso.Size = new System.Drawing.Size(289, 49);
            this.uso.StartIndex = 0;
            this.uso.TabIndex = 27;
            this.uso.ValueMember = "IdUso";
            this.uso.SelectedIndexChanged += new System.EventHandler(this.uso_SelectedIndexChanged);
            // 
            // equipo
            // 
            this.equipo.AutoResize = false;
            this.equipo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.equipo.DataSource = this.equipoBindingSource;
            this.equipo.Depth = 0;
            this.equipo.DisplayMember = "Identificacion";
            this.equipo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.equipo.DropDownHeight = 174;
            this.equipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.equipo.DropDownWidth = 121;
            this.equipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.equipo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.equipo.FormattingEnabled = true;
            this.equipo.Hint = "Equipo";
            this.equipo.IntegralHeight = false;
            this.equipo.ItemHeight = 43;
            this.equipo.Location = new System.Drawing.Point(39, 76);
            this.equipo.MaxDropDownItems = 4;
            this.equipo.MouseState = MaterialSkin.MouseState.OUT;
            this.equipo.Name = "equipo";
            this.equipo.Size = new System.Drawing.Size(289, 49);
            this.equipo.StartIndex = 0;
            this.equipo.TabIndex = 29;
            this.equipo.ValueMember = "IdEquipo";
            this.equipo.SelectedIndexChanged += new System.EventHandler(this.equipo_SelectedIndexChanged);
            // 
            // observaciones
            // 
            this.observaciones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.observaciones.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.observaciones.Depth = 0;
            this.observaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.observaciones.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.observaciones.Hint = "Observaciones";
            this.observaciones.Location = new System.Drawing.Point(39, 618);
            this.observaciones.MouseState = MaterialSkin.MouseState.HOVER;
            this.observaciones.Name = "observaciones";
            this.observaciones.Size = new System.Drawing.Size(289, 72);
            this.observaciones.TabIndex = 31;
            this.observaciones.Text = "";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(39, 590);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(109, 19);
            this.materialLabel1.TabIndex = 32;
            this.materialLabel1.Text = "Observaciones:";
            // 
            // descr
            // 
            this.descr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.descr.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.descr.Depth = 0;
            this.descr.Enabled = false;
            this.descr.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.descr.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.descr.Location = new System.Drawing.Point(39, 465);
            this.descr.MouseState = MaterialSkin.MouseState.HOVER;
            this.descr.Name = "descr";
            this.descr.Size = new System.Drawing.Size(289, 60);
            this.descr.TabIndex = 54;
            this.descr.Text = "";
            // 
            // Range
            // 
            this.Range.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Range.Depth = 0;
            this.Range.Enabled = false;
            this.Range.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Range.Hint = "Rango";
            this.Range.LeadingIcon = null;
            this.Range.Location = new System.Drawing.Point(42, 399);
            this.Range.MaxLength = 50;
            this.Range.MouseState = MaterialSkin.MouseState.OUT;
            this.Range.Multiline = false;
            this.Range.Name = "Range";
            this.Range.Size = new System.Drawing.Size(286, 50);
            this.Range.TabIndex = 53;
            this.Range.Text = "";
            this.Range.TrailingIcon = null;
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
            this.brand.Location = new System.Drawing.Point(39, 273);
            this.brand.MaxDropDownItems = 4;
            this.brand.MouseState = MaterialSkin.MouseState.OUT;
            this.brand.Name = "brand";
            this.brand.Size = new System.Drawing.Size(286, 49);
            this.brand.StartIndex = 0;
            this.brand.TabIndex = 52;
            this.brand.SelectedIndexChanged += new System.EventHandler(this.brand_SelectedIndexChanged);
            // 
            // AddEquipo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 726);
            this.Controls.Add(this.descr);
            this.Controls.Add(this.Range);
            this.Controls.Add(this.brand);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.observaciones);
            this.Controls.Add(this.equipo);
            this.Controls.Add(this.uso);
            this.Controls.Add(this.disp);
            this.Controls.Add(this.addMod);
            this.Controls.Add(this.modelo);
            this.Controls.Add(this.addCert);
            this.Controls.Add(this.certificado);
            this.Controls.Add(this.certChBx);
            this.Controls.Add(this.save);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(480, 726);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(480, 726);
            this.Name = "AddEquipo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Detalle del equipo";
            this.Load += new System.EventHandler(this.AddEquipo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.usoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentacionDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.disponibilidadBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.modeloIBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.certificadoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.modeloIBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentacionDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKDetalleEqIdMod18EBB532BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DocumentacionDataSet documentacionDataSet;
        private System.Windows.Forms.BindingSource usoBindingSource;
        private DocumentacionDataSetTableAdapters.UsoTableAdapter usoTableAdapter;
        private System.Windows.Forms.BindingSource disponibilidadBindingSource;
        private DocumentacionDataSetTableAdapters.DisponibilidadTableAdapter disponibilidadTableAdapter;
        private System.Windows.Forms.BindingSource modeloIBindingSource;
        private DocumentacionDataSetTableAdapters.ModeloITableAdapter modeloITableAdapter;
        private System.Windows.Forms.BindingSource modeloIBindingSource1;
        private System.Windows.Forms.BindingSource certificadoBindingSource;
        private DocumentacionDataSetTableAdapters.CertificadoTableAdapter certificadoTableAdapter;
        private DocumentacionDataSet1 documentacionDataSet1;
        private System.Windows.Forms.BindingSource equipoBindingSource;
        private DocumentacionDataSet1TableAdapters.EquipoTableAdapter equipoTableAdapter;
        private System.Windows.Forms.BindingSource fKDetalleEqIdMod18EBB532BindingSource;
        private DocumentacionDataSetTableAdapters.DetalleEquipoTableAdapter detalleEquipoTableAdapter;
        private MaterialSkin.Controls.MaterialButton save;
        private MaterialSkin.Controls.MaterialCheckbox certChBx;
        private MaterialSkin.Controls.MaterialComboBox certificado;
        private MaterialSkin.Controls.MaterialButton addCert;
        private MaterialSkin.Controls.MaterialComboBox modelo;
        private MaterialSkin.Controls.MaterialButton addMod;
        private MaterialSkin.Controls.MaterialComboBox disp;
        private MaterialSkin.Controls.MaterialComboBox uso;
        private MaterialSkin.Controls.MaterialComboBox equipo;
        private MaterialSkin.Controls.MaterialMultiLineTextBox observaciones;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialMultiLineTextBox descr;
        private MaterialSkin.Controls.MaterialTextBox Range;
        private MaterialSkin.Controls.MaterialComboBox brand;
    }
}