namespace FeatureFlagSystem.Distributed
{
    /// <summary>
    /// In-memory implementation of distributed cache for testing
    /// </summary>
    public class InMemoryDistributedCache : IDistributedCache
    {
        private readonly Dictionary<string, string> _cache = new Dictionary<string, string>();

        public string GetString(string key)
        {
            return _cache.TryGetValue(key, out var value) ? value : null;
        }

        public void SetString(string key, string value)
        {
            _cache[key] = value;
        }

        public IEnumerable<string> GetKeys(string pattern)
        {
            foreach (var key in _cache.Keys)
            {
                if (key.StartsWith(pattern.Replace("*", "")))
                {
                    yield return key;
                }
            }
        }
    }
}