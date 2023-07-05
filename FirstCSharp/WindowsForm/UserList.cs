using FirstCSharp.VetmanagerApiGateway;
using FirstCSharp.VetmanagerApiGateway.DTO.ModelContainer.Model;
using FirstCSharp.VetmanagerApiGateway.PathUri;

namespace FirstCSharp.WindowsForm
{
    internal partial class UserList : Form
    {
        private readonly ApiGateway _vetmanagerApiGateway;
        private readonly Client[] _clients;
        private Pet[] _loadedPetsForSelectedClient;

        public UserList(ApiGateway vetmanagerApiGateway, Client[] clients)
        {
            InitializeComponent();
            _vetmanagerApiGateway = vetmanagerApiGateway;
            _clients = clients;
            _loadedPetsForSelectedClient = Array.Empty<Pet>();
            comboBoxUserList.DataSource = _clients;
            comboBoxUserList.DisplayMember = "FullName";
            comboBoxUserList.ValueMember = "Id";
            comboBoxUserList.SelectedItem = null;
            createButton.Enabled = false;
            changeEditAndDeleteButtonStatesTo(false);
        }

        public async void UpdatePetTable()
        {
            _loadedPetsForSelectedClient = await _vetmanagerApiGateway.Pet.ByClientId(GetSelectedClientIdOrThrow());
            petDataGridView.DataSource = _loadedPetsForSelectedClient;
        }

        private void comboBoxUserList_SelectionChangeCommitted(object sender, EventArgs e)
        {
            UpdatePetTable();
            createButton.Enabled = IsClientSelected();
            changeEditAndDeleteButtonStatesTo(false);
        }

        private async void createButton_Click(object sender, EventArgs e)
        {
            if (!IsClientSelected())
            {
                MessageBox.Show("Firstly, pick client from the list to create a pet");
                return;
            }

            PetType[] petTypes = await _vetmanagerApiGateway.PetType.All();
            PetForm form = new(this, _vetmanagerApiGateway, GetSelectedClientIdOrThrow(), petTypes);
            form.Show();
        }


        private async void editButton_Click(object sender, EventArgs e)
        {
            int selectedPetId = GetPetIdOrThrow();
            PetType[] petTypes = await _vetmanagerApiGateway.PetType.All();
            Pet pet = GetPetFromListById(selectedPetId);
            PetForm form = new(this, _vetmanagerApiGateway, GetSelectedClientIdOrThrow(), petTypes, pet);
            form.Show();
        }

        private Pet GetPetFromListById(int petId)
        {
            foreach (Pet pet in _loadedPetsForSelectedClient)
            {
                if (pet.Id == petId) return pet;
            }

            throw new Exception("Couldn't find selected pet id in Pet List");
        }


        private async void deleteButton_Click(object sender, EventArgs e)
        {
            int selectedPetId = GetPetIdOrThrow();
            try
            {
                int deletedPetId = await _vetmanagerApiGateway.DeleteModelFromApi(new PathUri(AccessibleModelPathUri.pet, selectedPetId));
                if (deletedPetId != selectedPetId) { throw new Exception($"Somehow Deleted Pet Id ({deletedPetId}) is different from intended one ({selectedPetId})"); }
                UpdatePetTable();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private bool IsClientSelected()
        {
            return (GetSelectedClientIdAsNullableInt() != null);
        }

        private int GetSelectedClientIdOrThrow()
        {
            int? clientIdNullable = GetSelectedClientIdAsNullableInt();
            return clientIdNullable ?? throw new Exception("Somehow client id was null");
        }

        private int? GetSelectedClientIdAsNullableInt()
        {
            string? selectedOwnerId = comboBoxUserList.GetItemText(comboBoxUserList.SelectedValue);
            return (String.IsNullOrEmpty(selectedOwnerId)) ? null : Int32.Parse(selectedOwnerId);
        }

        private bool IsPetSelected()
        {
            return (GetSelectedPetIdAsNullableInt() != null);
        }

        private int GetPetIdOrThrow()
        {
            int? petIdNullable = GetSelectedPetIdAsNullableInt();
            return petIdNullable ?? throw new Exception("Somehow pet id was null");
        }

        private int? GetSelectedPetIdAsNullableInt()
        {
            if (petDataGridView.SelectedRows.Count == 0) return null;

            int selectedrowindex = petDataGridView.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = petDataGridView.Rows[selectedrowindex];
            string PetIdAsString = selectedRow.Cells["Id"].Value.ToString() ?? throw new Exception("Somehow couldn't read ID Column from Pet Row (Pet List)");
            return Int32.Parse(PetIdAsString);
        }

        private void petDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            changeEditAndDeleteButtonStatesTo(IsPetSelected());
        }

        /// <summary>
        /// Enables or disables Edit and Deletes button. Enables if parameter is true, disables if parameter is false
        /// </summary>
        /// <param name="boolean"></param>
        private void changeEditAndDeleteButtonStatesTo(bool boolean)
        {
            editButton.Enabled = boolean;
            deleteButton.Enabled = boolean;
        }
    }
}
