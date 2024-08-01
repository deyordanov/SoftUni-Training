namespace CustomIoCContainer
{
    public interface IServiceCollection : IList<ServiceDescriptor>
    {
        IServiceCollection AddTransient<TService, TImplementation>()
            where TService : class
            where TImplementation : class, TService;

        IServiceCollection AddSingleton<TService, TImplementation>()
            where TService : class
            where TImplementation : class, TService;

        IServiceProvider BuildServiceProvider();
    }
}
