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
    public class FacebookCalendar
    {
        // Data members       
        private readonly UserBirthdaysManager r_UserTodayBirthdays;
        private readonly UserEventsManager r_UserTodayEvents;
        private readonly UserTasksManager r_UserTodayTasks;

        public FacebookCalendar()
        {
            r_UserTodayBirthdays = new UserBirthdaysManager();
            r_UserTodayEvents = new UserEventsManager();
            r_UserTodayTasks = new UserTasksManager();
        }


        public List<User> GetUserTodayBirthdays(DateTime i_DateSelected)
        {
            return r_UserTodayBirthdays.GetUserTodayActivity(i_DateSelected);
        }

        public List<Event> GetUserTodayEvents(DateTime i_DateSelected)
        {
            return r_UserTodayEvents.GetUserTodayActivity(i_DateSelected);
        }

        public List<Task> GetUserTodayTasks(DateTime i_DateSelected)
        {
            return r_UserTodayTasks.GetUserTodayActivity(i_DateSelected);
        }

        public void AddTask(string i_TaskDescription, DateTime i_DateSelected)
        {
            r_UserTodayTasks.AddTask(i_TaskDescription, i_DateSelected);
        }

        public void RemoveTask(Task i_TaskToRemove)
        {
            r_UserTodayTasks.RemoveTask(i_TaskToRemove);
        }

        public void CleanTaskList()
        {
            r_UserTodayTasks.CleanTaskList();
        }
    }
}
