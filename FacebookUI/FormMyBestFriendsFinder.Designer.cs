namespace FacebookUI
{
    partial class FormMyBestFriendsFinder
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMyBestFriendsFinder));
            this.panelSearchResults = new System.Windows.Forms.Panel();
            this.friendDataGridView = new System.Windows.Forms.DataGridView();
            this.Ranking = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.profilePhotoDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.friendBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.labelSearchResults = new System.Windows.Forms.Label();
            this.checkBoxLikedPosts = new System.Windows.Forms.CheckBox();
            this.buttonSelectAll = new System.Windows.Forms.Button();
            this.buttonSelectNone = new System.Windows.Forms.Button();
            this.checkBoxCommonLikedPages = new System.Windows.Forms.CheckBox();
            this.labelSearchCriteria = new System.Windows.Forms.Label();
            this.checkBoxCommonCheckIn = new System.Windows.Forms.CheckBox();
            this.checkBoxSharedEvents = new System.Windows.Forms.CheckBox();
            this.checkBoxCommonGroups = new System.Windows.Forms.CheckBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.numericUpDownNumOfFriends = new System.Windows.Forms.NumericUpDown();
            this.labelNumOfBestFriends = new System.Windows.Forms.Label();
            this.panelTop = new System.Windows.Forms.Panel();
            this.labelMyBestFriend = new System.Windows.Forms.Label();
            this.pictureBoxFBlogo = new System.Windows.Forms.PictureBox();
            this.panelNav = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonFeatureMyCalendar = new System.Windows.Forms.Button();
            this.buttonStartMenu = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBoxProfile = new System.Windows.Forms.PictureBox();
            this.facebookConnectorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.labelUserName = new System.Windows.Forms.Label();
            this.panelCheckBoxFilters = new System.Windows.Forms.Panel();
            this.panelSearchResults.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.friendDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.friendBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNumOfFriends)).BeginInit();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFBlogo)).BeginInit();
            this.panelNav.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.facebookConnectorBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSearchResults
            // 
            this.panelSearchResults.Controls.Add(this.friendDataGridView);
            this.panelSearchResults.Controls.Add(this.labelSearchResults);
            this.panelSearchResults.Location = new System.Drawing.Point(277, 298);
            this.panelSearchResults.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelSearchResults.Name = "panelSearchResults";
            this.panelSearchResults.Size = new System.Drawing.Size(781, 392);
            this.panelSearchResults.TabIndex = 41;
            this.panelSearchResults.Visible = false;
            // 
            // friendDataGridView
            // 
            this.friendDataGridView.AllowUserToAddRows = false;
            this.friendDataGridView.AutoGenerateColumns = false;
            this.friendDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.friendDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.friendDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.friendDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.friendDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ranking,
            this.fullNameDataGridViewTextBoxColumn,
            this.profilePhotoDataGridViewImageColumn});
            this.friendDataGridView.DataSource = this.friendBindingSource;
            this.friendDataGridView.Location = new System.Drawing.Point(21, 44);
            this.friendDataGridView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.friendDataGridView.MultiSelect = false;
            this.friendDataGridView.Name = "friendDataGridView";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.NullValue = null;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.friendDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.friendDataGridView.RowHeadersVisible = false;
            this.friendDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.friendDataGridView.RowTemplate.Height = 24;
            this.friendDataGridView.Size = new System.Drawing.Size(745, 302);
            this.friendDataGridView.TabIndex = 43;
            // 
            // Ranking
            // 
            this.Ranking.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle5.NullValue = null;
            this.Ranking.DefaultCellStyle = dataGridViewCellStyle5;
            this.Ranking.HeaderText = "Ranking";
            this.Ranking.MinimumWidth = 6;
            this.Ranking.Name = "Ranking";
            this.Ranking.ReadOnly = true;
            // 
            // fullNameDataGridViewTextBoxColumn
            // 
            this.fullNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.fullNameDataGridViewTextBoxColumn.DataPropertyName = "FullName";
            this.fullNameDataGridViewTextBoxColumn.HeaderText = "FullName";
            this.fullNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fullNameDataGridViewTextBoxColumn.Name = "fullNameDataGridViewTextBoxColumn";
            this.fullNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // profilePhotoDataGridViewImageColumn
            // 
            this.profilePhotoDataGridViewImageColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.profilePhotoDataGridViewImageColumn.DataPropertyName = "ProfilePhoto";
            this.profilePhotoDataGridViewImageColumn.HeaderText = "ProfilePhoto";
            this.profilePhotoDataGridViewImageColumn.MinimumWidth = 6;
            this.profilePhotoDataGridViewImageColumn.Name = "profilePhotoDataGridViewImageColumn";
            this.profilePhotoDataGridViewImageColumn.ReadOnly = true;
            // 
            // friendBindingSource
            // 
            this.friendBindingSource.DataSource = typeof(FacebookLogic.Friend);
            // 
            // labelSearchResults
            // 
            this.labelSearchResults.AutoSize = true;
            this.labelSearchResults.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelSearchResults.ForeColor = System.Drawing.Color.Black;
            this.labelSearchResults.Location = new System.Drawing.Point(29, 16);
            this.labelSearchResults.Name = "labelSearchResults";
            this.labelSearchResults.Size = new System.Drawing.Size(681, 24);
            this.labelSearchResults.TabIndex = 26;
            this.labelSearchResults.Text = "We Found Out Who Your Best Friends Are And Here Are The Results ...";
            this.labelSearchResults.UseWaitCursor = true;
            // 
            // checkBoxLikedPosts
            // 
            this.checkBoxLikedPosts.AutoSize = true;
            this.checkBoxLikedPosts.Checked = true;
            this.checkBoxLikedPosts.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxLikedPosts.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.checkBoxLikedPosts.ForeColor = System.Drawing.Color.DimGray;
            this.checkBoxLikedPosts.Location = new System.Drawing.Point(502, 182);
            this.checkBoxLikedPosts.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkBoxLikedPosts.Name = "checkBoxLikedPosts";
            this.checkBoxLikedPosts.Size = new System.Drawing.Size(138, 25);
            this.checkBoxLikedPosts.TabIndex = 40;
            this.checkBoxLikedPosts.Text = "Liked Posts";
            this.checkBoxLikedPosts.UseVisualStyleBackColor = true;
            // 
            // buttonSelectAll
            // 
            this.buttonSelectAll.BackColor = System.Drawing.Color.SkyBlue;
            this.buttonSelectAll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSelectAll.FlatAppearance.BorderSize = 0;
            this.buttonSelectAll.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.buttonSelectAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSelectAll.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonSelectAll.ForeColor = System.Drawing.Color.White;
            this.buttonSelectAll.Location = new System.Drawing.Point(929, 170);
            this.buttonSelectAll.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonSelectAll.Name = "buttonSelectAll";
            this.buttonSelectAll.Size = new System.Drawing.Size(128, 49);
            this.buttonSelectAll.TabIndex = 39;
            this.buttonSelectAll.Text = "Select All";
            this.buttonSelectAll.UseVisualStyleBackColor = false;
            this.buttonSelectAll.Click += new System.EventHandler(this.ButtonSelectAll_Click);
            // 
            // buttonSelectNone
            // 
            this.buttonSelectNone.BackColor = System.Drawing.Color.SkyBlue;
            this.buttonSelectNone.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSelectNone.FlatAppearance.BorderSize = 0;
            this.buttonSelectNone.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.buttonSelectNone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSelectNone.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonSelectNone.ForeColor = System.Drawing.Color.White;
            this.buttonSelectNone.Location = new System.Drawing.Point(929, 228);
            this.buttonSelectNone.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonSelectNone.Name = "buttonSelectNone";
            this.buttonSelectNone.Size = new System.Drawing.Size(128, 49);
            this.buttonSelectNone.TabIndex = 38;
            this.buttonSelectNone.Text = "Select None";
            this.buttonSelectNone.UseVisualStyleBackColor = false;
            this.buttonSelectNone.Click += new System.EventHandler(this.ButtonSelectNone_Click);
            // 
            // checkBoxCommonLikedPages
            // 
            this.checkBoxCommonLikedPages.AutoSize = true;
            this.checkBoxCommonLikedPages.Checked = true;
            this.checkBoxCommonLikedPages.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxCommonLikedPages.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.checkBoxCommonLikedPages.ForeColor = System.Drawing.Color.DimGray;
            this.checkBoxCommonLikedPages.Location = new System.Drawing.Point(502, 216);
            this.checkBoxCommonLikedPages.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkBoxCommonLikedPages.Name = "checkBoxCommonLikedPages";
            this.checkBoxCommonLikedPages.Size = new System.Drawing.Size(228, 25);
            this.checkBoxCommonLikedPages.TabIndex = 37;
            this.checkBoxCommonLikedPages.Text = "Common Liked Pages";
            this.checkBoxCommonLikedPages.UseVisualStyleBackColor = true;
            // 
            // labelSearchCriteria
            // 
            this.labelSearchCriteria.AutoSize = true;
            this.labelSearchCriteria.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelSearchCriteria.ForeColor = System.Drawing.Color.DimGray;
            this.labelSearchCriteria.Location = new System.Drawing.Point(273, 138);
            this.labelSearchCriteria.Name = "labelSearchCriteria";
            this.labelSearchCriteria.Size = new System.Drawing.Size(267, 24);
            this.labelSearchCriteria.TabIndex = 36;
            this.labelSearchCriteria.Text = "Choose the search criteria:";
            // 
            // checkBoxCommonCheckIn
            // 
            this.checkBoxCommonCheckIn.AutoSize = true;
            this.checkBoxCommonCheckIn.Checked = true;
            this.checkBoxCommonCheckIn.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxCommonCheckIn.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.checkBoxCommonCheckIn.ForeColor = System.Drawing.Color.DimGray;
            this.checkBoxCommonCheckIn.Location = new System.Drawing.Point(277, 250);
            this.checkBoxCommonCheckIn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkBoxCommonCheckIn.Name = "checkBoxCommonCheckIn";
            this.checkBoxCommonCheckIn.Size = new System.Drawing.Size(198, 25);
            this.checkBoxCommonCheckIn.TabIndex = 35;
            this.checkBoxCommonCheckIn.Text = "Common Check-In";
            this.checkBoxCommonCheckIn.UseVisualStyleBackColor = true;
            // 
            // checkBoxSharedEvents
            // 
            this.checkBoxSharedEvents.AutoSize = true;
            this.checkBoxSharedEvents.Checked = true;
            this.checkBoxSharedEvents.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxSharedEvents.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.checkBoxSharedEvents.ForeColor = System.Drawing.Color.DimGray;
            this.checkBoxSharedEvents.Location = new System.Drawing.Point(277, 216);
            this.checkBoxSharedEvents.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkBoxSharedEvents.Name = "checkBoxSharedEvents";
            this.checkBoxSharedEvents.Size = new System.Drawing.Size(164, 25);
            this.checkBoxSharedEvents.TabIndex = 34;
            this.checkBoxSharedEvents.Text = "Shared Events";
            this.checkBoxSharedEvents.UseVisualStyleBackColor = true;
            // 
            // checkBoxCommonGroups
            // 
            this.checkBoxCommonGroups.AutoSize = true;
            this.checkBoxCommonGroups.Checked = true;
            this.checkBoxCommonGroups.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxCommonGroups.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.checkBoxCommonGroups.ForeColor = System.Drawing.Color.DimGray;
            this.checkBoxCommonGroups.Location = new System.Drawing.Point(277, 182);
            this.checkBoxCommonGroups.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkBoxCommonGroups.Name = "checkBoxCommonGroups";
            this.checkBoxCommonGroups.Size = new System.Drawing.Size(185, 25);
            this.checkBoxCommonGroups.TabIndex = 33;
            this.checkBoxCommonGroups.Text = "Common Groups";
            this.checkBoxCommonGroups.UseVisualStyleBackColor = true;
            // 
            // buttonSearch
            // 
            this.buttonSearch.BackColor = System.Drawing.Color.SkyBlue;
            this.buttonSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSearch.FlatAppearance.BorderSize = 0;
            this.buttonSearch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.buttonSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSearch.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonSearch.ForeColor = System.Drawing.Color.White;
            this.buttonSearch.Location = new System.Drawing.Point(929, 95);
            this.buttonSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(128, 49);
            this.buttonSearch.TabIndex = 32;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = false;
            this.buttonSearch.Click += new System.EventHandler(this.ButtonSearch_Click);
            // 
            // numericUpDownNumOfFriends
            // 
            this.numericUpDownNumOfFriends.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.numericUpDownNumOfFriends.ForeColor = System.Drawing.Color.DimGray;
            this.numericUpDownNumOfFriends.Location = new System.Drawing.Point(775, 95);
            this.numericUpDownNumOfFriends.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numericUpDownNumOfFriends.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDownNumOfFriends.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownNumOfFriends.Name = "numericUpDownNumOfFriends";
            this.numericUpDownNumOfFriends.Size = new System.Drawing.Size(52, 28);
            this.numericUpDownNumOfFriends.TabIndex = 31;
            this.numericUpDownNumOfFriends.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDownNumOfFriends.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // labelNumOfBestFriends
            // 
            this.labelNumOfBestFriends.AutoSize = true;
            this.labelNumOfBestFriends.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelNumOfBestFriends.ForeColor = System.Drawing.Color.DimGray;
            this.labelNumOfBestFriends.Location = new System.Drawing.Point(273, 95);
            this.labelNumOfBestFriends.Name = "labelNumOfBestFriends";
            this.labelNumOfBestFriends.Size = new System.Drawing.Size(442, 24);
            this.labelNumOfBestFriends.TabIndex = 30;
            this.labelNumOfBestFriends.Text = "Choose the number of best friends to search:";
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.RoyalBlue;
            this.panelTop.Controls.Add(this.labelMyBestFriend);
            this.panelTop.Controls.Add(this.pictureBoxFBlogo);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.ForeColor = System.Drawing.Color.White;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1087, 70);
            this.panelTop.TabIndex = 42;
            // 
            // labelMyBestFriend
            // 
            this.labelMyBestFriend.AutoSize = true;
            this.labelMyBestFriend.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelMyBestFriend.ForeColor = System.Drawing.Color.White;
            this.labelMyBestFriend.Location = new System.Drawing.Point(83, 12);
            this.labelMyBestFriend.Name = "labelMyBestFriend";
            this.labelMyBestFriend.Size = new System.Drawing.Size(478, 43);
            this.labelMyBestFriend.TabIndex = 21;
            this.labelMyBestFriend.Text = "Discover Your Best Friends";
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
            // panelNav
            // 
            this.panelNav.BackColor = System.Drawing.Color.White;
            this.panelNav.Controls.Add(this.panel2);
            this.panelNav.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelNav.Location = new System.Drawing.Point(0, 70);
            this.panelNav.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelNav.Name = "panelNav";
            this.panelNav.Size = new System.Drawing.Size(205, 622);
            this.panelNav.TabIndex = 43;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.buttonFeatureMyCalendar);
            this.panel2.Controls.Add(this.buttonStartMenu);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(205, 622);
            this.panel2.TabIndex = 7;
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
            this.buttonFeatureMyCalendar.Location = new System.Drawing.Point(0, 329);
            this.buttonFeatureMyCalendar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonFeatureMyCalendar.Name = "buttonFeatureMyCalendar";
            this.buttonFeatureMyCalendar.Size = new System.Drawing.Size(205, 144);
            this.buttonFeatureMyCalendar.TabIndex = 10;
            this.buttonFeatureMyCalendar.Text = "My Calendar";
            this.buttonFeatureMyCalendar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonFeatureMyCalendar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonFeatureMyCalendar.UseVisualStyleBackColor = true;
            this.buttonFeatureMyCalendar.Click += new System.EventHandler(this.ButtonFeatureMyCalendar_Click);
            // 
            // buttonStartMenu
            // 
            this.buttonStartMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonStartMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonStartMenu.FlatAppearance.BorderSize = 0;
            this.buttonStartMenu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.buttonStartMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStartMenu.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonStartMenu.ForeColor = System.Drawing.Color.RoyalBlue;
            this.buttonStartMenu.Image = ((System.Drawing.Image)(resources.GetObject("buttonStartMenu.Image")));
            this.buttonStartMenu.Location = new System.Drawing.Point(0, 189);
            this.buttonStartMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonStartMenu.Name = "buttonStartMenu";
            this.buttonStartMenu.Size = new System.Drawing.Size(205, 140);
            this.buttonStartMenu.TabIndex = 9;
            this.buttonStartMenu.Text = "Home";
            this.buttonStartMenu.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonStartMenu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonStartMenu.UseVisualStyleBackColor = true;
            this.buttonStartMenu.Click += new System.EventHandler(this.ButtonStartMenu_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.pictureBoxProfile);
            this.panel3.Controls.Add(this.labelUserName);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(205, 189);
            this.panel3.TabIndex = 8;
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
            this.pictureBoxProfile.TabIndex = 2;
            this.pictureBoxProfile.TabStop = false;
            // 
            // facebookConnectorBindingSource
            // 
            this.facebookConnectorBindingSource.DataSource = typeof(FacebookLogic.FacebookConnector);
            // 
            // labelUserName
            // 
            this.labelUserName.AutoSize = true;
            this.labelUserName.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelUserName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelUserName.Location = new System.Drawing.Point(71, 134);
            this.labelUserName.Name = "labelUserName";
            this.labelUserName.Size = new System.Drawing.Size(0, 24);
            this.labelUserName.TabIndex = 1;
            // 
            // panelCheckBoxFilters
            // 
            this.panelCheckBoxFilters.Location = new System.Drawing.Point(277, 165);
            this.panelCheckBoxFilters.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelCheckBoxFilters.Name = "panelCheckBoxFilters";
            this.panelCheckBoxFilters.Size = new System.Drawing.Size(453, 125);
            this.panelCheckBoxFilters.TabIndex = 44;
            // 
            // FormMyBestFriendsFinder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1087, 692);
            this.Controls.Add(this.panelNav);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.panelSearchResults);
            this.Controls.Add(this.checkBoxLikedPosts);
            this.Controls.Add(this.buttonSelectAll);
            this.Controls.Add(this.buttonSelectNone);
            this.Controls.Add(this.checkBoxCommonLikedPages);
            this.Controls.Add(this.labelSearchCriteria);
            this.Controls.Add(this.checkBoxCommonCheckIn);
            this.Controls.Add(this.checkBoxSharedEvents);
            this.Controls.Add(this.checkBoxCommonGroups);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.numericUpDownNumOfFriends);
            this.Controls.Add(this.labelNumOfBestFriends);
            this.Controls.Add(this.panelCheckBoxFilters);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "FormMyBestFriendsFinder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "My Best Friends Finder";
            this.Activated += new System.EventHandler(this.FormMyBestFriendsFinder_Activated);
            this.panelSearchResults.ResumeLayout(false);
            this.panelSearchResults.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.friendDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.friendBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNumOfFriends)).EndInit();
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFBlogo)).EndInit();
            this.panelNav.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.facebookConnectorBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelSearchResults;
        private System.Windows.Forms.Label labelSearchResults;
        private System.Windows.Forms.CheckBox checkBoxLikedPosts;
        private System.Windows.Forms.Button buttonSelectAll;
        private System.Windows.Forms.Button buttonSelectNone;
        private System.Windows.Forms.CheckBox checkBoxCommonLikedPages;
        private System.Windows.Forms.Label labelSearchCriteria;
        private System.Windows.Forms.CheckBox checkBoxCommonCheckIn;
        private System.Windows.Forms.CheckBox checkBoxSharedEvents;
        private System.Windows.Forms.CheckBox checkBoxCommonGroups;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.NumericUpDown numericUpDownNumOfFriends;
        private System.Windows.Forms.Label labelNumOfBestFriends;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label labelMyBestFriend;
        private System.Windows.Forms.PictureBox pictureBoxFBlogo;
        private System.Windows.Forms.Panel panelNav;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonStartMenu;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label labelUserName;
        private System.Windows.Forms.Button buttonFeatureMyCalendar;
        private System.Windows.Forms.PictureBox pictureBoxProfile;
        private System.Windows.Forms.BindingSource friendBindingSource;
        private System.Windows.Forms.DataGridView friendDataGridView;
        private System.Windows.Forms.BindingSource facebookConnectorBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ranking;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn profilePhotoDataGridViewImageColumn;
        private System.Windows.Forms.Panel panelCheckBoxFilters;
    }
}