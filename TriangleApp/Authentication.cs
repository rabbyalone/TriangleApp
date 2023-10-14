using Microsoft.Identity.Client;

namespace TriangleApp
{
    public partial class Authentication : Form
    {
        string clientId = "8129b46a-d8f1-4938-a68e-1b6c0f5b14a7";
        string tenantId = "26af20c9-e7a6-4331-a214-ad63af35da07";
        string[] scopes = new string[] { "User.Read" };
        public Authentication()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var accessToken = GetAccessTokenAsync().Result;
                if (accessToken == null)
                {
                    label1.Visible = true;
                    label1.Text = "Unable to fetch login details from Microsoft!";
                }
                else
                {
                    new AdvanceTriangle().Show();
                }
            }
            catch (Exception ex)
            {
                label1.Visible = true;
                label1.Text = $"Something went wrong while login {ex.Message}";
            }
        }

        public async Task<string> GetAccessTokenAsync()
        {
            PublicClientApplicationOptions options = new PublicClientApplicationOptions();
            options.ClientId = clientId;
            options.Instance = "https://login.microsoftonline.com/common";
            options.RedirectUri = "https://login.microsoftonline.com/common/oauth2/nativeclient";


            var app = PublicClientApplicationBuilder.CreateWithApplicationOptions(options)
                .WithAuthority(AzureCloudInstance.None, tenantId)
                .Build();

            var accounts = await app.GetAccountsAsync();
            AuthenticationResult result;
            try
            {
                result = await app.AcquireTokenSilent(scopes, accounts.FirstOrDefault())
                    .ExecuteAsync();
            }
            catch (MsalUiRequiredException)
            {
                try
                {
                    var res =
                     Task.Factory.StartNew(async () => await app.AcquireTokenInteractive(scopes).ExecuteAsync());
                    result = res.Result.Result;
                }
                catch (MsalException ex)
                {
                    Console.WriteLine(ex.Message);
                    throw;
                }
            }

            return result.AccessToken;
        }
    }
}
