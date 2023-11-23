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
        public User_Form()
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
        }

        private void User_Form_Load(object sender, EventArgs e)
        {
            //listView1.Items.Add();

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
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            Confirm.Hide();
            confirmation.Hide();
            Cancel.Hide();
        }
    }
}
