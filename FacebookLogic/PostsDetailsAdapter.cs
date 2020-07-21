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
    public class PostsDetailsAdapter : IPostDetails
    {
        // Defines
        private const string k_BoundaryLine = "==============================";
        private const int k_StartPostNumber = 1;

        // Data members
        private FacebookObjectCollection<Post> m_UserPosts = FacebookConnector.GetInstance.Posts;

        public List<string> GetPostList(IPostFormatStrategy i_PostFormatStrategy)
        {
            List <string> userPostsDetails = new List<string>();
            int postNumber = k_StartPostNumber;

            foreach (Post post in m_UserPosts)
            {
                if (!string.IsNullOrEmpty(post.Message))
                {
                    userPostsDetails.Add(k_BoundaryLine);
                    userPostsDetails.Add(string.Format("{0}.", postNumber));
                    // Strategy 
                    foreach (string postDetail in i_PostFormatStrategy.PostsDetails(post))
                    {
                        userPostsDetails.Add(postDetail);
                    }

                    postNumber++;
                }
            }

            return userPostsDetails;
        }
    }
}
