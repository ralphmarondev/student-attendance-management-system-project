using StudentAttendanceManagementSystem.Tools;
using System;
using System.Collections;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace StudentAttendanceManagementSystem.ClassModule
{
    public partial class UpdateClassForm : Form
    {
        private string initial_class_code; // will get this on search button click
        public UpdateClassForm()
        {
            InitializeComponent();
        }

        private void btn_finish_add_Click(object sender, EventArgs e)
        {
            if (DBTools.is_record_exist_in_database("classes_table", "class_code", tb_subject_code.Text))
            {
                string subject_code = tb_subject_code.Text;
                string subject_name = tb_subject_name.Text;
                string semester = cb_semester.Text;
                string school_year = tb_school_year.Text;
                string department = tb_department.Text;
                string college = tb_college.Text;

                ArrayList names = new ArrayList();
                names.Clear();
                string empty_fields = "Empty Fields:\n\n";
                if (subject_code != "" && subject_name != "" && semester != "" &&
                    school_year != "" && department != "" && college != "")
                {
                    Console.WriteLine("Initial subject code: " + initial_class_code);
                    if (subject_code == initial_class_code)
                    {
                        try
                        {
                            SqlConnection conn = new SqlConnection(DBTools.get_connection_string());
                            SqlCommand cmd = new SqlCommand("UPDATE classes_table SET class_name = @class_name, class_semester = @class_semester, class_school_year = @class_school_year, class_department = @class_department, class_college = @class_college WHERE class_code = @class_code", conn);

                            cmd.Parameters.AddWithValue("@class_code", tb_subject_code.Text);
                            cmd.Parameters.AddWithValue("@class_name", tb_subject_name.Text);
                            cmd.Parameters.AddWithValue("@class_semester", cb_semester.Text);
                            cmd.Parameters.AddWithValue("@class_school_year", tb_school_year.Text);
                            cmd.Parameters.AddWithValue("@class_department", tb_department.Text);
                            cmd.Parameters.AddWithValue("@class_college", tb_college.Text);

                            conn.Open();
                            cmd.ExecuteNonQuery();
                            conn.Close();
                            MessageBox.Show("Updated Successfully!");
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Class doesn't exist!", "Updating class failed!");
                    }
                }
                else
                {
                    if (subject_code == "")
                    {
                        names.Add("Subject Code");
                    }
                    if (subject_name == "")
                    {
                        names.Add("Subject Name");
                    }
                    if (semester == "")
                    {
                        names.Add("Semester");
                    }
                    if (school_year == "")
                    {
                        names.Add("School Year");
                    }
                    if (department == "")
                    {
                        names.Add("Department");
                    }
                    if (college == "")
                    {
                        names.Add("College");
                    }

                    foreach (var items in names)
                    {
                        empty_fields = empty_fields + items.ToString() + "\n";
                    }

                    MessageBox.Show(empty_fields, "Updating class failed!");
                }
            }
            else
            {
                MessageBox.Show("Class doesn't exist in database.", "Failed!");
            }
            this.Hide();
        }

        private void UpdateClassForm_Load(object sender, EventArgs e)
        {

        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Getting data in database...");
            if (tb_subject_code.Text != "")
            {
                try
                {
                    get_data_in_certain_column_from_database();
                    tb_subject_name.Text = subject_name[0].ToString();
                    tb_college.Text = subject_college[0].ToString();
                    tb_department.Text = subject_college[0].ToString();
                    cb_semester.Text = subject_semester[0].ToString();
                    tb_school_year.Text = subject_school_year[0].ToString();

                    initial_class_code = tb_subject_code.Text;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Subject Code is empty!", "Auto-fill failed!");
            }
            Console.WriteLine("Done...");
        }

        #region Get all data of a class for auto-fill
        /// <date-2023-06-10>
        /// 
        /// </date-2023-06-10>
        private ArrayList subject_name = new ArrayList();
        private ArrayList subject_semester = new ArrayList();
        private ArrayList subject_college = new ArrayList();
        private ArrayList subject_department = new ArrayList();
        private ArrayList subject_school_year = new ArrayList();

        private void get_data_in_certain_column_from_database()
        {
            string table_name = "classes_table";
            string subject_code = tb_subject_code.Text;

            get_data_in_certain_column_from_database_helper(table_name, "class_name", subject_code, 1);
            get_data_in_certain_column_from_database_helper(table_name, "class_semester", subject_code, 2);
            get_data_in_certain_column_from_database_helper(table_name, "class_college", subject_code, 3);
            get_data_in_certain_column_from_database_helper(table_name, "class_department", subject_code, 4);
            get_data_in_certain_column_from_database_helper(table_name, "class_school_year", subject_code, 5);


        }


        private void get_data_in_certain_column_from_database_helper(string table_name, string column_name, string subject_code, int flag)
        {
            SqlConnection conn = new SqlConnection(DBTools.get_connection_string());

            try
            {
                conn.Open();

                string query = "SELECT " + column_name + " FROM " + table_name + " WHERE class_code = '" + subject_code + "';";
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
                                    subject_name.Add(column_value1);
                                    Console.WriteLine(column_value1);
                                    break;
                                case 2:
                                    string column_value2 = reader.GetString(column_index);
                                    subject_semester.Add(column_value2);
                                    Console.WriteLine(column_value2);
                                    break;
                                case 3:
                                    string column_value3 = reader.GetString(column_index);
                                    subject_college.Add(column_value3);
                                    Console.WriteLine(column_value3);
                                    break;
                                case 4:
                                    string column_value4 = reader.GetString(column_index);
                                    subject_department.Add(column_value4);
                                    Console.WriteLine(column_value4);
                                    break;
                                case 5:
                                    string column_value5 = reader.GetString(column_index);
                                    subject_school_year.Add(column_value5);
                                    Console.WriteLine(column_value5);
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
        }

        #endregion

    }
}
