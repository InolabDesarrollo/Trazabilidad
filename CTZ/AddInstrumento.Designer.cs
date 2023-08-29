namespace CTZ
{
    partial class AddInstrumento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddInstrumento));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.instrumento = new System.Windows.Forms.ComboBox();
            this.instrumentoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.documentacionDataSet = new CTZ.DocumentacionDataSet();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.laboratorio = new System.Windows.Forms.ComboBox();
            this.laboratorioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.modelo = new System.Windows.Forms.ComboBox();
            this.modeloEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.marca = new System.Windows.Forms.ComboBox();
            this.marcaEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.procedimiento = new System.Windows.Forms.ComboBox();
            this.procedimientoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.equipo = new System.Windows.Forms.TextBox();
            this.informe = new System.Windows.Forms.TextBox();
            this.id = new System.Windows.Forms.TextBox();
            this.serie = new System.Windows.Forms.TextBox();
            this.incertidumbre = new System.Windows.Forms.TextBox();
            this.save = new System.Windows.Forms.Button();
            this.instrumentoTableAdapter = new CTZ.DocumentacionDataSetTableAdapters.InstrumentoTableAdapter();
            this.laboratorioTableAdapter = new CTZ.DocumentacionDataSetTableAdapters.LaboratorioTableAdapter();
            this.modeloETableAdapter = new CTZ.DocumentacionDataSetTableAdapters.ModeloETableAdapter();
            this.marcaETableAdapter = new CTZ.DocumentacionDataSetTableAdapters.MarcaETableAdapter();
            this.procedimientoTableAdapter = new CTZ.DocumentacionDataSetTableAdapters.ProcedimientoTableAdapter();
            this.instrumentoCB = new System.Windows.Forms.CheckBox();
            this.modeloCB = new System.Windows.Forms.CheckBox();
            this.marcaCB = new System.Windows.Forms.CheckBox();
            this.procedimientoCB = new System.Windows.Forms.CheckBox();
            this.label11 = new System.Windows.Forms.Label();
            this.vigencia = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.instrumentoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentacionDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.laboratorioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modeloEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.marcaEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.procedimientoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Equipo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "No. de Informe";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Id";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Serie";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Incertidumbre";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(40, 223);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Instrumento:";
            // 
            // instrumento
            // 
            this.instrumento.DataSource = this.instrumentoBindingSource;
            this.instrumento.DisplayMember = "Equipo";
            this.instrumento.Enabled = false;
            this.instrumento.FormattingEnabled = true;
            this.instrumento.Location = new System.Drawing.Point(147, 220);
            this.instrumento.Name = "instrumento";
            this.instrumento.Size = new System.Drawing.Size(200, 21);
            this.instrumento.TabIndex = 6;
            this.instrumento.ValueMember = "IdInstrumento";
            // 
            // instrumentoBindingSource
            // 
            this.instrumentoBindingSource.DataMember = "Instrumento";
            this.instrumentoBindingSource.DataSource = this.documentacionDataSet;
            // 
            // documentacionDataSet
            // 
            this.documentacionDataSet.DataSetName = "DocumentacionDataSet";
            this.documentacionDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(40, 259);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Laboratorio";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(40, 296);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Modelo";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(40, 333);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "Marca";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(40, 369);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 13);
            this.label10.TabIndex = 10;
            this.label10.Text = "Procedimiento";
            // 
            // laboratorio
            // 
            this.laboratorio.DataSource = this.laboratorioBindingSource;
            this.laboratorio.DisplayMember = "Nombre";
            this.laboratorio.FormattingEnabled = true;
            this.laboratorio.Location = new System.Drawing.Point(147, 256);
            this.laboratorio.Name = "laboratorio";
            this.laboratorio.Size = new System.Drawing.Size(200, 21);
            this.laboratorio.TabIndex = 11;
            this.laboratorio.ValueMember = "IdLaboratorio";
            // 
            // laboratorioBindingSource
            // 
            this.laboratorioBindingSource.DataMember = "Laboratorio";
            this.laboratorioBindingSource.DataSource = this.documentacionDataSet;
            // 
            // modelo
            // 
            this.modelo.DataSource = this.modeloEBindingSource;
            this.modelo.DisplayMember = "Descripcion";
            this.modelo.Enabled = false;
            this.modelo.FormattingEnabled = true;
            this.modelo.Location = new System.Drawing.Point(147, 293);
            this.modelo.Name = "modelo";
            this.modelo.Size = new System.Drawing.Size(200, 21);
            this.modelo.TabIndex = 12;
            this.modelo.ValueMember = "IdModeloE";
            // 
            // modeloEBindingSource
            // 
            this.modeloEBindingSource.DataMember = "ModeloE";
            this.modeloEBindingSource.DataSource = this.documentacionDataSet;
            // 
            // marca
            // 
            this.marca.DataSource = this.marcaEBindingSource;
            this.marca.DisplayMember = "Nombre";
            this.marca.Enabled = false;
            this.marca.FormattingEnabled = true;
            this.marca.Location = new System.Drawing.Point(147, 330);
            this.marca.Name = "marca";
            this.marca.Size = new System.Drawing.Size(200, 21);
            this.marca.TabIndex = 13;
            this.marca.ValueMember = "IdMarcaE";
            // 
            // marcaEBindingSource
            // 
            this.marcaEBindingSource.DataMember = "MarcaE";
            this.marcaEBindingSource.DataSource = this.documentacionDataSet;
            // 
            // procedimiento
            // 
            this.procedimiento.DataSource = this.procedimientoBindingSource;
            this.procedimiento.DisplayMember = "Descripcion";
            this.procedimiento.Enabled = false;
            this.procedimiento.FormattingEnabled = true;
            this.procedimiento.Location = new System.Drawing.Point(147, 366);
            this.procedimiento.Name = "procedimiento";
            this.procedimiento.Size = new System.Drawing.Size(200, 21);
            this.procedimiento.TabIndex = 14;
            this.procedimiento.ValueMember = "IdProcedimiento";
            // 
            // procedimientoBindingSource
            // 
            this.procedimientoBindingSource.DataMember = "Procedimiento";
            this.procedimientoBindingSource.DataSource = this.documentacionDataSet;
            // 
            // equipo
            // 
            this.equipo.Location = new System.Drawing.Point(147, 41);
            this.equipo.Name = "equipo";
            this.equipo.Size = new System.Drawing.Size(200, 20);
            this.equipo.TabIndex = 15;
            // 
            // informe
            // 
            this.informe.Location = new System.Drawing.Point(147, 75);
            this.informe.Name = "informe";
            this.informe.Size = new System.Drawing.Size(200, 20);
            this.informe.TabIndex = 16;
            // 
            // id
            // 
            this.id.Location = new System.Drawing.Point(147, 117);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(200, 20);
            this.id.TabIndex = 17;
            // 
            // serie
            // 
            this.serie.Location = new System.Drawing.Point(147, 147);
            this.serie.Name = "serie";
            this.serie.Size = new System.Drawing.Size(200, 20);
            this.serie.TabIndex = 18;
            // 
            // incertidumbre
            // 
            this.incertidumbre.Location = new System.Drawing.Point(147, 182);
            this.incertidumbre.Name = "incertidumbre";
            this.incertidumbre.Size = new System.Drawing.Size(200, 20);
            this.incertidumbre.TabIndex = 19;
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(254, 426);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(75, 23);
            this.save.TabIndex = 20;
            this.save.Text = "Guardar";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // instrumentoTableAdapter
            // 
            this.instrumentoTableAdapter.ClearBeforeFill = true;
            // 
            // laboratorioTableAdapter
            // 
            this.laboratorioTableAdapter.ClearBeforeFill = true;
            // 
            // modeloETableAdapter
            // 
            this.modeloETableAdapter.ClearBeforeFill = true;
            // 
            // marcaETableAdapter
            // 
            this.marcaETableAdapter.ClearBeforeFill = true;
            // 
            // procedimientoTableAdapter
            // 
            this.procedimientoTableAdapter.ClearBeforeFill = true;
            // 
            // instrumentoCB
            // 
            this.instrumentoCB.AutoSize = true;
            this.instrumentoCB.Location = new System.Drawing.Point(372, 224);
            this.instrumentoCB.Name = "instrumentoCB";
            this.instrumentoCB.Size = new System.Drawing.Size(15, 14);
            this.instrumentoCB.TabIndex = 21;
            this.instrumentoCB.UseVisualStyleBackColor = true;
            this.instrumentoCB.CheckedChanged += new System.EventHandler(this.instrumentoCB_CheckedChanged);
            // 
            // modeloCB
            // 
            this.modeloCB.AutoSize = true;
            this.modeloCB.Location = new System.Drawing.Point(372, 296);
            this.modeloCB.Name = "modeloCB";
            this.modeloCB.Size = new System.Drawing.Size(15, 14);
            this.modeloCB.TabIndex = 22;
            this.modeloCB.UseVisualStyleBackColor = true;
            this.modeloCB.CheckedChanged += new System.EventHandler(this.modeloCB_CheckedChanged);
            // 
            // marcaCB
            // 
            this.marcaCB.AutoSize = true;
            this.marcaCB.Location = new System.Drawing.Point(372, 333);
            this.marcaCB.Name = "marcaCB";
            this.marcaCB.Size = new System.Drawing.Size(15, 14);
            this.marcaCB.TabIndex = 23;
            this.marcaCB.UseVisualStyleBackColor = true;
            this.marcaCB.CheckedChanged += new System.EventHandler(this.marcaCB_CheckedChanged);
            // 
            // procedimientoCB
            // 
            this.procedimientoCB.AutoSize = true;
            this.procedimientoCB.Location = new System.Drawing.Point(372, 369);
            this.procedimientoCB.Name = "procedimientoCB";
            this.procedimientoCB.Size = new System.Drawing.Size(15, 14);
            this.procedimientoCB.TabIndex = 24;
            this.procedimientoCB.UseVisualStyleBackColor = true;
            this.procedimientoCB.CheckedChanged += new System.EventHandler(this.procedimientoCB_CheckedChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(40, 403);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(48, 13);
            this.label11.TabIndex = 25;
            this.label11.Text = "Vigencia";
            // 
            // vigencia
            // 
            this.vigencia.Location = new System.Drawing.Point(147, 397);
            this.vigencia.Name = "vigencia";
            this.vigencia.Size = new System.Drawing.Size(200, 20);
            this.vigencia.TabIndex = 26;
            // 
            // AddInstrumento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 461);
            this.Controls.Add(this.vigencia);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.procedimientoCB);
            this.Controls.Add(this.marcaCB);
            this.Controls.Add(this.modeloCB);
            this.Controls.Add(this.instrumentoCB);
            this.Controls.Add(this.save);
            this.Controls.Add(this.incertidumbre);
            this.Controls.Add(this.serie);
            this.Controls.Add(this.id);
            this.Controls.Add(this.informe);
            this.Controls.Add(this.equipo);
            this.Controls.Add(this.procedimiento);
            this.Controls.Add(this.marca);
            this.Controls.Add(this.modelo);
            this.Controls.Add(this.laboratorio);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.instrumento);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(415, 500);
            this.MinimumSize = new System.Drawing.Size(415, 500);
            this.Name = "AddInstrumento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddInstrumento";
            this.Load += new System.EventHandler(this.AddInstrumento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.instrumentoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentacionDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.laboratorioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.modeloEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.marcaEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.procedimientoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox instrumento;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox laboratorio;
        private System.Windows.Forms.ComboBox modelo;
        private System.Windows.Forms.ComboBox marca;
        private System.Windows.Forms.ComboBox procedimiento;
        private System.Windows.Forms.TextBox equipo;
        private System.Windows.Forms.TextBox informe;
        private System.Windows.Forms.TextBox id;
        private System.Windows.Forms.TextBox serie;
        private System.Windows.Forms.TextBox incertidumbre;
        private System.Windows.Forms.Button save;
        private DocumentacionDataSet documentacionDataSet;
        private System.Windows.Forms.BindingSource instrumentoBindingSource;
        private DocumentacionDataSetTableAdapters.InstrumentoTableAdapter instrumentoTableAdapter;
        private System.Windows.Forms.BindingSource laboratorioBindingSource;
        private DocumentacionDataSetTableAdapters.LaboratorioTableAdapter laboratorioTableAdapter;
        private System.Windows.Forms.BindingSource modeloEBindingSource;
        private DocumentacionDataSetTableAdapters.ModeloETableAdapter modeloETableAdapter;
        private System.Windows.Forms.BindingSource marcaEBindingSource;
        private DocumentacionDataSetTableAdapters.MarcaETableAdapter marcaETableAdapter;
        private System.Windows.Forms.BindingSource procedimientoBindingSource;
        private DocumentacionDataSetTableAdapters.ProcedimientoTableAdapter procedimientoTableAdapter;
        private System.Windows.Forms.CheckBox instrumentoCB;
        private System.Windows.Forms.CheckBox modeloCB;
        private System.Windows.Forms.CheckBox marcaCB;
        private System.Windows.Forms.CheckBox procedimientoCB;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker vigencia;
    }
}