using FirstCSharp.DTO.RootDataWithModel.Model;

namespace FirstCSharp.WindowsForm
{
    internal partial class LoginForm : Form
    {
        public LoginForm() { InitializeComponent(); }
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
            LoginByUserAndPasswordForm form = new(this);
            form.Show();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            try
            {
                string domainName = String.IsNullOrEmpty(textBoxDomainName.Text) ? "three" : textBoxDomainName.Text;
                string apiKey = String.IsNullOrEmpty(textBoxApiKey.Text) ? "87f81046a057ec76d9e2299113d24052" : textBoxApiKey.Text;
                VetmanagerApiGateway vetmanagerGateway = ApiGateway(domainName, apiKey);
                CreatePetListForm(vetmanagerGateway);
            } catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        private VetmanagerApiGateway ApiGateway(string domainName, string apiKey)
        {
            try { return new VetmanagerApiGateway(new HttpClient(), domainName, apiKey); }
            catch (Exception) { throw new Exception("Wasn't able to connect with provided domain ank key"); }
        }
    }
}