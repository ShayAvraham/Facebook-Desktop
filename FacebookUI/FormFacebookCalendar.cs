using FacebookLogic;
using FacebookWrapper.ObjectModel;
using System;
using System.Threading;
using System.Collections.Generic;
using System.Windows.Forms;

namespace FacebookUI
{
    public partial class FormFacebookCalendar : Form
    {
        //Defines
        private const string k_Birthday = "birthdays";
        private const string k_Events = "events";
        private const string k_Tasks = "tasks";
        private const string k_TaskAddMessage = "Task added succesfully";
        private const string k_AddTaskWindowMessage = "Write Something...";
        private readonly string k_EventsPremissionError = "Sorry, No Permission For Events.";
        private readonly string k_BirthdaysPremissionError = "Sorry, No Permission For Friend's Birthdays.";

        // Data members
        private readonly FacebookCalendar r_FacebookCalendar;

        public FormFacebookCalendar()
        {
            r_FacebookCalendar = new FacebookCalendar();
            InitializeComponent();
            showLabelNames();
            showTodayTasks(monthCalendar.SelectionStart);
        }

        private void uploadProfilePicture()
        {
            if (!pictureBoxProfile.InvokeRequired)
            {
                facebookConnectorBindingSource.DataSource = FacebookConnector.GetInstance;
            }
            else
            {
                pictureBoxProfile.Invoke(new Action(() => facebookConnectorBindingSource.DataSource = FacebookConnector.GetInstance));
            }
        }

        private void showLabelNames()
        {
            labelSelectedDate.Text = monthCalendar.SelectionStart.ToShortDateString();
            textBoxTodayBirthdays.Text = String.Format(" Birthdays At {0}", labelSelectedDate.Text);
            textBoxTodayEvents.Text = String.Format(" Events On {0}", labelSelectedDate.Text);
            textBoxTodayTasks.Text = String.Format(" Tasks On {0}", labelSelectedDate.Text);
        }

        private void showTodayBirthdays(DateTime i_DateSelected)
        {
            try
            {
                listBoxTodayBirthdays.Invoke(new Action(() => listBoxTodayBirthdays.Items.Clear()));

                List<User> userTodayBirthdays = r_FacebookCalendar.GetUserTodayBirthdays(i_DateSelected);

                if (userTodayBirthdays.Count > 0)
                {
                    foreach (User friend in userTodayBirthdays)
                    {
                        listBoxTodayBirthdays.Invoke(new Action(() => listBoxTodayBirthdays.Items.Add(friend.UserName)));
                    }
                }
                else
                {
                    listBoxTodayBirthdays.Invoke(new Action(() => listBoxTodayBirthdays.Items.Add(string.Format("No {0} for today", k_Birthday))));
                }
            }
            catch 
            {
                listBoxTodayBirthdays.Invoke(new Action(() => listBoxTodayBirthdays.Items.Clear()));
                listBoxTodayBirthdays.Invoke(new Action(() => listBoxTodayBirthdays.Items.Add(k_BirthdaysPremissionError)));
            }
        }

        private void showTodayEvents(DateTime i_DateSelected)
        {
            try
            {
                listBoxTodayEvents.Invoke(new Action(() => listBoxTodayEvents.Items.Clear()));

                List<Event> userTodayEvents = r_FacebookCalendar.GetUserTodayEvents(i_DateSelected);

                if (userTodayEvents.Count > 0)
                {
                    foreach (Event fbEvent in userTodayEvents)
                    {
                        listBoxTodayEvents.Invoke(new Action(() => listBoxTodayEvents.Items.Add(fbEvent.Name)));
                    }
                }
                else
                {
                    listBoxTodayEvents.Invoke(new Action(() => listBoxTodayEvents.Items.Add(string.Format("No {0} for today", k_Events))));
                }
            }
            catch 
            {
                listBoxTodayEvents.Invoke(new Action(() => listBoxTodayEvents.Items.Clear()));
                listBoxTodayEvents.Invoke(new Action(() => listBoxTodayEvents.Items.Add(k_EventsPremissionError)));
            }
        }

        private void showTodayTasks(DateTime i_DateSelected)
        {
            listBoxTodayTasks.Items.Clear();

            List<Task> userTodayTasks = r_FacebookCalendar.GetUserTodayTasks(i_DateSelected);

            if (userTodayTasks.Count > 0)
            {
                foreach (Task task in userTodayTasks)
                {
                    listBoxTodayTasks.Items.Add(task.Description);
                }
            }
            else
            {
                listBoxTodayTasks.Items.Add(string.Format("No {0} for today", k_Tasks));
            }
        }

        private void TextBoxCreateNewTask_Click(object sender, EventArgs e)
        {
            textBoxCreateNewTask.Clear();
        }

        private void ButtonAddTask_Click(object sender, EventArgs e)
        {
            try
            {
                r_FacebookCalendar.AddTask(textBoxCreateNewTask.Text, monthCalendar.SelectionStart);
                textBoxCreateNewTask.Clear();
                MessageBox.Show(k_TaskAddMessage);
                showTodayTasks(monthCalendar.SelectionStart);
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
            textBoxCreateNewTask.Text = k_AddTaskWindowMessage;
        }

        private void ButtonRemoveTasks_Click(object sender, EventArgs e)
        {
            if (listBoxTodayTasks.SelectedItems.Count > 0)
            {
                List<Task> userTodayTasks = r_FacebookCalendar.GetUserTodayTasks(monthCalendar.SelectionStart);

                foreach (Task task in userTodayTasks)
                {
                    if (task.Description == listBoxTodayTasks.SelectedItems[0].ToString())
                    {
                        listBoxTodayTasks.Items.Remove(listBoxTodayTasks.SelectedItems[0]);
                        if (listBoxTodayTasks.Items.Count == 0)
                        {
                            listBoxTodayTasks.Items.Add(string.Format("No {0} for today", k_Tasks));
                        }
                        r_FacebookCalendar.RemoveTask(task);
                        break;
                    }
                }
            }
            else
            {
                MessageBox.Show("you have not picked any task");
            }
        }

        private void MonthCalendar_DateSelected(object sender, DateRangeEventArgs e)
        {
            showLabelNames();
            showTodayTasks(e.Start);
            if (listBoxTodayBirthdays.Items[0].ToString() != k_BirthdaysPremissionError)
            {
                showTodayBirthdays(e.Start);
            }
            if (listBoxTodayEvents.Items[0].ToString() != k_EventsPremissionError)
            {
                showTodayEvents(e.Start);
            }
        }

        private void ButtonStartMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ButtonFacebookBestFriend_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
                new FormMyBestFriendsFinder().ShowDialog();
            }
            catch(Exception exp)
            {
                MessageBox.Show(exp.Message);
                buttonFacebookBestFriends.Enabled = false;
            }
        }

        private void FormFacebookCalendar_Activated(object sender, EventArgs e)
        {
            new Thread(() => uploadProfilePicture()).Start();
            new Thread(() => showTodayBirthdays(monthCalendar.SelectionStart)).Start();
            new Thread(() => showTodayEvents(monthCalendar.SelectionStart)).Start();
        }
    }
}
