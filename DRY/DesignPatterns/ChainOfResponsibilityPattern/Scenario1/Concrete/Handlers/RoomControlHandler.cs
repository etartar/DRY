using DRY.DesignPatterns.ChainOfResponsibilityPattern.Scenario1.Abstract;
using System;

namespace DRY.DesignPatterns.ChainOfResponsibilityPattern.Scenario1.Concrete.Handlers
{
    public class RoomControlHandler : BaseHandler
    {
        public override ITransportObject Handle(ITransportObject transportObject)
        {
            var rentARoomModel = (RentARoomModel)transportObject;

            /// Oda veritabanımız da var mı ? oda kiralamaya uygun mu gibi kontroller yapılabilir.

            Console.WriteLine($"Oda Kontrol Edildi : {rentARoomModel.RoomNumber}");
            return NextChain(transportObject);
        }
    }
}
