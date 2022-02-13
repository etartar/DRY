namespace DRY.DesignPatterns.AbstractFactoryPattern.Scenario1.Abstract
{
    public interface ICar
    {
        string Color { get; }
        double Price { get; }
        int ModelYear { get; }
        bool BackupCamera { get; }
        void ShowCarInfo();
    }
}
