using FirstCSharp.DTO.RootDataWithModel.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirstCSharp.WindowsForm
{
    public partial class PetForm : Form
    {
        private readonly VetmanagerApiGateway _vetmanagerApiGateway;
        private readonly Pet? _pet;

        public PetForm(VetmanagerApiGateway vetmanagerApiGateway, Breed[] breeds, PetType[] petTypes) : this(vetmanagerApiGateway, breeds, petTypes, null)
        {
            InitializeComponent();
        }

        public PetForm(VetmanagerApiGateway vetmanagerApiGateway, Breed[] breeds, PetType[] petTypes, Pet? pet)
        {
            InitializeComponent();
            _vetmanagerApiGateway = vetmanagerApiGateway;
            _pet = pet;
            breedComboBox.DataSource = breeds;
            breedComboBox.DisplayMember = "Title";
            breedComboBox.ValueMember = "Id";
            breedComboBox.SelectedItem = null;
            typeComboBox.DataSource = petTypes;
            typeComboBox.DisplayMember = "Title";
            typeComboBox.ValueMember = "Id";
            typeComboBox.SelectedItem = null;
        }
    }
}
