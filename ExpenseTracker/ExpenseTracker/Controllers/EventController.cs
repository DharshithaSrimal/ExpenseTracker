using ExpenseTracker.DataAccess;
using ExpenseTracker.DataAccess.Services;
using ExpenseTracker.Views.Event;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExpenseTracker.Controllers
{
    public class EventController
    {
        private readonly ExpenseTrackerDataSet _dataset;
        private readonly EventService _eventService;

        public EventController(ref ExpenseTrackerDataSet ds)
        {
            _dataset = ds;
            _eventService = new EventService(ref ds);
        }

        public BindingSource GetEventListBinding(string key, int? value)
        {
            SortedDictionary<string, int> keyValuePairs = new SortedDictionary<string, int>();

            if (!string.IsNullOrEmpty(key) && value.HasValue)
            {
                keyValuePairs.Add(key, value.Value);
            }

            foreach (ExpenseTrackerDataSet.EventRow row in _dataset.Event.ToList())
            {
                keyValuePairs.Add(row.Name, row.Id);
            }

            return (keyValuePairs.Count > 0) ? new BindingSource(keyValuePairs, null) : null;
        }

        public int SaveNew(string name, string location, DateTime dateTime, int? recurFrequency,
            int? occurrences, DateTime? untillWhen)
        {
            ExpenseTrackerDataSet.EventRow eventRow = _dataset.Event.NewEventRow();
            eventRow.Name = name;
            eventRow.DateTime = dateTime;
            eventRow.LastProcessed = DateTime.Now;
            if (string.IsNullOrWhiteSpace(location))
                eventRow.Location = location;
            if (recurFrequency.HasValue)
                eventRow.RecurFrequency = recurFrequency.Value;
            if (occurrences.HasValue)
                eventRow.Occurrences = occurrences.Value;
            if (untillWhen.HasValue)
                eventRow.UntillWhen = untillWhen.Value;

            return _eventService.AddAsync(eventRow).Result;
        }

        public Task<int> SaveNewAsync(string name, string location, DateTime dateTime, int? recurFrequency,
            int? occurrences, DateTime? untillWhen)
        {
            return Task.Run(() =>
            {
                return SaveNew(name, location, dateTime, recurFrequency, occurrences, untillWhen);
            });
        }

        public void ShowAddNewView()
        {
            AddEvent addEvent = new AddEvent(this);
            addEvent.ShowDialog();
        }
    }
}
