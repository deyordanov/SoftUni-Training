namespace CustomInversionOfControlContainer
{
    public class ServiceDescriptor
    {
        public ServiceDescriptor(
            Type serviceType,
            Type implementationType,
            ServiceLifetime serviceLifetime)
        {
            this.ServiceType = serviceType;
            this.ImplementationType = implementationType;
            this.ServiceLifetime = serviceLifetime;
        }

        // IEngine
        public Type ServiceType { get; set; }

        // DieselEngine
        public Type ImplementationType { get; set; }

        // Transient
        public ServiceLifetime ServiceLifetime { get; set; }
    }
}
