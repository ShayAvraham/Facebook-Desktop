using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacebookLogic
{
    public class ConcreteFriend : Friend
    {
        public ConcreteFriend(string i_FullName) : base(i_FullName)
        {
        }

        public override void UpdateScoreForCurrentFilter(int i_FilterIndex)
        {
            switch ((eCheckBoxType)i_FilterIndex)
            {
                case (eCheckBoxType.Groups):
                    Score += (NumOfCommonGroups * 3);
                    break;
                case (eCheckBoxType.Events):
                    Score += (NumOfSharedEvents * 2);
                    break;
                case (eCheckBoxType.Check_Ins):
                    Score += NumOfCommonCheckIns;
                    break;
                case (eCheckBoxType.Liked_Pages):
                    Score += (NumOfCommonLikedPages * 4);
                    break;
                case (eCheckBoxType.Liked_Posts):
                    Score += (NumOfLikedPosts * 5);
                    break;
            }
        }
    }
}
