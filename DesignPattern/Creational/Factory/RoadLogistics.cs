namespace DesignPattern.Creational.Factory;

public class RoadLogistics : ILogistics
{
    public override ITransport CreateTransport()
    {
        return new Truck();
    }
}