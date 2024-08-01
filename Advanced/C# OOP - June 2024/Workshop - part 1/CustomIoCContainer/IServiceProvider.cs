namespace CustomIoCContainer
{
    public interface IServiceProvider
    {
        object GetService(Type serviceType);
    }
}
