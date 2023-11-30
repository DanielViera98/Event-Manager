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
    public partial class VendorLanding : Form
    {
        Vendor currVendor;
        public VendorLanding(Vendor vendor)
        {
            InitializeComponent();
            refresh_view();
            currVendor = vendor;
        }
        private void refresh_view()
        {
            var db = new EventContext();
            var vendorSource = new BindingList<Event>();
            foreach (var local in db.Events)
            {
                vendorSource.Add(local);
            }
            dataGridView_Vendors.DataSource = vendorSource;
        }
        private void button_register_Click(object sender, EventArgs e)
        {
            var selected = dataGridView_Vendors.SelectedRows;
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
                var temp2 = (Guid)dataGridView_Vendors.SelectedRows[i].Cells[0].Value;
                var temp = db.Events.Where(s => s.EventId == (Guid)dataGridView_Vendors.SelectedRows[i].Cells[0].Value).First();
                if (temp != null)
                {
                    db.HasSpace.Add(new HasSpace(3, 5, db.Vendors.Find(currVendor.VendorID), temp));
                }
            }
            db.SaveChanges();
        }
    }
}
