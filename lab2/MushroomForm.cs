namespace lab2
{
    public partial class MushroomForm : Form
    {
        private readonly ChooseForm chooseForm;
        private readonly Form1 loginForm;

        public MushroomForm(ChooseForm chooseForm, Form1 loginForm)
        {
            this.chooseForm = chooseForm;
            this.loginForm = loginForm;
            InitializeComponent();
        }

        private void CheckButton_Click(object? sender, EventArgs e)
        {
            if (mushroomTypeComboBox.SelectedItem is not string mushroomType)
            {
                MessageBox.Show("Select a mushroom type.", "Mushroom", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(quantityTextBox.Text, out int quantity) || quantity <= 0)
            {
                MessageBox.Show("Enter a quantity greater than zero.", "Mushroom", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                quantityTextBox.Focus();
                return;
            }

            bool isEdible = mushroomType is "Button mushroom" or "Oyster mushroom";
            string result = isEdible ? "edible" : "not edible";
            MessageBox.Show($"{quantity} {mushroomType}(s) selected. This mushroom is {result}.", "Mushroom", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
