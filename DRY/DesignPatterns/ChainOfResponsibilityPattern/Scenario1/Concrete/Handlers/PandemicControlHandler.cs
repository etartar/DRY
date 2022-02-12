using DRY.DesignPatterns.ChainOfResponsibilityPattern.Scenario1.Abstract;
using System;

namespace DRY.DesignPatterns.ChainOfResponsibilityPattern.Scenario1.Concrete.Handlers
{
    public class PandemicControlHandler : BaseHandler
    {
        public override ITransportObject Handle(ITransportObject transportObject)
        {
            var rentARoomModel = (RentARoomModel)transportObject;

            /// oda pandemi şartlarını sağlıyor mu, kullanıcının hes kodu sorgulaması gibi işlemleri yapabiliriz.

            Console.WriteLine($"Oda Pandemi için Kontrol Edildi : {rentARoomModel.RoomNumber}");
            return NextChain(transportObject);
        }
    }
}
