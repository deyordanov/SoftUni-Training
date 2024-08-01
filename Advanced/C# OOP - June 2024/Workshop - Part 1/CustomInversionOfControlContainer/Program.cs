using CustomInversionOfControlContainer;
using IServiceProvider = CustomInversionOfControlContainer.IServiceProvider;

IServiceCollection services = new ServiceCollection();

services.AddSingleton<IEngine, DieselEngine>();

IServiceProvider serviceProvider = services.BuildServiceProvider();

IEngine engine1 = (IEngine)serviceProvider.GetService(typeof(IEngine));
engine1.Start();
Console.WriteLine(engine1.GetHashCode());

IEngine engine2 = (IEngine)serviceProvider.GetService(typeof(IEngine));
engine2.Start();
Console.WriteLine(engine2.GetHashCode());

IEngine engine3 = (IEngine)serviceProvider.GetService(typeof(IEngine));
engine3.Start();
Console.WriteLine(engine3.GetHashCode());