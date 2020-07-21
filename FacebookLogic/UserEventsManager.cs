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
    public class UserEventsManager : UserActivityManager<Event>
    {
        // Data members
        private FacebookConnector m_FacebookConnector = FacebookConnector.GetInstance;

        public override void GetUserTodaySpecificActivity(DateTime i_DateSelected, ref List<Event> o_UserTodayActivity)
        {
            foreach (Event fbEvent in m_FacebookConnector.Events)
            {
                if (fbEvent.StartTime == i_DateSelected)
                {
                    o_UserTodayActivity.Add(fbEvent);
                }
            }
        }
    }
}
