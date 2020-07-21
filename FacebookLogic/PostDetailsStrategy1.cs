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
    public class PostDetailsStrategy1 : IPostDetailsStrategy
    {
        // Defines
        private const string k_CreatedTime = "Created At: ";
        private const string k_Likes = "Likes";

        public List<string> PostsDetails(Post i_Post)
        {
            List<string> postDetails = new List<string>();

            postDetails.Add(i_Post.Message);
            postDetails.Add(string.Format("{0} {1}", i_Post.LikedBy.Count, k_Likes));
            postDetails.Add(string.Format("{0}{1}", k_CreatedTime, i_Post.CreatedTime));

            return postDetails;
        }
    }
}
