namespace CTZ
{
    partial class AddPuntos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddPuntos));
            this.magnitudesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.documentacionDataSet = new CTZ.DocumentacionDataSet();
            this.certificadoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.magnitudesTableAdapter = new CTZ.DocumentacionDataSetTableAdapters.MagnitudesTableAdapter();
            this.certificadoTableAdapter = new CTZ.DocumentacionDataSetTableAdapters.CertificadoTableAdapter();
            this.valor = new MaterialSkin.Controls.MaterialTextBox();
            this.incertidumbre = new MaterialSkin.Controls.MaterialTextBox();
            this.magnitud = new MaterialSkin.Controls.MaterialComboBox();
            this.certificado = new MaterialSkin.Controls.MaterialComboBox();
            this.save = new MaterialSkin.Controls.MaterialButton();
            this.add = new MaterialSkin.Controls.MaterialButton();
            ((System.ComponentModel.ISupportInitialize)(this.magnitudesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentacionDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.certificadoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // magnitudesBindingSource
            // 
            this.magnitudesBindingSource.DataMember = "Magnitudes";
            this.magnitudesBindingSource.DataSource = this.documentacionDataSet;
            // 
            // documentacionDataSet
            // 
            this.documentacionDataSet.DataSetName = "DocumentacionDataSet";
            this.documentacionDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // certificadoBindingSource
            // 
            this.certificadoBindingSource.DataMember = "Certificado";
            this.certificadoBindingSource.DataSource = this.documentacionDataSet;
            // 
            // magnitudesTableAdapter
            // 
            this.magnitudesTableAdapter.ClearBeforeFill = true;
            // 
            // certificadoTableAdapter
            // 
            this.certificadoTableAdapter.ClearBeforeFill = true;
            // 
            // valor
            // 
            this.valor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.valor.Depth = 0;
            this.valor.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.valor.Hint = "Valor";
            this.valor.LeadingIcon = null;
            this.valor.Location = new System.Drawing.Point(64, 83);
            this.valor.MaxLength = 50;
            this.valor.MouseState = MaterialSkin.MouseState.OUT;
            this.valor.Multiline = false;
            this.valor.Name = "valor";
            this.valor.Size = new System.Drawing.Size(222, 50);
            this.valor.TabIndex = 9;
            this.valor.Text = "";
            this.valor.TrailingIcon = null;
            // 
            // incertidumbre
            // 
            this.incertidumbre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.incertidumbre.Depth = 0;
            this.incertidumbre.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.incertidumbre.Hint = "Incertidumbre";
            this.incertidumbre.LeadingIcon = null;
            this.incertidumbre.Location = new System.Drawing.Point(64, 148);
            this.incertidumbre.MaxLength = 50;
            this.incertidumbre.MouseState = MaterialSkin.MouseState.OUT;
            this.incertidumbre.Multiline = false;
            this.incertidumbre.Name = "incertidumbre";
            this.incertidumbre.Size = new System.Drawing.Size(222, 50);
            this.incertidumbre.TabIndex = 10;
            this.incertidumbre.Text = "";
            this.incertidumbre.TrailingIcon = null;
            // 
            // magnitud
            // 
            this.magnitud.AutoResize = false;
            this.magnitud.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.magnitud.DataSource = this.magnitudesBindingSource;
            this.magnitud.Depth = 0;
            this.magnitud.DisplayMember = "Descripcion";
            this.magnitud.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.magnitud.DropDownHeight = 174;
            this.magnitud.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.magnitud.DropDownWidth = 121;
            this.magnitud.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.magnitud.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.magnitud.FormattingEnabled = true;
            this.magnitud.Hint = "Magnitud";
            this.magnitud.IntegralHeight = false;
            this.magnitud.ItemHeight = 43;
            this.magnitud.Location = new System.Drawing.Point(64, 216);
            this.magnitud.MaxDropDownItems = 4;
            this.magnitud.MouseState = MaterialSkin.MouseState.OUT;
            this.magnitud.Name = "magnitud";
            this.magnitud.Size = new System.Drawing.Size(222, 49);
            this.magnitud.StartIndex = 0;
            this.magnitud.TabIndex = 11;
            this.magnitud.ValueMember = "IdMagnitudes";
            // 
            // certificado
            // 
            this.certificado.AutoResize = false;
            this.certificado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.certificado.DataSource = this.certificadoBindingSource;
            this.certificado.Depth = 0;
            this.certificado.DisplayMember = "certificado";
            this.certificado.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.certificado.DropDownHeight = 174;
            this.certificado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.certificado.DropDownWidth = 121;
            this.certificado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.certificado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.certificado.FormattingEnabled = true;
            this.certificado.Hint = "Certificado";
            this.certificado.IntegralHeight = false;
            this.certificado.ItemHeight = 43;
            this.certificado.Location = new System.Drawing.Point(64, 285);
            this.certificado.MaxDropDownItems = 4;
            this.certificado.MouseState = MaterialSkin.MouseState.OUT;
            this.certificado.Name = "certificado";
            this.certificado.Size = new System.Drawing.Size(222, 49);
            this.certificado.StartIndex = 0;
            this.certificado.TabIndex = 12;
            this.certificado.ValueMember = "IdCertificado";
            // 
            // save
            // 
            this.save.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.save.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.save.Depth = 0;
            this.save.HighEmphasis = true;
            this.save.Icon = null;
            this.save.Location = new System.Drawing.Point(288, 349);
            this.save.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.save.MouseState = MaterialSkin.MouseState.HOVER;
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(88, 36);
            this.save.TabIndex = 13;
            this.save.Text = "Guardar";
            this.save.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.save.UseAccentColor = false;
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // add
            // 
            this.add.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.add.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.add.Depth = 0;
            this.add.HighEmphasis = true;
            this.add.Icon = null;
            this.add.Location = new System.Drawing.Point(293, 229);
            this.add.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.add.MouseState = MaterialSkin.MouseState.HOVER;
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(88, 36);
            this.add.TabIndex = 14;
            this.add.Text = "AGREGAR";
            this.add.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.add.UseAccentColor = false;
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // AddPuntos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 394);
            this.Controls.Add(this.add);
            this.Controls.Add(this.save);
            this.Controls.Add(this.certificado);
            this.Controls.Add(this.magnitud);
            this.Controls.Add(this.incertidumbre);
            this.Controls.Add(this.valor);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(383, 394);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(383, 394);
            this.Name = "AddPuntos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Puntos de calibración";
            this.Load += new System.EventHandler(this.AddPuntos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.magnitudesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentacionDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.certificadoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DocumentacionDataSet documentacionDataSet;
        private System.Windows.Forms.BindingSource magnitudesBindingSource;
        private DocumentacionDataSetTableAdapters.MagnitudesTableAdapter magnitudesTableAdapter;
        private System.Windows.Forms.BindingSource certificadoBindingSource;
        private DocumentacionDataSetTableAdapters.CertificadoTableAdapter certificadoTableAdapter;
        private MaterialSkin.Controls.MaterialTextBox valor;
        private MaterialSkin.Controls.MaterialTextBox incertidumbre;
        private MaterialSkin.Controls.MaterialComboBox magnitud;
        private MaterialSkin.Controls.MaterialComboBox certificado;
        private MaterialSkin.Controls.MaterialButton save;
        private MaterialSkin.Controls.MaterialButton add;
    }
}