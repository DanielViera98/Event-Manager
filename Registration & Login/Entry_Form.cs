using Event_Manager.LocationItems;
using Event_Manager.PresenterItems;
using Event_Manager.Registration___Login;
using Event_Manager.VendorItems;

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
            string accountType = comboBox_Login.Text;
            if (textBox1.Text == "" || textBox2.Text == "" || accountType == "" || !db.Accounts.Any(p => p.UserName == textBox1.Text))
            {
                MessageBox.Show($"Must have an account as {accountType}, and must type username and password.");
                return;
            }
            var account = db.Accounts.Where(p => p.UserName == textBox1.Text && p.Password == textBox2.Text && accountType == p.AccountType).FirstOrDefault();
            if (account == null)
            {
                MessageBox.Show("Account not found.");
                return;
            }
            if (accountType == "Attendee")
            {
                Attendee currUser = db.Attendees.Where(p => p.AttendeeID == account.AccountID).First();
                User_Form user = new User_Form(currUser);
                user.Show();
            }
            else if (accountType == "Host")
            {
                var currHost = db.Hosts.Where(p => p.HostID == account.AccountID).First();

                var hostZone = new HostLanding(currHost);
                hostZone.Show();
            }
            else if (accountType == "Vendor")
            {
                var currVendor = db.Vendors.Where(p => p.VendorID == account.AccountID).First();

                var hostZone = new VendorLanding(currVendor);
                hostZone.Show();
            }
            else if (accountType == "Presenter")
            {
                var currPresenter = db.Presenters.Where(p => p.PresenterID == account.AccountID).First();

                var presenterZone = new PresenterLanding(currPresenter);
                presenterZone.Show();
            }
            else if (accountType == "Admin")
            {
                var adminZone = new Admin_Form();
                adminZone.Show();
                var locationZone = new AddLocation();
                locationZone.Show();
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
            else
                reg = new RegisterHost_Form();
            reg.Show();
        }
    }
}