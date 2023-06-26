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

        private async void comboBoxUserList_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string selectedOwnerId = comboBoxUserList.GetItemText(comboBoxUserList.SelectedValue) ?? throw new Exception("WTF? selectedOwnerId somehow is null");
            Pet[] pets = await _vetmanagerApiGateway.GetPetByClientId(Int32.Parse(selectedOwnerId));
            this.petDataGridView.DataSource = pets;
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            PetForm form = new(_vetmanagerApiGateway);
            form.Show();
        }
    }
}
