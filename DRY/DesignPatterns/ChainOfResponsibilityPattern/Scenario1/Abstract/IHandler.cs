namespace DRY.DesignPatterns.ChainOfResponsibilityPattern.Scenario1.Abstract
{
    public interface IHandler
    {
        ITransportObject Handle(ITransportObject transportObject);
        IHandler SetNext(IHandler handler);
    }
}
