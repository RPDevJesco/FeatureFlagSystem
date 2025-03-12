namespace FeatureFlagSystem.Distributed
{
    /// <summary>
    /// Helper for setting up distributed feature flag system
    /// </summary>
    public static class DistributedFeatureFlagSetup
    {
        public static void InitializeDistributed(
            IDistributedCache cache,
            IPubSubService pubSub,
            IFeatureFlagLogger logger = null)
        {
            var storage = new DistributedFeatureFlagStorage(cache);
            var notifier = new DistributedFeatureFlagNotifier(pubSub);
            
            FeatureFlagManager.Initialize(
                storage, 
                logger ?? new ConsoleFeatureFlagLogger(), 
                notifier);
        }
        
        public static void InitializeInMemoryDistributed(
            IFeatureFlagLogger logger = null)
        {
            var cache = new InMemoryDistributedCache();
            var pubSub = new InMemoryPubSubService();
            
            InitializeDistributed(cache, pubSub, logger);
        }
    }
}