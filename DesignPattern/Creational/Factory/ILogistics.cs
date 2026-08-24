namespace DesignPattern.Creational.Factory;

public interface ILogistics
{
    public void CreateTransport(ITransport transport);
    public void PlanLogistics();
}
