namespace FeatureFlagSystem
{
    /// <summary>
    /// Fast feature flag store using a hash-based lookup
    /// </summary>
    public class FastFeatureFlagStore : IFeatureFlagStorage
    {
        private Dictionary<string, FeatureFlagEntry> _flagMap;

        public FastFeatureFlagStore(IEnumerable<FeatureFlagEntry> initialFlags = null)
        {
            _flagMap = initialFlags?.ToDictionary(flag => flag.Name) ?? new Dictionary<string, FeatureFlagEntry>();
        }

        public bool GetFlagValue(string flagName)
        {
            return _flagMap.TryGetValue(flagName, out var flag) && flag.Value;
        }

        public void SetFlagValue(string flagName, bool value)
        {
            if (_flagMap.TryGetValue(flagName, out var flag))
            {
                flag.Value = value;
                flag.ModifiedAt = DateTime.UtcNow;
            }
            else
            {
                _flagMap[flagName] = new FeatureFlagEntry
                {
                    Name = flagName,
                    Value = value,
                    CreatedAt = DateTime.UtcNow,
                    ModifiedAt = DateTime.UtcNow
                };
            }
        }

        public IEnumerable<FeatureFlagEntry> GetAllFlags()
        {
            return _flagMap.Values;
        }
    }
}