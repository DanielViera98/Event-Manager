namespace Event_Manager.PresenterItems
{
    public partial class AddPresenter : Form
    {
        private EventContext db = new EventContext();
        private Event e;
        private Presenter p;
        public AddPresenter(Event e, Presenter p)
        {
            this.e = e;
            this.p = p;
            InitializeComponent();
            label_Welcome.Text.Concat(e.Name);
            Location l = db.Locations.Find(e.Location);
            DateTime startTime = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 12, 0, 0);
            DateTime endTime = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 20, 0, 0);

            while (startTime < endTime)
            {
                comboBox_Timeslot.Items.Add(startTime.ToString("hh:mm tt"));
                startTime = startTime.AddMinutes(30);
            }
            for (int i = 0; i < 20; i++)
            {
                comboBox_Room.Items.Add(i);
            }
        }

        private void button_register_Click(object sender, EventArgs e)
        {
            try
            {
                db.Presents.Add(new Presents
                {
                    RoomID = (int)comboBox_Room.SelectedItem,
                    Title = textBox_Title.Text,
                    Description = textBox_description.Text,
                    Event = db.Events.Find(this.e.EventId),
                    Presenter = db.Presenters.Find(this.p.PresenterID),
                    Time = DateTime.Parse(comboBox_Timeslot.SelectedItem.ToString()).ToUniversalTime()
                });
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"ERROR: {ex.Message}");
            }
            
            Close();
        }
    }
}
