using Event_Manager.PresenterItems;
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
    public partial class RegisterPresenter_Form : Form
    {
        public RegisterPresenter_Form()
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
                textBox_PhoneNum.Text,
                textBox_Username.Text,
                textBox_Password.Text
            };
            if (!Functions.CheckNull(check) || !Functions.CheckMin(check, 2) || !Functions.CheckUsernameFree(textBox_Username.Text))
            {
                return;
            }

            Presenter p = new Presenter
            {
                Name = textBox_Name.Text,
                Email = textBox_Email.Text,
                Phone = textBox_PhoneNum.Text,
                PresenterFee = numericUpDown_Fee.Value
            };
            db.Presenters.Add(p);
            db.Accounts.Add(new Account(p.PresenterID,textBox_Username.Text, "Presenter", textBox_Password.Text));
            db.SaveChanges();

            var form = new PresenterLanding(p);
            form.Show();
            Close();
        }
    }
}
