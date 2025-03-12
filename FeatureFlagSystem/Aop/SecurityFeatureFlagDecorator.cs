namespace FeatureFlagSystem.Aop
{
        /// <summary>
    /// Decorator for adding security aspect to feature flag service
    /// </summary>
    public class SecurityFeatureFlagDecorator : IFeatureFlagService
    {
        private readonly IFeatureFlagService _innerService;
        private readonly string _requiredRoleForAdmin;

        public SecurityFeatureFlagDecorator(IFeatureFlagService service, string requiredRoleForAdmin = "Admin")
        {
            _innerService = service;
            _requiredRoleForAdmin = requiredRoleForAdmin;
        }

        public bool IsEnabled(string flagName, UserContext user)
        {
            // Check if the flag exists through read access is generally allowed
            return _innerService.IsEnabled(flagName, user);
        }

        public void SetEnabled(string flagName, bool value)
        {
            // This is security sensitive, so we'll have to pass the user in through another method
            // or ThreadLocal storage in a real implementation
            throw new InvalidOperationException("For security reasons, use SetEnabledWithUser method");
        }

        public void SetEnabledWithUser(string flagName, bool value, UserContext user)
        {
            if (user == null || !user.HasRole(_requiredRoleForAdmin))
            {
                throw new UnauthorizedAccessException(
                    $"User does not have the required role: {_requiredRoleForAdmin}");
            }

            _innerService.SetEnabled(flagName, value);
        }

        public void RegisterFlagRole(string flagName, IFeatureFlagRole role)
        {
            // This is security sensitive too
            throw new InvalidOperationException("For security reasons, use RegisterFlagRoleWithUser method");
        }

        public void RegisterFlagRoleWithUser(string flagName, IFeatureFlagRole role, UserContext user)
        {
            if (user == null || !user.HasRole(_requiredRoleForAdmin))
            {
                throw new UnauthorizedAccessException(
                    $"User does not have the required role: {_requiredRoleForAdmin}");
            }

            _innerService.RegisterFlagRole(flagName, role);
        }
    }
}