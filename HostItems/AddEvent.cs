using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Event_Manager.HostItems
{
    public partial class AddEvent : Form
    {
        public AddEvent()
        {
            InitializeComponent();
            var db = new EventContext();
            var localSource = new BindingList<Location>();
            foreach (var local in db.Locations)
            {
                localSource.Add(local);
            }
            comboBox_Locations.DataSource = localSource;
            
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button_AddEvent_Click(object sender, EventArgs e)
        {
            var db = new EventContext();
            if (string.IsNullOrWhiteSpace(textBox_Name.Text))
            {
                MessageBox.Show("Must enter a value for Event name, start date, and end date.");
                return;
            }
            var selectedLocationId = ((Location)comboBox_Locations.SelectedItem).Address;
            var existingLocation = db.Locations.Find(selectedLocationId);
            if (existingLocation == null)
            {
                MessageBox.Show("Selected location does not exist in the database.");
                return;
            }

            db.Events.Add(new Event(
                textBox_Name.Text,
                richTextBox_Description.Text,
                dateTimePicker_Start.Value.ToUniversalTime(),
                dateTimePicker_End.Value.ToUniversalTime(),
                textBox_Website.Text,
                existingLocation));

            db.SaveChanges();
            Close();
        }
    }
}
