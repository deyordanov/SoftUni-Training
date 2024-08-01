namespace CustomInversionOfControlContainer
{
    public interface IServiceProvider
    {
        object GetService(Type serviceType);
    }
}
