using DRY.DesignPatterns.FactoryPattern.Scenario3.Abstract;

namespace DRY.DesignPatterns.FactoryPattern.Scenario3.Concrete.Implementations.Garanti
{
    public class GarantiPayInputModel : IPayInputModel
    {
        public string OrderNumber { get; set; }
        public string CardNumber { get; set; }
        public decimal Price { get; set; }
    }
}
