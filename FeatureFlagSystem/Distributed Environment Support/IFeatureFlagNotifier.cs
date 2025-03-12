namespace FeatureFlagSystem
{
    /// <summary>
    /// Interface for notifying about feature flag changes
    /// </summary>
    public interface IFeatureFlagNotifier
    {
        void NotifyFlagChange(string flagName, bool newValue);
        void SubscribeToChanges(Action<string, bool> handler);
    }
}