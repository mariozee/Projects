namespace PassKey
{
    partial class MainScreen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainScreen));
            this.hostListBox = new System.Windows.Forms.ComboBox();
            this.usernameBox = new System.Windows.Forms.TextBox();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.showHideButton = new System.Windows.Forms.Button();
            this.logoutButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.passwordHideTimer = new System.Windows.Forms.Timer(this.components);
            this.emailBox = new System.Windows.Forms.TextBox();
            this.editDataButton = new System.Windows.Forms.Button();
            this.removeButton = new System.Windows.Forms.Button();
            this.addHostBox = new System.Windows.Forms.TextBox();
            this.addEmailBox = new System.Windows.Forms.TextBox();
            this.addUsernameBox = new System.Windows.Forms.TextBox();
            this.addPasswordBox = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.doneButton = new System.Windows.Forms.Button();
            this.hostBox = new System.Windows.Forms.TextBox();
            this.doneEditButton = new System.Windows.Forms.Button();
            this.hostMessageLabel = new System.Windows.Forms.Label();
            this.hostNameLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.changePassButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // hostListBox
            // 
            this.hostListBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.hostListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hostListBox.FormattingEnabled = true;
            this.hostListBox.Location = new System.Drawing.Point(56, 64);
            this.hostListBox.Name = "hostListBox";
            this.hostListBox.Size = new System.Drawing.Size(180, 24);
            this.hostListBox.Sorted = true;
            this.hostListBox.TabIndex = 0;
            this.hostListBox.SelectedIndexChanged += new System.EventHandler(this.hostListBox_SelectedIndexChanged);
            // 
            // usernameBox
            // 
            this.usernameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameBox.Location = new System.Drawing.Point(428, 64);
            this.usernameBox.Name = "usernameBox";
            this.usernameBox.ReadOnly = true;
            this.usernameBox.Size = new System.Drawing.Size(180, 22);
            this.usernameBox.TabIndex = 2;
            // 
            // passwordBox
            // 
            this.passwordBox.Enabled = false;
            this.passwordBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordBox.Location = new System.Drawing.Point(614, 64);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.Size = new System.Drawing.Size(180, 22);
            this.passwordBox.TabIndex = 3;
            this.passwordBox.UseSystemPasswordChar = true;
            // 
            // showHideButton
            // 
            this.showHideButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showHideButton.Location = new System.Drawing.Point(800, 63);
            this.showHideButton.Name = "showHideButton";
            this.showHideButton.Size = new System.Drawing.Size(75, 25);
            this.showHideButton.TabIndex = 4;
            this.showHideButton.Text = "Show";
            this.showHideButton.UseVisualStyleBackColor = true;
            this.showHideButton.Click += new System.EventHandler(this.showHideButton_Click);
            // 
            // logoutButton
            // 
            this.logoutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutButton.Location = new System.Drawing.Point(56, 196);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(180, 27);
            this.logoutButton.TabIndex = 5;
            this.logoutButton.Text = "Logout";
            this.logoutButton.UseVisualStyleBackColor = true;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // editButton
            // 
            this.editButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editButton.Location = new System.Drawing.Point(242, 196);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(180, 27);
            this.editButton.TabIndex = 6;
            this.editButton.Text = "Add / Edit";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // passwordHideTimer
            // 
            this.passwordHideTimer.Interval = 5000;
            this.passwordHideTimer.Tick += new System.EventHandler(this.passwordHideTimer_Tick);
            // 
            // emailBox
            // 
            this.emailBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailBox.Location = new System.Drawing.Point(242, 64);
            this.emailBox.Name = "emailBox";
            this.emailBox.ReadOnly = true;
            this.emailBox.Size = new System.Drawing.Size(180, 22);
            this.emailBox.TabIndex = 7;
            // 
            // editDataButton
            // 
            this.editDataButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editDataButton.Location = new System.Drawing.Point(800, 63);
            this.editDataButton.Name = "editDataButton";
            this.editDataButton.Size = new System.Drawing.Size(75, 25);
            this.editDataButton.TabIndex = 8;
            this.editDataButton.Text = "Edit";
            this.editDataButton.UseVisualStyleBackColor = true;
            this.editDataButton.Visible = false;
            this.editDataButton.Click += new System.EventHandler(this.editDataButton_Click);
            // 
            // removeButton
            // 
            this.removeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeButton.Location = new System.Drawing.Point(881, 63);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(75, 25);
            this.removeButton.TabIndex = 9;
            this.removeButton.Text = "Remove";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Visible = false;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // addHostBox
            // 
            this.addHostBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addHostBox.Location = new System.Drawing.Point(56, 130);
            this.addHostBox.Name = "addHostBox";
            this.addHostBox.Size = new System.Drawing.Size(180, 22);
            this.addHostBox.TabIndex = 10;
            this.addHostBox.Visible = false;
            // 
            // addEmailBox
            // 
            this.addEmailBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addEmailBox.Location = new System.Drawing.Point(242, 130);
            this.addEmailBox.Name = "addEmailBox";
            this.addEmailBox.Size = new System.Drawing.Size(180, 22);
            this.addEmailBox.TabIndex = 11;
            this.addEmailBox.Visible = false;
            // 
            // addUsernameBox
            // 
            this.addUsernameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addUsernameBox.Location = new System.Drawing.Point(428, 130);
            this.addUsernameBox.Name = "addUsernameBox";
            this.addUsernameBox.Size = new System.Drawing.Size(180, 22);
            this.addUsernameBox.TabIndex = 12;
            this.addUsernameBox.Visible = false;
            // 
            // addPasswordBox
            // 
            this.addPasswordBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addPasswordBox.Location = new System.Drawing.Point(614, 130);
            this.addPasswordBox.Name = "addPasswordBox";
            this.addPasswordBox.Size = new System.Drawing.Size(180, 22);
            this.addPasswordBox.TabIndex = 13;
            this.addPasswordBox.UseSystemPasswordChar = true;
            this.addPasswordBox.Visible = false;
            // 
            // addButton
            // 
            this.addButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addButton.Location = new System.Drawing.Point(800, 129);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 25);
            this.addButton.TabIndex = 14;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Visible = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // doneButton
            // 
            this.doneButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doneButton.Location = new System.Drawing.Point(56, 196);
            this.doneButton.Name = "doneButton";
            this.doneButton.Size = new System.Drawing.Size(180, 27);
            this.doneButton.TabIndex = 15;
            this.doneButton.Text = "Done";
            this.doneButton.UseVisualStyleBackColor = true;
            this.doneButton.Visible = false;
            this.doneButton.Click += new System.EventHandler(this.doneButton_Click);
            // 
            // hostBox
            // 
            this.hostBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hostBox.Location = new System.Drawing.Point(56, 64);
            this.hostBox.Name = "hostBox";
            this.hostBox.Size = new System.Drawing.Size(180, 22);
            this.hostBox.TabIndex = 16;
            this.hostBox.Visible = false;
            // 
            // doneEditButton
            // 
            this.doneEditButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doneEditButton.Location = new System.Drawing.Point(800, 63);
            this.doneEditButton.Name = "doneEditButton";
            this.doneEditButton.Size = new System.Drawing.Size(75, 25);
            this.doneEditButton.TabIndex = 17;
            this.doneEditButton.Text = "Done";
            this.doneEditButton.UseCompatibleTextRendering = true;
            this.doneEditButton.UseVisualStyleBackColor = true;
            this.doneEditButton.Visible = false;
            this.doneEditButton.Click += new System.EventHandler(this.doneEditButton_Click);
            // 
            // hostMessageLabel
            // 
            this.hostMessageLabel.AutoSize = true;
            this.hostMessageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hostMessageLabel.ForeColor = System.Drawing.Color.OrangeRed;
            this.hostMessageLabel.Location = new System.Drawing.Point(53, 102);
            this.hostMessageLabel.Name = "hostMessageLabel";
            this.hostMessageLabel.Size = new System.Drawing.Size(41, 13);
            this.hostMessageLabel.TabIndex = 18;
            this.hostMessageLabel.Text = "label1";
            this.hostMessageLabel.Visible = false;
            // 
            // hostNameLabel
            // 
            this.hostNameLabel.AutoSize = true;
            this.hostNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hostNameLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.hostNameLabel.Location = new System.Drawing.Point(124, 36);
            this.hostNameLabel.Name = "hostNameLabel";
            this.hostNameLabel.Size = new System.Drawing.Size(40, 16);
            this.hostNameLabel.TabIndex = 19;
            this.hostNameLabel.Text = "Host";
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.emailLabel.Location = new System.Drawing.Point(310, 36);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(47, 16);
            this.emailLabel.TabIndex = 20;
            this.emailLabel.Text = "Email";
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.usernameLabel.Location = new System.Drawing.Point(476, 36);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(79, 16);
            this.usernameLabel.TabIndex = 21;
            this.usernameLabel.Text = "Username";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.passwordLabel.Location = new System.Drawing.Point(668, 36);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(76, 16);
            this.passwordLabel.TabIndex = 22;
            this.passwordLabel.Text = "Password";
            // 
            // changePassButton
            // 
            this.changePassButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changePassButton.Location = new System.Drawing.Point(428, 196);
            this.changePassButton.Name = "changePassButton";
            this.changePassButton.Size = new System.Drawing.Size(180, 27);
            this.changePassButton.TabIndex = 23;
            this.changePassButton.Text = "Change Password";
            this.changePassButton.UseVisualStyleBackColor = true;
            this.changePassButton.Click += new System.EventHandler(this.changePassButton_Click);
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(1003, 282);
            this.Controls.Add(this.changePassButton);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.hostNameLabel);
            this.Controls.Add(this.hostMessageLabel);
            this.Controls.Add(this.doneEditButton);
            this.Controls.Add(this.hostBox);
            this.Controls.Add(this.doneButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.addPasswordBox);
            this.Controls.Add(this.addUsernameBox);
            this.Controls.Add(this.addEmailBox);
            this.Controls.Add(this.addHostBox);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.editDataButton);
            this.Controls.Add(this.emailBox);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.logoutButton);
            this.Controls.Add(this.showHideButton);
            this.Controls.Add(this.passwordBox);
            this.Controls.Add(this.usernameBox);
            this.Controls.Add(this.hostListBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1019, 320);
            this.MinimumSize = new System.Drawing.Size(1019, 320);
            this.Name = "MainScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "PassKey";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainScreen_FormClosed);
            this.Load += new System.EventHandler(this.MainScreen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox hostListBox;
        private System.Windows.Forms.TextBox usernameBox;
        private System.Windows.Forms.TextBox passwordBox;
        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Timer passwordHideTimer;
        private System.Windows.Forms.TextBox emailBox;
        private System.Windows.Forms.Button editDataButton;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.TextBox addHostBox;
        private System.Windows.Forms.TextBox addEmailBox;
        private System.Windows.Forms.TextBox addUsernameBox;
        private System.Windows.Forms.TextBox addPasswordBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button doneButton;
        private System.Windows.Forms.TextBox hostBox;
        private System.Windows.Forms.Button doneEditButton;
        protected System.Windows.Forms.Button showHideButton;
        private System.Windows.Forms.Label hostMessageLabel;
        private System.Windows.Forms.Label hostNameLabel;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Button changePassButton;
    }
}