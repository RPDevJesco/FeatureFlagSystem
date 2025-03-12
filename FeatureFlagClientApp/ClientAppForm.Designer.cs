namespace FeatureFlagClientApp
{
    partial class ClientAppForm
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
            this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.darkModeMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.featuresMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.analyticsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.betaFeaturesMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adminMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userManagementMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.userStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.featuresStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.sidePanel = new System.Windows.Forms.Panel();
            this.weekendModePanel = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.exportButton = new System.Windows.Forms.Button();
            this.adminButton = new System.Windows.Forms.Button();
            this.userProfilePanel = new System.Windows.Forms.Panel();
            this.userRolesLabel = new System.Windows.Forms.Label();
            this.userSubscriptionLabel = new System.Windows.Forms.Label();
            this.userEmailLabel = new System.Windows.Forms.Label();
            this.userNameLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.userComboBox = new System.Windows.Forms.ComboBox();
            this.generateRandomUserButton = new System.Windows.Forms.Button();
            this.dashboardPanel = new System.Windows.Forms.Panel();
            this.betaBadgeLabel = new System.Windows.Forms.Label();
            this.analyticsPanel = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label5 = new System.Windows.Forms.Label();
            this.searchPanel = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.mainMenuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.sidePanel.SuspendLayout();
            this.weekendModePanel.SuspendLayout();
            this.userProfilePanel.SuspendLayout();
            this.dashboardPanel.SuspendLayout();
            this.analyticsPanel.SuspendLayout();
            this.searchPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenuStrip
            // 
            this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[]
            {
                this.fileMenuItem,
                this.featuresMenuItem,
                this.adminMenuItem
            });
            this.mainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.mainMenuStrip.Name = "mainMenuStrip";
            this.mainMenuStrip.Size = new System.Drawing.Size(1024, 24);
            this.mainMenuStrip.TabIndex = 0;
            this.mainMenuStrip.Text = "menuStrip1";
            // 
            // fileMenuItem
            // 
            this.fileMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[]
            {
                this.darkModeMenuItem,
                this.exitMenuItem
            });
            this.fileMenuItem.Name = "fileMenuItem";
            this.fileMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileMenuItem.Text = "&File";
            // 
            // darkModeMenuItem
            // 
            this.darkModeMenuItem.Name = "darkModeMenuItem";
            this.darkModeMenuItem.Size = new System.Drawing.Size(135, 22);
            this.darkModeMenuItem.Text = "Dark Mode";
            this.darkModeMenuItem.Click += new System.EventHandler(this.darkModeMenuItem_Click);
            // 
            // exitMenuItem
            // 
            this.exitMenuItem.Name = "exitMenuItem";
            this.exitMenuItem.Size = new System.Drawing.Size(135, 22);
            this.exitMenuItem.Text = "Exit";
            this.exitMenuItem.Click += new System.EventHandler(this.exitMenuItem_Click);
            // 
            // featuresMenuItem
            // 
            this.featuresMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[]
            {
                this.searchMenuItem,
                this.analyticsMenuItem,
                this.exportMenuItem,
                this.betaFeaturesMenuItem
            });
            this.featuresMenuItem.Name = "featuresMenuItem";
            this.featuresMenuItem.Size = new System.Drawing.Size(63, 20);
            this.featuresMenuItem.Text = "&Features";
            // 
            // searchMenuItem
            // 
            this.searchMenuItem.Name = "searchMenuItem";
            this.searchMenuItem.Size = new System.Drawing.Size(180, 22);
            this.searchMenuItem.Text = "Search";
            this.searchMenuItem.Click += new System.EventHandler(this.searchMenuItem_Click);
            // 
            // analyticsMenuItem
            // 
            this.analyticsMenuItem.Name = "analyticsMenuItem";
            this.analyticsMenuItem.Size = new System.Drawing.Size(180, 22);
            this.analyticsMenuItem.Text = "Advanced Analytics";
            this.analyticsMenuItem.Click += new System.EventHandler(this.analyticsMenuItem_Click);
            // 
            // exportMenuItem
            // 
            this.exportMenuItem.Name = "exportMenuItem";
            this.exportMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exportMenuItem.Text = "Export Data";
            this.exportMenuItem.Click += new System.EventHandler(this.exportMenuItem_Click);
            // 
            // betaFeaturesMenuItem
            // 
            this.betaFeaturesMenuItem.Name = "betaFeaturesMenuItem";
            this.betaFeaturesMenuItem.Size = new System.Drawing.Size(180, 22);
            this.betaFeaturesMenuItem.Text = "Beta Dashboard";
            this.betaFeaturesMenuItem.Click += new System.EventHandler(this.betaFeaturesMenuItem_Click);
            // 
            // adminMenuItem
            // 
            this.adminMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[]
            {
                this.userManagementMenuItem
            });
            this.adminMenuItem.Name = "adminMenuItem";
            this.adminMenuItem.Size = new System.Drawing.Size(55, 20);
            this.adminMenuItem.Text = "Admin";
            this.adminMenuItem.Click += new System.EventHandler(this.adminMenuItem_Click);
            // 
            // userManagementMenuItem
            // 
            this.userManagementMenuItem.Name = "userManagementMenuItem";
            this.userManagementMenuItem.Size = new System.Drawing.Size(180, 22);
            this.userManagementMenuItem.Text = "User Management";
            this.userManagementMenuItem.Click += new System.EventHandler(this.userManagementMenuItem_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[]
            {
                this.userStatusLabel,
                this.featuresStatusLabel
            });
            this.statusStrip.Location = new System.Drawing.Point(0, 678);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(1024, 22);
            this.statusStrip.TabIndex = 1;
            this.statusStrip.Text = "statusStrip1";
            // 
            // userStatusLabel
            // 
            this.userStatusLabel.Name = "userStatusLabel";
            this.userStatusLabel.Size = new System.Drawing.Size(33, 17);
            this.userStatusLabel.Text = "User:";
            // 
            // featuresStatusLabel
            // 
            this.featuresStatusLabel.Name = "featuresStatusLabel";
            this.featuresStatusLabel.Size = new System.Drawing.Size(98, 17);
            this.featuresStatusLabel.Text = "Enabled Features:";
            // 
            // sidePanel
            // 
            this.sidePanel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.sidePanel.Controls.Add(this.weekendModePanel);
            this.sidePanel.Controls.Add(this.exportButton);
            this.sidePanel.Controls.Add(this.adminButton);
            this.sidePanel.Controls.Add(this.userProfilePanel);
            this.sidePanel.Controls.Add(this.userComboBox);
            this.sidePanel.Controls.Add(this.generateRandomUserButton);
            this.sidePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidePanel.Location = new System.Drawing.Point(0, 24);
            this.sidePanel.Name = "sidePanel";
            this.sidePanel.Size = new System.Drawing.Size(250, 654);
            this.sidePanel.TabIndex = 2;
            // 
            // weekendModePanel
            // 
            this.weekendModePanel.Anchor =
                ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom |
                                                       System.Windows.Forms.AnchorStyles.Left)
                                                      | System.Windows.Forms.AnchorStyles.Right)));
            this.weekendModePanel.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.weekendModePanel.Controls.Add(this.label8);
            this.weekendModePanel.Controls.Add(this.label7);
            this.weekendModePanel.Location = new System.Drawing.Point(12, 554);
            this.weekendModePanel.Name = "weekendModePanel";
            this.weekendModePanel.Size = new System.Drawing.Size(226, 88);
            this.weekendModePanel.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(13, 32);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(198, 47);
            this.label8.TabIndex = 1;
            this.label8.Text = "This panel is only visible on weekends. Enjoy your time off!";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(13, 10);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(121, 16);
            this.label7.TabIndex = 0;
            this.label7.Text = "WEEKEND MODE";
            // 
            // exportButton
            // 
            this.exportButton.Anchor =
                ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top |
                                                       System.Windows.Forms.AnchorStyles.Left)
                                                      | System.Windows.Forms.AnchorStyles.Right)));
            this.exportButton.Location = new System.Drawing.Point(12, 393);
            this.exportButton.Name = "exportButton";
            this.exportButton.Size = new System.Drawing.Size(226, 34);
            this.exportButton.TabIndex = 4;
            this.exportButton.Text = "Export Data";
            this.exportButton.UseVisualStyleBackColor = true;
            this.exportButton.Click += new System.EventHandler(this.exportButton_Click);
            // 
            // adminButton
            // 
            this.adminButton.Anchor =
                ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top |
                                                       System.Windows.Forms.AnchorStyles.Left)
                                                      | System.Windows.Forms.AnchorStyles.Right)));
            this.adminButton.BackColor =
                System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.adminButton.ForeColor = System.Drawing.Color.White;
            this.adminButton.Location = new System.Drawing.Point(12, 433);
            this.adminButton.Name = "adminButton";
            this.adminButton.Size = new System.Drawing.Size(226, 34);
            this.adminButton.TabIndex = 3;
            this.adminButton.Text = "Admin Panel";
            this.adminButton.UseVisualStyleBackColor = false;
            this.adminButton.Click += new System.EventHandler(this.adminButton_Click);
            // 
            // userProfilePanel
            // 
            this.userProfilePanel.Anchor =
                ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top |
                                                       System.Windows.Forms.AnchorStyles.Left)
                                                      | System.Windows.Forms.AnchorStyles.Right)));
            this.userProfilePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.userProfilePanel.Controls.Add(this.userRolesLabel);
            this.userProfilePanel.Controls.Add(this.userSubscriptionLabel);
            this.userProfilePanel.Controls.Add(this.userEmailLabel);
            this.userProfilePanel.Controls.Add(this.userNameLabel);
            this.userProfilePanel.Controls.Add(this.label4);
            this.userProfilePanel.Location = new System.Drawing.Point(12, 97);
            this.userProfilePanel.Name = "userProfilePanel";
            this.userProfilePanel.Size = new System.Drawing.Size(226, 190);
            this.userProfilePanel.TabIndex = 2;
            // 
            // userRolesLabel
            // 
            this.userRolesLabel.AutoSize = true;
            this.userRolesLabel.Location = new System.Drawing.Point(12, 143);
            this.userRolesLabel.Name = "userRolesLabel";
            this.userRolesLabel.Size = new System.Drawing.Size(34, 13);
            this.userRolesLabel.TabIndex = 4;
            this.userRolesLabel.Text = "Roles";
            // 
            // userSubscriptionLabel
            // 
            this.userSubscriptionLabel.AutoSize = true;
            this.userSubscriptionLabel.Location = new System.Drawing.Point(12, 114);
            this.userSubscriptionLabel.Name = "userSubscriptionLabel";
            this.userSubscriptionLabel.Size = new System.Drawing.Size(65, 13);
            this.userSubscriptionLabel.TabIndex = 3;
            this.userSubscriptionLabel.Text = "Subscription";
            // 
            // userEmailLabel
            // 
            this.userEmailLabel.AutoSize = true;
            this.userEmailLabel.Location = new System.Drawing.Point(12, 85);
            this.userEmailLabel.Name = "userEmailLabel";
            this.userEmailLabel.Size = new System.Drawing.Size(35, 13);
            this.userEmailLabel.TabIndex = 2;
            this.userEmailLabel.Text = "Email:";
            // 
            // userNameLabel
            // 
            this.userNameLabel.AutoSize = true;
            this.userNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F,
                System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNameLabel.Location = new System.Drawing.Point(12, 50);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(82, 16);
            this.userNameLabel.TabIndex = 1;
            this.userNameLabel.Text = "User Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "User Profile:";
            // 
            // userComboBox
            // 
            this.userComboBox.Anchor =
                ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top |
                                                       System.Windows.Forms.AnchorStyles.Left)
                                                      | System.Windows.Forms.AnchorStyles.Right)));
            this.userComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.userComboBox.FormattingEnabled = true;
            this.userComboBox.Location = new System.Drawing.Point(12, 17);
            this.userComboBox.Name = "userComboBox";
            this.userComboBox.Size = new System.Drawing.Size(226, 21);
            this.userComboBox.TabIndex = 1;
            this.userComboBox.SelectedIndexChanged += new System.EventHandler(this.userComboBox_SelectedIndexChanged);
            // 
            // generateRandomUserButton
            // 
            this.generateRandomUserButton.Anchor =
                ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top |
                                                       System.Windows.Forms.AnchorStyles.Left)
                                                      | System.Windows.Forms.AnchorStyles.Right)));
            this.generateRandomUserButton.Location = new System.Drawing.Point(12, 53);
            this.generateRandomUserButton.Name = "generateRandomUserButton";
            this.generateRandomUserButton.Size = new System.Drawing.Size(226, 23);
            this.generateRandomUserButton.TabIndex = 0;
            this.generateRandomUserButton.Text = "Generate Random User";
            this.generateRandomUserButton.UseVisualStyleBackColor = true;
            this.generateRandomUserButton.Click += new System.EventHandler(this.generateRandomUserButton_Click);
            // 
            // dashboardPanel
            // 
            this.dashboardPanel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.dashboardPanel.Controls.Add(this.betaBadgeLabel);
            this.dashboardPanel.Controls.Add(this.analyticsPanel);
            this.dashboardPanel.Controls.Add(this.searchPanel);
            this.dashboardPanel.Controls.Add(this.label1);
            this.dashboardPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dashboardPanel.Location = new System.Drawing.Point(250, 24);
            this.dashboardPanel.Name = "dashboardPanel";
            this.dashboardPanel.Padding = new System.Windows.Forms.Padding(20);
            this.dashboardPanel.Size = new System.Drawing.Size(774, 654);
            this.dashboardPanel.TabIndex = 3;
            // 
            // betaBadgeLabel
            // 
            this.betaBadgeLabel.Anchor =
                ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top |
                                                      System.Windows.Forms.AnchorStyles.Right)));
            this.betaBadgeLabel.BackColor = System.Drawing.Color.OrangeRed;
            this.betaBadgeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F,
                System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.betaBadgeLabel.ForeColor = System.Drawing.Color.White;
            this.betaBadgeLabel.Location = new System.Drawing.Point(683, 20);
            this.betaBadgeLabel.Name = "betaBadgeLabel";
            this.betaBadgeLabel.Size = new System.Drawing.Size(71, 23);
            this.betaBadgeLabel.TabIndex = 3;
            this.betaBadgeLabel.Text = "BETA";
            this.betaBadgeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // analyticsPanel
            // 
            this.analyticsPanel.Anchor =
                ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top |
                                                        System.Windows.Forms.AnchorStyles.Bottom)
                                                       | System.Windows.Forms.AnchorStyles.Left)
                                                      | System.Windows.Forms.AnchorStyles.Right)));
            this.analyticsPanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.analyticsPanel.Controls.Add(this.label6);
            this.analyticsPanel.Controls.Add(this.progressBar2);
            this.analyticsPanel.Controls.Add(this.progressBar1);
            this.analyticsPanel.Controls.Add(this.label5);
            this.analyticsPanel.Location = new System.Drawing.Point(23, 196);
            this.analyticsPanel.Name = "analyticsPanel";
            this.analyticsPanel.Size = new System.Drawing.Size(731, 435);
            this.analyticsPanel.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 110);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Conversions:";
            // 
            // progressBar2
            // 
            this.progressBar2.Location = new System.Drawing.Point(32, 126);
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(652, 23);
            this.progressBar2.TabIndex = 2;
            this.progressBar2.Value = 35;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(32, 65);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(652, 23);
            this.progressBar1.TabIndex = 1;
            this.progressBar1.Value = 75;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Visitor Metrics:";
            // 
            // searchPanel
            // 
            this.searchPanel.Anchor =
                ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top |
                                                       System.Windows.Forms.AnchorStyles.Left)
                                                      | System.Windows.Forms.AnchorStyles.Right)));
            this.searchPanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.searchPanel.Controls.Add(this.button1);
            this.searchPanel.Controls.Add(this.searchTextBox);
            this.searchPanel.Controls.Add(this.label2);
            this.searchPanel.Location = new System.Drawing.Point(23, 73);
            this.searchPanel.Name = "searchPanel";
            this.searchPanel.Size = new System.Drawing.Size(731, 103);
            this.searchPanel.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Anchor =
                ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top |
                                                      System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(613, 51);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // searchTextBox
            // 
            this.searchTextBox.Anchor =
                ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top |
                                                       System.Windows.Forms.AnchorStyles.Left)
                                                      | System.Windows.Forms.AnchorStyles.Right)));
            this.searchTextBox.Location = new System.Drawing.Point(29, 51);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(578, 20);
            this.searchTextBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Search Content:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dashboard";
            // 
            // ClientAppForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 700);
            this.Controls.Add(this.dashboardPanel);
            this.Controls.Add(this.sidePanel);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.mainMenuStrip);
            this.MainMenuStrip = this.mainMenuStrip;
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "ClientAppForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Feature Flag Client Application";
            this.mainMenuStrip.ResumeLayout(false);
            this.mainMenuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.sidePanel.ResumeLayout(false);
            this.weekendModePanel.ResumeLayout(false);
            this.weekendModePanel.PerformLayout();
            this.userProfilePanel.ResumeLayout(false);
            this.userProfilePanel.PerformLayout();
            this.dashboardPanel.ResumeLayout(false);
            this.dashboardPanel.PerformLayout();
            this.analyticsPanel.ResumeLayout(false);
            this.analyticsPanel.PerformLayout();
            this.searchPanel.ResumeLayout(false);
            this.searchPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mainMenuStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.Panel sidePanel;
        private System.Windows.Forms.Panel dashboardPanel;
        private System.Windows.Forms.ToolStripMenuItem fileMenuItem;
        private System.Windows.Forms.ToolStripMenuItem darkModeMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitMenuItem;
        private System.Windows.Forms.ToolStripMenuItem featuresMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchMenuItem;
        private System.Windows.Forms.ToolStripMenuItem analyticsMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportMenuItem;
        private System.Windows.Forms.ToolStripMenuItem betaFeaturesMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adminMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userManagementMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel userStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel featuresStatusLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox userComboBox;
        private System.Windows.Forms.Button generateRandomUserButton;
        private System.Windows.Forms.Panel userProfilePanel;
        private System.Windows.Forms.Label userRolesLabel;
        private System.Windows.Forms.Label userSubscriptionLabel;
        private System.Windows.Forms.Label userEmailLabel;
        private System.Windows.Forms.Label userNameLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel searchPanel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel analyticsPanel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ProgressBar progressBar2;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label betaBadgeLabel;
        private System.Windows.Forms.Button adminButton;
        private System.Windows.Forms.Button exportButton;
        private System.Windows.Forms.Panel weekendModePanel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
    }
}