using RSVP_Project.Models;
namespace RSVP_Project;

public partial class Events : ContentPage
{
	public Events()
	{
		InitializeComponent();
	}

    protected override void OnAppearing()
    {
        base.OnAppearing(); // Load events from the database and display them in the UI
        LoadEvents();
    }

    private void LoadEvents() 
    {
        string dbPath = Path.Combine(FileSystem.AppDataDirectory, "rsvp.db");

        RSVP_Project.Database.Database database = new RSVP_Project.Database.Database(dbPath);

        var events = database.GetEvents();

        AllEventsLayout.Children.Clear();

        foreach (var eventItem in events)
        {
            var eventButton = new Button
            {
                Text = eventItem.EventName,
                CommandParameter = eventItem.EventId 
            };
            eventButton.Clicked += OnEventClicked;
            AllEventsLayout.Children.Add(eventButton);
        }
    }

    private void OnEventClicked(object? sender, EventArgs e)
    {
        if (sender is not Button button) return;
        int eventId = (int)button.CommandParameter;
        string dbPath = Path.Combine(FileSystem.AppDataDirectory, "rsvp.db");
        RSVP_Project.Database.Database database = new RSVP_Project.Database.Database(dbPath);
        var selectedEvent = database.GetEvents().FirstOrDefault(ev => ev.EventId == eventId);
        if (selectedEvent != null)
        {
            EventDetails.Text =
                $"{selectedEvent.EventName}\n" +
                $"{selectedEvent.Date} at {selectedEvent.Time}\n" +
                $"Location: {selectedEvent.Location}\n";
        }
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