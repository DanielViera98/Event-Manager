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
                var hostZone = new HostLanding();
                hostZone.Show();
            }

        }

        private void button_Register_Click(object sender, EventArgs e)
        {
            if (radioButton_Attendee.Checked)
            {
                var reg = new RegisterAttendee_Form();
                reg.Show();
            }
            if (radioButton_Employee.Checked)
            {
                var reg = new RegisterEmployee_Form();
                reg.Show();
            }
            if (radioButton_Presenter.Checked)
            {
                var reg = new RegisterPresenter_Form();
                reg.Show();
            }
            if (radioButton_Vendor.Checked)
            {
                var reg = new RegisterVendor_Form();
                reg.Show();
            }
            if (radioButton_Host.Checked)
            {
                var reg = new RegisterHost_Form();
                reg.Show();
            }
            if (radioButton_Admin.Checked)
            {
                var reg = new Admin_Form();
                reg.Show();
            }

        }
    }
}