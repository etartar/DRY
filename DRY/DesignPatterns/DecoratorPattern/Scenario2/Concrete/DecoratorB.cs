using DRY.DesignPatterns.DecoratorPattern.Scenario2.Abstract;
using System;

namespace DRY.DesignPatterns.DecoratorPattern.Scenario2.Concrete
{
    public class DecoratorB : IComponent
    {
        private IComponent _component;

        public DecoratorB(IComponent component)
        {
            _component = component;
        }

        public double Operation()
        {
            Component newComponent = new Component();

            Console.WriteLine("Ön siparişiniz toplam fiyatı hesaplanıyor...");
            Console.WriteLine("Siparişe ön ek indirim ekleniyor...");
            return newComponent.Operation() - (newComponent.Operation() * 0.15) - (newComponent.Operation() * 0.25);
        }
    }
}
