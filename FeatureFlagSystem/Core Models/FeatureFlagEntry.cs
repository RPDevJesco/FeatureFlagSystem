namespace FeatureFlagSystem
{
    /// <summary>
    /// Represents a feature flag entry with metadata
    /// </summary>
    public class FeatureFlagEntry
    {
        public string Name { get; set; }
        public bool Value { get; set; }
        public string Description { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime ModifiedAt { get; set; }
    }
}