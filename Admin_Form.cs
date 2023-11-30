using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Event_Manager
{
    public partial class Admin_Form : Form
    {
        string entityType = "";
        public Admin_Form()
        {
            InitializeComponent();
            //dataGridView1.AutoGenerateColumns = false;
        }


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void EventsButton_Click(object sender, EventArgs e)
        {
            entityType = "Event";
            var db = new EventContext();
            //var events = db.Events.ToList();
            dataGridView1.DataSource = db.Events.Select(o => new
            {
                EventID = o.EventId,
                Name = o.Name,
                Description = o.Description,
                StartDate = o.StartDate,
                EndDate = o.EndDate,
                Website = o.Website,
                Location = o.Location.Name.ToString()
            }).ToList();
        }

        private void HostsButton_Click(object sender, EventArgs e)
        {
            entityType = "Host";
            var db = new EventContext();
            //var hosts = db.Hosts.ToList();
            dataGridView1.DataSource = db.Hosts.Select(o => new
            {
                HostID = o.HostID,
                Website = o.Website,
                Email = o.Email,
                Name = o.Name,
                PhoneNumber = o.PhoneNumber,
                Discriminator = o.GetType().ToString()
            }).ToList();
        }

        private void AttendeesButton_Click(object sender, EventArgs e)
        {
            entityType = "Attendee";
            var db = new EventContext();
            //var attendees = db.Attendees.ToList();
            var attendees = db.Attendees.Select(o => new
            {
                AttendeeID = o.AttendeeID,
                Name = o.Name,
                Email = o.Email,
                PhoneNumber = o.PhoneNumber,
                //CheckinTime = o.CheckinTime

            }).ToList();
            dataGridView1.DataSource = attendees;

            //dataGridView1.DataSource = db.Attendees.Select(o => new
            //{
            //  AttendeeID = o.AttendeeID,
            // Name = o.Name,
            //Email = o.Email,
            //PhoneNumber = o.PhoneNumber,
            //CheckinTime = o.CheckinTime

            //            }).ToList();
        }


        private void LocationsButton_Click(object sender, EventArgs e)
        {
            entityType = "Location";
            var db = new EventContext();
            //var locations = db.Locations.ToList();
            dataGridView1.DataSource = db.Locations.Select(o => new
            {
                Address = o.Address,
                Name = o.Name,
                Website = o.Website,
                Email = o.Email,
                RentalFee = o.RentalFee,
                VendorCapacity = o.VendorCapacity,
                AttendeeCapacity = o.AttendeeCapacity
            }).ToList();

            //db.SaveChanges();
            //Close();
        }

        private void PresentersButton_Click(object sender, EventArgs e)
        {
            entityType = "Presenter";
            var db = new EventContext();
            //var presenters = db.Presenters.ToList();
            dataGridView1.DataSource = db.Presenters.Select(o => new
            {
                PresenterID = o.PresenterID,
                Name = o.Name,
                Email = o.Email,
                PresenterFee = o.PresenterFee,
                PhoneNumber = o.Phone,
            }).ToList();
        }

        private void VendorsButton_Click(object sender, EventArgs e)
        {
            entityType = "Vendor";
            var db = new EventContext();
            //var vendors = db.Vendors.ToList();
            dataGridView1.DataSource = db.Vendors.Select(o => new
            {
                VendorID = o.VendorID,
                Name = o.Name,
                Email = o.Email,
                Phone = o.PhoneNum,
                Fee = o.Fee
            }).ToList();
        }

        private void EmployeesButton_Click(object sender, EventArgs e)
        {
            entityType = "Employee";
            var db = new EventContext();
            //var employees = db.Employees.ToList();
            dataGridView1.DataSource = db.Employees.Select(o => new
            {
                EmployeeID = o.EmpID,
                Name = o.Name,
                Pay = o.Pay,
                ShiftSchedule = o.ShiftSchedule,
                Location = o.Location.Name.ToString(),
                //HostID = o.Host.,
            }).ToList();
        }

        private void TicketsButton_Click(object sender, EventArgs e)
        {
            entityType = "Ticket";
            var db = new EventContext();
            //var tickets = db.Tickets.ToList();
            dataGridView1.DataSource = db.Tickets.Select(o => new
            {
                TicketID = o.TicketID,
                Cost = o.Cost,
                AttendeeID = o.Attendee.Name,
                EventID = o.Event.Name,
                TicketType = o.TicketType,
                CheckInTime = o.CheckInTime,
            }).ToList();
        }


        private void HasSpaceButton_Click_1(object sender, EventArgs e)
        {
            entityType = "HasSpace";
            var db = new EventContext();
            //var hasSpace = db.HasSpace.ToList();
            dataGridView1.DataSource = db.HasSpace.Select(o => new
            {
                RoomID = o.RoomID,
                TableID = o.TableID,
                VendorID = o.Vendor,
                EventID = o.Event,
            }).ToList();
        }

        private void HostedByButton_Click_1(object sender, EventArgs e)
        {
            entityType = "HostedBy";
            var db = new EventContext();
            //var hostedBy = db.HostedBy.ToList();
            //dataGridView1.DataSource = hostedBy;
            dataGridView1.DataSource = db.HostedBy.Select(o => new
            {
                HostedID = o.HostedID,
                EventID = o.Event,
                HostID = o.HostedID,

            }).ToList();
        }

        private void PresentsButton_Click_1(object sender, EventArgs e)
        {
            entityType = "Present";
            var db = new EventContext();
            //var presents = db.Presents.ToList();
            dataGridView1.DataSource = db.Presents.Select(o => new
            {
                RoomID = o.RoomID,
                Title = o.Title,
                Description = o.Description,
                Time = o.Time,
                PresenterID = o.Presenter,
                EventID = o.Event
            }).ToList();
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
                        //var itemToDelete = row.DataBoundItem;
                        var itemToDelete2 = row.Cells[0].Value;


                        if (itemToDelete2 != null)
                        {
                            DeleteEntity(db, itemToDelete2);
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
            if (entityType == "Event")
            {
                var entityToDelete = db.Events.Find(entity);
                db.Events.Remove(entityToDelete);
            }
            else if (entityType == "Host")
            {
                var entityToDelete = db.Hosts.Find(entity);
                db.Hosts.Remove(entityToDelete);
            }
            else if (entityType == "Attendee")
            {
                var entityToDelete = db.Attendees.Find(entity);
                db.Attendees.Remove(entityToDelete);
            }
            else if (entityType == "Employee")
            {
                var entityToDelete = db.Employees.Find(entity);
                db.Employees.Remove(entityToDelete);
            }
            else if (entityType == "Location")
            {
                var entityToDelete = db.Locations.Find(entity);
                db.Locations.Remove(entityToDelete);
            }
            else if (entityType == "Vendor")
            {
                var entityToDelete = db.Vendors.Find(entity);
                db.Vendors.Remove(entityToDelete);
            }
            else if (entityType == "Presenter")
            {
                var entityToDelete = db.Presenters.Find(entity);
                db.Presenters.Remove(entityToDelete);
            }
            else if (entityType == "Ticket")
            {
                var entityToDelete = db.Tickets.Find(entity);
                db.Tickets.Remove(entityToDelete);
            }
            else if (entityType == "HasSpace")
            {
                var entityToDelete = db.HasSpace.Find(entity);
                db.HasSpace.Remove(entityToDelete);
            }
            else if (entityType == "HostedBy")
            {
                var entityToDelete = db.HostedBy.Find(entity);
                db.HostedBy.Remove(entityToDelete);
            }
            else if (entityType == "Presents")
            {
                var entityToDelete = db.Presents.Find(entity);
                db.Presents.Remove(entityToDelete);
            }
            // ... handle other entity types similarly
            // else if (entity is AnotherEntityType) { ... }
        }


        private void ModifyButton_Click(object sender, EventArgs e)
        {
            var db = new EventContext();
            if (dataGridView1.SelectedRows.Count == 1)
            {
                var row = dataGridView1.SelectedRows[0];
                //var itemToEdit = row.DataBoundItem;
                var itemToEdit2 = row.Cells[0].Value;
                if (itemToEdit2 != null)
                {
                    // Open a new form or display a section in the current form to edit the selected item
                    EditItem(db, itemToEdit2);
                }
            }
            else
            {
                MessageBox.Show("Please select a single row to edit.");
            }
        }

        private void EditItem(EventContext db, object item)
        {
            if (item != null)
            {
                //EntityType entityType = EntityType.Unknown;

                // Determine the type of the entity
                Form editForm = null; // Declare the form variable outside of the if-else statements

                // Determine the type of the entity and instantiate the appropriate form
                if (entityType == "Event")
                {
                    var entityToEdit = db.Events.Find(item);

                    editForm = new Event_Edit_Form(entityToEdit);
                }
                else if (entityType == "Host")
                {
                    var entityToEdit = db.Hosts.Find(item);

                    editForm = new Host_Edit_Form(entityToEdit);
                }
                else if (entityType == "Location")
                {
                    var entityToEdit = db.Locations.Find(item);

                    editForm = new Location_Edit_Form(entityToEdit);
                }
                else if (entityType == "Attendee")
                {
                    var entityToEdit = db.Attendees.Find(item);

                    editForm = new Attendee_Edit_Form(entityToEdit);
                }
                else if (entityType == "Presenter")
                {
                    var entityToEdit = db.Presenters.Find(item);

                    editForm = new Presenter_Edit_Form(entityToEdit);
                }
                else if (entityType == "Ticket")
                {
                    var entityToEdit = db.Tickets.Find(item);

                    editForm = new Ticket_Edit_Form(entityToEdit);
                }
                else if (entityType == "Vendor")
                {
                    var entityToEdit = db.Vendors.Find(item);

                    editForm = new Vendor_Edit_Form(entityToEdit);
                }
                else if (entityType == "Employee")
                {
                    var entityToEdit = db.Employees.Find(item);

                    editForm = new Employees_Edit_Form(entityToEdit);
                }
                else if (entityType == "HasSpace")
                {
                    var entityToEdit = db.HasSpace.Find(item);

                    //     editForm = new HasSpace_Edit_Form(entityToEdit);
                }
                else if (entityType == "HostedBy")
                {
                    var entityToEdit = db.HostedBy.Find(item);

                    //    editForm = new HostedBy_Edit_Form(entityToEdit);
                }
                else if (entityType == "Present")
                {
                    var entityToEdit = db.Presents.Find(item);

                    //    editForm = new Presents_Edit_Form(entityToEdit);
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






    }
}
