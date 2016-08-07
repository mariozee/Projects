namespace PassKey.Extentions
{
    using System.Drawing;
    using System.Windows.Forms;

    public static class ExtentionForm
    {
        public static void LoadForm(this Form current, Form incoming)
        {
            int x = current.Location.X;
            int y = current.Location.Y;

            current.Hide();
            incoming.Location = new Point(x, y);
            incoming.Show();
        }
    }
}