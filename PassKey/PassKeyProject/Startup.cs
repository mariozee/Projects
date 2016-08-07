namespace PassKey
{
    using System;
    using System.Windows.Forms;
    using Data;
    using Forms;
    using UsersActionHandlers;
    using UsersInputValidators;
    using System.Threading;

    static class Startup
    {
        private static Mutex mutex = new Mutex(true, "mutex");

        [STAThread]
        static void Main()
        {
            if (mutex.WaitOne(TimeSpan.Zero, true))
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);

                DataParser dataParser = new DataParser();

                EditValidor editValidor = new EditValidor();
                EditHandler editHandler = new EditHandler();

                RegistrationHandler regHandler = new RegistrationHandler();
                RegistrationValidator regValidator = new RegistrationValidator();

                LoginHandler logHandler = new LoginHandler(dataParser);
                LoginValidator logValidator = new LoginValidator();

                BackupHandler backupHandler = new BackupHandler();
                RestoreHandler restoreHandler = new RestoreHandler();

                AboutBox aboutBox = new AboutBox();
                MainScreen mainForm = new MainScreen(editHandler, editValidor);
                RegisterForm regForm = new RegisterForm(regValidator, regHandler);
                LoginForm logForm = new LoginForm(logValidator, logHandler, backupHandler, restoreHandler);

                mainForm.LoginForm = logForm;
                regForm.LogForm = logForm;
                logForm.RegForm = regForm;
                logForm.MainForm = mainForm;
                logForm.AboutBox = aboutBox;

                Application.Run(logForm);
            }
            else
            {
                MessageBox.Show("The program already running!", "Oops", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }            
        }
    }
}