using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FacebookLogic;
using System.Threading;

namespace FacebookUI
{
    public partial class FormMyBestFriendsFinder : Form
    {
        // Defines
        private const string k_NoSearchFilterErrorMsg = "Error: no search filter selected ,please select at least one search filter";
        private const string k_NumOfFriendsIsZeroErrorMsg = "Error: You need AT least one friend to use this feature";
        private const int k_NumOfFilters = 5;

        // Data members
        private MyBestFriendsFinder r_MyBestFriendsFinder;


        public FormMyBestFriendsFinder()
        {
            InitializeComponent();
        }

        private void uploadProfilePicture()
        {
            if (!pictureBoxProfile.InvokeRequired)
            {
                facebookConnectorBindingSource.DataSource = FacebookConnector.GetInstance;
            }
            else
            {
                pictureBoxProfile.Invoke(new Action(() => facebookConnectorBindingSource.DataSource = FacebookConnector.GetInstance));
            }
        }

        private void ButtonSearch_Click(object sender, EventArgs e)
        {
            try
            {
                validateSearchPossible();
                buttonSearch.Enabled = false;
                new Thread(() =>
                {
                    r_MyBestFriendsFinder.FindMyBestFriends((int)numericUpDownNumOfFriends.Value, createListOfSearchFilters());
                    showMyBestFriendsOnGrid();
                }).Start();             
            }
            catch (Exception exp)
            {
                buttonSearch.Enabled = true;
                MessageBox.Show(exp.Message);
            }
        }

        private void ButtonSelectAll_Click(object sender, EventArgs e)
        {
            changeCheckBoxsCheckedStatus(true);
        }

        private void ButtonSelectNone_Click(object sender, EventArgs e)
        {
            changeCheckBoxsCheckedStatus(false);
        }

        private List<bool> createListOfSearchFilters()
        {
            List<bool> searchFilters = new List<bool>(k_NumOfFilters);

            for (int i = 0; i < k_NumOfFilters; i++)
            {
                searchFilters.Add(false);
            }

            foreach (CheckBox checkBox in panelCheckBoxFilters.Controls.OfType<CheckBox>())
            {
                switch (checkBox.Name)
                {
                    case "checkBoxCommonGroups":
                        searchFilters[(int)Friend.eCheckBoxType.Groups] = checkBox.Checked;
                        break;
                    case "checkBoxSharedEvents":
                        searchFilters[(int)Friend.eCheckBoxType.Events] = checkBox.Checked;
                        break;
                    case "checkBoxCommonCheckIn":
                        searchFilters[(int)Friend.eCheckBoxType.Check_Ins] = checkBox.Checked;
                        break;
                    case "checkBoxCommonLikedPages":
                        searchFilters[(int)Friend.eCheckBoxType.Liked_Pages] = checkBox.Checked;
                        break;
                    case "checkBoxLikedPosts":
                        searchFilters[(int)Friend.eCheckBoxType.Liked_Posts] = checkBox.Checked;
                        break;
                }
            }

            return searchFilters;
        }

        private void showMyBestFriendsOnGrid()
        {
            if (!friendDataGridView.InvokeRequired)
            {
                friendBindingSource.DataSource = r_MyBestFriendsFinder.MyBestFriends;
            }
            else
            {
                friendDataGridView.Invoke(new Action(() => friendBindingSource.DataSource = r_MyBestFriendsFinder.MyBestFriends));
            }

            panelSearchResults.Invoke(new Action(() => panelSearchResults.Visible = true));
            buttonSearch.Invoke(new Action(() => buttonSearch.Enabled = true));

            foreach (DataGridViewRow row in friendDataGridView.Rows)
            {
                row.Cells[0].Value = String.Format("{0}", row.Index + 1);
            }
        }


        private void changeCheckBoxsCheckedStatus(bool i_CheckedSatus)
        {
            foreach (CheckBox checkBox in this.Controls.OfType<CheckBox>())
            {
                checkBox.Checked = i_CheckedSatus;
            }
        }

        private void validateSearchPossible()
        {
            if (!isUserHasFriends())
            {
                throw new Exception(k_NumOfFriendsIsZeroErrorMsg);
            }
            else if (!isAtLeastOneCheckBoxCheck())
            {
                throw new Exception(k_NoSearchFilterErrorMsg);
            }
        }

        private bool isUserHasFriends()
        {
            bool isUserHasFriends = true;

            if (numericUpDownNumOfFriends.Maximum == 0)
            {
                isUserHasFriends = false;
            }

            return isUserHasFriends;
        }
        private bool isAtLeastOneCheckBoxCheck()
        {
            bool isAtLeastOneCheckBoxCheck = false;

            foreach (CheckBox checkBox in this.Controls.OfType<CheckBox>())
            {
                if (checkBox.Checked == true)
                {
                    isAtLeastOneCheckBoxCheck = true;
                    break;
                }
            }

            return isAtLeastOneCheckBoxCheck;
        }

        private void ButtonStartMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ButtonFeatureMyCalendar_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
                new FormFacebookCalendar().ShowDialog();
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
                buttonFeatureMyCalendar.Enabled = false;
            }
        }

        private void FormMyBestFriendsFinder_Activated(object sender, EventArgs e)
        {
            new Thread(() => uploadProfilePicture()).Start();
            new Thread(() => numericUpDownNumOfFriends.Maximum = FacebookConnector.GetInstance.Friends.Count).Start();
            r_MyBestFriendsFinder = new MyBestFriendsFinder();
        }
    }
}
