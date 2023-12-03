using Event_Manager.LocationItems;
using Event_Manager.PresenterItems;
using Event_Manager.Registration___Login;
using Event_Manager.VendorItems;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query.SqlExpressions;
using Microsoft.EntityFrameworkCore.Storage;

namespace Event_Manager
{
    public partial class Entry_Form : Form
    {
        public Entry_Form()
        {
            InitializeComponent();
        }

        private async void button_LogIn_Click(object sender, EventArgs e)
        {
            //Declare variables
            char[] tests = "\'\"\\".ToCharArray();
            var db = new EventContext();
            List<string> inputs = new List<string> { comboBox_Login.Text, textBox_Username.Text, textBox_Password.Text };
            string accountType = comboBox_Login.Text;
            int minUsernameAndPasswordSize = 4;
            Account account;

            //Check that the user selected an account type, entries are not null, empty, or < a certain size. Also check if account exists.
            //Throw exception otherwise.
            try
            {
                if (!Functions.CheckNull(inputs) || !Functions.CheckMin(inputs, minUsernameAndPasswordSize) || !db.Accounts.Any(p => p.UserName == textBox_Username.Text))
                    throw new Exception($"Failed a Requirement:\nMust have an account as {accountType}\nMinimum Username and Password Size: {minUsernameAndPasswordSize}.");
                if (Functions.CheckContains(inputs, tests))
                    throw new Exception("Entry contains invalid characters");
                account = (await db.Accounts.FromSqlRaw($"CALL \"LoginUser\" (\'{textBox_Username.Text}\', \'{textBox_Password.Text}\', \'{comboBox_Login.Text}\')").ToListAsync()).First();
                if (account.AccountType == "hello")
                    throw new Exception("Cannot confirm account details.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            //Select the database entry corresponding to the account and open the relevant form.
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
            //Open new registration form. Note no admin form exists, as admins should only be able to be added by other admins.
            try
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
                else if (radioButton_Host.Checked)
                    reg = new RegisterHost_Form();
                else
                    throw new Exception("Must select an account type.");
                reg.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }
    }
}