// See https://aka.ms/new-console-template for more information
using DemoDesignPattern;
using DemoDesignPattern.Extended;
using Microsoft.Extensions.DependencyInjection;

var serviceProvider = new ServiceCollection()
    .AddSingleton<IMyLogger, MyLogger>()   
    .Decorate<IMyLogger, MyLoggerExtended>()
    .BuildServiceProvider();

var myLogger = serviceProvider
    .GetRequiredService<IMyLogger>();
myLogger.Log("Hello .NET 6 by RiCo");

Console.ReadLine();
