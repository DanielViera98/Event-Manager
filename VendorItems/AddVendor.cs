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
    public partial class AddVendor : Form
    {
        private EventContext db = new EventContext();
        private Vendor currVendor;
        private Event currEvent;
        public AddVendor(Event e, Vendor v)
        {
            InitializeComponent();
            currVendor = v;
            currEvent = e;

            //Concat welcome label to show event which is being registered
            label_Welcome.Text.Concat(e.Name);
            Location l = db.Locations.Find(e.Location.Address);
            var roomsTaken = db.HasSpace.Select(s => s.RoomID).ToList();
            var tablesTaken = db.HasSpace.Select(s => s.RoomID).ToList();

            //Get list of all non taken rooms and tables, add to combobox
            for (int i = 0; i < l.VendorCapacity; i++)
            {
                if (!tablesTaken.Contains(i))
                    comboBox_Table.Items.Add(i);
            }
            for (int i = 0; i < l.Rooms; i++)
            {
                if (roomsTaken.Count(x => x == i) < l.VendorCapacity/ l.Rooms)    //Assume vendors are evenly spaced
                    comboBox_Room.Items.Add(i);
            }
        }

        private void button_register_Click(object sender, EventArgs e)
        {
            try
            {
                db.HasSpace.Add(new HasSpace
                {
                    RoomID = (int)comboBox_Room.SelectedItem,
                    TableID = (int)comboBox_Table.SelectedItem,
                    Event = db.Events.Find(this.currEvent.EventId),
                    Vendor = db.Vendors.Find(this.currVendor.VendorID)
                });
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"ERROR: {ex.Message}");
            }
            Close();
        }
    }
}
