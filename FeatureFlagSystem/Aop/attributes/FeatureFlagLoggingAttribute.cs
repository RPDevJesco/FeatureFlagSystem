namespace FeatureFlagSystem.Aop
{
    /// <summary>
    /// Attribute for logging feature flag checks
    /// </summary>
    [AttributeUsage(AttributeTargets.Method)]
    public class FeatureFlagLoggingAttribute : Attribute
    {
    }
}