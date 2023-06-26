using FirstCSharp.DTO.RootDataWithModel;
using FirstCSharp.DTO.RootDataWithModel.Model;

namespace FirstCSharp.WindowsForm
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
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
            labelActionsWithSelected = new Label();
            deleteButton = new Button();
            createButton = new Button();
            editButton = new Button();
            ((System.ComponentModel.ISupportInitialize)clientListDataBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)petDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)petBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)clientListDataBindingSource1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(125, 39);
            label1.Name = "label1";
            label1.Size = new Size(44, 15);
            label1.TabIndex = 0;
            label1.Text = "Client: ";
            // 
            // comboBoxUserList
            // 
            comboBoxUserList.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxUserList.FormattingEnabled = true;
            comboBoxUserList.Location = new Point(184, 36);
            comboBoxUserList.MaxDropDownItems = 10;
            comboBoxUserList.Name = "comboBoxUserList";
            comboBoxUserList.Size = new Size(169, 23);
            comboBoxUserList.TabIndex = 1;
            comboBoxUserList.SelectionChangeCommitted += comboBoxUserList_SelectionChangeCommitted;
            // 
            // clientListDataBindingSource
            // 
            clientListDataBindingSource.DataSource = typeof(BreedListData);
            // 
            // petDataGridView
            // 
            petDataGridView.AllowUserToAddRows = false;
            petDataGridView.AllowUserToDeleteRows = false;
            petDataGridView.AllowUserToResizeColumns = false;
            petDataGridView.AllowUserToResizeRows = false;
            petDataGridView.AutoGenerateColumns = false;
            petDataGridView.BackgroundColor = SystemColors.Control;
            petDataGridView.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            petDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            petDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            petDataGridView.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, aliasDataGridViewTextBoxColumn, breedidDataGridViewTextBoxColumn, typeDataGridViewTextBoxColumn, sexDataGridViewTextBoxColumn, birthdayDataGridViewTextBoxColumn });
            petDataGridView.DataSource = petBindingSource;
            petDataGridView.ImeMode = ImeMode.NoControl;
            petDataGridView.Location = new Point(23, 161);
            petDataGridView.MultiSelect = false;
            petDataGridView.Name = "petDataGridView";
            petDataGridView.ReadOnly = true;
            petDataGridView.RowTemplate.Height = 25;
            petDataGridView.Size = new Size(613, 307);
            petDataGridView.TabIndex = 2;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.MinimumWidth = 4;
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.ReadOnly = true;
            idDataGridViewTextBoxColumn.Width = 50;
            // 
            // aliasDataGridViewTextBoxColumn
            // 
            aliasDataGridViewTextBoxColumn.DataPropertyName = "alias";
            aliasDataGridViewTextBoxColumn.HeaderText = "Alias";
            aliasDataGridViewTextBoxColumn.Name = "aliasDataGridViewTextBoxColumn";
            aliasDataGridViewTextBoxColumn.ReadOnly = true;
            aliasDataGridViewTextBoxColumn.Width = 150;
            // 
            // breedidDataGridViewTextBoxColumn
            // 
            breedidDataGridViewTextBoxColumn.DataPropertyName = "breed";
            breedidDataGridViewTextBoxColumn.HeaderText = "Breed";
            breedidDataGridViewTextBoxColumn.Name = "breedidDataGridViewTextBoxColumn";
            breedidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // typeDataGridViewTextBoxColumn
            // 
            typeDataGridViewTextBoxColumn.DataPropertyName = "type";
            typeDataGridViewTextBoxColumn.HeaderText = "Type";
            typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            typeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sexDataGridViewTextBoxColumn
            // 
            sexDataGridViewTextBoxColumn.DataPropertyName = "sex";
            sexDataGridViewTextBoxColumn.HeaderText = "Gender";
            sexDataGridViewTextBoxColumn.Name = "sexDataGridViewTextBoxColumn";
            sexDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // birthdayDataGridViewTextBoxColumn
            // 
            birthdayDataGridViewTextBoxColumn.DataPropertyName = "birthday";
            birthdayDataGridViewTextBoxColumn.HeaderText = "Birthday";
            birthdayDataGridViewTextBoxColumn.Name = "birthdayDataGridViewTextBoxColumn";
            birthdayDataGridViewTextBoxColumn.ReadOnly = true;
            birthdayDataGridViewTextBoxColumn.Width = 70;
            // 
            // petBindingSource
            // 
            petBindingSource.DataSource = typeof(Pet);
            // 
            // clientListDataBindingSource1
            // 
            clientListDataBindingSource1.DataSource = typeof(BreedListData);
            // 
            // labelActionsWithSelected
            // 
            labelActionsWithSelected.AutoSize = true;
            labelActionsWithSelected.Location = new Point(29, 99);
            labelActionsWithSelected.Name = "labelActionsWithSelected";
            labelActionsWithSelected.Size = new Size(140, 15);
            labelActionsWithSelected.TabIndex = 3;
            labelActionsWithSelected.Text = "Action with selected row:";
            // 
            // deleteButton
            // 
            deleteButton.Location = new Point(278, 95);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(75, 23);
            deleteButton.TabIndex = 5;
            deleteButton.Text = "Delete";
            deleteButton.UseVisualStyleBackColor = true;
            // 
            // createButton
            // 
            createButton.Location = new Point(470, 95);
            createButton.Name = "createButton";
            createButton.Size = new Size(150, 23);
            createButton.TabIndex = 6;
            createButton.Text = "Create New Pet";
            createButton.UseVisualStyleBackColor = true;
            createButton.Click += createButton_Click;
            // 
            // editButton
            // 
            editButton.Location = new Point(184, 95);
            editButton.Name = "editButton";
            editButton.Size = new Size(75, 23);
            editButton.TabIndex = 7;
            editButton.Text = "Edit";
            editButton.UseVisualStyleBackColor = true;
            // 
            // UserList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(661, 489);
            Controls.Add(editButton);
            Controls.Add(createButton);
            Controls.Add(deleteButton);
            Controls.Add(labelActionsWithSelected);
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
        private Label labelActionsWithSelected;
        private Button deleteButton;
        private Button createButton;
        private Button editButton;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn aliasDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn breedidDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn sexDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn birthdayDataGridViewTextBoxColumn;
    }
}