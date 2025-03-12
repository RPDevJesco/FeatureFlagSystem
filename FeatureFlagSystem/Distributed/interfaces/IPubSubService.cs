namespace FeatureFlagSystem.Distributed
{
    /// <summary>
    /// Interface for publish/subscribe operations
    /// </summary>
    public interface IPubSubService
    {
        void Publish(string channel, string message);
        void Subscribe(string channel, Action<string> handler);
    }
}