﻿namespace DRY.DesignPatterns.FactoryPattern.Scenario1.Abstract
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
