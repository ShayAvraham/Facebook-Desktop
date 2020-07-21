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
    public interface ITodayUserEvents
    {
        List<Event> GetUserTodayEvents(DateTime i_DateSelected);
    }
}




