namespace FeatureFlagSystem
{
    /// <summary>
    /// Implementation of feature flag service
    /// </summary>
    public class FeatureFlagServiceImpl : IFeatureFlagService
    {
        private readonly IFeatureFlagStorage _storage;
        private readonly IFeatureFlagLogger _logger;
        private readonly Dictionary<string, IFeatureFlagRole> _flagRoles = new Dictionary<string, IFeatureFlagRole>();

        public FeatureFlagServiceImpl(IFeatureFlagStorage storage, IFeatureFlagLogger logger)
        {
            _storage = storage;
            _logger = logger;
        }

        public void RegisterFlagRole(string flagName, IFeatureFlagRole role)
        {
            _flagRoles[flagName] = role;
        }

        public bool IsEnabled(string flagName, UserContext user)
        {
            bool baseEnabled = _storage.GetFlagValue(flagName);
            
            // If the flag has a role, evaluate it; otherwise just use the storage value
            bool finalEnabled = baseEnabled && (!_flagRoles.TryGetValue(flagName, out var role) || role.Evaluate(user));
            
            _logger.LogFlagCheck(flagName, finalEnabled, user);
            return finalEnabled;
        }

        public void SetEnabled(string flagName, bool value)
        {
            _storage.SetFlagValue(flagName, value);
            _logger.LogFlagUpdate(flagName, value);
        }
    }
}