namespace CTZ.View.Estandard
{
    partial class Assignments_Menu
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
            this.Btn_Add_Load = new System.Windows.Forms.Button();
            this.Btn_Regist_Return = new System.Windows.Forms.Button();
            this.Btn_Query_Assignment = new System.Windows.Forms.Button();
            this.Btn_Load_Estandar_By_Parts = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Btn_Add_Load
            // 
            this.Btn_Add_Load.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(119)))), ((int)(((byte)(182)))));
            this.Btn_Add_Load.FlatAppearance.BorderSize = 0;
            this.Btn_Add_Load.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Add_Load.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Add_Load.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Btn_Add_Load.Location = new System.Drawing.Point(198, 99);
            this.Btn_Add_Load.Name = "Btn_Add_Load";
            this.Btn_Add_Load.Size = new System.Drawing.Size(195, 63);
            this.Btn_Add_Load.TabIndex = 17;
            this.Btn_Add_Load.Text = "Registrar prestamo de estándar";
            this.Btn_Add_Load.UseVisualStyleBackColor = false;
            this.Btn_Add_Load.Click += new System.EventHandler(this.Btn_Add_Load_Click);
            // 
            // Btn_Regist_Return
            // 
            this.Btn_Regist_Return.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(119)))), ((int)(((byte)(182)))));
            this.Btn_Regist_Return.FlatAppearance.BorderSize = 0;
            this.Btn_Regist_Return.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Regist_Return.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Regist_Return.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Btn_Regist_Return.Location = new System.Drawing.Point(198, 269);
            this.Btn_Regist_Return.Name = "Btn_Regist_Return";
            this.Btn_Regist_Return.Size = new System.Drawing.Size(195, 63);
            this.Btn_Regist_Return.TabIndex = 18;
            this.Btn_Regist_Return.Text = "Registrar Devolucion de Estandard";
            this.Btn_Regist_Return.UseVisualStyleBackColor = false;
            this.Btn_Regist_Return.Click += new System.EventHandler(this.Btn_Regist_Return_Instrument_Click);
            // 
            // Btn_Query_Assignment
            // 
            this.Btn_Query_Assignment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(119)))), ((int)(((byte)(182)))));
            this.Btn_Query_Assignment.FlatAppearance.BorderSize = 0;
            this.Btn_Query_Assignment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Query_Assignment.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Query_Assignment.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Btn_Query_Assignment.Location = new System.Drawing.Point(198, 386);
            this.Btn_Query_Assignment.Name = "Btn_Query_Assignment";
            this.Btn_Query_Assignment.Size = new System.Drawing.Size(195, 63);
            this.Btn_Query_Assignment.TabIndex = 19;
            this.Btn_Query_Assignment.Text = "Consultar Asignacion";
            this.Btn_Query_Assignment.UseVisualStyleBackColor = false;
            this.Btn_Query_Assignment.Click += new System.EventHandler(this.Btn_Query_Assignment_Click);
            // 
            // Btn_Load_Estandar_By_Parts
            // 
            this.Btn_Load_Estandar_By_Parts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(119)))), ((int)(((byte)(182)))));
            this.Btn_Load_Estandar_By_Parts.FlatAppearance.BorderSize = 0;
            this.Btn_Load_Estandar_By_Parts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Load_Estandar_By_Parts.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Load_Estandar_By_Parts.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Btn_Load_Estandar_By_Parts.Location = new System.Drawing.Point(198, 182);
            this.Btn_Load_Estandar_By_Parts.Name = "Btn_Load_Estandar_By_Parts";
            this.Btn_Load_Estandar_By_Parts.Size = new System.Drawing.Size(195, 63);
            this.Btn_Load_Estandar_By_Parts.TabIndex = 20;
            this.Btn_Load_Estandar_By_Parts.Text = "Registrar prestamo de estándar por lotes";
            this.Btn_Load_Estandar_By_Parts.UseVisualStyleBackColor = false;
            this.Btn_Load_Estandar_By_Parts.Click += new System.EventHandler(this.Btn_Load_Estandar_By_Parts_Click);
            // 
            // Assignments_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 507);
            this.Controls.Add(this.Btn_Load_Estandar_By_Parts);
            this.Controls.Add(this.Btn_Query_Assignment);
            this.Controls.Add(this.Btn_Regist_Return);
            this.Controls.Add(this.Btn_Add_Load);
            this.Name = "Assignments_Menu";
            this.Text = "Asignaciones ";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button Btn_Add_Load;
        private System.Windows.Forms.Button Btn_Regist_Return;
        private System.Windows.Forms.Button Btn_Query_Assignment;
        private System.Windows.Forms.Button Btn_Load_Estandar_By_Parts;
    }
}