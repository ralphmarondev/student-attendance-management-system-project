using StudentAttendanceManagementSystem.DashBoardModule;
using StudentAttendanceManagementSystem.ReportsModule;
using StudentAttendanceManagementSystem.StudentModule.UserControls;
using StudentAttendanceManagementSystem.Tools;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace StudentAttendanceManagementSystem.StudentModule
{
    public partial class StudentForm : Form
    {
        public StudentForm()
        {
            InitializeComponent();
            //cb_date.Text = DBTools.get_current_date();//.Replace("_", "-");
        }

        // constructor for passing data
        //
        // [class_code]
        //,[class_name]
        //,[class_semester]
        //,[class_school_year]
        //,[class_department]
        //,[class_college]
        public StudentForm(string class_code, string class_semester, string school_year, string department, string college)
        {
            InitializeComponent();

            cb_class.Text = class_code;
            cb_semester.Text = class_semester;
            cb_school_year.Text = school_year;
            cb_department.Text = department;
            cb_college.Text = college;

            cb_date.Text = DBTools.get_current_date();
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            try
            {
                string class_code = "class_" + cb_class.Text;
                // string MyConnection2 = "Data Source=LAPTOP-T2HJFRJU\\SQLEXPRESS;Initial Catalog=StudentAttendanceManagementSystemDB;Integrated Security=True";
                //Display query
                string Query = "select * from " + class_code + ";";
                SqlConnection MyConn2 = new SqlConnection(DBTools.get_connection_string());
                SqlCommand MyCommand2 = new SqlCommand(Query, MyConn2);
                //  MyConn2.Open();
                //For off-line connection we will use  MySqlDataAdapter class.
                SqlDataAdapter MyAdapter = new SqlDataAdapter();
                MyAdapter.SelectCommand = MyCommand2;
                DataTable dTable = new DataTable();
                MyAdapter.Fill(dTable);
                dgv_classes_lists.DataSource = dTable; // here i have assign dTable object to the dataGridView1 object to display data.
                                                       // MyConn2.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_add_class_Click(object sender, EventArgs e)
        {
            AddStudentForm add_student_form = new AddStudentForm(cb_college.Text, cb_department.Text, cb_semester.Text, cb_school_year.Text, cb_class.Text);

            add_student_form.Show();
        }

        private void btn_update_student_Click(object sender, EventArgs e)
        {
            UpdateStudentForm update_student_form = new UpdateStudentForm(cb_college.Text, cb_department.Text, cb_semester.Text, cb_school_year.Text, cb_class.Text);

            update_student_form.Show();
        }

        private void btn_delete_student_Click(object sender, EventArgs e)
        {
            string table_name = "class_" + cb_class.Text;
            DeleteStudentForm delete_student_form = new DeleteStudentForm(table_name);

            delete_student_form.Show();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            DashBoardForm dash_board_form = new DashBoardForm();

            dash_board_form.Show();
            this.Hide();
        }

        private void dgv_classes_lists_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        #region search student from database
        private ArrayList searched_student_name_list = new ArrayList();
        private ArrayList searched_student_total_absents = new ArrayList();
        private ArrayList searched_student_total_presents = new ArrayList();
        private int search_size_list = 0;

        private void btn_search_student_Click(object sender, EventArgs e)
        {
            #region Display searched students in a data grid view
            //string class_code = "class_" + cb_class.Text;
            //SqlConnection conn = new SqlConnection(DBTools.get_connection_string());
            //SqlCommand cmd = new SqlCommand("Select * from " + class_code + " where id_number = @id_number", conn);
            //conn.Open();
            //cmd.Parameters.AddWithValue("id_number", tb_student_id_search.Text);
            //SqlDataAdapter da = new SqlDataAdapter(cmd);
            //DataTable dt = new DataTable();
            //da.Fill(dt);
            //dgv_classes_lists.DataSource = dt;
            #endregion

            string table_name = "class_" + cb_class.Text;
            string id_number = tb_student_id_search.Text;

            generate_searched_student_dynamic_user_control(table_name, id_number);

        }

        private void get_searched_student_from_db(string table_name, string id_number)
        {
            // searched_student_id_list.Clear();
            searched_student_name_list.Clear();
            searched_student_total_presents.Clear();
            searched_student_total_absents.Clear(); //class_test123

            // get_searched_student_from_database(table_name, "id_number", 1);
            get_searched_student_from_database("last_name", table_name, id_number, 1);
            // get_data_from_database(table_name, "last_name", 2);
            //get_data_from_database(table_name, "total_presents", 3);
            //get_data_from_database(table_name, "total_absents", 4);
        }

        private void get_searched_student_from_database(string column_name, string table_name, string id_number, int flag)
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
                                //case 1:
                                //    string column_value1 = reader.GetString(column_index);
                                //    student_id_list.Add(column_value1);
                                //    // MessageBox.Show(column_value);
                                //    search_size_list++;
                                //    break;
                                case 1:
                                    string column_value2 = reader.GetString(column_index);
                                    searched_student_name_list.Add(column_value2);
                                    search_size_list++;
                                    //MessageBox.Show(column_value);
                                    break;
                                    //case 3:
                                    //    //object result = cmd.ExecuteScalar();
                                    //    ////student_total_presents.Add(Convert.ToString(column_value.ToString()));
                                    //    //student_total_presents.Add(result.ToString());
                                    //    // MessageBox.Show(column_value);
                                    //    int int_value = Convert.ToInt32(cmd.ExecuteScalar());
                                    //    string string_value1 = int_value.ToString();
                                    //    student_total_presents.Add(string_value1);
                                    //    break;
                                    //case 4:
                                    //    //student_total_absents.Add(Convert.ToString(column_value.ToString()));
                                    //    //object result2 = cmd.ExecuteScalar();
                                    //    //student_total_absents.Add(result2.ToString());
                                    //    //MessageBox.Show(column_value);
                                    //    int int_value2 = Convert.ToInt32(cmd.ExecuteScalar());
                                    //    string string_value2 = int_value2.ToString();
                                    //    student_total_absents.Add(string_value2);
                                    //    break;
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

        private void generate_searched_student_dynamic_user_control(string table_name, string id_number)
        {
            search_size_list = 0;
            get_searched_student_from_db(table_name, id_number);

            flp_students.Controls.Clear();

            StudentUserControl[] list_items = new StudentUserControl[search_size_list];

            try
            {
                for (int i = 0; i < list_items.Length; i++)
                {
                    // create and story every dynamic user control object to list item array
                    list_items[i] = new StudentUserControl();
                    list_items[i].StudentIDNumber = id_number;
                    list_items[i].StudentName = searched_student_name_list[i].ToString();
                    //list_items[i].StudentTotalPresent = student_total_presents[i].ToString();
                    //list_items[i].StudentTotalAbsent = student_total_absents[i].ToString();

                    // adding newly created dynamic user control to dynamic panel
                    flp_students.Controls.Add(list_items[i]);

                    list_items[i].Click += new System.EventHandler(this.UserControl_Click);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }


        #endregion

        private void StudentForm_Load(object sender, EventArgs e)
        {
            // 2023-06-09 [add date on form load]
            cb_date.Text = DBTools.get_current_date();
            // done

            // 2023-06-10 [add items in cb_class combo-box
            adding_items_in_combo_boxes();
            // done

            btn_better_view_Click(sender, e);
        }

        private void btn_better_view_Click(object sender, EventArgs e)
        {
            if (cb_class.Text != null)
            {
                string table_name = "class_" + cb_class.Text.ToString();
                //generate_dynamic_user_control(table_name);
                generate_dynamic_user_control(table_name);
            }

        }


        #region Function to generate dynamic user controls
        private ArrayList student_id_list = new ArrayList();
        private ArrayList student_name_list = new ArrayList();
        private ArrayList student_total_absents = new ArrayList();
        private ArrayList student_total_presents = new ArrayList();
        private int size_list = 0;
        private void generate_dynamic_user_control(string table_name)
        {
            generated_from_database(table_name);

            flp_students.Controls.Clear();

            StudentUserControl[] list_items = new StudentUserControl[size_list];

            try
            {
                for (int i = 0; i < list_items.Length; i++)
                {
                    // create and story every dynamic user control object to list item array
                    list_items[i] = new StudentUserControl();
                    list_items[i].StudentIDNumber = student_id_list[i].ToString();
                    list_items[i].StudentName = student_name_list[i].ToString();

                    // adding newly created dynamic user control to dynamic panel
                    flp_students.Controls.Add(list_items[i]);

                    list_items[i].Click += new System.EventHandler(this.UserControl_Click);

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
        #endregion

        #region Click Listener on user controls
        private void UserControl_Click(object sender, EventArgs e)
        {
            StudentUserControl obj = (StudentUserControl)sender;

            MessageBox.Show(obj.StudentIDNumber);
        }
        #endregion

        #region Get data from database
        /// <summary>
        /// FIXME: get the name of class here, since each student
        /// is saved on a table named by the class name
        /// </summary>
        private void generated_from_database(string table_name)
        {
            student_id_list.Clear();
            student_name_list.Clear();
            student_total_presents.Clear();
            student_total_absents.Clear();

            get_data_from_database(table_name, "id_number", 1);
            get_data_from_database(table_name, "last_name", 2);
            get_data_from_database(table_name, "total_presents", 3);
            get_data_from_database(table_name, "total_absents", 4);
        }

        private void get_data_from_database(string table_name, string column_name, int flag)
        {
            SqlConnection conn = new SqlConnection(DBTools.get_connection_string());

            #region try one
            try
            {
                conn.Open();

                string query = "SELECT " + column_name + " FROM " + table_name;
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
                                    string column_value1 = reader.GetString(column_index);
                                    student_id_list.Add(column_value1);
                                    size_list++;
                                    break;
                                case 2:
                                    string column_value2 = reader.GetString(column_index);
                                    student_name_list.Add(column_value2);
                                    break;
                                case 3:
                                    int int_value = Convert.ToInt32(cmd.ExecuteScalar());
                                    string string_value1 = int_value.ToString();
                                    student_total_presents.Add(string_value1);
                                    break;
                                case 4:
                                    int int_value2 = Convert.ToInt32(cmd.ExecuteScalar());
                                    string string_value2 = int_value2.ToString();
                                    student_total_absents.Add(string_value2);
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
            catch
            {

            }
            #endregion

        }

        #endregion

        private void btn_check_attendance_Click(object sender, EventArgs e)
        {
            AttendanceForm attendance_form = new AttendanceForm(cb_college.Text, cb_department.Text, cb_semester.Text, cb_school_year.Text, cb_class.Text, cb_date.Text);

            attendance_form.Show();
            Hide();
        }

        private void btn_report_Click(object sender, EventArgs e)
        {
            ReportsForm rf = new ReportsForm(cb_college.Text, cb_department.Text, cb_semester.Text, cb_school_year.Text, cb_class.Text);

            rf.Show();
            Hide();
        }

        // 2023-06-09       11:07 pm
        #region Adding items in combo boxes
        /// <Algorithm>
        /// 1. Get the data in a certain column in db [ex. class_semester]
        /// 2. Store it in an array-list [if same, only accept the first one]
        /// 3. Convert the array-list to a list
        /// 4. Add it to combo-box
        /// </Algorithm>

        #region variables
        private ArrayList class_code_items = new ArrayList();
        private int class_code_items_count;

        #endregion

        private void adding_items_in_combo_boxes()
        {
            string table_name = "classes_table";
            string column_name = "class_code";
            get_data_in_certain_column_from_database_helper(table_name, column_name);

            List<string> class_code_list = new List<string>();

            foreach (var items in class_code_items)
            {
                class_code_list.Add(items.ToString());
                // MessageBox.Show(items.ToString());
            }
            cb_class.Items.Add(class_code_list.ToArray());
        }

        private void get_data_in_certain_column_from_database(string table_name)
        {


        }

        private void get_data_in_certain_column_from_database_helper(string table_name, string column_name)
        {
            class_code_items_count = 0;
            SqlConnection conn = new SqlConnection(DBTools.get_connection_string());

            try
            {
                conn.Open();

                string query = "SELECT " + column_name + " FROM " + table_name;
                SqlCommand cmd = new SqlCommand(query, conn);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        int column_index = reader.GetOrdinal(column_name);
                        while (reader.Read())
                        {
                            string column_value = reader.GetString(column_index);
                            class_code_items.Add(column_value);
                            class_code_items_count++;
                            // MessageBox.Show(column_value);
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
        }

        #endregion


        #region On text change listener on search 2023-06-10
        private void tb_student_id_search_TextChanged(object sender, EventArgs e)
        {
            // 2023-06-10

            string table_name = "class_" + cb_class.Text;
            string id_number = tb_student_id_search.Text;
            //if (id_number.Length == 8)
            generate_searched_student_dynamic_user_control_otc(table_name, id_number);
            if (id_number == "")
                btn_better_view_Click(sender, e);
        }

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

                flp_students.Controls.Clear();

                StudentUserControl student = new StudentUserControl();

                student.StudentIDNumber = id_number;
                student.StudentName = searched_student_name_list_otc[0].ToString();

                // adding newly created dynamic user control to dynamic panel
                flp_students.Controls.Add(student);

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
        #endregion


        #region Show students with 20% absents already!
        private void show_students_with_20_percent_absents()
        {
            AttendanceTools.select_all_that_have_20_percent_absent_from_database(cb_class.Text);
        }
        #endregion

        private void flp_students_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cb_date_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void cb_school_year_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void cb_semester_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void cb_department_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void cb_college_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void cb_class_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lbl_student_id_search_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void StudentForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            DashBoardForm df = new DashBoardForm();

            df.Show();
            Hide();
        }
    }
}
