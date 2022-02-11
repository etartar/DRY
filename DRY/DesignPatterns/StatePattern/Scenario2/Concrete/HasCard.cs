using DRY.DesignPatterns.StatePattern.Scenario2.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DRY.DesignPatterns.StatePattern.Scenario2.Concrete
{
    public class HasCard : ATMState
    {
        public override void EjectCard(ATMMachine context)
        {
            Console.WriteLine("Kart çıkarılmıştır.");
            context.State = new NoCard();
        }

        public override void InsertCard(ATMMachine context)
        {
            Console.WriteLine("Aynı anda birden fazla kart takamazsınız.");
        }

        public override void InsertPin(int pin, ATMMachine context)
        {
            if (pin == 1234)
            {
                Console.WriteLine("Pin doğrulandı.");
                context.CorrectPinEntered = true;
                context.State = new HasPin();
            }
            else
            {
                Console.WriteLine("Geçersiz pin girildi.");
                context.CorrectPinEntered = false;
                Console.WriteLine("Kart çıkarılmıştır.");
                context.State = new NoCard();
            }
        }

        public override void RequestCash(int cashToWithDraw, ATMMachine context)
        {
            Console.WriteLine("Lütfen önce pini giriniz.");
        }
    }
}
