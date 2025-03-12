using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FeatureFlagSystem;
using FeatureFlagSystem.Distributed;

namespace FeatureFlagClientApp
{
    public partial class ClientAppForm : Form
    {
        private UserContext _currentUser;
        private Dictionary<string, UserContext> _userProfiles;
        private IFeatureFlagStorage _storage;
        private IFeatureFlagLogger _logger;
        private IFeatureFlagNotifier _notifier;

        public ClientAppForm()
        {
            InitializeComponent();
            
            // Initialize the feature flag system
            InitializeFeatureFlags();
            
            // Create user profiles
            CreateUserProfiles();
            
            // Set up the user selection dropdown
            SetupUserDropdown();
            
            // Load the dashboard with the default user
            SwitchUser(_currentUser);
        }

        private void InitializeFeatureFlags()
        {
            // Create storage, logger, and notifier
            _storage = new InMemoryFlagStorage();
            _logger = new ConsoleFeatureFlagLogger();
            _notifier = new InMemoryFeatureFlagNotifier();
            
            // Initialize the feature flag manager
            FeatureFlagManager.Initialize(_storage, _logger, _notifier);
            
            // Set up feature flags
            SetupFeatureFlags();
        }

        private void SetupFeatureFlags()
        {
            // Basic features
            FeatureFlagManager.SetEnabled("dark_mode", true);
            FeatureFlagManager.RegisterFlagRole("dark_mode", new PermissionFeatureFlag("Premium"));
            FeatureFlagManager.SetEnabled("search_feature", true);
            
            // Premium features
            FeatureFlagManager.SetEnabled("advanced_analytics", true);
            FeatureFlagManager.SetEnabled("export_data", true);
            FeatureFlagManager.RegisterFlagRole("advanced_analytics", new PermissionFeatureFlag("Premium"));
            FeatureFlagManager.RegisterFlagRole("export_data", new PermissionFeatureFlag("Premium"));
            
            // Beta features with percentage rollout
            FeatureFlagManager.SetEnabled("beta_dashboard", true);
            FeatureFlagManager.RegisterFlagRole("beta_dashboard", new ExperimentalFeatureFlag(50));
            
            // Admin-only features
            FeatureFlagManager.SetEnabled("admin_panel", true);
            FeatureFlagManager.SetEnabled("user_management", true);
            FeatureFlagManager.RegisterFlagRole("admin_panel", new PermissionFeatureFlag("Admin"));
            FeatureFlagManager.RegisterFlagRole("user_management", new PermissionFeatureFlag("Admin"));
            
            // Time-based feature
            FeatureFlagManager.SetEnabled("weekend_mode", true);
            FeatureFlagManager.RegisterFlagRole("weekend_mode", new WeekendFeatureFlag());
        }

        private void CreateUserProfiles()
        {
            _userProfiles = new Dictionary<string, UserContext>
            {
                {
                    "Regular User",
                    new UserContext
                    {
                        Id = "user123",
                        Email = "user@example.com",
                        Roles = new List<string> { "User" },
                        Attributes = new Dictionary<string, string>
                        {
                            { "Name", "John Doe" },
                            { "Subscription", "Free" }
                        }
                    }
                },
                {
                    "Premium User",
                    new UserContext
                    {
                        Id = "premium456",
                        Email = "premium@example.com",
                        Roles = new List<string> { "User", "Premium" },
                        Attributes = new Dictionary<string, string>
                        {
                            { "Name", "Jane Smith" },
                            { "Subscription", "Premium" }
                        }
                    }
                },
                {
                    "Admin User",
                    new UserContext
                    {
                        Id = "admin789",
                        Email = "admin@example.com",
                        Roles = new List<string> { "User", "Admin", "Premium" },
                        Attributes = new Dictionary<string, string>
                        {
                            { "Name", "Admin User" },
                            { "Subscription", "Enterprise" }
                        }
                    }
                },
                {
                    "Beta Tester",
                    new UserContext
                    {
                        Id = "beta101",
                        Email = "beta@example.com",
                        Roles = new List<string> { "User", "BetaTester" },
                        Attributes = new Dictionary<string, string>
                        {
                            { "Name", "Beta Tester" },
                            { "Subscription", "Free" }
                        }
                    }
                }
            };

            // Set default user
            _currentUser = _userProfiles["Regular User"];
        }

        private void SetupUserDropdown()
        {
            // Populate the user dropdown
            userComboBox.Items.Clear();
            userComboBox.Items.AddRange(_userProfiles.Keys.ToArray());
            userComboBox.SelectedItem = "Regular User";
        }

