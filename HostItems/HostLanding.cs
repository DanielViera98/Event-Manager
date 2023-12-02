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
            //Get all the desired items in the view and present it to the user
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
                s.RepresentativePhone
            }).Where(s => s.EventID != null).ToList();
            items = new BindingList<object>(temp.Cast<object>().ToList());
            dataGridView_Events.DataSource = items;
        }
    }
}
