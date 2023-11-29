﻿using System;
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
            db.Attendees.Add(new Attendee { Name = textBox_Name.Text, Email = textBox_Email.Text, PhoneNumber = textBox_PhoneNum.Text });
            db.SaveChanges();
        }
    }
}
