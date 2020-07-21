using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacebookLogic
{
    public class TodayUserTasks
    {
        // Defines
        private const string k_EmptyTaskError = "You can not add an empty task !";
        private const string k_AddTaskWindowMessage = "Write Something...";

        // Data members
        private FacebookConnector m_FacebookConnector = FacebookConnector.GetFacebookConnector;
        private readonly List<Task> r_UserTasks = new List<Task>();

        public List<Task> GetUserTodayTasks(DateTime i_DateSelected)
        {
            List<Task> userTodayTasks = new List<Task>();

            foreach (Task task in r_UserTasks)
            {
                if (task.Date == i_DateSelected)
                {
                    userTodayTasks.Add(task);
                }
            }

            return userTodayTasks;
        }

        public void AddTask(string i_TaskDescription, DateTime i_DateSelected)
        {
            if (!string.IsNullOrEmpty(i_TaskDescription) && i_TaskDescription != k_AddTaskWindowMessage)
            {
                Task newTask = new Task(i_TaskDescription, i_DateSelected);
                r_UserTasks.Add(newTask);
            }
            else
            {
                throw new Exception(k_EmptyTaskError);
            }
        }

        public void RemoveTask(Task i_TaskToRemove)
        {
            r_UserTasks.Remove(i_TaskToRemove);
        }

        public void CleanTaskList()
        {
            r_UserTasks.Clear();
        }
    }
}
