namespace DesignPattern.Creational.Factory;

public class LogisticsFactory : Logistics
{
    public Transport _creator;
    public void CreateTransport(Transport transport)
    {
       _creator = transport;
    }

    public void PlanLogistics()
    {
        Console.WriteLine(_creator.Deliver());
    }
}