using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;
using System.Drawing;

namespace FacebookLogic
{
    public sealed class FacebookConnector
    {
        // Defines
        private readonly string k_FaildToImportNameErrorMsg = "Error: Import user name was unsuccessful ";
        private readonly string k_FaildToImportBirthdayErrorMsg = "Error: Import birthday name was unsuccessful ";
        private readonly string k_FaildToImportProfilePhotoErrorMsg = "Error: Import profile photo was unsuccessful ";
        private readonly string k_FaildToImportFriendsErrorMsg = "Error: Import friends was unsuccessful ";
        private readonly string k_FaildToImportGroupsErrorMsg = "Error: Import groups was unsuccessful ";
        private readonly string k_FaildToImportAlbumsErrorMsg = "Error: Import albums was unsuccessful ";
        private readonly string k_FaildToImportEventsErrorMsg = "Error: Import events was unsuccessful ";
        private readonly string k_FaildToImportCheckinsErrorMsg = "Error: Import checkins was unsuccessful ";
        private readonly string k_FaildToImportLikedPagesErrorMsg = "Error: Import liked pages was unsuccessful ";
        private readonly string k_FaildToImportPostsErrorMsg = "Error: Import posts was unsuccessful ";
        private readonly string k_FaildToPostErrorMsg = "Error: Posting a status faild, Please try again ";
        private readonly string k_AppId = "527190517843829";

        // Data members
        private User m_LoggedInUser;
        private string m_UserFirstName;
        private string m_UserBirthday;
        private Image m_UserProfilePictureNormal;
        private Image m_UserProfilePictureSmall;
        private FacebookObjectCollection<User> r_Friends;
        private FacebookObjectCollection<Group> m_Groups;
        private FacebookObjectCollection<Album> m_Albums;
        private FacebookObjectCollection<Event> m_Events;
        private FacebookObjectCollection<Checkin> m_Checkins;
        private FacebookObjectCollection<Page> m_LikedPages;
        private FacebookObjectCollection<Post> m_Posts;
        private static FacebookConnector s_Instance = null;
        private static readonly object sr_CreationKey = new object();


        public string UserFirstName
        {
            get
            {
                return m_UserFirstName ?? fetchUserFirstName();
            }
            private set
            {
                m_UserFirstName = value;
            }
        }

        public string UserBirthday
        {
            get
            {
                return m_UserBirthday ?? fetchUserBirthday();
            }
            private set
            {
                m_UserBirthday = value;
            }
        }

        public Image UserProfilePictureSmall
        {
            get
            {
                return m_UserProfilePictureSmall ?? fetchProfilePictureSmall();
            }
            private set
            {
                m_UserProfilePictureSmall = value;
            }
        }

        public Image UserProfilePictureNormal
        {
            get
            {
                return m_UserProfilePictureNormal ?? fetchProfilePictureNormal();
            }
            private set
            {
                m_UserProfilePictureNormal = value;
            }
        }

        public FacebookObjectCollection<User> Friends
        {
            get
            {
                return r_Friends ?? fetchFriends();
            }
            private set
            {
                r_Friends = value;
            }
        }

        public FacebookObjectCollection<Group> Groups
        {
            get
            {
                return m_Groups ?? fetchGroups();
            }
            private set
            {
                m_Groups = value;
            }
        }

        public FacebookObjectCollection<Album> Albums
        {
            get
            {
                return m_Albums ?? fetchAlbums();
            }
            private set
            {
                m_Albums = value;
            }
        }

        public FacebookObjectCollection<Event> Events
        {
            get
            {
                return m_Events ?? fetchEvents();
            }
            private set
            {
                m_Events = value;
            }
        }

        public FacebookObjectCollection<Checkin> Checkins
        {
            get
            {
                return m_Checkins ?? fetchCheckins();
            }
            private set
            {
                m_Checkins = value;
            }
        }

        public FacebookObjectCollection<Page> LikedPages
        {
            get
            {
                return m_LikedPages ?? fetchLikedPages();
            }
            private set
            {
                m_LikedPages = value;
            }
        }

        public FacebookObjectCollection<Post> Posts
        {
            get
            {
                return m_Posts ?? fetchPosts();
            }
            private set
            {
                m_Posts = value;
            }
        }

        public static FacebookConnector GetInstance 
        {
            get
            {
                if (s_Instance == null)
                {
                    lock (sr_CreationKey)
                    {
                        if (s_Instance == null)
                        {
                            s_Instance = new FacebookConnector();
                        }
                    }
                }
                return s_Instance;
            }
        }

