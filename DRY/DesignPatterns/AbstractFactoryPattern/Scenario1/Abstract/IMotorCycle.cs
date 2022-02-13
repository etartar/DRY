namespace DRY.DesignPatterns.AbstractFactoryPattern.Scenario1.Abstract
{
    public interface IMotorCycle
    {
        string Type { get; }
        string Color { get; }
        double Price { get; }
        int ModelYear { get; }
        void ShowMotorCycleInfo();
    }
}
