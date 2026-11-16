namespace lab2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object? sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(usernameTextBox.Text) ||
                string.IsNullOrWhiteSpace(passwordTextBox.Text))
            {
                MessageBox.Show("Username and password cannot be empty.", "Login", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var chooseForm = new ChooseForm(this);
            Hide();
            chooseForm.Show();
        }
    }
}
