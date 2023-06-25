using StudentAttendanceManagementSystem.ClassModule;
using StudentAttendanceManagementSystem.StudentModule;
using StudentAttendanceManagementSystem.Tools;
using System;
using System.Collections;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace StudentAttendanceManagementSystem.DashBoardModule
{
    public partial class DashBoardForm : Form
    {
        private string username;
        public DashBoardForm()
        {
            InitializeComponent();
        }

        // 2023-06-10
        public DashBoardForm(string user_name)
        {
            InitializeComponent();

            this.username = user_name;
        }

        private void btn_class_form_Click(object sender, EventArgs e)
        {
            ClassForm class_form = new ClassForm();

            class_form.Show();
            this.Hide();
        }

        private void btn_student_form_Click(object sender, EventArgs e)
        {
            generated_from_database();
            StudentForm student_form = new StudentForm(
                class_code_list[0].ToString(),
                class_semester_list[0].ToString(),
                class_school_year_list[0].ToString(),
                class_department[0].ToString(),
                class_college[0].ToString());

            student_form.Show();
            Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainForm main_form = new MainForm();

            main_form.Show();
            Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void btn_attendance_form_Click(object sender, EventArgs e)
        {
            generated_from_database();
            AttendanceForm attendance_form = new AttendanceForm(
                class_college[0].ToString(),
                class_department[0].ToString(),
                class_semester_list[0].ToString(),
                class_school_year_list[0].ToString(),
                class_code_list[0].ToString(),
                DBTools.get_current_date());

            attendance_form.Show();
            Hide();
        }

        private void gb_check_attendance_Enter(object sender, EventArgs e)
        {

        }

        private void lbl_chck_attndce_Click(object sender, EventArgs e)
        {
            // go to attendance form
            MessageBox.Show("Shortcut to go to checking attendance.");
        }

        private void btn_reports_Click(object sender, EventArgs e)
        {
            ReportsModule.ReportsForm rf = new ReportsModule.ReportsForm();

            rf.Show();
            Hide();
        }

        private void btn_users_Click(object sender, EventArgs e)
        {
            UserModule.UserForm uf = new UserModule.UserForm();

            uf.Show();
            Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Shortcut to view students");
        }

        private void label3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Shortcut to generate reports");
        }

        private void label1_MouseEnter(object sender, EventArgs e)
        {
            // MessageBox.Show("Name of the current user will appear here!");
        }

        private void DashBoardForm_Load(object sender, EventArgs e)
        {
            try
            {
                if (DBTools.is_table_empty("classes_table"))
                {
                    SetupFormAddDefaultClass setup = new SetupFormAddDefaultClass();

                    setup.Show();
                    this.Hide();
                }
                //generate_first_three_classes();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Console.WriteLine("selecting all that have 20 percent absent from database...");
            //MessageBox.Show("selecting all that have 20 percent absent from database");
            AttendanceTools.select_all_that_have_20_percent_absent_from_database("test123");
        }

        #region comments 2023-06-11
        // 2023-06-10
        private ArrayList class_code_list = new ArrayList();
        private ArrayList class_name_list = new ArrayList();
        private ArrayList class_semester_list = new ArrayList();
        private ArrayList class_school_year_list = new ArrayList();
        private ArrayList class_department = new ArrayList();
        private ArrayList class_college = new ArrayList();
        private int size_list = 0;

        #region Get data from database
        private void generated_from_database()
        {
            try
            {
                class_code_list.Clear();
                class_name_list.Clear();
                class_semester_list.Clear();
                class_school_year_list.Clear();
                class_department.Clear();
                class_college.Clear();

                get_data_from_database("class_code", 1);
                get_data_from_database("class_name", 2);
                get_data_from_database("class_semester", 3);
                get_data_from_database("class_school_year", 4);
                get_data_from_database("class_department", 5);
                get_data_from_database("class_college", 6);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void get_data_from_database(string column_name, int flag)
        {
            // Get data from database 
            SqlConnection conn = new SqlConnection(DBTools.get_connection_string());
            string table_name = "classes_table"; //tb_subject_code_add.Text.Replace("-", "_") + "_" + tb_subject_name_add.Text + "_" + cb_semester_add.Text + "_" + tb_school_year_add.Text.Replace("-", "_");

            #region try one
            try
            {
                conn.Open();

                string query = "SELECT " + column_name + " FROM " + table_name.ToString();
                SqlCommand cmd = new SqlCommand(query, conn);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        int column_index = reader.GetOrdinal(column_name);
                        while (reader.Read())
                        {
                            string column_value = reader.GetString(column_index);
                            switch (flag)
                            {
                                case 1:
                                    class_code_list.Add(column_value);
                                    // MessageBox.Show(column_value);
                                    size_list++;
                                    break;
                                case 2:
                                    class_name_list.Add(column_value);
                                    //MessageBox.Show(column_value);
                                    break;
                                case 3:
                                    class_semester_list.Add(column_value);
                                    // MessageBox.Show(column_value);
                                    break;
                                case 4:
                                    class_school_year_list.Add(column_value);
                                    //MessageBox.Show(column_value);
                                    break;
                                case 5:
                                    class_department.Add(column_value);
                                    // MessageBox.Show(column_value);
                                    break;
                                case 6:
                                    class_college.Add(column_value);
                                    //MessageBox.Show(column_value);
                                    break;
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("No data found!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            #endregion

        }

        #endregion
        /// END -> 2023-06-10
        #endregion


        #region Get data of the class [class code, name, etc.] and pass to student form
        private ArrayList value_to_return = new ArrayList();
        private string get_class_data_from_database(string class_code, string column_name)
        {
            value_to_return.Clear();

            SqlConnection conn = new SqlConnection(DBTools.get_connection_string());
            string table_name = "classes_table";

            try
            {
                conn.Open();

                string query = "SELECT " + column_name + " FROM " + table_name.ToString() + " WHERE class_code = '" + class_code + "';";
                SqlCommand cmd = new SqlCommand(query, conn);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        int column_index = reader.GetOrdinal(column_name);
                        while (reader.Read())
                        {
                            string column_value = reader.GetString(column_index);
                            value_to_return.Add(column_value);
                            //MessageBox.Show(column_value);
                            Console.WriteLine(column_value);
                        }
                    }
                    else
                    {
                        MessageBox.Show("No data found!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            return value_to_return[0].ToString();
        }
        #endregion


        private void panel_top_three_classes_Paint(object sender, PaintEventArgs e)
        {

        }

        #region Experimental [2023-06-11]

        private void generate_first_three_classes()
        {
            int max_classes = 2; // will only generate user control for the
            // first 3 classes
            generated_from_database();

            panel_top_three_classes.Controls.Clear();

            MyClassUserControl[] list_items = new MyClassUserControl[10];
            //class_code_list.Sort();

            try
            {
                for (int i = 0; i < max_classes; i++)
                {
                    // create and story every dynamic user control object to list item array
                    list_items[i] = new MyClassUserControl();
                    list_items[i].ClassCode = class_code_list[i].ToString();
                    list_items[i].ClassName = class_name_list[i].ToString();
                    list_items[i].ClassSemester = class_semester_list[i].ToString();
                    list_items[i].ClassSchoolYear = class_school_year_list[i].ToString();

                    //MessageBox.Show("Inside generate first 3 class");
                    //MessageBox.Show(list_items[i].ClassCode.ToString());
                    //MessageBox.Show("Done");

                    // adding newly created dynamic user control to dynamic panel
                    panel_top_three_classes.Controls.Add(list_items[i]);

                    list_items[i].Click += new System.EventHandler(this.UserControl_Click);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void UserControl_Click(object sender, EventArgs e)
        {
            MyClassUserControl obj = (MyClassUserControl)sender;

            MessageBox.Show(obj.ClassName + " " + obj.ClassCode);
            // go to students form
            // get all the needed data and pass to student form
            string class_department = get_class_data_from_database(obj.ClassCode, "class_department");
            //MessageBox.Show("From usercontrol_click method: " + class_department);
            string class_college = get_class_data_from_database(obj.ClassCode, "class_college");
            //MessageBox.Show("From usercontrol_click method: " + class_college);

            StudentForm student_form = new StudentForm(obj.ClassCode, obj.ClassSemester, obj.ClassSchoolYear, class_department, class_college);

            student_form.Show();
            Hide();
        }


        #endregion Experimental [2023-06-11]

        #region Hover effects
        private void btn_attendance_form_MouseLeave(object sender, EventArgs e)
        {
            this.btn_attendance_form.BackColor = Color.FromArgb(224, 224, 224);
        }

        private void btn_attendance_form_MouseEnter(object sender, EventArgs e)
        {
            this.btn_attendance_form.BackColor = Color.FromArgb(255, 128, 255);
        }


        private void btn_student_form_MouseEnter(object sender, EventArgs e)
        {
            this.btn_student_form.BackColor = Color.FromArgb(255, 128, 255);
        }

        private void btn_student_form_MouseLeave(object sender, EventArgs e)
        {
            this.btn_student_form.BackColor = Color.FromArgb(224, 224, 224);
        }

        private void btn_class_form_MouseEnter(object sender, EventArgs e)
        {
            this.btn_class_form.BackColor = Color.FromArgb(255, 128, 255);
        }

        private void btn_class_form_MouseLeave(object sender, EventArgs e)
        {
            this.btn_class_form.BackColor = Color.FromArgb(224, 224, 224);
        }

        private void btn_reports_MouseEnter(object sender, EventArgs e)
        {
            this.btn_reports.BackColor = Color.FromArgb(255, 128, 255);
        }

        private void btn_reports_MouseLeave(object sender, EventArgs e)
        {
            this.btn_reports.BackColor = Color.FromArgb(224, 224, 224);
        }

        private void btn_users_MouseEnter(object sender, EventArgs e)
        {
            this.btn_users.BackColor = Color.FromArgb(255, 128, 255);
        }

        private void btn_users_MouseLeave(object sender, EventArgs e)
        {
            this.btn_users.BackColor = Color.FromArgb(224, 224, 224);
        }

        // logout
        private void button1_MouseEnter(object sender, EventArgs e)
        {
            this.button1.BackColor = Color.Red;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            this.button1.BackColor = Color.FromArgb(224, 224, 224);
        }
        #endregion

        private void lbl_username_Click(object sender, EventArgs e)
        {

        }

        private void setup()
        {
            Console.WriteLine("Setting up...");
            try
            {
                SetupFormAddDefaultClass add = new SetupFormAddDefaultClass();

                add.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }

            Console.WriteLine("Done...");
            Hide();
        }
    }
}
