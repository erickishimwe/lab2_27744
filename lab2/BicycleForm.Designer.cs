namespace lab2
{
    partial class BicycleForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            titleLabel = new Label();
            typeLabel = new Label();
            bicycleTypeComboBox = new ComboBox();
            hoursLabel = new Label();
            hoursTextBox = new TextBox();
            calculateButton = new Button();
            totalLabel = new Label();
            totalTextBox = new TextBox();
            backButton = new Button();
            logoutButton = new Button();
            SuspendLayout();
            titleLabel.AutoSize = true;
            titleLabel.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            titleLabel.Location = new Point(205, 25);
            titleLabel.Text = "Bicycle rental";
            typeLabel.AutoSize = true;
            typeLabel.Location = new Point(75, 90);
            typeLabel.Text = "Bicycle type:";
            bicycleTypeComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            bicycleTypeComboBox.Items.AddRange(new object[] { "City bicycle", "Mountain bicycle" });
            bicycleTypeComboBox.Location = new Point(190, 87);
            bicycleTypeComboBox.Size = new Size(230, 23);
            hoursLabel.AutoSize = true;
            hoursLabel.Location = new Point(75, 135);
            hoursLabel.Text = "Hours:";
            hoursTextBox.Location = new Point(190, 132);
            hoursTextBox.Size = new Size(230, 23);
            calculateButton.Location = new Point(190, 175);
            calculateButton.Size = new Size(130, 32);
            calculateButton.Text = "Calculate";
            calculateButton.UseVisualStyleBackColor = true;
            calculateButton.Click += CalculateButton_Click;
            totalLabel.AutoSize = true;
            totalLabel.Location = new Point(75, 225);
            totalLabel.Text = "Total:";
            totalTextBox.Location = new Point(190, 222);
            totalTextBox.ReadOnly = true;
            totalTextBox.Size = new Size(230, 23);
            backButton.Location = new Point(115, 275);
            backButton.Size = new Size(110, 35);
            backButton.Text = "Back";
            backButton.UseVisualStyleBackColor = true;
            backButton.Click += BackButton_Click;
            logoutButton.Location = new Point(295, 275);
            logoutButton.Size = new Size(110, 35);
            logoutButton.Text = "Logout";
            logoutButton.UseVisualStyleBackColor = true;
            logoutButton.Click += LogoutButton_Click;
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(500, 350);
            Controls.Add(titleLabel);
            Controls.Add(typeLabel);
            Controls.Add(bicycleTypeComboBox);
            Controls.Add(hoursLabel);
            Controls.Add(hoursTextBox);
            Controls.Add(calculateButton);
            Controls.Add(totalLabel);
            Controls.Add(totalTextBox);
            Controls.Add(backButton);
            Controls.Add(logoutButton);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bicycle";
            ResumeLayout(false);
            PerformLayout();
        }

        private Label titleLabel;
        private Label typeLabel;
        private ComboBox bicycleTypeComboBox;
        private Label hoursLabel;
        private TextBox hoursTextBox;
        private Button calculateButton;
        private Label totalLabel;
        private TextBox totalTextBox;
        private Button backButton;
        private Button logoutButton;
    }
}
