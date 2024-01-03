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
            this.Btn_Serch_Assignments = new System.Windows.Forms.Button();
            this.Btn_Add_Assignments = new System.Windows.Forms.Button();
            this.Btn_Regist_Return = new System.Windows.Forms.Button();
            this.Btn_Query_Assignment = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Btn_Serch_Assignments
            // 
            this.Btn_Serch_Assignments.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(119)))), ((int)(((byte)(182)))));
            this.Btn_Serch_Assignments.FlatAppearance.BorderSize = 0;
            this.Btn_Serch_Assignments.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Serch_Assignments.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Serch_Assignments.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Btn_Serch_Assignments.Location = new System.Drawing.Point(198, 102);
            this.Btn_Serch_Assignments.Name = "Btn_Serch_Assignments";
            this.Btn_Serch_Assignments.Size = new System.Drawing.Size(195, 50);
            this.Btn_Serch_Assignments.TabIndex = 16;
            this.Btn_Serch_Assignments.Text = "Buscar";
            this.Btn_Serch_Assignments.UseVisualStyleBackColor = false;
            this.Btn_Serch_Assignments.Click += new System.EventHandler(this.Btn_Serch_Assignments_Click);
            // 
            // Btn_Add_Assignments
            // 
            this.Btn_Add_Assignments.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(119)))), ((int)(((byte)(182)))));
            this.Btn_Add_Assignments.FlatAppearance.BorderSize = 0;
            this.Btn_Add_Assignments.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Add_Assignments.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Add_Assignments.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Btn_Add_Assignments.Location = new System.Drawing.Point(198, 179);
            this.Btn_Add_Assignments.Name = "Btn_Add_Assignments";
            this.Btn_Add_Assignments.Size = new System.Drawing.Size(195, 63);
            this.Btn_Add_Assignments.TabIndex = 17;
            this.Btn_Add_Assignments.Text = "Registrar Entrega de Estandard";
            this.Btn_Add_Assignments.UseVisualStyleBackColor = false;
            this.Btn_Add_Assignments.Click += new System.EventHandler(this.Btn_Add_Assignments_Click);
            // 
            // Btn_Regist_Return
            // 
            this.Btn_Regist_Return.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(119)))), ((int)(((byte)(182)))));
            this.Btn_Regist_Return.FlatAppearance.BorderSize = 0;
            this.Btn_Regist_Return.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Regist_Return.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Regist_Return.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Btn_Regist_Return.Location = new System.Drawing.Point(198, 272);
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
            this.Btn_Query_Assignment.Location = new System.Drawing.Point(198, 375);
            this.Btn_Query_Assignment.Name = "Btn_Query_Assignment";
            this.Btn_Query_Assignment.Size = new System.Drawing.Size(195, 63);
            this.Btn_Query_Assignment.TabIndex = 19;
            this.Btn_Query_Assignment.Text = "Consultar Asignacion";
            this.Btn_Query_Assignment.UseVisualStyleBackColor = false;
            // 
            // Assignments_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 486);
            this.Controls.Add(this.Btn_Query_Assignment);
            this.Controls.Add(this.Btn_Regist_Return);
            this.Controls.Add(this.Btn_Add_Assignments);
            this.Controls.Add(this.Btn_Serch_Assignments);
            this.Name = "Assignments_Menu";
            this.Text = "Asignaciones ";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Btn_Serch_Assignments;
        private System.Windows.Forms.Button Btn_Add_Assignments;
        private System.Windows.Forms.Button Btn_Regist_Return;
        private System.Windows.Forms.Button Btn_Query_Assignment;
    }
}