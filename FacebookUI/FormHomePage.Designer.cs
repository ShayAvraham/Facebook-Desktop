namespace FacebookUI
{
    partial class FormHomePage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHomePage));
            this.panelTop = new System.Windows.Forms.Panel();
            this.labelHello = new System.Windows.Forms.Label();
            this.labelUserFirstName = new System.Windows.Forms.Label();
            this.facebookConnectorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pictureBoxSmallProfile = new System.Windows.Forms.PictureBox();
            this.pictureBoxFBlogo = new System.Windows.Forms.PictureBox();
            this.buttonLogOut = new System.Windows.Forms.Button();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.panelNav = new System.Windows.Forms.Panel();
            this.buttonFeatureMyBestFriends = new System.Windows.Forms.Button();
            this.buttonFeatureMyCalendar = new System.Windows.Forms.Button();
            this.panelUserName = new System.Windows.Forms.Panel();
            this.pictureBoxProfile = new System.Windows.Forms.PictureBox();
            this.panelPost = new System.Windows.Forms.Panel();
            this.buttonPost = new System.Windows.Forms.Button();
            this.textBoxPost = new System.Windows.Forms.TextBox();
            this.textBoxCreatePost = new System.Windows.Forms.TextBox();
            this.panelPosts = new System.Windows.Forms.Panel();
            this.listBoxPosts = new System.Windows.Forms.ListBox();
            this.textBoxPosts = new System.Windows.Forms.TextBox();
            this.friendsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panelFriends = new System.Windows.Forms.Panel();
            this.listBoxFriends = new System.Windows.Forms.ListBox();
            this.textBoxMyFriends = new System.Windows.Forms.TextBox();
            this.panelAlbums = new System.Windows.Forms.Panel();
            this.listBoxAlbums = new System.Windows.Forms.ListBox();
            this.albumsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.textBoxMyAlbums = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.CheckBoxDetailedViewOfPosts = new System.Windows.Forms.CheckBox();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.facebookConnectorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSmallProfile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFBlogo)).BeginInit();
            this.panelLeft.SuspendLayout();
            this.panelNav.SuspendLayout();
            this.panelUserName.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).BeginInit();
            this.panelPost.SuspendLayout();
            this.panelPosts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.friendsBindingSource)).BeginInit();
            this.panelFriends.SuspendLayout();
            this.panelAlbums.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.albumsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.RoyalBlue;
            this.panelTop.Controls.Add(this.labelHello);
            this.panelTop.Controls.Add(this.labelUserFirstName);
            this.panelTop.Controls.Add(this.pictureBoxSmallProfile);
            this.panelTop.Controls.Add(this.pictureBoxFBlogo);
            this.panelTop.Controls.Add(this.buttonLogOut);
            this.panelTop.Controls.Add(this.buttonLogin);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.ForeColor = System.Drawing.Color.White;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1182, 84);
            this.panelTop.TabIndex = 0;
            // 
            // labelHello
            // 
            this.labelHello.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelHello.Location = new System.Drawing.Point(754, 25);
            this.labelHello.Name = "labelHello";
            this.labelHello.Size = new System.Drawing.Size(69, 32);
            this.labelHello.TabIndex = 14;
            this.labelHello.Text = "Hello";
            this.labelHello.Visible = false;
            // 
            // labelUserFirstName
            // 
            this.labelUserFirstName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.facebookConnectorBindingSource, "UserFirstName", true));
            this.labelUserFirstName.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelUserFirstName.Location = new System.Drawing.Point(829, 25);
            this.labelUserFirstName.Name = "labelUserFirstName";
            this.labelUserFirstName.Size = new System.Drawing.Size(107, 32);
            this.labelUserFirstName.TabIndex = 13;
            // 
            // facebookConnectorBindingSource
            // 
            this.facebookConnectorBindingSource.DataSource = typeof(FacebookLogic.FacebookConnector);
            // 
            // pictureBoxSmallProfile
            // 
            this.pictureBoxSmallProfile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBoxSmallProfile.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.facebookConnectorBindingSource, "UserProfilePictureSmall", true));
            this.pictureBoxSmallProfile.Location = new System.Drawing.Point(954, 15);
            this.pictureBoxSmallProfile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxSmallProfile.Name = "pictureBoxSmallProfile";
            this.pictureBoxSmallProfile.Size = new System.Drawing.Size(58, 49);
            this.pictureBoxSmallProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxSmallProfile.TabIndex = 12;
            this.pictureBoxSmallProfile.TabStop = false;
            this.pictureBoxSmallProfile.WaitOnLoad = true;
            // 
            // pictureBoxFBlogo
            // 
            this.pictureBoxFBlogo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxFBlogo.Image")));
            this.pictureBoxFBlogo.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxFBlogo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxFBlogo.Name = "pictureBoxFBlogo";
            this.pictureBoxFBlogo.Size = new System.Drawing.Size(55, 45);
            this.pictureBoxFBlogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxFBlogo.TabIndex = 3;
            this.pictureBoxFBlogo.TabStop = false;
            // 
            // buttonLogOut
            // 
            this.buttonLogOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonLogOut.FlatAppearance.BorderSize = 0;
            this.buttonLogOut.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.HotTrack;
            this.buttonLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogOut.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonLogOut.Location = new System.Drawing.Point(1030, 8);
            this.buttonLogOut.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonLogOut.Name = "buttonLogOut";
            this.buttonLogOut.Size = new System.Drawing.Size(129, 56);
            this.buttonLogOut.TabIndex = 2;
            this.buttonLogOut.Text = "Log Out";
            this.buttonLogOut.UseVisualStyleBackColor = true;
            this.buttonLogOut.Visible = false;
            this.buttonLogOut.Click += new System.EventHandler(this.ButtonLogOut_Click);
            // 
            // buttonLogin
            // 
            this.buttonLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonLogin.FlatAppearance.BorderSize = 0;
            this.buttonLogin.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.HotTrack;
            this.buttonLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogin.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonLogin.Location = new System.Drawing.Point(73, 8);
            this.buttonLogin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(102, 56);
            this.buttonLogin.TabIndex = 0;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.ButtonLogin_Click);
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.Color.White;
            this.panelLeft.Controls.Add(this.panelNav);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 84);
            this.panelLeft.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(205, 606);
            this.panelLeft.TabIndex = 1;
            // 
            // panelNav
            // 
            this.panelNav.Controls.Add(this.buttonFeatureMyBestFriends);
            this.panelNav.Controls.Add(this.buttonFeatureMyCalendar);
            this.panelNav.Controls.Add(this.panelUserName);
            this.panelNav.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelNav.Enabled = false;
            this.panelNav.Location = new System.Drawing.Point(0, 0);
            this.panelNav.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelNav.Name = "panelNav";
            this.panelNav.Size = new System.Drawing.Size(205, 606);
            this.panelNav.TabIndex = 7;
            // 
            // buttonFeatureMyBestFriends
            // 
            this.buttonFeatureMyBestFriends.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonFeatureMyBestFriends.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonFeatureMyBestFriends.FlatAppearance.BorderSize = 0;
            this.buttonFeatureMyBestFriends.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.buttonFeatureMyBestFriends.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFeatureMyBestFriends.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonFeatureMyBestFriends.ForeColor = System.Drawing.Color.RoyalBlue;
            this.buttonFeatureMyBestFriends.Image = ((System.Drawing.Image)(resources.GetObject("buttonFeatureMyBestFriends.Image")));
            this.buttonFeatureMyBestFriends.Location = new System.Drawing.Point(0, 333);
            this.buttonFeatureMyBestFriends.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonFeatureMyBestFriends.Name = "buttonFeatureMyBestFriends";
            this.buttonFeatureMyBestFriends.Size = new System.Drawing.Size(205, 149);
            this.buttonFeatureMyBestFriends.TabIndex = 10;
            this.buttonFeatureMyBestFriends.Text = "Find My Best Friends";
            this.buttonFeatureMyBestFriends.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonFeatureMyBestFriends.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonFeatureMyBestFriends.UseVisualStyleBackColor = true;
            this.buttonFeatureMyBestFriends.Click += new System.EventHandler(this.ButtonFeatureMyBestFriend_Click);
            // 
            // buttonFeatureMyCalendar
            // 
            this.buttonFeatureMyCalendar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonFeatureMyCalendar.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonFeatureMyCalendar.FlatAppearance.BorderSize = 0;
            this.buttonFeatureMyCalendar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.buttonFeatureMyCalendar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFeatureMyCalendar.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonFeatureMyCalendar.ForeColor = System.Drawing.Color.RoyalBlue;
            this.buttonFeatureMyCalendar.Image = ((System.Drawing.Image)(resources.GetObject("buttonFeatureMyCalendar.Image")));
            this.buttonFeatureMyCalendar.Location = new System.Drawing.Point(0, 189);
            this.buttonFeatureMyCalendar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonFeatureMyCalendar.Name = "buttonFeatureMyCalendar";
            this.buttonFeatureMyCalendar.Size = new System.Drawing.Size(205, 144);
            this.buttonFeatureMyCalendar.TabIndex = 9;
            this.buttonFeatureMyCalendar.Text = "My Calendar";
            this.buttonFeatureMyCalendar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonFeatureMyCalendar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonFeatureMyCalendar.UseVisualStyleBackColor = true;
            this.buttonFeatureMyCalendar.Click += new System.EventHandler(this.ButtonFeatureMyCalendar_Click);
            // 
            // panelUserName
            // 
            this.panelUserName.Controls.Add(this.pictureBoxProfile);
            this.panelUserName.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelUserName.Location = new System.Drawing.Point(0, 0);
            this.panelUserName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelUserName.Name = "panelUserName";
            this.panelUserName.Size = new System.Drawing.Size(205, 189);
            this.panelUserName.TabIndex = 8;
            // 
            // pictureBoxProfile
            // 
            this.pictureBoxProfile.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.facebookConnectorBindingSource, "UserProfilePictureNormal", true));
            this.pictureBoxProfile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxProfile.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxProfile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxProfile.Name = "pictureBoxProfile";
            this.pictureBoxProfile.Size = new System.Drawing.Size(205, 189);
            this.pictureBoxProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxProfile.TabIndex = 0;
            this.pictureBoxProfile.TabStop = false;
            // 
            // panelPost
            // 
            this.panelPost.BackColor = System.Drawing.Color.White;
            this.panelPost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelPost.Controls.Add(this.buttonPost);
            this.panelPost.Controls.Add(this.textBoxPost);
            this.panelPost.Controls.Add(this.textBoxCreatePost);
            this.panelPost.Enabled = false;
            this.panelPost.Location = new System.Drawing.Point(230, 100);
            this.panelPost.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelPost.Name = "panelPost";
            this.panelPost.Size = new System.Drawing.Size(441, 251);
            this.panelPost.TabIndex = 2;
            // 
            // buttonPost
            // 
            this.buttonPost.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonPost.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonPost.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonPost.FlatAppearance.BorderSize = 0;
            this.buttonPost.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Navy;
            this.buttonPost.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPost.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonPost.ForeColor = System.Drawing.Color.White;
            this.buttonPost.Location = new System.Drawing.Point(-1, 202);
            this.buttonPost.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonPost.Name = "buttonPost";
            this.buttonPost.Size = new System.Drawing.Size(440, 47);
            this.buttonPost.TabIndex = 5;
            this.buttonPost.Text = "Post";
            this.buttonPost.UseVisualStyleBackColor = false;
            this.buttonPost.Click += new System.EventHandler(this.ButtonPost_Click);
            // 
            // textBoxPost
            // 
            this.textBoxPost.BackColor = System.Drawing.Color.White;
            this.textBoxPost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxPost.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBoxPost.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPost.ForeColor = System.Drawing.Color.Silver;
            this.textBoxPost.Location = new System.Drawing.Point(0, 28);
            this.textBoxPost.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxPost.Multiline = true;
            this.textBoxPost.Name = "textBoxPost";
            this.textBoxPost.Size = new System.Drawing.Size(439, 174);
            this.textBoxPost.TabIndex = 4;
            this.textBoxPost.Click += new System.EventHandler(this.TextBoxPost_Click);
            // 
            // textBoxCreatePost
            // 
            this.textBoxCreatePost.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBoxCreatePost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxCreatePost.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBoxCreatePost.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBoxCreatePost.Enabled = false;
            this.textBoxCreatePost.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.textBoxCreatePost.ForeColor = System.Drawing.Color.DimGray;
            this.textBoxCreatePost.Location = new System.Drawing.Point(0, 0);
            this.textBoxCreatePost.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxCreatePost.Name = "textBoxCreatePost";
            this.textBoxCreatePost.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBoxCreatePost.Size = new System.Drawing.Size(439, 28);
            this.textBoxCreatePost.TabIndex = 3;
            this.textBoxCreatePost.Text = "  Create Post";
            // 
            // panelPosts
            // 
            this.panelPosts.BackColor = System.Drawing.Color.White;
            this.panelPosts.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelPosts.Controls.Add(this.listBoxPosts);
            this.panelPosts.Controls.Add(this.textBoxPosts);
            this.panelPosts.ForeColor = System.Drawing.Color.DimGray;
            this.panelPosts.Location = new System.Drawing.Point(230, 384);
            this.panelPosts.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelPosts.Name = "panelPosts";
            this.panelPosts.Size = new System.Drawing.Size(441, 253);
            this.panelPosts.TabIndex = 3;
            // 
            // listBoxPosts
            // 
            this.listBoxPosts.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBoxPosts.DisplayMember = "Caption";
            this.listBoxPosts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxPosts.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.listBoxPosts.ForeColor = System.Drawing.Color.DimGray;
            this.listBoxPosts.FormattingEnabled = true;
            this.listBoxPosts.HorizontalScrollbar = true;
            this.listBoxPosts.ItemHeight = 19;
            this.listBoxPosts.Location = new System.Drawing.Point(0, 28);
            this.listBoxPosts.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBoxPosts.Name = "listBoxPosts";
            this.listBoxPosts.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.listBoxPosts.Size = new System.Drawing.Size(439, 223);
            this.listBoxPosts.TabIndex = 5;
            this.listBoxPosts.ValueMember = "Caption";
            // 
            // textBoxPosts
            // 
            this.textBoxPosts.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBoxPosts.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxPosts.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBoxPosts.Enabled = false;
            this.textBoxPosts.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.textBoxPosts.ForeColor = System.Drawing.Color.DimGray;
            this.textBoxPosts.Location = new System.Drawing.Point(0, 0);
            this.textBoxPosts.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxPosts.Name = "textBoxPosts";
            this.textBoxPosts.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBoxPosts.Size = new System.Drawing.Size(439, 28);
            this.textBoxPosts.TabIndex = 4;
            this.textBoxPosts.Text = "  Posts";
            // 
            // friendsBindingSource
            // 
            this.friendsBindingSource.DataMember = "Friends";
            this.friendsBindingSource.DataSource = this.facebookConnectorBindingSource;
            // 
            // panelFriends
            // 
            this.panelFriends.BackColor = System.Drawing.Color.White;
            this.panelFriends.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelFriends.Controls.Add(this.listBoxFriends);
            this.panelFriends.Controls.Add(this.textBoxMyFriends);
            this.panelFriends.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.panelFriends.ForeColor = System.Drawing.Color.DimGray;
            this.panelFriends.Location = new System.Drawing.Point(693, 100);
            this.panelFriends.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelFriends.Name = "panelFriends";
            this.panelFriends.Size = new System.Drawing.Size(219, 251);
            this.panelFriends.TabIndex = 4;
            // 
            // listBoxFriends
            // 
            this.listBoxFriends.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxFriends.Cursor = System.Windows.Forms.Cursors.Default;
            this.listBoxFriends.DataSource = this.friendsBindingSource;
            this.listBoxFriends.DisplayMember = "Name";
            this.listBoxFriends.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxFriends.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.listBoxFriends.ForeColor = System.Drawing.Color.DimGray;
            this.listBoxFriends.FormattingEnabled = true;
            this.listBoxFriends.HorizontalScrollbar = true;
            this.listBoxFriends.ItemHeight = 19;
            this.listBoxFriends.Location = new System.Drawing.Point(0, 28);
            this.listBoxFriends.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBoxFriends.Name = "listBoxFriends";
            this.listBoxFriends.Size = new System.Drawing.Size(217, 221);
            this.listBoxFriends.TabIndex = 6;
            this.listBoxFriends.ValueMember = "About";
            // 
            // textBoxMyFriends
            // 
            this.textBoxMyFriends.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBoxMyFriends.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxMyFriends.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBoxMyFriends.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBoxMyFriends.Enabled = false;
            this.textBoxMyFriends.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.textBoxMyFriends.ForeColor = System.Drawing.Color.DimGray;
            this.textBoxMyFriends.Location = new System.Drawing.Point(0, 0);
            this.textBoxMyFriends.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxMyFriends.Name = "textBoxMyFriends";
            this.textBoxMyFriends.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBoxMyFriends.Size = new System.Drawing.Size(217, 28);
            this.textBoxMyFriends.TabIndex = 4;
            this.textBoxMyFriends.Text = " My Friends";
            // 
            // panelAlbums
            // 
            this.panelAlbums.BackColor = System.Drawing.Color.White;
            this.panelAlbums.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelAlbums.Controls.Add(this.listBoxAlbums);
            this.panelAlbums.Controls.Add(this.textBoxMyAlbums);
            this.panelAlbums.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelAlbums.ForeColor = System.Drawing.Color.DimGray;
            this.panelAlbums.Location = new System.Drawing.Point(940, 101);
            this.panelAlbums.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelAlbums.Name = "panelAlbums";
            this.panelAlbums.Size = new System.Drawing.Size(219, 250);
            this.panelAlbums.TabIndex = 5;
            // 
            // listBoxAlbums
            // 
            this.listBoxAlbums.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxAlbums.Cursor = System.Windows.Forms.Cursors.Default;
            this.listBoxAlbums.DataSource = this.albumsBindingSource;
            this.listBoxAlbums.DisplayMember = "Name";
            this.listBoxAlbums.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxAlbums.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.listBoxAlbums.ForeColor = System.Drawing.Color.DimGray;
            this.listBoxAlbums.FormattingEnabled = true;
            this.listBoxAlbums.HorizontalScrollbar = true;
            this.listBoxAlbums.ItemHeight = 19;
            this.listBoxAlbums.Location = new System.Drawing.Point(0, 28);
            this.listBoxAlbums.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBoxAlbums.Name = "listBoxAlbums";
            this.listBoxAlbums.Size = new System.Drawing.Size(217, 220);
            this.listBoxAlbums.TabIndex = 6;
            this.listBoxAlbums.ValueMember = "Comments";
            // 
            // albumsBindingSource
            // 
            this.albumsBindingSource.DataMember = "Albums";
            this.albumsBindingSource.DataSource = this.facebookConnectorBindingSource;
            // 
            // textBoxMyAlbums
            // 
            this.textBoxMyAlbums.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBoxMyAlbums.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxMyAlbums.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBoxMyAlbums.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBoxMyAlbums.Enabled = false;
            this.textBoxMyAlbums.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.textBoxMyAlbums.ForeColor = System.Drawing.Color.DimGray;
            this.textBoxMyAlbums.Location = new System.Drawing.Point(0, 0);
            this.textBoxMyAlbums.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxMyAlbums.Name = "textBoxMyAlbums";
            this.textBoxMyAlbums.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBoxMyAlbums.Size = new System.Drawing.Size(217, 28);
            this.textBoxMyAlbums.TabIndex = 4;
            this.textBoxMyAlbums.Text = " My Albums";
            // 
            // pictureBox1
            // 
            this.pictureBox1.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.albumsBindingSource, "ImageThumb", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "N0"));
            this.pictureBox1.Location = new System.Drawing.Point(942, 415);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(173, 170);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // CheckBoxDetailedViewOfPosts
            // 
            this.CheckBoxDetailedViewOfPosts.AutoSize = true;
            this.CheckBoxDetailedViewOfPosts.Enabled = false;
            this.CheckBoxDetailedViewOfPosts.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.CheckBoxDetailedViewOfPosts.ForeColor = System.Drawing.Color.DimGray;
            this.CheckBoxDetailedViewOfPosts.Location = new System.Drawing.Point(231, 643);
            this.CheckBoxDetailedViewOfPosts.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CheckBoxDetailedViewOfPosts.Name = "CheckBoxDetailedViewOfPosts";
            this.CheckBoxDetailedViewOfPosts.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.CheckBoxDetailedViewOfPosts.Size = new System.Drawing.Size(236, 25);
            this.CheckBoxDetailedViewOfPosts.TabIndex = 6;
            this.CheckBoxDetailedViewOfPosts.Text = "Detailed View Of Posts";
            this.CheckBoxDetailedViewOfPosts.UseVisualStyleBackColor = true;
            this.CheckBoxDetailedViewOfPosts.Click += new System.EventHandler(this.CheckBoxDetailedViewOfPosts_Click);
            // 
            // FormHomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 690);
            this.Controls.Add(this.CheckBoxDetailedViewOfPosts);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panelAlbums);
            this.Controls.Add(this.panelFriends);
            this.Controls.Add(this.panelPosts);
            this.Controls.Add(this.panelPost);
            this.Controls.Add(this.panelLeft);
            this.Controls.Add(this.panelTop);
            this.ForeColor = System.Drawing.Color.RoyalBlue;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "FormHomePage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Facebook Desktop";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormHomePage_FormClosed);
            this.panelTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.facebookConnectorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSmallProfile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFBlogo)).EndInit();
            this.panelLeft.ResumeLayout(false);
            this.panelNav.ResumeLayout(false);
            this.panelUserName.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).EndInit();
            this.panelPost.ResumeLayout(false);
            this.panelPost.PerformLayout();
            this.panelPosts.ResumeLayout(false);
            this.panelPosts.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.friendsBindingSource)).EndInit();
            this.panelFriends.ResumeLayout(false);
            this.panelFriends.PerformLayout();
            this.panelAlbums.ResumeLayout(false);
            this.panelAlbums.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.albumsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Panel panelPost;
        private System.Windows.Forms.Button buttonPost;
        private System.Windows.Forms.TextBox textBoxPost;
        private System.Windows.Forms.Button buttonLogOut;
        private System.Windows.Forms.Panel panelNav;
        private System.Windows.Forms.Panel panelPosts;
        private System.Windows.Forms.TextBox textBoxPosts;
        private System.Windows.Forms.ListBox listBoxPosts;
        private System.Windows.Forms.PictureBox pictureBoxFBlogo;
        private System.Windows.Forms.Button buttonFeatureMyCalendar;
        private System.Windows.Forms.Panel panelFriends;
        private System.Windows.Forms.TextBox textBoxMyFriends;
        private System.Windows.Forms.Panel panelAlbums;
        private System.Windows.Forms.TextBox textBoxMyAlbums;
        private System.Windows.Forms.Button buttonFeatureMyBestFriends;
        private System.Windows.Forms.ListBox listBoxFriends;
        private System.Windows.Forms.ListBox listBoxAlbums;
        private System.Windows.Forms.PictureBox pictureBoxSmallProfile;
        private System.Windows.Forms.TextBox textBoxCreatePost;
        private System.Windows.Forms.Panel panelUserName;
        private System.Windows.Forms.PictureBox pictureBoxProfile;
        private System.Windows.Forms.Label labelUserFirstName;
        private System.Windows.Forms.BindingSource facebookConnectorBindingSource;
        private System.Windows.Forms.Label labelHello;
        private System.Windows.Forms.BindingSource friendsBindingSource;
        private System.Windows.Forms.BindingSource albumsBindingSource;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox CheckBoxDetailedViewOfPosts;
    }
}

