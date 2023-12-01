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
    public partial class RegisterAttendee_Form : Form
    {
        public RegisterAttendee_Form()
        {
            InitializeComponent();
        }

        private void button_Register_Click(object sender, EventArgs e)
        {
            var db = new EventContext();
            string email = textBox_Email.Text;
            string name = textBox_Name.Text;
            string phoneNum = textBox_PhoneNum.Text;
            string username = textBox_Username.Text;
            string password = textBox_Password.Text;
            var check = new List<string>()
            {
                email, name, phoneNum, username, password
            };
            if (!Functions.CheckNull(check) || !Functions.CheckMin(check, 2) || !Functions.CheckUsernameFree(username))
            {
                return;
            }
            Attendee newAttendee = new Attendee { Name = name, Email = email, PhoneNumber = phoneNum };
            db.Attendees.Add(newAttendee);
            db.Accounts.Add(new Account(newAttendee.AttendeeID, username, "Attendee", password));
            db.SaveChanges();
            if (username != null)
            {
                var userForm = new User_Form(db.Attendees.Where(s => s.Name == textBox_Name.Text).First());
                userForm.Show();
            }
            Close();
        }
    }
}
