namespace FeatureFlagSystem
{
    /// <summary>
    /// Console implementation of feature flag logger
    /// </summary>
    public class ConsoleFeatureFlagLogger : IFeatureFlagLogger
    {
        public void LogFlagCheck(string flagName, bool enabled, UserContext user)
        {
            Console.WriteLine($"[{DateTime.UtcNow}] Flag '{flagName}' checked for user '{user.Id}': {enabled}");
        }

        public void LogFlagUpdate(string flagName, bool newValue)
        {
            Console.WriteLine($"[{DateTime.UtcNow}] Flag '{flagName}' updated to: {newValue}");
        }
    }
}