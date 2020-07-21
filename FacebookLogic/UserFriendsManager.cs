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
    public class UserFriendsManager : IEnumerable
    {
        // Data members
        private FacebookConnector m_FacebookConnector = FacebookConnector.GetInstance;
        private List<Friend> m_Friends = null;

        public int NumOfFriends
        {
            get
            {
                return m_FacebookConnector.Friends.Count;

            }
            private set
            {
                NumOfFriends = value;
            }
        }
        public UserFriendsManager()
        {
            new Thread(fetchFriends).Start();
        }

        public void FindMyBestFriends(List<bool> i_SearchFilters)
        {
            List<Friend> myBestFriends = new List<Friend>();

            foreach (Friend friend in m_Friends)
            {
                friend.UpdateScore(i_SearchFilters);
            }
            m_Friends = m_Friends.OrderByDescending(key => key.Score).ToList();
        }

        public IEnumerator GetEnumerator()
        {
            return (from friend in m_Friends
                    select friend)
                    .GetEnumerator();
        }

        public IEnumerator<Friend> GetEnumerator(int i_NumOfBestFriends)
        {
            int index = 0;

            foreach (Friend friend in m_Friends)
            {
                yield return friend;

                index++;
                if (index == i_NumOfBestFriends)
                {
                    break;
                }
            }
        }

        private void fetchFriends()
        {
            if (m_Friends == null)
            {
                m_Friends = new List<Friend>();
                foreach (User friendUser in m_FacebookConnector.Friends)
                {
                    m_Friends.Add(initializeFriend(friendUser));
                }
            }
        }

        private Friend initializeFriend(User i_FriendUser)
        {
            Friend friend = null;
            try
            {
                friend = new Friend(i_FriendUser.FirstName + " " + i_FriendUser.LastName);
                new Thread(() => friend.ProfilePhoto = i_FriendUser.ImageSmall).Start();
                new Thread(() => fetchNumOfCommonGroups(i_FriendUser, friend)).Start();
                new Thread(() => fetchNumOfSharedEvents(i_FriendUser, friend)).Start();
                new Thread(() => fetchNumOfCommonCheckIns(i_FriendUser, friend)).Start();
                new Thread(() => fetchNumOfCommonLikedPages(i_FriendUser, friend)).Start();
                new Thread(() => fetchNumOfLikedPosts(i_FriendUser, friend)).Start();
            }
            catch
            {
            }

            return friend;
        }
        private void fetchNumOfCommonGroups(User i_UserFriend, Friend i_Friend)
        {
            int numOfCommonGroups = 0;

            try
            {
                foreach (Group friendGroups in i_UserFriend.Groups)
                {
                    foreach (Group loggedInUserGroups in m_FacebookConnector.Groups)
                    {
                        if (friendGroups.Id == loggedInUserGroups.Id)
                        {
                            numOfCommonGroups++;
                        }
                    }
                }

                i_Friend.NumOfCommonGroups = numOfCommonGroups;
            }
            catch
            {
                i_Friend.NumOfCommonGroups = 0;
            }
        }

        private void fetchNumOfSharedEvents(User i_UserFriend, Friend i_Friend)
        {
            int numOfSharedEvents = 0;

            try
            {
                foreach (Event friendEvent in i_UserFriend.Events)
                {
                    foreach (Event loggedInUserEvent in m_FacebookConnector.Events)
                    {
                        if (friendEvent.Id == loggedInUserEvent.Id)
                        {
                            numOfSharedEvents++;
                        }
                    }
                }

                i_Friend.NumOfSharedEvents = numOfSharedEvents;
            }
            catch
            {
                i_Friend.NumOfSharedEvents = 0;
            }
        }

        private void fetchNumOfCommonCheckIns(User i_UserFriend, Friend i_Friend)
        {
            int numOfCommonCheckIns = 0;

            try
            {
                foreach (Checkin friendCheckIn in i_UserFriend.Checkins)
                {
                    foreach (Checkin loggedInUserCheckIn in m_FacebookConnector.Checkins)
                    {
                        if (friendCheckIn.Id == loggedInUserCheckIn.Id)
                        {
                            numOfCommonCheckIns++;
                        }
                    }
                }

                i_Friend.NumOfCommonCheckIns = numOfCommonCheckIns;
            }
            catch
            {
                i_Friend.NumOfCommonCheckIns = 0;
            }
        }

        private void fetchNumOfCommonLikedPages(User i_UserFriend, Friend i_Friend)
        {
            int numOfLikedPages = 0;

            try
            {
                foreach (Page friendLikedPage in i_UserFriend.LikedPages)
                {
                    foreach (Page loggedInUserLikedPage in m_FacebookConnector.LikedPages)
                    {
                        if (friendLikedPage.Id == loggedInUserLikedPage.Id)
                        {
                            numOfLikedPages++;
                        }
                    }
                }

                i_Friend.NumOfCommonLikedPages = numOfLikedPages;
            }
            catch
            {
                i_Friend.NumOfCommonLikedPages = 0;
            }
        }

        private void fetchNumOfLikedPosts(User i_UserFriend, Friend i_Friend)
        {
            int numOfLikedPost = 0;

            try
            {
                foreach (Post loggedInUserPost in m_FacebookConnector.Posts)
                {
                    foreach (User user in loggedInUserPost.LikedBy)
                    {
                        if (i_UserFriend.Id == user.Id)
                        {
                            numOfLikedPost++;
                        }
                    }
                }

                i_Friend.NumOfLikedPosts = numOfLikedPost;
            }
            catch
            {
                i_Friend.NumOfLikedPosts = 0;
            }
        }
    }
}
