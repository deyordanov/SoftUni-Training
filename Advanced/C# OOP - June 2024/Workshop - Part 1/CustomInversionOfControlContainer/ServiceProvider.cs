using System.Reflection;

namespace CustomInversionOfControlContainer
{
    internal class ServiceProvider : IServiceProvider
    {
        private readonly IServiceCollection services;
        private readonly Dictionary<Type, object> singletons;

        public ServiceProvider(IServiceCollection services)
        {
            this.singletons = new Dictionary<Type, object>();

            this.services = services;
        }

        // GetService(IEngine);
        public object GetService(Type serviceType)
        {
            // serviceType = IEngine
            ServiceDescriptor? descriptor = this.services.FirstOrDefault(d => d.ServiceType == serviceType);

            if(descriptor == null)
            {
                throw new InvalidOperationException($"The service of type {serviceType.Name} is not registered inside of the container.");
            }

            if(descriptor.ServiceLifetime == ServiceLifetime.Singleton)
            {
                if(!this.singletons.TryGetValue(serviceType, out var implementation))
                {
                    implementation = this.CreateInstace(descriptor.ImplementationType);
                    this.singletons.Add(serviceType, implementation);
                }

                return implementation;
            }

            return this.CreateInstace(descriptor.ImplementationType);
        }

        private object CreateInstace(Type implementationType)
        {
            // implementationType = Car
            ConstructorInfo constructor = implementationType.GetConstructors()[0];
            // Car(IEngine engine)
            ParameterInfo[] parametersInfo = constructor.GetParameters();
            // IEngine
            object[] parametrs = new object[parametersInfo.Length];

            for(int i = 0; i < parametersInfo.Length; i++)
            {
                parametrs[i] = this.GetService(parametersInfo[i].GetType());
            }

            return Activator.CreateInstance(implementationType, parametrs);
        }
    }
}
