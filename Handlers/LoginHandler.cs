using System.Text;
using System.Windows.Forms;

namespace ChatterBox.Handlers
{
    class LoginHandler
    {
        public static void checkLoginHandler(string username, string password)
        {
            string register = username + ":" + password;
            byte[] msg = Network.HandlersHelper.toByteArray(Encoding.UTF8.GetBytes(register), 2);
            try
            {
                Program.stream.Write(msg, 0, msg.Length);
            }
            catch
            {
                MessageBox.Show("Ошибка соединения с сервером, пожалуйста, попробуйте еще раз!");
            }
        }
    }
}
