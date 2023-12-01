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
    
    public partial class Location_Edit_Form : Form
    {
        private object _entityToEdit;

        public Location_Edit_Form(object entityToEdit)
        {
            InitializeComponent();
            _entityToEdit = entityToEdit;
            PopulateFields();
        }

        //Populates the fields in the edit form

        private void PopulateFields()
        {
            
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

                    
                    // ... handle other types
            
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            
                    SaveLocation();
                    
        }


        //Saves the changed values back to the database, thereby modifying the entry
        private void SaveLocation()
        {
            Location locationToSave = _entityToEdit as Location;
            if (locationToSave != null)
            {
                // Update locationToSave with values from form controls
                //locationToSave.Address = textBoxAddress.Text;

                if (Functions.CheckString(textBoxName.Text))
                {
                    locationToSave.Name = textBoxName.Text;
                }
                else
                {
                    MessageBox.Show("Name entry is empty, please try again.");
                    return;
                }
                if (Functions.CheckString(textBoxWebsite.Text))
                {
                    locationToSave.Website = textBoxWebsite.Text;
                }
                else
                {
                    MessageBox.Show("Website entry is empty, please try again.");
                    return;
                }
                if (Functions.CheckEmail(textBoxEmail.Text))
                {
                    locationToSave.Email = textBoxEmail.Text;
                }
                else
                {
                    MessageBox.Show("Email entry is incorrect, please try again.");
                    return;
                }

                

                
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
