using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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
            presenterData.Hide();
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
            //var attendees = db.Attendees.Where(p => p.Name == userName).ToList();
            var tickets = db.Tickets.Where(p => p.Attendee == currAttendee).ToList();
            var hosts = db.HostedBy.Where(p => db.Tickets.Any()).ToList();
            var events = db.Events.ToList();
            var presents = db.Presents.Where(p => tickets.Select(t => t.Event).Contains(p.Event)).ToList();
            var presenters = db.Presenters.ToList();
            var vendors = db.Vendors.ToList();
            hostedData.DataSource = hosts;
            eventData.DataSource = events;
            presenterData.DataSource = presenters;
            presentationData.DataSource = presents;
            vendorData.DataSource = vendors;
            //ticketData.DataSource = tickets;
            //foreach (DataGridViewRow row in ticketData.Rows)
            //{
                //Ticket ticketItem = row.DataBoundItem as Ticket;
                //if (ticketItem.Attendee != null)
                //{
                //row.Cells[1].ValueType = typeof(string);
                //row.Cells[1] = new Item("One", 1);//db.Attendees.First().ToString();
                //row.Cells[1].Tag = "hello";

                //row.Cells[0].Value = "hello";
                //row.Cells[2].Value = db.Tickets.First().ToString();
                //}
                //
                //Ticket potentialAttendee = db.Tickets.Where(p => p.TicketID.ToString() == row.Cells[0].Value.ToString()).First();
                //row.Cells[1].Value = potentialAttendee.Attendee.Name;
                /*if (potentialAttendee == null)
                {

                }
                else
                {
                    row.Cells[1].Value = potentialAttendee;
                }*/
                //row.Cells[2].Value = db.Tickets.Where(p=>p.TicketID.ToString() == row.Cells[0].Value.ToString()).First().Attendee.Name; // db.Attendees.Where(p => row.Cells[2].Value.ToString() == p.Name.ToString()).Select();
            //}

        }


        private void PresentersLabel_Click(object sender, EventArgs e)
        {
            //var entryFormItem = new Entry_Form();
            //entryFormItem.Show();
        }

        private void VendorsLabel_Click(object sender, EventArgs e)
        {

        }

        private void vendorData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void showPresenters_CheckedChanged(object sender, EventArgs e)
        {
            if (presenterData.Visible)
            {
                presenterData.Hide();
                PresentersLabel.Hide();
                tablesShowing -= 1;
            }
            else
            {
                presenterData.Location = new Point(400, 200 * tablesShowing);
                PresentersLabel.Location = new Point(320, 200 * tablesShowing);
                presenterData.Show();
                PresentersLabel.Show();
                tablesShowing += 1;
            }
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

            if (Choice.Text == "Select an Event" || db.Tickets.Any(p => p.Attendee == currAttendee))
            {
                MessageBox.Show("Must select a cell for an Event. Must not already have ticket.");
                return;
            }

            db.Tickets.Add(new Ticket(
                5,
                currAttendee,
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
