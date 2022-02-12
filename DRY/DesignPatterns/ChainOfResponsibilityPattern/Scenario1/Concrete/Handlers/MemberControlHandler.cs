using DRY.DesignPatterns.ChainOfResponsibilityPattern.Scenario1.Abstract;
using System;

namespace DRY.DesignPatterns.ChainOfResponsibilityPattern.Scenario1.Concrete.Handlers
{
    public class MemberControlHandler : BaseHandler
    {
        public override ITransportObject Handle(ITransportObject transportObject)
        {
            /// Burada ilgili kullanıcı veritabanımız da var mı ?
            /// Kullanıcı oda kiralamaya uygun mu gibi kontrolleri gerçekleştirebiliriz.

            Console.WriteLine($"Üye Kontrol Edildi : {transportObject.Name}");
            return NextChain(transportObject);
        }
    }
}
