using RSVP_Project.Models;
using RSVP_Project.Database;

namespace RSVP_Project;

public partial class AddEvent : ContentPage
{
    public AddEvent()
    {
        InitializeComponent();
    }
    private async void OnAddEventClicked(object sender, EventArgs e)
    {
        // Get the event details from the input fields
        string eventName = EventName.Text;
        string eventDate = DateInput.Text;
        string eventTime = TimeInput.Text;
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
            //Database Path
            string dbPath = Path.Combine(FileSystem.AppDataDirectory, "rsvp.db");

            //Save to Database
            RSVP_Project.Database.Database database = new RSVP_Project.Database.Database(dbPath); // Updated to use the correct class
            EventItem newEvent = new EventItem();

            newEvent.EventName = eventName;
            newEvent.Date = eventDate;
            newEvent.Time = eventTime;
            newEvent.Location = eventLocation;

            database.AddEvent(newEvent);

            Message.Text = "Event added successfully!";

            await Navigation.PopAsync(); // Navigate back to the previous page (e.g., Events page)
        }
    }
    private void OnCancelClicked(object sender, EventArgs e)
    {
        // Navigate back to the previous page (e.g., MainPage)
        Navigation.PopAsync();
    }
}