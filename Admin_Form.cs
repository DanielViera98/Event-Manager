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

namespace Event_Manager
{
    public partial class Admin_Form : Form
    {
        public Admin_Form()
        {
            InitializeComponent();
        }


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void EventsButton_Click(object sender, EventArgs e)
        {
            var db = new EventContext();
            var events = db.Events.ToList();
            dataGridView1.DataSource = events;
        }

        private void HostsButton_Click(object sender, EventArgs e)
        {
            var db = new EventContext();
            var hosts = db.Hosts.ToList();
            dataGridView1.DataSource = hosts;
        }

        private void AttendeesButton_Click(object sender, EventArgs e)
        {
            var db = new EventContext();
            var attendees = db.Attendees.ToList();
            dataGridView1.DataSource = attendees;
        }


        private void LocationsButton_Click(object sender, EventArgs e)
        {
            var db = new EventContext();
            var locations = db.Locations.ToList();
            dataGridView1.DataSource = locations;

            //db.SaveChanges();
            //Close();
        }

        private void PresentersButton_Click(object sender, EventArgs e)
        {
            var db = new EventContext();
            var presenters = db.Presenters.ToList();
            dataGridView1.DataSource = presenters;
        }

        private void VendorsButton_Click(object sender, EventArgs e)
        {
            var db = new EventContext();
            var vendors = db.Vendors.ToList();
            dataGridView1.DataSource = vendors;
        }

        private void EmployeesButton_Click(object sender, EventArgs e)
        {
            var db = new EventContext();
            var employees = db.Employees.ToList();
            dataGridView1.DataSource = employees;
        }

        private void TicketsButton_Click(object sender, EventArgs e)
        {
            var db = new EventContext();
            var tickets = db.Tickets.ToList();
            dataGridView1.DataSource = tickets;
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Are you sure you want to delete the selected rows?", "Confirm Deletion", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    var db = new EventContext();
                    foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                    {
                        var itemToDelete = row.DataBoundItem;
                        if (itemToDelete != null)
                        {
                            DeleteEntity(db, itemToDelete);
                        }
                    }

                    db.SaveChanges();
                    //RefreshDataGridView(); // Refresh your DataGridView
                }
            }
            else
            {
                MessageBox.Show("Please select at least one row to delete.");
            }
        }

        private void DeleteEntity(EventContext db, object entity)
        {
            // Example: Check the type of entity and remove it from the corresponding DbSet
            if (entity is Event)
            {
                db.Events.Remove(entity as Event);
            }
            else if (entity is Host)
            {
                db.Hosts.Remove(entity as Host);
            }
            else if (entity is Attendee)
            {
                db.Attendees.Remove(entity as Attendee);
            }
            else if (entity is Employee)
            {
                db.Employees.Remove(entity as Employee);
            }
            else if (entity is Location)
            {
                db.Locations.Remove(entity as Location);
            }
            else if (entity is Vendor)
            {
                db.Vendors.Remove(entity as Vendor);
            }
            else if (entity is Presenter)
            {
                db.Presenters.Remove(entity as Presenter);
            }
            else if (entity is Ticket)
            {
                db.Tickets.Remove(entity as Ticket);
            }
            // ... handle other entity types similarly
            // else if (entity is AnotherEntityType) { ... }
        }

        private void ApplyChanges<T>(T originalItem, T updatedItem) where T : class
        {
            var properties = typeof(T).GetProperties();
            foreach (var property in properties)
            {
                var originalValue = property.GetValue(originalItem);
                var updatedValue = property.GetValue(updatedItem);

                if (!Equals(originalValue, updatedValue))
                {
                    property.SetValue(originalItem, updatedValue);
                }
            }
        }


        private void ModifyButton_Click(object sender, EventArgs e)
        {
        }
    }
}
