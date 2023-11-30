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

namespace Event_Manager.LocationItems
{
    public partial class LocationLanding : Form
    {
        public LocationLanding()
        {
            InitializeComponent();
            refresh_view();
        }

        private void button_addLocation_Click(object sender, EventArgs e)
        {
            var newLocal = new AddLocation();
            newLocal.Show();
        }

        private void button_Refresh_Click(object sender, EventArgs e)
        {
            refresh_view();
        }

        private void refresh_view()
        {
            var db = new EventContext();
            var localSource = new BindingList<Location>();
            foreach (var local in db.Locations)
            {
                localSource.Add(local);
            }
            dataGridView_Locations.DataSource = localSource;
        }
    }
}
