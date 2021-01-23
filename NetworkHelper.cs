using System;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace ChatterBox
{
    class NetworkHelper
    {
        const int CONNECTION_NUMBER = 3; // Кол-во попыток для подключений
        const int CONNECTION_TIMEOUT = 200; // Время таймаута между подключениями в мс
        static int chatCount = 0; // Кол-во созданных чатов пользователем

        public static bool checkLogin(string login, string password)
        {
            try
            {
                string checkLogin = "[LOGIN]:" + login + ":" + password;
                byte[] msg = Encoding.UTF8.GetBytes(checkLogin);
                MessageBox.Show(msg.ToString());
                Program.stream.Write(msg, 0, msg.Length);

                /*byte[] msg2 = new byte[1024];
                string decodedString;
                for (int i = 0; i < CONNECTION_NUMBER; i++)
                {
                    if (Program.stream.DataAvailable)
                    {
                        int count = Program.stream.Read(msg2, 0, msg2.Length);
                        decodedString = Encoding.UTF8.GetString(msg2, 0, count);
                        if (decodedString != null)
                        {
                            if (decodedString.Contains("[LOGINANSWER]"))
                            {
                                string[] data = decodedString.Split(':');
                                if (data[1] == "ALLOW")
                                {
                                    Variables.username = data[2];
                                    return true;
                                }
                                else
                                {
                                    return false;
                                }
                            }
                            else if (decodedString.Contains("[ACCOUNTNULL]"))
                            {
                                MessageBox.Show("Ваш аккаунт не зарегистрирован!");
                                return false;
                            }
                        }
                    }
                    Thread.Sleep(CONNECTION_TIMEOUT);
                }*/
            } catch
            {
                MessageBox.Show("Произошла ошибка во время проверки данных. Попробуй повторить попытку.");
            }
            return false;
        }

        public static void createNewUserClient(string username, string email, string password)
        {
            string register = "[REGISTRATION]:" + username + ":" + email + ":" + password;
            byte[] msg = Encoding.UTF8.GetBytes(register);
            try
            {
                Program.stream.Write(msg, 0, msg.Length);
            }
            catch
            {
                MessageBox.Show("Ошибка соединения с сервером!");
            }
        }

        public static void activateNewUserClient(string username, string email, string password)
        {
            string register = "[CONFIRMATION]:" + username + ":" + email + ":" + password;
            byte[] msg = Encoding.UTF8.GetBytes(register);
            try
            {
                Program.stream.Write(msg, 0, msg.Length);
            }
            catch
            {
                MessageBox.Show("Ошибка соединения с сервером!");
            }
        }

        public static string readConfirmationCode()
        {
            byte[] msg = new byte[1024];
            int count = Program.stream.Read(msg, 0, msg.Length);
            string decodedString = Encoding.UTF8.GetString(msg, 0, count);
            if (decodedString.Contains("[CONFIRMATION]"))
            {
                string[] str = decodedString.Split(':');
                return str[1];
            }
            return null;
        }

        public static bool createNewChatClient(string usernameFrom, string usernameTo)
        {
            try
            {
                string addChat = "[ADDNEWCHAT]:" + usernameFrom + ":" + usernameTo;
                byte[] msg = Encoding.UTF8.GetBytes(addChat);
                Program.stream.Write(msg, 0, msg.Length);

                byte[] msg2 = new byte[1024];
                string decodedString;
                for (int i = 0; i < CONNECTION_NUMBER; i++)
                {
                    if (Program.stream.DataAvailable)
                    {
                        int count = Program.stream.Read(msg2, 0, msg2.Length);
                        decodedString = Encoding.UTF8.GetString(msg2, 0, count);
                        if (decodedString != null)
                        {
                            if (decodedString.Contains("[ADDNEWCHATANSWER]"))
                            {
                                string[] data = decodedString.Split(':');
                                if (data[1] == "ALLOW")
                                {
                                    //Variables.chat_id = Convert.ToInt32(data[2]);
                                    return true;
                                }
                                else
                                {
                                    return false;
                                }
                            }
                        }
                    }
                    Thread.Sleep(CONNECTION_TIMEOUT);
                }
            }
            catch
            {
                MessageBox.Show("Ошибка соединения с сервером!");
                return false;
            }
            return false;
        }

        public static void getChatCountClient(string username)
        {
            string checkLogin = "[GETCHATCOUNT]:" + username;
            byte[] msg = Encoding.UTF8.GetBytes(checkLogin);
            Program.stream.Write(msg, 0, msg.Length);

            byte[] msg2 = new byte[1024];
            string decodedString;
            for (int i = 0; i < CONNECTION_NUMBER; i++)
            {
                if (Program.stream.DataAvailable)
                {
                    int count = Program.stream.Read(msg2, 0, msg2.Length);
                    decodedString = Encoding.UTF8.GetString(msg2, 0, count);
                    if (decodedString != null)
                    {
                        if (decodedString.Contains("[USERCHATCOUNT]"))
                        {
                            string[] data = decodedString.Split(':');
                            chatCount = Convert.ToInt32(data[1]);
                            return;
                        }
                    }
                }
                Thread.Sleep(CONNECTION_TIMEOUT);
            }
        }

        public static string getChats(string username)
        {
            try
            {
                getChatCountClient(username);
                string checkLogin = "[GETCHATS]:" + username;
                byte[] msg = Encoding.UTF8.GetBytes(checkLogin);
                Program.stream.Write(msg, 0, msg.Length);

                byte[] msg2 = new byte[1024];
                string decodedString;
                for (int i = 0; i < CONNECTION_NUMBER; i++)
                {
                    if (Program.stream.DataAvailable)
                    {
                        int count = Program.stream.Read(msg2, 0, msg2.Length);
                        decodedString = Encoding.UTF8.GetString(msg2, 0, count);
                        if (decodedString != null)
                        {
                            for (int j = 0; j < chatCount; j++)
                            {
                                if (decodedString.Contains("[GETCHATSFROMSERVER]"))
                                {
                                    string[] data = decodedString.Split(':');
                                    Variables.usernames.Add(data[1]);
                                    Variables.usernames.Add(data[2]);
                                }
                            }
                        }
                    }
                    Thread.Sleep(CONNECTION_TIMEOUT);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Произошла ошибка во время проверки данных. Попробуйте повторить попытку.");
                return null;
            }
            return null;
        }

        public static string getMessages(string username)
        {
            try
            {
                getChatCountClient(username);
                string checkLogin = "[GETMESSAGES]:" + username;
                byte[] msg = Encoding.UTF8.GetBytes(checkLogin);
                Program.stream.Write(msg, 0, msg.Length);

                byte[] msg2 = new byte[1024];
                string decodedString;
                for (int i = 0; i < CONNECTION_NUMBER; i++)
                {
                    if (Program.stream.DataAvailable)
                    {
                        int count = Program.stream.Read(msg2, 0, msg2.Length);
                        decodedString = Encoding.UTF8.GetString(msg2, 0, count);
                        if (decodedString != null)
                        {
                            
                        }
                    }
                    Thread.Sleep(CONNECTION_TIMEOUT);
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Произошла ошибка во время проверки данных. Попробуй повторить попытку.");
                return null;
            }
            return null;
        }

        public static void checkMessages()
        {
            while (true)
            {
                
            }
        }
    }
}
