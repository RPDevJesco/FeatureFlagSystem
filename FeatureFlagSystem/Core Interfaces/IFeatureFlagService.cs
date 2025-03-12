namespace FeatureFlagSystem
{
    /// <summary>
    /// Interface for feature flag service operations
    /// </summary>
    public interface IFeatureFlagService
    {
        bool IsEnabled(string flagName, UserContext user);
        void SetEnabled(string flagName, bool value);
        void RegisterFlagRole(string flagName, IFeatureFlagRole role);
    }
}