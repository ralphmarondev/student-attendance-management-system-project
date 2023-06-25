using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace StudentAttendanceManagementSystem.ClassModule
{
    public partial class MyClassUserControl : UserControl
    {
        public MyClassUserControl()
        {
            InitializeComponent();
        }

        #region Getter and Setter for labels
        private string class_code;
        private string class_name;
        private string class_semester;
        private string class_school_year;

        [Category("Custom Props")]
        public string ClassCode
        {
            get { return class_code; }
            set { class_code = value; lbl_class_code.Text = value; }
        }

        [Category("Custom Props")]
        public string ClassName
        {
            get { return class_name; }
            set { class_name = value; lbl_class_name.Text = value; }
        }

        [Category("Custom Props")]
        public string ClassSemester
        {
            get { return class_semester; }
            set { class_semester = value; lbl_class_semester.Text = value; }
        }

        [Category("Custom Props")]
        public string ClassSchoolYear
        {
            get { return class_school_year; }
            set { class_school_year = value; lbl_class_sy.Text = value; }
        }
        #endregion


        #region Hover effect
        private void MyClassUserControl_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(255, 128, 255);
        }

        private void MyClassUserControl_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(255, 192, 255);
        }
        #endregion

        private void MyClassUserControl_Load(object sender, EventArgs e)
        {

        }
    }
}
