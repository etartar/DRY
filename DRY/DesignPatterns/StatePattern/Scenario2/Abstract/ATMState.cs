using DRY.DesignPatterns.StatePattern.Scenario2.Concrete;

namespace DRY.DesignPatterns.StatePattern.Scenario2.Abstract
{
    public abstract class ATMState
    {
        public abstract void InsertCard(ATMMachine context);
        public abstract void EjectCard(ATMMachine context);
        public abstract void InsertPin(int pin, ATMMachine context);
        public abstract void RequestCash(int cashToWithDraw, ATMMachine context);
    }
}
