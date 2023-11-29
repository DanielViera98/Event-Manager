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
    public partial class Vendor_Edit_Form : Form
    {
        private object _entityToEdit;

        public Vendor_Edit_Form(object entityToEdit)
        {
            InitializeComponent();
            _entityToEdit = entityToEdit;
            PopulateFields();
        }

        private void PopulateFields()
        {
            Vendor vendorToEdit = _entityToEdit as Vendor;
            if (vendorToEdit != null)
            {
                textBoxVI.Text = vendorToEdit.VendorID.ToString();
                textBoxName.Text = vendorToEdit.Name;
                textBoxEmail.Text = vendorToEdit.Email;
                textBoxPhone.Text = vendorToEdit.PhoneNum;
                textBoxFee.Text = vendorToEdit.Fee.ToString();
                
            }
        }

        private void SaveVendor()
        {
            Vendor vendorToSave = _entityToEdit as Vendor;
            if (vendorToSave != null)
            {
                // Update locationToSave with values from form controls

                if (!string.IsNullOrWhiteSpace(textBoxName.Text) && !textBoxName.Text.Any(char.IsDigit))
                {
                    vendorToSave.Name = textBoxName.Text;
                }
                else
                {
                    MessageBox.Show("Name must be a valid string.");
                    return;
                }
                vendorToSave.Email = textBoxEmail.Text;
                vendorToSave.PhoneNum = textBoxPhone.Text;
                if (decimal.TryParse(textBoxFee.Text, out decimal costResult))
                {
                    vendorToSave.Fee = costResult;
                }
                else
                {
                    MessageBox.Show("Pay must be a valid decimal number.");
                    return;
                }

 


                using (var db = new EventContext())
                {
                    // For a connected scenario
                    db.Vendors.Update(vendorToSave);
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
            SaveVendor();
        }
    }
}
