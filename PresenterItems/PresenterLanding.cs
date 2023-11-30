using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Event_Manager.PresenterItems
{
    public partial class PresenterLanding : Form
    {
        private Presenter p;
        public PresenterLanding(Presenter p)
        {
            this.p = p;
            InitializeComponent();
            refresh_view();
        }
        private void refresh_view()
        {
            var db = new EventContext();
            var presenterSource = new BindingList<Event>();
            foreach (var local in db.Events)
            {
                presenterSource.Add(local);
            }
            dataGridView_Presenters.DataSource = presenterSource;
        }
        private void button_register_Click(object sender, EventArgs e)
        {
            var selected = dataGridView_Presenters.SelectedRows;
            if (selected.Count <= 0)
            {
                MessageBox.Show("Must Select an Event.");
                return;
            }
            string selection = "";
            for (int i = 0; i < selected.Count; i++)
            {
                selection = selection + "\n" + selected[i].Cells[1].Value;
            }
            var db = new EventContext();
            for (int i = 0; i < selected.Count; i++)
            {
                var temp2 = (Guid)dataGridView_Presenters.SelectedRows[i].Cells[0].Value;
                var temp = db.Events.First(s => s.EventId == temp2);
                if (temp != null)
                {
                    var addPresent = new AddPresenter(temp, p);
                    addPresent.Show();
                }
                else
                    MessageBox.Show("Error finding Event");
            }
        }
    }
}
