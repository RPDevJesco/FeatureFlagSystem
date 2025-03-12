namespace FeatureFlagSystem
{
    /// <summary>
    /// Interface for feature flag logging
    /// </summary>
    public interface IFeatureFlagLogger
    {
        void LogFlagCheck(string flagName, bool enabled, UserContext user);
        void LogFlagUpdate(string flagName, bool newValue);
    }
}