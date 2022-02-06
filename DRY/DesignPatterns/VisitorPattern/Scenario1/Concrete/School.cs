using DRY.DesignPatterns.VisitorPattern.Scenario1.Abstract;
using System.Collections.Generic;

namespace DRY.DesignPatterns.VisitorPattern.Scenario1.Concrete
{
    public class School
    {
        public IList<IKid> Kids { get; set; }

        public School()
        {
            Kids = new List<IKid>
            {
                new Kid("Ram"),
                new Kid("Sara"),
                new Kid("Pam"),
            };
        }

        public void PerformOperation(IVisitor visitor)
        {
            foreach (var kid in Kids)
                kid.Accept(visitor);
        }
    }
}
