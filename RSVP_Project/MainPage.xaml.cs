using RSVP_Project.Models;
using RSVP_Project.Database;

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
            Database database = new Database();
            User user = database.GetUser(UsernameInput.Text, PasswordInput.Text);

            if (user != null)
            {
                Message.Text = "Login Successful";
                await Navigation.PushAsync(new Events());
            }
            else
            {
                Message.Text = "Invalid Username or Password, Please try again";
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
