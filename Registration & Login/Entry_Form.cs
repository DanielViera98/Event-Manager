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
            if (radioButton_Attendee.Checked)
            {
                var reg = new RegisterAttendee_Form();
                reg.Show();
            }
        }
    }
}