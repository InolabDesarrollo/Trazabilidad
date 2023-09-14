namespace CTZ
{
    partial class AddCert
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddCert));
            this.calibracion = new System.Windows.Forms.DateTimePicker();
            this.nxtCalibracion = new System.Windows.Forms.DateTimePicker();
            this.usoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.documentacionDataSet = new CTZ.DocumentacionDataSet();
            this.usoTableAdapter = new CTZ.DocumentacionDataSetTableAdapters.UsoTableAdapter();
            this.intervalo = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.link = new MaterialSkin.Controls.MaterialTextBox();
            this.cert = new MaterialSkin.Controls.MaterialTextBox();
            this.use = new MaterialSkin.Controls.MaterialComboBox();
            this.save = new MaterialSkin.Controls.MaterialButton();
            this.Lab = new MaterialSkin.Controls.MaterialComboBox();
            this.laboratorioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSctz = new CTZ.DSctz();
            this.laboratorioTableAdapter = new CTZ.DSctzTableAdapters.LaboratorioTableAdapter();
            this.materialButton1 = new MaterialSkin.Controls.MaterialButton();
            this.unassign = new MaterialSkin.Controls.MaterialButton();
            ((System.ComponentModel.ISupportInitialize)(this.usoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentacionDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.laboratorioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSctz)).BeginInit();
            this.SuspendLayout();
            // 
            // calibracion
            // 
            this.calibracion.Location = new System.Drawing.Point(249, 147);
            this.calibracion.Name = "calibracion";
            this.calibracion.Size = new System.Drawing.Size(200, 20);
            this.calibracion.TabIndex = 6;
            this.calibracion.ValueChanged += new System.EventHandler(this.calibracion_ValueChanged);
            // 
            // nxtCalibracion
            // 
            this.nxtCalibracion.Location = new System.Drawing.Point(249, 188);
            this.nxtCalibracion.Name = "nxtCalibracion";
            this.nxtCalibracion.Size = new System.Drawing.Size(200, 20);
            this.nxtCalibracion.TabIndex = 7;
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
            // intervalo
            // 
            this.intervalo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.intervalo.Depth = 0;
            this.intervalo.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.intervalo.Hint = "Intervalo de medida";
            this.intervalo.LeadingIcon = null;
            this.intervalo.Location = new System.Drawing.Point(90, 78);
            this.intervalo.MaxLength = 250;
            this.intervalo.MouseState = MaterialSkin.MouseState.OUT;
            this.intervalo.Multiline = false;
            this.intervalo.Name = "intervalo";
            this.intervalo.Size = new System.Drawing.Size(359, 50);
            this.intervalo.TabIndex = 13;
            this.intervalo.Text = "";
            this.intervalo.TrailingIcon = null;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(89, 148);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(147, 19);
            this.materialLabel1.TabIndex = 14;
            this.materialLabel1.Text = "Fecha de calibración";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(89, 188);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(142, 19);
            this.materialLabel2.TabIndex = 15;
            this.materialLabel2.Text = "Proxíma calibración";
            // 
            // link
            // 
            this.link.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.link.Depth = 0;
            this.link.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.link.Hint = "Link al certifiado";
            this.link.LeadingIcon = null;
            this.link.Location = new System.Drawing.Point(90, 227);
            this.link.MaxLength = 280;
            this.link.MouseState = MaterialSkin.MouseState.OUT;
            this.link.Multiline = false;
            this.link.Name = "link";
            this.link.Size = new System.Drawing.Size(359, 50);
            this.link.TabIndex = 16;
            this.link.Text = "";
            this.link.TrailingIcon = null;
            // 
            // cert
            // 
            this.cert.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cert.Depth = 0;
            this.cert.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.cert.Hint = "No. de certificado";
            this.cert.LeadingIcon = null;
            this.cert.Location = new System.Drawing.Point(92, 295);
            this.cert.MaxLength = 50;
            this.cert.MouseState = MaterialSkin.MouseState.OUT;
            this.cert.Multiline = false;
            this.cert.Name = "cert";
            this.cert.Size = new System.Drawing.Size(357, 50);
            this.cert.TabIndex = 17;
            this.cert.Text = "";
            this.cert.TrailingIcon = null;
            // 
            // use
            // 
            this.use.AutoResize = false;
            this.use.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.use.DataSource = this.usoBindingSource;
            this.use.Depth = 0;
            this.use.DisplayMember = "Descripcion";
            this.use.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.use.DropDownHeight = 174;
            this.use.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.use.DropDownWidth = 121;
            this.use.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.use.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.use.FormattingEnabled = true;
            this.use.Hint = "Uso";
            this.use.IntegralHeight = false;
            this.use.ItemHeight = 43;
            this.use.Location = new System.Drawing.Point(92, 367);
            this.use.MaxDropDownItems = 4;
            this.use.MouseState = MaterialSkin.MouseState.OUT;
            this.use.Name = "use";
            this.use.Size = new System.Drawing.Size(357, 49);
            this.use.StartIndex = 0;
            this.use.TabIndex = 18;
            this.use.ValueMember = "IdUso";
            // 
            // save
            // 
            this.save.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.save.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.save.Depth = 0;
            this.save.HighEmphasis = true;
            this.save.Icon = null;
            this.save.Location = new System.Drawing.Point(361, 505);
            this.save.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.save.MouseState = MaterialSkin.MouseState.HOVER;
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(88, 36);
            this.save.TabIndex = 19;
            this.save.Text = "Guardar";
            this.save.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.save.UseAccentColor = false;
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // Lab
            // 
            this.Lab.AutoResize = false;
            this.Lab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Lab.DataSource = this.laboratorioBindingSource;
            this.Lab.Depth = 0;
            this.Lab.DisplayMember = "Nombre";
            this.Lab.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.Lab.DropDownHeight = 174;
            this.Lab.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Lab.DropDownWidth = 121;
            this.Lab.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.Lab.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Lab.FormattingEnabled = true;
            this.Lab.Hint = "Laboratorio";
            this.Lab.IntegralHeight = false;
            this.Lab.ItemHeight = 43;
            this.Lab.Location = new System.Drawing.Point(92, 431);
            this.Lab.MaxDropDownItems = 4;
            this.Lab.MouseState = MaterialSkin.MouseState.OUT;
            this.Lab.Name = "Lab";
            this.Lab.Size = new System.Drawing.Size(357, 49);
            this.Lab.StartIndex = 0;
            this.Lab.TabIndex = 20;
            this.Lab.ValueMember = "IdLaboratorio";
            // 
            // laboratorioBindingSource
            // 
            this.laboratorioBindingSource.DataMember = "Laboratorio";
            this.laboratorioBindingSource.DataSource = this.dSctz;
            // 
            // dSctz
            // 
            this.dSctz.DataSetName = "DSctz";
            this.dSctz.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // laboratorioTableAdapter
            // 
            this.laboratorioTableAdapter.ClearBeforeFill = true;
            // 
            // materialButton1
            // 
            this.materialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton1.Depth = 0;
            this.materialButton1.HighEmphasis = true;
            this.materialButton1.Icon = null;
            this.materialButton1.Location = new System.Drawing.Point(265, 505);
            this.materialButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.Size = new System.Drawing.Size(88, 36);
            this.materialButton1.TabIndex = 21;
            this.materialButton1.Text = "Agregar";
            this.materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.materialButton1.UseAccentColor = false;
            this.materialButton1.UseVisualStyleBackColor = true;
            this.materialButton1.Click += new System.EventHandler(this.materialButton1_Click);
            // 
            // unassign
            // 
            this.unassign.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.unassign.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.unassign.Depth = 0;
            this.unassign.HighEmphasis = true;
            this.unassign.Icon = null;
            this.unassign.Location = new System.Drawing.Point(92, 505);
            this.unassign.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.unassign.MouseState = MaterialSkin.MouseState.HOVER;
            this.unassign.Name = "unassign";
            this.unassign.Size = new System.Drawing.Size(111, 36);
            this.unassign.TabIndex = 22;
            this.unassign.Text = "Desasignar";
            this.unassign.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.unassign.UseAccentColor = false;
            this.unassign.UseVisualStyleBackColor = true;
            this.unassign.Click += new System.EventHandler(this.unassign_Click);
            // 
            // AddCert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 550);
            this.Controls.Add(this.unassign);
            this.Controls.Add(this.materialButton1);
            this.Controls.Add(this.Lab);
            this.Controls.Add(this.save);
            this.Controls.Add(this.use);
            this.Controls.Add(this.cert);
            this.Controls.Add(this.link);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.intervalo);
            this.Controls.Add(this.nxtCalibracion);
            this.Controls.Add(this.calibracion);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(575, 550);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(575, 550);
            this.Name = "AddCert";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nuevo Certificado";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddCert_FormClosing);
            this.Load += new System.EventHandler(this.AddCert_Load);
            ((System.ComponentModel.ISupportInitialize)(this.usoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentacionDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.laboratorioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSctz)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker calibracion;
        private System.Windows.Forms.DateTimePicker nxtCalibracion;
        private DocumentacionDataSet documentacionDataSet;
        private System.Windows.Forms.BindingSource usoBindingSource;
        private DocumentacionDataSetTableAdapters.UsoTableAdapter usoTableAdapter;
        private MaterialSkin.Controls.MaterialTextBox intervalo;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialTextBox link;
        private MaterialSkin.Controls.MaterialTextBox cert;
        private MaterialSkin.Controls.MaterialComboBox use;
        private MaterialSkin.Controls.MaterialButton save;
        private MaterialSkin.Controls.MaterialComboBox Lab;
        private DSctz dSctz;
        private System.Windows.Forms.BindingSource laboratorioBindingSource;
        private DSctzTableAdapters.LaboratorioTableAdapter laboratorioTableAdapter;
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private MaterialSkin.Controls.MaterialButton unassign;
    }
}