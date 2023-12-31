﻿namespace CTZ
{
    partial class AddCarta
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.certificado = new System.Windows.Forms.ComboBox();
            this.certificadoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.documentacionDataSet = new CTZ.DocumentacionDataSet();
            this.instrumento = new System.Windows.Forms.ComboBox();
            this.Save = new System.Windows.Forms.Button();
            this.certificadoTableAdapter = new CTZ.DocumentacionDataSetTableAdapters.CertificadoTableAdapter();
            this.instChBx = new System.Windows.Forms.CheckBox();
            this.link = new System.Windows.Forms.Label();
            this.linked = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.certificadoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentacionDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Certificado";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Instrumento";
            // 
            // certificado
            // 
            this.certificado.DataSource = this.certificadoBindingSource;
            this.certificado.DisplayMember = "certificado";
            this.certificado.FormattingEnabled = true;
            this.certificado.Location = new System.Drawing.Point(127, 51);
            this.certificado.Name = "certificado";
            this.certificado.Size = new System.Drawing.Size(121, 21);
            this.certificado.TabIndex = 2;
            this.certificado.ValueMember = "IdCertificado";
            // 
            // certificadoBindingSource
            // 
            this.certificadoBindingSource.DataMember = "Certificado";
            this.certificadoBindingSource.DataSource = this.documentacionDataSet;
            // 
            // documentacionDataSet
            // 
            this.documentacionDataSet.DataSetName = "DocumentacionDataSet";
            this.documentacionDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // instrumento
            // 
            this.instrumento.FormattingEnabled = true;
            this.instrumento.Location = new System.Drawing.Point(127, 102);
            this.instrumento.Name = "instrumento";
            this.instrumento.Size = new System.Drawing.Size(121, 21);
            this.instrumento.TabIndex = 3;
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(217, 210);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(75, 23);
            this.Save.TabIndex = 4;
            this.Save.Text = "Guardar";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // certificadoTableAdapter
            // 
            this.certificadoTableAdapter.ClearBeforeFill = true;
            // 
            // instChBx
            // 
            this.instChBx.AutoSize = true;
            this.instChBx.Location = new System.Drawing.Point(16, 105);
            this.instChBx.Name = "instChBx";
            this.instChBx.Size = new System.Drawing.Size(15, 14);
            this.instChBx.TabIndex = 6;
            this.instChBx.UseVisualStyleBackColor = true;
            this.instChBx.CheckedChanged += new System.EventHandler(this.instChBx_CheckedChanged);
            // 
            // link
            // 
            this.link.AutoSize = true;
            this.link.Location = new System.Drawing.Point(37, 150);
            this.link.Name = "link";
            this.link.Size = new System.Drawing.Size(27, 13);
            this.link.TabIndex = 7;
            this.link.Text = "Link";
            // 
            // linked
            // 
            this.linked.Location = new System.Drawing.Point(127, 147);
            this.linked.Name = "linked";
            this.linked.Size = new System.Drawing.Size(121, 20);
            this.linked.TabIndex = 8;
            // 
            // AddCarta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 245);
            this.Controls.Add(this.linked);
            this.Controls.Add(this.link);
            this.Controls.Add(this.instChBx);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.instrumento);
            this.Controls.Add(this.certificado);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AddCarta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddCarta";
            this.Load += new System.EventHandler(this.AddCarta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.certificadoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentacionDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox certificado;
        private System.Windows.Forms.ComboBox instrumento;
        private System.Windows.Forms.Button Save;
        private DocumentacionDataSet documentacionDataSet;
        private System.Windows.Forms.BindingSource certificadoBindingSource;
        private DocumentacionDataSetTableAdapters.CertificadoTableAdapter certificadoTableAdapter;
        private System.Windows.Forms.CheckBox instChBx;
        private System.Windows.Forms.Label link;
        private System.Windows.Forms.TextBox linked;
    }
}