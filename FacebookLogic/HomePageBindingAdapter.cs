using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;
using System.Drawing;

namespace FacebookLogic
{
    public class HomePageBindingAdapter
    {
        public string UserFirstName { get; private set; }
        public Image UserProfilePictureNormal { get; private set; }
        public Image UserProfilePictureSmall { get; private set; }
        public FacebookObjectCollection<Album> UserAlbumsList { get; private set; }
        public FacebookObjectCollection<Post> UserPostsList { get; private set; }
        public FacebookObjectCollection<User> UserFriendsList { get; private set; }

        public HomePageBindingAdapter()
        {
            UserFirstName = FacebookConnector.GetFacebookConnector.UserFirstName;
            UserProfilePictureNormal = FacebookConnector.GetFacebookConnector.UserProfilePictureNormal;
            UserProfilePictureSmall = FacebookConnector.GetFacebookConnector.UserProfilePictureSmall;
            UserAlbumsList = FacebookConnector.GetFacebookConnector.Albums;
            UserPostsList = FacebookConnector.GetFacebookConnector.Posts;
            UserFriendsList = FacebookConnector.GetFacebookConnector.Friends;
        }
    }
}
