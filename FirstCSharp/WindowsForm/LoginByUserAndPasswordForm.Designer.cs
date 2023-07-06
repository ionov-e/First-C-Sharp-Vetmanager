namespace VetmanagerFormControl.WindowsForm
{
    partial class LoginByUserAndPasswordForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            fullUrlLabel = new Label();
            loginLabel = new Label();
            passwordLabel = new Label();
            fullUrlTextBox = new TextBox();
            loginNameTextBox = new TextBox();
            passwordTextBox = new TextBox();
            loginButton = new Button();
            SuspendLayout();
            // 
            // fullUrlLabel
            // 
            fullUrlLabel.AutoSize = true;
            fullUrlLabel.Location = new Point(37, 31);
            fullUrlLabel.Name = "fullUrlLabel";
            fullUrlLabel.Size = new Size(44, 15);
            fullUrlLabel.TabIndex = 0;
            fullUrlLabel.Text = "Full Url";
            // 
            // loginLabel
            // 
            loginLabel.AutoSize = true;
            loginLabel.Location = new Point(37, 103);
            loginLabel.Name = "loginLabel";
            loginLabel.Size = new Size(37, 15);
            loginLabel.TabIndex = 1;
            loginLabel.Text = "Login";
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Location = new Point(37, 183);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(57, 15);
            passwordLabel.TabIndex = 2;
            passwordLabel.Text = "Password";
            // 
            // fullUrlTextBox
            // 
            fullUrlTextBox.Location = new Point(37, 61);
            fullUrlTextBox.Name = "fullUrlTextBox";
            fullUrlTextBox.Size = new Size(212, 23);
            fullUrlTextBox.TabIndex = 3;
            // 
            // loginNameTextBox
            // 
            loginNameTextBox.Location = new Point(37, 134);
            loginNameTextBox.Name = "loginNameTextBox";
            loginNameTextBox.Size = new Size(212, 23);
            loginNameTextBox.TabIndex = 4;
            // 
            // passwordTextBox
            // 
            passwordTextBox.Location = new Point(37, 214);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(212, 23);
            passwordTextBox.TabIndex = 5;
            // 
            // loginButton
            // 
            loginButton.Location = new Point(162, 267);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(87, 23);
            loginButton.TabIndex = 6;
            loginButton.Text = "Login";
            loginButton.UseVisualStyleBackColor = true;
            loginButton.Click += loginButton_Click;
            // 
            // LoginByUserAndPasswordForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(290, 319);
            Controls.Add(loginButton);
            Controls.Add(passwordTextBox);
            Controls.Add(loginNameTextBox);
            Controls.Add(fullUrlTextBox);
            Controls.Add(passwordLabel);
            Controls.Add(loginLabel);
            Controls.Add(fullUrlLabel);
            Name = "LoginByUserAndPasswordForm";
            Text = "Login By User And Password";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label fullUrlLabel;
        private Label loginLabel;
        private Label passwordLabel;
        private TextBox fullUrlTextBox;
        private TextBox loginNameTextBox;
        private TextBox passwordTextBox;
        private Button loginButton;
    }
}