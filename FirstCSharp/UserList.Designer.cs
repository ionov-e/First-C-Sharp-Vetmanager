namespace FirstCSharp
{
    partial class UserList
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            comboBoxUserList = new ComboBox();
            clientListDataBindingSource = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)clientListDataBindingSource).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(46, 44);
            label1.Name = "label1";
            label1.Size = new Size(44, 15);
            label1.TabIndex = 0;
            label1.Text = "Client: ";
            // 
            // comboBoxUserList
            // 
            comboBoxUserList.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxUserList.FormattingEnabled = true;
            comboBoxUserList.Location = new Point(119, 41);
            comboBoxUserList.Name = "comboBoxUserList";
            comboBoxUserList.Size = new Size(182, 23);
            comboBoxUserList.TabIndex = 1;
            comboBoxUserList.SelectionChangeCommitted += comboBoxUserList_SelectionChangeCommitted;
            // 
            // clientListDataBindingSource
            // 
            clientListDataBindingSource.DataSource = typeof(DTO.ClientListData);
            // 
            // UserList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(comboBoxUserList);
            Controls.Add(label1);
            Name = "UserList";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)clientListDataBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox comboBoxUserList;
        private BindingSource clientListDataBindingSource;
    }
}