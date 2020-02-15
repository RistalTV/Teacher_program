using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Teacher_program
{
    public partial class TeacherMain : Form
    {
        public TeacherMain()
        {
            InitializeComponent();
            DebugForm debugForm = new DebugForm();
            debugForm.Show();
        }

        private void buttonInfoProgram_Click(object sender, EventArgs e)
        {
            panelOfInfoButton.Dock = System.Windows.Forms.DockStyle.Fill;
        }

        private void CloseButton_MouseEnter(object sender, EventArgs e)
        {
            CloseButton.ForeColor = Color.FromArgb(18, 159, 123);
        }

        private void CloseButton_MouseLeave(object sender, EventArgs e)
        {
            CloseButton.ForeColor = Color.White;
        }

        private void CloseButton_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ExitToLoginForm_Click(object sender, EventArgs e)
        {
            loginForm LoginForm = new loginForm();
            TeacherMain teacherMain = new TeacherMain();
            teacherMain.Hide();
            teacherMain.Close();
            LoginForm.Show();
        }
    }
}
