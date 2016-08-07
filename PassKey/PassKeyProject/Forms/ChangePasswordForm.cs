namespace PassKey.Forms
{
    using System;
    using System.Windows.Forms;
    using Exceptions;
    using UsersActionHandlers;
    using UsersInputValidators;

    public partial class ChangePasswordForm : Form
    {
        private PasswordChangeHandler changeHandler;
        private PasswordChangeValidator changeValidator;

        public ChangePasswordForm(PasswordChangeHandler changeHandler, PasswordChangeValidator changeValidator)
        {
            InitializeComponent();
            this.changeHandler = changeHandler;
            this.changeValidator = changeValidator;
        }

        private void doneButton_Click(object sender, EventArgs e)
        {
            oldPassLabel.Hide();
            newPassLabel.Hide();

            try
            {
                changeValidator.Validate(oldPassowrdBox.Text ,newPasswordBox.Text, confirmNewPasswordBox.Text);
                changeHandler.ChangePassword(newPasswordBox.Text);

                MessageBox.Show(GlobalMessages.PasswordChanged, GlobalMessages.Success, MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (PassKeyException pke)
            {
                if (pke.Message == GlobalMessages.IncorectPassword)
                {
                    oldPassLabel.Text = pke.Message;
                    oldPassLabel.Show();
                }
                else
                {
                    newPassLabel.Text = pke.Message;
                    newPassLabel.Show();
                }
            }            
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}