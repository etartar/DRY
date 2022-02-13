namespace DRY.DesignPatterns.FactoryPattern.Scenario3.Abstract
{
    public interface IPayInputModel
    {
        string OrderNumber { get; set; }
        string CardNumber { get; set; }
        decimal Price { get; set; }
    }
}
