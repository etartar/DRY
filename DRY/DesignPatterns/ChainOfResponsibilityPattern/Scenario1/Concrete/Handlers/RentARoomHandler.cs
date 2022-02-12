using DRY.DesignPatterns.ChainOfResponsibilityPattern.Scenario1.Abstract;
using System;

namespace DRY.DesignPatterns.ChainOfResponsibilityPattern.Scenario1.Concrete.Handlers
{
    public class RentARoomHandler : BaseHandler
    {
        public override ITransportObject Handle(ITransportObject transportObject)
        {
            var rentARoomModel = (RentARoomModel)transportObject;

            /// kullanıcıdan parayı çekip, ilgili odaya kullanıcıyı atama işlemini gerçekleştirip oda kiralama işlemini tamamlama akışını yapıyoruz.

            Console.WriteLine($"Oda Kiralandı : {rentARoomModel.Name} - {rentARoomModel.RoomNumber}");
            return NextChain(transportObject);
        }
    }
}
