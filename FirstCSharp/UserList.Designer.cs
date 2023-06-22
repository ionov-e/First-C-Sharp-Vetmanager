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
            petDataGridView = new DataGridView();
            petBindingSource = new BindingSource(components);
            clientListDataBindingSource1 = new BindingSource(components);
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            aliasDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            typeidDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            type = new DataGridViewTextBoxColumn();
            sexDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            birthdayDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            breedidDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            breedDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)clientListDataBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)petDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)petBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)clientListDataBindingSource1).BeginInit();
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
            // petDataGridView
            // 
            petDataGridView.AutoGenerateColumns = false;
            petDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            petDataGridView.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, aliasDataGridViewTextBoxColumn, typeidDataGridViewTextBoxColumn, type, sexDataGridViewTextBoxColumn, birthdayDataGridViewTextBoxColumn, breedidDataGridViewTextBoxColumn, breedDataGridViewTextBoxColumn });
            petDataGridView.DataSource = petBindingSource;
            petDataGridView.Location = new Point(47, 93);
            petDataGridView.Name = "petDataGridView";
            petDataGridView.RowTemplate.Height = 25;
            petDataGridView.Size = new Size(720, 309);
            petDataGridView.TabIndex = 2;
            // 
            // petBindingSource
            // 
            petBindingSource.DataSource = typeof(DTO.Pet);
            // 
            // clientListDataBindingSource1
            // 
            clientListDataBindingSource1.DataSource = typeof(DTO.ClientListData);
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // aliasDataGridViewTextBoxColumn
            // 
            aliasDataGridViewTextBoxColumn.DataPropertyName = "alias";
            aliasDataGridViewTextBoxColumn.HeaderText = "Alias";
            aliasDataGridViewTextBoxColumn.Name = "aliasDataGridViewTextBoxColumn";
            // 
            // typeidDataGridViewTextBoxColumn
            // 
            typeidDataGridViewTextBoxColumn.DataPropertyName = "type_id";
            typeidDataGridViewTextBoxColumn.HeaderText = "Type ID";
            typeidDataGridViewTextBoxColumn.Name = "typeidDataGridViewTextBoxColumn";
            // 
            // type
            // 
            type.DataPropertyName = "type";
            type.HeaderText = "Type";
            type.Name = "type";
            // 
            // sexDataGridViewTextBoxColumn
            // 
            sexDataGridViewTextBoxColumn.DataPropertyName = "sex";
            sexDataGridViewTextBoxColumn.HeaderText = "Gender";
            sexDataGridViewTextBoxColumn.Name = "sexDataGridViewTextBoxColumn";
            // 
            // birthdayDataGridViewTextBoxColumn
            // 
            birthdayDataGridViewTextBoxColumn.DataPropertyName = "birthday";
            birthdayDataGridViewTextBoxColumn.HeaderText = "Birthday";
            birthdayDataGridViewTextBoxColumn.Name = "birthdayDataGridViewTextBoxColumn";
            // 
            // breedidDataGridViewTextBoxColumn
            // 
            breedidDataGridViewTextBoxColumn.DataPropertyName = "breed_id";
            breedidDataGridViewTextBoxColumn.HeaderText = "Breed Id";
            breedidDataGridViewTextBoxColumn.Name = "breedidDataGridViewTextBoxColumn";
            // 
            // breedDataGridViewTextBoxColumn
            // 
            breedDataGridViewTextBoxColumn.DataPropertyName = "breed";
            breedDataGridViewTextBoxColumn.HeaderText = "Breed";
            breedDataGridViewTextBoxColumn.Name = "breedDataGridViewTextBoxColumn";
            // 
            // UserList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(petDataGridView);
            Controls.Add(comboBoxUserList);
            Controls.Add(label1);
            Name = "UserList";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)clientListDataBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)petDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)petBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)clientListDataBindingSource1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox comboBoxUserList;
        private BindingSource clientListDataBindingSource;
        private DataGridView petDataGridView;
        private BindingSource petBindingSource;
        private BindingSource clientListDataBindingSource1;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn aliasDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn typeidDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn type;
        private DataGridViewTextBoxColumn sexDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn birthdayDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn breedidDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn breedDataGridViewTextBoxColumn;
    }
}