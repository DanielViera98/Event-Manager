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

namespace Event_Manager.AdminItems
{
    public partial class HasSpace_Form_Edit : Form
    {
        private object _entityToEdit;

        public HasSpace_Form_Edit(object entityToEdit)
        {
            InitializeComponent();
            _entityToEdit = entityToEdit;
            PopulateFields();

        }

        private void PopulateFields()
        {
            HasSpace hasSpaceToEdit = _entityToEdit as HasSpace;
            if (hasSpaceToEdit != null)
            {

                //textBoxEI.Text = hasSpaceToEdit.EmpID.ToString();
                //textBoxName.Text = hasSpaceToEdit.Name;
                //textBoxPay.Text = hasSpaceToEdit.Pay.ToString();
                //textBoxShift.Text = hasSpaceToEdit.ShiftSchedule;
                //if (employeeToEdit.Host != null)
                //{
                //    textBoxHI.Text = employeeToEdit.Host.ToString();
                //}
                //else
                //{
                //    textBoxHI.Text = "Empty";
                //}

            }
        }

        private void SaveHasSpace()
        {
            HasSpace hasSpaceToSave = _entityToEdit as HasSpace;
            if (hasSpaceToSave != null)
            {
                // Update locationToSave with values from form controls

                //hasSpaceToSave.EmpID = Guid.Parse(textBoxEI.Text);
                //hasSpaceToSave.Name = textBoxName.Text;
                //if (decimal.TryParse(textBoxPay.Text, out decimal payResult))
                // {
                //     employeeToSave.Pay = payResult;
                // }
                //else
                // {
                //    MessageBox.Show("Pay must be a valid decimal number.");
                //    return;
                // }

                // hasSpaceToSave.ShiftSchedule = textBoxShift.Text;



                using (var db = new EventContext())
                {
                    // For a connected scenario
                    db.HasSpace.Update(hasSpaceToSave);
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
