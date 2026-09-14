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
            if(UsernameInput.Text == "User1" && PasswordInput.Text == "Password1")
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
            Message.Text = "Create Account Page Loading";
            await Navigation.PushAsync(new AddUser());
        }
    }
}
