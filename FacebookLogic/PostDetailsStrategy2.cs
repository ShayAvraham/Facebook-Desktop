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
    public class PostDetailsStrategy2 : IPostDetailsStrategy
    {
        public List<string> PostsDetails(Post i_Post)
        {
            List<string> postDetails = new List<string>();

            postDetails.Add(i_Post.Message);
            
            return postDetails;
        }
    }
}
