namespace CustomIoCContainer
{
    public class ServiceDescriptor
    {
        public ServiceDescriptor(Type serviceType, Type implementationType, ServiceLifetime serviceLifetime)
        {
            this.ServiceType = serviceType;
            this.ImplementationType = implementationType;
            this.ServiceLifetime = serviceLifetime;
        }

        public Type ServiceType { get; set; }

        public Type ImplementationType { get; set; }

        public ServiceLifetime ServiceLifetime { get; set; }
    }
}
