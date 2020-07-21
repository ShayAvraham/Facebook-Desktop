using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacebookLogic
{
    public class UserTasksManager : UserActivityManager<Task>
    {
        // Defines
        private const string k_EmptyTaskError = "You can not add an empty task !";
        private const string k_AddTaskWindowMessage = "Write Something...";

        // Data members
        private readonly List<Task> r_UserTasks = new List<Task>();


        public override void GetUserTodaySpecificActivity(DateTime i_DateSelected, ref List<Task> o_UserTodayActivity)
        {
            foreach (Task task in r_UserTasks)
            {
                if (task.Date == i_DateSelected)
                {
                    o_UserTodayActivity.Add(task);
                }
            }
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
