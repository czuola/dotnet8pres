using Microsoft.Extensions.DependencyInjection;

var serviceCollection = new ServiceCollection();

serviceCollection.AddKeyedSingleton<IService, DefaultService>(KeyedService.AnyKey);
serviceCollection.AddKeyedSingleton<IService, OtherService>("other-service");

var provider = serviceCollection.BuildServiceProvider();

var keyedAny = provider.GetKeyedService<IService>("another-random-key"); // returns defaultService
var keyedOther = provider.GetKeyedService<IService>("other-service"); // returns otherService

Console.WriteLine(keyedAny);
Console.WriteLine(keyedOther);
Console.ReadLine();

interface IService { }
class DefaultService : IService { }
class OtherService : IService { }