using FirstCSharp.DTO.RootDataWithModel;
using FirstCSharp.DTO.RootDataWithModel.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static FirstCSharp.VetmanagerApiGateway;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FirstCSharp.WindowsForm
{
    public partial class UserList : Form
    {
        private readonly VetmanagerApiGateway _vetmanagerApiGateway;
        private readonly Client[] _clients;

        public UserList(VetmanagerApiGateway vetmanagerApiGateway, Client[] clients)
        {
            InitializeComponent();
            _vetmanagerApiGateway = vetmanagerApiGateway;
            _clients = clients;
            comboBoxUserList.DataSource = _clients;
            comboBoxUserList.DisplayMember = "FullName";
            comboBoxUserList.ValueMember = "Id";
            comboBoxUserList.SelectedItem = null;
            createButton.Enabled = false;
            changeEditAndDeleteButtonStates(false);
        }

        private void comboBoxUserList_SelectionChangeCommitted(object sender, EventArgs e)
        {
            UpdatePetTable();
            createButton.Enabled = IsClientPicked();
            changeEditAndDeleteButtonStates(false);
        }

        public async void UpdatePetTable()
        {
            Pet[] pets = await _vetmanagerApiGateway.GetPetByClientId(GetClientIdOrThrow());
            this.petDataGridView.DataSource = pets;
        }

        private async void createButton_Click(object sender, EventArgs e)
        {
            if (!IsClientPicked())
            {
                MessageBox.Show("Firstly, pick client from the list to create a pet");
                return;
            }

            PetType[] petTypes = await _vetmanagerApiGateway.GetAllPetTypes();
            PetForm form = new(this, _vetmanagerApiGateway, GetClientIdOrThrow(), petTypes);
            form.Show();
        }

        private bool IsClientPicked()
        {
            return (GetClientIdAsNullableInt() != null);
        }

        private int GetClientIdOrThrow()
        {
            int? clientIdNullable = GetClientIdAsNullableInt();
            return clientIdNullable ?? throw new Exception("Somehow client id was null");
        }

        private int? GetClientIdAsNullableInt()
        {
            string? selectedOwnerId = comboBoxUserList.GetItemText(comboBoxUserList.SelectedValue);
            return (String.IsNullOrEmpty(selectedOwnerId)) ? null : Int32.Parse(selectedOwnerId);
        }

        private bool IsPetPicked()
        {
            return (GetPetIdAsNullableInt() != null);
        }

        private int GetPetIdOrThrow()
        {
            int? petIdNullable = GetPetIdAsNullableInt();
            return petIdNullable ?? throw new Exception("Somehow pet id was null");
        }

        private int? GetPetIdAsNullableInt()
        {
            if (petDataGridView.SelectedRows.Count  == 0) return null;

            string? selectedPetId = petDataGridView.SelectedRows[0].Cells[0].Value.ToString();      //TODO
            return (String.IsNullOrEmpty(selectedPetId)) ? null : Int32.Parse(selectedPetId);
        }

        private void petDataGridView_SelectionChanged(object sender, EventArgs e)
        {
             changeEditAndDeleteButtonStates(IsPetPicked());
        }

        private void changeEditAndDeleteButtonStates(bool boolean)
        {
            editButton.Enabled = boolean;
            deleteButton.Enabled = boolean;
        }
    }
}
