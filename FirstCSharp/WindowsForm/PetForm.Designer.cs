namespace FirstCSharp.WindowsForm
{
    partial class PetForm
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
            aliasLabel = new Label();
            typeLabel = new Label();
            breedLabel = new Label();
            genderLabel = new Label();
            birthdayLabel = new Label();
            aliasTextBox = new TextBox();
            typeComboBox = new ComboBox();
            breedComboBox = new ComboBox();
            genderComboBox = new ComboBox();
            birthdayDateTimePicker = new DateTimePicker();
            saveButton = new Button();
            SuspendLayout();
            // 
            // aliasLabel
            // 
            aliasLabel.AutoSize = true;
            aliasLabel.Location = new Point(55, 48);
            aliasLabel.Name = "aliasLabel";
            aliasLabel.Size = new Size(32, 15);
            aliasLabel.TabIndex = 0;
            aliasLabel.Text = "Alias";
            aliasLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // typeLabel
            // 
            typeLabel.AutoSize = true;
            typeLabel.Location = new Point(56, 100);
            typeLabel.Name = "typeLabel";
            typeLabel.Size = new Size(31, 15);
            typeLabel.TabIndex = 1;
            typeLabel.Text = "Type";
            typeLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // breedLabel
            // 
            breedLabel.AutoSize = true;
            breedLabel.Location = new Point(50, 154);
            breedLabel.Name = "breedLabel";
            breedLabel.Size = new Size(37, 15);
            breedLabel.TabIndex = 2;
            breedLabel.Text = "Breed";
            breedLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // genderLabel
            // 
            genderLabel.AutoSize = true;
            genderLabel.Location = new Point(42, 208);
            genderLabel.Name = "genderLabel";
            genderLabel.Size = new Size(45, 15);
            genderLabel.TabIndex = 3;
            genderLabel.Text = "Gender";
            genderLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // birthdayLabel
            // 
            birthdayLabel.AutoSize = true;
            birthdayLabel.Location = new Point(42, 268);
            birthdayLabel.Name = "birthdayLabel";
            birthdayLabel.Size = new Size(51, 15);
            birthdayLabel.TabIndex = 4;
            birthdayLabel.Text = "Birthday";
            birthdayLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // aliasTextBox
            // 
            aliasTextBox.Location = new Point(166, 45);
            aliasTextBox.Name = "aliasTextBox";
            aliasTextBox.Size = new Size(216, 23);
            aliasTextBox.TabIndex = 5;
            // 
            // typeComboBox
            // 
            typeComboBox.FormattingEnabled = true;
            typeComboBox.Location = new Point(166, 97);
            typeComboBox.Name = "typeComboBox";
            typeComboBox.Size = new Size(216, 23);
            typeComboBox.TabIndex = 6;
            typeComboBox.SelectedIndexChanged += typeComboBox_SelectedIndexChanged;
            // 
            // breedComboBox
            // 
            breedComboBox.FormattingEnabled = true;
            breedComboBox.Location = new Point(166, 151);
            breedComboBox.Name = "breedComboBox";
            breedComboBox.Size = new Size(216, 23);
            breedComboBox.TabIndex = 7;
            // 
            // genderComboBox
            // 
            genderComboBox.FormattingEnabled = true;
            genderComboBox.Location = new Point(166, 205);
            genderComboBox.Name = "genderComboBox";
            genderComboBox.Size = new Size(216, 23);
            genderComboBox.TabIndex = 8;
            // 
            // birthdayDateTimePicker
            // 
            birthdayDateTimePicker.Location = new Point(166, 262);
            birthdayDateTimePicker.Name = "birthdayDateTimePicker";
            birthdayDateTimePicker.Size = new Size(216, 23);
            birthdayDateTimePicker.TabIndex = 9;
            // 
            // saveButton
            // 
            saveButton.Location = new Point(307, 330);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(75, 23);
            saveButton.TabIndex = 10;
            saveButton.Text = "Save";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += saveButton_Click;
            // 
            // PetForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(451, 398);
            Controls.Add(saveButton);
            Controls.Add(birthdayDateTimePicker);
            Controls.Add(genderComboBox);
            Controls.Add(breedComboBox);
            Controls.Add(typeComboBox);
            Controls.Add(aliasTextBox);
            Controls.Add(birthdayLabel);
            Controls.Add(genderLabel);
            Controls.Add(breedLabel);
            Controls.Add(typeLabel);
            Controls.Add(aliasLabel);
            Name = "PetForm";
            Text = "Pet Creation";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label aliasLabel;
        private Label typeLabel;
        private Label breedLabel;
        private Label genderLabel;
        private Label birthdayLabel;
        private TextBox aliasTextBox;
        private ComboBox typeComboBox;
        private ComboBox breedComboBox;
        private ComboBox genderComboBox;
        private DateTimePicker birthdayDateTimePicker;
        private Button saveButton;
    }
}