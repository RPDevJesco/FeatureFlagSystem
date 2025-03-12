namespace FeatureFlagSystem
{
    /// <summary>
    /// A composite feature flag that combines multiple roles
    /// </summary>
    public class CompositeFeatureFlag : IFeatureFlagRole
    {
        private readonly List<IFeatureFlagRole> _roles;

        public CompositeFeatureFlag(params IFeatureFlagRole[] roles)
        {
            _roles = roles.ToList();
        }

        public bool Evaluate(UserContext user)
        {
            return _roles.All(role => role.Evaluate(user));
        }
    }
}