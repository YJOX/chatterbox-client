using System;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace ChatterBox.Network
{
    class AnswerHandler
    {
        public static Thread addChat;
        public static void checkAnswers()
        {
            try
            {
                byte[] msg = new byte[1024];
                string decodedString = "";
                int count = 0;
                while (true)
                {
                    count = Program.stream.Read(msg, 0, msg.Length);
                    decodedString = Encoding.UTF8.GetString(msg, 1, count - 1);

                    if (msg[0] == 11) // Регистрация
                    {
                        if (decodedString.Contains("ALLOW"))
                        {
                            string[] data = decodedString.Split(':');
                            Variables.confirmationCode = data[1];
                            FormHelper.registerForm.BeginInvoke(new MethodInvoker(delegate
                            {
                                FormHelper.createConfirmationForm();
                            }));
                        }
                        else if (decodedString.Contains("DENY"))
                        {
                            MessageBox.Show("Произошла ошибка, пожалуйста, повторите попытку!");
                        }
                    }
                    else if (msg[0] == 22) // Подтверждение регистрации
                    {
                        if (decodedString == "ALLOW")
                        {
                            Handlers.ConfirmationHandler.completeRegistration();
                            FormHelper.confirmForm.BeginInvoke(new MethodInvoker(delegate
                            {
                                FormHelper.confirmForm.Close();
                            }));
                        }
                        else if (decodedString.Contains("DENY"))
                        {
                            MessageBox.Show("Произошла ошибка, пожалуйста, повторите попытку!");
                        }
                    }
                    else if (msg[0] == 33) // Авторизация
                    {
                        if (decodedString == "ALLOW")
                        {
                            FormHelper.loginForm.BeginInvoke(new MethodInvoker(delegate
                            {
                                FormHelper.createMainForm();
                            }));
                            
                        }
                        else if (decodedString == "DENY")
                        {
                            Variables.username = "";
                            MessageBox.Show("Введён неверный логин или пароль, пожалуйста, попробуйте еще раз");
                        }
                    }
                    else if (msg[0] == 44) // Загрузка чатов
                    {
                        MessageBox.Show(decodedString);
                        string[] data = decodedString.Split(':');
                        FormHelper.mainForm.BeginInvoke(new MethodInvoker(delegate
                        {
                            FormHelper.mainForm.addNewChat(data[0], data[1]);
                        }));
                    }
                    else if (msg[0] == 55) // Отправка сообщений
                    {

                    }
                    else if (msg[0] == 66) // Приём сообщений
                    {
                        string[] data = decodedString.Split(':');
                        FormHelper.mainForm.BeginInvoke(new MethodInvoker(delegate
                        {
                            FormHelper.mainForm.addMessageToPanel(data[0], data[1]);
                        }));
                    }
                    else if (msg[0] == 77) // Создание нового чата
                    {
                        string[] data = decodedString.Split(':');
                        if (data[0] == "ALLOW")
                        {
                            FormHelper.mainForm.BeginInvoke(new MethodInvoker(delegate
                            {
                                FormHelper.mainForm.addNewChat(data[1], data[2]);
                                FormHelper.addChatForm.Close();
                            }));
                            MessageBox.Show("Новый чат успешно создан!");
                        }
                        else
                        {
                            MessageBox.Show("Ошибка создания чата! Возможно, введенного никнейма не существует!");
                        }
                    }
                    Thread.Sleep(5);
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.ToString());
            }
        }
    }
}
