using System;
using System.Collections.Generic;
using System.Threading;
using FeatureFlagSystem;
using FeatureFlagSystem.Aop;
using FeatureFlagSystem.Distributed;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Advanced Feature Flag System Demo");
        Console.WriteLine("================================\n");

        // Demonstrate AOP functionality
        DemoAspectOrientedProgramming();
        
        Console.WriteLine("\n--------------------------------------------------\n");
        
        // Demonstrate distributed functionality
        DemoDistributedFeatureFlags();
        
        Console.WriteLine("\n--------------------------------------------------\n");
        
        // Demonstrate complex conditions and roles
        DemoComplexFeatureFlags();

        Console.WriteLine("\nPress any key to exit.");
        Console.ReadKey();
    }

    static void DemoAspectOrientedProgramming()
    {
        Console.WriteLine("Demonstrating Aspect-Oriented Programming (AOP)");
        Console.WriteLine("---------------------------------------------\n");
        
        // Create base services
        var storage = new InMemoryFlagStorage();
        var logger = new ConsoleFeatureFlagLogger();
        
        // Create service with AOP aspects
        var service = FeatureFlagServiceFactory.CreateWithAspects(
            storage, logger, 
            enableLogging: true, 
            enablePerformance: true, 
            enableSecurity: true);
        
        // Setup some flags
        storage.SetFlagValue("dark_mode", true);
        storage.SetFlagValue("new_dashboard", true);
        
        // Create a test user
        var user = new UserContext
        {
            Id = "user123",
            Email = "user@example.com",
            Roles = new List<string> { "User" }
        };
        
        var adminUser = new UserContext
        {
            Id = "admin789",
            Email = "admin@example.com",
            Roles = new List<string> { "User", "Admin" }
        };
        
        // Check flags (will trigger AOP logging and performance monitoring)
        Console.WriteLine("\nChecking flags with standard user:");
        Console.WriteLine($"  dark_mode: {service.IsEnabled("dark_mode", user)}");
        Console.WriteLine($"  new_dashboard: {service.IsEnabled("new_dashboard", user)}");
        
        // Try to access admin operations from a standard user
        Console.WriteLine("\nTrying to modify flags with standard user (this will throw an exception):");
        try
        {
            // This will fail because it needs admin access
            if (service is SecurityFeatureFlagDecorator securityService)
            {
                securityService.SetEnabledWithUser("dark_mode", false, user);
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"  Exception: {ex.Message}");
        }
        
        // Try again with admin user
        Console.WriteLine("\nModifying flags with admin user:");
        try
        {
            // This should succeed
            if (service is SecurityFeatureFlagDecorator securityService)
            {
                securityService.SetEnabledWithUser("dark_mode", false, adminUser);
                Console.WriteLine("  Flag updated successfully");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"  Exception: {ex.Message}");
        }
        
        // Check the flags again after modification
        Console.WriteLine("\nChecking flags after modification:");
        Console.WriteLine($"  dark_mode: {service.IsEnabled("dark_mode", user)}");
        Console.WriteLine($"  new_dashboard: {service.IsEnabled("new_dashboard", user)}");
    }
    
    static void DemoDistributedFeatureFlags()
    {
        Console.WriteLine("Demonstrating Distributed Feature Flags");
        Console.WriteLine("--------------------------------------\n");
        
        // Setup distributed components
        var cache = new InMemoryDistributedCache();
        var pubSub = new InMemoryPubSubService();
        var storage = new DistributedFeatureFlagStorage(cache);
        var notifier = new DistributedFeatureFlagNotifier(pubSub);
        var logger = new ConsoleFeatureFlagLogger();
        
        // Create two services simulating two different application instances
        var service1 = new FeatureFlagServiceImpl(storage, logger);
        var service2 = new FeatureFlagServiceImpl(storage, logger);
        
        // Subscribe both services to flag changes
        notifier.SubscribeToChanges((flagName, value) =>
        {
            Console.WriteLine($"[Service 1] Received notification: {flagName} = {value}");
            service1.SetEnabled(flagName, value);
        });
        
        notifier.SubscribeToChanges((flagName, value) =>
        {
            Console.WriteLine($"[Service 2] Received notification: {flagName} = {value}");
            service2.SetEnabled(flagName, value);
        });
        
        // Set up initial flags
        service1.SetEnabled("premium_feature", false);
        
        // Create test user
        var user = new UserContext
        {
            Id = "user123",
            Email = "user@example.com"
        };
        
        // Check flags on both services
        Console.WriteLine("\nInitial flag values:");
        Console.WriteLine($"  [Service 1] premium_feature: {service1.IsEnabled("premium_feature", user)}");
        Console.WriteLine($"  [Service 2] premium_feature: {service2.IsEnabled("premium_feature", user)}");
        
        // Update a flag through the notifier
        Console.WriteLine("\nUpdating flag through notifier...");
        notifier.NotifyFlagChange("premium_feature", true);
        
        // Give a moment for notifications to propagate (in a real system, this would be asynchronous)
        Thread.Sleep(100);
        
        // Check flags again on both services
        Console.WriteLine("\nFlag values after notification:");
        Console.WriteLine($"  [Service 1] premium_feature: {service1.IsEnabled("premium_feature", user)}");
        Console.WriteLine($"  [Service 2] premium_feature: {service2.IsEnabled("premium_feature", user)}");
        
        // Demonstrate updating a flag directly and seeing it on another service
        Console.WriteLine("\nUpdating flag directly on Service 1...");
        service1.SetEnabled("new_feature", true);
        
        // Without notification, the other service won't know about it
        Console.WriteLine("\nFlag values after direct update (without notification):");
        Console.WriteLine($"  [Service 1] new_feature: {service1.IsEnabled("new_feature", user)}");
        Console.WriteLine($"  [Service 2] new_feature: {service2.IsEnabled("new_feature", user)}");
    }
    
    static void DemoComplexFeatureFlags()
    {
        Console.WriteLine("Demonstrating Complex Feature Flags");
        Console.WriteLine("----------------------------------\n");
        
        // Create services
        var storage = new InMemoryFlagStorage();
        var logger = new ConsoleFeatureFlagLogger();
        var service = new FeatureFlagServiceImpl(storage, logger);
        
        // Enable all flags at the storage level
        storage.SetFlagValue("simple_flag", true);
        storage.SetFlagValue("admin_only", true);
        storage.SetFlagValue("percentage_rollout", true);
        storage.SetFlagValue("complex_flag", true);
        
        // Create different flag roles
        service.RegisterFlagRole("admin_only", new PermissionFeatureFlag("Admin"));
        
        service.RegisterFlagRole("percentage_rollout", new ExperimentalFeatureFlag(30));
        
        // Create a complex composite flag
        var complexFlag = new CompositeFeatureFlag(
            new ExperimentalFeatureFlag(50),       // 50% of users
            new PermissionFeatureFlag("Premium"),  // Must be Premium
            new TimeBasedCondition(               // Available in a time window
                DateTime.UtcNow.AddMinutes(-10), 
                DateTime.UtcNow.AddMinutes(30)
            )
        );
        service.RegisterFlagRole("complex_flag", complexFlag);
        
        // Create various users to test with
        var regularUser = new UserContext
        {
            Id = "user123",
            Email = "user@example.com",
            Roles = new List<string> { "User" }
        };
        
        var premiumUser = new UserContext
        {
            Id = "premium456",
            Email = "premium@example.com",
            Roles = new List<string> { "User", "Premium" }
        };
        
        var adminUser = new UserContext
        {
            Id = "admin789",
            Email = "admin@example.com",
            Roles = new List<string> { "User", "Admin" }
        };
        
        // Check flags for different users
        Console.WriteLine("\nRegular User:");
        CheckFlagsForUser(service, regularUser);
        
        Console.WriteLine("\nPremium User:");
        CheckFlagsForUser(service, premiumUser);
        
        Console.WriteLine("\nAdmin User:");
        CheckFlagsForUser(service, adminUser);
        
        // Create some users with different IDs to show the percentage rollout
        Console.WriteLine("\nPercentage Rollout for different users:");
        for (int i = 1; i <= 5; i++)
        {
            var testUser = new UserContext
            {
                Id = $"test{i}",
                Email = $"test{i}@example.com",
                Roles = new List<string> { "User" }
            };
            
            bool hasAccess = service.IsEnabled("percentage_rollout", testUser);
            Console.WriteLine($"  User test{i}: {hasAccess}");
        }
    }
    
    static void CheckFlagsForUser(IFeatureFlagService service, UserContext user)
    {
        Console.WriteLine($"User: {user.Email} (Roles: {string.Join(", ", user.Roles)})");
        
        string[] flags = { "simple_flag", "admin_only", "percentage_rollout", "complex_flag" };
        
        foreach (var flag in flags)
        {
            bool isEnabled = service.IsEnabled(flag, user);
            Console.WriteLine($"  - {flag}: {isEnabled}");
        }
    }
}

// Add this class to support the demo
namespace FeatureFlagSystem
{
    /// <summary>
    /// Condition for time-based feature activation
    /// </summary>
    public class TimeBasedCondition : IFeatureFlagRole
    {
        private readonly DateTime _startTime;
        private readonly DateTime? _endTime;
        
        public TimeBasedCondition(DateTime startTime, DateTime? endTime = null)
        {
            _startTime = startTime;
            _endTime = endTime;
        }
        
        public bool Evaluate(UserContext user)
        {
            DateTime now = DateTime.UtcNow;
            return now >= _startTime && (!_endTime.HasValue || now <= _endTime.Value);
        }
    }
}