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


        private void ModifyButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                var row = dataGridView1.SelectedRows[0];
                var itemToEdit = row.DataBoundItem;
                if (itemToEdit != null)
                {
                    // Open a new form or display a section in the current form to edit the selected item
                    EditItem(itemToEdit);
                }
            }
            else
            {
                MessageBox.Show("Please select a single row to edit.");
            }
        }

        private void EditItem(object item)
        {
            if (item != null)
            {
                //EntityType entityType = EntityType.Unknown;

                // Determine the type of the entity
                Form editForm = null; // Declare the form variable outside of the if-else statements

                // Determine the type of the entity and instantiate the appropriate form
                if (item is Event)
                {
                    editForm = new Event_Edit_Form(item);
                }
                else if (item is Host)
                {
                    editForm = new Host_Edit_Form(item);
                }
                else if (item is Location)
                {
                    editForm = new Location_Edit_Form(item);
                }
                else if (item is Attendee)
                {
                    editForm = new Attendee_Edit_Form(item);
                }
                else if (item is Presenter)
                {
                    editForm = new Presenter_Edit_Form(item);
                }
                else if (item is Ticket)
                {
                    editForm = new Ticket_Edit_Form(item);
                }
                else if (item is Vendor)
                {
                    editForm = new Vendor_Edit_Form(item);
                }
                else if (item is Employee)
                {
                    editForm = new Employees_Edit_Form(item);
                }
                // ... other types

                // Now show the form if it was instantiated
                editForm?.ShowDialog(this);

                // ... other types

                //Admin_Edit_Form editForm = new Admin_Edit_Form(item);
                //Attendee_Edit_Form editForm = new Attendee_Edit_Form(item);
                //Employees_Edit_Form editForm = new Employees_Edit_Form(item);
                //Ticket_Edit_Form editForm = new Ticket_Edit_Form(item);
                //Host_Edit_Form editForm = new Host_Edit_Form(item);
                //Presenter_Edit_Form editForm = new Presenter_Edit_Form(item);
                //Vendor_Edit_Form editForm = new Vendor_Edit_Form(item);


                //var dialogResult = editForm.ShowDialog(this);

                //if (dialogResult == DialogResult.OK)
                //{
                    //RefreshDataGridView();
                //}
            }
        }



        private void SaveEditedItem(object editedItem)
        {
            var db = new EventContext();
            // Assuming you know the type of the edited item, update it in the corresponding DbSet
            // Example:
            // if (editedItem is YourEntityType editedEntity)
            // {
            //     var originalEntity = db.YourEntitySet.Find(editedEntity.Id);
            //     if (originalEntity != null)
            //     {
            //         ApplyChanges(originalEntity, editedEntity);
            //         db.SaveChanges();
            //         RefreshDataGridView(); // Refresh your DataGridView
            //     }
            // }
        }

    }
}
