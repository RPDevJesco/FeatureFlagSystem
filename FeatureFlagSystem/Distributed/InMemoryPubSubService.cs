namespace FeatureFlagSystem.Distributed
{
    /// <summary>
    /// In-memory implementation of pub/sub service for testing
    /// </summary>
    public class InMemoryPubSubService : IPubSubService
    {
        private readonly Dictionary<string, List<Action<string>>> _subscribers = 
            new Dictionary<string, List<Action<string>>>();

        public void Publish(string channel, string message)
        {
            if (_subscribers.TryGetValue(channel, out var handlers))
            {
                foreach (var handler in handlers)
                {
                    handler(message);
                }
            }
        }

        public void Subscribe(string channel, Action<string> handler)
        {
            if (!_subscribers.TryGetValue(channel, out var handlers))
            {
                handlers = new List<Action<string>>();
                _subscribers[channel] = handlers;
            }

            handlers.Add(handler);
        }
    }
}