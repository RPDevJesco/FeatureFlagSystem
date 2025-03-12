namespace FeatureFlagSystem.Aop
{
    /// <summary>
    /// Attribute for tracking feature flag performance
    /// </summary>
    [AttributeUsage(AttributeTargets.Method)]
    public class FeatureFlagPerformanceAttribute : Attribute
    {
    }
}