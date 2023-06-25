using StudentAttendanceManagementSystem.ClassModule;
using StudentAttendanceManagementSystem.GuestUserModules.GuessUserDashBoard;
using StudentAttendanceManagementSystem.GuestUserModules.GuestStudentModule;
using StudentAttendanceManagementSystem.StudentModule.UserControls;
using StudentAttendanceManagementSystem.Tools;
using System;
using System.Collections;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace StudentAttendanceManagementSystem.GuestUserModules.GuestClassModule
{
    public partial class GuestClassForm : Form
    {

        #region variables
        private ArrayList class_code_list = new ArrayList();
        private ArrayList class_name_list = new ArrayList();
        private ArrayList class_semester_list = new ArrayList();
        private ArrayList class_school_year_list = new ArrayList();
        private int size_list = 0;
        #endregion
        public GuestClassForm()
        {
            InitializeComponent();
        }

        private void GuestClassForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            GuestDashBoardForm guest_dashboard_form = new GuestDashBoardForm();

            guest_dashboard_form.Show();
            Hide();
        }

        private void btn_back_Click(object sender, System.EventArgs e)
        {
            GuestDashBoardForm form = new GuestDashBoardForm();

            form.Show();
            Hide();
        }

        private void btn_search_class_Click(object sender, System.EventArgs e)
        {

            string class_code = tb_class_code_search.Text;
            // class_code = "test123";
            generate_searched_class_user_control(class_code);
        }

        #region search functionality
        // ArrayList searched_class_code_list = new ArrayList();
        private ArrayList searched_class_name_list = new ArrayList();
        private ArrayList searched_class_semester_list = new ArrayList();
        private ArrayList searched_class_school_year_list = new ArrayList();
        private int size_searched_list = 0;

        private void get_data_from_database(string class_code)
        {
            searched_class_name_list.Clear();
            searched_class_semester_list.Clear();
            searched_class_school_year_list.Clear();

            get_searched_data_from_database("class_name", class_code, 1);
            //get_searched_data_from_database("class_semester", class_code, 2);
            //get_searched_data_from_database("class_school_year", class_code, 3);
        }

        private void get_searched_data_from_database(string column_name, string class_code, int flag)
        {
            size_searched_list = 0;
            // Get data from database 
            // string conn_string = "Data Source=LAPTOP-T2HJFRJU\\SQLEXPRESS;Initial Catalog=StudentAttendanceManagementSystemDB;Integrated Security=True";
            SqlConnection conn = new SqlConnection(DBTools.get_connection_string());
            string table_name = "classes_table"; //tb_subject_code_add.Text.Replace("-", "_") + "_" + tb_subject_name_add.Text + "_" + cb_semester_add.Text + "_" + tb_school_year_add.Text.Replace("-", "_");

            #region try one
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
                            switch (flag)
                            {
                                case 1:
                                    searched_class_name_list.Add(column_value);
                                    // MessageBox.Show(column_value);
                                    size_searched_list++;
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

        private void generate_searched_class_user_control(string class_code)
        {
            get_data_from_database(class_code);

            flowLayoutPanel1.Controls.Clear();

            MyClassUserControl[] list_items = new MyClassUserControl[size_searched_list];

            try
            {
                for (int i = 0; i < list_items.Length; i++)
                {
                    // create and story every dynamic user control object to list item array
                    list_items[i] = new MyClassUserControl();
                    list_items[i].ClassCode = class_code;
                    list_items[i].ClassName = searched_class_name_list[i].ToString();

                    // adding newly created dynamic user control to dynamic panel
                    flowLayoutPanel1.Controls.Add(list_items[i]);

                    list_items[i].Click += new System.EventHandler(this.UserControl_Click);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }

        }
        #endregion


        private void btn_show_classes_Click(object sender, System.EventArgs e)
        {
            generate_dynamic_user_control();
        }


        #region Function to generate dynamic user controls
        private void generate_dynamic_user_control()
        {

            generated_from_database();

            flowLayoutPanel1.Controls.Clear();

            MyClassUserControl[] list_items = new MyClassUserControl[size_list];

            //class_code_list.Sort();

            try
            {
                for (int i = 0; i < list_items.Length; i++)
                {
                    // create and story every dynamic user control object to list item array
                    list_items[i] = new MyClassUserControl();
                    list_items[i].ClassCode = class_code_list[i].ToString();
                    list_items[i].ClassName = class_name_list[i].ToString();
                    list_items[i].ClassSemester = class_semester_list[i].ToString();
                    list_items[i].ClassSchoolYear = class_school_year_list[i].ToString();

                    // adding newly created dynamic user control to dynamic panel
                    flowLayoutPanel1.Controls.Add(list_items[i]);

                    list_items[i].Click += new System.EventHandler(this.UserControl_Click);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }

        #endregion


        #region User control click event
        private void UserControl_Click(object sender, EventArgs e)
        {
            MyClassUserControl obj = (MyClassUserControl)sender;

            Console.WriteLine(obj.ClassName + " " + obj.ClassCode);
            //MessageBox.Show(obj.ClassName + " " + obj.ClassCode);
            // go to students form
            // get all the needed data and pass to student form
            string class_department = get_class_data_from_database(obj.ClassCode, "class_department");
            //MessageBox.Show("From usercontrol_click method: " + class_department);
            string class_college = get_class_data_from_database(obj.ClassCode, "class_college");
            //MessageBox.Show("From usercontrol_click method: " + class_college);

            GuestStudentsForm student_form = new GuestStudentsForm(obj.ClassCode, obj.ClassSemester, obj.ClassSchoolYear, class_department, class_college);

            student_form.Show();
            Hide();
        }
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
                Console.WriteLine("Error: " + ex.Message);
            }
            return value_to_return[0].ToString();
        }
        #endregion


        //private void btn_show_classes_Click(object sender, EventArgs e)
        //{
        //    generate_dynamic_user_control();
        //}

        #region Get data from database
        private void generated_from_database()
        {
            class_code_list.Clear();
            class_name_list.Clear();
            class_semester_list.Clear();
            class_school_year_list.Clear();

            get_data_from_database("class_code", 1);
            get_data_from_database("class_name", 2);
            get_data_from_database("class_semester", 3);
            get_data_from_database("class_school_year", 4);
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
                Console.WriteLine("Error: " + ex.Message);
            }
            #endregion

        }

        #endregion

        private void GuestClassForm_Load(object sender, EventArgs e)
        {
            generate_dynamic_user_control();
        }



        #region On text change listener on search 2023-06-10

        #region search student from database
        private ArrayList searched_student_name_list_otc = new ArrayList();
        private ArrayList searched_student_total_absents_otc = new ArrayList();
        private ArrayList searched_student_total_presents_otc = new ArrayList();
        private int search_size_list_otc = 0;

        private void get_searched_student_from_db_otc(string table_name, string id_number)
        {
            // searched_student_id_list.Clear();
            searched_student_name_list_otc.Clear();
            searched_student_total_presents_otc.Clear();
            searched_student_total_absents_otc.Clear(); //class_test123

            // get_searched_student_from_database(table_name, "id_number", 1);
            get_searched_student_from_database_otc("last_name", table_name, id_number, 1);
            // get_data_from_database(table_name, "last_name", 2);
            //get_data_from_database(table_name, "total_presents", 3);
            //get_data_from_database(table_name, "total_absents", 4);
        }

        private void get_searched_student_from_database_otc(string column_name, string table_name, string id_number, int flag)
        {
            // Get data from database 
            // string conn_string = "Data Source=LAPTOP-T2HJFRJU\\SQLEXPRESS;Initial Catalog=StudentAttendanceManagementSystemDB;Integrated Security=True";
            SqlConnection conn = new SqlConnection(DBTools.get_connection_string());
            // string table_name = "classes_table"; //tb_subject_code_add.Text.Replace("-", "_") + "_" + tb_subject_name_add.Text + "_" + cb_semester_add.Text + "_" + tb_school_year_add.Text.Replace("-", "_");

            #region try one
            try
            {
                conn.Open();

                string query = "SELECT " + column_name + " FROM " + table_name + " WHERE id_number like '" + id_number + "';";
                SqlCommand cmd = new SqlCommand(query, conn);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        int column_index = reader.GetOrdinal(column_name);
                        while (reader.Read())
                        {
                            switch (flag)
                            {
                                case 1:
                                    string column_value2 = reader.GetString(column_index);
                                    searched_student_name_list_otc.Add(column_value2);
                                    // search_size_list++;
                                    //MessageBox.Show(column_value);
                                    break;

                            }
                        }
                    }
                    else
                    {
                        //MessageBox.Show("No data found!");
                    }
                }
            }
            catch //(Exception ex)
            {
                //MessageBox.Show("Error: " + ex.Message);
            }
            #endregion

        }

        private void generate_searched_student_dynamic_user_control_otc(string table_name, string id_number)
        {
            // search_size_list = 0;
            try
            {
                get_searched_student_from_db_otc(table_name, id_number);

                flowLayoutPanel1.Controls.Clear();

                //StudentUserControl[] list_items = new StudentUserControl[search_size_list];
                StudentUserControl student = new StudentUserControl();

                student.StudentIDNumber = id_number;
                student.StudentName = searched_student_name_list_otc[0].ToString();
                //list_items[i].StudentTotalPresent = student_total_presents[i].ToString();
                //list_items[i].StudentTotalAbsent = student_total_absents[i].ToString();

                // adding newly created dynamic user control to dynamic panel
                flowLayoutPanel1.Controls.Add(student);

                student.Click += new System.EventHandler(this.UserControl_Click);
                searched_student_name_list_otc.Clear();

            }
            catch
            {
                // no exception is written so that it will not become and
                // interruption while typing the student id
            }
        }

        #endregion


        private void tb_class_code_search_TextChanged_1(object sender, EventArgs e)
        {
            string table_name = "classes_table";
            string class_code = tb_class_code_search.Text;
            //if (id_number.Length == 8)
            generate_searched_student_dynamic_user_control_otc(table_name, class_code);
            //if (id_number == "")
            //    btn_better_view_Click(sender, e);
        }
        #endregion

    }
}
