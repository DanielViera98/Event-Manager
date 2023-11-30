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
    public partial class RegisterVendor_Form : Form
    {
        public RegisterVendor_Form()
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


            db.Vendors.Add(new Vendor
            {
                Name = textBox_Name.Text,
                Email = textBox_Email.Text,
                PhoneNum = textBox_PhoneNum.Text,
                Fee = numericUpDown_Fee.Value
            });
            db.SaveChanges();
            Close();
        }
    }
}
