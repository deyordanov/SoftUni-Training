namespace CustomIoCContainer
{
    public class ServiceCollection : List<ServiceDescriptor>, IServiceCollection
    {
        IServiceCollection IServiceCollection.AddSingleton<TService, TImplementation>()
        {
            Add(new ServiceDescriptor(typeof(TService), typeof(TImplementation), ServiceLifetime.Singleton));
            return this;
        }

        IServiceCollection IServiceCollection.AddTransient<TService, TImplementation>()
        {
            Add(new ServiceDescriptor(typeof(TService), typeof(TImplementation), ServiceLifetime.Transient));
            return this;
        }

        public IServiceProvider BuildServiceProvider()
            => new ServiceProvider(this);
    }
}
