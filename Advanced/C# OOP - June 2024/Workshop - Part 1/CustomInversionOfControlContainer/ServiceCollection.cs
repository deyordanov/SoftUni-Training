namespace CustomInversionOfControlContainer
{
    public class ServiceCollection : List<ServiceDescriptor>, IServiceCollection
    {
        IServiceCollection IServiceCollection.AddSingleton<TService, TImplementation>()
        {
            this.Add(new ServiceDescriptor(typeof(TService), typeof(TImplementation), ServiceLifetime.Singleton));
            return this;
        }

        IServiceCollection IServiceCollection.AddTransient<TService, TImplementation>()
        {
            this.Add(new ServiceDescriptor(typeof(TService), typeof(TImplementation), ServiceLifetime.Transient));
            return this;
        }

        public IServiceProvider BuildServiceProvider()
            => new ServiceProvider(this);
    }
}
