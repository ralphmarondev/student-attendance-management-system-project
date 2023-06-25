using StudentAttendanceManagementSystem.AttendanceModule;
using StudentAttendanceManagementSystem.DashBoardModule;
using StudentAttendanceManagementSystem.ReportsModule;
using StudentAttendanceManagementSystem.Tools;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace StudentAttendanceManagementSystem
{
    public partial class AttendanceForm : Form
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

        public AttendanceForm()
        {
            InitializeComponent();
        }

        // constructor for passing data
        public AttendanceForm(string college, string department, string semester, string school_year, string class_enrolled, string date)
        {
            InitializeComponent();

            cb_class.Text = class_enrolled;
            cb_college.Text = college;
            cb_department.Text = department;
            cb_semester.Text = semester;
            cb_school_year.Text = school_year;
            cb_date.Text = date;
        }

        #region Generating buttons programatically

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            string current_date = DBTools.get_current_date();
            //cb_date.Text = "attendance_" + current_date;

            #region Remove all of the items in the array-lists if there is any
            absents.Clear();
            presents.Clear();
            final_absent.Clear();
            #endregion

            buttons_panel.Controls.Clear();
            // edit: 2023-06-09 [clear last name array list]
            last_names.Clear();
            // done

            SqlConnection conn = new SqlConnection(DBTools.get_connection_string());
            string table_name = "class_" + cb_class.Text;//tb_subject_code_add.Text.Replace("-", "_") + "_" + tb_subject_name_add.Text + "_" + cb_semester_add.Text + "_" + tb_school_year_add.Text.Replace("-", "_");

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
                        // int i = 0;
                        while (reader.Read())
                        {
                            string column_value = reader.GetString(column_index);
                            last_names.Add(column_value);
                            //MessageBox.Show(column_value);
                        }
                    }
                    else
                    {
                        MessageBox.Show("No data found!");
                    }
                }
                // sorting last names
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
                // MessageBox.Show("Error: " + ex.Message);
                Console.WriteLine("Error: " + ex.Message);
            }

        }
        #endregion


        #region Initial validation if present or absent
        private void on_btn_click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            // btn.BackColor = Color.Red;
            //            MessageBox.Show(btn.Name);
            if (btn.BackColor == Color.Red)
            {
                btn.BackColor = Color.White;
                //MessageBox.Show(btn.Text + " is present");
                // presents.Add(btn.Text);
                absents.Remove(btn.Text);
                // final_present.Clear(); // if any of the button is clicked
            }
            else
            {
                btn.BackColor = Color.Red;
                //MessageBox.Show(btn.Text + " is absent");
                absents.Add(btn.Text);
                // presents.Remove(btn.Text);
                // final_present.Clear();
            }

        }
        #endregion

        private void btn_finish_Click(object sender, EventArgs e)
        {
            //string conn_string = "Data Source=DESKTOP-PO7BIMA\\SQLEXPRESS;Initial Catalog=StudentAttendanceManagementSystemDB;Integrated Security=True";
            SqlConnection conn = new SqlConnection(DBTools.get_connection_string());

            DateTime currentDate = DateTime.Now;
            string current_date = "attendance_" + currentDate.ToString("yyyy_MM_dd");

            string table_name = "class_" + cb_class.Text; ;
            string column_name = current_date;
            string data_type = "nvarchar(50)";

            #region generating the current date
            //DateTime currentDate = DateTime.Now;
            //Console.WriteLine("Current Date: " + currentDate.ToString("yyyy-MM-dd"));
            //string new_date = "Current Date: " + currentDate.ToString("yyyy-MM-dd");
            #endregion

            #region Delete column
            // Execute your SQL query to delete the column
            // string query = "ALTER TABLE your_table_name DROP COLUMN column_name;";
            #endregion

            #region Rename column
            // Execute your SQL query to rename the column
            // string query = "ALTER TABLE your_table_name CHANGE current_column_name new_column_name data_type;";
            #endregion

            #region Add column
            //string querry = "ALTER TABLE " + table_name + "  ADD " + column_name + " " + data_type;
            //SqlCommand cmd = new SqlCommand(querry, conn);
            //cmd.ExecuteNonQuery();
            #endregion

            // add column
            try
            {
                conn.Open();

                string querry = "ALTER TABLE " + table_name + "  ADD " + column_name + " " + data_type;
                SqlCommand cmd = new SqlCommand(querry, conn);
                cmd.ExecuteNonQuery();

                Console.WriteLine("New column '" + current_date + "' created successfully!");
                //MessageBox.Show("New column '" + current_date + "' created successfully!");


            }
            catch (Exception ex)
            {
                //MessageBox.Show("Error: " + ex.Message);
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }


        }

        private void AttendanceForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            DashBoardForm dashboard_form = new DashBoardForm();

            dashboard_form.Show();
            Hide();
        }

        #region Creating new column in database
        private void creating_new_column(string column_name)
        {
            // string conn_string = "Data Source=LAPTOP-T2HJFRJU\\SQLEXPRESS;Initial Catalog=StudentAttendanceManagementSystemDB;Integrated Security=True";
            SqlConnection conn = new SqlConnection(DBTools.get_connection_string());

            DateTime currentDate = DateTime.Now;
            string current_date = "attendance_" + currentDate.ToString("yyyy_MM_dd");

            string table_name = "class_" + cb_class.Text; ;
            // string column_name = current_date;
            string data_type = "nvarchar(50)";

            #region generating the current date
            //DateTime currentDate = DateTime.Now;
            //Console.WriteLine("Current Date: " + currentDate.ToString("yyyy-MM-dd"));
            //string new_date = "Current Date: " + currentDate.ToString("yyyy-MM-dd");
            #endregion

            #region Delete column
            // Execute your SQL query to delete the column
            // string query = "ALTER TABLE your_table_name DROP COLUMN column_name;";
            #endregion

            #region Rename column
            // Execute your SQL query to rename the column
            // string query = "ALTER TABLE your_table_name CHANGE current_column_name new_column_name data_type;";
            #endregion

            #region Add column
            //string querry = "ALTER TABLE " + table_name + "  ADD " + column_name + " " + data_type;
            //SqlCommand cmd = new SqlCommand(querry, conn);
            //cmd.ExecuteNonQuery();
            #endregion

            // add column
            try
            {
                conn.Open();

                string querry = "ALTER TABLE " + table_name + "  ADD " + column_name + " " + data_type;
                SqlCommand cmd = new SqlCommand(querry, conn);
                cmd.ExecuteNonQuery();

                // inserting present in all of the rows [fields]
                string myValue = "Present";

                InsertSameValueInAllRecords(myValue, table_name, column_name);

                Console.WriteLine("New column '" + column_name + "' created successfully!");


            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
        #endregion


        #region Inserting the same value in all of the rows in a column

        private void InsertSameValueInAllRecords(string value, string table_name, string column_name)
        {
            // string connectionString = "Data Source=LAPTOP-T2HJFRJU\\SQLEXPRESS;Initial Catalog=StudentAttendanceManagementSystemDB;Integrated Security=True";
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

        #region Insert data on array list on database
        private void insert_array_list_values(ArrayList array_list, string connection_string, string column_name, string table_name)
        {
            SqlConnection conn = new SqlConnection(connection_string);

            try
            {
                conn.Open();

                string query = "INSERT INTO " + table_name + " (" + column_name + ") VALUES (@value);";
                SqlCommand cmd = new SqlCommand(query, conn);

                foreach (var value in array_list)
                {
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@value", value.ToString());
                    cmd.ExecuteNonQuery();
                }
                Console.WriteLine("Values inserted successfully!");

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error inserting values: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }


        }
        #endregion

        private void btn_insert_Click(object sender, EventArgs e)
        {
            string conn_string = "Data Source=DESKTOP-PO7BIMA\\SQLEXPRESS;Initial Catalog=StudentAttendanceManagementSystemDB;Integrated Security=True";
            string column_name = "new_column";
            string table_name = "attendance_math1_secondsemester_2022_2023";
            ArrayList list = new ArrayList();
            list.Add("Maron 1");
            list.Add("Maron 2");
            list.Add("Maron 3");

            insert_array_list_values(list, conn_string, column_name, table_name);
        }


        #region View who is absent and who is present
        private void btn_view_Click(object sender, EventArgs e)
        {
            #region try one
            //    MessageBox.Show("Presents: " + size_present.ToString());
            //    MessageBox.Show("Absents: " + size_absent.ToString());

            //    for (int i = 0; i < size_present; i++)
            //    {
            //        MessageBox.Show(presents[i].ToString());
            //    }
            //    for (int i = 0; i < size_absent; i++)
            //    {
            //        MessageBox.Show(absents[i].ToString());
            //    }

            //StringBuilder sb = new StringBuilder();

            //// Iterate over the ArrayList and append the elements to the StringBuilder
            //foreach (var element in presents)
            //{
            //    sb.AppendLine(element.ToString());
            //}

            //// Display the elements in a MessageBox
            //MessageBox.Show(sb.ToString(), "Presents");

            //StringBuilder ab = new StringBuilder();

            //// Iterate over the ArrayList and append the elements to the StringBuilder
            //foreach (var element in absents)
            //{
            //    ab.AppendLine(element.ToString());
            //}

            //// Display the elements in a MessageBox
            //MessageBox.Show(sb.ToString(), "Absents");
            #endregion

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
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error: " + ex.Message);
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

            // sorting absents
            absents.Sort();
            foreach (var items in absents)
            {
                MessageBox.Show(items.ToString(), "Absents");
            }


        }
        #endregion


        #region Inserting who is absent and present on database
        private void validate_student(string table_name, string column_name)
        {
            final_absent.Clear();
            string myValue = "Present";

            InsertSameValueInAllRecords(myValue, table_name, column_name);

            foreach (var items in absents)
            {
                foreach (var items2 in last_names)
                {
                    if ((items.ToString() == items2.ToString()) && !(final_absent.Contains(items.ToString())))
                    {
                        final_absent.Add(items);
                        Console.WriteLine(items.ToString(), "Absent");
                    }
                }
            }
            absents.Clear();
        }

        private string get_date_in_datetime_picker()
        {
            DateTime selected_date = dateTimePicker1.Value;
            //DateTime selectedDate = dateTimePicker1.Value;
            string formatted_date = selected_date.ToString("yyyy_MM_dd");

            Console.WriteLine("Date from date-time picker: " + formatted_date);
            return formatted_date;
        }

        private void btn_present_Click(object sender, EventArgs e)
        {
            if (!(DBTools.is_column_exists_in_table_database("class_" + cb_class.Text, "attendance_" + get_date_in_datetime_picker())))
            {
                try
                {
                    // string conn_string = "Data Source=LAPTOP-T2HJFRJU\\SQLEXPRESS;Initial Catalog=StudentAttendanceManagementSystemDB;Integrated Security=True";
                    SqlConnection connection = new SqlConnection(DBTools.get_connection_string());

                    DateTime currentDate = DateTime.Now;
                    string current_date = "attendance_" + currentDate.ToString("yyyy_MM_dd");

                    string table_name = "class_" + cb_class.Text; ;
                    string column_name = "attendance_" + get_date_in_datetime_picker(); // cb_date.Text;

                    // all students, initially has a present value
                    creating_new_column(column_name);
                    validate_student(table_name, column_name);

                    #region Inserting )absents
                    List<string> myRecordIds_absent = new List<string>();
                    foreach (var items in final_absent)
                    {
                        myRecordIds_absent.Add(items.ToString());
                    }

                    string myValue_absent = "Absent";

                    InsertSameValueInRecords(myRecordIds_absent, myValue_absent, table_name, column_name, "last_name");

                    #endregion


                    #region Update present and absents in database

                    AttendanceTools.update_present(table_name, column_name);
                    AttendanceTools.update_absent(table_name, column_name);

                    string class_code = cb_class.Text;

                    AttendanceTools.update_total_meet_count("classes_table", class_code);

                    #endregion


                    #region Update the status in database
                    // 2023-06-16
                    update_status_in_database();
                    #endregion
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("You already checked attendance for the given date.\nChoose update instead.", "Failed");
            }
        }

        // insert the same values in different records using their ids

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

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AttendanceForm_Load(object sender, EventArgs e)
        {
            // 2023-06-09 [add date on form load]
            cb_date.Text = DBTools.get_current_date();
            // done

            btn_refresh_Click(sender, e);
        }

        private void btn_report_Click(object sender, EventArgs e)
        {
            ReportsForm rf = new ReportsForm();

            rf.Show();
            Hide();
        }

        #region Old codes
        //private void btn_finish_Click(object sender, EventArgs e)
        //{
        //    //string conn_string = "Data Source=LAPTOP-T2HJFRJU\\SQLEXPRESS;Initial Catalog=StudentAttendanceManagementSystemDB;Integrated Security=True";
        //    SqlConnection conn = new SqlConnection(DBTools.get_connection_string());

        //    DateTime currentDate = DateTime.Now;
        //    string current_date = "attendance_" + currentDate.ToString("yyyy_MM_dd");

        //    string table_name = "class_" + cb_class.Text; ;
        //    string column_name = current_date;
        //    string data_type = "nvarchar(50)";

        //    #region generating the current date
        //    //DateTime currentDate = DateTime.Now;
        //    //Console.WriteLine("Current Date: " + currentDate.ToString("yyyy-MM-dd"));
        //    //string new_date = "Current Date: " + currentDate.ToString("yyyy-MM-dd");
        //    #endregion

        //    #region Delete column
        //    // Execute your SQL query to delete the column
        //    // string query = "ALTER TABLE your_table_name DROP COLUMN column_name;";
        //    #endregion

        //    #region Rename column
        //    // Execute your SQL query to rename the column
        //    // string query = "ALTER TABLE your_table_name CHANGE current_column_name new_column_name data_type;";
        //    #endregion

        //    #region Add column
        //    //string querry = "ALTER TABLE " + table_name + "  ADD " + column_name + " " + data_type;
        //    //SqlCommand cmd = new SqlCommand(querry, conn);
        //    //cmd.ExecuteNonQuery();
        //    #endregion

        //    // add column
        //    try
        //    {
        //        conn.Open();

        //        string querry = "ALTER TABLE " + table_name + "  ADD " + column_name + " " + data_type;
        //        SqlCommand cmd = new SqlCommand(querry, conn);
        //        cmd.ExecuteNonQuery();

        //        MessageBox.Show("New column '" + current_date + "' created successfully!");


        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Error: " + ex.Message);
        //    }
        //    finally
        //    {
        //        conn.Close();
        //    }


        //}

        //private void btn_insert_Click(object sender, EventArgs e)
        //{
        //    string conn_string = "Data Source=LAPTOP-T2HJFRJU\\SQLEXPRESS;Initial Catalog=StudentAttendanceManagementSystemDB;Integrated Security=True";
        //    string column_name = "new_column";
        //    string table_name = "attendance_math1_secondsemester_2022_2023";
        //    ArrayList list = new ArrayList();
        //    list.Add("Maron 1");
        //    list.Add("Maron 2");
        //    list.Add("Maron 3");

        //    insert_array_list_values(list, conn_string, column_name, table_name);
        //}

        #endregion

        #region delete attendance
        private void button2_Click(object sender, EventArgs e)
        {
            DeleteAttendanceForm delete = new DeleteAttendanceForm(cb_class.Text, get_date_in_datetime_picker());

            delete.Show();
            // Hide();
        }
        #endregion

        #region  update attendance
        private void button1_Click(object sender, EventArgs e)
        {
            UpdateAttendanceForm update = new UpdateAttendanceForm(cb_college.Text, cb_department.Text, cb_semester.Text, cb_school_year.Text, cb_class.Text, get_date_in_datetime_picker());

            update.Show();
            Hide();
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
