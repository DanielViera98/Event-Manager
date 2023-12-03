using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Event_Manager.VendorItems
{
    public partial class ViewVendors : Form
    {
        private EventContext db;
        public ViewVendors(Event e, Vendor v, DbSet<EventContext.VendorView> view)
        {
            InitializeComponent();
            
        }
        private void refresh_view()
        {

        }

        private void button_refresh_Click(object sender, EventArgs e)
        {

        }
    }
}
