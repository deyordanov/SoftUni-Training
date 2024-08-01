using FollowingDependencyInversionPrinciple;
using Microsoft.Extensions.DependencyInjection;

IServiceCollection services = new ServiceCollection();
services.AddTransient<IEngine, ElectricEngine>();

IServiceProvider serviceProvider = services.BuildServiceProvider();

IEngine electricEngine1 = serviceProvider.GetRequiredService<IEngine>();

Car electricCar = new Car(electricEngine1);

IEngine electricEngine2 = serviceProvider.GetRequiredService<IEngine>();
IEngine electricEngine3 = serviceProvider.GetRequiredService<IEngine>();
Console.WriteLine($"Engine 1 - {electricEngine1.GetHashCode()}");
Console.WriteLine($"Engine 2 - {electricEngine2.GetHashCode()}");
Console.WriteLine($"Engine 3 - {electricEngine3.GetHashCode()}");