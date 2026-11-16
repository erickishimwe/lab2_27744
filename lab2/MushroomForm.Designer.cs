namespace lab2
{
    partial class MushroomForm
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
            mushroomTypeComboBox = new ComboBox();
            quantityLabel = new Label();
            quantityTextBox = new TextBox();
            checkButton = new Button();
            backButton = new Button();
            logoutButton = new Button();
            SuspendLayout();
            titleLabel.AutoSize = true;
            titleLabel.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            titleLabel.Location = new Point(190, 30);
            titleLabel.Text = "Mushroom";
            typeLabel.AutoSize = true;
            typeLabel.Location = new Point(65, 95);
            typeLabel.Text = "Mushroom type:";
            mushroomTypeComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            mushroomTypeComboBox.Items.AddRange(new object[] { "Button mushroom", "Oyster mushroom", "Unknown mushroom" });
            mushroomTypeComboBox.Location = new Point(190, 92);
            mushroomTypeComboBox.Size = new Size(240, 23);
            quantityLabel.AutoSize = true;
            quantityLabel.Location = new Point(65, 140);
            quantityLabel.Text = "Quantity:";
            quantityTextBox.Location = new Point(190, 137);
            quantityTextBox.Size = new Size(240, 23);
            checkButton.Location = new Point(190, 180);
            checkButton.Size = new Size(130, 32);
            checkButton.Text = "Check";
            checkButton.UseVisualStyleBackColor = true;
            checkButton.Click += CheckButton_Click;
            backButton.Location = new Point(115, 245);
            backButton.Size = new Size(110, 35);
            backButton.Text = "Back";
            backButton.UseVisualStyleBackColor = true;
            backButton.Click += BackButton_Click;
            logoutButton.Location = new Point(295, 245);
            logoutButton.Size = new Size(110, 35);
            logoutButton.Text = "Logout";
            logoutButton.UseVisualStyleBackColor = true;
            logoutButton.Click += LogoutButton_Click;
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(500, 320);
            Controls.Add(titleLabel);
            Controls.Add(typeLabel);
            Controls.Add(mushroomTypeComboBox);
            Controls.Add(quantityLabel);
            Controls.Add(quantityTextBox);
            Controls.Add(checkButton);
            Controls.Add(backButton);
            Controls.Add(logoutButton);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Mushroom";
            ResumeLayout(false);
            PerformLayout();
        }

        private Label titleLabel;
        private Label typeLabel;
        private ComboBox mushroomTypeComboBox;
        private Label quantityLabel;
        private TextBox quantityTextBox;
        private Button checkButton;
        private Button backButton;
        private Button logoutButton;
    }
}
