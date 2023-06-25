namespace StudentAttendanceManagementSystem.AttendanceModule
{
    partial class DeleteAttendanceForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeleteAttendanceForm));
            this.btn_delete = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cb_date = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_class = new System.Windows.Forms.ComboBox();
            this.lbl_class = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.Transparent;
            this.btn_delete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_delete.BackgroundImage")));
            this.btn_delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_delete.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.Location = new System.Drawing.Point(16, 225);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(312, 48);
            this.btn_delete.TabIndex = 3;
            this.btn_delete.Text = "DELETE";
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.groupBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox1.BackgroundImage")));
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.cb_date);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cb_class);
            this.groupBox1.Controls.Add(this.lbl_class);
            this.groupBox1.Controls.Add(this.btn_delete);
            this.groupBox1.Location = new System.Drawing.Point(1, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(364, 302);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DELETE ATTENDANCE";
            // 
            // cb_date
            // 
            this.cb_date.FormattingEnabled = true;
            this.cb_date.Items.AddRange(new object[] {
            "test123"});
            this.cb_date.Location = new System.Drawing.Point(19, 190);
            this.cb_date.Margin = new System.Windows.Forms.Padding(4);
            this.cb_date.Name = "cb_date";
            this.cb_date.Size = new System.Drawing.Size(310, 28);
            this.cb_date.TabIndex = 28;
            this.cb_date.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 114);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(219, 22);
            this.label2.TabIndex = 29;
            this.label2.Text = "Date of attendance:";
            // 
            // cb_class
            // 
            this.cb_class.FormattingEnabled = true;
            this.cb_class.Items.AddRange(new object[] {
            "test123"});
            this.cb_class.Location = new System.Drawing.Point(18, 74);
            this.cb_class.Margin = new System.Windows.Forms.Padding(4);
            this.cb_class.Name = "cb_class";
            this.cb_class.Size = new System.Drawing.Size(310, 28);
            this.cb_class.TabIndex = 26;
            // 
            // lbl_class
            // 
            this.lbl_class.AutoSize = true;
            this.lbl_class.BackColor = System.Drawing.Color.Transparent;
            this.lbl_class.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_class.Location = new System.Drawing.Point(15, 43);
            this.lbl_class.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_class.Name = "lbl_class";
            this.lbl_class.Size = new System.Drawing.Size(131, 22);
            this.lbl_class.TabIndex = 27;
            this.lbl_class.Text = "Class Code:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(18, 144);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(309, 27);
            this.dateTimePicker1.TabIndex = 30;
            // 
            // DeleteAttendanceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 303);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DeleteAttendanceForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DeleteAttendanceForm";
            this.Load += new System.EventHandler(this.DeleteAttendanceForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cb_date;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_class;
        private System.Windows.Forms.Label lbl_class;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}