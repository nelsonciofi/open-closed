// See https://aka.ms/new-console-template for more information
using FullOpenClosed;
using FullOpenClosed.Abstractions;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Shared;
using System.Reflection;

Console.WriteLine("Hello, World!");



var services = new ServiceCollection();

services.AddSingleton<IPaymentProcessSelector, PaymentProcessSelector>();
services.AddSingleton<IPaymentProcessor, PaymentProcessor>();
services.AddSingleton<SingleDependencyBankType>();

var type = typeof(IBankTypePaymentProcessor);
var implementations = Assembly.GetExecutingAssembly().GetTypes()    
    .Where(p => type.IsAssignableFrom(p))
    .Where(p => !p.IsInterface);

foreach (var implementation in implementations)
{ 
    services.Add(new ServiceDescriptor(type, implementation, ServiceLifetime.Singleton));
}


var serviceProvider = services.BuildServiceProvider();


var singleDependencyBankType = serviceProvider.GetRequiredService<SingleDependencyBankType>();
var multiDependencyBankTypes = serviceProvider.GetRequiredService<IPaymentProcessSelector>();


Console.ReadLine();