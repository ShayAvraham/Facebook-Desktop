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
    public class TodayUserBirthdays
    {
        // Data members
        private FacebookConnector m_FacebookConnector = FacebookConnector.GetFacebookConnector;

        public List<User> GetUserTodayBirthdays(DateTime i_DateSelected)
        {
            List<User> userTodayBirthdays = new List<User>();

            foreach (User friend in m_FacebookConnector.Friends)
            {
                if (friend.Birthday == i_DateSelected.ToShortDateString())
                {
                    userTodayBirthdays.Add(friend);
                }
            }

            return userTodayBirthdays;
        }
    }
}
