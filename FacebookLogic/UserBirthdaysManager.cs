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
    public class UserBirthdaysManager : UserActivityManager<User>
    {
        // Data members
        private FacebookConnector m_FacebookConnector = FacebookConnector.GetInstance;

        public override void GetUserTodaySpecificActivity(DateTime i_DateSelected, ref List<User> o_UserTodayActivity)
        {
            foreach (User friend in m_FacebookConnector.Friends)
            {
                if (friend.Birthday == i_DateSelected.ToShortDateString())
                {
                    o_UserTodayActivity.Add(friend);
                }
            }
        }
    }
}