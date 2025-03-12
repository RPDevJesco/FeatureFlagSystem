namespace FeatureFlagSystem.Aop
{
    /// <summary>
    /// Attribute for access control on feature flags
    /// </summary>
    [AttributeUsage(AttributeTargets.Method)]
    public class FeatureFlagSecurityAttribute : Attribute
    {
        public string RequiredRole { get; }

        public FeatureFlagSecurityAttribute(string requiredRole)
        {
            RequiredRole = requiredRole;
        }
    }
}