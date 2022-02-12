using DRY.DesignPatterns.ChainOfResponsibilityPattern.Scenario1.Abstract;

namespace DRY.DesignPatterns.ChainOfResponsibilityPattern.Scenario1.Concrete
{
    public class RentARoomModel : ITransportObject
    {
        public string Name { get; set; }
        public int RoomNumber { get; set; }
        public int PersonCount { get; set; }
    }
}
