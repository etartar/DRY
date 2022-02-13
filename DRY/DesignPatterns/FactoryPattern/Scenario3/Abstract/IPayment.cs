namespace DRY.DesignPatterns.FactoryPattern.Scenario3.Abstract
{
    public interface IPayment
    {
        IPayOutputModel Pay(IPayInputModel payInputModel);
    }
}
