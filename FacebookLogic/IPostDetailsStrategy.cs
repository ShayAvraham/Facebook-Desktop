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
    public interface IPostDetailsStrategy
    {
        List<string> PostsDetails(Post i_Post);
    }
}
