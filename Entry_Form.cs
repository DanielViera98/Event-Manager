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
            Register_Form reg = new Register_Form();
            reg.Show();
        }
    }
}