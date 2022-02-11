using DRY.DesignPatterns.DecoratorPattern.Scenario2.Abstract;

namespace DRY.DesignPatterns.DecoratorPattern.Scenario2.Concrete
{
    public class Component : IComponent
    {
        private double _package = 564.23;
        private double _clothes = 98.36;
        private double _mount = 78.52;
        private double _weapon = 108.38;

        public double Operation()
        {
            return _package + _clothes + _mount + _weapon;
        }

        public double Package
        {
            get { return _package; }
        }

        public double Clothes
        {
            get { return _clothes; }
        }

        public double Mount
        {
            get { return _mount; }
        }

        public double Weapon
        {
            get { return _weapon; }
        }
    }
}
