using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Event_Manager.PresenterItems
{
    public partial class PresenterLanding : Form
    {
        public PresenterLanding()
        {
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
        private void button_Register_Click(object sender, EventArgs e)
        {

        }
    }
}
