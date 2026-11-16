namespace lab2
{
    partial class ChooseForm
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
            bicycleButton = new Button();
            mushroomButton = new Button();
            SuspendLayout();
            titleLabel.AutoSize = true;
            titleLabel.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            titleLabel.Location = new Point(175, 45);
            titleLabel.Text = "Choose an activity";
            bicycleButton.Location = new Point(105, 130);
            bicycleButton.Size = new Size(125, 45);
            bicycleButton.Text = "Bicycle";
            bicycleButton.UseVisualStyleBackColor = true;
            bicycleButton.Click += BicycleButton_Click;
            mushroomButton.Location = new Point(270, 130);
            mushroomButton.Size = new Size(125, 45);
            mushroomButton.Text = "Mushroom";
            mushroomButton.UseVisualStyleBackColor = true;
            mushroomButton.Click += MushroomButton_Click;
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(500, 250);
            Controls.Add(titleLabel);
            Controls.Add(bicycleButton);
            Controls.Add(mushroomButton);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Choose";
            ResumeLayout(false);
            PerformLayout();
        }

        private Label titleLabel;
        private Button bicycleButton;
        private Button mushroomButton;
    }
}
