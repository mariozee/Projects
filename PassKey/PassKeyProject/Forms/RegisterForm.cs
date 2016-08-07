namespace PassKey
{
    using System;
    using System.Windows.Forms;
    using Exceptions;
    using UsersInputValidators;
    using UsersActionHandlers;
    using Extentions;

    public partial class RegisterForm : Form
    {
        private RegistrationValidator regValidator;
        private RegistrationHandler regHandler;

        public RegisterForm(RegistrationValidator regValidator, RegistrationHandler regHandler)
        {
            InitializeComponent();
            this.regValidator = regValidator;
            this.regHandler = regHandler;
        }

        public LoginForm LogForm { private get; set; }

        private void registerButton_Click(object sender, EventArgs e)
        {        
            try
            {
                this.usernameMessageLabel.Hide();
                this.passwordMessageLabel.Hide();

                regValidator.ValidateInput(this.usernameTextBox.Text, this.passwordTextBox.Text, this.confirmPasswordTextBox.Text);

                regHandler.Register(this.usernameTextBox.Text, this.passwordTextBox.Text);

                SuccessMessagePopUp();

                this.LoadForm(this.LogForm);
            }
            catch (PassKeyException pke)
            {                
                string baseExceptionName = pke.GetBaseException().GetType().Name;
                ShowExceptionMessage(baseExceptionName, pke);                
            }            
        }        
        
        private void backButton_Click(object sender, EventArgs e)
        {
            this.LoadForm(this.LogForm);            
        }

        private void SuccessMessagePopUp()
        {
            this.usernameTextBox.Clear();
            this.passwordTextBox.Clear();
            this.confirmPasswordTextBox.Clear();
            MessageBox.Show(GlobalMessages.SuccessRegistrationMessage
                , string.Empty
                , MessageBoxButtons.OK
                , MessageBoxIcon.Information);
        }

        private void ShowExceptionMessage(string baseExceptionName, PassKeyException pke)
        {
            if (baseExceptionName.ToLower().Contains(Constants.BaseUsernameExceptionKeyWord))
            {
                this.usernameMessageLabel.Text = pke.Message;
                this.usernameMessageLabel.Show();
            }

            if (baseExceptionName.ToLower().Contains(Constants.BasePasswordExceptionKeyWord))
            {
                this.passwordMessageLabel.Text = pke.Message;
                this.passwordMessageLabel.Show();
            }
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {

        }

        private void RegisterForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
