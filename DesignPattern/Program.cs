using DesignPattern.Creational.Builder;
using DesignPattern.Creational.Factory;

#region Builder

Console.WriteLine("Creational Design Pattern started.");

Console.WriteLine("Builder Pattern started");
BuilderDemo.Run();
Console.WriteLine("Builder Pattern ended");

Console.WriteLine("Creational Design Pattern ended.");

#endregion

#region Factory
Console.WriteLine("Factory pattern started");
var factory = new LogisticsFactory();
factory.CreateTransport(new Ship());
factory.PlanLogistics();

factory.CreateTransport(new Truck());
factory.PlanLogistics();

Console.WriteLine("Factory pattern ended");
#endregion


