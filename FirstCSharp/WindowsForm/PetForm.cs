using FirstCSharp.DTO.RootDataWithModel;
using FirstCSharp.DTO.RootDataWithModel.Model;
using FirstCSharp.DTO.RootDataWithModel.Model.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static FirstCSharp.VetmanagerApiGateway.PathUri;

namespace FirstCSharp.WindowsForm
{
    public partial class PetForm : Form
    {
        private UserList _userList;
        private readonly VetmanagerApiGateway _vetmanagerApiGateway;
        private readonly Pet? _pet;
        private readonly PetType[] _petTypes;
        private readonly int _ownerId;

        public PetForm(UserList userList, VetmanagerApiGateway vetmanagerApiGateway, int ownerId, PetType[] petTypes) : this(userList, vetmanagerApiGateway, ownerId, petTypes, null)
        {
        }

        public PetForm(UserList userList, VetmanagerApiGateway vetmanagerApiGateway, int ownerId, PetType[] petTypes, Pet? pet)
        {
            InitializeComponent();
            _userList = userList;
            _vetmanagerApiGateway = vetmanagerApiGateway;
            _ownerId = ownerId;
            _pet = pet;
            _petTypes = petTypes;
            typeComboBox.DataSource = _petTypes;
            typeComboBox.DisplayMember = "Title";
            typeComboBox.ValueMember = "Id";
            typeComboBox.SelectedItem = null;
            breedComboBox.DisplayMember = "Title";
            breedComboBox.ValueMember = "Id";
            breedComboBox.SelectedItem = null;
            genderComboBox.DataSource = Enum.GetValues(typeof(PetGender));
        }

        private async void saveButton_Click(object sender, EventArgs e)
        {
            dynamic pet = new ExpandoObject();
            pet.owner_id = _ownerId;
            pet.alias = aliasTextBox.Text;
            SetPetTypeIdIfSelected(pet);
            SetBreedIdIfSelected(pet);
            pet.sex = genderComboBox.Text;
            pet.birthday = birthdayDateTimePicker.Value.ToString("yyyy-MM-dd");

            try
            {
                PetDataFromPostRequest petRootData = await _vetmanagerApiGateway.PostModelToApi<PetDataFromPostRequest>(new VetmanagerApiGateway.PathUri(VetmanagerApiGateway.Model.pet), pet);
                _userList.UpdatePetTable();
                this.Close();
            }
            catch (Exception ex) { MessageBox.Show("Exception message: " + ex.Message); }
        }

        private void typeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            breedComboBox.DataSource = GetBreedsForPetType();
        }

        private Breed[] GetBreedsForPetType()
        {
            int? selectedPetTypeIdNullable = GetSelectedPetTypeIdNullable();

            if (selectedPetTypeIdNullable is null)
            {
                return Array.Empty<Breed>();
            }

            int selectedPetTypeId = GetSelectedPetTypeIdOrThrow();

            string selectedOwnerIdAsText = selectedPetTypeId.ToString();

            foreach (PetType petType in _petTypes)
            {
                if (petType.Id == selectedOwnerIdAsText)
                {
                    return petType.Breeds ?? Array.Empty<Breed>();
                }
            }

            return Array.Empty<Breed>();
        }

        private void SetPetTypeIdIfSelected(dynamic pet)
        {
            int? selectedPetTypeId = GetSelectedPetTypeIdNullable();
            if (selectedPetTypeId is not null)
            {
                pet.type_id = selectedPetTypeId;
            }
        }

        private int GetSelectedPetTypeIdOrThrow()
        {
            int? selectedPetTypeIdNullable = GetSelectedPetTypeIdNullable();
            return selectedPetTypeIdNullable ?? throw new Exception("Somehow Pet Type Id was null");

        }

        private int? GetSelectedPetTypeIdNullable()
        {
            string? selectedPetTypeId = typeComboBox.GetItemText(typeComboBox.SelectedValue);
            return (String.IsNullOrEmpty(selectedPetTypeId)) ? null : Int32.Parse(selectedPetTypeId);
        }

        private void SetBreedIdIfSelected(dynamic pet)
        {
            int? selectedBreedId = GetSelectedBreedIdNullable();
            if (selectedBreedId is not null)
            {
                pet.breed_id = selectedBreedId;
            }
        }

        private int? GetSelectedBreedIdNullable()
        {
            string? selectedBreedId = breedComboBox.GetItemText(breedComboBox.SelectedValue);
            return (String.IsNullOrEmpty(selectedBreedId)) ? null : Int32.Parse(selectedBreedId);
        }
    }
}
