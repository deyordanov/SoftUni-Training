
using System.Reflection;

namespace CustomIoCContainer
{
    internal class ServiceProvider : IServiceProvider
    {
        private readonly IServiceCollection services;
        private readonly Dictionary<Type, object> singletons;

        public ServiceProvider(IServiceCollection services)
        {
            this.singletons = new();

            this.services = services;
        }

        public object GetService(Type serviceType)
        {
            ServiceDescriptor descriptor = this.services.FirstOrDefault(d => d.ServiceType == serviceType);

            if(descriptor == null)
            {
                throw new InvalidOperationException();
            }

            if (descriptor.ServiceLifetime == ServiceLifetime.Singleton)
            {
                if (!this.singletons.TryGetValue(serviceType, out var service))
                {
                    service = this.CreateInstance(descriptor.ImplementationType);
                    this.singletons[serviceType] = service;
                }

                return service;
            }

            return this.CreateInstance(descriptor.ImplementationType);
        }

        private object CreateInstance(Type type)
        {
            ConstructorInfo constructor = type.GetConstructors()[0];
            ParameterInfo[] parametersInfo = constructor.GetParameters();
            object[] parameters = new object[parametersInfo.Length];

            for(int i = 0; i < parametersInfo.Length; i++)
            {
                parameters[i] = this.GetService(parametersInfo[i].GetType());
            }

            return Activator.CreateInstance(type, parameters);
        }
    }
}