        private FacebookConnector()
        {
            FacebookWrapper.FacebookService.s_CollectionLimit = 30;
            FacebookWrapper.FacebookService.s_FbApiVersion = 2.8f;

        }

        public void LoginAndInit()
        {
            LoginResult result = FacebookService.Login(k_AppId,
            "public_profile",
            "email",
            "publish_to_groups",
            "user_birthday",
            "user_age_range",
            "user_gender",
            "user_link",
            "user_tagged_places",
            "user_videos",
            "groups_access_member_info",
            "user_friends",
            "user_events",
            "user_likes",
            "user_location",
            "user_photos",
            "user_posts",
            "user_hometown");

            if (!string.IsNullOrEmpty(result.AccessToken))
            {
                m_LoggedInUser = result.LoggedInUser;
            }
            else
            {
                throw (new Exception(result.ErrorMessage));
            }
        }

        public void Logout()
        {
            FacebookService.Logout(resetProperties);
        }

        private void resetProperties()
        {
            m_LoggedInUser = null;
            UserFirstName = null;
            UserBirthday = null;
            m_UserProfilePictureNormal = null;
            UserProfilePictureSmall = null;
            Friends = null;
            Groups = null;
            Albums = null;
            Events = null;
            Checkins = null;
            LikedPages = null;
            Posts = null;
    }

        private string fetchUserFirstName()
        {
            try
            {
                UserFirstName = m_LoggedInUser.FirstName;
                return m_UserFirstName;
            }
            catch
            {
                throw new Exception(k_FaildToImportNameErrorMsg);
            }
        }

        private string fetchUserBirthday()
        {
            try
            {
                UserBirthday = m_LoggedInUser.Birthday;
                return m_UserBirthday;
            }
            catch
            {
                throw new Exception(k_FaildToImportBirthdayErrorMsg);
            }
        }

        private Image fetchProfilePictureNormal()
        {
            try
            {
                UserProfilePictureNormal = m_LoggedInUser.ImageNormal;
                return m_UserProfilePictureNormal;
            }
            catch
            {
                throw new Exception(k_FaildToImportProfilePhotoErrorMsg);
            }
        }

        private Image fetchProfilePictureSmall()
        {
            try
            {
                UserProfilePictureSmall = m_LoggedInUser.ImageSmall;
                return m_UserProfilePictureSmall;
            }
            catch
            {
                throw new Exception(k_FaildToImportProfilePhotoErrorMsg);
            }
        }

        private FacebookObjectCollection<User> fetchFriends()
        {
            try
            {
                Friends = m_LoggedInUser.Friends;
                return r_Friends;
            }
            catch
            {
                throw new Exception(k_FaildToImportFriendsErrorMsg);
            }
        }

        private FacebookObjectCollection<Group> fetchGroups()
        {
            try
            {
                Groups = m_LoggedInUser.Groups;
                return m_Groups;
            }
            catch
            {
                throw new Exception(k_FaildToImportGroupsErrorMsg);
            }
        }

        private FacebookObjectCollection<Album> fetchAlbums()
        {
            try
            {
                Albums = m_LoggedInUser.Albums;
                return m_Albums;
            }
            catch
            {
                throw new Exception(k_FaildToImportAlbumsErrorMsg);
            }
        }

        private FacebookObjectCollection<Event> fetchEvents()
        {
            try
            {
                Events = m_LoggedInUser.Events;
                return m_Events;
            }
            catch
            {
                throw new Exception(k_FaildToImportEventsErrorMsg);
            }
        }

        private FacebookObjectCollection<Checkin> fetchCheckins()
        {
            try
            {
                Checkins = m_LoggedInUser.Checkins;
                return m_Checkins;
            }
            catch
            {
                throw new Exception(k_FaildToImportCheckinsErrorMsg);
            }
        }

        private FacebookObjectCollection<Page> fetchLikedPages()
        {
            try
            {
                LikedPages = m_LoggedInUser.LikedPages;
                return m_LikedPages;
            }
            catch
            {
                throw new Exception(k_FaildToImportLikedPagesErrorMsg);
            }
        }

        private FacebookObjectCollection<Post> fetchPosts()
        {
            try
            {
                Posts = m_LoggedInUser.Posts;
                return m_Posts;
            }
            catch
            {
                throw new Exception(k_FaildToImportPostsErrorMsg);
            }
        }

        public void PostStatus(string i_PostMsg)
        {
            try
            {
                m_LoggedInUser.PostStatus(i_PostMsg);
                fetchPosts();
            }
            catch
            {
                throw new Exception(k_FaildToPostErrorMsg);
            }
        }
    }
}
