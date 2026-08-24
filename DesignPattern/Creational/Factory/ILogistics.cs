namespace DesignPattern.Creational.Factory;

public abstract class ILogistics
{
    public abstract ITransport  CreateTransport();

    public void PlanLogistics()
    {
        var transport = CreateTransport();
        Console.WriteLine(transport.Deliver());
    }
}
