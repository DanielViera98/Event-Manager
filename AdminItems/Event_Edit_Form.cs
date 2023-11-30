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
    public partial class Event_Edit_Form : Form
    {
        private object _entityToEdit;

        public Event_Edit_Form(object entityToEdit)
        {
            InitializeComponent();
            _entityToEdit = entityToEdit;
            PopulateFields();
        }


        private void PopulateFields()
        {
            Event eventToEdit = _entityToEdit as Event;
            if (eventToEdit != null)
            {
                textBoxEID.Text = eventToEdit.EventId.ToString();
                textBoxName.Text = eventToEdit.Name;
                textBoxDescription.Text = eventToEdit.Description;
                dateTimePickerSD.Value = eventToEdit.StartDate;
                dateTimePickerED.Value = eventToEdit.EndDate;
                textBoxWebsite.Text = eventToEdit.Website;

                /*if (eventToEdit.Location != null)
                {
                    textBoxLocation.Text = eventToEdit.Location.Name;
                }
                else
                {
                    textBoxLocation.Text = "Empty";
                }*/
            }
        }


        private void Submit_Click(object sender, EventArgs e)
        {
            SaveEvent();
        }
        private void SaveEvent()
        {
            Event eventToSave = _entityToEdit as Event;
            if (eventToSave != null)
            {
                // Update locationToSave with values from form controls
                //locationToSave.Address = textBoxAddress.Text;
                eventToSave.Name = textBoxName.Text;
                eventToSave.Description = textBoxDescription.Text;
                eventToSave.StartDate = DateTime.SpecifyKind(dateTimePickerSD.Value, DateTimeKind.Utc);
                eventToSave.EndDate = DateTime.SpecifyKind(dateTimePickerED.Value, DateTimeKind.Utc);
                eventToSave.Website = textBoxWebsite.Text;


                using (var db = new EventContext())
                {
                    // For a connected scenario
                    db.Events.Update(eventToSave);
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
            SaveEvent();
        }
    }
}
