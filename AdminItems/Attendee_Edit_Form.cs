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

        private void SaveAttendee()
        {
            Attendee attendeeToSave = _entityToEdit as Attendee;
            if (attendeeToSave != null)
            {
                // Update locationToSave with values from form controls

                //attendeeToSave.AttendeeID = textBoxAI.Text;
                attendeeToSave.Name = textBoxName.Text;
                attendeeToSave.Email = textBoxEmail.Text;
                attendeeToSave.PhoneNumber = textBoxPhone.Text;
                //attendeeToSave.CheckinTime = DateTime.SpecifyKind(dateTimePickerCheckin.Value, DateTimeKind.Utc);


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
