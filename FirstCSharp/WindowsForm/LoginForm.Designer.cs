namespace VetmanagerFormControl.WindowsForm
{
    partial class LoginForm
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
            loginButton = new Button();
            textBoxFullUrl = new TextBox();
            fullUrlName = new Label();
            labelApiKey = new Label();
            textBoxApiKey = new TextBox();
            differentLoginButton = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // loginButton
            // 
            loginButton.Location = new Point(167, 170);
            loginButton.Margin = new Padding(3, 2, 3, 2);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(84, 22);
            loginButton.TabIndex = 0;
            loginButton.Text = "Login";
            loginButton.UseVisualStyleBackColor = true;
            loginButton.Click += loginButton_Click;
            // 
            // textBoxFullUrl
            // 
            textBoxFullUrl.Location = new Point(30, 54);
            textBoxFullUrl.Margin = new Padding(3, 2, 3, 2);
            textBoxFullUrl.Name = "textBoxFullUrl";
            textBoxFullUrl.Size = new Size(221, 23);
            textBoxFullUrl.TabIndex = 1;
            // 
            // fullUrlName
            // 
            fullUrlName.AutoSize = true;
            fullUrlName.Location = new Point(30, 28);
            fullUrlName.Name = "fullUrlName";
            fullUrlName.Size = new Size(44, 15);
            fullUrlName.TabIndex = 2;
            fullUrlName.Text = "Full Url";
            // 
            // labelApiKey
            // 
            labelApiKey.AutoSize = true;
            labelApiKey.Location = new Point(30, 94);
            labelApiKey.Name = "labelApiKey";
            labelApiKey.Size = new Size(47, 15);
            labelApiKey.TabIndex = 4;
            labelApiKey.Text = "API Key";
            // 
            // textBoxApiKey
            // 
            textBoxApiKey.Location = new Point(30, 120);
            textBoxApiKey.Margin = new Padding(3, 2, 3, 2);
            textBoxApiKey.Name = "textBoxApiKey";
            textBoxApiKey.Size = new Size(221, 23);
            textBoxApiKey.TabIndex = 3;
            // 
            // differentLoginButton
            // 
            differentLoginButton.Location = new Point(30, 256);
            differentLoginButton.Name = "differentLoginButton";
            differentLoginButton.Size = new Size(221, 23);
            differentLoginButton.TabIndex = 5;
            differentLoginButton.Text = "Enter by providing User and Password";
            differentLoginButton.UseVisualStyleBackColor = true;
            differentLoginButton.Click += differentLoginButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(130, 237);
            label1.Name = "label1";
            label1.Size = new Size(18, 15);
            label1.TabIndex = 6;
            label1.Text = "or";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(283, 303);
            Controls.Add(label1);
            Controls.Add(differentLoginButton);
            Controls.Add(labelApiKey);
            Controls.Add(textBoxApiKey);
            Controls.Add(fullUrlName);
            Controls.Add(textBoxFullUrl);
            Controls.Add(loginButton);
            Margin = new Padding(3, 2, 3, 2);
            Name = "LoginForm";
            Text = "Login Form";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button loginButton;
        private TextBox textBoxFullUrl;
        private Label fullUrlName;
        private Label labelApiKey;
        private TextBox textBoxApiKey;
        private Button differentLoginButton;
        private Label label1;
    }
}