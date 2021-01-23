using System.Text;
using System.Windows.Forms;

namespace ChatterBox.Handlers
{
    class RegistrationHandler
    {
        public static void checkRegistrationHandler(string username, string email, string password)
        {
            string register = username + ":" + email + ":" + password;
            byte[] msg = Network.HandlersHelper.toByteArray(Encoding.UTF8.GetBytes(register), 0);
            try
            {
                Program.stream.Write(msg, 0, msg.Length);
            }
            catch
            {
                MessageBox.Show("Ошибка соединения с сервером, пожалуйста, попробуйте еще раз!");
                Variables.username = "";
                Variables.email = "";
                Variables.password = "";
            }
        }
    }
}
