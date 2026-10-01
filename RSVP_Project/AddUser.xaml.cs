using RSVP_Project.Models;
using RSVP_Project.Database;
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
			string dbPath = Path.Combine(FileSystem.AppDataDirectory, "rsvp.db");
            RSVP_Project.Database.Database database = new RSVP_Project.Database.Database(dbPath);

            //New user object
            User user = new User();
            user.Name = NameInput.Text;
			user.Email = EmailInput.Text;
			user.Username = UsernameInput.Text;
			user.Password = PasswordInput.Text;

			database.AddUser(user);

			Message.Text = "User added Successfully";
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