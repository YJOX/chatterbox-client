using System.Text;
using System.Windows.Forms;

namespace ChatterBox.Handlers
{
    class LoadChatsHandler
    {
        public static void sendChatsRequest()
        {
            string chatRequest = Variables.username;
            byte[] msg = Network.HandlersHelper.toByteArray(Encoding.UTF8.GetBytes(chatRequest), 3);
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
