namespace StudentAttendanceManagementSystem.ClassModule
{
    partial class MyClassUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_class_name = new System.Windows.Forms.Label();
            this.lbl_class_code = new System.Windows.Forms.Label();
            this.lbl_class_sy = new System.Windows.Forms.Label();
            this.lbl_class_semester = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_class_name
            // 
            this.lbl_class_name.AutoSize = true;
            this.lbl_class_name.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_class_name.Location = new System.Drawing.Point(21, 41);
            this.lbl_class_name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_class_name.Name = "lbl_class_name";
            this.lbl_class_name.Size = new System.Drawing.Size(109, 20);
            this.lbl_class_name.TabIndex = 3;
            this.lbl_class_name.Text = "CLASS NAME";
            // 
            // lbl_class_code
            // 
            this.lbl_class_code.AutoSize = true;
            this.lbl_class_code.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_class_code.Location = new System.Drawing.Point(21, 9);
            this.lbl_class_code.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_class_code.Name = "lbl_class_code";
            this.lbl_class_code.Size = new System.Drawing.Size(130, 23);
            this.lbl_class_code.TabIndex = 2;
            this.lbl_class_code.Text = "CLASS CODE";
            // 
            // lbl_class_sy
            // 
            this.lbl_class_sy.AutoSize = true;
            this.lbl_class_sy.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_class_sy.Location = new System.Drawing.Point(21, 101);
            this.lbl_class_sy.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_class_sy.Name = "lbl_class_sy";
            this.lbl_class_sy.Size = new System.Drawing.Size(99, 20);
            this.lbl_class_sy.TabIndex = 4;
            this.lbl_class_sy.Text = "2022-2023";
            // 
            // lbl_class_semester
            // 
            this.lbl_class_semester.AutoSize = true;
            this.lbl_class_semester.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_class_semester.Location = new System.Drawing.Point(21, 71);
            this.lbl_class_semester.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_class_semester.Name = "lbl_class_semester";
            this.lbl_class_semester.Size = new System.Drawing.Size(159, 20);
            this.lbl_class_semester.TabIndex = 5;
            this.lbl_class_semester.Text = "SECOND SEMESTER";
            // 
            // MyClassUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.lbl_class_semester);
            this.Controls.Add(this.lbl_class_sy);
            this.Controls.Add(this.lbl_class_name);
            this.Controls.Add(this.lbl_class_code);
            this.Name = "MyClassUserControl";
            this.Size = new System.Drawing.Size(268, 132);
            this.Load += new System.EventHandler(this.MyClassUserControl_Load);
            this.MouseEnter += new System.EventHandler(this.MyClassUserControl_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.MyClassUserControl_MouseLeave);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_class_name;
        private System.Windows.Forms.Label lbl_class_code;
        private System.Windows.Forms.Label lbl_class_sy;
        private System.Windows.Forms.Label lbl_class_semester;
    }
}
