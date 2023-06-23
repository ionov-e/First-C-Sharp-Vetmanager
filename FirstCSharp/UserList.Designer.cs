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
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            aliasDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            breedidDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            typeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            sexDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            birthdayDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            petBindingSource = new BindingSource(components);
            clientListDataBindingSource1 = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)clientListDataBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)petDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)petBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)clientListDataBindingSource1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(47, 39);
            label1.Name = "label1";
            label1.Size = new Size(44, 15);
            label1.TabIndex = 0;
            label1.Text = "Client: ";
            // 
            // comboBoxUserList
            // 
            comboBoxUserList.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxUserList.FormattingEnabled = true;
            comboBoxUserList.Location = new Point(119, 36);
            comboBoxUserList.MaxDropDownItems = 10;
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
            petDataGridView.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, aliasDataGridViewTextBoxColumn, breedidDataGridViewTextBoxColumn, typeDataGridViewTextBoxColumn, sexDataGridViewTextBoxColumn, birthdayDataGridViewTextBoxColumn });
            petDataGridView.DataSource = petBindingSource;
            petDataGridView.Location = new Point(26, 98);
            petDataGridView.Name = "petDataGridView";
            petDataGridView.RowTemplate.Height = 25;
            petDataGridView.Size = new Size(644, 307);
            petDataGridView.TabIndex = 2;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.MinimumWidth = 4;
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.Width = 50;
            // 
            // aliasDataGridViewTextBoxColumn
            // 
            aliasDataGridViewTextBoxColumn.DataPropertyName = "alias";
            aliasDataGridViewTextBoxColumn.HeaderText = "Alias";
            aliasDataGridViewTextBoxColumn.Name = "aliasDataGridViewTextBoxColumn";
            aliasDataGridViewTextBoxColumn.Width = 150;
            // 
            // breedidDataGridViewTextBoxColumn
            // 
            breedidDataGridViewTextBoxColumn.DataPropertyName = "breed";
            breedidDataGridViewTextBoxColumn.HeaderText = "Breed";
            breedidDataGridViewTextBoxColumn.Name = "breedidDataGridViewTextBoxColumn";
            // 
            // typeDataGridViewTextBoxColumn
            // 
            typeDataGridViewTextBoxColumn.DataPropertyName = "type";
            typeDataGridViewTextBoxColumn.HeaderText = "Type";
            typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
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
            // petBindingSource
            // 
            petBindingSource.DataSource = typeof(DTO.Pet);
            // 
            // clientListDataBindingSource1
            // 
            clientListDataBindingSource1.DataSource = typeof(DTO.ClientListData);
            // 
            // UserList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(691, 428);
            Controls.Add(petDataGridView);
            Controls.Add(comboBoxUserList);
            Controls.Add(label1);
            Name = "UserList";
            Text = "Pet List";
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
        private DataGridViewTextBoxColumn breedDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn aliasDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn breedidDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn sexDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn birthdayDataGridViewTextBoxColumn;
    }
}