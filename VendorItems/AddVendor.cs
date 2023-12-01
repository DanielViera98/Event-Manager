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
        EventContext db = new EventContext();
        Vendor currVendor;
        Event currEvent;
        public AddVendor(Event e, Vendor v)
        {
            InitializeComponent();
            currVendor = v;
            currEvent = e;

            label_Welcome.Text.Concat(e.Name);
            Location l = db.Locations.Find(e.Location);

            for (int i = 0; i < 20; i++)
            {
                comboBox_Room.Items.Add(i);
                comboBox_Table.Items.Add(i);
            }
        }

        private void button_register_Click(object sender, EventArgs e)
        {
            int roomID = (int)comboBox_Room.SelectedItem;
            int tableID = (int)comboBox_Table.SelectedItem;
            Event ev = db.Events.Find(this.currEvent.EventId);
            db.HasSpace.Add(new HasSpace
            {
                RoomID = (int)comboBox_Room.SelectedItem,
                TableID = (int)comboBox_Table.SelectedItem,
                Event = db.Events.Find(this.currEvent.EventId),
                Vendor = db.Vendors.Find(this.currVendor.VendorID)
            });
            db.SaveChanges();
            Close();
        }
    }
}
