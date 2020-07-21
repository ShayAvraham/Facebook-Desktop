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
    public abstract class UserActivityManager<T>
    {
        // Data members
        private FacebookConnector m_FacebookConnector = FacebookConnector.GetInstance;

        public List<T> GetUserTodayActivity(DateTime i_DateSelected)
        {
            List<T> userTodayActivity = new List<T>();

            GetUserTodaySpecificActivity(i_DateSelected, ref userTodayActivity);

            return userTodayActivity;
        }

        public abstract void GetUserTodaySpecificActivity(DateTime i_DateSelected, ref List<T> o_UserTodayActivity);
    }
}
