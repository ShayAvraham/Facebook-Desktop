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
    public class TodayUserEvents : ITodayUserEvents
    {
        // Data members
        private FacebookConnector m_FacebookConnector = FacebookConnector.GetFacebookConnector;       

        public List<Event> GetUserTodayEvents(DateTime i_DateSelected)
        {
            List<Event> userTodayEvents = new List<Event>();

            foreach (Event fbEvent in m_FacebookConnector.Events)
            {
                if (fbEvent.StartTime == i_DateSelected)
                {
                    userTodayEvents.Add(fbEvent);
                }
            }

            return userTodayEvents;
        }
    }
}
