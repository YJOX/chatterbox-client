using System;

namespace ChatterBox
{
    class FormHelper
    {
        public static Login loginForm;
        public static Registration registerForm;
        public static Confirmation confirmForm;
        public static Main mainForm;
        public static AddChat addChatForm;

        public static void createRegistrationForm()
        {
            registerForm = new Registration();
            registerForm.Show();
        }

        public static void createConfirmationForm()
        {
            confirmForm = new Confirmation();
            confirmForm.Show();
            registerForm.Close();
        }

        public static void createMainForm()
        {
            mainForm.Show();
        }

        public static void closeLoginForm()
        {
            loginForm.Close();
        }

        public static void addNewChatForm()
        {
            addChatForm = new AddChat();
            addChatForm.Show();
        }
    }
}
