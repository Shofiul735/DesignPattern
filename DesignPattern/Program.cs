using DesignPattern.Creational.Builder;
using DesignPattern.Creational.Factory;

#region Builder
Console.WriteLine("###############################");

Console.WriteLine("Builder Pattern started");
BuilderDemo.Run();
Console.WriteLine("Builder Pattern ended");

Console.WriteLine("###############################");
#endregion

#region Factory
Console.WriteLine("");
Console.WriteLine("###############################");
Console.WriteLine("Factory pattern started");
var roadLogistics = new RoadLogistics();
roadLogistics.PlanLogistics();

var seaLogistics = new SeaLogistics();
seaLogistics.PlanLogistics();


Console.WriteLine("Factory pattern ended");
Console.WriteLine("###############################");
#endregion


