using FirstCSharp.DTO;

namespace FirstCSharp
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private async void loginButton_Click(object sender, EventArgs e)
        {
            string domainName = String.IsNullOrEmpty(textBoxDomainName.Text) ? "three" : textBoxDomainName.Text;
            string apiKey = String.IsNullOrEmpty(textBoxApiKey.Text) ? "87f81046a057ec76d9e2299113d24052" : textBoxApiKey.Text;
            VetmanagerApiGateway vetmanagerGateway = new(new HttpClient(), domainName, apiKey, false);
            Client[] response = await vetmanagerGateway.GetAllClients();
            UserList form = new(vetmanagerGateway, response);
            form.Show();
        }
    }
}