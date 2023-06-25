namespace StudentAttendanceManagementSystem.ClassModule
{
    partial class UpdateClassForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateClassForm));
            this.gb_add_class = new System.Windows.Forms.GroupBox();
            this.btn_search = new System.Windows.Forms.Button();
            this.tb_department = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_college = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_semester = new System.Windows.Forms.ComboBox();
            this.btn_finish_add = new System.Windows.Forms.Button();
            this.tb_school_year = new System.Windows.Forms.TextBox();
            this.lbl_school_year_add = new System.Windows.Forms.Label();
            this.lbl_semester_add = new System.Windows.Forms.Label();
            this.tb_subject_name = new System.Windows.Forms.TextBox();
            this.lbl_subject_name_add = new System.Windows.Forms.Label();
            this.tb_subject_code = new System.Windows.Forms.TextBox();
            this.lbl_subject_code_add = new System.Windows.Forms.Label();
            this.gb_add_class.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_add_class
            // 
            this.gb_add_class.BackColor = System.Drawing.Color.LightCyan;
            this.gb_add_class.Controls.Add(this.btn_search);
            this.gb_add_class.Controls.Add(this.tb_department);
            this.gb_add_class.Controls.Add(this.label1);
            this.gb_add_class.Controls.Add(this.tb_college);
            this.gb_add_class.Controls.Add(this.label2);
            this.gb_add_class.Controls.Add(this.cb_semester);
            this.gb_add_class.Controls.Add(this.btn_finish_add);
            this.gb_add_class.Controls.Add(this.tb_school_year);
            this.gb_add_class.Controls.Add(this.lbl_school_year_add);
            this.gb_add_class.Controls.Add(this.lbl_semester_add);
            this.gb_add_class.Controls.Add(this.tb_subject_name);
            this.gb_add_class.Controls.Add(this.lbl_subject_name_add);
            this.gb_add_class.Controls.Add(this.tb_subject_code);
            this.gb_add_class.Controls.Add(this.lbl_subject_code_add);
            this.gb_add_class.Location = new System.Drawing.Point(36, 28);
            this.gb_add_class.Margin = new System.Windows.Forms.Padding(4);
            this.gb_add_class.Name = "gb_add_class";
            this.gb_add_class.Padding = new System.Windows.Forms.Padding(4);
            this.gb_add_class.Size = new System.Drawing.Size(1040, 515);
            this.gb_add_class.TabIndex = 2;
            this.gb_add_class.TabStop = false;
            // 
            // btn_search
            // 
            this.btn_search.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_search.Location = new System.Drawing.Point(313, 89);
            this.btn_search.Margin = new System.Windows.Forms.Padding(4);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(163, 29);
            this.btn_search.TabIndex = 18;
            this.btn_search.Text = "SEARCH";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // tb_department
            // 
            this.tb_department.Font = new System.Drawing.Font("Courier New", 12F);
            this.tb_department.Location = new System.Drawing.Point(531, 196);
            this.tb_department.Margin = new System.Windows.Forms.Padding(4);
            this.tb_department.Name = "tb_department";
            this.tb_department.Size = new System.Drawing.Size(445, 30);
            this.tb_department.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(526, 156);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 22);
            this.label1.TabIndex = 16;
            this.label1.Text = "Department:";
            // 
            // tb_college
            // 
            this.tb_college.Font = new System.Drawing.Font("Courier New", 12F);
            this.tb_college.Location = new System.Drawing.Point(531, 89);
            this.tb_college.Margin = new System.Windows.Forms.Padding(4);
            this.tb_college.Name = "tb_college";
            this.tb_college.Size = new System.Drawing.Size(445, 30);
            this.tb_college.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(526, 49);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 22);
            this.label2.TabIndex = 14;
            this.label2.Text = "College:";
            // 
            // cb_semester
            // 
            this.cb_semester.Font = new System.Drawing.Font("Courier New", 12F);
            this.cb_semester.FormattingEnabled = true;
            this.cb_semester.Items.AddRange(new object[] {
            "First Semester",
            "Second Semester"});
            this.cb_semester.Location = new System.Drawing.Point(31, 305);
            this.cb_semester.Margin = new System.Windows.Forms.Padding(4);
            this.cb_semester.Name = "cb_semester";
            this.cb_semester.Size = new System.Drawing.Size(445, 30);
            this.cb_semester.TabIndex = 9;
            // 
            // btn_finish_add
            // 
            this.btn_finish_add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_finish_add.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_finish_add.BackgroundImage")));
            this.btn_finish_add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_finish_add.Font = new System.Drawing.Font("Courier New", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_finish_add.Location = new System.Drawing.Point(31, 398);
            this.btn_finish_add.Margin = new System.Windows.Forms.Padding(4);
            this.btn_finish_add.Name = "btn_finish_add";
            this.btn_finish_add.Size = new System.Drawing.Size(948, 65);
            this.btn_finish_add.TabIndex = 8;
            this.btn_finish_add.Text = "UPDATE";
            this.btn_finish_add.UseVisualStyleBackColor = false;
            this.btn_finish_add.Click += new System.EventHandler(this.btn_finish_add_Click);
            // 
            // tb_school_year
            // 
            this.tb_school_year.Font = new System.Drawing.Font("Courier New", 12F);
            this.tb_school_year.Location = new System.Drawing.Point(532, 306);
            this.tb_school_year.Margin = new System.Windows.Forms.Padding(4);
            this.tb_school_year.Name = "tb_school_year";
            this.tb_school_year.Size = new System.Drawing.Size(445, 30);
            this.tb_school_year.TabIndex = 7;
            // 
            // lbl_school_year_add
            // 
            this.lbl_school_year_add.AutoSize = true;
            this.lbl_school_year_add.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_school_year_add.ForeColor = System.Drawing.Color.Black;
            this.lbl_school_year_add.Location = new System.Drawing.Point(528, 266);
            this.lbl_school_year_add.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_school_year_add.Name = "lbl_school_year_add";
            this.lbl_school_year_add.Size = new System.Drawing.Size(142, 22);
            this.lbl_school_year_add.TabIndex = 6;
            this.lbl_school_year_add.Text = "School Year:";
            // 
            // lbl_semester_add
            // 
            this.lbl_semester_add.AutoSize = true;
            this.lbl_semester_add.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_semester_add.ForeColor = System.Drawing.Color.Black;
            this.lbl_semester_add.Location = new System.Drawing.Point(28, 266);
            this.lbl_semester_add.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_semester_add.Name = "lbl_semester_add";
            this.lbl_semester_add.Size = new System.Drawing.Size(109, 22);
            this.lbl_semester_add.TabIndex = 4;
            this.lbl_semester_add.Text = "Semester:";
            // 
            // tb_subject_name
            // 
            this.tb_subject_name.Font = new System.Drawing.Font("Courier New", 12F);
            this.tb_subject_name.Location = new System.Drawing.Point(31, 196);
            this.tb_subject_name.Margin = new System.Windows.Forms.Padding(4);
            this.tb_subject_name.Name = "tb_subject_name";
            this.tb_subject_name.Size = new System.Drawing.Size(445, 30);
            this.tb_subject_name.TabIndex = 3;
            // 
            // lbl_subject_name_add
            // 
            this.lbl_subject_name_add.AutoSize = true;
            this.lbl_subject_name_add.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_subject_name_add.ForeColor = System.Drawing.Color.Black;
            this.lbl_subject_name_add.Location = new System.Drawing.Point(26, 156);
            this.lbl_subject_name_add.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_subject_name_add.Name = "lbl_subject_name_add";
            this.lbl_subject_name_add.Size = new System.Drawing.Size(153, 22);
            this.lbl_subject_name_add.TabIndex = 2;
            this.lbl_subject_name_add.Text = "Subject Name:";
            // 
            // tb_subject_code
            // 
            this.tb_subject_code.Font = new System.Drawing.Font("Courier New", 12F);
            this.tb_subject_code.Location = new System.Drawing.Point(31, 89);
            this.tb_subject_code.Margin = new System.Windows.Forms.Padding(4);
            this.tb_subject_code.Name = "tb_subject_code";
            this.tb_subject_code.Size = new System.Drawing.Size(274, 30);
            this.tb_subject_code.TabIndex = 1;
            // 
            // lbl_subject_code_add
            // 
            this.lbl_subject_code_add.AutoSize = true;
            this.lbl_subject_code_add.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_subject_code_add.ForeColor = System.Drawing.Color.Black;
            this.lbl_subject_code_add.Location = new System.Drawing.Point(26, 49);
            this.lbl_subject_code_add.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_subject_code_add.Name = "lbl_subject_code_add";
            this.lbl_subject_code_add.Size = new System.Drawing.Size(153, 22);
            this.lbl_subject_code_add.TabIndex = 0;
            this.lbl_subject_code_add.Text = "Subject Code:";
            // 
            // UpdateClassForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1091, 582);
            this.Controls.Add(this.gb_add_class);
            this.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UpdateClassForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UpdateClassForm";
            this.Load += new System.EventHandler(this.UpdateClassForm_Load);
            this.gb_add_class.ResumeLayout(false);
            this.gb_add_class.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_add_class;
        private System.Windows.Forms.ComboBox cb_semester;
        private System.Windows.Forms.Button btn_finish_add;
        private System.Windows.Forms.TextBox tb_school_year;
        private System.Windows.Forms.Label lbl_school_year_add;
        private System.Windows.Forms.Label lbl_semester_add;
        private System.Windows.Forms.TextBox tb_subject_name;
        private System.Windows.Forms.Label lbl_subject_name_add;
        private System.Windows.Forms.TextBox tb_subject_code;
        private System.Windows.Forms.Label lbl_subject_code_add;
        private System.Windows.Forms.TextBox tb_department;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_college;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_search;
    }
}