using StudentAttendanceManagementSystem.Tools;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace StudentAttendanceManagementSystem.AttendanceModule
{
    public partial class DeleteAttendanceForm : Form
    {
        public DeleteAttendanceForm()
        {
            InitializeComponent();
        }

        // for passing data from attendance form
        public DeleteAttendanceForm(string table_name, string column_name)
        {
            InitializeComponent();

            cb_class.Text = table_name;
            cb_date.Text = column_name;
        }

        private string get_date_in_datetime_picker_del()
        {
            DateTime selected_date = dateTimePicker1.Value;
            //DateTime selectedDate = dateTimePicker1.Value;
            string formatted_date = selected_date.ToString("yyyy_MM_dd");

            Console.WriteLine("Date from date-time picker: " + formatted_date);
            return formatted_date;
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (DBTools.is_column_exists_in_table_database("class_" + cb_class.Text, "attendance_" + get_date_in_datetime_picker_del()))
            {
                if (cb_class.Text != "" && cb_date.Text != "")
                {

                    string table_name = "class_" + cb_class.Text;
                    string column_name = "attendance_" + cb_date.Text;
                    // query to delete a column [i.e. attendance]
                    string query = "alter table " + table_name + " drop column " + column_name;

                    try
                    {
                        // added 2023-06-05 -> 8:23pm
                        delete_one_from_presents(table_name, column_name);
                        delete_one_from_absents(table_name, column_name);

                        // AttendanceTools.delete_one_from_total_meet_count("classes_table", table_name);
                        //MessageBox.Show("Delete one meet count from: '" + table_name + "'");

                        SqlConnection conn = new SqlConnection(DBTools.get_connection_string());
                        SqlCommand cmd = new SqlCommand(query, conn);

                        conn.Open();
                        cmd.ExecuteNonQuery();
                        conn.Close();
                        //// added 2023-06-05 -> 8:23pm
                        //delete_one_from_presents(table_name, column_name);
                        //delete_one_from_absents(table_name, column_name);

                        //AttendanceTools.delete_one_from_total_meet_count("classes_table", table_name);
                        delete_one_from_class_total_meets();
                        MessageBox.Show("Attendance '" + cb_date.Text + "' Deleted successfully!");

                        // Opens delete attendance form
                        //AttendanceForm af = new AttendanceForm();

                        //af.Show();
                        Hide();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
                else
                {
                    if (cb_class.Text == "" && cb_date.Text != "")
                    {
                        MessageBox.Show("Class code cannot be empty!", "Deleting attendance failed!");
                    }
                    else if (cb_class.Text != "" && cb_date.Text == "")
                    {
                        MessageBox.Show("Date cannot be empty!", "Deleting attendance failed!");
                    }
                    else
                    {
                        MessageBox.Show("Class code and Date cannot be empty!", "Deleting attendance failed!");
                    }
                }
            }
            else
            {
                MessageBox.Show("No attendance is recorded on the given date.", "Failed");
            }
        }

        private void delete_one_from_class_total_meets()
        {
            string class_code = cb_class.Text;

            Console.WriteLine("Deleting one from class total meets");
            try
            {
                string query = "update classes_table set total_meets = total_meets - 1 where class_code like '" + class_code + "';";
                SqlConnection conn = new SqlConnection(DBTools.get_connection_string());
                SqlCommand cmd = new SqlCommand(query, conn);

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            Console.WriteLine("Done...");
        }

        #region Process in deleting a column [i.e. attendance]
        private void delete_one_from_presents(string table_name, string column_name)
        {
            string query = "update " + table_name + " set total_presents = total_presents - 1 where " + column_name + " = 'Present';";

            try
            {
                SqlConnection conn = new SqlConnection(DBTools.get_connection_string());
                SqlCommand cmd = new SqlCommand(query, conn);

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Present count of class: '" + table_name + "' updated successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void delete_one_from_absents(string table_name, string column_name)
        {
            string query = "update " + table_name + " set total_absents = total_absents - 1 where " + column_name + " = 'Absent';";

            try
            {
                SqlConnection conn = new SqlConnection(DBTools.get_connection_string());
                SqlCommand cmd = new SqlCommand(query, conn);

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Absents count of class: '" + table_name + "' updated successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        #endregion

        private void DeleteAttendanceForm_Load(object sender, EventArgs e)
        {

        }
    }
}
