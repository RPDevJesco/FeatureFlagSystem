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
using FeatureFlagSystem.Aop;
using FeatureFlagSystem.Distributed;

namespace GraphicalExample
{
    public partial class MainForm : Form
    {
        private IFeatureFlagStorage _storage;
        private IFeatureFlagLogger _logger;
        private IFeatureFlagNotifier _notifier;
        private BindingList<FeatureFlagViewModel> _flagList;
        private Dictionary<string, UserContext> _userContexts;
        private UserContext _currentUser;

        public MainForm()
        {
            InitializeComponent();
            InitializeFeatureFlagSystem();
            InitializeUserContexts();
            SetupDataBindings();
        }

        private void InitializeFeatureFlagSystem()
        {
            // Initialize storage, logger, and notifier
            _storage = new InMemoryFlagStorage();
            _logger = new CustomLogger(logTextBox);
            _notifier = new InMemoryFeatureFlagNotifier();

            // Initialize feature flag manager
            FeatureFlagManager.Initialize(_storage, _logger, _notifier);

            // Create some initial feature flags
            FeatureFlagManager.SetEnabled("dark_mode", true);
            FeatureFlagManager.SetEnabled("new_dashboard", true);
            FeatureFlagManager.SetEnabled("beta_feature", true);
            FeatureFlagManager.SetEnabled("admin_panel", true);
            FeatureFlagManager.SetEnabled("premium_content", true);
            FeatureFlagManager.SetEnabled("experimental_ui", true);

            // Register roles for feature flags
            FeatureFlagManager.RegisterFlagRole("beta_feature", new ExperimentalFeatureFlag(50));
            FeatureFlagManager.RegisterFlagRole("admin_panel", new PermissionFeatureFlag("Admin"));
            FeatureFlagManager.RegisterFlagRole("premium_content", new PermissionFeatureFlag("Premium"));
            
            // Create complex flag with multiple conditions
            var experimentalUiFlag = new CompositeFeatureFlag(
                new ExperimentalFeatureFlag(30),
                new TimeBasedCondition(DateTime.Now.AddMinutes(-10), DateTime.Now.AddHours(1))
            );
            FeatureFlagManager.RegisterFlagRole("experimental_ui", experimentalUiFlag);
        }

        private void InitializeUserContexts()
        {
            _userContexts = new Dictionary<string, UserContext>
            {
                {
                    "Regular User",
                    new UserContext
                    {
                        Id = "user123",
                        Email = "user@example.com",
                        Roles = new List<string> { "User" }
                    }
                },
                {
                    "Premium User",
                    new UserContext
                    {
                        Id = "premium456",
                        Email = "premium@example.com",
                        Roles = new List<string> { "User", "Premium" }
                    }
                },
                {
                    "Admin User",
                    new UserContext
                    {
                        Id = "admin789",
                        Email = "admin@example.com",
                        Roles = new List<string> { "User", "Admin" }
                    }
                }
            };

            // Set default user
            _currentUser = _userContexts["Regular User"];
        }

        private void SetupDataBindings()
        {
            // Initialize flag list
            _flagList = new BindingList<FeatureFlagViewModel>();
            flagsDataGridView.DataSource = _flagList;

            // Set up user combobox
            userComboBox.DataSource = _userContexts.Keys.ToList();
            userComboBox.SelectedIndex = 0;

            // Refresh flag list
            RefreshFlagList();
        }

        private void RefreshFlagList()
        {
            _flagList.Clear();

            // Add all flags to the list
            var flags = new[]
            {
                "dark_mode",
                "new_dashboard",
                "beta_feature",
                "admin_panel",
                "premium_content",
                "experimental_ui"
            };

            foreach (var flagName in flags)
            {
                bool isEnabled = FeatureFlagManager.IsEnabled(flagName, _currentUser);
                _flagList.Add(new FeatureFlagViewModel { Name = flagName, IsEnabled = isEnabled });
            }
        }

        private void userComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedUserType = userComboBox.SelectedItem.ToString();
            _currentUser = _userContexts[selectedUserType];
            
            // Update user info labels
            userIdLabel.Text = $"ID: {_currentUser.Id}";
            userEmailLabel.Text = $"Email: {_currentUser.Email}";
            userRolesLabel.Text = $"Roles: {string.Join(", ", _currentUser.Roles)}";

            // Refresh flag list for the new user
            RefreshFlagList();
        }

        private void toggleFlagButton_Click(object sender, EventArgs e)
        {
            if (flagsDataGridView.SelectedRows.Count == 0)
                return;

            var selectedFlag = flagsDataGridView.SelectedRows[0].DataBoundItem as FeatureFlagViewModel;
            if (selectedFlag != null)
            {
                // Toggle the flag
                FeatureFlagManager.SetEnabled(selectedFlag.Name, !selectedFlag.IsEnabled);
                
                // Refresh the flag list
                RefreshFlagList();
            }
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            RefreshFlagList();
        }

        private void clearLogButton_Click(object sender, EventArgs e)
        {
            logTextBox.Clear();
        }

        private void randomUserButton_Click(object sender, EventArgs e)
        {
            // Create a random user to test percentage-based rollouts
            Random random = new Random();
            int userId = random.Next(1000, 10000);
            
            var randomUser = new UserContext
            {
                Id = $"random{userId}",
                Email = $"random{userId}@example.com",
                Roles = new List<string> { "User" }
            };

            // Add to user contexts
            string userKey = $"Random User {userId}";
            _userContexts[userKey] = randomUser;
            
            // Update combo box
            userComboBox.DataSource = _userContexts.Keys.ToList();
            userComboBox.SelectedItem = userKey;
        }
    }

    public class FeatureFlagViewModel
    {
        public string Name { get; set; }
        public bool IsEnabled { get; set; }
    }

    public class CustomLogger : IFeatureFlagLogger
    {
        private readonly TextBox _logTextBox;

        public CustomLogger(TextBox logTextBox)
        {
            _logTextBox = logTextBox;
        }

        public void LogFlagCheck(string flagName, bool enabled, UserContext user)
        {
            AppendLog($"[{DateTime.Now:HH:mm:ss}] Flag '{flagName}' checked for user '{user.Id}': {enabled}");
        }

        public void LogFlagUpdate(string flagName, bool newValue)
        {
            AppendLog($"[{DateTime.Now:HH:mm:ss}] Flag '{flagName}' updated to: {newValue}");
        }

        private void AppendLog(string message)
        {
            if (_logTextBox.InvokeRequired)
            {
                _logTextBox.Invoke(new Action(() => AppendLog(message)));
                return;
            }

            _logTextBox.AppendText(message + Environment.NewLine);
            _logTextBox.SelectionStart = _logTextBox.Text.Length;
            _logTextBox.ScrollToCaret();
        }
    }
}

namespace FeatureFlagSystem
{
    public class TimeBasedCondition : IFeatureFlagRole
    {
        private readonly DateTime _startTime;
        private readonly DateTime? _endTime;
        
        public TimeBasedCondition(DateTime startTime, DateTime? endTime = null)
        {
            _startTime = startTime;
            _endTime = endTime;
        }
        
        public bool Evaluate(UserContext user)
        {
            DateTime now = DateTime.Now;
            return now >= _startTime && (!_endTime.HasValue || now <= _endTime.Value);
        }
    }
}