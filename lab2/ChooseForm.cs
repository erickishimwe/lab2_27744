namespace lab2
{
    public partial class ChooseForm : Form
    {
        private readonly Form1 loginForm;

        public ChooseForm(Form1 loginForm)
        {
            this.loginForm = loginForm;
            InitializeComponent();
        }

        private void BicycleButton_Click(object? sender, EventArgs e)
        {
            Hide();
            new BicycleForm(this, loginForm).Show();
        }

        private void MushroomButton_Click(object? sender, EventArgs e)
        {
            Hide();
            new MushroomForm(this, loginForm).Show();
        }
    }
}
