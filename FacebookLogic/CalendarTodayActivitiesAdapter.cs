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
    public class CalendarTodayActivitiesAdapter
    {
        private readonly FacebookCalendar r_FacebookCalendar = new FacebookCalendar();
        public List<User> TodayBirthdays { get; set; }
        public List<Event> TodayEvents { get; set; }
        public List<Task> TodayTasks { get; set; }
        //private List<User> m_TodayBirthdays;
        //private List<Event> m_TodayEvents;
        //private List<Task> m_TodayTasks;

        public CalendarTodayActivitiesAdapter(DateTime i_DateSelected)
        {
            TodayBirthdays = r_FacebookCalendar.GetUserTodayBirthdays(i_DateSelected);
            TodayEvents = r_FacebookCalendar.GetUserTodayEvents(i_DateSelected);
            TodayTasks = r_FacebookCalendar.GetUserTodayTasks(i_DateSelected);
        }
    }
}
