using StudentAttendanceManagementSystem.Tools;
using System;
using System.Collections;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace StudentAttendanceManagementSystem.StudentModule
{
    public partial class UpdateStudentForm : Form
    {
        public UpdateStudentForm()
        {
            InitializeComponent();
        }

        // constructor for passing data
        public UpdateStudentForm(string college, string department, string semester, string school_year, string class_enrolled)
        {
            InitializeComponent();

            cb_class.Text = class_enrolled;
            cb_college.Text = college;
            cb_department.Text = department;
            cb_semester.Text = semester;
            cb_school_year.Text = school_year;
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(DBTools.get_connection_string());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            this.Hide();
        }

        private void btn_finish_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Updating student...");
            if (tb_id_number.Text != "" && tb_first_name.Text != "" && tb_last_name.Text != "" && tb_address.Text != "" &&
                tb_contact_number.Text != "" && tb_email.Text != "" && tb_name_of_guardian.Text != "")
            {
                if (is_student_exist_in_class_database())
                {
                    try
                    {
                        Console.WriteLine("Opening connection...");
                        //string connection_string = "Data Source=LAPTOP-T2HJFRJU\\SQLEXPRESS;Initial Catalog=StudentAttendanceManagementSystemDB;Integrated Security=True";
                        SqlConnection conn = new SqlConnection(DBTools.get_connection_string());
                        // id_number, last_name, first_name, address, contact_number, email, name_of_guardian,
                        // college, department, semester, school_year, class_enrolled, total_presents, total_absents
                        SqlCommand cmd = new SqlCommand("UPDATE class_" + cb_class.Text + " SET last_name = @last_name, first_name = @first_name, " +
                            "address = @address, contact_number = @contact_number, email = @email, " +
                            "name_of_guardian = @name_of_guardian, " +
                            "college = @college, " +
                            "department = @department, " +
                            "semester = @semester, " +
                            "class_enrolled = @class_enrolled " +
                            "WHERE id_number = @id_number", conn);

                        cmd.Parameters.AddWithValue("@id_number", tb_id_number.Text);
                        cmd.Parameters.AddWithValue("@last_name", tb_last_name.Text);
                        cmd.Parameters.AddWithValue("@first_name", tb_first_name.Text);
                        cmd.Parameters.AddWithValue("@address", tb_address.Text);
                        cmd.Parameters.AddWithValue("@contact_number", tb_contact_number.Text);
                        cmd.Parameters.AddWithValue("@email", tb_email.Text);
                        cmd.Parameters.AddWithValue("@name_of_guardian", tb_name_of_guardian.Text);
                        cmd.Parameters.AddWithValue("@college", cb_college.Text);
                        cmd.Parameters.AddWithValue("@department", cb_department.Text);
                        cmd.Parameters.AddWithValue("@semester", cb_semester.Text);
                        cmd.Parameters.AddWithValue("@class_enrolled", cb_class.Text);

                        conn.Open();
                        Console.WriteLine("Executing query...");
                        cmd.ExecuteNonQuery();
                        Console.WriteLine("Done...");

                        Console.WriteLine("Closing connection...");
                        conn.Close();
                        Console.WriteLine("Done...");
                        MessageBox.Show(tb_id_number.Text + " information Updated Successfully!");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        Console.WriteLine("Error: " + ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("There is no such student in database.", "Failed!");
                }
            }
            else
            {
                update_student_error();
            }
            Console.WriteLine("Done...");
            this.Hide();
        }


        private bool is_student_exist_in_class_database()
        {
            string table_name = "class_" + cb_class.Text;
            // Create the MySqlConnection object
            using (SqlConnection connection = new SqlConnection(DBTools.get_connection_string()))
            {
                try
                {
                    connection.Open();

                    // Prepare the SQL query
                    string query = "SELECT COUNT(*) FROM " + table_name + " WHERE id_number = @value"; // Replace with your table and column names
                    SqlCommand command = new SqlCommand(query, connection);

                    // Set the parameter value
                    command.Parameters.AddWithValue("@value", tb_id_number.Text); // Replace with the value you want to search

                    // Execute the query and get the result
                    int count = Convert.ToInt32(command.ExecuteScalar());

                    // Check if the record exists
                    if (count > 0)
                    {
                        Console.WriteLine("The record already exists in the database.");
                        return true;
                    }
                    else
                    {
                        // Add the record to the database
                        // ...
                        Console.WriteLine("The record does not exist in the database and can be added.");
                        return false;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("An error occurred: " + ex.Message);
                }
                return false;
            }
        }


        private void update_student_error()
        {
            string id_number = tb_id_number.Text;
            string first_name = tb_first_name.Text;
            string last_name = tb_last_name.Text;
            string address = tb_address.Text;
            string email = tb_email.Text;
            string contact_number = tb_contact_number.Text;
            string name_of_guardian = tb_name_of_guardian.Text;

            ArrayList names = new ArrayList();
            names.Clear();
            string empty_fields = "Empty Fields:\n\n";


            if (id_number == "")
            {
                names.Add("ID Number");
            }
            if (first_name == "")
            {
                names.Add("First Name");
            }
            if (last_name == "")
            {
                names.Add("Last Name");
            }
            if (address == "")
            {
                names.Add("Address");
            }
            if (email == "")
            {
                names.Add("Email");
            }
            if (contact_number == "")
            {
                names.Add("Contact Number");
            }
            if (name_of_guardian == "")
            {
                names.Add("Name of Guardian");
            }

            foreach (var items in names)
            {
                empty_fields = empty_fields + items.ToString() + "\n";
            }

            MessageBox.Show(empty_fields, "Updating student failed!");
        }


        private void UpdateStudentForm_Load(object sender, EventArgs e)
        {

        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            get_data_in_certain_column_from_database();

            tb_first_name.Text = first_name[0].ToString();
            tb_last_name.Text = last_name[0].ToString();
            tb_address.Text = address[0].ToString();
            tb_email.Text = email[0].ToString();
            tb_contact_number.Text = contact_number[0].ToString();
            tb_name_of_guardian.Text = name_of_guardian[0].ToString();

        }


        #region Get all data of a class for auto-fill
        /// <date-2023-06-10>
        /// 
        /// </date-2023-06-10>
        private ArrayList first_name = new ArrayList();
        private ArrayList last_name = new ArrayList();
        private ArrayList address = new ArrayList();
        private ArrayList email = new ArrayList();
        private ArrayList contact_number = new ArrayList();
        private ArrayList name_of_guardian = new ArrayList();

        private void get_data_in_certain_column_from_database()
        {
            string table_name = "class_" + cb_class.Text;
            string student_id = tb_id_number.Text;

            get_data_in_certain_column_from_database_helper(table_name, "first_name", student_id, 1);
            get_data_in_certain_column_from_database_helper(table_name, "last_name", student_id, 2);
            get_data_in_certain_column_from_database_helper(table_name, "address", student_id, 3);
            get_data_in_certain_column_from_database_helper(table_name, "email", student_id, 4);
            get_data_in_certain_column_from_database_helper(table_name, "contact_number", student_id, 5);
            get_data_in_certain_column_from_database_helper(table_name, "name_of_guardian", student_id, 6);

        }


        private void get_data_in_certain_column_from_database_helper(string table_name, string column_name, string id_number, int flag)
        {
            SqlConnection conn = new SqlConnection(DBTools.get_connection_string());

            try
            {
                conn.Open();

                string query = "SELECT " + column_name + " FROM " + table_name + " WHERE id_number = '" + id_number + "';";
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
                                    first_name.Add(column_value1);
                                    Console.WriteLine(column_value1);
                                    break;
                                case 2:
                                    string column_value2 = reader.GetString(column_index);
                                    last_name.Add(column_value2);
                                    Console.WriteLine(column_value2);
                                    break;
                                case 3:
                                    string column_value3 = reader.GetString(column_index);
                                    address.Add(column_value3);
                                    Console.WriteLine(column_value3);
                                    break;
                                case 4:
                                    string column_value4 = reader.GetString(column_index);
                                    email.Add(column_value4);
                                    Console.WriteLine(column_value4);
                                    break;
                                case 5:
                                    string column_value5 = reader.GetString(column_index);
                                    contact_number.Add(column_value5);
                                    Console.WriteLine(column_value5);
                                    break;
                                case 6:
                                    string column_value6 = reader.GetString(column_index);
                                    name_of_guardian.Add(column_value6);
                                    Console.WriteLine(column_value6);
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
