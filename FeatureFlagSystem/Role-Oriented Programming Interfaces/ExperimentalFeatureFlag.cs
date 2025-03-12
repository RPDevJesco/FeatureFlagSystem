namespace FeatureFlagSystem
{
    /// <summary>
    /// An experimental feature flag for gradual rollouts
    /// </summary>
    public class ExperimentalFeatureFlag : IFeatureFlagRole
    {
        private readonly int _rolloutPercentage;

        public ExperimentalFeatureFlag(int rolloutPercentage)
        {
            _rolloutPercentage = Math.Clamp(rolloutPercentage, 0, 100);
        }

        public bool Evaluate(UserContext user)
        {
            if (string.IsNullOrEmpty(user.Id))
                return false;

            // Simple hash-based percentage rollout
            return Math.Abs(user.Id.GetHashCode()) % 100 < _rolloutPercentage;
        }
    }
}