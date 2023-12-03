using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
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
    public partial class ViewPresenters : Form
    {
        DbSet<EventContext.PresenterView> view;
        Presenter p;
        EventContext db;
        public ViewPresenters(DbSet<EventContext.PresenterView> view, List<Guid> guids, Presenter p)
        {
            InitializeComponent();
            this.p = p;
            this.view = view;
            db = new EventContext();
            refresh_view();
        }
        private void refresh_view()
        {
            //Select columns, add as datasource to datagridview
            if (!checkBox_ViewUserPresents.Checked)
            {
                var temp = view.Select(s => new
                {
                    EventID = s.EventId,
                    EventName = s.eventname,
                    StartDate = s.StartDate,
                    EndDate = s.EndDate,
                    HostName = s.hostname,
                    s.PresenterID,
                    Presenter = s.presentername,
                    PresentationDescription = s.presentationdescription,
                    PresentationTime = s.Time,
                    PresentationRoom = s.RoomID
                }).Where(s => s.EventName != null)
                .ToList();
                BindingList<object> items = new BindingList<object>(temp.Cast<object>().ToList());
                dataGridView_Presenters.DataSource = items;
            }
            else
            {
                var temp = view.Select(s => new
                {
                    EventID = s.EventId,
                    s.PresenterID,
                    EventName = s.eventname,
                    StartDate = s.StartDate,
                    EndDate = s.EndDate,
                    HostName = s.hostname,
                    Presenter = s.presentername,
                    PresentationDescription = s.presentationdescription,
                    PresentationTime = s.Time,
                    PresentationRoom = s.RoomID
                }).Where(s => s.EventName != null && (s.PresenterID == p.PresenterID))
                .ToList();
                BindingList<object> items = new BindingList<object>(temp.Cast<object>().ToList());
                dataGridView_Presenters.DataSource = items;
            }
        }
        private void button_close_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void dataGridView_Presenters_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.ThrowException = false;
            e.Cancel = true;
        }
        private void button_refresh_Click(object sender, EventArgs e)
        {
            refresh_view();
        }
        private void button_DeletePresentation_Click(object sender, EventArgs e)
        {
            //Get selection of rows
            var selection = dataGridView_Presenters.SelectedRows;
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
                    var foundPresents = db.Presents.Where(s => s.Event == foundEvent && s.Presenter == p);
                    if (foundPresents.Count() == 0)
                        throw new Exception("Cannot Delete an Event you are not Hosting.");
                    db.Presents.RemoveRange(foundPresents);
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

        private void checkBox_ViewUserPresents_CheckedChanged(object sender, EventArgs e)
        {
            refresh_view();
        }
    }
}
