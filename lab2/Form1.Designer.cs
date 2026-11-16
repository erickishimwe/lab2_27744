namespace lab2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            titleLabel = new Label();
            usernameLabel = new Label();
            usernameTextBox = new TextBox();
            passwordLabel = new Label();
            passwordTextBox = new TextBox();
            loginButton = new Button();
            SuspendLayout();
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            titleLabel.Location = new Point(157, 35);
            titleLabel.Text = "Bicycle and Mushroom";
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.Location = new Point(70, 105);
            usernameLabel.Text = "Username:";
            // 
            // usernameTextBox
            // 
            usernameTextBox.Location = new Point(170, 102);
            usernameTextBox.Size = new Size(250, 23);
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Location = new Point(70, 150);
            passwordLabel.Text = "Password:";
            // 
            // passwordTextBox
            // 
            passwordTextBox.Location = new Point(170, 147);
            passwordTextBox.PasswordChar = '*';
            passwordTextBox.Size = new Size(250, 23);
            // 
            // loginButton
            // 
            loginButton.Location = new Point(205, 200);
            loginButton.Size = new Size(120, 35);
            loginButton.Text = "Login";
            loginButton.UseVisualStyleBackColor = true;
            loginButton.Click += LoginButton_Click;
            // 
            // Form1
            // 
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(500, 300);
            Controls.Add(titleLabel);
            Controls.Add(usernameLabel);
            Controls.Add(usernameTextBox);
            Controls.Add(passwordLabel);
            Controls.Add(passwordTextBox);
            Controls.Add(loginButton);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        private Label titleLabel;
        private Label usernameLabel;
        private TextBox usernameTextBox;
        private Label passwordLabel;
        private TextBox passwordTextBox;
        private Button loginButton;

        #endregion
    }
}
