namespace RSVP_Project;

public partial class Events : ContentPage
{
	public Events()
	{
		InitializeComponent();
	}

    private void OnBirthdayClicked(object sender, EventArgs e)
    {
        EventDetails.Text =
            "Birthday Dinner\n" +
            "September 18th, 2028 at 7pm\n" +
            "Location: 123 Main Street, Anytown, USA\n" +
            "Hosted by: John Doe\n";
    }

    private void OnWeddingClicked(object sender, EventArgs e)
    {
        EventDetails.Text =
            "Weddinh\n" +
            "September 21th, 2028 at 3pm\n" +
            "Location: 123 Main Street, Anytown, USA\n" +
            "Hosted by: Jane Doe\n";
    }
    private async void OnAddEventClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new AddEvent());
    }
    private async void OnRSVPClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new RSVPPage());
    }
    private async void OnLogoutClicked(object sender, EventArgs e)
    {
        await Navigation.PopToRootAsync();
    }
}