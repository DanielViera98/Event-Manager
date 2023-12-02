using Microsoft.EntityFrameworkCore;
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
    public partial class RegisterHost_Form : Form
    {
        public RegisterHost_Form()
        {
            InitializeComponent();
        }

        private async void button_Register_Click(object sender, EventArgs e)
        {
            var db = new EventContext();
            var check = new List<string>()
            {
                textBox_Email.Text,
                textBox_Name.Text,
                textBox_PhoneNum.Text,
                textBox_Username.Text,
                textBox_Password.Text
            };
            if (!Functions.CheckNull(check) || !Functions.CheckMin(check, 2) || !Functions.CheckUsernameFree(textBox_Username.Text))
            {
                return;
            }
            if (textBox_Username.Text.Contains('\'') || textBox_Username.Text.Contains('\"') || textBox_Password.Text.Contains('\'') || textBox_Password.Text.Contains('\"'))
            {
                MessageBox.Show("Must not include: \'");
                return;
            }

            Guid hostID;
            if (checkBox1.Checked == false)
            {
                Person newPerson = new Person
                {
                    Name = textBox_Name.Text,
                    Email = textBox_Email.Text,
                    PhoneNumber = textBox_PhoneNum.Text,
                    Website = textBox_Website.Text
                };
                db.Persons.Add(newPerson);
                hostID = newPerson.HostID;
            }
            else
            {
                Organization newOrg = new Organization
                {
                    Name = textBox_Name.Text,
                    Email = textBox_Email.Text,
                    PhoneNumber = textBox_PhoneNum.Text,
                    Website = textBox_Website.Text,
                    RepresentativeName = label_RName.Text,
                    RepresentativePhone = labelRPNum.Text
                };
                db.Organizations.Add(newOrg);
                hostID = newOrg.HostID;
            }
            try
            {
                await db.Hosts.FromSqlRaw($"CALL \"AddUser\" (\'{hostID}\', \'{textBox_Username.Text}\',\'{textBox_Password.Text}\','Host')").ToListAsync();
            }
            catch { }
            db.SaveChanges();
            var newForm = new HostLanding(db.Hosts.Find(hostID));
            newForm.Show();
            Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                labelRPNum.Enabled = true;
                label_OrgInfo.Enabled = true;
                label_RName.Enabled = true;
                textBox_RName.Enabled = true;
                textBox_RPNum.Enabled = true;
            }
            else
            {
                labelRPNum.Enabled = false;
                label_OrgInfo.Enabled = false;
                label_RName.Enabled = false;
                textBox_RName.Enabled = false;
                textBox_RPNum.Enabled = false;
            }
        }
    }
}
