using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Event_Manager.LocationItems
{
    public partial class AddLocation : Form
    {
        public AddLocation()
        {
            InitializeComponent();
        }

        private void button_AddEvent_Click(object sender, EventArgs e)
        {
            var db = new EventContext();
            var notNullBoxes = new[]
            {
                textBox_name,
                textBox_address,
                textBox_AttendeeCapacity,
                textBox_email,
                textBox_vendorCapacity
            };
            if (notNullBoxes.Any(tb => string.IsNullOrWhiteSpace(tb.Text)))
            {
                MessageBox.Show("Must enter a value for Name, Address, Email, Attendee and Vendor Capacity.");
                return;
            }

            db.Locations.Add(new Location(
                textBox_address.Text,
                textBox_name.Text,
                textBox_website.Text,
                textBox_email.Text,
                decimal.Parse(textBox_fee.Text),
                int.Parse(textBox_vendorCapacity.Text),
                int.Parse(textBox_AttendeeCapacity.Text)
                ));

            db.SaveChanges();
            Close();
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
