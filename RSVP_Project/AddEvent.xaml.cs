namespace RSVP_Project;

public partial class AddEvent : ContentPage
{
	public AddEvent()
	{
		InitializeComponent();
	}
	private void OnAddEventClicked(object sender, EventArgs e)
	{
		// Get the event details from the input fields
		string eventName = EventName.Text;
		string eventDate = DateInput.Text;
		string eventLocation = LocationInput.Text;

		// Validate the input fields (you can add more validation as needed)
		if (string.IsNullOrWhiteSpace(eventName) ||
			string.IsNullOrWhiteSpace(eventDate) ||
			string.IsNullOrWhiteSpace(eventLocation))
        {
			Message.Text = "Please fill in all fields";
			return;
		}
		else
		{
		   Message.Text = "Event added successfully!";
        }
    }
	private void OnCancelClicked(object sender, EventArgs e)
	{
		// Navigate back to the previous page (e.g., MainPage)
		Navigation.PopAsync();
    }
}