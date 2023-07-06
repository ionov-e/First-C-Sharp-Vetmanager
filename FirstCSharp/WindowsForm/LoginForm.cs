using VetmanagerApiGateway;
using VetmanagerApiGateway.DTO.ModelContainer.Model;

namespace VetmanagerFormControl.WindowsForm
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
                ApiTokenCredentials credentials = ApiTokenCredentialsExtension.FromSaved();
                if (credentials == null) { return; }
                ApiGateway vetmanagerGateway = new ApiGateway(new HttpClient(), credentials);
                CreatePetListForm(vetmanagerGateway);
            }
            catch (Exception) { };
        }

        public static async void CreatePetListForm(ApiGateway vetmanagerApiGateway)
        {
            try
            {
                Client[] response = await vetmanagerApiGateway.Client.All();
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
                ApiGateway vetmanagerGateway = ApiGateway(fullUrl, apiKey);
                CreatePetListForm(vetmanagerGateway);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        private ApiGateway ApiGateway(string domainName, string apiKey)
        {
            try { return new ApiGateway(new HttpClient(), domainName, apiKey); }
            catch (Exception) { throw new Exception("Wasn't able to connect with provided domain ank key"); }
        }
    }
}