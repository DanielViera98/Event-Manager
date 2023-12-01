using Microsoft.EntityFrameworkCore;
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
        public ViewPresenters(DbSet<EventContext.PresenterView> view, List<Guid> guids)
        {
            InitializeComponent();

            //Select columns, add as datasource to datagridview
            var temp = view.Select(s => new
            {
                EventName = s.eventname,
                StartDate = s.StartDate,
                EndDate = s.EndDate,
                HostName = s.hostname,
                Presenter = s.presentername,
                PresentationDescription = s.presentationdescription,
                PresentationTime = s.Time,
                PresentationRoom = s.RoomID
            }).Where(s => s.EventName != null && s.StartDate != null && s.EndDate != null &&
                s.HostName != null && s.Presenter != null && s.PresentationDescription != null && 
                s.PresentationTime != null && s.PresentationRoom != null)
            .ToList();
            BindingList<object> items = new BindingList<object>(temp.Cast<object>().ToList());
            dataGridView_Presenters.DataSource = items;
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
    }
}
