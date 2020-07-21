using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacebookLogic
{
    public interface IPostDetails
    {
        List<string> GetPostList(IPostFormatStrategy i_PostFormatStrategy);
    }
}
