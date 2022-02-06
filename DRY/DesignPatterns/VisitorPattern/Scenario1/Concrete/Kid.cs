using DRY.DesignPatterns.VisitorPattern.Scenario1.Abstract;

namespace DRY.DesignPatterns.VisitorPattern.Scenario1.Concrete
{
    public class Kid : IKid
    {
        public string Name { get; set; }

        public Kid(string name)
        {
            Name = name;
        }

        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
