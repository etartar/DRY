using DRY.DesignPatterns.DecoratorPattern.Scenario2.Abstract;
using System;

namespace DRY.DesignPatterns.DecoratorPattern.Scenario2.Concrete
{
    public class DecoratorA : IComponent
    {
        private IComponent _component;

        public DecoratorA(IComponent component)
        {
            _component = component;
        }

        public double Operation()
        {
            Component newComponent = new Component();

            Console.WriteLine("Ön siparişiniz toplam fiyatı hesaplanıyor...");
            return newComponent.Operation() - newComponent.Operation() * 0.15;
        }
    }
}
