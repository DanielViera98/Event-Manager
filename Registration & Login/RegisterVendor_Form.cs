using Event_Manager.VendorItems;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Event_Manager.Registration___Login
{
    public partial class RegisterVendor_Form : Form
    {
        public RegisterVendor_Form()
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
            Vendor newVend = new Vendor
            {
                Name = textBox_Name.Text,
                Email = textBox_Email.Text,
                PhoneNum = textBox_PhoneNum.Text,
                Fee = numericUpDown_Fee.Value
            };
            db.Vendors.Add(newVend);
            try 
            {
                await db.Vendors.FromSqlRaw($"CALL \"AddUser\" (\'{newVend.VendorID}\', \'{textBox_Username.Text}\',\'{textBox_Password.Text}\','Vendor')").ToListAsync();
            } catch { }
                
            db.SaveChanges();
            var newForm = new VendorLanding(db.Vendors.Find(newVend.VendorID));
            newForm.Show();
            Close();
        }
    }
}
