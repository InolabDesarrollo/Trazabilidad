namespace CTZ.Vista
{
    partial class MenuInstrumentos
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
            this.Pnl_Head = new System.Windows.Forms.Panel();
            this.Btn_Regist = new System.Windows.Forms.Button();
            this.Btn_See = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.asignacionDataSet1 = new CTZ.AsignacionDataSet();
            this.Dgv_Instrumentos = new System.Windows.Forms.DataGridView();
            this.Pnl_See = new System.Windows.Forms.Panel();
            this.Btn_Actives = new System.Windows.Forms.Button();
            this.Btn_All = new System.Windows.Forms.Button();
            this.Pnl_Regist = new System.Windows.Forms.Panel();
            this.BtnUpdate_Instrument = new System.Windows.Forms.Button();
            this.BtnDelete_Instruments = new System.Windows.Forms.Button();
            this.Btn_Add = new System.Windows.Forms.Button();
            this.Btn_Instruments_Certificates = new System.Windows.Forms.Button();
            this.Pnl_Head.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.asignacionDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Instrumentos)).BeginInit();
            this.Pnl_See.SuspendLayout();
            this.Pnl_Regist.SuspendLayout();
            this.SuspendLayout();
            // 
            // Pnl_Head
            // 
            this.Pnl_Head.AutoSize = true;
            this.Pnl_Head.BackColor = System.Drawing.Color.RoyalBlue;
            this.Pnl_Head.Controls.Add(this.Btn_Regist);
            this.Pnl_Head.Controls.Add(this.Btn_See);
            this.Pnl_Head.Controls.Add(this.pictureBox1);
            this.Pnl_Head.Dock = System.Windows.Forms.DockStyle.Top;
            this.Pnl_Head.Location = new System.Drawing.Point(0, 0);
            this.Pnl_Head.Name = "Pnl_Head";
            this.Pnl_Head.Size = new System.Drawing.Size(921, 107);
            this.Pnl_Head.TabIndex = 1;
            // 
            // Btn_Regist
            // 
            this.Btn_Regist.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.Btn_Regist.FlatAppearance.BorderSize = 0;
            this.Btn_Regist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Regist.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Regist.Location = new System.Drawing.Point(80, 40);
            this.Btn_Regist.Name = "Btn_Regist";
            this.Btn_Regist.Size = new System.Drawing.Size(100, 64);
            this.Btn_Regist.TabIndex = 1;
            this.Btn_Regist.Text = "Registros";
            this.Btn_Regist.UseVisualStyleBackColor = false;
            this.Btn_Regist.Click += new System.EventHandler(this.Btn_Regist_Click);
            // 
            // Btn_See
            // 
            this.Btn_See.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.Btn_See.FlatAppearance.BorderSize = 0;
            this.Btn_See.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_See.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_See.Location = new System.Drawing.Point(0, 40);
            this.Btn_See.Name = "Btn_See";
            this.Btn_See.Size = new System.Drawing.Size(85, 64);
            this.Btn_See.TabIndex = 0;
            this.Btn_See.Text = "Ver";
            this.Btn_See.UseVisualStyleBackColor = false;
            this.Btn_See.Click += new System.EventHandler(this.Btn_See_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox1.Image = global::CTZ.Properties.Resources.LOGO_Blanco_Lineas1;
            this.pictureBox1.Location = new System.Drawing.Point(745, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(176, 107);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // asignacionDataSet1
            // 
            this.asignacionDataSet1.DataSetName = "AsignacionDataSet";
            this.asignacionDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Dgv_Instrumentos
            // 
            this.Dgv_Instrumentos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Dgv_Instrumentos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Dgv_Instrumentos.BackgroundColor = System.Drawing.SystemColors.Control;
            this.Dgv_Instrumentos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Dgv_Instrumentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_Instrumentos.Location = new System.Drawing.Point(0, 104);
            this.Dgv_Instrumentos.Name = "Dgv_Instrumentos";
            this.Dgv_Instrumentos.Size = new System.Drawing.Size(921, 390);
            this.Dgv_Instrumentos.TabIndex = 3;
            this.Dgv_Instrumentos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_Instrumentos_CellContentClick);
            // 
            // Pnl_See
            // 
            this.Pnl_See.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.Pnl_See.Controls.Add(this.Btn_Instruments_Certificates);
            this.Pnl_See.Controls.Add(this.Btn_Actives);
            this.Pnl_See.Controls.Add(this.Btn_All);
            this.Pnl_See.Location = new System.Drawing.Point(0, 104);
            this.Pnl_See.Name = "Pnl_See";
            this.Pnl_See.Size = new System.Drawing.Size(85, 135);
            this.Pnl_See.TabIndex = 5;
            this.Pnl_See.Visible = false;
            // 
            // Btn_Actives
            // 
            this.Btn_Actives.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.Btn_Actives.FlatAppearance.BorderSize = 0;
            this.Btn_Actives.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Actives.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Actives.Location = new System.Drawing.Point(0, 43);
            this.Btn_Actives.Name = "Btn_Actives";
            this.Btn_Actives.Size = new System.Drawing.Size(85, 46);
            this.Btn_Actives.TabIndex = 8;
            this.Btn_Actives.Text = "Activos";
            this.Btn_Actives.UseVisualStyleBackColor = false;
            this.Btn_Actives.Click += new System.EventHandler(this.Btn_Actives_Click);
            // 
            // Btn_All
            // 
            this.Btn_All.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.Btn_All.FlatAppearance.BorderSize = 0;
            this.Btn_All.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_All.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_All.Location = new System.Drawing.Point(0, 0);
            this.Btn_All.Name = "Btn_All";
            this.Btn_All.Size = new System.Drawing.Size(85, 44);
            this.Btn_All.TabIndex = 7;
            this.Btn_All.Text = "Todos";
            this.Btn_All.UseVisualStyleBackColor = false;
            this.Btn_All.Click += new System.EventHandler(this.Btn_All_Click);
            // 
            // Pnl_Regist
            // 
            this.Pnl_Regist.BackColor = System.Drawing.SystemColors.Highlight;
            this.Pnl_Regist.Controls.Add(this.BtnUpdate_Instrument);
            this.Pnl_Regist.Controls.Add(this.BtnDelete_Instruments);
            this.Pnl_Regist.Controls.Add(this.Btn_Add);
            this.Pnl_Regist.Location = new System.Drawing.Point(80, 104);
            this.Pnl_Regist.Name = "Pnl_Regist";
            this.Pnl_Regist.Size = new System.Drawing.Size(100, 135);
            this.Pnl_Regist.TabIndex = 6;
            this.Pnl_Regist.Visible = false;
            // 
            // BtnUpdate_Instrument
            // 
            this.BtnUpdate_Instrument.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.BtnUpdate_Instrument.FlatAppearance.BorderSize = 0;
            this.BtnUpdate_Instrument.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnUpdate_Instrument.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnUpdate_Instrument.Location = new System.Drawing.Point(0, 79);
            this.BtnUpdate_Instrument.Name = "BtnUpdate_Instrument";
            this.BtnUpdate_Instrument.Size = new System.Drawing.Size(100, 56);
            this.BtnUpdate_Instrument.TabIndex = 10;
            this.BtnUpdate_Instrument.Text = "Actualizar";
            this.BtnUpdate_Instrument.UseVisualStyleBackColor = false;
            this.BtnUpdate_Instrument.Click += new System.EventHandler(this.BtnUpdate_Instrument_Click);
            // 
            // BtnDelete_Instruments
            // 
            this.BtnDelete_Instruments.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.BtnDelete_Instruments.FlatAppearance.BorderSize = 0;
            this.BtnDelete_Instruments.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDelete_Instruments.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDelete_Instruments.Location = new System.Drawing.Point(0, 43);
            this.BtnDelete_Instruments.Name = "BtnDelete_Instruments";
            this.BtnDelete_Instruments.Size = new System.Drawing.Size(100, 44);
            this.BtnDelete_Instruments.TabIndex = 9;
            this.BtnDelete_Instruments.Text = "Eliminar";
            this.BtnDelete_Instruments.UseVisualStyleBackColor = false;
            this.BtnDelete_Instruments.Click += new System.EventHandler(this.BtnDelete_Instruments_Click);
            // 
            // Btn_Add
            // 
            this.Btn_Add.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.Btn_Add.FlatAppearance.BorderSize = 0;
            this.Btn_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Add.Location = new System.Drawing.Point(0, 0);
            this.Btn_Add.Name = "Btn_Add";
            this.Btn_Add.Size = new System.Drawing.Size(100, 44);
            this.Btn_Add.TabIndex = 8;
            this.Btn_Add.Text = "Agregar";
            this.Btn_Add.UseVisualStyleBackColor = false;
            this.Btn_Add.Click += new System.EventHandler(this.Btn_Add_Click);
            // 
            // Btn_Instruments_Certificates
            // 
            this.Btn_Instruments_Certificates.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.Btn_Instruments_Certificates.FlatAppearance.BorderSize = 0;
            this.Btn_Instruments_Certificates.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Instruments_Certificates.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Instruments_Certificates.Location = new System.Drawing.Point(0, 84);
            this.Btn_Instruments_Certificates.Name = "Btn_Instruments_Certificates";
            this.Btn_Instruments_Certificates.Size = new System.Drawing.Size(82, 51);
            this.Btn_Instruments_Certificates.TabIndex = 9;
            this.Btn_Instruments_Certificates.Text = "UNION";
            this.Btn_Instruments_Certificates.UseVisualStyleBackColor = false;
            this.Btn_Instruments_Certificates.Click += new System.EventHandler(this.Btn_Instruments_Certificates_Click);
            // 
            // MenuInstrumentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 488);
            this.Controls.Add(this.Pnl_Regist);
            this.Controls.Add(this.Pnl_See);
            this.Controls.Add(this.Dgv_Instrumentos);
            this.Controls.Add(this.Pnl_Head);
            this.Name = "MenuInstrumentos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuInstrumentos";
            this.Pnl_Head.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.asignacionDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Instrumentos)).EndInit();
            this.Pnl_See.ResumeLayout(false);
            this.Pnl_Regist.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Pnl_Head;
        private System.Windows.Forms.Button Btn_Regist;
        private System.Windows.Forms.Button Btn_See;
        private System.Windows.Forms.PictureBox pictureBox1;
        private AsignacionDataSet asignacionDataSet1;
        private System.Windows.Forms.DataGridView Dgv_Instrumentos;
        private System.Windows.Forms.Panel Pnl_See;
        private System.Windows.Forms.Panel Pnl_Regist;
        private System.Windows.Forms.Button Btn_All;
        private System.Windows.Forms.Button Btn_Actives;
        private System.Windows.Forms.Button Btn_Add;
        private System.Windows.Forms.Button BtnDelete_Instruments;
        private System.Windows.Forms.Button BtnUpdate_Instrument;
        private System.Windows.Forms.Button Btn_Instruments_Certificates;
    }
}