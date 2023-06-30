namespace FirstCSharp.WindowsForm
{
    internal partial class LoginByUserAndPasswordForm : Form
    {
        public LoginByUserAndPasswordForm()
        {
            InitializeComponent();
        }

        private async void loginButton_Click(object sender, EventArgs e)
        {
            try
            {
                string fullUrl = String.IsNullOrEmpty(domainNameTextBox.Text) ? throw new Exception("No domain provided") : domainNameTextBox.Text;
                string login = String.IsNullOrEmpty(loginNameTextBox.Text) ? throw new Exception("No login provided") : loginNameTextBox.Text;
                string password = String.IsNullOrEmpty(passwordTextBox.Text) ? throw new Exception("No password provided") : passwordTextBox.Text;
                ApiTokenCredentials credentials = await VetmanagerApiGateway.GetApiTokenCredentials(fullUrl, login, password, ApiTokenCredentials.DefaultApiApplicationName);
                VetmanagerApiGateway vetmanagerGateway = new VetmanagerApiGateway(new HttpClient(), credentials);
                LoginForm.CreatePetListForm(vetmanagerGateway);
                credentials.Save();
            }
            catch (Exception ex) { MessageBox.Show("Failed at authorization: " + ex.Message); }
        }
    }
}
