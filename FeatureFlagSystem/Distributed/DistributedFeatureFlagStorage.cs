using System.Text.Json;

namespace FeatureFlagSystem.Distributed
{
    /// <summary>
    /// Distributed implementation of feature flag storage
    /// </summary>
    public class DistributedFeatureFlagStorage : IFeatureFlagStorage
    {
        private readonly IDistributedCache _cache;
        private readonly string _keyPrefix;
        
        public DistributedFeatureFlagStorage(IDistributedCache cache, string keyPrefix = "feature_flag:")
        {
            _cache = cache;
            _keyPrefix = keyPrefix;
        }
        
        public bool GetFlagValue(string flagName)
        {
            string key = $"{_keyPrefix}{flagName}";
            string json = _cache.GetString(key);
            
            if (string.IsNullOrEmpty(json))
                return false;
                
            try
            {
                var flag = JsonSerializer.Deserialize<FeatureFlagEntry>(json);
                return flag?.Value ?? false;
            }
            catch
            {
                return false;
            }
        }
        
        public void SetFlagValue(string flagName, bool value)
        {
            string key = $"{_keyPrefix}{flagName}";
            string json = _cache.GetString(key);
            FeatureFlagEntry flag;
            
            if (string.IsNullOrEmpty(json))
            {
                flag = new FeatureFlagEntry
                {
                    Name = flagName,
                    Value = value,
                    CreatedAt = DateTime.UtcNow,
                    ModifiedAt = DateTime.UtcNow
                };
            }
            else
            {
                try
                {
                    flag = JsonSerializer.Deserialize<FeatureFlagEntry>(json);
                    flag.Value = value;
                    flag.ModifiedAt = DateTime.UtcNow;
                }
                catch
                {
                    flag = new FeatureFlagEntry
                    {
                        Name = flagName,
                        Value = value,
                        CreatedAt = DateTime.UtcNow,
                        ModifiedAt = DateTime.UtcNow
                    };
                }
            }
            
            _cache.SetString(key, JsonSerializer.Serialize(flag));
        }
        
        public IEnumerable<FeatureFlagEntry> GetAllFlags()
        {
            var flags = new List<FeatureFlagEntry>();
            
            foreach (var key in _cache.GetKeys($"{_keyPrefix}*"))
            {
                string json = _cache.GetString(key);
                if (!string.IsNullOrEmpty(json))
                {
                    try
                    {
                        var flag = JsonSerializer.Deserialize<FeatureFlagEntry>(json);
                        if (flag != null)
                            flags.Add(flag);
                    }
                    catch
                    {
                        // Skip invalid entries
                    }
                }
            }
            
            return flags;
        }
    }
}