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
    public partial class Presenter_Edit_Form : Form
    {
        private object _entityToEdit;

        public Presenter_Edit_Form(object entityToEdit)
        {
            InitializeComponent();
            _entityToEdit = entityToEdit;
            PopulateFields();
        }

        private void PopulateFields()
        {
            Presenter presenterToEdit = _entityToEdit as Presenter;
            if (presenterToEdit != null)
            {
                //textBoxEID.Text = eventToEdit.EventId;
                textBoxPI.Text = presenterToEdit.PresenterID.ToString();
                textBoxName.Text = presenterToEdit.Name;
                textBoxEmail.Text = presenterToEdit.Email;
                textBoxPF.Text = presenterToEdit.PresenterFee.ToString();
                textBoxPhone.Text = presenterToEdit.Phone;
                //textBoxDiscriminator.Text = hostToEdit.Discriminator;
                //textBoxON.Text = hostToEdit.OrganizationName;

                //textBoxHI.Text = employeeToEdit.Host.ToString();

                //textBoxLocation.Text = eventToEdit.Location;
            }
        }

        private void SavePresenter()
        {
            Presenter presenterToSave = _entityToEdit as Presenter;
            if (presenterToSave != null)
            {
                // Update locationToSave with values from form controls


                if (!string.IsNullOrWhiteSpace(textBoxName.Text) && !textBoxName.Text.Any(char.IsDigit))
                {
                    presenterToSave.Name = textBoxName.Text;
                }
                else
                {
                    MessageBox.Show("Name must be a valid string.");
                    return;
                }


                presenterToSave.Name = textBoxName.Text;
                presenterToSave.Email = textBoxEmail.Text;
                if (decimal.TryParse(textBoxPF.Text, out decimal costResult))
                {
                    presenterToSave.PresenterFee = costResult;
                }
                else
                {
                    MessageBox.Show("Pay must be a valid float number.");
                    return;
                }

                //ticketToSave.Attendee = textBoxAI.Text;


                using (var db = new EventContext())
                {
                    // For a connected scenario
                    db.Presenters.Update(presenterToSave);
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

        private void Submit_Click(object sender, EventArgs e)
        {
            SavePresenter();
        }
    }
}
