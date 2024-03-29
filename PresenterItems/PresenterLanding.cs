﻿using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using System.Data;

namespace Event_Manager.PresenterItems
{

    public partial class PresenterLanding : Form
    {
        //Initialize class variables
        private EventContext db = new EventContext();
        private DbSet<EventContext.PresenterView> view;
        private Presenter p;
        private BindingList<object> items;
        public PresenterLanding(Presenter p)
        {
            //Initialize private variables view and p
            this.p = p;
            view = db.PresenterViews;

            //Initialize components and refresh view
            InitializeComponent();
            refresh_view();
        }
        private void refresh_view()
        {
            //Get all the desired items in the view and present it to the user
            var temp = view.Select(s => new
            {
                EventID = s.EventId,
                EventName = s.eventname,
                EventDescription = s.eventdescription,
                StartDate = s.StartDate,
                EndDate = s.EndDate,
                EventWebsite = s.eventwebsite,
                Location = s.locationname,
                Address = s.LocationAddress,
                LocationWebsite = s.locationwebsite,
                HostName = s.hostname,
                HostWebsite = s.hostwebsite
            }).Where(s => s.EventID != null).Distinct().ToList();
            items = new BindingList<object>(temp.Cast<object>().ToList());
            dataGridView_Presenters.DataSource = items;
        }
        private void button_register_Click(object sender, EventArgs e)
        {
            //Get all selected rows, if no rows selected throw exception
            var selected = dataGridView_Presenters.SelectedRows;
            try
            {
                if (selected.Count <= 0)
                    throw new Exception("Must Select an Event.");

                //take the eventid from every row, add the current presenter to addpresents for the events
                for (int i = 0; i < selected.Count; i++)
                {
                    var temp2 = (Guid)dataGridView_Presenters.SelectedRows[i].Cells[0].Value;
                    //Prevent lazy loading
                    var temp = db.Events.Include(e => e.Location).FirstOrDefault(e => e.EventId == temp2);
                    if (temp != null)
                    {
                        var addPresent = new AddPresenter(temp, p);
                        addPresent.Show();
                    }
                    else
                        throw new Exception("Error finding Event");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            refresh_view();
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button_ShowPresenters_Click(object sender, EventArgs e)
        {
            //Get selected rows
            var selected = dataGridView_Presenters.SelectedRows;
            if (selected.Count <= 0)
            {
                MessageBox.Show("Must Select an Event.");
                return;
            }
            //get event guids, sent to new viewpresenters form
            List<Guid> guids = new List<Guid>();
            for (int i = 0; i < selected.Count; i++)
                guids.Add((Guid)dataGridView_Presenters.SelectedRows[i].Cells[0].Value);
            ViewPresenters newForm = new ViewPresenters(view, guids, p);
            newForm.Show();
        }

        //Was throwing exception, added to ignore for now since it didn't affect results 
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
