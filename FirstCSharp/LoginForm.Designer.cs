namespace FirstCSharp
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
            textBoxDomainName = new TextBox();
            labelDomainName = new Label();
            labelApiKey = new Label();
            textBoxApiKey = new TextBox();
            SuspendLayout();
            // 
            // loginButton
            // 
            loginButton.Location = new Point(385, 260);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(96, 29);
            loginButton.TabIndex = 0;
            loginButton.Text = "Login";
            loginButton.UseVisualStyleBackColor = true;
            // 
            // textBoxDomainName
            // 
            textBoxDomainName.Location = new Point(229, 130);
            textBoxDomainName.Name = "textBoxDomainName";
            textBoxDomainName.Size = new Size(252, 27);
            textBoxDomainName.TabIndex = 1;
            // 
            // labelDomainName
            // 
            labelDomainName.AutoSize = true;
            labelDomainName.Location = new Point(229, 96);
            labelDomainName.Name = "labelDomainName";
            labelDomainName.Size = new Size(106, 20);
            labelDomainName.TabIndex = 2;
            labelDomainName.Text = "Domain Name";
            // 
            // labelApiKey
            // 
            labelApiKey.AutoSize = true;
            labelApiKey.Location = new Point(229, 173);
            labelApiKey.Name = "labelApiKey";
            labelApiKey.Size = new Size(59, 20);
            labelApiKey.TabIndex = 4;
            labelApiKey.Text = "API Key";
            // 
            // textBoxApiKey
            // 
            textBoxApiKey.Location = new Point(229, 207);
            textBoxApiKey.Name = "textBoxApiKey";
            textBoxApiKey.Size = new Size(252, 27);
            textBoxApiKey.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(748, 420);
            Controls.Add(labelApiKey);
            Controls.Add(textBoxApiKey);
            Controls.Add(labelDomainName);
            Controls.Add(textBoxDomainName);
            Controls.Add(loginButton);
            Name = "Form1";
            Text = "Form1";
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