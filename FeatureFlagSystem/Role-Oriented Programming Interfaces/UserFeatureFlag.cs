namespace FeatureFlagSystem
{
    /// <summary>
    /// A user-specific feature flag
    /// </summary>
    public class UserFeatureFlag : IFeatureFlagRole
    {
        private readonly string _permissionName;

        public UserFeatureFlag(string permissionName)
        {
            _permissionName = permissionName;
        }

        public bool Evaluate(UserContext user) => user.HasAccess(_permissionName);
    }
}