        private void SwitchUser(UserContext user)
        {
            _currentUser = user;
            
            // Update the user info display
            userNameLabel.Text = user.Attributes["Name"];
            userEmailLabel.Text = user.Email;
            userSubscriptionLabel.Text = user.Attributes["Subscription"];
            userRolesLabel.Text = string.Join(", ", user.Roles);
            
            // Apply feature flags
            ApplyFeatureFlags();
        }

        private void ApplyFeatureFlags()
        {
            // Dark mode
            bool darkModeEnabled = FeatureFlagManager.IsEnabled("dark_mode", _currentUser);
            ApplyDarkMode(darkModeEnabled);
            darkModeMenuItem.Visible = darkModeEnabled;
            
            // Search feature
            bool searchEnabled = FeatureFlagManager.IsEnabled("search_feature", _currentUser);
            searchPanel.Visible = searchEnabled;
            searchMenuItem.Visible = searchEnabled;
            
            // Advanced analytics
            bool analyticsEnabled = FeatureFlagManager.IsEnabled("advanced_analytics", _currentUser);
            analyticsPanel.Visible = analyticsEnabled;
            analyticsMenuItem.Visible = analyticsEnabled;
            
            // Export data
            bool exportEnabled = FeatureFlagManager.IsEnabled("export_data", _currentUser);
            exportMenuItem.Visible = exportEnabled;
            exportButton.Visible = exportEnabled;
            
            // Beta dashboard
            bool betaDashboardEnabled = FeatureFlagManager.IsEnabled("beta_dashboard", _currentUser);
            betaBadgeLabel.Visible = betaDashboardEnabled;
            betaFeaturesMenuItem.Visible = betaDashboardEnabled;
            
            // Admin panel
            bool adminPanelEnabled = FeatureFlagManager.IsEnabled("admin_panel", _currentUser);
            adminButton.Visible = adminPanelEnabled;
            adminMenuItem.Visible = adminPanelEnabled;
            
            // User management
            bool userManagementEnabled = FeatureFlagManager.IsEnabled("user_management", _currentUser);
            userManagementMenuItem.Visible = userManagementEnabled;
            
            // Weekend mode
            bool weekendModeEnabled = FeatureFlagManager.IsEnabled("weekend_mode", _currentUser);
            weekendModePanel.Visible = weekendModeEnabled;
            
            // Update status bar
            UpdateStatusBar();
        }

        private void ApplyDarkMode(bool darkMode)
        {
            if (darkMode)
            {
                // Apply dark theme
                this.BackColor = Color.FromArgb(30, 30, 30);
                this.ForeColor = Color.White;
                mainMenuStrip.BackColor = Color.FromArgb(45, 45, 48);
                mainMenuStrip.ForeColor = Color.White;
                statusStrip.BackColor = Color.FromArgb(45, 45, 48);
                statusStrip.ForeColor = Color.White;
                dashboardPanel.BackColor = Color.FromArgb(37, 37, 38);
                sidePanel.BackColor = Color.FromArgb(45, 45, 48);
                userProfilePanel.BackColor = Color.FromArgb(62, 62, 64);
                
                // Update controls
                foreach (Control control in GetAllControls(this))
                {
                    if (control is Panel panel)
                    {
                        panel.BackColor = Color.FromArgb(37, 37, 38);
                        panel.ForeColor = Color.White;
                    }
                    else if (control is Button button)
                    {
                        button.BackColor = Color.FromArgb(62, 62, 64);
                        button.ForeColor = Color.White;
                        button.FlatStyle = FlatStyle.Flat;
                        button.FlatAppearance.BorderColor = Color.DimGray;
                    }
                    else if (control is TextBox textBox)
                    {
                        textBox.BackColor = Color.FromArgb(30, 30, 30);
                        textBox.ForeColor = Color.White;
                    }
                    else if (control is Label label && label != betaBadgeLabel)
                    {
                        label.ForeColor = Color.White;
                    }
                }
                
                // Dark mode menu item state
                darkModeMenuItem.Checked = true;
            }
            else
            {
                // Apply light theme
                this.BackColor = SystemColors.Control;
                this.ForeColor = SystemColors.ControlText;
                mainMenuStrip.BackColor = SystemColors.Control;
                mainMenuStrip.ForeColor = SystemColors.ControlText;
                statusStrip.BackColor = SystemColors.Control;
                statusStrip.ForeColor = SystemColors.ControlText;
                dashboardPanel.BackColor = SystemColors.ControlLightLight;
                sidePanel.BackColor = SystemColors.ControlLight;
                userProfilePanel.BackColor = SystemColors.ControlLight;
                
                // Reset controls
                foreach (Control control in GetAllControls(this))
                {
                    if (control is Panel panel)
                    {
                        panel.BackColor = SystemColors.Control;
                        panel.ForeColor = SystemColors.ControlText;
                    }
                    else if (control is Button button)
                    {
                        button.UseVisualStyleBackColor = true;
                        button.FlatStyle = FlatStyle.Standard;
                    }
                    else if (control is TextBox textBox)
                    {
                        textBox.BackColor = SystemColors.Window;
                        textBox.ForeColor = SystemColors.WindowText;
                    }
                    else if (control is Label label && label != betaBadgeLabel)
                    {
                        label.ForeColor = SystemColors.ControlText;
                    }
                }
                
                // Dark mode menu item state
                darkModeMenuItem.Checked = false;
            }
        }

