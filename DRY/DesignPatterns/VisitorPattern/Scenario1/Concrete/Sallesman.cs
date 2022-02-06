using DRY.DesignPatterns.VisitorPattern.Scenario1.Abstract;
using System;

namespace DRY.DesignPatterns.VisitorPattern.Scenario1.Concrete
{
    public class Sallesman : IVisitor
    {
        public string Name { get; set; }

        public Sallesman(string name)
        {
            Name = name;
        }

        public void Visit(IKid element)
        {
            Kid kid = (Kid)element;
            Console.WriteLine($"Salesman : {this.Name} gave the school bag to the child : {kid.Name}");
        }
    }
}
