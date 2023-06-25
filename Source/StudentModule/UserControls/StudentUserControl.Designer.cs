namespace StudentAttendanceManagementSystem.StudentModule.UserControls
{
    partial class StudentUserControl
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
            this.lbl_id_number = new System.Windows.Forms.Label();
            this.lbl_name = new System.Windows.Forms.Label();
            this.lbl_total_present = new System.Windows.Forms.Label();
            this.lbl_total_absents = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_id_number
            // 
            this.lbl_id_number.AutoSize = true;
            this.lbl_id_number.Location = new System.Drawing.Point(22, 16);
            this.lbl_id_number.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_id_number.Name = "lbl_id_number";
            this.lbl_id_number.Size = new System.Drawing.Size(109, 20);
            this.lbl_id_number.TabIndex = 0;
            this.lbl_id_number.Text = "ID NUMBER:";
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Location = new System.Drawing.Point(242, 16);
            this.lbl_name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(59, 20);
            this.lbl_name.TabIndex = 1;
            this.lbl_name.Text = "NAME:";
            // 
            // lbl_total_present
            // 
            this.lbl_total_present.AutoSize = true;
            this.lbl_total_present.Location = new System.Drawing.Point(341, 47);
            this.lbl_total_present.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_total_present.Name = "lbl_total_present";
            this.lbl_total_present.Size = new System.Drawing.Size(159, 20);
            this.lbl_total_present.TabIndex = 3;
            this.lbl_total_present.Text = "TOTAL PRESENTS:";
            this.lbl_total_present.Visible = false;
            // 
            // lbl_total_absents
            // 
            this.lbl_total_absents.AutoSize = true;
            this.lbl_total_absents.Location = new System.Drawing.Point(341, 16);
            this.lbl_total_absents.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_total_absents.Name = "lbl_total_absents";
            this.lbl_total_absents.Size = new System.Drawing.Size(159, 20);
            this.lbl_total_absents.TabIndex = 2;
            this.lbl_total_absents.Text = "TOTAL ABSENTS: ";
            this.lbl_total_absents.Visible = false;
            // 
            // StudentUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.lbl_total_present);
            this.Controls.Add(this.lbl_total_absents);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.lbl_id_number);
            this.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "StudentUserControl";
            this.Size = new System.Drawing.Size(602, 45);
            this.Load += new System.EventHandler(this.StudentUserControl_Load);
            this.MouseEnter += new System.EventHandler(this.StudentUserControl_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.StudentUserControl_MouseLeave);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_id_number;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label lbl_total_present;
        private System.Windows.Forms.Label lbl_total_absents;
    }
}
