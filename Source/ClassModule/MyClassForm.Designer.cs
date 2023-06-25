namespace StudentAttendanceManagementSystem.ClassModule
{
    partial class MyClassForm
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
            this.lbl_class_code = new System.Windows.Forms.Label();
            this.lbl_class_name = new System.Windows.Forms.Label();
            this.lbl_school_year = new System.Windows.Forms.Label();
            this.lbl_semester = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_class_code
            // 
            this.lbl_class_code.AutoSize = true;
            this.lbl_class_code.Font = new System.Drawing.Font("Courier New", 9F);
            this.lbl_class_code.Location = new System.Drawing.Point(18, 10);
            this.lbl_class_code.Name = "lbl_class_code";
            this.lbl_class_code.Size = new System.Drawing.Size(125, 17);
            this.lbl_class_code.TabIndex = 1;
            this.lbl_class_code.Text = "Subject Code:";
            // 
            // lbl_class_name
            // 
            this.lbl_class_name.AutoSize = true;
            this.lbl_class_name.Font = new System.Drawing.Font("Courier New", 9F);
            this.lbl_class_name.Location = new System.Drawing.Point(18, 38);
            this.lbl_class_name.Name = "lbl_class_name";
            this.lbl_class_name.Size = new System.Drawing.Size(125, 17);
            this.lbl_class_name.TabIndex = 3;
            this.lbl_class_name.Text = "Subject Name:";
            // 
            // lbl_school_year
            // 
            this.lbl_school_year.AutoSize = true;
            this.lbl_school_year.Font = new System.Drawing.Font("Courier New", 9F);
            this.lbl_school_year.Location = new System.Drawing.Point(18, 94);
            this.lbl_school_year.Name = "lbl_school_year";
            this.lbl_school_year.Size = new System.Drawing.Size(116, 17);
            this.lbl_school_year.TabIndex = 5;
            this.lbl_school_year.Text = "School Year:";
            // 
            // lbl_semester
            // 
            this.lbl_semester.AutoSize = true;
            this.lbl_semester.Font = new System.Drawing.Font("Courier New", 9F);
            this.lbl_semester.Location = new System.Drawing.Point(18, 66);
            this.lbl_semester.Name = "lbl_semester";
            this.lbl_semester.Size = new System.Drawing.Size(89, 17);
            this.lbl_semester.TabIndex = 4;
            this.lbl_semester.Text = "Semester:";
            // 
            // MyClassForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.lbl_school_year);
            this.Controls.Add(this.lbl_semester);
            this.Controls.Add(this.lbl_class_name);
            this.Controls.Add(this.lbl_class_code);
            this.Name = "MyClassForm";
            this.Size = new System.Drawing.Size(181, 119);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_class_code;
        private System.Windows.Forms.Label lbl_class_name;
        private System.Windows.Forms.Label lbl_school_year;
        private System.Windows.Forms.Label lbl_semester;
    }
}
