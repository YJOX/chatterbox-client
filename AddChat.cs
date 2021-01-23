using System;
using System.Drawing;
using System.Windows.Forms;

namespace ChatterBox
{
    public partial class AddChat : Form
    {
        private Point MouseHook;
        Main mainForm;

        public AddChat()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.None;

        }

        public AddChat(Main form)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.None;
            this.mainForm = form;
        }

        private void backVector_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            if (addChatBox.Text != "")
            {
                Handlers.AddNewChatHandler.sendNewChatPacket(Variables.username, addChatBox.Text);
            }
            else
            {
                MessageBox.Show("Поле для ввода никнейма нельзя оставлять пустым!");
            }
        }

        private void AddChat_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) MouseHook = e.Location;
            Location = new Point((Size)Location - (Size)MouseHook + (Size)e.Location);
        }
    }
}
