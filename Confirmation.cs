using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace ChatterBox
{
    public partial class Confirmation : Form
    {
        private Point MouseHook;

        public Confirmation()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.None;
        }

        private void backVector_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            if (confirmCodeBox.Text == Variables.confirmationCode)
            {
                Handlers.ConfirmationHandler.checkConfirmationHandler(Variables.username, Variables.email, Variables.password);
            } 
            else
            {
                MessageBox.Show("Код неверный! Попробуйте еще раз!");
            }
        }

        private void Confirmation_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) MouseHook = e.Location;
            Location = new Point((Size)Location - (Size)MouseHook + (Size)e.Location);
        }

        
    }
}