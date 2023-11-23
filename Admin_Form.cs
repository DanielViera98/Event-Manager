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
            var events = new List<Event> { new Event() }; // Create an empty list with a dummy entry
            dataGridView1.DataSource = events;
        }

        private void HostsButton_Click(object sender, EventArgs e)
        {
            var hosts = new List<Host> { new Host() }; // Create an empty list with a dummy entry
            dataGridView1.DataSource = hosts;
        }

        private void AttendeesButton_Click(object sender, EventArgs e)
        {
            var attendees = new List<Attendee> { new Attendee() }; // Create an empty list with a dummy entry
            dataGridView1.DataSource = attendees;
        }


        private void LocationsButton_Click(object sender, EventArgs e)
        {
            var locations = new List<Location> { new Location() }; // Create an empty list with a dummy entry
            dataGridView1.DataSource = locations;
        }

        private void PresentersButton_Click(object sender, EventArgs e)
        {
            var presenters = new List<Presenter> { new Presenter() }; // Create an empty list with a dummy entry
            dataGridView1.DataSource = presenters;
        }

        private void VendorsButton_Click(object sender, EventArgs e)
        {
            var vendors = new List<Vendor> { new Vendor() }; // Create an empty list with a dummy entry
            dataGridView1.DataSource = vendors;
        }

        private void EmployeesButton_Click(object sender, EventArgs e)
        {
            var employees = new List<Employee> { new Employee() }; // Create an empty list with a dummy entry
            dataGridView1.DataSource = employees;
        }

        private void TicketsButton_Click(object sender, EventArgs e)
        {
            var tickets = new List<Ticket> { new Ticket() }; // Create an empty list with a dummy entry
            dataGridView1.DataSource = tickets;
        }
    }
}
