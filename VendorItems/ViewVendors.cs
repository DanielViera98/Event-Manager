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
        Vendor v;
        DbSet<EventContext.VendorView> view;
        List<Guid> ids;
        public ViewVendors(List<Guid> guids, Vendor v, DbSet<EventContext.VendorView> view)
        {
            InitializeComponent();
            this.v = v;
            this.view = view;
            ids = guids;
            db = new EventContext();
            refresh_view();
        }
        private void refresh_view()
        {
            //Select columns, add as datasource to datagridview
            if (!checkBox_ViewUserVendor.Checked)
            {
                var temp = view.Select(s => new
                {
                    EventID = s.EventID,
                    EventName = s.eventname,
                    StartDate = s.StartDate,
                    EndDate = s.EndDate,
                    s.LocationName,
                    s.VendorCapacity,
                    s.VendorID,
                    s.VendorName,
                    s.RoomID,
                    s.TableID
                }).Where(s => s.EventName != null && s.VendorID != null && ids.Contains((Guid)s.EventID) == true)
                .ToList();
                BindingList<object> items = new BindingList<object>(temp.Cast<object>().ToList());
                dataGridView_Vendors.DataSource = items;
            }
            else
            {
                var temp = view.Select(s => new
                {
                    EventID = s.EventID,
                    EventName = s.eventname,
                    StartDate = s.StartDate,
                    EndDate = s.EndDate,
                    s.LocationName,
                    s.VendorCapacity,
                    s.VendorID,
                    s.VendorName,
                    s.RoomID,
                    s.TableID
                }).Where(s => s.EventName != null && s.VendorID != null && (s.VendorID == v.VendorID))
                .ToList();
                BindingList<object> items = new BindingList<object>(temp.Cast<object>().ToList());
                dataGridView_Vendors.DataSource = items;
            }
        }

        private void button_refresh_Click(object sender, EventArgs e)
        {
            refresh_view();
        }

        private void checkBox_ViewUserVendor_CheckedChanged(object sender, EventArgs e)
        {
            refresh_view();
        }

        private void button_close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button_DeleteVendor_Click(object sender, EventArgs e)
        {
            //Get selection of rows
            var selection = dataGridView_Vendors.SelectedRows;
            try
            {
                //If nothing selected, throw ex.
                if (selection.Count == 0)
                    throw new Exception("Must select a row");

                //check if any row selected is not presented by user, if so throw ex. Otherwise delete the row from the database.
                foreach (DataGridViewRow row in selection)
                {
                    //Find the event associated with the row
                    Event foundEvent = db.Events.Find((Guid)row.Cells["EventID"].Value);

                    //check if the presentation is presented by the user.
                    var foundVendors = db.HasSpace.Where(s => s.Event == foundEvent && s.Vendor == v);
                    if (foundVendors.Count() == 0)
                        throw new Exception("Cannot Delete vendor not associated with your account.");
                    db.HasSpace.RemoveRange(foundVendors);
                }
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            db.SaveChanges();
            refresh_view();
        }
    }
}
