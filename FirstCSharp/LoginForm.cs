using FirstCSharp.DTO;

namespace FirstCSharp
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private async void loginButton_Click(object sender, EventArgs e)
        {
            string domainName = String.IsNullOrEmpty(textBoxDomainName.Text) ? "three" : textBoxDomainName.Text;
            string apiKey = String.IsNullOrEmpty(textBoxApiKey.Text) ? "87f81046a057ec76d9e2299113d24052" : textBoxApiKey.Text;
            VetmanagerApiGateway vetmanagerGateway = new(new HttpClient(), domainName, apiKey, false);


            ////string responseAsString = response[0]?.ClientTypeData?.Title ?? "Failed";
            ////string responseAsString = response[0]?.Street?.Title ?? "Failed";

            Client[] response = await vetmanagerGateway.GetAllClients();
            string responseAsString = response[0]?.City?.Title ?? "Failed";

            //Client response = await vetmanagerGateway.GetClient(1);
            //string responseAsString = response.City?.Title ?? "Failed";

            MessageBox.Show(responseAsString);
        }
    }
}