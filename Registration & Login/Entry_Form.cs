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
            var accountType = comboBox_Login.Text;

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