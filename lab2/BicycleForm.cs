namespace lab2
{
    public partial class BicycleForm : Form
    {
        private readonly ChooseForm chooseForm;
        private readonly Form1 loginForm;

        public BicycleForm(ChooseForm chooseForm, Form1 loginForm)
        {
            this.chooseForm = chooseForm;
            this.loginForm = loginForm;
            InitializeComponent();
        }

        private void CalculateButton_Click(object? sender, EventArgs e)
        {
            if (bicycleTypeComboBox.SelectedItem is not string bicycleType)
            {
                MessageBox.Show("Select a bicycle type.", "Bicycle rental", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(hoursTextBox.Text, out decimal hours) || hours <= 0)
            {
                MessageBox.Show("Enter a number of hours greater than zero.", "Bicycle rental", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                hoursTextBox.Focus();
                return;
            }

            decimal hourlyRate = bicycleType == "Mountain bicycle" ? 8.00m : 5.00m;
            decimal total = hours * hourlyRate;
            totalTextBox.Text = total.ToString("C2");
            MessageBox.Show($"Bicycle rental total: {total:C2}", "Bicycle rental", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BackButton_Click(object? sender, EventArgs e)
        {
            chooseForm.Show();
            Close();
        }

        private void LogoutButton_Click(object? sender, EventArgs e)
        {
            loginForm.Show();
            chooseForm.Close();
            Close();
        }
    }
}
