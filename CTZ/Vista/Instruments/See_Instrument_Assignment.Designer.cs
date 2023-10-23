namespace CTZ.Vista.Instruments
{
    partial class See_Instrument_Assignment
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
            this.Pnl_Instrument = new System.Windows.Forms.Panel();
            this.TimePicker_DateBegan = new System.Windows.Forms.DateTimePicker();
            this.Lbl_Title = new System.Windows.Forms.Label();
            this.Pnl_Body = new System.Windows.Forms.Panel();
            this.Dgv_Instrument_Assignment = new ADGV.AdvancedDataGridView();
            this.trazabilidadTestDataSet4 = new CTZ.TrazabilidadTestDataSet4();
            this.instrumentosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.instrumentosTableAdapter = new CTZ.TrazabilidadTestDataSet4TableAdapters.InstrumentosTableAdapter();
            this.Lbl_Date_Delivery = new System.Windows.Forms.Label();
            this.Lbl_Date_Return = new System.Windows.Forms.Label();
            this.TimePicker_DateFinal = new System.Windows.Forms.DateTimePicker();
            this.Btn_Filter = new System.Windows.Forms.Button();
            this.Btn_Clean = new System.Windows.Forms.Button();
            this.Pnl_Instrument.SuspendLayout();
            this.Pnl_Body.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Instrument_Assignment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trazabilidadTestDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.instrumentosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Pnl_Instrument
            // 
            this.Pnl_Instrument.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Pnl_Instrument.BackColor = System.Drawing.Color.RoyalBlue;
            this.Pnl_Instrument.Controls.Add(this.Btn_Clean);
            this.Pnl_Instrument.Controls.Add(this.Btn_Filter);
            this.Pnl_Instrument.Controls.Add(this.TimePicker_DateFinal);
            this.Pnl_Instrument.Controls.Add(this.Lbl_Date_Return);
            this.Pnl_Instrument.Controls.Add(this.Lbl_Date_Delivery);
            this.Pnl_Instrument.Controls.Add(this.TimePicker_DateBegan);
            this.Pnl_Instrument.Controls.Add(this.Lbl_Title);
            this.Pnl_Instrument.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.Pnl_Instrument.Location = new System.Drawing.Point(-3, 0);
            this.Pnl_Instrument.Name = "Pnl_Instrument";
            this.Pnl_Instrument.Size = new System.Drawing.Size(822, 93);
            this.Pnl_Instrument.TabIndex = 0;
            // 
            // TimePicker_DateBegan
            // 
            this.TimePicker_DateBegan.Location = new System.Drawing.Point(300, 13);
            this.TimePicker_DateBegan.Name = "TimePicker_DateBegan";
            this.TimePicker_DateBegan.Size = new System.Drawing.Size(200, 20);
            this.TimePicker_DateBegan.TabIndex = 1;
            // 
            // Lbl_Title
            // 
            this.Lbl_Title.AutoSize = true;
            this.Lbl_Title.BackColor = System.Drawing.Color.RoyalBlue;
            this.Lbl_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Title.ForeColor = System.Drawing.Color.White;
            this.Lbl_Title.Location = new System.Drawing.Point(15, 9);
            this.Lbl_Title.Name = "Lbl_Title";
            this.Lbl_Title.Size = new System.Drawing.Size(62, 24);
            this.Lbl_Title.TabIndex = 0;
            this.Lbl_Title.Text = "Titulo";
            // 
            // Pnl_Body
            // 
            this.Pnl_Body.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Pnl_Body.Controls.Add(this.Dgv_Instrument_Assignment);
            this.Pnl_Body.Location = new System.Drawing.Point(0, 89);
            this.Pnl_Body.Name = "Pnl_Body";
            this.Pnl_Body.Size = new System.Drawing.Size(822, 385);
            this.Pnl_Body.TabIndex = 1;
            // 
            // Dgv_Instrument_Assignment
            // 
            this.Dgv_Instrument_Assignment.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Dgv_Instrument_Assignment.AutoGenerateContextFilters = true;
            this.Dgv_Instrument_Assignment.BackgroundColor = System.Drawing.Color.White;
            this.Dgv_Instrument_Assignment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_Instrument_Assignment.DateWithTime = false;
            this.Dgv_Instrument_Assignment.Location = new System.Drawing.Point(0, 3);
            this.Dgv_Instrument_Assignment.Name = "Dgv_Instrument_Assignment";
            this.Dgv_Instrument_Assignment.Size = new System.Drawing.Size(822, 379);
            this.Dgv_Instrument_Assignment.TabIndex = 0;
            this.Dgv_Instrument_Assignment.TimeFilter = false;
            this.Dgv_Instrument_Assignment.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_Instrument_Assignment_CellContentDoubleClick);
            // 
            // trazabilidadTestDataSet4
            // 
            this.trazabilidadTestDataSet4.DataSetName = "TrazabilidadTestDataSet4";
            this.trazabilidadTestDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // instrumentosBindingSource
            // 
            this.instrumentosBindingSource.DataMember = "Instrumentos";
            this.instrumentosBindingSource.DataSource = this.trazabilidadTestDataSet4;
            // 
            // instrumentosTableAdapter
            // 
            this.instrumentosTableAdapter.ClearBeforeFill = true;
            // 
            // Lbl_Date_Delivery
            // 
            this.Lbl_Date_Delivery.AutoSize = true;
            this.Lbl_Date_Delivery.BackColor = System.Drawing.Color.RoyalBlue;
            this.Lbl_Date_Delivery.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Date_Delivery.ForeColor = System.Drawing.SystemColors.Window;
            this.Lbl_Date_Delivery.Location = new System.Drawing.Point(143, 11);
            this.Lbl_Date_Delivery.Name = "Lbl_Date_Delivery";
            this.Lbl_Date_Delivery.Size = new System.Drawing.Size(117, 20);
            this.Lbl_Date_Delivery.TabIndex = 2;
            this.Lbl_Date_Delivery.Text = "Fecha de Inicio";
            // 
            // Lbl_Date_Return
            // 
            this.Lbl_Date_Return.AutoSize = true;
            this.Lbl_Date_Return.BackColor = System.Drawing.Color.RoyalBlue;
            this.Lbl_Date_Return.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Date_Return.ForeColor = System.Drawing.SystemColors.Window;
            this.Lbl_Date_Return.Location = new System.Drawing.Point(143, 42);
            this.Lbl_Date_Return.Name = "Lbl_Date_Return";
            this.Lbl_Date_Return.Size = new System.Drawing.Size(80, 20);
            this.Lbl_Date_Return.TabIndex = 3;
            this.Lbl_Date_Return.Text = "Fecha Fin";
            // 
            // TimePicker_DateFinal
            // 
            this.TimePicker_DateFinal.Location = new System.Drawing.Point(300, 42);
            this.TimePicker_DateFinal.Name = "TimePicker_DateFinal";
            this.TimePicker_DateFinal.Size = new System.Drawing.Size(200, 20);
            this.TimePicker_DateFinal.TabIndex = 4;
            // 
            // Btn_Filter
            // 
            this.Btn_Filter.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Filter.Location = new System.Drawing.Point(561, 12);
            this.Btn_Filter.Name = "Btn_Filter";
            this.Btn_Filter.Size = new System.Drawing.Size(83, 50);
            this.Btn_Filter.TabIndex = 5;
            this.Btn_Filter.Text = "Filtar Fechas";
            this.Btn_Filter.UseVisualStyleBackColor = true;
            this.Btn_Filter.Click += new System.EventHandler(this.Btn_Filter_Click);
            // 
            // Btn_Clean
            // 
            this.Btn_Clean.Location = new System.Drawing.Point(668, 13);
            this.Btn_Clean.Name = "Btn_Clean";
            this.Btn_Clean.Size = new System.Drawing.Size(87, 49);
            this.Btn_Clean.TabIndex = 6;
            this.Btn_Clean.Text = "Limpiar Filtro";
            this.Btn_Clean.UseVisualStyleBackColor = true;
            this.Btn_Clean.Click += new System.EventHandler(this.Btn_Clean_Click);
            // 
            // See_Instrument_Assignment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 474);
            this.Controls.Add(this.Pnl_Body);
            this.Controls.Add(this.Pnl_Instrument);
            this.Name = "See_Instrument_Assignment";
            this.Text = "Asignacion de Instrumento";
            this.Load += new System.EventHandler(this.See_Instrument_Assignment_Load);
            this.Pnl_Instrument.ResumeLayout(false);
            this.Pnl_Instrument.PerformLayout();
            this.Pnl_Body.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Instrument_Assignment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trazabilidadTestDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.instrumentosBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Pnl_Instrument;
        private System.Windows.Forms.Label Lbl_Title;
        private System.Windows.Forms.Panel Pnl_Body;
        private TrazabilidadTestDataSet4 trazabilidadTestDataSet4;
        private System.Windows.Forms.BindingSource instrumentosBindingSource;
        private TrazabilidadTestDataSet4TableAdapters.InstrumentosTableAdapter instrumentosTableAdapter;
        private ADGV.AdvancedDataGridView Dgv_Instrument_Assignment;
        private System.Windows.Forms.DateTimePicker TimePicker_DateBegan;
        private System.Windows.Forms.Label Lbl_Date_Delivery;
        private System.Windows.Forms.DateTimePicker TimePicker_DateFinal;
        private System.Windows.Forms.Label Lbl_Date_Return;
        private System.Windows.Forms.Button Btn_Filter;
        private System.Windows.Forms.Button Btn_Clean;
    }
}