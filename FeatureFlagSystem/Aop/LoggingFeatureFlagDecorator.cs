namespace FeatureFlagSystem.Aop
{
    /// <summary>
    /// Decorator for adding logging aspect to feature flag service
    /// </summary>
    public class LoggingFeatureFlagDecorator : IFeatureFlagService
    {
        private readonly IFeatureFlagService _innerService;
        private readonly IFeatureFlagLogger _logger;

        public LoggingFeatureFlagDecorator(IFeatureFlagService service, IFeatureFlagLogger logger)
        {
            _innerService = service;
            _logger = logger;
        }

        public bool IsEnabled(string flagName, UserContext user)
        {
            Console.WriteLine($"[AOP] Logging method call: IsEnabled({flagName})");
            bool result = _innerService.IsEnabled(flagName, user);
            return result;
        }

        public void SetEnabled(string flagName, bool value)
        {
            Console.WriteLine($"[AOP] Logging method call: SetEnabled({flagName}, {value})");
            _innerService.SetEnabled(flagName, value);
        }

        public void RegisterFlagRole(string flagName, IFeatureFlagRole role)
        {
            Console.WriteLine($"[AOP] Logging method call: RegisterFlagRole({flagName})");
            _innerService.RegisterFlagRole(flagName, role);
        }
    }
}