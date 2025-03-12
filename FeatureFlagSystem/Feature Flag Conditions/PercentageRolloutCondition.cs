namespace FeatureFlagSystem
{
    /// <summary>
    /// Condition for percentage-based rollouts
    /// </summary>
    public class PercentageRolloutCondition : IFeatureFlagCondition
    {
        private readonly int _percentage;

        public PercentageRolloutCondition(int percentage)
        {
            _percentage = Math.Clamp(percentage, 0, 100);
        }

        public bool Evaluate(UserContext user)
        {
            if (string.IsNullOrEmpty(user.Id))
                return false;

            return Math.Abs(user.Id.GetHashCode()) % 100 < _percentage;
        }
    }
}