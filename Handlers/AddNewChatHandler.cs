using System.Text;
using System.Windows.Forms;

namespace ChatterBox.Handlers
{
    class AddNewChatHandler
    {
        public static void sendNewChatPacket(string usernameFrom, string usernameTo)
        {
            string register = usernameFrom + ":" + usernameTo;
            byte[] msg = Network.HandlersHelper.toByteArray(Encoding.UTF8.GetBytes(register), 6);
            try
            {
                Program.stream.Write(msg, 0, msg.Length);
            }
            catch
            {
                // Ничего...
            }
        }
    }
}
