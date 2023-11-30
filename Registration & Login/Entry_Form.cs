using Event_Manager.Registration___Login;

namespace Event_Manager
{
    public partial class Entry_Form : Form
    {
        public Entry_Form()
        {
            InitializeComponent();
        }

        private void button_LogIn_Click(object sender, EventArgs e)
        {
            var db = new EventContext();
            var accountType = comboBox_Login.Text;
            if (accountType == "Attendee" && textBox1.Text != "" && textBox2.Text != "")
            {
                var currUser = db.Attendees.Where(p => p.Name == textBox1.Text).FirstOrDefault();
                if (currUser == null)
                {
                    MessageBox.Show("Must have an account as an Attendee.");
                    return;
                }
                User_Form user = new User_Form(currUser);
                user.Show();
            }
            else if (accountType == "Host" && textBox1.Text != "" && textBox2.Text != "")
            {
                var currHost = db.Hosts.Where(p => p.Name == textBox1.Text).FirstOrDefault();
                if (currHost == null)
                {
                    MessageBox.Show("Must have an account as a Host.");
                    return;
                }

                var hostZone = new HostLanding(currHost);
                hostZone.Show();
            }

        }

        private void button_Register_Click(object sender, EventArgs e)
        {
            dynamic reg;
            if (radioButton_Attendee.Checked)
                reg = new RegisterAttendee_Form();
            else if (radioButton_Employee.Checked)
                reg = new RegisterEmployee_Form();
            else if (radioButton_Presenter.Checked)
                reg = new RegisterPresenter_Form();
            else if (radioButton_Vendor.Checked)
                reg = new RegisterVendor_Form();
            else //(radioButton_Host.Checked)
                reg = new RegisterHost_Form();
            //else reg = new Entry_Form();
            reg.Show();
        }
    }
}