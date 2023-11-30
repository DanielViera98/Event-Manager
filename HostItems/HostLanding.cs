using Event_Manager.HostItems;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Event_Manager
{
    public partial class HostLanding : Form
    {
        Host hostUser;
        public HostLanding(Host host)
        {
            InitializeComponent();

            refresh_view();

            hostUser = host;
        }

        private void button_RegisterEvent_Click(object sender, EventArgs e)
        {
            var newEvent = new AddEvent(hostUser);
            newEvent.Show();
        }

        private void button_Refresh_Click(object sender, EventArgs e)
        {
            refresh_view();
        }

        private void refresh_view()
        {
            var db = new EventContext();
            var eventSource = new BindingList<Event>();
            foreach (var local in db.Events)
            {
                eventSource.Add(local);
            }
            dataGridView_Events.DataSource = eventSource;
        }
    }
}
