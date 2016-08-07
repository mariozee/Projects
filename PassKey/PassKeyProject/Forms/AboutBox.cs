namespace PassKey.Forms
{
    using System;
    using System.Windows.Forms;

    public partial class AboutBox : Form
    {
        public AboutBox()
        {
            InitializeComponent();            
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}