using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;

namespace FacebookLogic
{
    public class HomePage
    {
        //Data members
        private FacebookConnector m_FacebookConnector = FacebookConnector.GetInstance;

        public void LoginAndInit()
        {
            m_FacebookConnector.LoginAndInit();
        }

        public void Logout()
        {
            m_FacebookConnector.Logout();
        }

        public void PostStatus(string i_PostMsg)
        {
            m_FacebookConnector.PostStatus(i_PostMsg);
        }

        public List<string> GetPosts(bool i_IsDetailedPosts)
        {
            IPostFormatStrategy m_PostFormatStrategy;

            if (i_IsDetailedPosts)
            {
                m_PostFormatStrategy = new DetailedPostFormat();
            }
            else
            {
                m_PostFormatStrategy = new BasicPostFormat();
            }

            IPostDetails postsDetailsAdapter = new PostsDetailsAdapter();
            return postsDetailsAdapter.GetPostList(m_PostFormatStrategy);
        }
    }
}
