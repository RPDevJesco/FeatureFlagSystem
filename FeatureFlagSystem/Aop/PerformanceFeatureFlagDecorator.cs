using System.Diagnostics;

namespace FeatureFlagSystem.Aop
{
    /// <summary>
    /// Decorator for adding performance monitoring aspect to feature flag service
    /// </summary>
    public class PerformanceFeatureFlagDecorator : IFeatureFlagService
    {
        private readonly IFeatureFlagService _innerService;

        public PerformanceFeatureFlagDecorator(IFeatureFlagService service)
        {
            _innerService = service;
        }

        public bool IsEnabled(string flagName, UserContext user)
        {
            var stopwatch = Stopwatch.StartNew();
            bool result = _innerService.IsEnabled(flagName, user);
            stopwatch.Stop();

            Console.WriteLine($"[AOP] Performance of IsEnabled({flagName}): {stopwatch.ElapsedMilliseconds}ms");
            return result;
        }

        public void SetEnabled(string flagName, bool value)
        {
            var stopwatch = Stopwatch.StartNew();
            _innerService.SetEnabled(flagName, value);
            stopwatch.Stop();

            Console.WriteLine($"[AOP] Performance of SetEnabled({flagName}): {stopwatch.ElapsedMilliseconds}ms");
        }

        public void RegisterFlagRole(string flagName, IFeatureFlagRole role)
        {
            var stopwatch = Stopwatch.StartNew();
            _innerService.RegisterFlagRole(flagName, role);
            stopwatch.Stop();

            Console.WriteLine($"[AOP] Performance of RegisterFlagRole({flagName}): {stopwatch.ElapsedMilliseconds}ms");
        }
    }
}