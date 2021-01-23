using System;
using System.Drawing;
using System.Windows.Forms;

namespace ChatterBox
{
    public partial class Main : Form
    {
        private Point MouseHook;
        Label username = new Label();

        public Main()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.None;

            close.FlatAppearance.BorderSize = 0;
            close.FlatStyle = FlatStyle.Flat;
            off.FlatAppearance.BorderSize = 0;
            off.FlatStyle = FlatStyle.Flat;

            off.Click += off_Click;
        }

        private void Main_Load(object sender, EventArgs e)
        {
            Handlers.LoadChatsHandler.sendChatsRequest();

            nameLabel.Text = Variables.username;
            chatPanel.HorizontalScroll.Maximum = 0;
            chatPanel.AutoScroll = false;
            chatPanel.VerticalScroll.Visible = false;
            chatPanel.AutoScroll = true;

            this.off.BackColor = Color.White;
            this.close.BackColor = Color.White;
            this.userToInfo.Hide();
            this.userToInfo.SendToBack();
            chatsPanel.Hide();
            addNewChatButMini.Hide();
            sendMessagePanel.Hide();
        }

        private void off_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Login_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) MouseHook = e.Location;
            Location = new Point((Size)Location - (Size)MouseHook + (Size)e.Location);
        }

        private void close_Click(object sender, EventArgs e)
        {
            Program.checkAnswersThread.Abort();
            Application.Exit();
        }

        private void searchTextBox_Enter(object sender, EventArgs e)
        {
            if (searchTextBox.Text == "Поиск")
            {
                searchTextBox.Text = "";
            }
        }

        private void searchTextBox_Leave(object sender, EventArgs e)
        {
            if (searchTextBox.Text == "")
            {
                searchTextBox.Text = "Поиск";
            }
        }

        public void addNewChat(string name, string chat_id)
        {
            Panel chat = new Panel();
            chat.Name = chat_id;
            chat.Text = name;
            chat.BackgroundImage = Image.FromFile(@"..\\..\\resources\\images\\ChatTemplate.png");
            chat.Size = new Size(235, 66);
            chat.Dock = DockStyle.Top;
            chat.Margin = new Padding(0);
            chat.Cursor = Cursors.Hand;
            chatPanel.Controls.Add(chat);
            chat.Click += HandleClicks;

            Label username = new Label();
            username.Text = name;
            username.Location = new Point(60, 18);
            username.AutoSize = true;
            username.BackColor = Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            username.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(204)));
            username.Name = "nameLabel";
            username.Size = new Size(30, 17);
            chat.Controls.Add(username);
        }

        private void HandleClicks(object sender, EventArgs e)
        {
            Control control = (Control)sender;
            MessageBox.Show(string.Format("{0} was clicked!", control.Name));
            openChatImage.Hide();
            openChatLabel.Hide();
            addNewChatBut.Hide();
            sendMessagePanel.Show();
            chatsPanel.Show();
            addNewChatButMini.Show();

            this.off.BackColor = Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.close.BackColor = Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            userToInfo.Show();

            username.Text = control.Text;
            username.Location = new Point(60, 14);
            username.AutoSize = true;
            username.BackColor = Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            username.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(204)));
            username.Name = "nameLabel";
            username.Size = new Size(30, 17);
            userToInfo.Controls.Add(username);
        }

        private void addNewChatBut_Click(object sender, EventArgs e)
        {
            FormHelper.addNewChatForm();
        }

        private void addNewChatButMini_Click(object sender, EventArgs e)
        {
            FormHelper.addNewChatForm();
        }

        private void submitMsgBut_Click(object sender, EventArgs e)
        {
            if (messageBox.Text != "")
            {

            } 
            else
            {
                MessageBox.Show("Введите сообщение для отправки!");
            }
        }

        int posY = 0;
        public void addMessageToPanel(string message, string companionName)
        {
            if (userToInfo.Text == companionName)
            {
                Label msg = new Label();
                msg.Text = message;
                posY = posY + 14;
                msg.Location = new Point(10, posY);
                msg.AutoSize = true;
                msg.BackColor = Color.Gray;
                msg.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(204)));
                msg.Name = "msgLabel";
                msg.Size = new Size(300, 17);
                chatPanel.Controls.Add(msg);
            }
        }
    }
}
