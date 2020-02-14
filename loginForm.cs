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
    public partial class loginForm : Form
    {
        public loginForm()
        {
            InitializeComponent();
            this.loginField.Text = "Введите логин";
            this.loginField.ForeColor = Color.Gray;
            this.passField.Text = "Введите пароль";
            this.passField.ForeColor = Color.Gray;

        }

        private void CloseButton_MouseEnter(object sender, EventArgs e)
        {
            this.CloseButton.ForeColor = Color.White;
        }

        private void CloseButton_MouseLeave(object sender, EventArgs e)
        {
            this.CloseButton.ForeColor = Color.Black;
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        Point LastPoint;
        private void MainPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                this.Left += e.X - LastPoint.X;
                this.Top += e.Y - LastPoint.Y;

            }
        }

        private void MainPanel_MouseDown(object sender, MouseEventArgs e)
        {
            LastPoint = new Point(e.X, e.Y);
        }

        private void panel1_MouseLeave(object sender, EventArgs e)
        {

        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - LastPoint.X;
                this.Top += e.Y - LastPoint.Y;

            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            LastPoint = new Point(e.X, e.Y);
        }

        private void loginField_TextChanged(object sender, EventArgs e)
        {

        }

        private void loginField_Enter(object sender, EventArgs e)
        {
            if (loginField.Text == "Введите логин")
            {
                loginField.Text = "";
                loginField.ForeColor = Color.Black;
            }
        }

        private void passField_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void passField_Enter(object sender, EventArgs e)
        {
            if (passField.Text == "Введите пароль")
            {
                passField.Text = "";
                passField.ForeColor = Color.Black;
                passField.UseSystemPasswordChar = true;
            }
        }

        private void passField_Leave(object sender, EventArgs e)
        {
            if (passField.Text == "")
            {
                passField.Text = "Введите пароль";
                passField.ForeColor = Color.Gray;
                passField.UseSystemPasswordChar = false;
            }
        }

        private void loginField_Leave(object sender, EventArgs e)
        {
            if (loginField.Text == "")
            {
                loginField.Text = "Введите логин";
                loginField.ForeColor = Color.Gray;
            }
        }

        private void loginTeacher_Click(object sender, EventArgs e)
        {
            if(loginField.Text == "Teacher" && passField.Text == "1234")
            {
                this.Hide();
                TeacherMain teacherMain = new TeacherMain();
                teacherMain.Show();
                
            }
            else
            {
                MessageBox.Show("Вы не вошли. Введите верные данные.");
            }
        }

        private void loginStudent_Click(object sender, EventArgs e)
        {
            this.Hide();
            StudentMain studentMain = new StudentMain();
            studentMain.Show();
        }

        
    
    }
}
