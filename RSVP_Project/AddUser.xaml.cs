namespace RSVP_Project;

public partial class AddUser : ContentPage
{
	public AddUser()
	{
		InitializeComponent();
	}

	private void OnCreateClicked(object? sender, EventArgs e)
	{
        if (string.IsNullOrWhiteSpace(NameInput.Text) || 
			string.IsNullOrWhiteSpace(UsernameInput.Text) || 
			string.IsNullOrWhiteSpace(PasswordInput.Text) || 
			string.IsNullOrWhiteSpace(EmailInput.Text) ||
			string.IsNullOrWhiteSpace(PhoneInput.Text))

        {
			Message.Text = "Please fill in all fields";
		}

		else
		{
			Message.Text = "Account Created Successfully";
		}
    }
	private void OnCancelClicked(object? sender, EventArgs e)
	{
		NameInput.Text = "";
		EmailInput.Text = "";
		UsernameInput.Text = "";
		PasswordInput.Text = "";
		PhoneInput.Text = "";
    }
}