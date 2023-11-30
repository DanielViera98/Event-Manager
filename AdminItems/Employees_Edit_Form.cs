﻿using System;
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
    public partial class Employees_Edit_Form : Form
    {
        private object _entityToEdit;

        public Employees_Edit_Form(object entityToEdit)
        {
            InitializeComponent();
            _entityToEdit = entityToEdit;
            PopulateFields();
        }

        private void PopulateFields()
        {
            Employee employeeToEdit = _entityToEdit as Employee;
            if (employeeToEdit != null)
            {
                //textBoxEID.Text = eventToEdit.EventId;
                textBoxEI.Text = employeeToEdit.EmpID.ToString();
                textBoxName.Text = employeeToEdit.Name;
                textBoxPay.Text = employeeToEdit.Pay.ToString();
                textBoxShift.Text = employeeToEdit.ShiftSchedule;
                /*if (employeeToEdit.Location != null)
                {
                    textBoxLocation.Text = employeeToEdit.Location.ToString();
                }
                else
                {
                    textBoxLocation.Text = "Empty";
                }
                if (employeeToEdit.Host != null)
                {
                    textBoxHI.Text = employeeToEdit.Host.ToString();
                }
                else
                {
                    textBoxHI.Text = "Empty";
                }
                */

                //textBoxHI.Text = employeeToEdit.Host.ToString();

                //textBoxLocation.Text = eventToEdit.Location;
            }
        }

        private void SaveEmployee()
        {
            Employee employeeToSave = _entityToEdit as Employee;
            if (employeeToSave != null)
            {
                // Update locationToSave with values from form controls

                //attendeeToSave.AttendeeID = textBoxAI.Text;

                //textBoxEI.Text = textBoxEI.Text.ToString();
                employeeToSave.EmpID = Guid.Parse(textBoxEI.Text);
                employeeToSave.Name = textBoxName.Text;
                if (decimal.TryParse(textBoxPay.Text, out decimal payResult))
                {
                    employeeToSave.Pay = payResult;
                }
                else
                {
                    MessageBox.Show("Pay must be a valid decimal number.");
                    return;
                }

                employeeToSave.ShiftSchedule = textBoxShift.Text;
                //employeeToSave.Location = (Location) textBoxLocation.Text;
                //employeeToSave.Host = (Host) textBoxHI.Text;


                using (var db = new EventContext())
                {
                    // For a connected scenario
                    db.Employees.Update(employeeToSave);
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






        private void Employees_Edit_Form_Load(object sender, EventArgs e)
        {

        }

        private void Submit_Click(object sender, EventArgs e)
        {
            SaveEmployee();

        }
    }
}