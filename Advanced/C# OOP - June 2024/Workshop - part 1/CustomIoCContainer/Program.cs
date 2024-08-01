using CustomIoCContainer;
using IServiceProvider = CustomIoCContainer.IServiceProvider;

IServiceCollection services = new ServiceCollection();
services.AddTransient<IEngine, DieselEngine>();

IServiceProvider serviceProvider = services.BuildServiceProvider();

IEngine dieselEngine = (IEngine)serviceProvider.GetService(typeof(IEngine));

Car car = new Car(dieselEngine);

car.Engine.Start();