using DRY.DesignPatterns.VisitorPattern.Scenario1.Abstract;
using System;

namespace DRY.DesignPatterns.VisitorPattern.Scenario1.Concrete
{
    public class Doctor : IVisitor
    {
        public string Name { get; set; }

        public Doctor(string name)
        {
            Name = name;
        }

        public void Visit(IKid element)
        {
            Kid kid = (Kid)element;
            Console.WriteLine($"Doctor : {this.Name} did the health checkup of the child: {kid.Name}");
        }
    }
}
