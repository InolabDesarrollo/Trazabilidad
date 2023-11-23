namespace CTZ.View.Instruments.Trazability
{
    partial class Trazability_SubMenu
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
            this.Btn_Serch_Traceability = new System.Windows.Forms.Button();
            this.Btn_AddTraceability = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Btn_Serch_Traceability
            // 
            this.Btn_Serch_Traceability.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(119)))), ((int)(((byte)(182)))));
            this.Btn_Serch_Traceability.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Serch_Traceability.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Serch_Traceability.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Btn_Serch_Traceability.Location = new System.Drawing.Point(108, 187);
            this.Btn_Serch_Traceability.Name = "Btn_Serch_Traceability";
            this.Btn_Serch_Traceability.Size = new System.Drawing.Size(319, 49);
            this.Btn_Serch_Traceability.TabIndex = 2;
            this.Btn_Serch_Traceability.Text = "Buscar";
            this.Btn_Serch_Traceability.UseVisualStyleBackColor = false;
            this.Btn_Serch_Traceability.Click += new System.EventHandler(this.Btn_Serch_Traceability_Click);
            // 
            // Btn_AddTraceability
            // 
            this.Btn_AddTraceability.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(119)))), ((int)(((byte)(182)))));
            this.Btn_AddTraceability.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_AddTraceability.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_AddTraceability.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Btn_AddTraceability.Location = new System.Drawing.Point(108, 118);
            this.Btn_AddTraceability.Name = "Btn_AddTraceability";
            this.Btn_AddTraceability.Size = new System.Drawing.Size(319, 49);
            this.Btn_AddTraceability.TabIndex = 3;
            this.Btn_AddTraceability.Text = "Agregar";
            this.Btn_AddTraceability.UseVisualStyleBackColor = false;
            this.Btn_AddTraceability.Click += new System.EventHandler(this.Btn_AddTraceability_Click);
            // 
            // Trazability_SubMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 325);
            this.Controls.Add(this.Btn_AddTraceability);
            this.Controls.Add(this.Btn_Serch_Traceability);
            this.Name = "Trazability_SubMenu";
            this.Text = "Trazabilidad";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button Btn_Serch_Traceability;
        private System.Windows.Forms.Button Btn_AddTraceability;
    }
}