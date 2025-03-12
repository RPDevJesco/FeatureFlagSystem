namespace FeatureFlagSystem
{
    /// <summary>
    /// Represents contextual information about a user for feature flag evaluation
    /// </summary>
    public class UserContext
    {
        public string Id { get; set; }
        public string Email { get; set; }
        public List<string> Roles { get; set; } = new List<string>();
        public Dictionary<string, string> Attributes { get; set; } = new Dictionary<string, string>();

        public bool HasRole(string role) => Roles.Contains(role);

        public bool HasAccess(string permission)
        {
            // This could be expanded with more sophisticated permission logic
            return Roles.Any(r => r == "Admin") || Attributes.ContainsKey($"Permission:{permission}");
        }
    }
}