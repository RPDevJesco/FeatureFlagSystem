namespace FeatureFlagSystem.Aop
{
    /// <summary>
    /// Factory for creating feature flag services with AOP aspects
    /// </summary>
    public static class FeatureFlagServiceFactory
    {
        /// <summary>
        /// Creates a feature flag service with the requested aspects
        /// </summary>
        public static IFeatureFlagService CreateWithAspects(
            IFeatureFlagStorage storage,
            IFeatureFlagLogger logger,
            bool enableLogging = false,
            bool enablePerformance = false,
            bool enableSecurity = false)
        {
            // Create the base service
            IFeatureFlagService service = new FeatureFlagServiceImpl(storage, logger);

            // Apply decorators based on requested aspects
            if (enableSecurity)
            {
                service = new SecurityFeatureFlagDecorator(service);
            }

            if (enablePerformance)
            {
                service = new PerformanceFeatureFlagDecorator(service);
            }

            if (enableLogging)
            {
                service = new LoggingFeatureFlagDecorator(service, logger);
            }

            return service;
        }
    }
}