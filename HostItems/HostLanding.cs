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
        public HostLanding()
        {
            InitializeComponent();
        }

        private void button1_RegisterEvent(object sender, EventArgs e)
        {
            var newEvent = new AddEvent();
            newEvent.Show();
        }
    }
}
