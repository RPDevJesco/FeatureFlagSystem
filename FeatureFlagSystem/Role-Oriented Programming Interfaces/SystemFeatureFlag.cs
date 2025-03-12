namespace FeatureFlagSystem
{
    /// <summary>
    /// A system-wide feature flag that applies to all users
    /// </summary>
    public class SystemFeatureFlag : IFeatureFlagRole
    {
        private readonly bool _isEnabled;

        public SystemFeatureFlag(bool isEnabled)
        {
            _isEnabled = isEnabled;
        }

        public bool Evaluate(UserContext user) => _isEnabled;
    }
}