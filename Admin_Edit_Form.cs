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
    public enum EntityType
    {
        Unknown,
        Event,
        Host,
        Attendee,
        Location,
        // ... other entity types
    }
    public partial class Admin_Edit_Form : Form
    {
        private object _entityToEdit;
        private EntityType _entityType;

        public Admin_Edit_Form(object entityToEdit, EntityType entityType)
        {
            InitializeComponent();
            _entityToEdit = entityToEdit;
            _entityType = entityType;
            PopulateFields();
        }

        private void PopulateFields()
        {
            switch (_entityType)
            {
                case EntityType.Event:
                    Event eventToEdit = _entityToEdit as Event;
                    // Populate fields for Event
                    break;
                case EntityType.Host:
                    Host hostToEdit = _entityToEdit as Host;
                    // Populate fields for Host
                    break;
                case EntityType.Location:
                    Location locationToEdit = _entityToEdit as Location;
                    // Populate fields for Location
                    if (locationToEdit != null)
                    {
                        textBoxAddress.Text = locationToEdit.Address;
                        textBoxName.Text = locationToEdit.Name;
                        textBoxWebsite.Text = locationToEdit.Website;
                        textBoxEmail.Text = locationToEdit.Email;
                        numericRF.Value = locationToEdit.RentalFee;
                        numericVC.Value = locationToEdit.VendorCapacity;
                        numericAC.Value = locationToEdit.AttendeeCapacity;
                    }

                    break;
                    // ... handle other types
            }
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            switch (_entityType)
            {
                case EntityType.Event:
                    SaveEvent();
                    break;
                case EntityType.Host:
                    SaveHost();
                    break;
                // ... other cases
                case EntityType.Location:
                    SaveLocation();
                    break;
                default:
                    throw new InvalidOperationException("Unsupported entity type.");
            }
        }

        private void SaveEvent()
        {
            Event eventToSave = _entityToEdit as Event;
            // Update eventToSave with values from form controls
            // Save to database
            // Set DialogResult and close if successful
        }

        private void SaveHost()
        {
            Host hostToSave = _entityToEdit as Host;
            // Similar handling for Host
        }

        private void SaveLocation()
        {
            Location locationToSave = _entityToEdit as Location;
            if (locationToSave != null)
            {
                // Update locationToSave with values from form controls
                //locationToSave.Address = textBoxAddress.Text;
                locationToSave.Name = textBoxName.Text;
                locationToSave.Website = textBoxWebsite.Text;
                locationToSave.Email = textBoxEmail.Text;
                locationToSave.RentalFee = numericRF.Value;
                locationToSave.VendorCapacity = (int)numericVC.Value;
                locationToSave.AttendeeCapacity = (int)numericAC.Value;

                using (var db = new EventContext())
                {
                    // For a connected scenario
                    db.Locations.Update(locationToSave);
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



        private void Admin_Edit_Form_Load(object sender, EventArgs e)
        {

        }


    }
}
