using System;
using System.Drawing;
using System.Windows.Forms;

namespace ChatterBox
{
    public partial class Registration : Form
    {
        private Point MouseHook;

        public Registration()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.None;
        }

        private void backVector_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            if (nameBox.Text != "" && emailBox.Text != "" && passBox.Text != "" && repeatPassBox.Text != "")
            {
                if (passBox.Text == repeatPassBox.Text)
                {
                    Handlers.RegistrationHandler.checkRegistrationHandler(nameBox.Text, emailBox.Text, passBox.Text);
                    Variables.username = nameBox.Text;
                    Variables.email = emailBox.Text;
                    Variables.password = passBox.Text;
                }
                else
                {
                    MessageBox.Show("Пароли не совпадают!");
                }
            } 
            else
            {
                MessageBox.Show("Заполните все поля!");
            }
        }

        private void Registration_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) MouseHook = e.Location;
            Location = new Point((Size)Location - (Size)MouseHook + (Size)e.Location);
        }
    }
}
