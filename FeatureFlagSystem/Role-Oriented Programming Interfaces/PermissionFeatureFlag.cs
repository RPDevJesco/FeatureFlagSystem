namespace FeatureFlagSystem
{
    /// <summary>
    /// A permission-based feature flag for access control
    /// </summary>
    public class PermissionFeatureFlag : IFeatureFlagRole
    {
        private readonly string _requiredRole;

        public PermissionFeatureFlag(string requiredRole)
        {
            _requiredRole = requiredRole;
        }

        public bool Evaluate(UserContext user) => user.HasRole(_requiredRole);
    }
}