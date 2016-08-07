namespace PassKey
{
    using System;
    using System.Linq;
    using System.Windows.Forms;
    using Microsoft.Win32;
    using Extentions;
    using UsersInputValidators;
    using UsersActionHandlers;
    using Exceptions;
    using Forms;
    using Data;

    public partial class LoginForm : Form
    {
        private LoginValidator logValidator;
        private LoginHandler logHandler;
        private BackupHandler backupHandler;
        private RestoreHandler restoreHandler;

        public LoginForm(LoginValidator logValidator
            , LoginHandler logHandler
            , BackupHandler backupHandelr
            , RestoreHandler restoreHandler)
        {
            InitializeComponent();
            this.InitSubKeys();
            this.logValidator = logValidator;
            this.logHandler = logHandler;
            this.backupHandler = backupHandelr;
            this.restoreHandler = restoreHandler;
        }

        public AboutBox AboutBox { private get; set; }

        public RegisterForm RegForm { private get; set; }

        public MainScreen MainForm { private get; set; }

        private void registerButton_Click(object sender, EventArgs e)
        {
            this.usernameTextBox.Clear();
            this.passwordTextBox.Clear();
            this.loginLabel.Hide();
            this.LoadForm(this.RegForm);
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void InitSubKeys()
        {
            var registry = Registry.CurrentUser;

            if (!registry.GetSubKeyNames().Contains(Constants.GeneralSubKeyName))
            {
                registry.CreateSubKey(Constants.GeneralSubKeyName);
                registry.OpenSubKey(Constants.GeneralSubKeyName, true).CreateSubKey(Constants.UsersLoginInfoSubKey);
                registry.Close();
                registry.OpenSubKey(Constants.GeneralSubKeyName, true).CreateSubKey(Constants.UsersDataSubKey);
                registry.Close();                
            }
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.loginLabel.Hide();
                                
                this.logValidator.ValidateInput(this.usernameTextBox.Text, this.passwordTextBox.Text);
                LoggedUser user = this.logHandler.Login(this.usernameTextBox.Text, this.passwordTextBox.Text);
                //Register user "testUser" with password "testPass1", uncomment code bellow and comment the two line above for more easily debug
                //this.logValidator.ValidateInput("testUser", "testPass1");
                //LoggedUser user = this.logHandler.Login("testUser", "testPass1");
                this.MainForm.User = user;

                this.usernameTextBox.Clear();
                this.passwordTextBox.Clear();
                this.loginLabel.Hide();
                
                this.LoadForm(this.MainForm);                
            }
            catch (PassKeyException pke)
            {
                string baseExceptionName = pke.GetBaseException().GetType().Name;
                ShowExceptionMessage(baseExceptionName, pke);
            }
            
        }

        private void ShowExceptionMessage(string baseExceptionName, PassKeyException pke)
        {
            if (baseExceptionName.ToLower().Contains(Constants.BaseUsernameExceptionKeyWord))
            {
                this.loginLabel.Text = pke.Message;
                this.loginLabel.Show();
            }

            if (baseExceptionName.ToLower().Contains(Constants.BasePasswordExceptionKeyWord))
            {
                this.loginLabel.Text = pke.Message;
                this.loginLabel.Show();
            }
        }

        private void aboutButton_Click(object sender, EventArgs e)
        {
            this.AboutBox.Show();
        }

        private void LoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void backupMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show(GlobalMessages.BackupConfirm
                , GlobalMessages.RestoreBackup, MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

            if (dialogResult == DialogResult.OK)
            {
                this.backupHandler.Backup();

                MessageBox.Show(GlobalMessages.BackupCreated, GlobalMessages.Success, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }            
        }

        private void restoreMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show(GlobalMessages.RestoreConfirm
                , GlobalMessages.RestoreBackup, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    this.restoreHandler.Restore();

                    MessageBox.Show(GlobalMessages.BackupRestored, GlobalMessages.Success, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (PassKeyException pke)
                {
                    MessageBox.Show(pke.Message, GlobalMessages.Error, MessageBoxButtons.OK ,MessageBoxIcon.Error);
                }                
            }         
        }

        private void softwareInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.AboutBox.Show();
        }
    }
}