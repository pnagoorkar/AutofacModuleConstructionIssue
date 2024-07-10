using Autofac;
using Autofac.Configuration;
using Microsoft.Extensions.Configuration;

var configuration1 = new ConfigurationBuilder().AddJsonFile("settings1.json").Build();
var configuration2 = new ConfigurationBuilder().AddJsonFile("settings2.json").Build();
var configuration3 = new ConfigurationBuilder().AddJsonFile("settings3.json").Build();

var containerBuilder = new ContainerBuilder();
containerBuilder.RegisterModule(new ConfigurationModule(configuration1));
containerBuilder.RegisterModule(new ConfigurationModule(configuration2));
containerBuilder.RegisterModule(new ConfigurationModule(configuration3));
var container = containerBuilder.Build();

Console.ReadLine();
