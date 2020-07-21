namespace FacebookUI
{
    partial class FormFacebookCalendar
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
            System.Windows.Forms.Button buttonRemoveTasks;
            System.Windows.Forms.Button buttonAddTask;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFacebookCalendar));
            this.panelTop = new System.Windows.Forms.Panel();
            this.labelMyCalendar = new System.Windows.Forms.Label();
            this.pictureBoxFBlogo = new System.Windows.Forms.PictureBox();
            this.panelNav = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonFacebookBestFriends = new System.Windows.Forms.Button();
            this.buttonStartMenu = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBoxProfile = new System.Windows.Forms.PictureBox();
            this.labelUserName = new System.Windows.Forms.Label();
            this.monthCalendar = new System.Windows.Forms.MonthCalendar();
            this.labelSelectedDate = new System.Windows.Forms.Label();
            this.panelAddTask = new System.Windows.Forms.Panel();
            this.textBoxCreateNewTask = new System.Windows.Forms.TextBox();
            this.textBoxAddNewTask = new System.Windows.Forms.TextBox();
            this.panelTodayTasks = new System.Windows.Forms.Panel();
            this.listBoxTodayTasks = new System.Windows.Forms.ListBox();
            this.textBoxTodayTasks = new System.Windows.Forms.TextBox();
            this.panelTodayEvents = new System.Windows.Forms.Panel();
            this.listBoxTodayEvents = new System.Windows.Forms.ListBox();
            this.textBoxTodayEvents = new System.Windows.Forms.TextBox();
            this.panelTodayBirthdays = new System.Windows.Forms.Panel();
            this.listBoxTodayBirthdays = new System.Windows.Forms.ListBox();
            this.textBoxTodayBirthdays = new System.Windows.Forms.TextBox();
            this.facebookConnectorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            buttonRemoveTasks = new System.Windows.Forms.Button();
            buttonAddTask = new System.Windows.Forms.Button();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFBlogo)).BeginInit();
            this.panelNav.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).BeginInit();
            this.panelAddTask.SuspendLayout();
            this.panelTodayTasks.SuspendLayout();
            this.panelTodayEvents.SuspendLayout();
            this.panelTodayBirthdays.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.facebookConnectorBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonRemoveTasks
            // 
            buttonRemoveTasks.BackColor = System.Drawing.Color.RoyalBlue;
            buttonRemoveTasks.Cursor = System.Windows.Forms.Cursors.Hand;
            buttonRemoveTasks.Dock = System.Windows.Forms.DockStyle.Bottom;
            buttonRemoveTasks.FlatAppearance.BorderSize = 0;
            buttonRemoveTasks.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Navy;
            buttonRemoveTasks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            buttonRemoveTasks.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            buttonRemoveTasks.ForeColor = System.Drawing.Color.White;
            buttonRemoveTasks.Location = new System.Drawing.Point(0, 203);
            buttonRemoveTasks.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            buttonRemoveTasks.Name = "buttonRemoveTasks";
            buttonRemoveTasks.Size = new System.Drawing.Size(281, 48);
            buttonRemoveTasks.TabIndex = 38;
            buttonRemoveTasks.Text = "Remove Task From List";
            buttonRemoveTasks.UseVisualStyleBackColor = false;
            buttonRemoveTasks.Click += new System.EventHandler(this.ButtonRemoveTasks_Click);
            // 
            // buttonAddTask
            // 
            buttonAddTask.BackColor = System.Drawing.Color.RoyalBlue;
            buttonAddTask.Cursor = System.Windows.Forms.Cursors.Hand;
            buttonAddTask.Dock = System.Windows.Forms.DockStyle.Bottom;
            buttonAddTask.FlatAppearance.BorderSize = 0;
            buttonAddTask.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Navy;
            buttonAddTask.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            buttonAddTask.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            buttonAddTask.ForeColor = System.Drawing.Color.White;
            buttonAddTask.Location = new System.Drawing.Point(0, 203);
            buttonAddTask.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            buttonAddTask.Name = "buttonAddTask";
            buttonAddTask.Size = new System.Drawing.Size(281, 48);
            buttonAddTask.TabIndex = 38;
            buttonAddTask.Text = "Add Task";
            buttonAddTask.UseVisualStyleBackColor = false;
            buttonAddTask.Click += new System.EventHandler(this.ButtonAddTask_Click);
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.RoyalBlue;
            this.panelTop.Controls.Add(this.labelMyCalendar);
            this.panelTop.Controls.Add(this.pictureBoxFBlogo);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.ForeColor = System.Drawing.Color.White;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1305, 70);
            this.panelTop.TabIndex = 1;
            // 
            // labelMyCalendar
            // 
            this.labelMyCalendar.AutoSize = true;
            this.labelMyCalendar.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelMyCalendar.ForeColor = System.Drawing.Color.White;
            this.labelMyCalendar.Location = new System.Drawing.Point(83, 12);
            this.labelMyCalendar.Name = "labelMyCalendar";
            this.labelMyCalendar.Size = new System.Drawing.Size(232, 43);
            this.labelMyCalendar.TabIndex = 21;
            this.labelMyCalendar.Text = "My Calendar";
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
            this.panelNav.Size = new System.Drawing.Size(205, 625);
            this.panelNav.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.buttonFacebookBestFriends);
            this.panel2.Controls.Add(this.buttonStartMenu);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(205, 625);
            this.panel2.TabIndex = 7;
            // 
            // buttonFacebookBestFriends
            // 
            this.buttonFacebookBestFriends.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonFacebookBestFriends.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonFacebookBestFriends.FlatAppearance.BorderSize = 0;
            this.buttonFacebookBestFriends.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.buttonFacebookBestFriends.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFacebookBestFriends.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonFacebookBestFriends.ForeColor = System.Drawing.Color.RoyalBlue;
            this.buttonFacebookBestFriends.Image = ((System.Drawing.Image)(resources.GetObject("buttonFacebookBestFriends.Image")));
            this.buttonFacebookBestFriends.Location = new System.Drawing.Point(0, 329);
            this.buttonFacebookBestFriends.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonFacebookBestFriends.Name = "buttonFacebookBestFriends";
            this.buttonFacebookBestFriends.Size = new System.Drawing.Size(205, 148);
            this.buttonFacebookBestFriends.TabIndex = 10;
            this.buttonFacebookBestFriends.Text = "Find My Best Friends";
            this.buttonFacebookBestFriends.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonFacebookBestFriends.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonFacebookBestFriends.UseVisualStyleBackColor = true;
            this.buttonFacebookBestFriends.Click += new System.EventHandler(this.ButtonFacebookBestFriend_Click);
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
            // monthCalendar
            // 
            this.monthCalendar.BackColor = System.Drawing.Color.White;
            this.monthCalendar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.monthCalendar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.monthCalendar.ForeColor = System.Drawing.Color.White;
            this.monthCalendar.Location = new System.Drawing.Point(217, 92);
            this.monthCalendar.MaxSelectionCount = 1;
            this.monthCalendar.Name = "monthCalendar";
            this.monthCalendar.ShowToday = false;
            this.monthCalendar.ShowTodayCircle = false;
            this.monthCalendar.TabIndex = 3;
            this.monthCalendar.TitleBackColor = System.Drawing.Color.White;
            this.monthCalendar.TitleForeColor = System.Drawing.Color.White;
            this.monthCalendar.TodayDate = new System.DateTime(2019, 11, 22, 0, 0, 0, 0);
            this.monthCalendar.TrailingForeColor = System.Drawing.Color.White;
            this.monthCalendar.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.MonthCalendar_DateSelected);
            // 
            // labelSelectedDate
            // 
            this.labelSelectedDate.AutoSize = true;
            this.labelSelectedDate.BackColor = System.Drawing.SystemColors.Control;
            this.labelSelectedDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelSelectedDate.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelSelectedDate.ForeColor = System.Drawing.Color.DimGray;
            this.labelSelectedDate.Location = new System.Drawing.Point(328, 351);
            this.labelSelectedDate.Name = "labelSelectedDate";
            this.labelSelectedDate.Size = new System.Drawing.Size(147, 26);
            this.labelSelectedDate.TabIndex = 20;
            this.labelSelectedDate.Text = "SelectedDate";
            this.labelSelectedDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelAddTask
            // 
            this.panelAddTask.BackColor = System.Drawing.Color.White;
            this.panelAddTask.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelAddTask.Controls.Add(buttonAddTask);
            this.panelAddTask.Controls.Add(this.textBoxCreateNewTask);
            this.panelAddTask.Controls.Add(this.textBoxAddNewTask);
            this.panelAddTask.Location = new System.Drawing.Point(884, 92);
            this.panelAddTask.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelAddTask.Name = "panelAddTask";
            this.panelAddTask.Size = new System.Drawing.Size(283, 253);
            this.panelAddTask.TabIndex = 33;
            // 
            // textBoxCreateNewTask
            // 
            this.textBoxCreateNewTask.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBoxCreateNewTask.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.textBoxCreateNewTask.ForeColor = System.Drawing.Color.DimGray;
            this.textBoxCreateNewTask.Location = new System.Drawing.Point(0, 28);
            this.textBoxCreateNewTask.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxCreateNewTask.Multiline = true;
            this.textBoxCreateNewTask.Name = "textBoxCreateNewTask";
            this.textBoxCreateNewTask.Size = new System.Drawing.Size(281, 176);
            this.textBoxCreateNewTask.TabIndex = 5;
            this.textBoxCreateNewTask.Text = "Write Something...";
            this.textBoxCreateNewTask.Click += new System.EventHandler(this.TextBoxCreateNewTask_Click);
            // 
            // textBoxAddNewTask
            // 
            this.textBoxAddNewTask.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBoxAddNewTask.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxAddNewTask.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBoxAddNewTask.Enabled = false;
            this.textBoxAddNewTask.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.textBoxAddNewTask.ForeColor = System.Drawing.Color.DimGray;
            this.textBoxAddNewTask.Location = new System.Drawing.Point(0, 0);
            this.textBoxAddNewTask.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxAddNewTask.Name = "textBoxAddNewTask";
            this.textBoxAddNewTask.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBoxAddNewTask.Size = new System.Drawing.Size(281, 28);
            this.textBoxAddNewTask.TabIndex = 4;
            this.textBoxAddNewTask.Text = "  Add New Tasks";
            // 
            // panelTodayTasks
            // 
            this.panelTodayTasks.BackColor = System.Drawing.Color.White;
            this.panelTodayTasks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelTodayTasks.Controls.Add(buttonRemoveTasks);
            this.panelTodayTasks.Controls.Add(this.listBoxTodayTasks);
            this.panelTodayTasks.Controls.Add(this.textBoxTodayTasks);
            this.panelTodayTasks.Location = new System.Drawing.Point(573, 94);
            this.panelTodayTasks.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelTodayTasks.Name = "panelTodayTasks";
            this.panelTodayTasks.Size = new System.Drawing.Size(283, 253);
            this.panelTodayTasks.TabIndex = 34;
            // 
            // listBoxTodayTasks
            // 
            this.listBoxTodayTasks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBoxTodayTasks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxTodayTasks.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.listBoxTodayTasks.ForeColor = System.Drawing.Color.DimGray;
            this.listBoxTodayTasks.FormattingEnabled = true;
            this.listBoxTodayTasks.ItemHeight = 19;
            this.listBoxTodayTasks.Location = new System.Drawing.Point(0, 28);
            this.listBoxTodayTasks.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBoxTodayTasks.Name = "listBoxTodayTasks";
            this.listBoxTodayTasks.Size = new System.Drawing.Size(281, 223);
            this.listBoxTodayTasks.TabIndex = 5;
            // 
            // textBoxTodayTasks
            // 
            this.textBoxTodayTasks.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBoxTodayTasks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxTodayTasks.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBoxTodayTasks.Enabled = false;
            this.textBoxTodayTasks.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.textBoxTodayTasks.ForeColor = System.Drawing.Color.DimGray;
            this.textBoxTodayTasks.Location = new System.Drawing.Point(0, 0);
            this.textBoxTodayTasks.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxTodayTasks.Name = "textBoxTodayTasks";
            this.textBoxTodayTasks.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBoxTodayTasks.Size = new System.Drawing.Size(281, 28);
            this.textBoxTodayTasks.TabIndex = 4;
            // 
            // panelTodayEvents
            // 
            this.panelTodayEvents.BackColor = System.Drawing.Color.White;
            this.panelTodayEvents.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelTodayEvents.Controls.Add(this.listBoxTodayEvents);
            this.panelTodayEvents.Controls.Add(this.textBoxTodayEvents);
            this.panelTodayEvents.Location = new System.Drawing.Point(572, 422);
            this.panelTodayEvents.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelTodayEvents.Name = "panelTodayEvents";
            this.panelTodayEvents.Size = new System.Drawing.Size(283, 253);
            this.panelTodayEvents.TabIndex = 36;
            // 
            // listBoxTodayEvents
            // 
            this.listBoxTodayEvents.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBoxTodayEvents.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxTodayEvents.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.listBoxTodayEvents.ForeColor = System.Drawing.Color.DimGray;
            this.listBoxTodayEvents.FormattingEnabled = true;
            this.listBoxTodayEvents.HorizontalScrollbar = true;
            this.listBoxTodayEvents.ItemHeight = 19;
            this.listBoxTodayEvents.Location = new System.Drawing.Point(0, 28);
            this.listBoxTodayEvents.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBoxTodayEvents.Name = "listBoxTodayEvents";
            this.listBoxTodayEvents.Size = new System.Drawing.Size(281, 223);
            this.listBoxTodayEvents.TabIndex = 5;
            // 
            // textBoxTodayEvents
            // 
            this.textBoxTodayEvents.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBoxTodayEvents.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxTodayEvents.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBoxTodayEvents.Enabled = false;
            this.textBoxTodayEvents.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.textBoxTodayEvents.ForeColor = System.Drawing.Color.DimGray;
            this.textBoxTodayEvents.Location = new System.Drawing.Point(0, 0);
            this.textBoxTodayEvents.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxTodayEvents.Name = "textBoxTodayEvents";
            this.textBoxTodayEvents.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBoxTodayEvents.Size = new System.Drawing.Size(281, 28);
            this.textBoxTodayEvents.TabIndex = 4;
            this.textBoxTodayEvents.Text = "  ";
            // 
            // panelTodayBirthdays
            // 
            this.panelTodayBirthdays.BackColor = System.Drawing.Color.White;
            this.panelTodayBirthdays.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelTodayBirthdays.Controls.Add(this.listBoxTodayBirthdays);
            this.panelTodayBirthdays.Controls.Add(this.textBoxTodayBirthdays);
            this.panelTodayBirthdays.Location = new System.Drawing.Point(260, 421);
            this.panelTodayBirthdays.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelTodayBirthdays.Name = "panelTodayBirthdays";
            this.panelTodayBirthdays.Size = new System.Drawing.Size(283, 253);
            this.panelTodayBirthdays.TabIndex = 37;
            // 
            // listBoxTodayBirthdays
            // 
            this.listBoxTodayBirthdays.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBoxTodayBirthdays.DisplayMember = "About";
            this.listBoxTodayBirthdays.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxTodayBirthdays.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.listBoxTodayBirthdays.ForeColor = System.Drawing.Color.DimGray;
            this.listBoxTodayBirthdays.FormattingEnabled = true;
            this.listBoxTodayBirthdays.HorizontalScrollbar = true;
            this.listBoxTodayBirthdays.ItemHeight = 19;
            this.listBoxTodayBirthdays.Location = new System.Drawing.Point(0, 28);
            this.listBoxTodayBirthdays.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBoxTodayBirthdays.Name = "listBoxTodayBirthdays";
            this.listBoxTodayBirthdays.Size = new System.Drawing.Size(281, 223);
            this.listBoxTodayBirthdays.TabIndex = 5;
            this.listBoxTodayBirthdays.ValueMember = "About";
            // 
            // textBoxTodayBirthdays
            // 
            this.textBoxTodayBirthdays.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBoxTodayBirthdays.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxTodayBirthdays.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBoxTodayBirthdays.Enabled = false;
            this.textBoxTodayBirthdays.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.textBoxTodayBirthdays.ForeColor = System.Drawing.Color.DimGray;
            this.textBoxTodayBirthdays.Location = new System.Drawing.Point(0, 0);
            this.textBoxTodayBirthdays.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxTodayBirthdays.Name = "textBoxTodayBirthdays";
            this.textBoxTodayBirthdays.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBoxTodayBirthdays.Size = new System.Drawing.Size(281, 28);
            this.textBoxTodayBirthdays.TabIndex = 4;
            // 
            // facebookConnectorBindingSource
            // 
            this.facebookConnectorBindingSource.DataSource = typeof(FacebookLogic.FacebookConnector);
            // 
            // FormFacebookCalendar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1305, 695);
            this.Controls.Add(this.panelTodayBirthdays);
            this.Controls.Add(this.panelTodayEvents);
            this.Controls.Add(this.panelTodayTasks);
            this.Controls.Add(this.panelAddTask);
            this.Controls.Add(this.labelSelectedDate);
            this.Controls.Add(this.monthCalendar);
            this.Controls.Add(this.panelNav);
            this.Controls.Add(this.panelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "FormFacebookCalendar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "My Calendar";
            this.Activated += new System.EventHandler(this.FormFacebookCalendar_Activated);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFBlogo)).EndInit();
            this.panelNav.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).EndInit();
            this.panelAddTask.ResumeLayout(false);
            this.panelAddTask.PerformLayout();
            this.panelTodayTasks.ResumeLayout(false);
            this.panelTodayTasks.PerformLayout();
            this.panelTodayEvents.ResumeLayout(false);
            this.panelTodayEvents.PerformLayout();
            this.panelTodayBirthdays.ResumeLayout(false);
            this.panelTodayBirthdays.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.facebookConnectorBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.PictureBox pictureBoxFBlogo;
        private System.Windows.Forms.Panel panelNav;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.MonthCalendar monthCalendar;
        private System.Windows.Forms.Label labelSelectedDate;
        private System.Windows.Forms.Label labelMyCalendar;
        private System.Windows.Forms.Panel panelAddTask;
        private System.Windows.Forms.TextBox textBoxAddNewTask;
        private System.Windows.Forms.Panel panelTodayTasks;
        private System.Windows.Forms.ListBox listBoxTodayTasks;
        private System.Windows.Forms.TextBox textBoxTodayTasks;
        private System.Windows.Forms.Panel panelTodayEvents;
        private System.Windows.Forms.ListBox listBoxTodayEvents;
        private System.Windows.Forms.TextBox textBoxTodayEvents;
        private System.Windows.Forms.Panel panelTodayBirthdays;
        private System.Windows.Forms.ListBox listBoxTodayBirthdays;
        private System.Windows.Forms.TextBox textBoxTodayBirthdays;
        private System.Windows.Forms.TextBox textBoxCreateNewTask;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label labelUserName;
        private System.Windows.Forms.Button buttonFacebookBestFriends;
        private System.Windows.Forms.Button buttonStartMenu;
        private System.Windows.Forms.PictureBox pictureBoxProfile;
        private System.Windows.Forms.BindingSource facebookConnectorBindingSource;
    }
}