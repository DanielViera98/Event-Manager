using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Event_Manager.Registration___Login
{
    public partial class RegisterEmployee_Form : Form
    {
        public RegisterEmployee_Form()
        {
            InitializeComponent();

            var db = new EventContext();
            var localSource = new BindingList<Location>();
            foreach (var local in db.Locations)
            {
                localSource.Add(local);
            }
            comboBox_Location.DataSource = localSource;
            comboBox_Location.SelectedIndex = -1;

            var hostSource = new BindingList<Host>();
            foreach (var host in db.Hosts)
            {
                hostSource.Add(host);
            }
            comboBox_Employer.DataSource = hostSource;
            comboBox_Employer.SelectedIndex = -1;
        }

        private void button_Register_Click(object sender, EventArgs e)
        {
            var db = new EventContext();
            var check = new List<string>()
            {
                textBox_Email.Text,
                textBox_Name.Text,
                textBox_PhoneNum.Text
            };
            Functions.CheckNull(check);
            Functions.CheckMin(check, 2);

            var selectedLocationId = ((Location)comboBox_Location.SelectedItem);
            Location existingLocation = null;
            if (selectedLocationId != null)
                existingLocation = db.Locations.Find(selectedLocationId.Address);
            var selectedHostId = ((Host)comboBox_Employer.SelectedItem);
            Host existingHost = null;
            if (selectedHostId != null)
                existingHost = db.Hosts.Find(selectedHostId.HostID);
            db.Employees.Add(new Employee
            {
                Name = textBox_Name.Text,
                Email = textBox_Email.Text,
                PhoneNum = textBox_PhoneNum.Text,
                ShiftSchedule = richTextBox_ShiftInfo.Text,
                Pay = numericUpDown_Pay.Value,
                Location = existingLocation,
                Host = existingHost
            }) ;
            db.SaveChanges();
            Close();
        }
    }
}
