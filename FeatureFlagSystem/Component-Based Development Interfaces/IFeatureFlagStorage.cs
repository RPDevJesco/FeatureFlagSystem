namespace FeatureFlagSystem
{
    /// <summary>
    /// Interface for feature flag storage providers
    /// </summary>
    public interface IFeatureFlagStorage
    {
        bool GetFlagValue(string flagName);
        void SetFlagValue(string flagName, bool value);
        IEnumerable<FeatureFlagEntry> GetAllFlags();
    }
}