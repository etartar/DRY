using DRY.DesignPatterns.StrategyPattern.Scenario1.Abstract;

namespace DRY.DesignPatterns.StrategyPattern.Scenario1.Concrete
{
    public class Context
    {
        private Strategy _strategy;

        public Context(Strategy strategy)
        {
            _strategy = strategy;
        }

        public void ExecuteContext()
        {
            _strategy.AlgorithmInterface();
        }
    }
}
