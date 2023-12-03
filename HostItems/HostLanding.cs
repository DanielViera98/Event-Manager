using Event_Manager.HostItems;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using System.Data;

namespace Event_Manager
{
    public partial class HostLanding : Form
    {
        //Initialize class variables
        private EventContext db = new EventContext();
        private DbSet<EventContext.HostView> view;
        private BindingList<object> items;
        private Host hostUser;
        public HostLanding(Host host)
        {
            hostUser = host;
            view = db.HostViews;
            InitializeComponent();
            refresh_view();
        }

        private void button_RegisterEvent_Click(object sender, EventArgs e)
        {
            var newEvent = new AddEvent(hostUser);
            newEvent.Show();
        }

        private void button_Refresh_Click(object sender, EventArgs e)
        {
            refresh_view();
        }

        private void refresh_view()
        {
            dataGridView_Events.Rows.Clear();
            //Get all the desired items in the view and present it to the user
            if (!checkBox_ViewHosted.Checked)
            {
                var temp = view.Select(s => new
                {
                    s.EventID,
                    EventName = s.eventname,
                    EventDescription = s.eventdescription,
                    s.StartDate,
                    s.EndDate,
                    EventWebsite = s.eventwebsite,
                    Location = s.LocationName,
                    s.Address,
                    s.LocationWebsite,
                    s.LocationEmail,
                    s.RentalFee,
                    s.VendorCapacity,
                    s.Rooms,
                    s.AttendeeCapacity,
                    s.HostName,
                    s.HostWebsite,
                    s.HostEmail,
                    s.HostPhoneNumber,
                    s.RepresentativeName,
                    s.RepresentativePhone,
                    s.HostID
                }).Where(s => s.EventID != null).ToList();
                items = new BindingList<object>(temp.Cast<object>().ToList());
                dataGridView_Events.DataSource = items;
            }
            else
            {
                var temp = view.Select(s => new
                {
                    s.EventID,
                    EventName = s.eventname,
                    EventDescription = s.eventdescription,
                    s.StartDate,
                    s.EndDate,
                    EventWebsite = s.eventwebsite,
                    Location = s.LocationName,
                    s.Address,
                    s.LocationWebsite,
                    s.LocationEmail,
                    s.RentalFee,
                    s.VendorCapacity,
                    s.Rooms,
                    s.AttendeeCapacity,
                    s.HostName,
                    s.HostWebsite,
                    s.HostEmail,
                    s.HostPhoneNumber,
                    s.RepresentativeName,
                    s.RepresentativePhone,
                    s.HostID
                }).Where(s => s.EventID != null && (s.HostID == null || s.HostID == hostUser.HostID)).ToList(); 
                //The above where statements gets all rows where eventID is not null and where hostid matches the user's hostid
                items = new BindingList<object>(temp.Cast<object>().ToList());
                dataGridView_Events.DataSource = items;
            }
        }

        private void button_DeleteEvent_Click(object sender, EventArgs e)
        {
            //Get selection of rows
            var selection = dataGridView_Events.SelectedRows;
            try
            {
                //If nothing selected, throw ex.
                if (selection.Count == 0)
                    throw new Exception("Must select a row");

                //check if any row selected has an event not owned by host, if so throw ex. Otherwise delete the event from the database.
                foreach (DataGridViewRow row in selection)
                {
                    //Find the event associated with the row
                    Event foundEvent = db.Events.Find((Guid)row.Cells["EventID"].Value);

                    //check if the event is hosted by the user.
                    if (db.HostedBy.Where(s => s.Event == foundEvent && s.Host == hostUser).Count() == 0)
                        throw new Exception("Cannot Delete an Event you are not Hosting.");
                    db.Events.Remove(foundEvent);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            db.SaveChanges();
            refresh_view();
        }

        private void checkBox_ViewHosted_CheckedChanged(object sender, EventArgs e)
        {
            refresh_view();
        }
    }
}
