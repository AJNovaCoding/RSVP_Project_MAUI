using System.Net.Http.Headers;
using System.Text;

namespace RSVP_Project
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private async void OnLoginClicked(object? sender, EventArgs e)
        {
            string username = UsernameInput.Text;
            string password = PasswordInput.Text;

            string credentials = $"{username}:{password}";
            string encodedCredentials = Convert.ToBase64String(Encoding.UTF8.GetBytes(credentials));

            using HttpClient client = new HttpClient();

            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", encodedCredentials);

            try
            {
                HttpResponseMessage response = await client.GetAsync("http://localhost:5240/api/Auth/login");

                if (response.IsSuccessStatusCode)
                {
                    Message.Text = "Login Successful";
                    await Navigation.PushAsync(new Events());
                }
                else
                {
                    Message.Text = "Invalid Username or Password, Please try again";
                }
            }

            catch(Exception)
            {
                Message.Text = "Unable to connect to Login Service";
            }

        }
        private async void OnGuestClicked(object? sender, EventArgs e)
        {
            Message.Text = "Continuing As Guest...";
            await Navigation.PushAsync(new Events());
        }
        private async void OnCreateClicked(object? sender, EventArgs e)
        {
            await Navigation.PushAsync(new AddUser());
        }
    }
}
