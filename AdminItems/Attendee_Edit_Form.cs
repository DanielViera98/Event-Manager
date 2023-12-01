using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;
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
    public partial class Attendee_Edit_Form : Form
    {
        private object _entityToEdit;

        public Attendee_Edit_Form(object entityToEdit)
        {
            InitializeComponent();
            _entityToEdit = entityToEdit;
            PopulateFields();
        }

        //Populates the fields in the edit form
        private void PopulateFields()
        {
            Attendee attendeeToEdit = _entityToEdit as Attendee;
            if (attendeeToEdit != null)
            {
                //textBoxEID.Text = eventToEdit.EventId;
                textBoxAI.Text = attendeeToEdit.AttendeeID.ToString();
                textBoxName.Text = attendeeToEdit.Name;
                textBoxEmail.Text = attendeeToEdit.Email;
                textBoxPhone.Text = attendeeToEdit.PhoneNumber;
                //dateTimePickerCheckin.Value = attendeeToEdit.CheckinTime;

                //textBoxLocation.Text = eventToEdit.Location;
            }
        }

        //Saves the changed values back to the database, thereby modifying the entry
        private void SaveAttendee()
        {
            Attendee attendeeToSave = _entityToEdit as Attendee;
            if (attendeeToSave != null)
            {
                // Update locationToSave with values from form controls

                //attendeeToSave.AttendeeID = textBoxAI.Text;
                attendeeToSave.Name = textBoxName.Text;
                if(Functions.CheckString(textBoxName.Text)) {
                    
                    attendeeToSave.Name = textBoxName.Text;
                }
                else
                {
                    MessageBox.Show("Cannot leave name empty, please try again"
                        );
                }
                if (Functions.CheckPhone(textBoxPhone.Text))
                {

                    attendeeToSave.PhoneNumber = textBoxPhone.Text;
                }
                else
                {
                    MessageBox.Show("Phone format incorrect, please try again");
                }


                using (var db = new EventContext())
                {
                    // For a connected scenario
                    db.Attendees.Update(attendeeToSave);
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
            SaveAttendee();
        }
    }
}
