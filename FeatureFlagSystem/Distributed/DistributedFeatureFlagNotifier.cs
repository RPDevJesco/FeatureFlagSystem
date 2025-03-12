using System.Text.Json;

namespace FeatureFlagSystem.Distributed
{
    /// <summary>
    /// Distributed implementation of feature flag notifier using pub/sub
    /// </summary>
    public class DistributedFeatureFlagNotifier : IFeatureFlagNotifier
    {
        private readonly IPubSubService _pubSub;
        private readonly string _channel;
        private readonly List<Action<string, bool>> _subscribers = new List<Action<string, bool>>();
        
        public DistributedFeatureFlagNotifier(IPubSubService pubSub, string channel = "feature_flag_changes")
        {
            _pubSub = pubSub;
            _channel = channel;
            
            // Subscribe to pub/sub channel for feature flag changes
            _pubSub.Subscribe(_channel, message =>
            {
                try
                {
                    var changeMessage = JsonSerializer.Deserialize<FlagChangeMessage>(message);
                    if (changeMessage != null)
                    {
                        foreach (var handler in _subscribers)
                        {
                            handler(changeMessage.FlagName, changeMessage.NewValue);
                        }
                    }
                }
                catch
                {
                    // Ignore invalid messages
                }
            });
        }
        
        public void NotifyFlagChange(string flagName, bool newValue)
        {
            var message = new FlagChangeMessage
            {
                FlagName = flagName,
                NewValue = newValue,
                Timestamp = DateTime.UtcNow
            };
            
            _pubSub.Publish(_channel, JsonSerializer.Serialize(message));
        }
        
        public void SubscribeToChanges(Action<string, bool> handler)
        {
            _subscribers.Add(handler);
        }
        
        private class FlagChangeMessage
        {
            public string FlagName { get; set; }
            public bool NewValue { get; set; }
            public DateTime Timestamp { get; set; }
        }
    }
}