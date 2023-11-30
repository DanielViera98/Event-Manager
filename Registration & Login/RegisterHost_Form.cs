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

            if (checkBox1.Checked == false)
            {
                db.Persons.Add(new Person
                {
                    Name = textBox_Name.Text,
                    Email = textBox_Email.Text,
                    PhoneNumber = textBox_PhoneNum.Text,
                    Website = textBox_Website.Text
                });
            }
            else if (checkBox1.Checked == true)
            {
                db.Organizations.Add(new Organization
                {
                    Name = textBox_Name.Text,
                    Email = textBox_Email.Text,
                    PhoneNumber = textBox_PhoneNum.Text,
                    Website = textBox_Website.Text,
                    RepresentativeName = label_RName.Text,
                    RepresentativePhone = labelRPNum.Text
                });
            }

            db.SaveChanges();
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
