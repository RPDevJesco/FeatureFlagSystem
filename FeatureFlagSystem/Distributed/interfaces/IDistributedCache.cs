namespace FeatureFlagSystem.Distributed
{
    /// <summary>
    /// Interface for distributed cache operations
    /// </summary>
    public interface IDistributedCache
    {
        string GetString(string key);
        void SetString(string key, string value);
        IEnumerable<string> GetKeys(string pattern);
    }
}