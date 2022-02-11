using DRY.DesignPatterns.StatePattern.Scenario2.Abstract;

namespace DRY.DesignPatterns.StatePattern.Scenario2.Concrete
{
    public class ATMMachine
    {
        private ATMState _state;

        public ATMMachine()
        {
            _state = new NoCard();
        }

        public ATMState State { set => _state = value; }

        public int CashInMachine { get; set; } = 2000;

        public bool CorrectPinEntered { get; set; } = false;

        public void InsertCard() => _state.InsertCard(this);

        public void EjectCard() => _state.EjectCard(this);

        public void InsertPin(int pin) => _state.InsertPin(pin, this);

        public void RequestCache(int cashToWithDraw) => _state.RequestCash(cashToWithDraw, this);
    }
}
