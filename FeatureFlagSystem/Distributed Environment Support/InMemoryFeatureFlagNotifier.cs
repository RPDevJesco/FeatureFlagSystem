namespace FeatureFlagSystem
{
    /// <summary>
    /// In-memory implementation of feature flag notifier
    /// </summary>
    public class InMemoryFeatureFlagNotifier : IFeatureFlagNotifier
    {
        private readonly List<Action<string, bool>> _subscribers = new List<Action<string, bool>>();

        public void NotifyFlagChange(string flagName, bool newValue)
        {
            foreach (var subscriber in _subscribers)
            {
                subscriber(flagName, newValue);
            }
        }

        public void SubscribeToChanges(Action<string, bool> handler)
        {
            _subscribers.Add(handler);
        }
    }
}