using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace ChatterBox
{
    public partial class Login : Form
    {
        private Point MouseHook;

        public Login()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.None;

            close.FlatAppearance.BorderSize = 0;
            close.FlatStyle = FlatStyle.Flat;
            off.FlatAppearance.BorderSize = 0;
            off.FlatStyle = FlatStyle.Flat;

            close.Click += close_Click;
            off.Click += off_Click;
        }

        private void close_Click(object sender, EventArgs e)
        {
            Program.checkAnswersThread.Abort();
            Application.Exit();
        }

        private void off_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void loginText_Enter(object sender, EventArgs e)
        {
            if (loginText.Text == "Login")
            {
                loginText.Text = "";
                loginText.ForeColor = Color.Gray;
            }
        }

        private void loginText_Leave(object sender, EventArgs e)
        {
            if (loginText.Text == "")
            {
                loginText.Text = "Login";
                loginText.ForeColor = Color.Gray;
            }
        }

        private void passText_Enter(object sender, EventArgs e)
        {
            if (passText.Text == "Password")
            {
                passText.Text = "";
                passText.ForeColor = Color.Gray;
            }
        }

        private void passText_Leave(object sender, EventArgs e)
        {
            if (passText.Text == "")
            {
                passText.Text = "Password";
                passText.ForeColor = Color.Gray;
            }
        }

        private void Login_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) MouseHook = e.Location;
            Location = new Point((Size)Location - (Size)MouseHook + (Size)e.Location);
        }

        private void showPass_CheckedChanged(object sender, EventArgs e)
        {
            if (showPass.Checked)
            {
                passText.UseSystemPasswordChar = false;
            } else
            {
                passText.UseSystemPasswordChar = true;
            }
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            Variables.username = loginText.Text;
            Handlers.LoginHandler.checkLoginHandler(loginText.Text, passText.Text);
        }

        private void Registration_Click(object sender, EventArgs e)
        {
            FormHelper.createRegistrationForm();
        }
    }
}
