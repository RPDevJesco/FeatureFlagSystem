namespace FeatureFlagSystem
{
    /// <summary>
    /// Simple in-memory implementation of feature flag storage
    /// </summary>
    public class InMemoryFlagStorage : IFeatureFlagStorage
    {
        private readonly Dictionary<string, FeatureFlagEntry> _flags = new Dictionary<string, FeatureFlagEntry>();

        public bool GetFlagValue(string flagName)
        {
            return _flags.TryGetValue(flagName, out var flag) && flag.Value;
        }

        public void SetFlagValue(string flagName, bool value)
        {
            if (_flags.TryGetValue(flagName, out var flag))
            {
                flag.Value = value;
                flag.ModifiedAt = DateTime.UtcNow;
            }
            else
            {
                _flags[flagName] = new FeatureFlagEntry
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
            return _flags.Values;
        }
    }
}