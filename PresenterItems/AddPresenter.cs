using Microsoft.EntityFrameworkCore;

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
            Location l = e.Location;
            DateTime startTime = e.StartDate;
            DateTime endTime = e.EndDate;

            while (startTime < endTime)
            {
                comboBox_Timeslot.Items.Add(startTime.ToString("hh:mm tt"));
                startTime = startTime.AddMinutes(30);
            }
            //add every room to the list
            for (int i = 0; i < l.Rooms; i++)
                comboBox_Room.Items.Add(i);
        }

        private void button_register_Click(object sender, EventArgs e)
        {
            try
            {
                //Add to presents table
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
                throw new Exception("Timeslot/Room taken");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"ERROR: {ex.Message}");
            }
            
            Close();
        }
    }
}
