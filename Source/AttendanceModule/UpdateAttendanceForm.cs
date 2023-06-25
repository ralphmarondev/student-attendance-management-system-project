using StudentAttendanceManagementSystem.DashBoardModule;
using StudentAttendanceManagementSystem.Tools;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace StudentAttendanceManagementSystem.AttendanceModule
{
    public partial class UpdateAttendanceForm : Form
    {
        #region global variables
        // temporarily store presents and absents
        private ArrayList presents = new ArrayList();
        private ArrayList absents = new ArrayList();

        // final variable to store presents and absents
        private ArrayList final_present = new ArrayList();
        private ArrayList final_absent = new ArrayList();

        // store all the last names from database
        private ArrayList last_names = new ArrayList();
        #endregion

        public UpdateAttendanceForm()
        {
            InitializeComponent();
        }

        // constructor for passing data
        public UpdateAttendanceForm(string college, string department, string semester, string school_year, string class_enrolled, string date)
        {
            InitializeComponent();

            cb_class.Text = class_enrolled;
            cb_college.Text = college;
            cb_department.Text = department;
            cb_semester.Text = semester;
            cb_school_year.Text = school_year;
            cb_date.Text = date;
        }

        private string get_date_in_datetime_picker()
        {
            DateTime selected_date = dateTimePicker1.Value;
            //DateTime selectedDate = dateTimePicker1.Value;
            string formatted_date = selected_date.ToString("yyyy_MM_dd");

            Console.WriteLine("Date from date-time picker: " + formatted_date);
            return formatted_date;
        }

        #region Update attendance on the date given
        private void btn_update_Click(object sender, System.EventArgs e)
        {
            cb_date.Text = get_date_in_datetime_picker();
            // update_attendace_form();
            old_btn_update_click();
        }

        private void old_btn_update_click()
        {
            if (DBTools.is_column_exists_in_table_database("class_" + cb_class.Text, "attendance_" + cb_date.Text))
            {
                string table_name = "class_" + cb_class.Text;
                string column_name = "attendance_" + cb_date.Text;

                try
                {
                    Console.WriteLine("Validating students...");
                    validate_student(table_name, column_name);
                    Console.WriteLine("Done...");

                    #region Subtracting 1 from absent and present whatever is the status
                    Console.WriteLine("Subtracting 1 from total_presents...");
                    subract_one_from_total_presents(table_name, column_name);
                    Console.WriteLine("Done...");

                    Console.WriteLine("Subtracting 1 from total_absents...");
                    subtract_one_from_total_absents(table_name, column_name);
                    Console.WriteLine("Done...");
                    #endregion

                    Console.WriteLine("Inserting absents in array list...");
                    #region Inserting absents
                    List<string> myRecordIds_absent = new List<string>();
                    foreach (var items in final_absent)
                    {
                        myRecordIds_absent.Add(items.ToString());
                    }
                    Console.WriteLine("Done...");

                    // setting all the fields to present initially
                    Console.WriteLine("Inserting present in all fields...");
                    InsertSameValueInAllRecords("Present", table_name, column_name);
                    Console.WriteLine("Done...");

                    // updating absent in the database
                    Console.WriteLine("Updating absents...");
                    string myValue_absent = "Absent";

                    InsertSameValueInRecords(myRecordIds_absent, myValue_absent, table_name, column_name, "last_name");

                    #endregion
                    Console.WriteLine("Done...");

                    Console.WriteLine("Updating total absent and present...");
                    #region Adding 1 from absent and present whatever the status is
                    AttendanceTools.update_absent(table_name, column_name);
                    AttendanceTools.update_present(table_name, column_name);
                    //add_one_from_total_absents(table_name, column_name);
                    //add_one_from_total_presents(table_name, column_name);
                    Console.WriteLine("Done...");

                    Console.WriteLine("Updating status in database...");
                    update_status_in_database();
                    Console.WriteLine("Done...");
                    #endregion
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                    // MessageBox.Show("Error: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("No attendance is recorded on the given date.", "Failed");
            }
        }
        #endregion

        private void validate_student(string table_name, string column_name)
        {
            Console.WriteLine("Clearing final absents...");
            final_absent.Clear();
            Console.WriteLine("Done...");

            //get_all_absents_in_database(table_name, column_name);
            //string myValue = "Present";

            //InsertSameValueInAllRecords(myValue, table_name, column_name);

            Console.WriteLine("Iterating on absents...");
            foreach (var items in absents)
            {
                foreach (var items2 in last_names)
                {
                    if ((items.ToString() == items2.ToString()) && !(final_absent.Contains(items.ToString())))
                    {
                        final_absent.Add(items);
                        MessageBox.Show(items.ToString(), "Absent");
                    }
                }
            }
            Console.WriteLine("Done...");

            Console.WriteLine("Adding new absents in final absents...");
            foreach (var items in final_absent)
            {
                foreach (var items2 in inital_absents)
                {
                    if (!(final_absent.Contains(items2.ToString())))
                    {
                        final_absent.Add(items);
                        MessageBox.Show(items.ToString(), "Absent");
                    }
                }
            }
            Console.WriteLine("Done...");

            Console.WriteLine("Clearing absents...");
            absents.Clear();
            Console.WriteLine("Done...");
        }


        #region Inserting the same value in all of the rows in a column
        private void InsertSameValueInAllRecords(string value, string table_name, string column_name)
        {
            SqlConnection connection = new SqlConnection(DBTools.get_connection_string());

            try
            {
                connection.Open();

                string query = "UPDATE " + table_name + " SET " + column_name + " = @value;";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@value", value);
                command.ExecuteNonQuery();

                Console.WriteLine("Value inserted in all records successfully!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error inserting value in records: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }
        #endregion


        #region insert the same values in different records using their ids
        private void InsertSameValueInRecords(List<string> recordIds, string value, string table_name, string column_name, string column_name_to_be_updated)
        {
            SqlConnection connection = new SqlConnection(DBTools.get_connection_string());

            try
            {
                connection.Open();

                string query = "UPDATE " + table_name + " SET " + column_name + " = @value WHERE " + column_name_to_be_updated + " = @id;";
                SqlCommand command = new SqlCommand(query, connection);

                foreach (var id in recordIds)
                {
                    command.Parameters.Clear();
                    command.Parameters.AddWithValue("@value", value);
                    command.Parameters.AddWithValue("@id", id);
                    //DBTools.IncrementAndInsert(table_name, column_name, id);
                    command.ExecuteNonQuery();
                }

                Console.WriteLine("Value inserted in records successfully!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error inserting value in records: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }
        #endregion


        #region Get all the initial absents
        private ArrayList inital_absents = new ArrayList();
        private void get_all_absents_in_database(string table_name, string column_name)
        {
            string date_of_attendance = column_name;
            SqlConnection conn = new SqlConnection(DBTools.get_connection_string());

            try
            {
                Console.WriteLine("Getting all absents in database");
                conn.Open();

                string query = "SELECT last_name FROM " + table_name.ToString() + " WHERE " + date_of_attendance + " like 'Absent';";
                SqlCommand cmd = new SqlCommand(query, conn);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        int column_index = reader.GetOrdinal("last_name");
                        while (reader.Read())
                        {
                            string column_value = reader.GetString(column_index);
                            inital_absents.Add(column_value);
                            absents.Add(column_value);
                            Console.WriteLine(column_value);
                        }
                    }
                    else
                    {
                        MessageBox.Show("No data found!");
                    }
                }
                Console.WriteLine("Done...");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
        #endregion


        #region Subtract 1 from total absents
        private void subtract_one_from_total_absents(string table_name, string column_name)
        {
            /// TODO: implement this!
            string date_of_attendance = column_name;
            try
            {
                string querry = "UPDATE " + table_name + " SET total_absents =  total_absents - 1 WHERE " + date_of_attendance + " like 'Absent'";

                SqlConnection connection = new SqlConnection(DBTools.get_connection_string());
                SqlCommand cmd = new SqlCommand(querry, connection);

                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Absent count Updated Successfully!");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                MessageBox.Show("Done");
            }
        }

        #endregion

        #region add 1 from total absents
        private void add_one_from_total_absents(string table_name, string column_name)
        {
            /// TODO: implement this!
            string date_of_attendance = column_name;
            try
            {
                string querry = "UPDATE " + table_name + " SET total_absents =  total_absents + 1 WHERE " + date_of_attendance + " like 'Absent'";

                SqlConnection connection = new SqlConnection(DBTools.get_connection_string());
                SqlCommand cmd = new SqlCommand(querry, connection);

                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Absent count Updated Successfully!");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                MessageBox.Show("Done");
            }
        }

        #endregion


        #region Subtract 1 from total presents
        private void subract_one_from_total_presents(string table_name, string column_name)
        {
            string date_of_attendance = column_name;
            /// TODO: implement this!
            try
            {
                string querry = "UPDATE " + table_name + " SET total_presents =  total_presents - 1 WHERE " + date_of_attendance + " like 'Present'";

                SqlConnection connection = new SqlConnection(DBTools.get_connection_string());
                SqlCommand cmd = new SqlCommand(querry, connection);

                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Present count Updated Successfully!");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                MessageBox.Show("Done");
            }

        }
        #endregion


        #region add 1 from total presents
        private void add_one_from_total_presents(string table_name, string column_name)
        {
            string date_of_attendance = column_name;
            /// TODO: implement this!
            try
            {
                string querry = "UPDATE " + table_name + " SET total_presents =  total_presents + 1 WHERE " + date_of_attendance + " like 'Present'";

                SqlConnection connection = new SqlConnection(DBTools.get_connection_string());
                SqlCommand cmd = new SqlCommand(querry, connection);

                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Present count Updated Successfully!");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                MessageBox.Show("Done");
            }

        }
        #endregion



        #region Get all last names in the class
        private void get_all_last_names_in_database(string table_name)
        {
            SqlConnection conn = new SqlConnection(DBTools.get_connection_string());

            try
            {
                conn.Open();

                string query = "SELECT last_name FROM " + table_name.ToString();
                SqlCommand cmd = new SqlCommand(query, conn);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        int column_index = reader.GetOrdinal("last_name");
                        while (reader.Read())
                        {
                            string column_value = reader.GetString(column_index);
                            last_names.Add(column_value);
                            MessageBox.Show(column_value);
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
                Console.WriteLine("Me when I'm falling...");
            }
        }
        #endregion


        #region Generating buttons programatically
        private void btn_refresh_Click(object sender, EventArgs e)
        {
            //string current_date = DBTools.get_current_date();
            //cb_date.Text = "attendance_" + current_date;
            string table_name = "class_" + cb_class.Text;
            string column_name = "attendance_" + cb_date.Text; //.Replace("-", "_");

            get_all_absents_in_database(table_name, column_name);
            #region Remove all of the items in the array-lists if there is any
            absents.Clear();
            presents.Clear();
            final_absent.Clear();
            #endregion

            buttons_panel.Controls.Clear();
            last_names.Clear();

            SqlConnection conn = new SqlConnection(DBTools.get_connection_string());
            // string table_name = "class_" + cb_class.Text;
            //table_name = "class_test123";
            try
            {
                conn.Open();

                string query = "SELECT last_name FROM " + table_name.ToString();
                SqlCommand cmd = new SqlCommand(query, conn);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        int column_index = reader.GetOrdinal("last_name");
                        int i = 0;
                        while (reader.Read())
                        {
                            string column_value = reader.GetString(column_index);
                            last_names.Add(column_value);
                            //MessageBox.Show(column_value);
                            //Button btn = new Button();

                            //btn.Name = last_names[i].ToString();
                            //btn.Text = last_names[i].ToString();
                            //btn.Size = new Size(145, 52);
                            //btn.BackColor = Color.White;

                            //foreach (var items in inital_absents)
                            //{
                            //    if (btn.Name == items.ToString())
                            //    {
                            //        btn.BackColor = Color.Red;
                            //        absents.Add(btn.Name);
                            //        break;
                            //    }
                            //}


                            //flowLayoutPanel1.Controls.Add(btn);

                            //btn.Click += new EventHandler(this.on_btn_click);
                            //i++;
                        }
                    }
                    else
                    {
                        MessageBox.Show("No data found!");
                    }
                }

                last_names.Sort();

                #region generating button programatically with row and column
                int row = int.Parse(cb_default_row.Text);
                int col = int.Parse(cb_default_column.Text);// 8;
                int c = 0;

                int buttonWidth = 145;// 80;
                int buttonHeight = 52; // 30;
                int spacing = 5; // 10;

                int startX = 30; // (ClientSize.Width - (col * buttonWidth + (col - 1) * spacing)) / 2;
                int startY = 30; // (ClientSize.Height - (row * buttonHeight + (row - 1) * spacing)) / 2;

                for (int i = 0; i < row; i++)
                {
                    for (int j = 0; j < col; j++)
                    {
                        Button button = new Button();
                        button.Size = new Size(buttonWidth, buttonHeight);
                        button.Location = new Point(startX + j * (buttonWidth + spacing),
                                                    startY + i * (buttonHeight + spacing));
                        button.Text += last_names[c].ToString();
                        button.Name += last_names[c].ToString();
                        button.BackColor = Color.White;

                        foreach (var items in inital_absents)
                        {
                            if (button.Name == items.ToString())
                            {
                                button.BackColor = Color.Red;
                                absents.Add(button.Name);
                                break;
                            }
                        }

                        //button.Text = $"Button {i}-{j}";
                        button.Click += on_btn_click;

                        buttons_panel.Controls.Add(button);
                        c++;
                    }
                }
                #endregion

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
        #endregion


        #region Initial validation if present or absent
        void on_btn_click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn.BackColor == Color.Red)
            {
                btn.BackColor = Color.White;
                absents.Remove(btn.Text);
            }
            else
            {
                btn.BackColor = Color.Red;
                absents.Add(btn.Text);
            }

        }
        #endregion

        private void UpdateAttendanceForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            AttendanceForm af = new AttendanceForm(cb_college.Text, cb_department.Text, cb_semester.Text, cb_school_year.Text, cb_class.Text, cb_date.Text);

            af.Show();
            Hide();
        }

        private void btn_refresh_Click_1(object sender, EventArgs e)
        {
            btn_refresh_Click(sender, e);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void UpdateAttendanceForm_Load(object sender, EventArgs e)
        {
            btn_refresh_Click(sender, e);
        }

        private void btn_view_Click(object sender, EventArgs e)
        {
            #region try two
            // loop in present array list
            foreach (var items in presents)
            {
                //MessageBox.Show(items.ToString(), "Presents");

                // if the text in present is also in the last_names array-list
                // then we are going to append it to final_presents array-list
                foreach (var ls in last_names)
                {
                    if (ls.ToString() == items.ToString())
                    {
                        final_present.Add(items);
                    }
                }
            }

            //foreach (var items in final_present)
            //{
            //    MessageBox.Show(items.ToString(), "Presents");
            //}

            // loop in absents array list
            foreach (var items in absents)
            {
                //MessageBox.Show(items.ToString(), "Absents");

                // if the text in present is also in the last_names array-list
                // then we are going to append it to final_absents array-list
                foreach (var ls in last_names)
                {
                    if (ls.ToString() == items.ToString())
                    {
                        foreach (var ls2 in final_present)
                        {
                            if (ls2.ToString() != items.ToString())
                            {
                                final_absent.Add(items);
                            }
                            else
                            {
                                final_absent.Remove(items);
                            }
                        }
                    }
                }
            }

            foreach (var items in presents)
            {
                //MessageBox.Show(items.ToString(), "Absents");

                // if the text in present is also in the last_names array-list
                // then we are going to append it to final_absents array-list
                foreach (var ls in last_names)
                {
                    if (ls.ToString() == items.ToString())
                    {
                        try
                        {
                            foreach (var ls2 in final_present)
                            {
                                if (ls2.ToString() != items.ToString())
                                {
                                    final_present.Add(items);
                                }
                                else
                                {
                                    final_present.Remove(items);
                                }
                            }
                        }
                        catch
                        {
                            // me when i'm falling lol :)
                        }
                    }
                }
            }

            foreach (var items in final_present)
            {
                MessageBox.Show(items.ToString(), "Presents");
            }

            foreach (var items in final_absent)
            {
                MessageBox.Show(items.ToString(), "Absents");
            }
            #endregion

            foreach (var items in absents)
            {
                MessageBox.Show(items.ToString(), "Absents");
            }

        }

        #region Update attendance form
        private void update_attendace_form()
        {

        }

        #endregion



        #region update status
        private void update_status_in_database()
        {
            Console.WriteLine("Updating status in database...");
            try
            {
                update_good();
                update_drop();
                update_warning();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            Console.WriteLine("Done...");
        }


        private void update_drop()
        {
            Console.WriteLine("Updating drop status in database...");
            try
            {
                //update class_maron123 set status = 'DROP2' 
                // where total_absents =
                // ((select total_meets from
                //classes_table where class_code = 'maron123')
                //*0.2)
                SqlConnection conn = new SqlConnection(DBTools.get_connection_string());

                string table_name = "class_" + cb_class.Text;
                string class_code = cb_class.Text;
                //MessageBox.Show("Table Name: " + table_name + "\n\n" + "Class code: " + class_code);

                string query = "update " + table_name + " set status = 'DROP' WHERE total_absents >= " +
                    "((select total_meets from classes_table where class_code = '" + class_code + "') * 0.2);";

                Console.WriteLine("Connection string: " + DBTools.get_connection_string());
                Console.WriteLine("query: " + query);

                SqlCommand cmd = new SqlCommand(query, conn);

                Console.WriteLine("Opening database...");
                conn.Open();
                Console.WriteLine("Done...");

                Console.WriteLine("Executing non query...");
                cmd.ExecuteNonQuery();
                Console.WriteLine("Done...");

                Console.WriteLine("Closing database...");
                conn.Close();
                Console.WriteLine("Done...");

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            Console.WriteLine("Done...");
        }

        private void update_warning()
        {
            Console.WriteLine("Updating status in database...");
            try
            {
                SqlConnection conn = new SqlConnection(DBTools.get_connection_string());

                string table_name = "class_" + cb_class.Text;
                string class_code = cb_class.Text;

                string query = "update " + table_name + " set status = 'WARNING' WHERE total_absents >= " +
                    "((select total_meets from classes_table where class_code = '" + class_code + "') * 0.1) and " +
                    "total_absents >= ((select total_meets from classes_table where class_code = '" + class_code + "') * 0.19);";

                Console.WriteLine("Connection string: " + DBTools.get_connection_string());
                Console.WriteLine("query: " + query);

                SqlCommand cmd = new SqlCommand(query, conn);

                Console.WriteLine("Opening database...");
                conn.Open();
                Console.WriteLine("Done...");

                Console.WriteLine("Executing non query...");
                cmd.ExecuteNonQuery();
                Console.WriteLine("Done...");

                Console.WriteLine("Closing database...");
                conn.Close();
                Console.WriteLine("Done...");

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            Console.WriteLine("Done...");
        }

        private void update_good()
        {

            Console.WriteLine("Updating status in database...");
            try
            {
                SqlConnection conn = new SqlConnection(DBTools.get_connection_string());

                string table_name = "class_" + cb_class.Text;
                string class_code = cb_class.Text;

                string query = "update " + table_name + " set status = 'GOOD' WHERE total_absents < " +
                    "((select total_meets from classes_table where class_code = '" + class_code + "') * 0.1);";

                Console.WriteLine("Connection string: " + DBTools.get_connection_string());
                Console.WriteLine("query: " + query);

                SqlCommand cmd = new SqlCommand(query, conn);

                Console.WriteLine("Opening database...");
                conn.Open();
                Console.WriteLine("Done...");

                Console.WriteLine("Executing non query...");
                cmd.ExecuteNonQuery();
                Console.WriteLine("Done...");

                Console.WriteLine("Closing database...");
                conn.Close();
                Console.WriteLine("Done...");

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            Console.WriteLine("Done...");
        }

        #endregion

        private void btn_back_Click(object sender, EventArgs e)
        {
            DashBoardForm df = new DashBoardForm();

            df.Show();
            Hide();
        }
    }
}
