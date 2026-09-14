using System.ComponentModel.Design;

namespace RSVP_Project;

public partial class RSVPPage : ContentPage
{
	public RSVPPage()
	{
		InitializeComponent();
	}
	private void OnSubmitRSVPClicked(object sender, EventArgs e)
	{
		if (string.IsNullOrWhiteSpace(NameEntry.Text) ||
			string.IsNullOrWhiteSpace(EmailEntry.Text) ||
			string.IsNullOrWhiteSpace(PhoneEntry.Text))
		{
			MessageLabel.Text = "Please fill in all fields.";	
        }
		else
		{
			MessageLabel.Text = $"Thank you for your RSVP, {NameEntry.Text}! We look forward to seeing you at the event.";
        }
    }
	private void OnCancelClicked(object sender, EventArgs e)
	{
		NameEntry.Text = "";
		EmailEntry.Text = "";
		PhoneEntry.Text = "";
		MessageLabel.Text = "";
    }
}