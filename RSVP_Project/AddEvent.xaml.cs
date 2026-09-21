using RSVP_Project.Models;
using RSVP_Project.Database;

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
            //Database Path
            string dbPath = Path.Combine(FileSystem.AppDataDirectory, "rsvp.db");

            //Save to Database
            Database database = new Database(dbPath); // Updated to use the correct class
            EventItem newEvent = new EventItem();

            newEvent.EventName = eventName;
            newEvent.Date = eventDate;
            newEvent.Location = eventLocation;

            database.AddEvent(newEvent);

            Message.Text = "Event added successfully!";
        }
    }
    private void OnCancelClicked(object sender, EventArgs e)
    {
        // Navigate back to the previous page (e.g., MainPage)
        Navigation.PopAsync();
    }
}