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
    internal partial class LoginByUserAndPasswordForm : Form
    {
        LoginForm _loginForm;

        public LoginByUserAndPasswordForm(LoginForm loginForm)
        {
            InitializeComponent();
            _loginForm = loginForm;
        }

        private async void loginButton_Click(object sender, EventArgs e)
        {
            try
            {
                string fullUrl = String.IsNullOrEmpty(domainNameTextBox.Text) ? throw new Exception("No domain provided") : domainNameTextBox.Text;
                string login = String.IsNullOrEmpty(loginNameTextBox.Text) ? throw new Exception("No login provided") : loginNameTextBox.Text;
                string password = String.IsNullOrEmpty(passwordTextBox.Text) ? throw new Exception("No password provided") : passwordTextBox.Text;
                string apiServiceKey = await VetmanagerApiGateway.GetApiKeyAsync(fullUrl, login, password);
                VetmanagerApiGateway vetmanagerGateway = ApiGateway(fullUrl, apiServiceKey);
                LoginForm.CreatePetListForm(vetmanagerGateway);
            } catch (Exception ex) { MessageBox.Show("Failed at authorization: " + ex.Message); }
        }

        private VetmanagerApiGateway ApiGateway(string fullUrl, string apiServiceKey)
        {
            try { return new VetmanagerApiGateway(new HttpClient(), fullUrl, VetmanagerApiGateway.DefaultApiServiceName, apiServiceKey); }
            catch (Exception) { throw new Exception("Wasn't able to connect with provided domain ank key"); }
        }
    }
}
