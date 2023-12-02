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
            //Check if name empty
            if (string.IsNullOrWhiteSpace(textBox_Name.Text))
            {
                MessageBox.Show("Must enter a value for Event name, start date, and end date.");
                return;
            }
            //Get address, grab the view corresponding
            var selectedLocation = ((Location)comboBox_Locations.SelectedItem).Address;
            var viewFound = view.Where(s => s.Address == selectedLocation);
            if (viewFound == null)
            {
                MessageBox.Show("Selected location does not exist in the database.");
                return;
            }

            //Create an event based on the location address. Separated with view to avoid tampering. 
            Event addedEvent = new Event(
                textBox_Name.Text,
                richTextBox_Description.Text,
                dateTimePicker_Start.Value.ToUniversalTime(),
                dateTimePicker_End.Value.ToUniversalTime(),
                textBox_Website.Text,
                db.Locations.Find(selectedLocation));

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
