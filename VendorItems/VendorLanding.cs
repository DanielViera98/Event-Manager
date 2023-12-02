using Event_Manager.PresenterItems;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Event_Manager.VendorItems
{
    public partial class VendorLanding : Form
    {
        //Initialize class variables
        private EventContext db = new EventContext();
        private DbSet<EventContext.VendorView> view;
        private BindingList<object> items;
        private Vendor currVendor;
        public VendorLanding(Vendor vendor)
        {
            currVendor = vendor;
            view = db.VendorViews;
            InitializeComponent();
            refresh_view();
        }
        private void refresh_view()
        {
            //Get all information to be shown from view and display to user
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
                s.VendorCapacity,
                s.AttendeeCapacity,
                s.HostName,
                s.HostWebsite,
                s.HostEmail,
                s.HostType,
                TicketsBought = s.TicketCount
            }).Where(s => s.EventID != null).ToList();
            items = new BindingList<object>(temp.Cast<object>().ToList());
            dataGridView_Vendors.DataSource = items;
        }
        private void button_register_Click(object sender, EventArgs e)
        {
            //If nothing is selected, throw message and return
            var selected = dataGridView_Vendors.SelectedRows;
            if (selected.Count <= 0)
            {
                MessageBox.Show("Must Select an Event.");
                return;
            }

            //Add vendor to all events selected
            for (int i = 0; i < selected.Count; i++)
            {
                var temp2 = (Guid)dataGridView_Vendors.SelectedRows[i].Cells[0].Value;
                var temp = db.Events.Where(s => s.EventId == (Guid)dataGridView_Vendors.SelectedRows[i].Cells[0].Value)
                    .Include(e => e.Location)
                    .First();
                if (temp != null)
                {
                    var addVendor = new AddVendor(temp, currVendor);
                    addVendor.Show();
                }
                else
                    MessageBox.Show("Error finding Event");
            }
        }
    }
}
