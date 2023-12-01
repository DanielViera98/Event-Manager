using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Event_Manager
{
    public partial class User_Form : Form
    {
        int tablesShowing = 0;
        Attendee currAttendee;
        public User_Form(Attendee user)
        {
            InitializeComponent();
            vendorData.Hide();
            eventData.Hide();
            presentationData.Hide();
            hostedData.Hide();
            ticketData.Hide();
            PresentersLabel.Hide();
            VendorsLabel.Hide();
            EventsLabel.Hide();
            PresentsLabel.Hide();
            HostedLabel.Hide();
            TicketsLabel.Hide();

            confirmation.Hide();
            Confirm.Hide();
            Cancel.Hide();
            currAttendee = user;

        }


        private void User_Form_Load(object sender, EventArgs e)
        {
            NameBox.Text = currAttendee.Name;
            var db = new EventContext();
            var tickets = db.Tickets.Where(p => p.Attendee == currAttendee);
            var hosts = db.HostedBy.Where(p => db.Tickets.Any()).ToList();
            var presents = db.Presents.Where(p => tickets.Select(t => t.Event).Contains(p.Event)).ToList();
            var presenters = db.Presenters.ToList();
            var vendors = db.Vendors.ToList();
            hostedData.DataSource = hosts;

            eventData.DataSource = db.Events.Select(o => new
            {
                Name = o.Name,
                Description = o.Description,
                StartDate = o.StartDate,
                EndDate = o.EndDate,
                Website = o.Website,
                Location = o.Location.Name
            }).ToList();
            presentationData.DataSource = db.Presents.Where(p => tickets.Select(t => t.Event).Contains(p.Event)).Select(o => new
            {
                Time = o.Time,
                Title = o.Title,
                Description = o.Description,
                RoomID = o.RoomID,
                Presenter = o.Presenter.Name,
                Event = o.Event.Name
            }).ToList();
            hostedData.DataSource = db.HostedBy.Where(p => tickets.Select(t => t.Event).Contains(p.Event)).Select(o => new
            {
                Event = o.Event.Name,
                Host = o.Host.Name
            }).ToList();
            vendorData.DataSource = db.HasSpace.Where(p => db.HasSpace.Any(q => q.Vendor.VendorID == p.Vendor.VendorID && tickets.Select(t => t.Event).Contains(q.Event))).Select(o => new
            {
                Event = o.Event.Name,
                TableID = o.TableID,
                RoomID = o.RoomID,
                Vendor = o.Vendor.Name

            }).ToList();
            ticketData.DataSource = db.Tickets.Where(p => p.Attendee == currAttendee).Select(o => new
            {
                TicketID = o.TicketID,
                Attendee = o.Attendee.Name,
                Event = o.Event.Name,
                TicketType = o.TicketType
            }).ToList();

        }

        private void PresentersLabel_Click(object sender, EventArgs e)
        {

        }

        private void VendorsLabel_Click(object sender, EventArgs e)
        {

        }

        private void vendorData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void showVendors_CheckedChanged(object sender, EventArgs e)
        {
            if (vendorData.Visible)
            {
                vendorData.Hide();
                VendorsLabel.Hide();
                tablesShowing -= 1;
            }
            else
            {
                vendorData.Location = new Point(400, 200 * tablesShowing);
                VendorsLabel.Location = new Point(320, 200 * tablesShowing);
                vendorData.Show();
                VendorsLabel.Show();
                tablesShowing += 1;
            }
        }

        private void ShowEvents_CheckedChanged(object sender, EventArgs e)
        {
            if (eventData.Visible)
            {
                eventData.Hide();
                EventsLabel.Hide();
                tablesShowing -= 1;
            }
            else
            {
                eventData.Location = new Point(400, 200 * tablesShowing);
                EventsLabel.Location = new Point(320, 200 * tablesShowing);
                eventData.Show();
                EventsLabel.Show();
                tablesShowing += 1;
            }
        }

        private void ShowPresentations_CheckedChanged(object sender, EventArgs e)
        {
            if (presentationData.Visible)
            {
                presentationData.Hide();
                PresentsLabel.Hide();
                tablesShowing -= 1;
            }
            else
            {
                presentationData.Location = new Point(400, 200 * tablesShowing);
                PresentsLabel.Location = new Point(320, 200 * tablesShowing);
                presentationData.Show();
                PresentsLabel.Show();
                tablesShowing += 1;
            }
        }

        private void ShowHosts_CheckedChanged(object sender, EventArgs e)
        {
            if (hostedData.Visible)
            {
                hostedData.Hide();
                HostedLabel.Hide();
                tablesShowing -= 1;
            }
            else
            {
                hostedData.Location = new Point(400, 200 * tablesShowing);
                HostedLabel.Location = new Point(320, 200 * tablesShowing);
                hostedData.Show();
                HostedLabel.Show();
                tablesShowing += 1;
            }
        }

        private void ShowTickets_CheckedChanged(object sender, EventArgs e)
        {
            if (ticketData.Visible)
            {
                ticketData.Hide();
                TicketsLabel.Hide();
                tablesShowing -= 1;
            }
            else
            {
                ticketData.Location = new Point(400, 200 * tablesShowing);
                TicketsLabel.Location = new Point(320, 200 * tablesShowing);
                ticketData.Show();
                TicketsLabel.Show();
                tablesShowing += 1;
            }
        }

        private void buyButton_Click(object sender, EventArgs e)
        {
            Confirm.Show();
            confirmation.Show();
            Cancel.Show();
        }

        private void Confirm_Click(object sender, EventArgs e)
        {
            Confirm.Hide();
            confirmation.Hide();
            Cancel.Hide();

            var db = new EventContext();

            if (Choice.Text == "Select an Event")
            {
                MessageBox.Show("Must select a cell for an Event.");
                return;
            }

            db.Tickets.Add(new Ticket(
                5,
                db.Attendees.Find(currAttendee.AttendeeID),
                db.Events.Where(p => p.Name == Choice.Text).First(),
                "Attendee"
                ));

            db.SaveChanges();
            User_Form_Load(null, null);

        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            Confirm.Hide();
            confirmation.Hide();
            Cancel.Hide();
        }

        private void eventData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow row in eventData.Rows)
            {
                foreach (DataGridViewCell cell in eventData.SelectedCells)
                {
                    if (row.Cells[0].Value.ToString() == cell.Value.ToString())
                    {
                        Choice.Text = row.Cells[0].Value.ToString();
                        break;
                    }
                }

            }
        }
    }
}
