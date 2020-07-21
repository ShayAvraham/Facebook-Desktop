using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;
using System.Collections;
using System.Threading;

namespace FacebookLogic
{
    public class MyBestFriendsFinder
    {
        // Data members
        private UserFriendsManager r_userFriendManager;
        public List<bool> SearchFilters { get; private set; }
        public List<Friend> MyBestFriends { get; private set; }
        private IEnumerator<Friend> MyBestFriendsEnumerator { get; set; }

        public MyBestFriendsFinder()
        {
            r_userFriendManager = new UserFriendsManager();
        }

        public void FindMyBestFriends(int i_NumOfBestFriends, List<bool> i_SearchFilters)
        {
            SearchFilters = i_SearchFilters;
            r_userFriendManager.FindMyBestFriends(i_SearchFilters);
            MyBestFriendsEnumerator = r_userFriendManager.GetEnumerator(i_NumOfBestFriends);
            generateBestFriendCollection();
        }

        private void generateBestFriendCollection()
        {
            MyBestFriends = new List<Friend>();

            while (MyBestFriendsEnumerator.MoveNext())
            {
                MyBestFriends.Add(MyBestFriendsEnumerator.Current);
            }
        }
    }
}
