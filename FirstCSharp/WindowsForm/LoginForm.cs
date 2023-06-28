using FirstCSharp.DTO.RootDataWithModel.Model;
using System.Windows.Forms;

namespace FirstCSharp.WindowsForm
{
    internal partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string domainName = String.IsNullOrEmpty(textBoxDomainName.Text) ? "three" : textBoxDomainName.Text;
            string apiKey = String.IsNullOrEmpty(textBoxApiKey.Text) ? "87f81046a057ec76d9e2299113d24052" : textBoxApiKey.Text;

            try { 
                VetmanagerApiGateway vetmanagerGateway = new(new HttpClient(), domainName, apiKey, false);
                CreatePetListForm(vetmanagerGateway);
            } catch (Exception) { MessageBox.Show("Wasn't able to connect with provided domain ank key"); }
        }

        private static async void CreatePetListForm(VetmanagerApiGateway vetmanagerApiGateway)
        {
            try
            {
                Client[] response = await vetmanagerApiGateway.GetAllClients();
                UserList form = new(vetmanagerApiGateway, response);
                form.Show();
            } catch (Exception ex) { MessageBox.Show("Unexpected error has happened: " + ex.Message); }
        }
    }
}