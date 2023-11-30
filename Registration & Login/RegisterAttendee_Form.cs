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
            var check = new List<string>()
            {
                textBox_Email.Text,
                textBox_Name.Text,
                textBox_PhoneNum.Text
            };
            Functions.CheckNull( check );
            Functions.CheckMin(check, 2);
            db.Attendees.Add(new Attendee { Name = textBox_Name.Text, Email = textBox_Email.Text, PhoneNumber = textBox_PhoneNum.Text });
            db.SaveChanges();
            if (textBox_Name.Text != null)
            {
                var userForm = new User_Form(db.Attendees.Select(s => s.Name == textBox_Name.Text) as Attendee);
                userForm.Show();
            }
            Close();
        }
    }
}
