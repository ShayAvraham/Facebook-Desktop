using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;

namespace FacebookLogic
{
    public class TodayUserEventsAdapter : TodayUserEvents, ITodayUserEvents
    {
        public TodayUserEvents TodayUserEvents { get; private set; }

        public TodayUserEventsAdapter()
        {
            TodayUserEvents = new TodayUserEvents();
        }

        public List<Event> GetUserTodayEvents(DateTime i_DateSelected)
        {
            List<Event> userTodayEvents = TodayUserEvents.GetUserTodayEvents(i_DateSelected);
            userTodayEvents.OrderBy(key => key.StartTime);

            return userTodayEvents;
        }
    }
}
