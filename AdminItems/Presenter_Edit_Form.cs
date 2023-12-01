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

        //Populates the fields in the edit form

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
  
            }
        }

        //Saves the changed values back to the database, thereby modifying the entry

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
                if (Functions.CheckString(textBoxName.Text))
                {
                    presenterToSave.Name = textBoxName.Text;
                }
                else
                {
                    MessageBox.Show("Name entry is empty, please try again.");
                    return;
                }
                if (Functions.CheckEmail(textBoxEmail.Text))
                {
                    presenterToSave.Email = textBoxEmail.Text;
                }
                else
                {
                    MessageBox.Show("Email is incorrect, please try again.");
                    return;
                }



                
                if (decimal.TryParse(textBoxPF.Text, out decimal costResult))
                {
                    presenterToSave.PresenterFee = costResult;
                }
                else
                {
                    MessageBox.Show("Pay must be a valid float number.");
                    return;
                }

               


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
