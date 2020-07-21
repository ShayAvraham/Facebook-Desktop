using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace FacebookLogic
{
    public class Friend
    {
        public enum eCheckBoxType
        {
            Groups = 0,
            Events,
            Check_Ins,
            Liked_Pages,
            Liked_Posts
        }

        // Data members
        public string FullName { get; }
        public Image ProfilePhoto { get; set; }
        public int Score { get; protected set; }
        public int NumOfCommonGroups { get; set; }
        public int NumOfSharedEvents { get; set; }
        public int NumOfCommonCheckIns { get; set; }
        public int NumOfCommonLikedPages { get; set; }
        public int NumOfLikedPosts { get; set; }

        public Friend(string i_FullName)
        {
            Score = 0;
            FullName = i_FullName;
        }

        public void UpdateScore(List<bool> i_SearchFilters)
        {
            Score = 0;
            int filterIndex = 0;

            foreach (bool filter in i_SearchFilters)
            {
                if (filter)
                {
                    switch ((eCheckBoxType)filterIndex)
                    {
                        case (eCheckBoxType.Groups):
                            Score += NumOfCommonGroups;
                            break;
                        case (eCheckBoxType.Events):
                            Score += NumOfSharedEvents;
                            break;
                        case (eCheckBoxType.Check_Ins):
                            Score += NumOfCommonCheckIns;
                            break;
                        case (eCheckBoxType.Liked_Pages):
                            Score += NumOfCommonLikedPages;
                            break;
                        case (eCheckBoxType.Liked_Posts):
                            Score += NumOfLikedPosts;
                            break;
                    }
                }
                filterIndex++;
            }
        }
    }
}
