using FollowingDependencyInversion;
using Microsoft.Extensions.DependencyInjection;

IServiceCollection services = new ServiceCollection();
services
    .AddSingleton<Car, Car>()
    .AddTransient<IEngine, DieselEngine>();

IServiceProvider serviceProvider = services.BuildServiceProvider();

IEngine engine1 = serviceProvider.GetRequiredService<IEngine>();
Console.WriteLine(engine1.GetHashCode());

IEngine engine2 = serviceProvider.GetRequiredService<IEngine>();
Console.WriteLine(engine2.GetHashCode());

IEngine engine3 = serviceProvider.GetRequiredService<IEngine>();
Console.WriteLine(engine3.GetHashCode());
