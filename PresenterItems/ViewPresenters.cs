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
        public ViewPresenters(DbSet<EventContext.PresenterView> view, List<Guid> guids, Presenter p)
        {
            InitializeComponent();
            this.p = p;
            this.view = view;
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
    }
}
