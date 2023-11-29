using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Event_Manager
{
    public partial class Host_Edit_Form : Form
    {
        private object _entityToEdit;

        public Host_Edit_Form(object entityToEdit)
        {
            InitializeComponent();
            _entityToEdit = entityToEdit;
            PopulateFields();
        }

        private void PopulateFields()
        {
            Host hostToEdit = _entityToEdit as Host;
            if (hostToEdit != null)
            {
                //textBoxEID.Text = eventToEdit.EventId;
                textBoxHI.Text = hostToEdit.HostID.ToString();
                textBoxWebsite.Text = hostToEdit.Website;
                textBoxEmail.Text = hostToEdit.Email;
                //textBoxDiscriminator.Text = hostToEdit.Discriminator;
                //textBoxON.Text = hostToEdit.OrganizationName;

                //textBoxHI.Text = employeeToEdit.Host.ToString();

                //textBoxLocation.Text = eventToEdit.Location;
            }
        }

        private void SaveHost()
        {
            Host hostToSave = _entityToEdit as Host;
            if (hostToSave != null)
            {
                // Update locationToSave with values from form controls

                

                hostToSave.Website = textBoxWebsite.Text;
                hostToSave.Email = textBoxEmail.Text;

                //ticketToSave.Attendee = textBoxAI.Text;


                using (var db = new EventContext())
                {
                    // For a connected scenario
                    db.Hosts.Update(hostToSave);
                    db.SaveChanges();

                    // Indicate success and close the form
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
            else
            {
                // Handle null case or show an error message
                MessageBox.Show("Editing failed. No location data provided.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Submit_Click_1(object sender, EventArgs e)
        {
            SaveHost();
        }
    }
}