        private IEnumerable<Control> GetAllControls(Control container)
        {
            List<Control> controlList = new List<Control>();
            foreach (Control c in container.Controls)
            {
                controlList.Add(c);
                controlList.AddRange(GetAllControls(c));
            }
            return controlList;
        }

        private void UpdateStatusBar()
        {
            // Count enabled features
            int enabledFeatures = 0;
            
            if (FeatureFlagManager.IsEnabled("dark_mode", _currentUser)) enabledFeatures++;
            if (FeatureFlagManager.IsEnabled("search_feature", _currentUser)) enabledFeatures++;
            if (FeatureFlagManager.IsEnabled("advanced_analytics", _currentUser)) enabledFeatures++;
            if (FeatureFlagManager.IsEnabled("export_data", _currentUser)) enabledFeatures++;
            if (FeatureFlagManager.IsEnabled("beta_dashboard", _currentUser)) enabledFeatures++;
            if (FeatureFlagManager.IsEnabled("admin_panel", _currentUser)) enabledFeatures++;
            if (FeatureFlagManager.IsEnabled("user_management", _currentUser)) enabledFeatures++;
            if (FeatureFlagManager.IsEnabled("weekend_mode", _currentUser)) enabledFeatures++;
            
            // Update status
            featuresStatusLabel.Text = $"Enabled Features: {enabledFeatures}";
            userStatusLabel.Text = $"User: {_currentUser.Attributes["Name"]}";
        }

        private void userComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedUserType = userComboBox.SelectedItem.ToString();
            SwitchUser(_userProfiles[selectedUserType]);
        }

        private void darkModeMenuItem_Click(object sender, EventArgs e)
        {
            bool isDarkMode = darkModeMenuItem.Checked;
            ApplyDarkMode(!isDarkMode);
        }

        private void exitMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void adminButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Admin Panel - This feature is only available to administrators.", "Admin Feature", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void exportButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Export Data - This feature is only available to premium users.", "Premium Feature", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void generateRandomUserButton_Click(object sender, EventArgs e)
        {
            // Create a random user for testing percentage rollouts
            Random random = new Random();
            int userId = random.Next(1000, 10000);
            
            var randomUser = new UserContext
            {
                Id = $"random{userId}",
                Email = $"random{userId}@example.com",
                Roles = new List<string> { "User" },
                Attributes = new Dictionary<string, string>
                {
                    { "Name", $"Random User {userId}" },
                    { "Subscription", "Free" }
                }
            };
            
            // Add the random user to profiles
            string userKey = $"Random User {userId}";
            _userProfiles[userKey] = randomUser;
            
            // Update the combobox
            userComboBox.Items.Add(userKey);
            userComboBox.SelectedItem = userKey;
        }

        private void betaFeaturesMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You have access to the Beta Dashboard! This feature is randomly assigned to a percentage of users.", "Beta Feature", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void adminMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Admin Panel - This feature is only available to administrators.", "Admin Feature", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void userManagementMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("User Management - This feature is only available to administrators.", "Admin Feature", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void analyticsMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Advanced Analytics - This feature is only available to premium users.", "Premium Feature", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void exportMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Export Data - This feature is only available to premium users.", "Premium Feature", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void searchMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Search feature is available to all users.", "Feature", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }

    /// <summary>
    /// Feature flag that is only active on weekends
    /// </summary>
    public class WeekendFeatureFlag : IFeatureFlagRole
    {
        public bool Evaluate(UserContext user)
        {
            // Check if today is Saturday or Sunday
            DayOfWeek today = DateTime.Now.DayOfWeek;
            return today == DayOfWeek.Saturday || today == DayOfWeek.Sunday;
        }
    }
}