using System.Text;
using System.Windows.Forms;

namespace ChatterBox.Handlers
{
    class ConfirmationHandler
    {
        public static void checkConfirmationHandler(string username, string email, string password)
        {
            string register = username + ":" + email + ":" + password;
            byte[] msg = Network.HandlersHelper.toByteArray(Encoding.UTF8.GetBytes(register), 1);
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

        public static void completeRegistration()
        {
            MessageBox.Show("Регистрация успешно завершена, теперь вы можете войти с помощью своего логина и пароля!");
        }
    }
}
