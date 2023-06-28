using FirstCSharp.DTO.RootDataWithModel;
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
        }

        private void comboBoxUserList_SelectionChangeCommitted(object sender, EventArgs e)
        {
            updatePetTable();
        }

        public async void updatePetTable()
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
    }
}
