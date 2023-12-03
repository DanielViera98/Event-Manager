using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using System.Data;

namespace Event_Manager.HostItems
{
    public partial class AddEvent : Form
    {
        private EventContext db = new EventContext();
        private Host hostUser;
        private DbSet<EventContext.HostView> view;
        private BindingList<object> items;
        public AddEvent(Host host)
        {
            InitializeComponent();
            hostUser = host;
            view = db.HostViews;

            //Create list of Locations, bind to combobox
            var temp = db.Locations.ToList();
            items = new BindingList<object>(temp.Cast<object>().ToList());
            comboBox_Locations.DataSource = items;
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button_AddEvent_Click(object sender, EventArgs e)
        {
            string selectedLocation;
            IQueryable<EventContext.HostView> viewFound;
            try
            {
                //Check if name empty
                if (string.IsNullOrWhiteSpace(textBox_Name.Text))
                    throw new Exception("Must enter a value for Event name, start date, and end date.");

                //Get address, grab the view corresponding
                selectedLocation = ((Location)comboBox_Locations.SelectedItem).Address;
                viewFound = view.Where(s => s.Address == selectedLocation);
                if (viewFound == null)
                    throw new Exception("Selected location does not exist in the database.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            //Create an event based on the location address. Separated with view to avoid tampering. 
            Event addedEvent = new Event(
                textBox_Name.Text,
                richTextBox_Description.Text,
                dateTimePicker_Start.Value.ToUniversalTime(),
                dateTimePicker_End.Value.ToUniversalTime(),
                textBox_Website.Text,
                db.Locations.Find(selectedLocation),
                hostUser.HostID);

            //Add to events table.
            db.Events.Add(addedEvent);

            //Add new entry to hostedby table
            db.HostedBy.Add(new HostedBy(
                addedEvent,
                db.Hosts.Find(hostUser.HostID)
                ));

            db.SaveChanges();
            Close();
        }
    }
}
