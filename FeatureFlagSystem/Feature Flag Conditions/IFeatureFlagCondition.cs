namespace FeatureFlagSystem
{
    /// <summary>
    /// Interface for feature flag conditions
    /// </summary>
    public interface IFeatureFlagCondition
    {
        bool Evaluate(UserContext user);
    }
}