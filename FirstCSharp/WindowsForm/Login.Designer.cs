namespace FirstCSharp
{
    partial class Login
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
            textBoxDomainName = new TextBox();
            labelDomainName = new Label();
            labelApiKey = new Label();
            textBoxApiKey = new TextBox();
            SuspendLayout();
            // 
            // loginButton
            // 
            loginButton.Location = new Point(167, 172);
            loginButton.Margin = new Padding(3, 2, 3, 2);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(84, 22);
            loginButton.TabIndex = 0;
            loginButton.Text = "Login";
            loginButton.UseVisualStyleBackColor = true;
            loginButton.Click += loginButton_Click;
            // 
            // textBoxDomainName
            // 
            textBoxDomainName.Location = new Point(30, 56);
            textBoxDomainName.Margin = new Padding(3, 2, 3, 2);
            textBoxDomainName.Name = "textBoxDomainName";
            textBoxDomainName.Size = new Size(221, 23);
            textBoxDomainName.TabIndex = 1;
            // 
            // labelDomainName
            // 
            labelDomainName.AutoSize = true;
            labelDomainName.Location = new Point(30, 30);
            labelDomainName.Name = "labelDomainName";
            labelDomainName.Size = new Size(84, 15);
            labelDomainName.TabIndex = 2;
            labelDomainName.Text = "Domain Name";
            // 
            // labelApiKey
            // 
            labelApiKey.AutoSize = true;
            labelApiKey.Location = new Point(30, 96);
            labelApiKey.Name = "labelApiKey";
            labelApiKey.Size = new Size(47, 15);
            labelApiKey.TabIndex = 4;
            labelApiKey.Text = "API Key";
            // 
            // textBoxApiKey
            // 
            textBoxApiKey.Location = new Point(30, 122);
            textBoxApiKey.Margin = new Padding(3, 2, 3, 2);
            textBoxApiKey.Name = "textBoxApiKey";
            textBoxApiKey.Size = new Size(221, 23);
            textBoxApiKey.TabIndex = 3;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(283, 225);
            Controls.Add(labelApiKey);
            Controls.Add(textBoxApiKey);
            Controls.Add(labelDomainName);
            Controls.Add(textBoxDomainName);
            Controls.Add(loginButton);
            Margin = new Padding(3, 2, 3, 2);
            Name = "LoginForm";
            Text = "Login Form";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button loginButton;
        private TextBox textBoxDomainName;
        private Label labelDomainName;
        private Label labelApiKey;
        private TextBox textBoxApiKey;
    }
}