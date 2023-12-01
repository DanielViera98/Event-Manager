using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Event_Manager.AdminItems
{
    public partial class HostedBy_Edit_Form : Form
    {
        private object _entityToEdit;

        public HostedBy_Edit_Form(object entityToEdit)
        {
            InitializeComponent();
            _entityToEdit = entityToEdit;
            PopulateFields();

        }
        //USER CANNOT EDIT THIS PAGE

        private void PopulateFields()
        {
            HostedBy hostedByToEdit = _entityToEdit as HostedBy;
            if (hostedByToEdit != null)
            {
                textBoxHBI.Text = hostedByToEdit.HostedID.ToString();
                textBoxEI.Text = hostedByToEdit.Event.ToString();
                textBoxHI.Text = hostedByToEdit.Host.ToString();

            }
        }


        private void Submit_Click(object sender, EventArgs e)
        {
            SaveEvent();
        }
        private void SaveEvent()
        {
            HostedBy hostedByToSave = _entityToEdit as HostedBy;
            if (hostedByToSave != null)
            {
                // Update locationToSave with values from form controls

                //hostedByToSave.HostedID = textBoxHBI.Text;
                //hostedByToSave.Event = textBoxEI.Text;
                //hostedByToSave.Host = textBoxHI.Text;




                using (var db = new EventContext())
                {
                    // For a connected scenario
                    db.HostedBy.Update(hostedByToSave);
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
    }
}
