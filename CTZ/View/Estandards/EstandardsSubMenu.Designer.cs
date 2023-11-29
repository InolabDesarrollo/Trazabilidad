namespace CTZ.View.Estandards
{
    partial class EstandardsSubMenu
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
            this.Page_Estandards = new System.Windows.Forms.TabPage();
            this.TabControl_Estandards = new System.Windows.Forms.TabControl();
            this.Btn_Add = new System.Windows.Forms.Button();
            this.Btn_Delete = new System.Windows.Forms.Button();
            this.Btn_Update = new System.Windows.Forms.Button();
            this.trazabilidadTestDataSet3 = new CTZ.TrazabilidadTestDataSet3();
            this.trazabilidadTestDataSet3BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataTable1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.instrumentosCertificadoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.instrumentos_CertificadoTableAdapter = new CTZ.TrazabilidadTestDataSet3TableAdapters.Instrumentos_CertificadoTableAdapter();
            this.dataTable1BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.TabControl_Estandards.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trazabilidadTestDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trazabilidadTestDataSet3BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.instrumentosCertificadoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // Page_Estandards
            // 
            this.Page_Estandards.Location = new System.Drawing.Point(4, 22);
            this.Page_Estandards.Name = "Page_Estandards";
            this.Page_Estandards.Padding = new System.Windows.Forms.Padding(3);
            this.Page_Estandards.Size = new System.Drawing.Size(855, 265);
            this.Page_Estandards.TabIndex = 0;
            this.Page_Estandards.Text = "Estandares";
            this.Page_Estandards.UseVisualStyleBackColor = true;
            // 
            // TabControl_Estandards
            // 
            this.TabControl_Estandards.Controls.Add(this.Page_Estandards);
            this.TabControl_Estandards.Location = new System.Drawing.Point(6, 88);
            this.TabControl_Estandards.Name = "TabControl_Estandards";
            this.TabControl_Estandards.SelectedIndex = 0;
            this.TabControl_Estandards.Size = new System.Drawing.Size(863, 291);
            this.TabControl_Estandards.TabIndex = 0;
            // 
            // Btn_Add
            // 
            this.Btn_Add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(119)))), ((int)(((byte)(182)))));
            this.Btn_Add.FlatAppearance.BorderSize = 0;
            this.Btn_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Add.Location = new System.Drawing.Point(57, 381);
            this.Btn_Add.Name = "Btn_Add";
            this.Btn_Add.Size = new System.Drawing.Size(121, 44);
            this.Btn_Add.TabIndex = 10;
            this.Btn_Add.Text = "Agregar";
            this.Btn_Add.UseVisualStyleBackColor = false;
            // 
            // Btn_Delete
            // 
            this.Btn_Delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(119)))), ((int)(((byte)(182)))));
            this.Btn_Delete.FlatAppearance.BorderSize = 0;
            this.Btn_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Delete.Location = new System.Drawing.Point(213, 381);
            this.Btn_Delete.Name = "Btn_Delete";
            this.Btn_Delete.Size = new System.Drawing.Size(121, 45);
            this.Btn_Delete.TabIndex = 11;
            this.Btn_Delete.Text = "Eliminar";
            this.Btn_Delete.UseVisualStyleBackColor = false;
            // 
            // Btn_Update
            // 
            this.Btn_Update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(119)))), ((int)(((byte)(182)))));
            this.Btn_Update.FlatAppearance.BorderSize = 0;
            this.Btn_Update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Update.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Update.Location = new System.Drawing.Point(375, 381);
            this.Btn_Update.Name = "Btn_Update";
            this.Btn_Update.Size = new System.Drawing.Size(121, 47);
            this.Btn_Update.TabIndex = 12;
            this.Btn_Update.Text = "Actualizar";
            this.Btn_Update.UseVisualStyleBackColor = false;
            // 
            // trazabilidadTestDataSet3
            // 
            this.trazabilidadTestDataSet3.DataSetName = "TrazabilidadTestDataSet3";
            this.trazabilidadTestDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // trazabilidadTestDataSet3BindingSource
            // 
            this.trazabilidadTestDataSet3BindingSource.DataSource = this.trazabilidadTestDataSet3;
            this.trazabilidadTestDataSet3BindingSource.Position = 0;
            // 
            // dataTable1BindingSource
            // 
            this.dataTable1BindingSource.DataMember = "DataTable1";
            this.dataTable1BindingSource.DataSource = this.trazabilidadTestDataSet3BindingSource;
            // 
            // instrumentosCertificadoBindingSource
            // 
            this.instrumentosCertificadoBindingSource.DataMember = "Instrumentos_Certificado";
            this.instrumentosCertificadoBindingSource.DataSource = this.trazabilidadTestDataSet3BindingSource;
            // 
            // instrumentos_CertificadoTableAdapter
            // 
            this.instrumentos_CertificadoTableAdapter.ClearBeforeFill = true;
            // 
            // dataTable1BindingSource1
            // 
            this.dataTable1BindingSource1.DataMember = "DataTable1";
            this.dataTable1BindingSource1.DataSource = this.trazabilidadTestDataSet3BindingSource;
            // 
            // EstandardsSubMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 456);
            this.Controls.Add(this.Btn_Update);
            this.Controls.Add(this.Btn_Delete);
            this.Controls.Add(this.Btn_Add);
            this.Controls.Add(this.TabControl_Estandards);
            this.Name = "EstandardsSubMenu";
            this.Text = "Informacion Estandares";
            this.Load += new System.EventHandler(this.EstandardsSubMenu_Load);
            this.TabControl_Estandards.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.trazabilidadTestDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trazabilidadTestDataSet3BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.instrumentosCertificadoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage Page_Estandards;
        private System.Windows.Forms.TabControl TabControl_Estandards;
        private System.Windows.Forms.Button Btn_Add;
        private System.Windows.Forms.Button Btn_Delete;
        private System.Windows.Forms.Button Btn_Update;
        private System.Windows.Forms.BindingSource dataTable1BindingSource;
        private System.Windows.Forms.BindingSource trazabilidadTestDataSet3BindingSource;
        private TrazabilidadTestDataSet3 trazabilidadTestDataSet3;
        private System.Windows.Forms.BindingSource instrumentosCertificadoBindingSource;
        private TrazabilidadTestDataSet3TableAdapters.Instrumentos_CertificadoTableAdapter instrumentos_CertificadoTableAdapter;
        private System.Windows.Forms.BindingSource dataTable1BindingSource1;
    }
}