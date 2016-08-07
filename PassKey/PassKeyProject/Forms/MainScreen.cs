namespace PassKey
{
    using UsersActionHandlers;
    using System;
    using System.Drawing;
    using System.Windows.Forms;
    using UsersInputValidators;
    using Exceptions;
    using Extentions;
    using Data;
    using Forms;

    public partial class MainScreen : Form
    {
        private EditHandler editHandler;
        private EditValidor editValidor;

        public MainScreen(EditHandler editHandler, EditValidor editValidor)
        {
            InitializeComponent();
            this.editHandler = editHandler;
            this.editValidor = editValidor;
        }

        public LoggedUser User { private get; set; }

        public LoginForm LoginForm { private get; set; }

        private void MainScreen_Load(object sender, EventArgs e)
        {
            var hostsNames = this.User.GetHosts();
            this.hostListBox.Items.AddRange(hostsNames);
        }

        private void hostListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(hostListBox.Text))
            {
                var userInfo = this.User.GetRegInfoByHost(hostListBox.Text);

                this.emailBox.Text = userInfo[0];
                this.usernameBox.Text = userInfo[1];
                this.passwordBox.Text = userInfo[2];
            }
        }

        private void showHideButton_Click(object sender, EventArgs e)
        {
            if (this.showHideButton.Text == "Show")
            {
                this.passwordHideTimer.Enabled = true;
                this.passwordBox.UseSystemPasswordChar = false;
                this.showHideButton.Text = "Hide";
            }
            else
            {
                this.passwordHideTimer.Enabled = false;
                this.passwordBox.UseSystemPasswordChar = true;
                this.showHideButton.Text = "Show";
            }
        }

        private void passwordHideTimer_Tick(object sender, EventArgs e)
        {
            this.passwordHideTimer.Enabled = false;
            this.passwordBox.UseSystemPasswordChar = true;
            this.showHideButton.Text = "Show";
            this.Refresh();
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            this.EditMode();
        }

        private void doneButton_Click(object sender, EventArgs e)
        {
            this.hostMessageLabel.Hide();
            this.NormalMode();
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult =
                MessageBox.Show(string.Format(GlobalMessages.AboutToDeleteItem
                , this.hostListBox.Text
                , Environment.NewLine)
                , GlobalMessages.WarnningLabel
                , MessageBoxButtons.YesNo
                , MessageBoxIcon.Warning);

            if (dialogResult == DialogResult.Yes)
            {
                this.editHandler.Remove(this.hostListBox.Text, this.User);

                this.hostListBox.Items.Remove(this.hostListBox.Text);
                this.hostListBox.ResetText();
                this.emailBox.Clear();
                this.usernameBox.Clear();
                this.passwordBox.Clear();
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            try
            {
                editValidor.Validate(this.addHostBox.Text, this.User);

                this.editHandler.Add(this.addHostBox.Text
                , this.addEmailBox.Text
                , this.addUsernameBox.Text
                , this.addPasswordBox.Text
                , this.User);

                this.hostListBox.Items.Add(this.addHostBox.Text);
                this.addHostBox.Clear();
                this.addEmailBox.Clear();
                this.addUsernameBox.Clear();
                this.addPasswordBox.Clear();

                this.hostMessageLabel.Hide();
            }
            catch (PassKeyException pke)
            {
                this.hostMessageLabel.Text = pke.Message;
                this.hostMessageLabel.Show();
            }
        }

        private void editDataButton_Click(object sender, EventArgs e)
        {
            this.hostMessageLabel.Hide();

            if (!string.IsNullOrWhiteSpace(this.hostListBox.Text))
            {
                DialogResult dialogResult =
                MessageBox.Show(string.Format(GlobalMessages.AboutToShowPassword, Environment.NewLine)
                , GlobalMessages.WarnningLabel
                , MessageBoxButtons.YesNo
                , MessageBoxIcon.Exclamation);

                if (dialogResult == DialogResult.Yes)
                {
                    this.removeButton.Enabled = false;
                    this.emailBox.ReadOnly = false;
                    this.usernameBox.ReadOnly = false;
                    this.passwordBox.Enabled = true;

                    this.passwordBox.UseSystemPasswordChar = false;

                    this.hostBox.Text = this.hostListBox.Text;
                    this.hostListBox.Visible = false;
                    this.hostBox.Visible = true;

                    this.hostListBox.Items.Remove(this.hostBox.Text);
                    this.hostListBox.ResetText();

                    this.editDataButton.Visible = false;
                    this.doneEditButton.Visible = true;

                    this.doneButton.Enabled = false;
                    this.editHandler.Remove(this.hostBox.Text, this.User);
                }
            }
        }

        private void doneEditButton_Click(object sender, EventArgs e)
        {
            this.hostMessageLabel.Hide();

            try
            {
                editValidor.Validate(this.hostBox.Text, this.User);

                this.removeButton.Enabled = true;

                this.editHandler.Add(this.hostBox.Text
                , this.emailBox.Text
                , this.usernameBox.Text
                , this.passwordBox.Text
                , this.User);

                this.hostListBox.Items.Add(this.hostBox.Text);

                this.hostBox.Clear();
                this.emailBox.Clear();
                this.usernameBox.Clear();
                this.passwordBox.Clear();

                this.emailBox.ReadOnly = true;
                this.usernameBox.ReadOnly = true;
                this.passwordBox.Enabled = false;
                this.passwordBox.UseSystemPasswordChar = true;

                this.hostListBox.Visible = true;
                this.hostBox.Visible = false;

                this.editDataButton.Visible = true;
                this.doneEditButton.Visible = false;
                this.doneButton.Enabled = true;
            }
            catch (PassKeyException pke)
            {
                this.hostMessageLabel.Text = pke.Message;
                this.hostMessageLabel.Show();
            }
        }

        private void EditMode()
        {
            this.BackColor = Color.DimGray;
            this.showHideButton.Visible = false;
            this.editButton.Visible = false;
            this.logoutButton.Visible = false;
            this.changePassButton.Visible = false;

            this.editDataButton.Visible = true;
            this.doneButton.Visible = true;
            this.addButton.Visible = true;
            this.removeButton.Visible = true;

            this.addEmailBox.Visible = true;
            this.addHostBox.Visible = true;
            this.addUsernameBox.Visible = true;
            this.addPasswordBox.Visible = true;
        }

        private void NormalMode()
        {
            this.BackColor = Color.FromArgb(48, 48, 48);
            this.showHideButton.Visible = true;
            this.editButton.Visible = true;
            this.logoutButton.Visible = true;
            this.changePassButton.Visible = true;

            this.editDataButton.Visible = false;
            this.doneButton.Visible = false;
            this.addButton.Visible = false;
            this.removeButton.Visible = false;

            this.addEmailBox.Visible = false;
            this.addHostBox.Visible = false;
            this.addUsernameBox.Visible = false;
            this.addPasswordBox.Visible = false;
        }

        private void MainScreen_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            this.LoadForm(this.LoginForm);
        }

        private void changePassButton_Click(object sender, EventArgs e)
        {
            var changeHandler = new PasswordChangeHandler(this.User);
            var changeValidator = new PasswordChangeValidator(this.User);
            var changeForm = new ChangePasswordForm(changeHandler, changeValidator);
            changeForm.Show();
        }
    }
}