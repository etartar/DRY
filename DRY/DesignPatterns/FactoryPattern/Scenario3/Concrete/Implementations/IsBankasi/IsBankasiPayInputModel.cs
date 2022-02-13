using DRY.DesignPatterns.FactoryPattern.Scenario3.Abstract;

namespace DRY.DesignPatterns.FactoryPattern.Scenario3.Concrete.Implementations.IsBankasi
{
    public class IsBankasiPayInputModel : IPayInputModel
    {
        public string OrderNumber { get; set; }
        public string CardNumber { get; set; }
        public decimal Price { get; set; }
    }
}
