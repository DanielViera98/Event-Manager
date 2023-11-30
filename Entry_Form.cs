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
                if (currUser == null ) 
                {
                    MessageBox.Show("Must have an account as an Attendee.");
                    return;
                }
                User_Form user = new User_Form(currUser);
                user.Show();
            }
        }

        private void button_Register_Click(object sender, EventArgs e)
        {
            Register_Form reg = new Register_Form();
            reg.Show();
        }
    }
}