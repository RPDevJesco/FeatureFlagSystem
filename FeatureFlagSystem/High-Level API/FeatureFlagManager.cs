namespace FeatureFlagSystem
{
    /// <summary>
    /// Static manager class providing a simple API for feature flags
    /// </summary>
    public static class FeatureFlagManager
    {
        private static IFeatureFlagService _service;
        private static IFeatureFlagNotifier _notifier;

        public static void Initialize(IFeatureFlagStorage storage, IFeatureFlagLogger logger,
            IFeatureFlagNotifier notifier = null)
        {
            _service = new FeatureFlagServiceImpl(storage, logger);
            _notifier = notifier;

            if (_notifier != null)
            {
                _notifier.SubscribeToChanges((flagName, value) => { _service.SetEnabled(flagName, value); });
            }
        }

        public static bool IsEnabled(string flagName, UserContext user)
        {
            if (_service == null)
                throw new InvalidOperationException("FeatureFlagManager has not been initialized.");

            return _service.IsEnabled(flagName, user);
        }

        public static void SetEnabled(string flagName, bool value)
        {
            if (_service == null)
                throw new InvalidOperationException("FeatureFlagManager has not been initialized.");

            _service.SetEnabled(flagName, value);

            if (_notifier != null)
            {
                _notifier.NotifyFlagChange(flagName, value);
            }
        }

        public static void RegisterFlagRole(string flagName, IFeatureFlagRole role)
        {
            if (_service == null)
                throw new InvalidOperationException("FeatureFlagManager has not been initialized.");

            _service.RegisterFlagRole(flagName, role);
        }
    }
}