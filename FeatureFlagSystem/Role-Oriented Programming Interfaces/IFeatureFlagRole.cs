namespace FeatureFlagSystem
{
    /// <summary>
    /// Interface defining the role of a feature flag
    /// </summary>
    public interface IFeatureFlagRole
    {
        bool Evaluate(UserContext user);
    }
}