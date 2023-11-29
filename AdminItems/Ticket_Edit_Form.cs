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

    public partial class Ticket_Edit_Form : Form
    {
        private object _entityToEdit;
        public Ticket_Edit_Form(object entityToEdit)
        {
            InitializeComponent();
            _entityToEdit = entityToEdit;
            PopulateFields();
        }
        private void PopulateFields()
        {
            Ticket ticketToEdit = _entityToEdit as Ticket;
            if (ticketToEdit != null)
            {
                //textBoxEID.Text = eventToEdit.EventId;
                textBoxTI.Text = ticketToEdit.TicketID.ToString();
                textBoxCost.Text = ticketToEdit.Cost.ToString();
                //textBoxAI.Text = ticketToEdit.Attendee.ToString();
                if (ticketToEdit.Attendee != null)
                {
                    textBoxAI.Text = ticketToEdit.Attendee.ToString();
                }
                else
                {
                    textBoxAI.Text = "Empty";
                }
                //textBoxEI.Text = ticketToEdit.Event.ToString();
                if (ticketToEdit.Event != null)
                {
                    textBoxEI.Text = ticketToEdit.Event.ToString();
                }
                else
                {
                    textBoxAI.Text = "Empty";
                }

                textBoxType.Text = ticketToEdit.TicketType;

                //textBoxHI.Text = employeeToEdit.Host.ToString();

                //textBoxLocation.Text = eventToEdit.Location;
            }
        }

        private void SaveTicket()
        {
            Ticket ticketToSave = _entityToEdit as Ticket;
            if (ticketToSave != null)
            {
                // Update locationToSave with values from form controls

                //attendeeToSave.AttendeeID = textBoxAI.Text;


                //ticketToSave.TicketID = Guid.Parse(textBoxTI.Text);
                if (float.TryParse(textBoxCost.Text, out float costResult))
                {
                    ticketToSave.Cost = costResult;
                }
                else
                {
                    MessageBox.Show("Pay must be a valid float number.");
                    return;
                }
                ticketToSave.TicketType = textBoxType.Text;

                //ticketToSave.Attendee = textBoxAI.Text;


                using (var db = new EventContext())
                {
                    // For a connected scenario
                    db.Tickets.Update(ticketToSave);
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
            SaveTicket();
        }
    }

}
