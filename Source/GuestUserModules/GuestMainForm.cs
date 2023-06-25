using StudentAttendanceManagementSystem.GuestUserModules.GuessUserDashBoard;
using System;
using System.Windows.Forms;

namespace StudentAttendanceManagementSystem.GuestUserModules
{
    public partial class GuestMainForm : Form
    {
        public GuestMainForm()
        {
            InitializeComponent();
        }

        private void btn_yes_Click(object sender, EventArgs e)
        {
            GuestDashBoardForm guess_dash_board = new GuestDashBoardForm();

            guess_dash_board.Show();
            Hide();
        }

        private void btn_no_Click(object sender, EventArgs e)
        {
            MainForm main_form = new MainForm();

            main_form.Show();
            Hide();
        }
    }
}
