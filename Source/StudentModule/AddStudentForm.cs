using StudentAttendanceManagementSystem.Tools;
using System;
using System.Collections;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace StudentAttendanceManagementSystem.DashBoardModule
{
    public partial class AddStudentForm : Form
    {
        public AddStudentForm()
        {
            InitializeComponent();
        }

        // constructor for passing data
        public AddStudentForm(string college, string department, string semester, string school_year, string class_enrolled)
        {
            InitializeComponent();

            cb_class.Text = class_enrolled;
            cb_college.Text = college;
            cb_department.Text = department;
            cb_semester.Text = semester;
            cb_school_year.Text = school_year;
        }


        private void AddStudentForm_Load(object sender, EventArgs e)
        {

        }

        private void btn_finish_Click(object sender, EventArgs e)
        {
            if (tb_id_number.Text != "" && tb_first_name.Text != "" && tb_last_name.Text != "" && tb_address.Text != "" &&
                tb_contact_number.Text != "" && tb_email.Text != "" && tb_name_of_guardian.Text != "")
            {
                if (!(is_student_exist_in_class_database()))
                {
                    try
                    {
                        string status = "GOOD"; // default status for every students in database
                        string table_name = "class_" + cb_class.Text;//tb_subject_code_add.Text.Replace("-", "_") + "_" + tb_subject_name_add.Text + "_" + cb_semester_add.Text + "_" + tb_school_year_add.Text.Replace("-", "_");

                        //This is my connection string i have assigned the database file address path
                        // string MyConnection2 = "Data Source=LAPTOP-T2HJFRJU\\SQLEXPRESS;Initial Catalog=StudentAttendanceManagementSystemDB;Integrated Security=True";
                        //This is my insert query in which i am taking input from the user through windows forms
                        string Query = "insert into " + table_name + " (id_number, last_name, first_name, address, contact_number, email, name_of_guardian, college, department, semester, school_year, class_enrolled, total_presents, total_absents, status) values" + "('" +
                            tb_id_number.Text + "','" +
                            tb_last_name.Text + "','" +
                            tb_first_name.Text + "','" +
                            tb_address.Text + "','" +
                            tb_contact_number.Text + "','" +
                            tb_email.Text + "','" +
                            tb_name_of_guardian.Text + "','" +
                            cb_college.Text + "','" +
                            cb_department.Text + "','" +
                            cb_semester.Text + "','" +
                            cb_school_year.Text + "','" +
                            cb_class.Text + "', '0', '0', '" + status + "');";
                        //This is  MySqlConnection here i have created the object and pass my connection string.
                        SqlConnection MyConn2 = new SqlConnection(DBTools.get_connection_string());
                        //This is command class which will handle the query and connection object.
                        SqlCommand MyCommand2 = new SqlCommand(Query, MyConn2);
                        SqlDataReader MyReader2;
                        MyConn2.Open();
                        MyReader2 = MyCommand2.ExecuteReader();     // Here our query will be executed and data saved into the database.
                        MessageBox.Show("'" + tb_id_number.Text + "' saved successfully!");

                        while (MyReader2.Read())
                        {
                        }
                        MyConn2.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Student already exists in database!", "Failed!");
                }
            }
            else
            {
                add_student_error();
            }
            Hide();
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

        private void add_student_error()
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

            MessageBox.Show(empty_fields, "Adding student failed!");
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
