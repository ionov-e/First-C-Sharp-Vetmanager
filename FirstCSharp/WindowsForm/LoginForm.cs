using FirstCSharp.DTO.RootDataWithModel.Model;

namespace FirstCSharp.WindowsForm
{
    internal partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            TryToRunUserFormWithLastSuccessfulConnection();
        }

        private static void TryToRunUserFormWithLastSuccessfulConnection()
        {
            try
            {
                var credentials = ApiTokenCredentials.FromSaved();
                if (credentials == null) { return; }
                VetmanagerApiGateway vetmanagerGateway = new VetmanagerApiGateway(new HttpClient(), credentials);
                CreatePetListForm(vetmanagerGateway);
            }
            catch (Exception) { };
        }

        public static async void CreatePetListForm(VetmanagerApiGateway vetmanagerApiGateway)
        {
            try
            {
                Client[] response = await vetmanagerApiGateway.GetAllClients();
                UserList form = new(vetmanagerApiGateway, response);
                form.Show();
            }
            catch (Exception ex) { MessageBox.Show("Unexpected error has happened: " + ex.Message); }
        }

        private void differentLoginButton_Click(object sender, EventArgs e)
        {
            new LoginByUserAndPasswordForm().Show();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            try
            {
                string fullUrl = String.IsNullOrEmpty(textBoxFullUrl.Text) ? throw new Exception("Full url field is empty") : textBoxFullUrl.Text;
                string apiKey = String.IsNullOrEmpty(textBoxApiKey.Text) ? throw new Exception("API Key field is empty") : textBoxApiKey.Text;
                VetmanagerApiGateway vetmanagerGateway = ApiGateway(fullUrl, apiKey);
                CreatePetListForm(vetmanagerGateway);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        private VetmanagerApiGateway ApiGateway(string domainName, string apiKey)
        {
            try { return new VetmanagerApiGateway(new HttpClient(), domainName, apiKey); }
            catch (Exception) { throw new Exception("Wasn't able to connect with provided domain ank key"); }
        }
    }
}