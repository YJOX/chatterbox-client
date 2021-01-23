using System;
using System.Net.Sockets;
using System.Threading;
using System.Windows.Forms;

namespace ChatterBox
{
    static class Program
    {
        private const string host = "95.217.58.79";
        private const int port = 1337;
        public static TcpClient client;
        public static NetworkStream stream;
        public static Thread checkAnswersThread;

        [STAThread]
        static void Main()
        {
            try
            {
                client = new TcpClient();
                client.Connect(host, port);
                stream = client.GetStream();

                checkAnswersThread = new Thread(new ThreadStart(Network.AnswerHandler.checkAnswers));
                checkAnswersThread.Start();
            }
            catch
            {
                Application.Run(new ServerError());
                return;
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            FormHelper.mainForm = new Main();
            Application.Run(FormHelper.loginForm = new Login());
        }
    }
}
