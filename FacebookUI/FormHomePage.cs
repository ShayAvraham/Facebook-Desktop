using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;
using FacebookLogic;
using System.Threading;

namespace FacebookUI
{
    public partial class FormHomePage : Form
    {
        // Defines
        private const string k_EmptyPostErrortMessage = "Error: You cant post an empty status";
        private const string k_PostMessage = " What's On Your Mind ?";

        // Data members
        private readonly HomePage r_HomePage;

        public FormHomePage()
        {
            InitializeComponent();
            r_HomePage = new HomePage();
        }

        private void ButtonLogin_Click(object sender, EventArgs e)
        {
            try
            {
                r_HomePage.LoginAndInit();
                new Thread(showUserInfo).Start();
                resetFormControls(true);

            }
            catch (Exception exp)
            {
                resetFormControls(false);
                MessageBox.Show(exp.Message);
            }
        }

        private void ButtonLogOut_Click(object sender, EventArgs e)
        {
            resetDataSource();
            r_HomePage.Logout();
            resetFormControls(false);
        }

        private void resetDataSource()
        {
            facebookConnectorBindingSource.DataSource = typeof(FacebookConnector);
            albumsBindingSource.DataSource = typeof(Album);
            friendsBindingSource.DataSource = typeof(Friend);
        }

        private void resetFormControls(bool i_IsLogginOccuer)
        {
            panelNav.Enabled = i_IsLogginOccuer;
            panelPost.Enabled = i_IsLogginOccuer;
            labelHello.Visible = i_IsLogginOccuer;
            buttonLogin.Visible = !i_IsLogginOccuer;

            if (i_IsLogginOccuer)
            {
                textBoxPost.Text = k_PostMessage;
            }
            else
            {
                CheckBoxDetailedViewOfPosts.Enabled = i_IsLogginOccuer;
                buttonLogOut.Visible = i_IsLogginOccuer;
                CheckBoxDetailedViewOfPosts.Checked = i_IsLogginOccuer;
                textBoxPost.Clear();
                listBoxPosts.Items.Clear(); 
           }
        }

        private void showUserInfo()
        {
            FacebookConnector facebookConnector = FacebookConnector.GetInstance;
            facebookConnectorBindingSource.DataSource = facebookConnector;
            showPosts();
            listBoxAlbums.Invoke(new Action(() => albumsBindingSource.DataSource = facebookConnector.Albums));
            listBoxFriends.Invoke(new Action(() => friendsBindingSource.DataSource = facebookConnector.Friends));
            buttonLogOut.Invoke(new Action(() => buttonLogOut.Visible = true));
            labelUserFirstName.Invoke(new Action(() => facebookConnectorBindingSource.ResetBindings(false)));
        }

        private void showPosts()
        {
            foreach (string postDetails in r_HomePage.GetPosts(CheckBoxDetailedViewOfPosts.Checked))
            {
                listBoxPosts.Invoke(new Action(() => listBoxPosts.Items.Add(postDetails)));
            }

            CheckBoxDetailedViewOfPosts.Invoke(new Action(() => CheckBoxDetailedViewOfPosts.Enabled = true));
        }

        private void ButtonPost_Click(object sender, EventArgs e)
        {
            new Thread(() =>
            {
                if (!string.IsNullOrEmpty(textBoxPost.Text) && textBoxPost.Text != k_PostMessage)
                {
                    try
                    {
                        r_HomePage.PostStatus(textBoxPost.Text);
                    }
                    catch (Exception exp)
                    {
                        MessageBox.Show(exp.Message);
                    }
                }
                else
                {
                    MessageBox.Show(k_EmptyPostErrortMessage);
                }
                textBoxPost.Invoke(new Action(() => textBoxPost.Text = k_PostMessage));
            }
            ).Start();
        }

        private void TextBoxPost_Click(object sender, EventArgs e)
        {
            textBoxPost.Clear();
        }

        private void CheckBoxDetailedViewOfPosts_Click(object sender, EventArgs e)
        {
            CheckBoxDetailedViewOfPosts.Enabled = false;
            listBoxPosts.Items.Clear();
            new Thread(showPosts).Start();
        }

        private void ButtonFeatureMyCalendar_Click(object sender, EventArgs e)
        {
            new FormFacebookCalendar().ShowDialog();
        }

        private void ButtonFeatureMyBestFriend_Click(object sender, EventArgs e)
        {
            new FormMyBestFriendsFinder().ShowDialog();
        }

        private void FormHomePage_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(Environment.ExitCode);
        }
    }
}
