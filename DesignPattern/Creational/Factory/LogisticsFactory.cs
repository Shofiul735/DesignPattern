namespace DesignPattern.Creational.Factory;

public class LogisticsFactory : ILogistics
{
    public ITransport _creator;
    public void CreateTransport(ITransport transport)
    {
       _creator = transport;
    }

    public void PlanLogistics()
    {
        Console.WriteLine(_creator.Deliver());
    }
}