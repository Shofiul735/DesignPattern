namespace DesignPattern.Creational.Factory;

public class SeaLogistics: ILogistics
{
    public override ITransport CreateTransport()
    {
        return new Ship();
    }
}